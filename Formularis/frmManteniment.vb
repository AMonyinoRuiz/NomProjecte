Imports Excel = Microsoft.Office.Interop.Excel
Imports Scripting
Imports Infragistics.Win.UltraWinGrid
Imports System.Xml

Public Class frmManteniment
    Implements IDisposable

    Dim DT As New DataTable
    Dim oDA As SqlClient.SqlDataAdapter
    Dim oDTC As DTCDataContext

    Public Sub Entrada()
        Me.AplicarDisseny()
        Util.Cargar_Combo(Me.C_Taula, "SELECT Tabla, Descripcion From Maestro order by Descripcion", False, False)
        Me.KeyPreview = False
        Me.AccessibleName = Me.C_Taula.Value

        '  Dim _IDMestre As Integer = pIDMestre
        oDTC = New DTCDataContext(BD.Conexion)
        '  Dim _Mestre As Maestro = oDTC.Maestro.Where(Function(F) F.ID_Maestro = _IDMestre).FirstOrDefault
        '  Me.C_Taula.SelectedIndex = Util.Buscar_en_Combo(Me.C_Taula, _Mestre.Tabla)

        'Me.ToolForm.M.clsToolBar.Afegir_Boto("Eliminar Propuesta")
    End Sub

    Private Sub C_Taula_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C_Taula.SelectionChanged
        Try
            Dim oCmd As New SqlClient.SqlCommand
            Dim oCmdBuilder As New SqlClient.SqlCommandBuilder


            DT = New DataTable
            With oCmd
                .CommandType = CommandType.Text
                .CommandText = "SELECT * From " & Me.C_Taula.Value
                .Connection = BD.Conexion
                .CommandTimeout = 1500
                .Transaction = BD.Transaccion
            End With
            oDA = New SqlClient.SqlDataAdapter(oCmd)
            oDA.Fill(DT)
            oCmdBuilder = New SqlClient.SqlCommandBuilder(oDA)
            oDA.UpdateCommand = oCmdBuilder.GetUpdateCommand
            Me.AccessibleName = Me.C_Taula.Value
            Me.GRD.M.clsUltraGrid.Cargar(DT)
            Me.GRD.GRID.DisplayLayout.Bands(0).Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
            Me.GRD.GRID.DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText

            UCP.Visible = False
            Btn_Apli.Visible = False


            Select Case Me.C_Taula.Value
                Case "Informe_Apartado"
                    Call Cargar_Informe()
                Case "Articulo"
                    Call CargarArticuloFamilia()
                Case "BancoCC"
                    Call CargarBanco()
                Case "Proveedor"
                    Call CargarProveedorTipo()
                Case "Vehiculo"
                    Call CargarPlanta()
                Case "AusenciaTipo"
                    UCP.Visible = True
                    Btn_Apli.Visible = True

                    Dim _pRow As UltraGridRow
                    For Each _pRow In GRD.GRID.Rows
                        _pRow.Appearance.BackColor = System.Drawing.Color.FromArgb(_pRow.Cells("Color").Value)
                    Next
            End Select


        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    'Private Sub Cargar_Producto_Familia()
    '    Try
    '        oDTC = New DTCDataContext(BD.Conexion)
    '        Dim Valors As New Infragistics.Win.ValueList
    '        Dim Result = From taula In oDTC.Producto_Familia Where taula.Activo = True Select taula Order By taula.Descripcion Ascending

    '        For Each Producto_Familia In Result
    '            Valors.ValueListItems.Add(Producto_Familia.ID_Producto_Familia, Producto_Familia.Producto_Division.Descripcion & "-" & Producto_Familia.Descripcion)
    '        Next

    '        Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Producto_Familia").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
    '        Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Producto_Familia").ValueList = Valors.Clone
    '        Me.GRD.GRID.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True

    '    Catch ex As Exception
    '        Mensaje.Mostrar_Mensaje_Error(ex)
    '    End Try

    'End Sub

    Private Sub Cargar_Informe()
        Try
            oDTC = New DTCDataContext(BD.Conexion)
            Dim Valors As New Infragistics.Win.ValueList
            Dim Result = From taula In oDTC.Informe Select taula Order By taula.Descripcion Ascending

            For Each Informe In Result
                Valors.ValueListItems.Add(Informe.ID_Informe, Informe.Descripcion)
            Next

            Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Informe").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Informe").ValueList = Valors.Clone
            Me.GRD.GRID.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    Private Sub CargarArticuloFamilia()
        Try
            oDTC = New DTCDataContext(BD.Conexion)
            Dim Valors As New Infragistics.Win.ValueList
            Dim Result = From taula In oDTC.ArticuloFamilia Select taula Order By taula.Descripcion Ascending
            Dim _Familia As ArticuloFamilia

            For Each _Familia In Result
                Valors.ValueListItems.Add(_Familia.ID_ArticuloFamilia, _Familia.Descripcion)
            Next

            Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_ArticuloFamilia").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_ArticuloFamilia").ValueList = Valors.Clone
            Me.GRD.GRID.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    Private Sub CargarBanco()
        Try
            oDTC = New DTCDataContext(BD.Conexion)
            Dim Valors As New Infragistics.Win.ValueList
            Dim Result = From taula In oDTC.Banco Select taula Order By taula.Descripcion Ascending
            Dim _Banco As Banco

            For Each _Banco In Result
                Valors.ValueListItems.Add(_Banco.ID_Banco, _Banco.Descripcion)
            Next

            Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Banco").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Banco").ValueList = Valors.Clone
            Me.GRD.GRID.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    Private Sub CargarPlanta()
        Try
            oDTC = New DTCDataContext(BD.Conexion)
            Dim Valors As New Infragistics.Win.ValueList
            Dim Result = From taula In oDTC.Planta Select taula Order By taula.Descripcion Ascending
            Dim _Planta As Planta

            For Each _Planta In Result
                Valors.ValueListItems.Add(_Planta.ID_Planta, _Planta.Descripcion)
            Next

            Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Planta").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Planta").ValueList = Valors.Clone
            Me.GRD.GRID.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub CargarProveedorTipo()
        Try
            oDTC = New DTCDataContext(BD.Conexion)
            Dim Valors As New Infragistics.Win.ValueList
            Dim Result = From taula In oDTC.ProveedorTipo Select taula Order By taula.Descripcion Ascending
            Dim _Tipo As ProveedorTipo

            For Each _Tipo In Result
                Valors.ValueListItems.Add(_Tipo.ID_ProveedorTipo, _Tipo.Descripcion)
            Next

            Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_ProveedorTipo").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_ProveedorTipo").ValueList = Valors.Clone
            Me.GRD.GRID.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    'Private Sub Cargar_Propuesta_Estado()
    '    Try
    '        oDTC = New DTCDataContext(BD.Conexion)
    '        Dim Valors As New Infragistics.Win.ValueList
    '        Dim Result = From taula In oDTC.Propuesta_Estado Select taula Order By taula.Codigo Ascending

    '        For Each Propuesta_Estado In Result
    '            Valors.ValueListItems.Add(Propuesta_Estado.ID_Propuesta_Estado, Propuesta_Estado.Descripcion)
    '        Next

    '        Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Propuesta_Estado").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
    '        Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Propuesta_Estado").ValueList = Valors.Clone
    '        Me.GRD.GRID.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True

    '    Catch ex As Exception
    '        Mensaje.Mostrar_Mensaje_Error(ex)
    '    End Try

    'End Sub

    'Private Sub GRD_M_GRID_AfterRowUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles GRD.M_GRID_AfterRowUpdate
    '    Call M_ToolForm1_m_ToolForm_Guardar()
    'End Sub

    Private Sub GRD_M_Grid_InitializeRow(Sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles GRD.M_Grid_InitializeRow
        If e.Row.Band.Columns.Exists("RO") = True Then
            If IsDBNull(e.Row.Cells("RO").Value) = False AndAlso e.Row.Cells("RO").Value = True Then
                e.Row.Activation = Infragistics.Win.UltraWinGrid.Activation.Disabled
            End If
        End If
    End Sub

    'Private Sub Cargar_Producto_Subfamilia()
    '    Try
    '        oDTC = New DTCDataContext(BD.Conexion)
    '        Dim Valors As New Infragistics.Win.ValueList
    '        Dim Result = From taula In oDTC.Producto_SubFamilia Where taula.Activo = True Select taula Order By taula.Descripcion Ascending

    '        For Each Producto_SubFamilia In Result
    '            Valors.ValueListItems.Add(Producto_SubFamilia.ID_Producto_SubFamilia, Producto_SubFamilia.Descripcion)
    '        Next

    '        Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Producto_SubFamilia").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
    '        Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ID_Producto_SubFamilia").ValueList = Valors.Clone
    '        Me.GRD.GRID.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True

    '    Catch ex As Exception
    '        Mensaje.Mostrar_Mensaje_Error(ex)
    '    End Try

    'End Sub

    Private Sub GRD_M_ToolGrid_ToolAfegir(ByRef sender As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager, ByRef e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles GRD.M_ToolGrid_ToolAfegir
        Me.GRD.GRID.DisplayLayout.Bands(0).AddNew()

        If Me.GRD.GRID.DisplayLayout.Bands(0).Columns.Exists("RO") = True Then
            Me.GRD.GRID.Rows(Me.GRD.GRID.Rows.Count - 1).Cells("RO").Value = False
        End If

        If Me.GRD.GRID.DisplayLayout.Bands(0).Columns.Exists("ACtivo") = True Then
            Me.GRD.GRID.Rows(Me.GRD.GRID.Rows.Count - 1).Cells("Activo").Value = True
        End If

        Select Case Me.C_Taula.Value
            Case "AusenciaTipo"
                Me.GRD.GRID.Rows(Me.GRD.GRID.Rows.Count - 1).Cells("ComptaPerHores").Value = True
                Me.GRD.GRID.Rows(Me.GRD.GRID.Rows.Count - 1).Cells("Desconta_20_min").Value = False
                Me.GRD.GRID.Rows(Me.GRD.GRID.Rows.Count - 1).Cells("Conta_Festius").Value = False
                Me.GRD.GRID.Rows(Me.GRD.GRID.Rows.Count - 1).Cells("Color").Value = -986896
                Me.GRD.GRID.Rows(Me.GRD.GRID.Rows.Count - 1).Appearance.BackColor = System.Drawing.Color.FromArgb(-986896)
                'Me.GRD.M_TreureFocus()
        End Select
    End Sub

    Private Sub M_ToolForm1_m_ToolForm_Guardar() Handles ToolForm.m_ToolForm_Guardar
        Try
            Me.GRD.GRID.UpdateData()
            oDA.Update(DT)
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_MODIFICAR_REGISTRE)
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje("Error al eliminar el registro, el registro eliminado tiene relación con otros registros de una o más tablas", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)
            Call C_Taula_SelectionChanged(Nothing, Nothing)

        End Try
    End Sub

    Private Sub M_ToolForm1_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

    Private Sub GRD_M_ToolGrid_ToolEliminarRow(ByRef sender As Infragistics.Win.UltraWinGrid.UltraGrid, ByRef e As Infragistics.Win.UltraWinGrid.UltraGridRow) Handles GRD.M_ToolGrid_ToolEliminarRow
        'If e.Band.Columns.Exists("RO") = True AndAlso e.Cells("RO").Value = True Then
        '    Mensaje.Mostrar_Mensaje("Imposible eliminar, este registro es del sistema", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)
        '    Exit Sub
        'End If
    End Sub

    Private Sub GRD_M_ToolGrid_ToolEliminar(ByRef sender As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager, ByRef e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles GRD.M_ToolGrid_ToolEliminar
        If Me.GRD.GRID.ActiveRow Is Nothing Then
            Exit Sub
        End If

        If Me.GRD.GRID.DisplayLayout.Bands(0).Columns.Exists("RO") = True AndAlso Me.GRD.GRID.ActiveRow.Cells("RO").Value = True Then
            Mensaje.Mostrar_Mensaje("Imposible eliminar, este registro es del sistema", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)
            Exit Sub
        End If

        Me.GRD.GRID.ActiveRow.Delete(False)
        Call M_ToolForm1_m_ToolForm_Guardar()
    End Sub


    Private Sub Btn_Apli_Click(sender As Object, e As EventArgs) Handles Btn_Apli.Click

        If Me.GRD.GRID.ActiveRow Is Nothing Then
            Mensaje.Mostrar_Mensaje("Selecciona una fila primer", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)
            Exit Sub
        End If

        Me.GRD.GRID.ActiveRow.Cells("Color").Value = Me.UCP.Color.ToArgb

        'Carles
        'Me.GRD.GRID.ActiveRow.Appearance.BackColor = Me.UCP.Color

        Me.GRD.GRID.ActiveRow.Appearance.BackColor = System.Drawing.Color.FromArgb(Me.GRD.GRID.ActiveRow.Cells("Color").Value)
        'Me.GRD.M_TreureFocus()
    End Sub

    Private Sub GRD_M_GRID_ClickRow2(ByRef sender As M_UltraGrid.m_UltraGrid, ByRef e As UltraGridRow) Handles GRD.M_GRID_ClickRow2

        Select Case Me.C_Taula.Value
            Case "AusenciaTipo"
                Me.UCP.Color = System.Drawing.Color.FromArgb(Me.GRD.GRID.ActiveRow.Cells("Color").Value)

                If Me.GRD.GRID.ActiveCell.Column.Key = "Desconta_20_min" Then
                    If Me.GRD.GRID.ActiveRow.Cells("ComptaPerHores").Value = True And Me.GRD.GRID.ActiveRow.Cells("Desconta_20_min").Value = False Then
                        Mensaje.Mostrar_Mensaje("No puedes activar la opción de descontar 20 minutos en ausencias que computan por horas", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                        Me.GRD.GRID.ActiveRow.Cells("Desconta_20_min").Value = False
                    End If
                End If

                If Me.GRD.GRID.ActiveCell.Column.Key = "ComptaPerHores" Then
                    If Me.GRD.GRID.ActiveRow.Cells("ComptaPerHores").Value = False And Me.GRD.GRID.ActiveRow.Cells("Desconta_20_min").Value = True Then
                        Mensaje.Mostrar_Mensaje("No puedes activar la opción de descontar 20 minutos en ausencias que computan por horas", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                        Me.GRD.GRID.ActiveRow.Cells("ComptaPerHores").Value = False
                    End If
                End If
        End Select
    End Sub

    Private Sub UltraButton3_Click(sender As Object, e As EventArgs) Handles UltraButton3.Click
        Dim _Ausencia As Personal_Ausencia
        For Each _Ausencia In oDTC.Personal_Ausencia.Where(Function(F) F.ID_AusenciaTipo = 49)

            Dim _AusenciaFestiva As Integer = oDTC.DiaFiesta.Where(Function(F) F.Data = _Ausencia.Fecha).Count
            If _AusenciaFestiva > 0 Or Weekday(_Ausencia.Fecha, FirstDayOfWeek.Monday) = 6 Or Weekday(_Ausencia.Fecha, FirstDayOfWeek.Monday) = 7 Then
                'MsgBox(_Ausencia.Fecha & " - " & Weekday(_Ausencia.Fecha, FirstDayOfWeek.Monday))
                oDTC.Personal_Ausencia.DeleteOnSubmit(_Ausencia)
                oDTC.SubmitChanges()
            End If

        Next
    End Sub

    Private Sub DataColumn(p1 As Object)
        Throw New NotImplementedException
    End Sub

End Class