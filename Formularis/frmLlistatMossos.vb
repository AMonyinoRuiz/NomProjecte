Imports Infragistics.Win
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet
Imports System.Globalization


Public Class frmLlistatMossos

    Dim _DTC As New DTCDataContext(BD.Conexion)
    Dim _Missatge_contador As Integer
    Dim _NumRegistroParaTabla As Integer = 0
    Dim _AdrecaPlanta As String
    Dim _LocalitatPlanta As String
    Dim _Tel As String
    Dim _Email As String

#Region "M_ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada()
        Me.AplicarDisseny()

        Util.Cargar_Combo(Me.C_Planta, "SELECT ID_Planta, Descripcion FROM Planta Where Activo=1 and ID_Planta <> 10 ORDER BY Descripcion", True)

        If IsNothing(Seguretat.oUser.CampoAux1) = False And IsDBNull(Seguretat.oUser.CampoAux1) = False Then
            Me.C_Planta.Value = Seguretat.oUser.CampoAux1
            If Seguretat.oUser.CampoAux1 = 1 Then
                Me.C_Planta.ReadOnly = False
            Else
                Me.C_Planta.ReadOnly = True
            End If
        End If

        Me.T_Num.Value = 0
        Me.DT_Fin.Value = Now.Date
        Me.DT_Inicio.Value = Now.Date.AddDays(-1)
        Me.TE_RutaExportacio.Value = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Seguretat.oUser.CampoAux1)).FirstOrDefault.RutaExportacio
        Me.TE_RutaExportacio.ButtonsRight("Lupeta").Enabled = True

        _Missatge_contador = 0

        _AdrecaPlanta = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Seguretat.oUser.CampoAux1)).FirstOrDefault.Direccio
        _LocalitatPlanta = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Seguretat.oUser.CampoAux1)).FirstOrDefault.Poblacio
        _Tel = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Seguretat.oUser.CampoAux1)).FirstOrDefault.Telefon
        _Email = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Seguretat.oUser.CampoAux1)).FirstOrDefault.Email

        Call CargarGrid()

    End Sub

    Private Sub Validar_Click(sender As Object, e As EventArgs) Handles Validar.Click
        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Call CargarGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.TE_RutaExportacio.Text = "" Then
            Mensaje.Mostrar_Mensaje("No puedes crear el excel de los Mossos si no hay una ruta d'exportación", M_Mensaje.Missatge_Modo.ERRORS, , , True)
            Exit Sub
        End If

        If IsNothing(_AdrecaPlanta) = True Or IsNothing(_LocalitatPlanta) = True Or IsNothing(_Tel) = True Or IsNothing(_Email) = True Then
            Mensaje.Mostrar_Mensaje("No se puede exportar, no se han introducido los datos de la planta", M_Mensaje.Missatge_Modo.ERRORS, , , True)
            Exit Sub
        End If

        Util.WaitFormObrir()

        Call CargarGrid()

        '**** per averiguar el num primer i ultim
        Dim _Valor_uno As Integer
        Dim _Valor_dos As Integer

        _Valor_uno = Me.GridView1.GetRowCellValue(0, "NumRegistro").ToString
        _Valor_dos = Me.GridView1.GetRowCellValue(Me.GridView1.RowCount - 1, "NumRegistro").ToString
        '**** per averiguar el num primer i ultim

        Dim _NomArxiu As String = "Vda Lauro Clariana-Setmana " & DatePart(DateInterval.WeekOfYear, Me.DT_Inicio.Value, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek) & "-" & CDate(Me.DT_Inicio.Value).Year & "-registres-" & _Valor_uno & "-" & _Valor_dos

        If System.IO.File.Exists(Me.TE_RutaExportacio.Text & "\" & _NomArxiu & ".xls") = True Then
            'Mensaje.Mostrar_Mensaje("El archivo que pretende crear ya existe, intentelo de nuevo mas tarde", M_Mensaje.Missatge_Modo.ERRORS, , , True)
            'Exit Sub
            Kill(Me.TE_RutaExportacio.Text & "\" & _NomArxiu & ".xls")
        End If

        'Creem l'arxiu necesari a la carpeta de destí especificada
        If OP2.Value = "oficial" Then
            System.IO.File.Copy("Extras\LlistatMossos.xls", Me.TE_RutaExportacio.Text & "\" & _NomArxiu & ".xls")
        Else
            If OP2.Value = "generico" Then
                System.IO.File.Copy("Extras\LlistatMossosGeneric.xls", Me.TE_RutaExportacio.Text & "\" & _NomArxiu & ".xls")
            Else
                If OP2.Value = "guardia_civil" Then
                    System.IO.File.Copy("Extras\LlistatMossosGuardiaCivil.xls", Me.TE_RutaExportacio.Text & "\" & _NomArxiu & ".xls")
                End If
            End If
        End If


        Me.GridView1.OptionsPrint.AutoWidth = False

        DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG

        Dim _App As New Microsoft.Office.Interop.Excel.Application
        Dim _WB As Microsoft.Office.Interop.Excel.Workbook = _App.Workbooks.Open(Me.TE_RutaExportacio.Text & "\" & _NomArxiu & ".xls")
        Dim _WS As Microsoft.Office.Interop.Excel.Worksheet = _WB.Sheets.Item(1)

        '_WS.Range

        For _Files As Integer = 3 To Me.GridView1.RowCount + 2
            For _Columnes As Integer = 1 To Me.GridView1.Columns.Count - 1

                Dim _NomColumna As String = Me.GridView1.Columns(_Columnes).Name
                Dim _Valor As String = GridView1.GetRowCellValue(_Files - 3, _NomColumna).ToString

                If (_NomColumna = "DataDadquisicio" Or _NomColumna = "DataNaixement") And _Valor <> "" Then
                    _Valor = CDate(_Valor.Substring(0, 10))
                    _WS.Cells(_Files, _Columnes) = CDate(_Valor.Substring(0, 10))
                Else
                    _WS.Cells(_Files, _Columnes) = _Valor
                End If
            Next
        Next

        'Dim _ColumnaQueNoImportem As Integer = 0
        'If OP.Value = "albaran" Then
        '    _ColumnaQueNoImportem = 3
        'Else
        '    If OP.Value = "registro" Then
        '        _ColumnaQueNoImportem = 4
        '    End If
        'End If

        'For _Files As Integer = 3 To Me.GridView1.RowCount + 2
        '    For _Columnes As Integer = 1 To Me.GridView1.Columns.Count - 1
        '        If _Columnes > _ColumnaQueNoImportem Then
        '            Dim _NomColumna As String = Me.GridView1.Columns(_Columnes).Name
        '            Dim _Valor As String = GridView1.GetRowCellValue(_Files - 3, _NomColumna).ToString

        '            If (_NomColumna = "DataDadquisicio" Or _NomColumna = "DataNaixement") And _Valor <> "" Then
        '                _Valor = CDate(_Valor.Substring(0, 10))
        '                _WS.Cells(_Files, _Columnes - 1) = CDate(_Valor.Substring(0, 10))
        '            Else
        '                _WS.Cells(_Files, _Columnes - 1) = _Valor
        '            End If
        '        End If

        '        If _Columnes < _ColumnaQueNoImportem Then
        '            Dim _NomColumna As String = Me.GridView1.Columns(_Columnes).Name
        '            Dim _Valor As String = GridView1.GetRowCellValue(_Files - 3, _NomColumna).ToString

        '            If (_NomColumna = "DataDadquisicio" Or _NomColumna = "DataNaixement") And _Valor <> "" Then
        '                _Valor = CDate(_Valor.Substring(0, 10))
        '                _WS.Cells(_Files, _Columnes) = CDate(_Valor.Substring(0, 10))
        '            Else
        '                _WS.Cells(_Files, _Columnes) = _Valor
        '            End If
        '        End If
        '    Next
        'Next




            _WB.Save()
            _WB.Close()
            _App.Quit()
            _App = Nothing
            _WB = Nothing
            _WS = Nothing


            Util.WaitFormTancar()
            Mensaje.Mostrar_Mensaje("Exportacion realizada con éxito", M_Mensaje.Missatge_Modo.INFORMACIO, , , False)
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                'oClsControls.ControlBuit(.TE_Codigo)
                oClsControls.ControlBuit(.DT_Inicio)
                oClsControls.ControlBuit(.DT_Fin)
                oClsControls.ControlBuit(.C_Planta)
                oClsControls.ControlBuit(.T_Num)
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Private Sub TE_RutaExportacio_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles TE_RutaExportacio.EditorButtonClick
        If e.Button.Key = "Lupeta" Then
            Dim Dialog As New System.Windows.Forms.FolderBrowserDialog
            If Dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Me.TE_RutaExportacio.Text = Dialog.SelectedPath
                Catch oerr As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub TE_RutaExportacio_ValueChanged(sender As Object, e As EventArgs) Handles TE_RutaExportacio.ValueChanged
        If Me.TE_RutaExportacio.Value <> "" And Me.TE_RutaExportacio.Value <> "TE_RutaExportacio" Then

            Dim oLinqPlanta As Planta
            oLinqPlanta = (From taula In _DTC.Planta Where taula.ID_Planta = CInt(Seguretat.oUser.CampoAux1) Select taula).FirstOrDefault
            oLinqPlanta.RutaExportacio = Me.TE_RutaExportacio.Value

            _DTC.SubmitChanges()

        End If
    End Sub

#End Region

#Region "Altres events"
    Private Sub OP_ValueChanged(sender As Object, e As EventArgs) Handles OP.ValueChanged
        If OP.Value = "albaran" Then
            Me.T_Num.ReadOnly = True
        Else
            If OP.Value = "registro" Then
                Me.T_Num.ReadOnly = False
            End If
        End If
    End Sub

#End Region

#Region "Grid"

    Private Sub CargarGrid()

        _NumRegistroParaTabla = Me.T_Num.Value
        _Missatge_contador = 0

        Dim _DT As New DataTable 'CReeem les columnes

        _DT.Columns.Add("Cif", GetType(String))
        _DT.Columns.Add("NomEstabliment", GetType(String))
        _DT.Columns.Add("Adreca", GetType(String))
        _DT.Columns.Add("Localitat", GetType(String))
        _DT.Columns.Add("TelContacte", GetType(String))
        _DT.Columns.Add("AdrecaElectronica", GetType(String))
        _DT.Columns.Add("DataDadquisicio", GetType(Date))
        _DT.Columns.Add("DescripcioMaterial", GetType(String))
        _DT.Columns.Add("Quantitat", GetType(Integer))
        _DT.Columns.Add("Pes", GetType(Double))
        _DT.Columns.Add("NomVenedor", GetType(String))
        _DT.Columns.Add("PrimerCognom", GetType(String))
        _DT.Columns.Add("SegonCognom", GetType(String))
        _DT.Columns.Add("DataNaixement", GetType(Date))
        _DT.Columns.Add("Nacionalitat", GetType(String))
        _DT.Columns.Add("Domicili", GetType(String))
        _DT.Columns.Add("NumDocument", GetType(String))
        _DT.Columns.Add("TipusVehicle", GetType(String))
        _DT.Columns.Add("Marca", GetType(String))
        _DT.Columns.Add("Model", GetType(String))
        _DT.Columns.Add("Matricula", GetType(String))
        _DT.Columns.Add("NumRegistro", GetType(Integer))

        Me.GridControl1.DataSource = Nothing

        Dim _DTLinies As DataTable


        Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA

        If Me.CH_CamionesEntrePlantas.Checked = True Then
            _DTLinies = BD.RetornaDataTable("Select * From C_LCLARIANA_LlistatMossos where Planta = '" & _Planta & "' and FechaAlbaran between '" & CDate(Me.DT_Inicio.Value) & "' and '" & CDate(Me.DT_Fin.Value) & "' Order by FechaAlbaran", True)
        Else
            _DTLinies = BD.RetornaDataTable("Select * From C_LCLARIANA_LlistatMossos where RazonSocial <> 'VIUDA DE LAURO CLARIANA, S.L.' and RazonSocial not like '%VIUDA%' and Planta = '" & _Planta & "' and FechaAlbaran between '" & CDate(Me.DT_Inicio.Value) & "' and '" & CDate(Me.DT_Fin.Value) & "' Order by FechaAlbaran", True)
        End If


        For Each _DtRow In _DTLinies.Rows
            Call GenerarRow(_DT, _DtRow)
        Next

        Me.GridControl1.DataSource = _DT

        If CH_VisualizarColumnas.Checked = True Then
            Me.GridView1.Columns("Cif").Visible = True
            Me.GridView1.Columns("NomEstabliment").Visible = True
            Me.GridView1.Columns("Adreca").Visible = True
            Me.GridView1.Columns("Localitat").Visible = True
            Me.GridView1.Columns("TelContacte").Visible = True
            Me.GridView1.Columns("AdrecaElectronica").Visible = True
        Else
            Me.GridView1.Columns("Cif").Visible = False
            Me.GridView1.Columns("NomEstabliment").Visible = False
            Me.GridView1.Columns("Adreca").Visible = False
            Me.GridView1.Columns("Localitat").Visible = False
            Me.GridView1.Columns("TelContacte").Visible = False
            Me.GridView1.Columns("AdrecaElectronica").Visible = False
        End If

        If _Missatge_contador > 0 Then
            Mensaje.Mostrar_Mensaje("Existen " & _Missatge_contador & " campos en el listado escritos incorrectamente", M_Mensaje.Missatge_Modo.ERRORS, , , True)
        End If

    End Sub

    Private Sub GenerarRow(ByRef pDT As DataTable, ByRef pOldRow As DataRow)

        Dim _NewRow As DataRow
        _NewRow = pDT.NewRow
        _NewRow("Cif") = "B60156163"
        _NewRow("NomEstabliment") = "Vda.Lauro Clariana.,s.l."
        _NewRow("Adreca") = _AdrecaPlanta
        _NewRow("Localitat") = _LocalitatPlanta
        _NewRow("TelContacte") = _Tel
        _NewRow("AdrecaElectronica") = _Email
        _NewRow("DataDadquisicio") = pOldRow.Item("FechaAlbaran")
        _NewRow("DescripcioMaterial") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("DescripcionArticulo")))

        If pOldRow.Item("UnidadMedida") = "1" Then
            _NewRow("Quantitat") = pOldRow.Item("Unidades")
            _NewRow("Pes") = pOldRow.Item("Talla")
        Else
            _NewRow("Quantitat") = pOldRow.Item("Talla")
            _NewRow("Pes") = pOldRow.Item("Unidades")
        End If

        If IsDBNull(pOldRow.Item("FechaNacimiento")) = True Then
            _NewRow("NomVenedor") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("RazonSocial")))
            _NewRow("PrimerCognom") = ""
            _NewRow("SegonCognom") = ""
        Else
            _NewRow("NomVenedor") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("NombrePersona")))
            _NewRow("PrimerCognom") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("PrimerApellido")))
            _NewRow("SegonCognom") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("SegundoApellido")))
        End If
        _NewRow("DataNaixement") = pOldRow.Item("FechaNacimiento")


        'EN CASTELLA O CALATA SEGONS EL EXCEL QUE VOLEM EXPORTAR******
        If OP2.Value = "oficial" Or OP2.Value = "generico" Then
            If IsDBNull(pOldRow.Item("Nacion")) = False And IsNothing(pOldRow.Item("Nacion")) = False Then
                Select Case pOldRow.Item("Nacion")
                    Case "ESPAÑA"
                        _NewRow("Nacionalitat") = "Espanya"
                    Case "FRANCIA"
                        _NewRow("Nacionalitat") = "França"
                    Case "ECUADOR(Inc.GALAPAGOS)"
                        _NewRow("Nacionalitat") = "Equador"
                    Case "MARRUECOS"
                        _NewRow("Nacionalitat") = "Marroc"
                    Case "GAMBIA"
                        _NewRow("Nacionalitat") = "Gàmbia"
                    Case "ALEMANIA"
                        _NewRow("Nacionalitat") = "Alemània"
                    Case Else
                        _NewRow("Nacionalitat") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("Nacion")))
                End Select
            Else
                _NewRow("Nacionalitat") = ""
            End If
        Else
            If OP2.Value = "guardia_civil" Then
                If IsDBNull(pOldRow.Item("Nacion")) = False And IsNothing(pOldRow.Item("Nacion")) = False Then
                    Select Case pOldRow.Item("Nacion")
                        Case "ESPAÑA"
                            _NewRow("Nacionalitat") = "España"
                        Case "FRANCIA"
                            _NewRow("Nacionalitat") = "Francia"
                        Case "ECUADOR(Inc.GALAPAGOS)"
                            _NewRow("Nacionalitat") = "Ecuador"
                        Case "MARRUECOS"
                            _NewRow("Nacionalitat") = "Marruecos"
                        Case "GAMBIA"
                            _NewRow("Nacionalitat") = "Gambia"
                        Case "ALEMANIA"
                            _NewRow("Nacionalitat") = "Alemania"
                        Case Else
                            _NewRow("Nacionalitat") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("Nacion")))
                    End Select
                Else
                    _NewRow("Nacionalitat") = ""
                End If
            End If
        End If
        'EN CASTELLA O CALATA SEGONS EL EXCEL QUE VOLEM EXPORTAR******


        _NewRow("Domicili") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("Domicilio") & ", " & pOldRow.Item("Municipio")))
        _NewRow("NumDocument") = pOldRow.Item("CifEuropeo")

        'EN CASTELLA O CALATA SEGONS EL EXCEL QUE VOLEM EXPORTAR******
        If OP2.Value = "oficial" Or OP2.Value = "generico" Then
            If IsDBNull(pOldRow.Item("TipoVehiculo")) = False And IsNothing(pOldRow.Item("TipoVehiculo")) = False Then
                Select Case pOldRow.Item("TipoVehiculo")
                    Case "CAMIÓN"
                        _NewRow("TipusVehicle") = "Camió"
                    Case "TURISMO"
                        _NewRow("TipusVehicle") = "Turisme"
                    Case Else
                        _NewRow("TipusVehicle") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("TipoVehiculo")))
                End Select
            Else
                _NewRow("TipusVehicle") = ""
            End If
        Else
            If OP2.Value = "guardia_civil" Then
                If IsDBNull(pOldRow.Item("TipoVehiculo")) = False And IsNothing(pOldRow.Item("TipoVehiculo")) = False Then
                    Select Case pOldRow.Item("TipoVehiculo")
                        Case "CAMIÓN"
                            _NewRow("TipusVehicle") = "Camión"
                        Case "TURISMO"
                            _NewRow("TipusVehicle") = "Turismo"
                        Case Else
                            _NewRow("TipusVehicle") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("TipoVehiculo")))
                    End Select
                Else
                    _NewRow("TipusVehicle") = ""
                End If
            End If
        End If
        'EN CASTELLA O CALATA SEGONS EL EXCEL QUE VOLEM EXPORTAR******

        If IsDBNull(pOldRow.Item("MarcaVehiculo")) = False And IsNothing(pOldRow.Item("MarcaVehiculo")) = False Then
            _NewRow("Marca") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("MarcaVehiculo")))
        Else
            _NewRow("Marca") = ""
        End If

        If IsDBNull(pOldRow.Item("Modelo")) = False And IsNothing(pOldRow.Item("Modelo")) = False Then
            _NewRow("Model") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("Modelo")))
        Else
            _NewRow("Model") = ""
        End If

        If IsDBNull(pOldRow.Item("Matricula")) = False And IsNothing(pOldRow.Item("Matricula")) = False Then
            _NewRow("Matricula") = Replace(pOldRow.Item("Matricula"), "-", "")
        Else
            _NewRow("Matricula") = ""
        End If


        If OP.Value = "albaran" Then
            _NewRow("NumRegistro") = pOldRow.Item("Num_del_registre")
        Else
            If OP.Value = "registro" Then
                _NewRow("NumRegistro") = _NumRegistroParaTabla
            End If
        End If

        pDT.Rows.Add(_NewRow)

        'para hacer el numero de registro consecutivo
        _NumRegistroParaTabla = _NumRegistroParaTabla + 1

    End Sub

    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender

        'EN CASTELLA O CALATA SEGONS EL EXCEL QUE VOLEM EXPORTAR******
        If OP2.Value = "oficial" Or OP2.Value = "generico" Then
            If e.Column.FieldName = "TipusVehicle" Then
                Dim valor As String = UCase(View.GetRowCellDisplayText(e.RowHandle, View.Columns("TipusVehicle")))
                If valor <> "CAMIÓ" And valor <> "CICLOMOTOR" And valor <> "FURGONETA" And valor <> "MOTOCICLETA" And valor <> "TURISME" Then
                    e.Appearance.BackColor = Color.LightCoral
                    _Missatge_contador = _Missatge_contador + 1
                End If
            End If

            If e.Column.FieldName = "Nacionalitat" Then
                Dim valor As String = UCase(View.GetRowCellDisplayText(e.RowHandle, View.Columns("Nacionalitat")))
                If valor <> "ESPANYA" And valor <> "FRANÇA" And valor <> "PAKISTAN" And valor <> "MALI" And valor <> "EQUADOR" And valor <> "GÀMBIA" And valor <> "MARROC" Then
                    e.Appearance.BackColor = Color.LightCoral
                    _Missatge_contador = _Missatge_contador + 1
                End If
            End If
        Else
            If OP2.Value = "guardia_civil" Then
                If e.Column.FieldName = "TipusVehicle" Then
                    Dim valor As String = UCase(View.GetRowCellDisplayText(e.RowHandle, View.Columns("TipusVehicle")))
                    If valor <> "CAMIÓN" And valor <> "CICLOMOTOR" And valor <> "FURGONETA" And valor <> "MOTOCICLETA" And valor <> "TURISMO" Then
                        e.Appearance.BackColor = Color.LightCoral
                        _Missatge_contador = _Missatge_contador + 1
                    End If
                End If

                If e.Column.FieldName = "Nacionalitat" Then
                    Dim valor As String = UCase(View.GetRowCellDisplayText(e.RowHandle, View.Columns("Nacionalitat")))
                    If valor <> "ESPAÑA" And valor <> "FRANCIA" And valor <> "PAKISTAN" And valor <> "MALI" And valor <> "ECUADOR" And valor <> "GAMBIA" And valor <> "MARRUECOS" Then
                        e.Appearance.BackColor = Color.LightCoral
                        _Missatge_contador = _Missatge_contador + 1
                    End If
                End If
            End If
        End If
        'EN CASTELLA O CALATA SEGONS EL EXCEL QUE VOLEM EXPORTAR******



    End Sub

#End Region

End Class