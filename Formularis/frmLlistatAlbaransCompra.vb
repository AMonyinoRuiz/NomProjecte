Imports Infragistics.Win


Public Class frmLlistatAlbaransCompra
    Dim _DTC As New DTCDataContext(BD.Conexion)

#Region "M_ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub


#End Region

#Region "Metodes"

    Public Sub Entrada()
        Me.AplicarDisseny()
        Util.Cargar_Combo(Me.C_Planta, "SELECT ID_Planta, Descripcion FROM Planta Where Activo=1 and ID_Planta <> 10 ORDER BY Descripcion", True, True)

        Me.DT_Inicio.Value = New Date(Now.Year, Now.Month, Now.Day)
        Me.DT_Fin.Value = New Date(Now.Year, Now.Month, Now.Day)

        If IsNothing(Seguretat.oUser.CampoAux1) = False And IsDBNull(Seguretat.oUser.CampoAux1) = False Then
            Me.C_Planta.Value = Seguretat.oUser.CampoAux1
            If Seguretat.oUser.CampoAux1 = 1 Then
                Me.C_Planta.ReadOnly = False
            Else
                Me.C_Planta.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub BuscarLlistat()
        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Dim _SQL As String = ""
        If Me.CH_RAE.Checked = True Then
            _SQL = " and (CodigoArticulo = '210GAE' or CodigoArticulo = '216') "
        End If

        Dim _ValorsGrid As DataTable

        If Me.OP.Value = "compra" Then
            If Me.C_Planta.Value = 0 Then
                _ValorsGrid = BD.RetornaDataTable("Select * From C_LCClariana_LlistatAlbaranesCompra where FechaAlbaran BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' " & _SQL & " order by NumeroAlbaran", True)
            Else
                Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA
                _ValorsGrid = BD.RetornaDataTable("Select * From C_LCClariana_LlistatAlbaranesCompra where FechaAlbaran BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' " & _SQL & " and Planta = '" & _Planta & "' order by NumeroAlbaran", True)
            End If
        Else
            If Me.C_Planta.Value = 0 Then
                _ValorsGrid = BD.RetornaDataTable("Select * From C_LCClariana_LlistatAlbaranesVenta where FechaAlbaran BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' " & _SQL & " order by NumeroAlbaran", True)
            Else
                Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA
                _ValorsGrid = BD.RetornaDataTable("Select * From C_LCClariana_LlistatAlbaranesVenta where FechaAlbaran BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' " & _SQL & " and Planta = '" & _Planta & "' order by NumeroAlbaran", True)
            End If
        End If

        Me.GRD.M.clsUltraGrid.Cargar(_ValorsGrid)

        Me.GRD.GRID.DisplayLayout.Bands(0).Summaries.Add("Total1", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Me.GRD.GRID.DisplayLayout.Bands(0).Columns("Unidades"), Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn)
        Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("Total1").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
        Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("Total1").DisplayFormat = "Total: {0:#,##}"
        Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("Total1").Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True

        If Me.OP.Value = "compra" Then
            Me.GRD.GRID.DisplayLayout.Bands(0).Summaries.Add("Total2", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Me.GRD.GRID.DisplayLayout.Bands(0).Columns("Unidades2"), Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn)
            Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("Total2").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("Total2").DisplayFormat = "Total: {0:#,##}"
            Me.GRD.GRID.DisplayLayout.Bands(0).Summaries("Total2").Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
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
                oClsControls.ControlBuit(.C_Planta)
                oClsControls.ControlBuit(.DT_Inicio)
                oClsControls.ControlBuit(.DT_Fin)
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

#End Region

End Class