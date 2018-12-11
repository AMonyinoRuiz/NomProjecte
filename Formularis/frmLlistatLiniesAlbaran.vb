Imports Infragistics.Win
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet
Imports System.Globalization


Public Class frmLlistatLiniesAlbaran

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

        Util.Cargar_Combo(Me.C_Planta, "SELECT ID_Planta, Descripcion FROM Planta Where Activo=1 and ID_Planta <> 10 ORDER BY Descripcion", True, True)

        If IsNothing(Seguretat.oUser.CampoAux1) = False And IsDBNull(Seguretat.oUser.CampoAux1) = False Then
            Me.C_Planta.Value = Seguretat.oUser.CampoAux1
            If Seguretat.oUser.CampoAux1 = 1 Then
                Me.C_Planta.ReadOnly = False
            Else
                Me.C_Planta.ReadOnly = True
            End If
        End If


        Me.DT_Fin.Value = Now.Date
        Me.DT_Inicio.Value = Now.Date.AddDays(-1)

        Call CargarGrid()

    End Sub

    Private Sub Validar_Click(sender As Object, e As EventArgs) Handles Validar.Click
        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Call CargarGrid()
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
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    
#End Region

#Region "Grid"

    Private Sub CargarGrid()

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

        Dim _Planta As String = ""
        If Me.C_Planta.Value > 0 Then
            _Planta = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA
        End If


        Dim _Where
        If Me.OP.Value = "compra" Then
            If Me.CH_CamionesEntrePlantas.Checked = True Then
                _DTLinies = BD.RetornaDataTable("Select * From C_LCLARIANA_LineasAlbaranCompra_2 where Planta = '" & _Planta & "' and FechaAlbaran between '" & CDate(Me.DT_Inicio.Value) & "' and '" & CDate(Me.DT_Fin.Value) & "' Order by FechaAlbaran", True)
            Else
                _DTLinies = BD.RetornaDataTable("Select * From C_LCLARIANA_LineasAlbaranCompra_2 where RazonSocial <> 'VIUDA DE LAURO CLARIANA, S.L.' and Planta = '" & _Planta & "' and FechaAlbaran between '" & CDate(Me.DT_Inicio.Value) & "' and '" & CDate(Me.DT_Fin.Value) & "' Order by FechaAlbaran", True)
            End If
        Else
            If Me.CH_CamionesEntrePlantas.Checked = True Then
                _DTLinies = BD.RetornaDataTable("Select * From C_LCLARIANA_LineasAlbaranVenta_2 where Planta = '" & _Planta & "' and FechaAlbaran between '" & CDate(Me.DT_Inicio.Value) & "' and '" & CDate(Me.DT_Fin.Value) & "' Order by FechaAlbaran", True)
            Else
                _DTLinies = BD.RetornaDataTable("Select * From C_LCLARIANA_LineasAlbaranVenta_2 where RazonSocial <> 'VIUDA DE LAURO CLARIANA, S.L.' and Planta = '" & _Planta & "' and FechaAlbaran between '" & CDate(Me.DT_Inicio.Value) & "' and '" & CDate(Me.DT_Fin.Value) & "' Order by FechaAlbaran", True)
            End If
        End If



        For Each _DtRow In _DTLinies.Rows
            Call GenerarRow(_DT, _DtRow)
        Next

        Me.GridControl1.DataSource = _DT

    End Sub

    Private Sub GenerarRow(ByRef pDT As DataTable, ByRef pOldRow As DataRow)

        Dim _NewRow As DataRow
        _NewRow = pDT.NewRow
        _NewRow("DataDadquisicio") = pOldRow.Item("FechaAlbaran")
        _NewRow("DescripcioMaterial") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("DescripcionArticulo")))

        If pOldRow.Item("UnidadMedida") = "1" Then
            _NewRow("Quantitat") = pOldRow.Item("Unidades")
            '_NewRow("Pes") = ""
        Else
            '_NewRow("Quantitat") = ""
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


        _NewRow("Domicili") = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(pOldRow.Item("Domicilio") & ", " & pOldRow.Item("Municipio")))
        _NewRow("NumDocument") = pOldRow.Item("CifEuropeo")

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

        _NewRow("NumRegistro") = pOldRow.Item("Num_del_registre")

        pDT.Rows.Add(_NewRow)

        'para hacer el numero de registro consecutivo
        _NumRegistroParaTabla = _NumRegistroParaTabla + 1

    End Sub

#End Region

End Class