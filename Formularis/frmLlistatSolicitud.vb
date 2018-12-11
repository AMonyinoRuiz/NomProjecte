Public Class frmLlistatSolicitud

#Region "M_ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub
#End Region

#Region "Metodes"

    Public Sub Entrada()
        Me.AplicarDisseny()
        Util.Cargar_Combo(Me.C_Usuari, "SELECT ID_Usuario, Nombre FROM Usuario Where Activo=1 and CampoAux2 is not null ORDER BY Nombre", True, True)

        If Seguretat.oUser.CampoAux2 = EnumTipusUsuari.Solicitant Then
            Me.C_Usuari.ReadOnly = True
            Me.C_Usuari.Value = Seguretat.oUser.ID_Usuario
        Else
            Me.C_Usuari.Value = 0
        End If

        Call BuscarLlistat()

    End Sub

    Private Sub BuscarLlistat()
        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Dim _DT As New DataTable 'CReeem les columnes

        _DT.Columns.Add("ID_Solicitud", GetType(Integer))
        _DT.Columns.Add("FechaAlta", GetType(Date))
        _DT.Columns.Add("Mes", GetType(String))
        _DT.Columns.Add("Solicitante", GetType(String))
        _DT.Columns.Add("ID_Estado", GetType(String))
        _DT.Columns.Add("Estado", GetType(String))
        _DT.Columns.Add("Tipo", GetType(String))
        _DT.Columns.Add("Destino", GetType(String))
        _DT.Columns.Add("TipoMateria", GetType(String))
        _DT.Columns.Add("Urgencia", GetType(String))

        Dim _ValorsGrid As DataTable
        If Me.C_Usuari.Value = 0 Then
            _ValorsGrid = BD.RetornaDataTable("Select * From C_Solicitud Where Activo=1 order by ID_SolicitudEstado, DataAlta")
        Else
            _ValorsGrid = BD.RetornaDataTable("Select * From C_Solicitud where Activo = 1 and ID_Usuario = " & Me.C_Usuari.Value & " order by ID_SolicitudEstado, DataAlta")
        End If

        Me.GRD.M.clsUltraGrid.Cargar(_ValorsGrid)

        For Each _pRow In Me.GRD.GRID.Rows
            Select Case _pRow.Cells("ID_SolicitudEstado").Value
                Case CInt(EnumEstatsSolicitud.Aceptada)
                    _pRow.Appearance.BackColor = Color.LightGreen
                Case CInt(EnumEstatsSolicitud.Denegada)
                    _pRow.Appearance.BackColor = Color.LightCoral
                Case CInt(EnumEstatsSolicitud.EnCurso)
                    _pRow.Appearance.BackColor = Color.LightSkyBlue
                Case CInt(EnumEstatsSolicitud.Pendiente)
                    _pRow.Appearance.BackColor = Color.LightYellow
            End Select
        Next

        If Seguretat.oUser.CampoAux2 = "2" Then 'Un solicitante no podrà eliminar una solicitud
            Me.GRD.ToolGrid.Tools("Eliminar").SharedProps.Enabled = False
        End If
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Call BuscarLlistat()
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                'oClsControls.ControlBuit(.TE_Codigo)
                oClsControls.ControlBuit(.C_Usuari)
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

#End Region

#Region "Grid"
    Private Sub GRD_M_ToolGrid_ToolEditar(ByRef sender As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager, ByRef e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles GRD.M_ToolGrid_ToolEditar
        Call GRD_M_ToolGrid_ToolVisualitzarDobleClickRow()
    End Sub

    Private Sub GRD_M_ToolGrid_ToolVisualitzarDobleClickRow() Handles GRD.M_ToolGrid_ToolVisualitzarDobleClickRow
        If Me.GRD.GRID.Selected.Rows.Count <> 1 Then
            Exit Sub
        End If

        Dim frm As New frmSolicitud
        frm.Entrada(Me.GRD.GRID.Selected.Rows(0).Cells("ID_Solicitud").Value)
        AddHandler frm.FormClosing, AddressOf AlTancarFrm
        frm.FormObrir(Me, True)
    End Sub

    Private Sub GRD_M_ToolGrid_ToolAfegir(ByRef sender As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager, ByRef e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles GRD.M_ToolGrid_ToolAfegir

        If Seguretat.oUser.CampoAux2 Is Nothing = True OrElse Seguretat.oUser.CampoAux2.Length < 1 Then
            Mensaje.Mostrar_Mensaje("No puedes dar de alta una solicitud si no eres un Autorizador o Solicitante", M_Mensaje.Missatge_Modo.ERRORS, , , True)
            Exit Sub
        End If

        Try
            Dim frm As New frmSolicitud
            frm.Entrada()
            AddHandler frm.FormClosing, AddressOf AlTancarFrm
            frm.FormObrir(Me, True)
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    Private Sub GRD_M_ToolGrid_ToolEliminar(ByRef sender As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager, ByRef e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles GRD.M_ToolGrid_ToolEliminar
        Try
            If Me.GRD.GRID.Selected.Cells.Count = 0 And Me.GRD.GRID.Selected.Rows.Count = 0 Then
                Exit Sub
            End If

            If Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE_PREGUNTA) = M_Mensaje.Botons.SI Then

                Dim pRow As Infragistics.Win.UltraWinGrid.UltraGridRow = Me.GRD.GRID.Selected.Rows(0)

                Dim _ID As Integer = pRow.Cells("ID_Solicitud").Value

                BD.EjecutarConsulta("Delete From SolicitudPersonaAsignada Where ID_Solicitud=" & _ID)
                BD.EjecutarConsulta("Delete From Solicitud Where ID_Solicitud=" & _ID)

                Call BuscarLlistat()

                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE)
                'pRow.Hidden = True
            End If

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub AlTancarFrm()
        Call Buscar_Click(Nothing, Nothing)
    End Sub
#End Region

End Class