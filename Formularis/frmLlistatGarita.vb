Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win


Public Class frmLlistatGarita

    Dim oDTC As New DTCDataContext(BD.Conexion)

#Region "ToolForm"

    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

#End Region

#Region "Métodes"
    Public Sub Entrada()
        Try
            Me.AplicarDisseny()

            Me.DT_Fecha.Value = Now.Date

            Call CargarGrid(Me.DT_Fecha.Value)

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

#End Region

#Region "Events"

    Private Sub B_Buscar_Click(sender As Object, e As EventArgs) Handles B_Buscar.Click
        Call CargarGrid(Me.DT_Fecha.Value)
    End Sub

#End Region

#Region "Grid"
    Private Sub CargarGrid(ByVal pFecha As Date)
        Try

            Me.L_MovimientosDia.Text = "Movimientos del dia: " & pFecha

            Dim _Planta As Integer = Seguretat.oUser.CampoAux1

            Dim _Movimiento As IEnumerable(Of Movimiento) = From taula In oDTC.Movimiento Where taula.MovimientoCabecera.Fecha = pFecha And taula.Vehiculo.ID_Planta = _Planta And taula.ID_EstadoTrabajador = CInt(EnumEstadoTrabajador.Trabajo) Order By taula.ID_Movimiento Select taula

            With Me.GRD

                '.GRID.DataSource = _Asignacion
                .M.clsUltraGrid.CargarIEnumerable(_Movimiento)
                .M_Editable()
                .M_TreureFocus()

                .GRID.DisplayLayout.Bands(0).Columns("Vehiculo").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .GRID.DisplayLayout.Bands(0).Columns("Personal").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .GRID.DisplayLayout.Bands(0).Columns("Descripcion").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .GRID.DisplayLayout.Bands(0).Columns("HorarioEntrada").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .GRID.DisplayLayout.Bands(0).Columns("HorarioTeoricoSalida").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .GRID.DisplayLayout.Bands(0).Columns("EstadoTrabajador").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

                .GRID.DisplayLayout.Bands(0).Columns("HorarioTeoricoSalida").Style = ColumnStyle.Time
                .GRID.DisplayLayout.Bands(0).Columns("HorarioRealSalida").Style = ColumnStyle.Time
                .GRID.DisplayLayout.Bands(0).Columns("HorarioRealLlegada").Style = ColumnStyle.Time

                .GRID.DisplayLayout.Bands(0).Columns("pDiferenciaTeoricAmbReal").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .GRID.DisplayLayout.Bands(0).Columns("pDiferenciaEntradaAmbSortida").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

                .GRID.ActiveRow = Nothing



                'If oDTC.MovimientoCabecera.Where(Function(F) F.Fecha > Me.DT_Fecha.Value).Count > 0 Then
                '    Me.GRD.di
                'End If
            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_M_Grid_InitializeRow(Sender As Object, e As InitializeRowEventArgs) Handles GRD.M_Grid_InitializeRow
        If e.ReInitialize = False Then
            Call CargarCombo_Vehiculo(Sender, e.Row.Cells("Vehiculo"), True)
        End If

        If e.ReInitialize = False Then
            Call CargarCombo_Personal(Sender, e.Row.Cells("Personal"), True)
        End If

        If e.ReInitialize = False Then
            Call CargarCombo_EstadoTrabajador(Sender, e.Row.Cells("EstadoTrabajador"), True)
        End If

        If IsNothing(e.Row.Cells("HorarioRealLlegada").Value) = False OrElse e.Row.Cells("HorarioRealLlegada").Value <> "" Then
            e.Row.Appearance.BackColor = System.Drawing.Color.LightGreen
        End If

        '  Dim _Movimiento As Movimiento = e.Row.ListObject

        If Me.DT_Fecha.Value < Now.Date Then 'no permetrem modificar hores si no es el dia d'avui
            e.Row.Activation = Activation.NoEdit
        End If

        If IsNothing(e.Row.Cells("pDiferenciaTeoricAmbReal").Value) = False AndAlso e.Row.Cells("pDiferenciaTeoricAmbReal").Value > 15 Then
            e.Row.Cells("pDiferenciaTeoricAmbReal").Appearance.ForeColor = Color.Red
        End If
    End Sub

    Private Sub GRD_M_GRID_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles GRD.M_GRID_AfterRowUpdate
        Try
            oDTC.SubmitChanges()
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

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

#End Region

End Class