Imports Infragistics.Win
Imports System.IO
Imports System.Text
Imports Infragistics.Win.UltraWinGrid


Public Class frmMovimientosBancarios
    Dim _DTC As New DTCDataContext(BD.Conexion)

#Region "M_ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub


#End Region

#Region "Metodes"

    Public Sub Entrada()
        Me.AplicarDisseny()

        Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = True

        'Util.Cargar_Combo(Me.C_BancoCC, "SELECT ID_BancoCC, ((Select Descripcion from Banco where banco.ID_Banco = BancoCC.ID_Banco) + ' - ' + bancoCC.Descripcion) as Descripcion FROM BancoCC Where Activo=1 ORDER BY Descripcion", True, True)
        'Util.Cargar_Combo(Me.C_BancoCC, "SELECT ID_BancoCC, Alias FROM BancoCC Where Activo=1 ORDER BY Alias", True, True, "TODOS")
        Util.Cargar_Combo(Me.C_BancoCC, "Select  '@' +  CONVERT(varchar(10), ID_Banco) as ID_Banco, Descripcion + ' * Todo' as descrip from Banco Where Activo=1 union all SELECT CONVERT(varchar(10), ID_BancoCC), Alias as descrip FROM BancoCC Where Activo=1 ", True, True)

        Me.DT_Inicio.Value = Now.Date.AddDays(-1)
        Me.DT_Fin.Value = Now.Date.AddDays(-1)

        Call BuscarLlistat()

    End Sub

    Private Sub BuscarLlistat()
        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Dim _DT As New DataTable 'CReeem les columnes

        _DT.Columns.Add("ID_BancoMovimiento", GetType(Integer))
        _DT.Columns.Add("ID_BancoCC", GetType(Integer))
        _DT.Columns.Add("ID_Banco", GetType(Integer))
        _DT.Columns.Add("BancoCC", GetType(String))
        _DT.Columns.Add("Banco", GetType(String))
        _DT.Columns.Add("Fecha", GetType(Date))
        _DT.Columns.Add("FechaValor", GetType(Date))
        _DT.Columns.Add("Importe", GetType(Decimal))
        _DT.Columns.Add("Saldo", GetType(Decimal))
        _DT.Columns.Add("Concepto", GetType(String))

        Dim _ValorsGrid As DataTable

        If CStr(Me.C_BancoCC.Value).Substring(0, 1).Equals("@") = False AndAlso Me.C_BancoCC.Value = 0 Then
            _ValorsGrid = BD.RetornaDataTable("Select * From C_BancoMovimientos where Fecha BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' order by ID_Banco, ID_BancoMovimientos desc")
        Else
            If Me.C_BancoCC.Value.Substring(0, 1).Equals("@") = True Then
                _ValorsGrid = BD.RetornaDataTable("Select * From C_BancoMovimientos where Fecha BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' and ID_Banco = " & CInt(Me.C_BancoCC.Value.Substring(1, 1)) & " order by ID_Banco, ID_BancoMovimientos desc")
            Else
                _ValorsGrid = BD.RetornaDataTable("Select * From C_BancoMovimientos where Fecha BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' and ID_BancoCC = " & Me.C_BancoCC.Value & " order by ID_Banco, ID_BancoMovimientos desc")
            End If
        End If


        Me.GRD.M.clsUltraGrid.Cargar(_ValorsGrid)
        Me.GRD.M_Editable()

        Dim _pCol As UltraGridColumn
        For Each _pCol In Me.GRD.GRID.DisplayLayout.Bands(0).Columns
            If _pCol.Key <> "DescripcionPersonalizada" Then
                _pCol.CellActivation = Activation.NoEdit
            End If
        Next

        'agrupacio per la columna cuenta corriente

        Me.GRD.M_TreureFocus()
        Me.GRD.GRID.ActiveRow = Nothing
        Me.GRD.GRID.Selected.Rows.Clear()
        Me.GRD.GRID.ActiveCell = Nothing

        If Me.GRD.GRID.Rows.Count > 0 Then
            If CStr(Me.C_BancoCC.Value).Substring(0, 1).Equals("@") = True OrElse Me.C_BancoCC.Value = 0 Then
                Me.GRD.GRID.DisplayLayout.Bands(0).ClearGroupByColumns()
                Me.GRD.GRID.DisplayLayout.Bands(0).Columns(21).GroupByMode = GroupByMode.Default
                Me.GRD.GRID.DisplayLayout.Bands(0).SortedColumns.Add(Me.GRD.GRID.DisplayLayout.Bands(0).Columns(21), False, True)
                Me.GRD.GRID.Rows.ExpandAll(True)
                Me.GRD.M_TreureFocus()
            Else
                Me.GRD.GRID.DisplayLayout.Bands(0).Columns("Alias").Hidden = True
            End If
        End If

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Validar.Click
        Call BuscarLlistat()
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                'oClsControls.ControlBuit(.TE_Codigo)
                oClsControls.ControlBuit(.C_BancoCC)
                oClsControls.ControlBuit(.DT_Inicio)
                oClsControls.ControlBuit(.DT_Fin)
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

#End Region

#Region "Altres events"
    Private Sub B_Importar_Click(sender As Object, e As EventArgs) Handles B_Importar.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "All Files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim objReader As New StreamReader(openFileDialog1.FileName, Encoding.Default)
                If (objReader IsNot Nothing) Then

                    Util.WaitFormObrir()

                    Dim _CuentasNoIntroducidasEnElPrograma(10) As String
                    Dim _ContadorDeContes As Integer = 0

                    Dim _Linia As String = ""
                    'Dim _LlistaMovimientos As New ArrayList()
                    'Dim _LlistaMovimientosComplementos As New ArrayList()
                    'Dim _FilaNumeroUno As String = ""
                    'Dim _ContFiles As Integer = 0

                    Dim _CC As String
                    Dim _Fecha As Date
                    Dim _FechaValor As Date
                    Dim _Importe As Decimal
                    Dim _Concepto As String
                    Dim _Saldo As Decimal
                    Dim _ConceptoComplementario1 As String
                    Dim _ConceptoComplementario2 As String
                    Dim _ConceptoComplementario3 As String
                    Dim _ConceptoComplementario4 As String
                    Dim _ConceptoComplementario5 As String
                    Dim _ConceptoComplementario6 As String
                    Dim _ConceptoComplementario7 As String
                    Dim _ConceptoComplementario8 As String
                    Dim _ConceptoComplementario9 As String
                    Dim _ConceptoComplementario10 As String
                    Dim _ConceptoComplementario11 As String

                    Dim _TenimTotesLesDades As Boolean = False
                    Dim _UpdateDades As Boolean = False
                    Dim _UpdateDadesID As Integer = 0

                    Do
                        _Linia = objReader.ReadLine()

                        If Not _Linia Is Nothing AndAlso _Linia.Length > 2 Then
                            Select Case _Linia.Substring(0, 2)
                                Case "11"
                                    'Neteja de variables
                                    _CC = ""
                                    _Fecha = Nothing
                                    _FechaValor = Nothing
                                    _Importe = 0
                                    _Concepto = ""
                                    _Saldo = 0
                                    _UpdateDadesID = 0

                                    _CC = _Linia.Substring(2, 18)
                                    If _Linia.Substring(32, 1) = 1 Then
                                        _Saldo = CDbl("-" & _Linia.Substring(33, 12) & "," & _Linia.Substring(45, 2))
                                    Else
                                        _Saldo = CDbl(_Linia.Substring(33, 12) & "," & _Linia.Substring(45, 2))
                                    End If
                                    _TenimTotesLesDades = False
                                    _UpdateDades = False
                                Case "22"
                                    _Fecha = New Date("20" & _Linia.Substring(10, 2), _Linia.Substring(12, 2), _Linia.Substring(14, 2))
                                    _FechaValor = New Date("20" & _Linia.Substring(16, 2), _Linia.Substring(18, 2), _Linia.Substring(20, 2))
                                    If _Linia.Substring(27, 1) = 1 Then
                                        _Importe = CDbl("-" & _Linia.Substring(28, 12) & "," & _Linia.Substring(40, 2))
                                    Else
                                        _Importe = CDbl(_Linia.Substring(28, 12) & "," & _Linia.Substring(40, 2))
                                    End If
                                    _ConceptoComplementario1 = ""
                                    _ConceptoComplementario2 = ""
                                    _ConceptoComplementario3 = ""
                                    _ConceptoComplementario4 = ""
                                    _ConceptoComplementario5 = ""
                                    _ConceptoComplementario6 = ""
                                    _ConceptoComplementario7 = ""
                                    _ConceptoComplementario8 = ""
                                    _ConceptoComplementario9 = ""
                                    _ConceptoComplementario10 = ""
                                    _ConceptoComplementario11 = _Linia.Substring(52, 28)

                                    _Saldo = _Saldo + _Importe

                                    _TenimTotesLesDades = True
                                    _UpdateDades = False
                                Case "23"
                                    'If _Linia.Substring(0, 4) = "2301" Then
                                    '    _Concepto = _Linia.Substring(42, 38)
                                    '    _Saldo = _Saldo + _Importe
                                    '    _TenimTotesLesDades = True
                                    'Else
                                    '    _TenimTotesLesDades = False
                                    'End If

                                    Select Case _Linia.Substring(0, 4)
                                        Case "2301"
                                            _Concepto = _Linia.Substring(42, 38)
                                            _ConceptoComplementario1 = _Linia.Substring(4, 38)
                                            _ConceptoComplementario2 = _Linia.Substring(42, 38)
                                            _TenimTotesLesDades = False
                                            _UpdateDades = True
                                        Case "2302"
                                            _ConceptoComplementario3 = _Linia.Substring(4, 38)
                                            _ConceptoComplementario4 = _Linia.Substring(42, 38)
                                            _TenimTotesLesDades = False
                                            _UpdateDades = True
                                        Case "2303"
                                            _ConceptoComplementario5 = _Linia.Substring(4, 38)
                                            _ConceptoComplementario6 = _Linia.Substring(42, 38)
                                            _TenimTotesLesDades = False
                                            _UpdateDades = True
                                        Case "2304"
                                            _ConceptoComplementario7 = _Linia.Substring(4, 38)
                                            _ConceptoComplementario8 = _Linia.Substring(42, 38)
                                            _TenimTotesLesDades = False
                                            _UpdateDades = True
                                        Case "2305"
                                            _ConceptoComplementario9 = _Linia.Substring(4, 38)
                                            _ConceptoComplementario10 = _Linia.Substring(42, 38)
                                            _TenimTotesLesDades = False
                                            _UpdateDades = True
                                    End Select
                                Case "33"
                                    _TenimTotesLesDades = False
                                    _UpdateDades = False
                            End Select


                            If _TenimTotesLesDades = True Then
                                Dim _BancoMovimientos As New BancoMovimientos

                                If _DTC.BancoCC.Where(Function(F) F.Descripcion.Equals(_CC)).Count = 0 Then
                                    _CuentasNoIntroducidasEnElPrograma(_ContadorDeContes) = _CC
                                    _ContadorDeContes = _ContadorDeContes + 1
                                Else
                                    _BancoMovimientos.BancoCC = _DTC.BancoCC.Where(Function(F) F.Descripcion.Equals(_CC)).FirstOrDefault
                                    _BancoMovimientos.Fecha = _Fecha
                                    _BancoMovimientos.FechaValor = _FechaValor
                                    _BancoMovimientos.Importe = _Importe
                                    _BancoMovimientos.Saldo = _Saldo
                                    _BancoMovimientos.Concepto = _Concepto
                                    _BancoMovimientos.ConceptoComplementario1 = _ConceptoComplementario1
                                    _BancoMovimientos.ConceptoComplementario2 = _ConceptoComplementario2
                                    _BancoMovimientos.ConceptoComplementario3 = _ConceptoComplementario3
                                    _BancoMovimientos.ConceptoComplementario4 = _ConceptoComplementario4
                                    If _BancoMovimientos.BancoCC.ID_Banco = EnumBancos.BBVA And _ConceptoComplementario5.Length > 3 Then
                                        _BancoMovimientos.ConceptoComplementario5 = _ConceptoComplementario5.Substring(4, _ConceptoComplementario5.Length - 4)
                                    Else
                                        _BancoMovimientos.ConceptoComplementario5 = _ConceptoComplementario5
                                    End If
                                    _BancoMovimientos.ConceptoComplementario6 = _ConceptoComplementario6
                                    _BancoMovimientos.ConceptoComplementario7 = _ConceptoComplementario7
                                    _BancoMovimientos.ConceptoComplementario8 = _ConceptoComplementario8
                                    _BancoMovimientos.ConceptoComplementario9 = _ConceptoComplementario9
                                    _BancoMovimientos.ConceptoComplementario10 = _ConceptoComplementario10
                                    _BancoMovimientos.ConceptoComplementario11 = _ConceptoComplementario11

                                    Dim _DescripcionPersonalizada As String = ""
                                    Select Case _BancoMovimientos.BancoCC.ID_Banco
                                        Case EnumBancos.LaCaixa
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_Concepto) 'no fem la comprovacio per que el concepto mai sera null

                                            If Trim(_ConceptoComplementario1) <> "" Then
                                                If _ConceptoComplementario1 = "" Then
                                                    _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1)
                                                Else
                                                    _DescripcionPersonalizada = _DescripcionPersonalizada & " || " & Trim(_ConceptoComplementario1)
                                                End If
                                            End If

                                            If Trim(_ConceptoComplementario3) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & " || " & Trim(_ConceptoComplementario3)
                                            End If

                                            If Trim(_ConceptoComplementario7) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & " || " & Trim(_ConceptoComplementario7)
                                            End If

                                            _BancoMovimientos.DescripcionPersonalizada = _DescripcionPersonalizada
                                        Case EnumBancos.BBVA

                                            If Trim(_ConceptoComplementario11) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario11) & " || "
                                            End If

                                            'treuem els 4 primers caracters
                                            Dim _CC5SinLos4Primeros As String = _ConceptoComplementario5
                                            If _ConceptoComplementario5.Length > 3 Then
                                                _CC5SinLos4Primeros = _ConceptoComplementario5.Substring(4, _ConceptoComplementario5.Length - 4)
                                            End If

                                            If Trim(_CC5SinLos4Primeros) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_CC5SinLos4Primeros) & Trim(_ConceptoComplementario6) & " || "
                                            Else
                                                If Trim(_ConceptoComplementario1) <> "" Then
                                                    _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & " || "
                                                End If
                                            End If

                                            If Trim(_ConceptoComplementario7) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario7)
                                            End If

                                            If Trim(_ConceptoComplementario8) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario8)
                                            End If

                                            If Trim(_ConceptoComplementario9) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario9)
                                            End If

                                            If Trim(_ConceptoComplementario10) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario10)
                                            End If

                                            If _DescripcionPersonalizada.Substring((_DescripcionPersonalizada.Length - 4), 4) = " || " Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada.Substring(0, _DescripcionPersonalizada.Length - 4)
                                            End If

                                            If Trim(_ConceptoComplementario2) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & " || " & Trim(_ConceptoComplementario2)
                                            End If

                                            If Trim(_Concepto) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & " || " & Trim(_Concepto)
                                            End If

                                            _BancoMovimientos.DescripcionPersonalizada = _DescripcionPersonalizada

                                        Case EnumBancos.Bankia
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & Trim(_ConceptoComplementario2) & Trim(_ConceptoComplementario3)
                                            _BancoMovimientos.DescripcionPersonalizada = _DescripcionPersonalizada

                                        Case EnumBancos.Santander
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & Trim(_ConceptoComplementario2) & Trim(_ConceptoComplementario3)
                                            _BancoMovimientos.DescripcionPersonalizada = _DescripcionPersonalizada

                                        Case EnumBancos.Sabadell
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & Trim(_ConceptoComplementario2) & Trim(_ConceptoComplementario3)
                                            _BancoMovimientos.DescripcionPersonalizada = _DescripcionPersonalizada
                                        Case EnumBancos.Ibercaja
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & Trim(_ConceptoComplementario2) & Trim(_ConceptoComplementario3)
                                            _BancoMovimientos.DescripcionPersonalizada = _DescripcionPersonalizada
                                        Case EnumBancos.Cajamar
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & Trim(_ConceptoComplementario2) & Trim(_ConceptoComplementario3)
                                            _BancoMovimientos.DescripcionPersonalizada = _DescripcionPersonalizada
                                    End Select

                                    _DTC.BancoMovimientos.InsertOnSubmit(_BancoMovimientos)
                                    _DTC.SubmitChanges()

                                    _UpdateDadesID = _BancoMovimientos.ID_BancoMovimientos
                                End If
                            End If

                            If _UpdateDades = True Then
                                Dim _BancoMovimientosUpdate As BancoMovimientos
                                _BancoMovimientosUpdate = _DTC.BancoMovimientos.Where(Function(F) F.ID_BancoMovimientos = _UpdateDadesID).FirstOrDefault
                                _BancoMovimientosUpdate.ConceptoComplementario1 = _ConceptoComplementario1
                                _BancoMovimientosUpdate.ConceptoComplementario2 = _ConceptoComplementario2
                                _BancoMovimientosUpdate.ConceptoComplementario3 = _ConceptoComplementario3
                                _BancoMovimientosUpdate.ConceptoComplementario4 = _ConceptoComplementario4
                                If _BancoMovimientosUpdate.BancoCC.ID_Banco = EnumBancos.BBVA And _ConceptoComplementario5.Length > 3 Then
                                    _BancoMovimientosUpdate.ConceptoComplementario5 = _ConceptoComplementario5.Substring(4, _ConceptoComplementario5.Length - 4)
                                Else
                                    _BancoMovimientosUpdate.ConceptoComplementario5 = _ConceptoComplementario5
                                End If
                                _BancoMovimientosUpdate.ConceptoComplementario6 = _ConceptoComplementario6
                                _BancoMovimientosUpdate.ConceptoComplementario7 = _ConceptoComplementario7
                                _BancoMovimientosUpdate.ConceptoComplementario8 = _ConceptoComplementario8
                                _BancoMovimientosUpdate.ConceptoComplementario9 = _ConceptoComplementario9
                                _BancoMovimientosUpdate.ConceptoComplementario10 = _ConceptoComplementario10

                                Dim _DescripcionPersonalizada As String = ""
                                Select Case _BancoMovimientosUpdate.BancoCC.ID_Banco
                                    Case EnumBancos.LaCaixa
                                        _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_Concepto) 'no fem la comprovacio per que el concepto mai sera null

                                        If Trim(_ConceptoComplementario1) <> "" Then
                                            If _ConceptoComplementario1 = "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1)
                                            Else
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & " || " & Trim(_ConceptoComplementario1)
                                            End If
                                        End If

                                        If Trim(_ConceptoComplementario3) <> "" Then
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & " || " & Trim(_ConceptoComplementario3)
                                        End If

                                        If Trim(_ConceptoComplementario7) <> "" Then
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & " || " & Trim(_ConceptoComplementario7)
                                        End If

                                        _BancoMovimientosUpdate.DescripcionPersonalizada = _DescripcionPersonalizada
                                    Case EnumBancos.BBVA

                                        If Trim(_ConceptoComplementario11) <> "" Then
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario11) & " || "
                                        End If

                                        'treuem els 4 primers caracters
                                        Dim _CC5SinLos4Primeros As String = _ConceptoComplementario5
                                        If _ConceptoComplementario5.Length > 3 Then
                                            _CC5SinLos4Primeros = _ConceptoComplementario5.Substring(4, _ConceptoComplementario5.Length - 4)
                                        End If

                                        If Trim(_CC5SinLos4Primeros) <> "" Then
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_CC5SinLos4Primeros) & Trim(_ConceptoComplementario6) & " || "
                                        Else
                                            If Trim(_ConceptoComplementario1) <> "" Then
                                                _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & " || "
                                            End If
                                        End If

                                        If Trim(_ConceptoComplementario7) <> "" Then
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario7)
                                        End If

                                        If Trim(_ConceptoComplementario8) <> "" Then
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario8)
                                        End If

                                        If Trim(_ConceptoComplementario9) <> "" Then
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario9)
                                        End If

                                        If Trim(_ConceptoComplementario10) <> "" Then
                                            _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario10)
                                        End If

                                        If _DescripcionPersonalizada.Substring((_DescripcionPersonalizada.Length - 4), 4) = " || " Then
                                            _DescripcionPersonalizada = _DescripcionPersonalizada.Substring(0, _DescripcionPersonalizada.Length - 4)
                                        End If

                                        _BancoMovimientosUpdate.DescripcionPersonalizada = _DescripcionPersonalizada

                                    Case EnumBancos.Bankia
                                        _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & Trim(_ConceptoComplementario2) & Trim(_ConceptoComplementario3)
                                        _BancoMovimientosUpdate.DescripcionPersonalizada = _DescripcionPersonalizada

                                    Case EnumBancos.Santander
                                        _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & Trim(_ConceptoComplementario2) & Trim(_ConceptoComplementario3)
                                        _BancoMovimientosUpdate.DescripcionPersonalizada = _DescripcionPersonalizada

                                    Case EnumBancos.Sabadell
                                        _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & Trim(_ConceptoComplementario2) & Trim(_ConceptoComplementario3)
                                        _BancoMovimientosUpdate.DescripcionPersonalizada = _DescripcionPersonalizada

                                    Case EnumBancos.Ibercaja
                                        _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & Trim(_ConceptoComplementario2) & Trim(_ConceptoComplementario3)
                                        _BancoMovimientosUpdate.DescripcionPersonalizada = _DescripcionPersonalizada

                                    Case EnumBancos.Cajamar
                                        _DescripcionPersonalizada = _DescripcionPersonalizada & Trim(_ConceptoComplementario1) & Trim(_ConceptoComplementario2) & Trim(_ConceptoComplementario3)
                                        _BancoMovimientosUpdate.DescripcionPersonalizada = _DescripcionPersonalizada
                                End Select
                                _DTC.SubmitChanges()
                            End If

                        End If
                    Loop Until _Linia Is Nothing

                    objReader.Close()

                    Dim _mensaje As String = ""
                    Dim _cuenta As String
                    For Each _cuenta In _CuentasNoIntroducidasEnElPrograma
                        If IsNothing(_cuenta) = False AndAlso _mensaje.Contains(_cuenta) = False Then
                            _mensaje = _mensaje & _cuenta & ", "
                        End If
                    Next

                    If _mensaje <> "" Then
                        Mensaje.Mostrar_Mensaje("Los movimientos bancarios de las cuentas " & _mensaje & " no se han podido importar ya que las cuentas no estan registradas en el programa", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                    End If

                    Util.WaitFormTancar()

                    Mensaje.Mostrar_Mensaje("Dades importades correctament", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)


                    'tornem a posar el dia de ahir i recarreguem

                    Dim _DataUltimRegistreIntroduit As Date = BD.RetornaValorSQL("Select top(1) Fecha from BancoMovimientos order by id_BancoMovimientos desc")
                    Me.DT_Inicio.Value = _DataUltimRegistreIntroduit.Date
                    Me.DT_Fin.Value = _DataUltimRegistreIntroduit.Date
                    Me.C_BancoCC.Value = 0

                    Call BuscarLlistat()

                End If
            Catch Ex As Exception
                Mensaje.Mostrar_Mensaje("Error intern, consultar amb l'administrador", M_Mensaje.Missatge_Modo.ERRORS, , , True)
            End Try
        End If
    End Sub
#End Region

#Region "GRD"

    Private Sub ToolForm_m_ToolForm_Imprimir() Handles ToolForm.m_ToolForm_Imprimir
        Try
            Dim pDocument As New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument

            pDocument.Grid = Me.GRD.GRID
            pDocument.DefaultPageSettings.Landscape = True
            pDocument.DefaultPageSettings.Margins.Top = 50
            pDocument.DefaultPageSettings.Margins.Bottom = 50
            pDocument.DefaultPageSettings.Margins.Left = 50
            pDocument.DefaultPageSettings.Margins.Right = 50

            If Me.C_BancoCC.Value <> 0 Then
                pDocument.Header.TextCenter = Me.C_BancoCC.Text & vbCrLf & vbCrLf
            End If

            Me.GRD.GRID.PrintPreview(Me.GRD.GRID.DisplayLayout, pDocument, Infragistics.Win.UltraWinGrid.RowPropertyCategories.All)
            'Me.GRD.GRID.Print(Me.GRD.GRID.DisplayLayout, pDocument, Infragistics.Win.UltraWinGrid.RowPropertyCategories.All)
            'Me.GRD.GRID.DataSource = Nothing

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_M_GRID_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles GRD.M_GRID_AfterRowUpdate
        Dim _Registre As BancoMovimientos = _DTC.BancoMovimientos.Where(Function(F) F.ID_BancoMovimientos = CInt(e.Row.Cells("ID_BancoMovimientos").Value)).FirstOrDefault
        _Registre.DescripcionPersonalizada = e.Row.Cells("DescripcionPersonalizada").Value
        _DTC.SubmitChanges()
    End Sub

#End Region

End Class