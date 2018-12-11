Imports Infragistics.Win
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet


Public Class frmLlistatComprasSuministros

    Dim _DTC As New DTCDataContext(BD.Conexion)
    Dim _Missatge_contador As Integer

#Region "M_ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada()
        Me.AplicarDisseny()


        Me.DT_Inicio.Value = New Date(Now.Year, Now.Month, 1)
        Me.DT_Fin.Value = New Date(Now.Year, Now.Month, Now.Day)


        Call CargaGrid()

    End Sub


#End Region

#Region "Grid"
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Call CargaGrid()
    End Sub

    Private Sub CargaGrid()
        Try
            With Me.GRD

                If IsNothing(Me.DT_Fin.Value) = True Or IsNothing(Me.DT_Inicio.Value) = True Then
                    Mensaje.Mostrar_Mensaje("Tienes que introducir un rango de fechas", M_Mensaje.Missatge_Modo.INFORMACIO,,, True)
                    Exit Sub
                End If

                If Me.DT_Fin.Value < Me.DT_Inicio.Value Then
                    Mensaje.Mostrar_Mensaje("Tienes que introducir un rango de fechas", M_Mensaje.Missatge_Modo.INFORMACIO,,, True)
                    Exit Sub
                End If

                Dim _DT As New DataTable
                If OP_Fecha.Value = "No_filtrar" Then
                    _DT = BD.RetornaDataTable("Select * from C_LCClariana_ListadoComprasSuministros where fechaalbaran between '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' order by CodigoArticulo")
                End If

                If OP_Fecha.Value = "agrupado_articulo" Then
                    _DT = BD.RetornaDataTable("Select CodigoArticulo, DescripcionArticulo, sum(Unidades) as Unidades, sum(ImporteLiquido) as ImporteLiquido from C_LCClariana_ListadoComprasSuministros where fechaalbaran between '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' group by CodigoArticulo, DescripcionArticulo order by CodigoArticulo")
                End If

                If OP_Fecha.Value = "agrupacio_producto_proveedor" Then
                    _DT = BD.RetornaDataTable("Select CodigoArticulo, DescripcionArticulo, CodigoProveedor, RazonSocial, sum(Unidades) as Unidades, sum(ImporteLiquido) as ImporteLiquido from C_LCClariana_ListadoComprasSuministros where fechaalbaran between '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' group by CodigoArticulo, DescripcionArticulo, CodigoProveedor, RazonSocial order by CodigoArticulo")
                End If

                .M.clsUltraGrid.Cargar(_DT)

                .GRID.ActiveRow = Nothing

                Me.GRD.GRID.DisplayLayout.Bands(0).Summaries.Add("ImporteLiquido", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Me.GRD.GRID.DisplayLayout.Bands(0).Columns("ImporteLiquido"), Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn)
                Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("ImporteLiquido").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("ImporteLiquido").DisplayFormat = "{0:#,##0.00} €"
                Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("ImporteLiquido").Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True

                Me.GRD.GRID.DisplayLayout.Bands(0).Summaries.Add("Unidades", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Me.GRD.GRID.DisplayLayout.Bands(0).Columns("Unidades"), Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn)
                Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("Unidades").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("Unidades").DisplayFormat = "{0:#,##0}"
                Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("Unidades").Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True

            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

#End Region
End Class