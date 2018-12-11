Imports Infragistics.Win.UltraWinGrid
Imports DevExpress.XtraCharts
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.UltraWinToolbars
Imports Infragistics.Win

Public Class frmMovimientos


    Dim oLinqMovimientoCabecera As MovimientoCabecera
    Dim oDTC As New DTCDataContext(BD.Conexion)

#Region "ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

    Private Sub ToolForm_m_ToolForm_Eliminar() Handles ToolForm.m_ToolForm_Eliminar
        Call Eliminar()
    End Sub

    Private Sub ToolForm_m_ToolForm_Buscar() Handles ToolForm.m_ToolForm_Buscar
        Call Cridar_Llistat_Generic()
    End Sub

    Private Sub M_ToolForm1_m_ToolForm_Nuevo() Handles ToolForm.m_ToolForm_Nuevo
        Call Netejar_Pantalla()
    End Sub

    Private Sub ToolForm_m_ToolForm_Imprimir() Handles ToolForm.m_ToolForm_Imprimir
        If Guardar() = True Then 'Per obligar guardar abans d'imprimir
            Dim _Pepe As New DTCDataContext(BD.Conexion)

            Informes.ObrirInformePreparacio(_Pepe, 1, "[ID_MovimientoCabecera] = " & oLinqMovimientoCabecera.ID_MovimientoCabecera, "Movimiento " & oLinqMovimientoCabecera.ID_MovimientoCabecera)

        End If

    End Sub

#End Region

#Region "Metodes"
    Public Sub Entrada()

        Me.AplicarDisseny()

        Me.TE_Codigo.ButtonsRight("Lupeta").Enabled = True

        Call Netejar_Pantalla()

        Me.ToolForm.M.Botons.tGuardar.SharedProps.Visible = False
        Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = True

        Util.Cargar_Combo(Me.C_Planta, "select ID_Planta, Descripcion From Planta Where Activo=1")

        If Seguretat.oUser.CampoAux1 = 1 Then  'Només la central podrà seleccionar quina planta visualitzar
            Me.C_Planta.Enabled = True
        Else
            Me.C_Planta.Enabled = False
        End If

        If IsNumeric(Seguretat.oUser.CampoAux1) = True Then
            Me.C_Planta.Value = Seguretat.oUser.CampoAux1

            If Seguretat.oUser.CampoAux1 <> "1" Then
                Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = False
            End If

        End If


    End Sub

    Private Sub Eliminar()
        Try
            If oLinqMovimientoCabecera.ID_MovimientoCabecera = 0 Then
                Call Netejar_Pantalla()
                Exit Sub
            End If

            If Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE_PREGUNTA) = M_Mensaje.Botons.SI Then

                oDTC.Movimiento.DeleteAllOnSubmit(oLinqMovimientoCabecera.Movimiento)
                oDTC.MovimientoCabecera.DeleteOnSubmit(oLinqMovimientoCabecera)
                oDTC.SubmitChanges()

                Call Netejar_Pantalla()
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE)
            End If


        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Netejar_Pantalla()
        oLinqMovimientoCabecera = New MovimientoCabecera
        oDTC = New DTCDataContext(BD.Conexion)

        Util.Blanquejar(Me, M_Util.Enum_Controles_Activacion.TODOS, True)

        Me.DT_Fecha.Value = Now.Date
        Me.TE_Codigo.Value = Nothing
        Me.TE_Codigo.Focus()
        Me.C_Planta.Value = Seguretat.oUser.CampoAux1

        Me.EstableixCaptionForm("Movimiento")

        Call CargaGrid_Movimientos(0)

        ErrorProvider1.Clear()
    End Sub

    Private Function Guardar() As Boolean
        Guardar = False
        Try
            Me.TE_Codigo.Focus()

            'If ComprovacioCampsRequeritsError() = True Then
            '    Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            '    Exit Function
            'End If

            Call GetFromForm(oLinqMovimientoCabecera)

            If oLinqMovimientoCabecera.ID_MovimientoCabecera = 0 Then  ' Comprovacio per saber si es un insertar o un nou
                'si avui ja hem creat movimiento cabecera, no en crearem un altre
                If BD.RetornaValorSQL("select count(*) from MovimientoCabecera where Fecha = '" & Me.DT_Fecha.Value & "'") = 0 Then
                    oDTC.MovimientoCabecera.InsertOnSubmit(oLinqMovimientoCabecera)
                    oDTC.SubmitChanges()

                    Dim _MovimentNew As DataRow
                    Dim _NumeroVehicles As DataTable = BD.RetornaDataTable("select ID_Vehiculo from Vehiculo where activo = 1 Order by Orden")
                    For Each _MovimentNew In _NumeroVehicles.Rows
                        Dim _Movimiento As New Movimiento
                        _Movimiento.ID_MovimientoCabecera = oLinqMovimientoCabecera.ID_MovimientoCabecera
                        If IsDBNull(BD.RetornaValorSQL("select TOP 1 ID_Personal from Movimiento where ID_Vehiculo = " & _MovimentNew.Item("ID_Vehiculo") & " order by ID_Movimiento desc")) = True Then
                            _Movimiento.ID_Personal = Nothing
                        Else
                            _Movimiento.ID_Personal = BD.RetornaValorSQL("select TOP 1 ID_Personal from Movimiento where ID_Vehiculo = " & _MovimentNew.Item("ID_Vehiculo") & " order by ID_Movimiento desc")
                        End If
                        _Movimiento.ID_Vehiculo = _MovimentNew.Item("ID_Vehiculo")
                        _Movimiento.ID_EstadoTrabajador = 1
                        oDTC.Movimiento.InsertOnSubmit(_Movimiento)
                    Next
                    oDTC.SubmitChanges()

                    Me.TE_Codigo.Text = oLinqMovimientoCabecera.ID_MovimientoCabecera
                    Me.EstableixCaptionForm("Movimiento: " & (oLinqMovimientoCabecera.ID_MovimientoCabecera))
                    Call CargaGrid_Movimientos(oLinqMovimientoCabecera.ID_MovimientoCabecera)

                    Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_AFEGIR_REGISTRE)
                Else
                    Dim _ID_MovimientoCabecera_Dia As Integer = BD.RetornaValorSQL("select ID_MovimientoCabecera From MovimientoCabecera Where Fecha = '" & CDate(Me.DT_Fecha.Value).Date & "'")
                    Me.TE_Codigo.Text = _ID_MovimientoCabecera_Dia
                    oLinqMovimientoCabecera = oDTC.MovimientoCabecera.Where(Function(F) F.ID_MovimientoCabecera = _ID_MovimientoCabecera_Dia).FirstOrDefault
                    Call CargaGrid_Movimientos(_ID_MovimientoCabecera_Dia)
                End If
            Else
                oDTC.SubmitChanges()
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_MODIFICAR_REGISTRE)
            End If

            'Call ComprovarSiAlgoHaCanviat(oLinqAssociat.ID_Associat)
            Guardar = True

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Private Sub GetFromForm(ByRef pMovimientoCabecera As MovimientoCabecera)
        Try
            With pMovimientoCabecera
                .Fecha = Me.DT_Fecha.Value
            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub SetToForm()
        Try
            With oLinqMovimientoCabecera
                Me.TE_Codigo.Value = .ID_MovimientoCabecera
                Me.DT_Fecha.Text = .Fecha
            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Cridar_Llistat_Generic()
        Dim LlistatGeneric As New M_LlistatGeneric.clsLlistatGeneric
        LlistatGeneric.Mostrar_Llistat("SELECT * FROM MovimientoCabecera ORDER BY Fecha", Me.TE_Codigo, "ID_MovimientoCabecera", "ID_MovimientoCabecera")
        AddHandler LlistatGeneric.AlTancarLlistatGeneric, AddressOf AlTancarLlistat
    End Sub

    Private Sub AlTancarLlistat(ByVal pID As String)
        Try
            Call Cargar_Form(pID)
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Cargar_Form(ByVal pID As Integer)
        Try
            Call Netejar_Pantalla()

            oLinqMovimientoCabecera = (From taula In oDTC.MovimientoCabecera Where taula.ID_MovimientoCabecera = pID Select taula).FirstOrDefault

            Call SetToForm()

            Call CargaGrid_Movimientos(pID)

            Me.EstableixCaptionForm("Movimiento: " & (oLinqMovimientoCabecera.ID_MovimientoCabecera))

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

#End Region

#Region "Grid Movimientos"
    Private Sub CargaGrid_Movimientos(ByVal pId As Integer)
        Try
            Dim _Movimiento As IEnumerable(Of Movimiento) = From taula In oDTC.Movimiento Where taula.ID_MovimientoCabecera = pId And taula.Vehiculo.ID_Planta = CInt(Me.C_Planta.Value) Order By taula.ID_Movimiento Select taula

            With Me.GRD_Movimientos

                '.GRID.DataSource = _Asignacion
                .M.clsUltraGrid.CargarIEnumerable(_Movimiento)
                .M_Editable()
                .M_TreureFocus()

                .GRID.DisplayLayout.Bands(0).Columns("Vehiculo").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .GRID.DisplayLayout.Bands(0).Columns("HorarioRealSalida").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .GRID.DisplayLayout.Bands(0).Columns("HorarioRealLlegada").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .GRID.DisplayLayout.Bands(0).Columns("pDiferenciaTeoricAmbReal").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .GRID.DisplayLayout.Bands(0).Columns("pDiferenciaEntradaAmbSortida").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit


                .GRID.ActiveRow = Nothing
                .GRID.DisplayLayout.Bands(0).Columns("HorarioTeoricoSalida").Style = ColumnStyle.Time
                .GRID.DisplayLayout.Bands(0).Columns("HorarioRealSalida").Style = ColumnStyle.Time
                .GRID.DisplayLayout.Bands(0).Columns("HorarioRealLlegada").Style = ColumnStyle.Time

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    'cargar el combo de vehicles, sense els desactivats
    Private Sub CargarCombo_Vehiculo(ByVal pGrid As UltraWinGrid.UltraGrid, ByRef pCell As UltraWinGrid.UltraGridCell, ByVal pTots As Boolean)
        Try

            Dim oTaula As IQueryable(Of Vehiculo)
            Dim Valors As New Infragistics.Win.ValueList
            Dim _Vehiculo As Vehiculo = pCell.Value

            If pTots = True Then
                oTaula = (From Taula In oDTC.Vehiculo Order By Taula.Matricula Select Taula)
            Else
                oTaula = (From Taula In oDTC.Vehiculo Where (Taula Is _Vehiculo) Or Taula.Activo = True Order By Taula.Matricula Select Taula)
            End If

            Dim Var As Vehiculo

            For Each Var In oTaula
                Valors.ValueListItems.Add(Var, Var.Matricula)
            Next

            pCell.ValueList = Valors.Clone
            pGrid.DisplayLayout.Bands(0).Columns("Vehiculo").Style = ColumnStyle.DropDown

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub CargarCombo_Personal(ByVal pGrid As UltraWinGrid.UltraGrid, ByRef pCell As UltraWinGrid.UltraGridCell, ByVal pTots As Boolean)
        Try

            Dim oTaula As IQueryable(Of Personal)
            Dim Valors As New Infragistics.Win.ValueList
            Dim _Personal As Personal = pCell.Value

            If pTots = True Then
                oTaula = (From Taula In oDTC.Personal Order By Taula.Nombre Select Taula)
            Else
                oTaula = (From Taula In oDTC.Personal Where (Taula Is _Personal) Or Taula.Activo = True Order By Taula.Nombre Select Taula)
            End If

            Dim Var As Personal

            For Each Var In oTaula
                Valors.ValueListItems.Add(Var, Var.Nombre)
            Next

            pCell.ValueList = Valors.Clone
            pGrid.DisplayLayout.Bands(0).Columns("Personal").Style = ColumnStyle.DropDown

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub CargarCombo_EstadoTrabajador(ByVal pGrid As UltraWinGrid.UltraGrid, ByRef pCell As UltraWinGrid.UltraGridCell, ByVal pTots As Boolean)
        Try

            Dim oTaula As IQueryable(Of EstadoTrabajador)
            Dim Valors As New Infragistics.Win.ValueList
            Dim _Estado As EstadoTrabajador = pCell.Value

            oTaula = (From Taula In oDTC.EstadoTrabajador Order By Taula.Descripcion Select Taula)

            Dim Var As EstadoTrabajador

            For Each Var In oTaula
                Valors.ValueListItems.Add(Var, Var.Descripcion)
            Next

            pCell.ValueList = Valors.Clone
            pGrid.DisplayLayout.Bands(0).Columns("EstadoTrabajador").Style = ColumnStyle.DropDown

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_Movimientos_M_GRID_BeforeCellActivate(ByRef sender As UltraGrid, ByRef e As CancelableCellEventArgs) Handles GRD_Movimientos.M_GRID_BeforeCellActivate
        If e.Cell.Column.Key = "Vehiculo" Then
            Call CargarCombo_Vehiculo(sender, e.Cell, False)
        End If

        If e.Cell.Column.Key = "Personal" Then
            Call CargarCombo_Personal(sender, e.Cell, False)
        End If

        If e.Cell.Column.Key = "EstadoTrabajador" Then
            Call CargarCombo_EstadoTrabajador(sender, e.Cell, False)
        End If
    End Sub

    Private Sub GRD_Movimientos_M_Grid_InitializeRow(Sender As Object, e As InitializeRowEventArgs) Handles GRD_Movimientos.M_Grid_InitializeRow
        If e.ReInitialize = False Then
            Call CargarCombo_Vehiculo(Sender, e.Row.Cells("Vehiculo"), True)
        End If

        If e.ReInitialize = False Then
            Call CargarCombo_Personal(Sender, e.Row.Cells("Personal"), True)
        End If

        If e.ReInitialize = False Then
            Call CargarCombo_EstadoTrabajador(Sender, e.Row.Cells("EstadoTrabajador"), True)
        End If

        If IsNothing(e.Row.Cells("HorarioTeoricoSalida").Value) = False OrElse e.Row.Cells("HorarioTeoricoSalida").Value <> "" Then
            e.Row.Appearance.BackColor = System.Drawing.Color.LightGreen
        End If

        If e.Row.Cells("ID_EstadoTrabajador").Value = 2 Or e.Row.Cells("ID_EstadoTrabajador").Value = 3 Then
            e.Row.Appearance.BackColor = System.Drawing.Color.LightCoral
        Else
            If IsNothing(e.Row.Cells("HorarioTeoricoSalida").Value) = False OrElse e.Row.Cells("HorarioTeoricoSalida").Value <> "" Then
                e.Row.Appearance.BackColor = System.Drawing.Color.LightGreen
            Else
                e.Row.Appearance.BackColor = System.Drawing.Color.White
            End If
        End If

    End Sub
    '
    Private Sub GRD_Diagnostic_M_GRID_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles GRD_Movimientos.M_GRID_AfterRowUpdate
        Try
            oDTC.SubmitChanges()
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

#End Region

#Region "Events varis"
    Private Sub TE_Codigo_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles TE_Codigo.EditorButtonClick
        If e.Button.Key = "Lupeta" Then
            Call Cridar_Llistat_Generic()
        End If
    End Sub

    Private Sub B_Actualizar_Click(sender As Object, e As EventArgs) Handles B_Actualizar.Click
        If oLinqMovimientoCabecera.ID_MovimientoCabecera <> 0 AndAlso oLinqMovimientoCabecera.Fecha <> Me.DT_Fecha.Value Then 'fem això pq si tinguessin un dia carregat, canviessin la data i apretessin el botó actualitzar canviarien la data de la cabecerade movimientos
            Exit Sub
        End If

        Call Guardar()
        Call CargaGrid_Movimientos(oLinqMovimientoCabecera.ID_MovimientoCabecera)

    End Sub
#End Region

End Class