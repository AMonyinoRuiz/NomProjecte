Imports Infragistics.Win.UltraWinEditors

Public Class frmLlistatSergiSanchezArticlesPerPlanta
    Dim oDTC As New DTCDataContext(BD.Conexion)

    Public Sub Entrada()
        Me.AplicarDisseny()

        Me.TE_Codigo.ButtonsRight("Lupeta").Enabled = True
        Me.DT_Inicio.Value = "1/1/" & Now.Year
        Me.DT_Fin.Value = "31/12/" & Now.Year

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click

        If IsDate(Me.DT_Inicio.Value) And IsDate(Me.DT_Fin.Value) And IsNothing(Me.TE_Codigo.Tag) = False Then

            Dim _CodigoProveedor As String = Me.TE_Codigo.Tag

            Me.GRD.M.clsUltraGrid.Cargar("Select CodigoArticulo, DescripcionArticulo,  Planta, sum(Unidades) as Unidades From C_SergiSanchez_LlistatKGPerPlantaProveidorArticle Where FechaAlbaran between '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' and CodigoProveedor='" & _CodigoProveedor & "' Group By CodigoArticulo, DescripcionArticulo, planta Order by Planta, DescripcionArticulo", BD)

        End If

    End Sub

    Private Sub TE_Codigo_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles TE_Codigo.EditorButtonClick
        If e.Button.Key = "Lupeta" Then
            Call Cridar_Llistat_Generic()
        End If
    End Sub

    Private Sub Cridar_Llistat_Generic()
        Dim LlistatGeneric As New M_LlistatGeneric.clsLlistatGeneric
        LlistatGeneric.Mostrar_Llistat("SELECT * FROM C_LCClariana_Proveedores ORDER BY Nombre", Me.TE_Codigo, "CodigoProveedor", "Nombre")
        ' AddHandler LlistatGeneric.AlTancarLlistatGeneric, AddressOf AlTancarLlistat
    End Sub

    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub
End Class