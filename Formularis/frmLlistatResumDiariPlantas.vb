Imports Infragistics.Win
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet
Imports System.Globalization


Public Class frmLlistatResumDiariPlantas

    Dim _DTC As New DTCDataContext(BD.Conexion)

#Region "M_ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub


    Private Sub ToolForm_m_ToolForm_Imprimir() Handles ToolForm.m_ToolForm_Imprimir

        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Util.WaitFormObrir()

        Call BuidarTaulaTemp()

        Call OmplirTaulaTemp()

        Util.WaitFormTancar()

        Dim __DTC As New DTCDataContext(BD.Conexion)
        Informes.ObrirInformePreparacio(__DTC, 8, "", "Listado resumen diario plantas", , , , , , False)
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada()
        Me.AplicarDisseny()

        Util.Cargar_Combo(Me.C_Planta, "SELECT ID_Planta, Descripcion FROM Planta Where Activo=1 and ID_Planta <> 10 ORDER BY Descripcion", True)
        'Me.C_Planta.Items.Add(New With {.Text = "USA", .Value = 101})

        If IsNothing(Seguretat.oUser.CampoAux1) = False And IsDBNull(Seguretat.oUser.CampoAux1) = False Then
            Me.C_Planta.Value = Seguretat.oUser.CampoAux1
            If Seguretat.oUser.CampoAux1 = 1 Then
                Me.C_Planta.ReadOnly = False
            Else
                Me.C_Planta.ReadOnly = True
            End If
        End If

        Me.DT_Fecha.Value = Now.Date

        Dim BotoCancelar As UltraWinEditors.EditorButton
        BotoCancelar = New UltraWinEditors.EditorButton
        BotoCancelar.Key = "Cancelar"
        Dim oDisseny As New M_Disseny.ClsDisseny
        BotoCancelar.Appearance.Image = oDisseny.Leer_Imagen("text_cancelar.gif")
        BotoCancelar.Width = 16
        BotoCancelar.Appearance.BackColor = Color.White
        BotoCancelar.Appearance.BorderAlpha = Alpha.Transparent

        Me.C_Proveedor.ButtonsRight.Add(BotoCancelar.Clone)

        Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = True

        Call CargarGridEntrades()
        Call CargarGridEntradesPlantas()
        Call CargarGridSortides()
        Call CargarGridSortidesPlantes()
        Call CargarGridSCamionesPerdidos()

    End Sub

    Private Sub Validar_Click(sender As Object, e As EventArgs) Handles Validar.Click
        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Call CargarGridEntrades()
        Call CargarGridEntradesPlantas()
        Call CargarGridSortides()
        Call CargarGridSortidesPlantes()
        Call CargarGridSCamionesPerdidos()
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                'oClsControls.ControlBuit(.TE_Codigo)
                oClsControls.ControlBuit(.DT_Fecha)
                'oClsControls.ControlBuit(.C_Planta)
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Public Sub BuidarTaulaTemp()
        BD.EjecutarConsulta("Delete from Temp_Diari_EntradaPlanta")
        BD.EjecutarConsulta("Delete from Temp_Diari_SortidaPlanta")
        BD.EjecutarConsulta("Delete from Temp_Diari_Entrada")
        BD.EjecutarConsulta("Delete from Temp_Diari_Sortida")
        BD.EjecutarConsulta("Delete from Temp_Diari")
    End Sub

    Public Sub OmplirTaulaTemp()
        Try

            Dim _Temp As New Temp_Diari
            _Temp.Fecha = Me.DT_Fecha.Value
            _Temp.Planta = Me.C_Planta.Text
            _DTC.Temp_Diari.InsertOnSubmit(_Temp)
            _DTC.SubmitChanges()

            'entradas
            For _Files As Integer = 0 To Me.GridView1.RowCount - 1
                Dim _Temp_Entrada As New Temp_Diari_Entrada
                _Temp_Entrada.Temp_Diari = _Temp
                _Temp_Entrada.CodigoArticulo = GridView1.GetRowCellValue(_Files, "Codigo").ToString
                _Temp_Entrada.DescripcionArticulo = GridView1.GetRowCellValue(_Files, "Descripcion").ToString

                If IsDBNull(GridView1.GetRowCellValue(_Files, "TotalUnidades")) = False Then
                    Dim cadenas1 As String() = FormatNumber(GridView1.GetRowCellValue(_Files, "TotalUnidades"), 0).ToString.Split(",")
                    _Temp_Entrada.CantidadActual = cadenas1(0)
                Else
                    _Temp_Entrada.CantidadActual = ""
                End If

                If IsDBNull(GridView1.GetRowCellValue(_Files, "TotalUnidadesHastaHoy")) = False Then
                    Dim cadenas2 As String() = FormatNumber(GridView1.GetRowCellValue(_Files, "TotalUnidadesHastaHoy"), 0).ToString.Split(",")
                    _Temp_Entrada.CantidadHastaHoy = cadenas2(0)
                Else
                    _Temp_Entrada.CantidadHastaHoy = ""
                End If


                _DTC.Temp_Diari_Entrada.InsertOnSubmit(_Temp_Entrada)
                _DTC.SubmitChanges()
            Next

            'entradas por planta
            For _Files As Integer = 0 To Me.GridView4.RowCount - 1
                Dim _Temp_EntradaPlanta As New Temp_Diari_EntradaPlanta
                _Temp_EntradaPlanta.Temp_Diari = _Temp
                _Temp_EntradaPlanta.CodigoArticulo = GridView4.GetRowCellValue(_Files, "Codigo").ToString
                _Temp_EntradaPlanta.DescripcionArticulo = GridView4.GetRowCellValue(_Files, "Descripcion").ToString

                If IsDBNull(GridView4.GetRowCellValue(_Files, "TotalUnidades")) = False Then
                    Dim cadenas1 As String() = FormatNumber(GridView4.GetRowCellValue(_Files, "TotalUnidades"), 0).ToString.Split(",")
                    _Temp_EntradaPlanta.CantidadActual = cadenas1(0)
                Else
                    _Temp_EntradaPlanta.CantidadActual = ""
                End If

                If IsDBNull(GridView4.GetRowCellValue(_Files, "TotalUnidadesHastaHoy")) = False Then
                    Dim cadenas2 As String() = FormatNumber(GridView4.GetRowCellValue(_Files, "TotalUnidadesHastaHoy"), 0).ToString.Split(",")
                    _Temp_EntradaPlanta.CantidadHastaHoy = cadenas2(0)
                Else
                    _Temp_EntradaPlanta.CantidadHastaHoy = ""
                End If


                _DTC.Temp_Diari_EntradaPlanta.InsertOnSubmit(_Temp_EntradaPlanta)
                _DTC.SubmitChanges()
            Next

            'sortides
            For _Files As Integer = 0 To Me.GridView2.RowCount - 1
                Dim _Temp_Sortida As New Temp_Diari_Sortida
                _Temp_Sortida.Temp_Diari = _Temp
                _Temp_Sortida.CodigoArticulo = GridView2.GetRowCellValue(_Files, "Codigo").ToString
                _Temp_Sortida.DescripcionArticulo = GridView2.GetRowCellValue(_Files, "Descripcion").ToString

                If IsDBNull(GridView2.GetRowCellValue(_Files, "TotalUnidades")) = False Then
                    Dim cadenas1 As String() = FormatNumber(GridView2.GetRowCellValue(_Files, "TotalUnidades"), 0).ToString.Split(",")
                    _Temp_Sortida.CantidadActual = cadenas1(0)
                Else
                    _Temp_Sortida.CantidadActual = ""
                End If

                If IsDBNull(GridView2.GetRowCellValue(_Files, "TotalUnidadesHastaHoy")) = False Then
                    Dim cadenas2 As String() = FormatNumber(GridView2.GetRowCellValue(_Files, "TotalUnidadesHastaHoy"), 0).ToString.Split(",")
                    _Temp_Sortida.CantidadHastaHoy = cadenas2(0)
                Else
                    _Temp_Sortida.CantidadHastaHoy = ""
                End If

                _DTC.Temp_Diari_Sortida.InsertOnSubmit(_Temp_Sortida)
                _DTC.SubmitChanges()
            Next

            'sortides per planta
            For _Files As Integer = 0 To Me.GridView6.RowCount - 1
                Dim _Temp_SortidaPlanta As New Temp_Diari_SortidaPlanta
                _Temp_SortidaPlanta.Temp_Diari = _Temp
                _Temp_SortidaPlanta.CodigoArticulo = GridView6.GetRowCellValue(_Files, "Codigo").ToString
                _Temp_SortidaPlanta.DescripcionArticulo = GridView6.GetRowCellValue(_Files, "Descripcion").ToString

                If IsDBNull(GridView6.GetRowCellValue(_Files, "TotalUnidades")) = False Then
                    Dim cadenas1 As String() = FormatNumber(GridView6.GetRowCellValue(_Files, "TotalUnidades"), 0).ToString.Split(",")
                    _Temp_SortidaPlanta.CantidadActual = cadenas1(0)
                Else
                    _Temp_SortidaPlanta.CantidadActual = ""
                End If

                If IsDBNull(GridView6.GetRowCellValue(_Files, "TotalUnidadesHastaHoy")) = False Then
                    Dim cadenas2 As String() = FormatNumber(GridView6.GetRowCellValue(_Files, "TotalUnidadesHastaHoy"), 0).ToString.Split(",")
                    _Temp_SortidaPlanta.CantidadHastaHoy = cadenas2(0)
                Else
                    _Temp_SortidaPlanta.CantidadHastaHoy = ""
                End If

                _DTC.Temp_Diari_SortidaPlanta.InsertOnSubmit(_Temp_SortidaPlanta)
                _DTC.SubmitChanges()
            Next

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

#End Region

#Region "Grid entrades"

    Private Sub CargarGridEntrades()
        Dim _SQLPRoveedor As String
        If Me.C_Proveedor.SelectedIndex <> -1 Then
            _SQLPRoveedor = " CodigoProveedor= '" & Me.C_Proveedor.Value & "' and "
        End If

        Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA
       
        Dim _DTS As New DataSet
        BD.CargarDataSet(_DTS, "Select CodigoArticulo as Codigo, DescripcionArticulo as Descripcion, Sum(Unidades) as TotalUnidadesHastaHoy, (Select Sum(Unidades) as TotalUnidades From C_LineasAlbaranCompra as a where " & _SQLPRoveedor & " CodigoProveedor not in (Select CodigoProveedor from Planta where CodigoProveedor is not null) and Planta = '" & _Planta & "' and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "' and a.DescripcionArticulo = b.DescripcionArticulo) as TotalUnidades From C_LineasAlbaranCompra as b where " & _SQLPRoveedor & " Planta = '" & _Planta & "' and CodigoProveedor not in (Select CodigoProveedor from Planta where CodigoProveedor is not null) and FechaAlbaran between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & CDate(Me.DT_Fecha.Value) & "' Group by CodigoArticulo, DescripcionArticulo Order by Descripcion")
        BD.CargarDataSet(_DTS, "Select * From C_LineasAlbaranCompra where " & _SQLPRoveedor & " CodigoProveedor not in (Select CodigoProveedor from Planta where CodigoProveedor is not null) and Planta = '" & _Planta & "' and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "'  Order by FechaAlbaran ", "Movimientos del día", 0, "Codigo", "CodigoArticulo", True)
        BD.CargarDataSet(_DTS, "Select * From C_LineasAlbaranCompra where " & _SQLPRoveedor & " CodigoProveedor not in (Select CodigoProveedor from Planta where CodigoProveedor is not null) and Planta = '" & _Planta & "' and FechaAlbaran between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & CDate(Me.DT_Fecha.Value) & "'  Order by FechaAlbaran ", "Movimientos del mes", 0, "Codigo", "CodigoArticulo", True)

        _DTS.Tables(0).TableName = "Root"
        Me.GridControl1.DataSource = _DTS.Tables(0)

    End Sub

#End Region

#Region "Grid entrades plantas"

    Private Sub CargarGridEntradesPlantas()
        Dim _SQLPRoveedor As String
        If Me.C_Proveedor.SelectedIndex <> -1 Then
            _SQLPRoveedor = " CodigoProveedor= '" & Me.C_Proveedor.Value & "' and "
        End If

        Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA
       
        Dim _DTS As New DataSet
        BD.CargarDataSet(_DTS, "Select CodigoArticulo as Codigo, DescripcionArticulo as Descripcion, Sum(Unidades) as TotalUnidadesHastaHoy, (Select Sum(Unidades) as TotalUnidades From C_LineasAlbaranCompra as a where " & _SQLPRoveedor & " CodigoProveedor in (Select CodigoProveedor from Planta where CodigoProveedor is not null) and Planta = '" & _Planta & "' and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "' and a.DescripcionArticulo = b.DescripcionArticulo) as TotalUnidades From C_LineasAlbaranCompra as b where " & _SQLPRoveedor & " Planta = '" & _Planta & "' and CodigoProveedor in (Select CodigoProveedor from Planta where CodigoProveedor is not null) and FechaAlbaran between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & CDate(Me.DT_Fecha.Value) & "' Group by CodigoArticulo, DescripcionArticulo Order by Descripcion")
        BD.CargarDataSet(_DTS, "Select * From C_LineasAlbaranCompra where " & _SQLPRoveedor & "  CodigoProveedor in (Select CodigoProveedor from Planta where CodigoProveedor is not null) and Planta = '" & _Planta & "' and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "'  Order by FechaAlbaran ", "Movimientos del día", 0, "Codigo", "CodigoArticulo", True)
        BD.CargarDataSet(_DTS, "Select * From C_LineasAlbaranCompra where " & _SQLPRoveedor & "  CodigoProveedor in (Select CodigoProveedor from Planta where CodigoProveedor is not null) and Planta = '" & _Planta & "' and FechaAlbaran between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & CDate(Me.DT_Fecha.Value) & "'  Order by FechaAlbaran ", "Movimientos del mes", 0, "Codigo", "CodigoArticulo", True)

        _DTS.Tables(0).TableName = "Root"
        Me.GridControl3.DataSource = _DTS.Tables(0)

    End Sub

#End Region

#Region "Grid sortides"

    Private Sub CargarGridSortides()

        Dim _SQLPRoveedor As String
        If Me.C_Proveedor.SelectedIndex <> -1 Then
            _SQLPRoveedor = " CodigoCliente= '" & Me.C_Proveedor.Value & "' and "
        End If

        Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA

        Dim _DTS As New DataSet
        BD.CargarDataSet(_DTS, "Select CodigoArticulo as Codigo, DescripcionArticulo as Descripcion, Sum(Unidades) as TotalUnidadesHastaHoy, (Select Sum(Unidades) as TotalUnidades From C_LineasAlbaranVenta as a where " & _SQLPRoveedor & " CodigoCliente not in (Select CodigoCliente from Planta where CodigoCliente is not null) and Planta = '" & _Planta & "' and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "' and a.DescripcionArticulo = b.DescripcionArticulo) as TotalUnidades From C_LineasAlbaranVenta as b where " & _SQLPRoveedor & " CodigoCliente not in (Select CodigoCliente from Planta where CodigoCliente is not null) and Planta = '" & _Planta & "' and FechaAlbaran between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & CDate(Me.DT_Fecha.Value) & "' Group by CodigoArticulo, DescripcionArticulo Order by Descripcion")
        BD.CargarDataSet(_DTS, "Select * From C_LineasAlbaranVenta where " & _SQLPRoveedor & " CodigoCliente not in (Select CodigoCliente from Planta where CodigoCliente is not null) and Planta = '" & _Planta & "' and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "'  Order by FechaAlbaran ", "Movimientos del día", 0, "Codigo", "CodigoArticulo", True)
        BD.CargarDataSet(_DTS, "Select * From C_LineasAlbaranVenta where " & _SQLPRoveedor & " CodigoCliente not in (Select CodigoCliente from Planta where CodigoCliente is not null) and Planta = '" & _Planta & "' and FechaAlbaran between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & CDate(Me.DT_Fecha.Value) & "'  Order by FechaAlbaran ", "Movimientos del mes", 0, "Codigo", "CodigoArticulo", True)

        _DTS.Tables(0).TableName = "Root"
        Me.GridControl2.DataSource = _DTS.Tables(0)

    End Sub

#End Region

#Region "Grid sortides plantas"

    Private Sub CargarGridSortidesPlantes()

        Dim _SQLPRoveedor As String
        If Me.C_Proveedor.SelectedIndex <> -1 Then
            _SQLPRoveedor = " CodigoCliente= '" & Me.C_Proveedor.Value & "' and "
        End If

        Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA

        Dim _DTS As New DataSet

        'BD.CargarDataSet(_DTS, "Select CodigoArticulo as Codigo, DescripcionArticulo as Descripcion, Sum(Unidades) as TotalUnidadesHastaHoy, (Select Sum(Unidades) as TotalUnidades From C_LineasAlbaranCompra as a where " & _SQLPRoveedor & " CodigoProveedor in (Select CodigoProveedor from Planta where CodigoProveedor is not null) and Planta = '" & _Planta & "' and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "' and a.DescripcionArticulo = b.DescripcionArticulo) as TotalUnidades From C_LineasAlbaranCompra as b where " & _SQLPRoveedor & " Planta = '" & _Planta & "' and CodigoProveedor in (Select CodigoProveedor from Planta where CodigoProveedor is not null) and FechaAlbaran between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & CDate(Me.DT_Fecha.Value) & "' Group by CodigoArticulo, DescripcionArticulo Order by Descripcion")
        BD.CargarDataSet(_DTS, "Select CodigoArticulo as Codigo, DescripcionArticulo as Descripcion, Sum(Unidades) as TotalUnidadesHastaHoy, (Select Sum(Unidades) as TotalUnidades From C_LineasAlbaranVenta as a where " & _SQLPRoveedor & " CodigoCliente in (Select CodigoCliente from Planta where CodigoCliente is not null) and Planta = '" & _Planta & "' and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "' and a.DescripcionArticulo = b.DescripcionArticulo) as TotalUnidades From C_LineasAlbaranVenta as b where " & _SQLPRoveedor & " Planta = '" & _Planta & "' and CodigoCliente in (Select CodigoCliente from Planta where CodigoCliente is not null) and FechaAlbaran between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & CDate(Me.DT_Fecha.Value) & "' Group by CodigoArticulo, DescripcionArticulo Order by Descripcion")
        BD.CargarDataSet(_DTS, "Select * From C_LineasAlbaranVenta where " & _SQLPRoveedor & " CodigoCliente in (Select CodigoCliente from Planta where CodigoCliente is not null) and Planta = '" & _Planta & "' and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "'  Order by FechaAlbaran ", "Movimientos del día", 0, "Codigo", "CodigoArticulo", True)
        BD.CargarDataSet(_DTS, "Select * From C_LineasAlbaranVenta where " & _SQLPRoveedor & " CodigoCliente in (Select CodigoCliente from Planta where CodigoCliente is not null) and Planta = '" & _Planta & "' and FechaAlbaran between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & CDate(Me.DT_Fecha.Value) & "'  Order by FechaAlbaran ", "Movimientos del mes", 0, "Codigo", "CodigoArticulo", True)

        _DTS.Tables(0).TableName = "Root"
        Me.GridControl4.DataSource = _DTS.Tables(0)

    End Sub

#End Region

#Region "Grid camiones perdidos"
    Private Sub CargarGridSCamionesPerdidos()

        Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA

        Dim _dt_CompradoViuda As DataTable = BD.RetornaDataTable("select REPLACE(Matricula, '-', '') as Matricula, Proveedor, Contador from (Select NumeroAlbaran, Matricula, (Select Descripcion from planta where planta.CodigoProveedor = C_LineasAlbaranCompra.CodigoProveedor) as Proveedor, count(*) as Contador From C_LineasAlbaranCompra where CodigoProveedor in (Select CodigoProveedor from Planta where CodigoProveedor is not null and CodigoProveedor <> 400999997) and Planta = '" & _Planta & "' and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "' group by NumeroAlbaran, Matricula, CodigoProveedor) as tabla group by Matricula, Proveedor, Contador")
        Dim _dt_VendidoViuda As DataTable = BD.RetornaDataTable("select REPLACE(Matricula, '-', '') as Matricula, Cliente, Contador from (Select NumeroAlbaran, Matricula, (Select Descripcion from planta where Iniciales_LCLARIANA = Planta) as Cliente, count(*) as Contador From C_LineasAlbaranVenta where Planta <> 'GI' and CodigoCliente = (Select CodigoCliente from Planta where ID_Planta = " & Me.C_Planta.Value & ") and FechaAlbaran = '" & CDate(Me.DT_Fecha.Value) & "' group by NumeroAlbaran, Matricula, Planta) as tabla group by Matricula, Cliente, Contador")

        'omplim el dt amb l'esquema
        Dim _dt_CamionsPerdutsVendido As DataTable = BD.RetornaDataTable("Select Matricula, (Select Descripcion from planta where Iniciales_LCLARIANA = Planta) as Cliente, count(*) as Contador From C_LineasAlbaranVenta where CodigoCliente = 0 group by NumeroAlbaran, Matricula, Planta", True)

        Dim _row_vendido As DataRow
        If IsNothing(_dt_VendidoViuda) = False Then
            For Each _row_vendido In _dt_VendidoViuda.Rows
                If IsNothing(_dt_CompradoViuda) = False Then
                    Dim _dt_CompradoViuda_filtrat As DataTable = FilterDataTable(_dt_CompradoViuda, "Proveedor = '" & _row_vendido.Item("Cliente") & "'")
                    If _dt_CompradoViuda_filtrat.Rows.Count > 0 Then
                        If _dt_CompradoViuda_filtrat.Rows(0).Item("Contador") <> _row_vendido.Item("Contador") Then
                            _dt_CamionsPerdutsVendido.ImportRow(_row_vendido)
                        End If
                    Else
                        _dt_CamionsPerdutsVendido.ImportRow(_row_vendido)
                    End If
                End If
            Next
        End If

        'omplim el dt amb l'esquema
        Dim _dt_CamionsPerdutsComprado As DataTable = BD.RetornaDataTable("Select Matricula, (Select Descripcion from planta where planta.CodigoProveedor = C_LineasAlbaranCompra.CodigoProveedor) as Proveedor, count(*) as Contador From C_LineasAlbaranCompra where CodigoProveedor = 0 group by NumeroAlbaran, Matricula, CodigoProveedor", True)

        Dim _row_comprado As DataRow
        If IsNothing(_dt_CompradoViuda) = False Then
            For Each _row_comprado In _dt_CompradoViuda.Rows
                If IsNothing(_dt_VendidoViuda) = False Then
                    Dim _dt_VendidoViuda_filtrat As DataTable = FilterDataTable(_dt_VendidoViuda, "Cliente = '" & _row_comprado.Item("Proveedor") & "'")
                    If _dt_VendidoViuda_filtrat.Rows.Count > 0 Then
                        If _dt_VendidoViuda_filtrat.Rows(0).Item("Contador") <> _row_comprado.Item("Contador") Then
                            _dt_CamionsPerdutsComprado.ImportRow(_row_comprado)
                        End If
                    Else
                        _dt_CamionsPerdutsComprado.ImportRow(_row_comprado)
                    End If
                End If
            Next
        End If


        Me.GRD.M.clsUltraGrid.Cargar(_dt_CamionsPerdutsVendido)
        Me.GRD2.M.clsUltraGrid.Cargar(_dt_CamionsPerdutsComprado)
    End Sub

#End Region


    Private Sub C_Proveedor_BeforeDropDown(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles C_Proveedor.BeforeDropDown
        Dim _SQLPlanta As String = ""

        If IsNothing(Me.DT_Fecha.Value) = True Then
            Mensaje.Mostrar_Mensaje("Introduzca correctamente los datos", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)
        Else
            If Me.C_Planta.SelectedIndex <> -1 Then
                Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA
                _SQLPlanta = " planta= '" & _Planta & "' and "
            End If
        End If

        If Me.OP.Value = "cliente" Then
            Util.Cargar_Combo(Me.C_Proveedor, "SELECT codigocliente, RazonSocial FROM C_LineasAlbaranVenta Where " & _SQLPlanta & "  FechaAlbaran Between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & Me.DT_Fecha.Value & "' group by codigocliente, RazonSocial ", False, False)
        Else
            Util.Cargar_Combo(Me.C_Proveedor, "SELECT codigoproveedor, Proveedor FROM C_LineasAlbaranCompra Where " & _SQLPlanta & "  FechaAlbaran Between '" & New Date(CDate(Me.DT_Fecha.Value).Year, CDate(Me.DT_Fecha.Value).Month, 1) & "' and '" & Me.DT_Fecha.Value & "' group by codigoproveedor, Proveedor ", False, False)
        End If

    End Sub

    Private Sub C_Proveedor_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles C_Proveedor.EditorButtonClick
        If e.Button.Key = "Cancelar" Then
            Me.C_Proveedor.SelectedIndex = -1
        End If
    End Sub

    Private Sub OP_ValueChanged(sender As Object, e As EventArgs) Handles OP.ValueChanged
        If Me.OP.Value = "cliente" Then
            Me.UltraLabel2.Text = "Cliente"
        Else
            Me.UltraLabel2.Text = "Proveedor"
        End If
    End Sub

    Function FilterDataTable(ByVal dt As DataTable, ByVal filter As String) As DataTable

        Dim rows As DataRow()
        Dim dtNew As DataTable


        dtNew = dt.Clone()
            rows = dt.Select(filter)

            For Each dr As DataRow In rows
                dtNew.ImportRow(dr)
            Next

            Return dtNew



    End Function
End Class