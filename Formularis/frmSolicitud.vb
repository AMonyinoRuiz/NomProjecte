Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmSolicitud
    Implements IDisposable
    Dim oDTC As DTCDataContext
    Dim oLinqSolicitud As Solicitud
    Dim Fichero As M_Archivos_Binarios.clsArchivosBinarios2


#Region "M_ToolForm"

    Private Sub M_ToolForm1_m_ToolForm_Guardar() Handles ToolForm.m_ToolForm_Guardar
        Call Guardar()
    End Sub

    Private Sub M_ToolForm1_m_ToolForm_Sortir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

    Private Sub ToolForm_m_ToolForm_Buscar() Handles ToolForm.m_ToolForm_Buscar
        Call Cridar_Llistat_Generic()
    End Sub

    Private Sub ToolForm_m_ToolForm_Eliminar() Handles ToolForm.m_ToolForm_Eliminar
        Try
            If oLinqSolicitud.ID_Solicitud <> 0 Then
                If Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE_PREGUNTA) = M_Mensaje.Botons.SI Then
                    oLinqSolicitud.Activo = False
                    oDTC.SubmitChanges()
                    Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE)
                    Me.FormTancar()
                End If
            End If
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)

        End Try
    End Sub

    Private Sub ToolForm_m_ToolForm_Imprimir() Handles ToolForm.m_ToolForm_Imprimir

        If oLinqSolicitud.ID_Solicitud = 0 Then
            Exit Sub
        End If

        Informes.ObrirInformePreparacio(oDTC, 2, "[ID_Solicitud] = '" & Me.TE_Codigo.Value & "'", "Solicitud: " & Me.TE_Codigo.Value, , , , , , False)
    End Sub

    Private Sub ToolForm_m_ToolForm_ToolClick_Botones_Extras(Sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles ToolForm.m_ToolForm_ToolClick_Botones_Extras

        If oLinqSolicitud.ID_Solicitud = 0 Then
            Mensaje.Mostrar_Mensaje("No hay una solicitud cargada en la pantalla", M_Mensaje.Missatge_Modo.ERRORS, , , True)
        Else
            Select Case e.Tool.Key
                Case "PasarSolicitudAEnCurso"
                    Me.C_Estado.Value = CInt(EnumEstatsSolicitud.EnCurso)
                    Me.DT_CambioEstado.Value = Now
                    Me.CH_LeidoSolicitante.Checked = False
                    Call Guardar()
                Case "PasarSolicitudAPendiente"
                    Me.C_Estado.Value = CInt(EnumEstatsSolicitud.Pendiente)
                    Me.DT_CambioEstado.Value = Now
                    Me.CH_LeidoSolicitante.Checked = False
                    Call Guardar()
                Case "PasarSolicitudAAceptada"
                    Me.C_Estado.Value = CInt(EnumEstatsSolicitud.Aceptada)
                    Me.CH_LeidoSolicitante.Checked = False
                    Me.DT_CambioEstado.Value = Now
                    Call Guardar()
                Case "PasarSolicitudADenegada"
                    Me.C_Estado.Value = CInt(EnumEstatsSolicitud.Denegada)
                    Me.CH_LeidoSolicitante.Checked = False
                    Me.DT_CambioEstado.Value = Now
                    Call Guardar()
            End Select
        End If
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada(Optional ByVal pID As Integer = 0)

        Try

            Me.AplicarDisseny()

            Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = True

            Fichero = New M_Archivos_Binarios.clsArchivosBinarios2(BD, Me.GRD_Ficheros, "Solicitud_Archivo", 1)

            Util.Cargar_Combo(Me.C_Estado, "SELECT ID_SolicitudEstado, Descripcion FROM SolicitudEstado ORDER BY ID_SolicitudEstado", False)
            Util.Cargar_Combo(Me.C_Usuario, "SELECT ID_Usuario, Nombre FROM Usuario Where Activo=1 and CampoAux2 is not null ORDER BY Nombre", False)
            Util.Cargar_Combo(Me.C_Planta, "SELECT ID_Planta, Descripcion FROM Planta Where Activo = 1 ORDER BY ID_Planta desc", False)
            Util.Cargar_Combo(Me.C_TipoMaterial, "SELECT ID_SolicitudTipoMaterial, Descripcion FROM SolicitudTipoMaterial ORDER BY ID_SolicitudTipoMaterial", False)
            Util.Cargar_Combo(Me.C_Tipo, "SELECT ID_SolicitudTipo, Descripcion FROM SolicitudTipo ORDER BY ID_SolicitudTipo", False)
            Util.Cargar_Combo(Me.C_Urgencia, "SELECT ID_SolicitudUrgencia, Descripcion FROM SolicitudUrgencia ORDER BY ID_SolicitudUrgencia", False)

            Me.ToolForm.M.Botons.tNou.SharedProps.Visible = False
            Me.ToolForm.M.Botons.tAccions.SharedProps.Visible = True
            Me.ToolForm.M.clsToolBar.Afegir_BotoAccions("PasarSolicitudAEnCurso", "Pasar a 'En Curso'", True)
            Me.ToolForm.M.clsToolBar.Afegir_BotoAccions("PasarSolicitudAPendiente", "Pasar a 'Pendiente'", True)
            Me.ToolForm.M.clsToolBar.Afegir_BotoAccions("PasarSolicitudAAceptada", "Aceptar solicitud", True)
            Me.ToolForm.M.clsToolBar.Afegir_BotoAccions("PasarSolicitudADenegada", "Denegar solicitud", True)

           
            If pID <> 0 Then
                Call Cargar_Form(pID)
            Else
                Call Netejar_Pantalla()
            End If

            Me.KeyPreview = False

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    Private Function Guardar() As Boolean
        Guardar = False
        Try
            Me.TE_Codigo.Focus()

            If ComprovacioCampsRequeritsError() = True Then
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
                Exit Function
            End If

            Call GetFromForm(oLinqSolicitud)

            If oLinqSolicitud.ID_Solicitud = 0 Then  ' Comprovacio per saber si es un insertar o un nou
                oDTC.Solicitud.InsertOnSubmit(oLinqSolicitud)

                oDTC.SubmitChanges()

                Me.TE_Codigo.Value = oLinqSolicitud.ID_Solicitud

                Call Fichero.Cargar_GRID(oLinqSolicitud.ID_Solicitud)

                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_AFEGIR_REGISTRE)
                '  Call CargaGrid_PersonasAsignadas(oLinqExpediente.ID_Expediente)  'Fem això pq al apretar el botó afegir de la grid de personal, si la acció no estava guardada peta

            Else
                oDTC.SubmitChanges()
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_MODIFICAR_REGISTRE)
            End If

            Me.EstableixCaptionForm("Solicitud: " & (oLinqSolicitud.ID_Solicitud))

            Call BloqujarBotonsEstat()

            Guardar = True

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Private Sub SetToForm()
        Try
            With oLinqSolicitud

                Me.TE_Codigo.Text = .ID_Solicitud
                Me.C_Usuario.Value = .ID_Usuario
                Me.T_Concepto.Text = .Concepto
                Me.DT_Alta.Value = .DataAlta
                Me.DT_FechaEntrega.Value = .FechaEntrega
                Me.C_Estado.Value = .ID_SolicitudEstado
                Me.C_Planta.Value = .ID_Planta
                Me.C_Tipo.Value = .ID_SolicitudTipo
                Me.C_TipoMaterial.Value = .ID_SolicitudTipoMaterial
                Me.C_Urgencia.Value = .ID_SolicitudUrgencia
                Me.T_ImporteAproximado.Value = DbnullToNothing(.ImporteAproximado)
                Me.T_Motivo.Text = .Motivo
                Me.T_ObservacionesAutorizador.Text = .ObservacionesDelEstado
                Me.DT_CambioEstado.Value = .DataCambioEstado
                Me.CH_LeidoSolicitante.Checked = .LeidoSolicitante
                Me.CH_LeidoAutorizador.Checked = .LeidoAutorizador
                Me.CH_PedidoRealizado.Checked = .PedidoRealizado

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GetFromForm(ByRef pSolicitud As Solicitud)
        Try
            With pSolicitud
                If pSolicitud.ID_Solicitud = 0 Then
                    .Activo = True
                    .Usuario = oDTC.Usuario.Where(Function(F) F.ID_Usuario = CInt(Me.C_Usuario.Value)).FirstOrDefault
                    .DataAlta = Me.DT_Alta.Value
                End If
                .Concepto = Me.T_Concepto.Text
                .DataCambioEstado = Me.DT_CambioEstado.Value
                .FechaEntrega = Me.DT_FechaEntrega.Value
                .Planta = oDTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault
                .SolicitudEstado = oDTC.SolicitudEstado.Where(Function(F) F.ID_SolicitudEstado = CInt(Me.C_Estado.Value)).FirstOrDefault
                .SolicitudTipo = oDTC.SolicitudTipo.Where(Function(F) F.ID_SolicitudTipo = CInt(Me.C_Tipo.Value)).FirstOrDefault
                .SolicitudTipoMaterial = oDTC.SolicitudTipoMaterial.Where(Function(F) F.ID_SolicitudTipoMaterial = CInt(Me.C_TipoMaterial.Value)).FirstOrDefault
                .SolicitudUrgencia = oDTC.SolicitudUrgencia.Where(Function(F) F.ID_SolicitudUrgencia = CInt(Me.C_Urgencia.Value)).FirstOrDefault


                .LeidoAutorizador = Me.CH_LeidoAutorizador.Checked
                .LeidoSolicitante = Me.CH_LeidoSolicitante.Checked
                .PedidoRealizado = Me.CH_PedidoRealizado.Checked

                .ImporteAproximado = DbnullToNothing(Me.T_ImporteAproximado.Value)
                .Motivo = Me.T_Motivo.Text
                .ObservacionesDelEstado = Me.T_ObservacionesAutorizador.Text

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Cargar_Form(ByVal pID As Integer)
        Try
            Call Netejar_Pantalla()

            Call Fichero.Cargar_GRID(pID)

            oLinqSolicitud = (From taula In oDTC.Solicitud Where taula.ID_Solicitud = pID Select taula).First

            Call SetToForm()

            Call CargaGrid_PersonasAsignadas(pID)

            Me.EstableixCaptionForm("Solicitud: " & (oLinqSolicitud.ID_Solicitud))

            Call BloqujarBotonsEstat()

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Netejar_Pantalla()

        oLinqSolicitud = New Solicitud
        oDTC = New DTCDataContext(BD.Conexion)

        Util.Blanquejar(Me, M_Util.Enum_Controles_Activacion.TODOS, True)

        Me.TE_Codigo.Value = Nothing
        Me.TE_Codigo.Tag = Nothing
        Me.DT_Alta.Value = Now
        Me.DT_CambioEstado.Value = Now


        Me.DT_FechaEntrega.Value = Nothing
        ' Me.DT_FechaEntrega.ReadOnly = True

        Call Fichero.Cargar_GRID(0)

        Me.C_Usuario.Value = Seguretat.oUser.ID_Usuario
        Me.C_Estado.Value = 1
        Me.C_Planta.value = Seguretat.oUser.CampoAux1
        Me.C_TipoMaterial.SelectedIndex = -1
        Me.C_Tipo.SelectedIndex = -1
        Me.C_Urgencia.SelectedIndex = -1
        'Me.DT_FechaEntrega.Value = Now.AddDays(10)  'posat per la marta qui sap pq

        Me.ToolForm.ToolForm.Tools("PasarSolicitudAEnCurso").SharedProps.Enabled = False
        Me.ToolForm.ToolForm.Tools("PasarSolicitudAPendiente").SharedProps.Enabled = False
        Me.ToolForm.ToolForm.Tools("PasarSolicitudAAceptada").SharedProps.Enabled = False
        Me.ToolForm.ToolForm.Tools("PasarSolicitudADenegada").SharedProps.Enabled = False

        Me.CH_PedidoRealizado.Checked = False

        If Seguretat.oUser.CampoAux2 <> EnumTipusUsuari.Autoritzador Then
            Me.T_ObservacionesAutorizador.ReadOnly = True
            Me.CH_LeidoAutorizador.Checked = False
            Me.CH_LeidoSolicitante.Checked = True
            Me.CH_PedidoRealizado.Enabled = False
            Me.DT_FechaEntrega.ReadOnly = True
        Else
            Me.CH_LeidoAutorizador.Checked = True
            Me.CH_LeidoSolicitante.Checked = True
            Me.CH_PedidoRealizado.Enabled = True
            Me.DT_FechaEntrega.ReadOnly = False
        End If


        Me.Tab_Principal.Tabs("General").Selected = True

        Call CargaGrid_PersonasAsignadas(0)

        Me.EstableixCaptionForm("Solicitud")

        ErrorProvider1.Clear()

        Call Permisos()
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                oClsControls.ControlBuit(.DT_Alta)
                oClsControls.ControlBuit(.T_Concepto)
                oClsControls.ControlBuit(.T_Motivo)
                oClsControls.ControlBuit(.C_Estado)
                oClsControls.ControlBuit(.C_Planta)
                oClsControls.ControlBuit(.C_Tipo)
                oClsControls.ControlBuit(.C_TipoMaterial)
                oClsControls.ControlBuit(.C_Usuario)
                oClsControls.ControlBuit(.C_Urgencia)
                '  oClsControls.ControlBuit(.DT_FechaEntrega)
                '  oClsControls.ControlBuit(.TL_Cliente, clsControles.EPropietat.pTag)
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Public Function DbnullToNothing(ByVal pValor As Object) As Decimal?
        ' DbnullToNothing = pValor
        Try
            If pValor Is Nothing = False Then
                If IsDBNull(pValor) = True Then
                    Return Nothing
                Else
                    Return CDbl(pValor)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Cridar_Llistat_Generic()
        Dim LlistatGeneric As New M_LlistatGeneric.clsLlistatGeneric
        If Seguretat.oUser.CampoAux2 = EnumTipusUsuari.Solicitant Then
            LlistatGeneric.Mostrar_Llistat("Select * From C_Solicitud Where Activo=1 and ID_Usuario = " & Seguretat.oUser.ID_Usuario & " order by ID_SolicitudEstado, DataAlta", Me.TE_Codigo, "ID_Solicitud", "ID_Solicitud")
        Else
            LlistatGeneric.Mostrar_Llistat("Select * From C_Solicitud Where Activo=1  order by ID_SolicitudEstado, DataAlta", Me.TE_Codigo, "ID_Solicitud", "ID_Solicitud")
        End If
        AddHandler LlistatGeneric.AlTancarLlistatGeneric, AddressOf AlTancarLlistat
    End Sub

    Private Sub AlTancarLlistat(ByVal pID As String)
        Try
            Call Cargar_Form(pID)
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    Private Sub Permisos()
        'Me.TE_Codigo.ReadOnly = True
        'Me.C_Estado.ReadOnly = True
        'Me.C_Resolucion.ReadOnly = True
        'Me.DT_FechaPrevFinalizacion.ReadOnly = True
        'Me.DT_FechaFinalizacion.ReadOnly = True
        'Me.T_Descripcion.ReadOnly = True
        'Me.GRD_PersonasAsignadas.M.clsToolBar.DesactivarBotonesEdicion()
        'Me.R_DescripcionAmpliada.RichText.ReadOnly = True
        'Me.GRD_PersonasAsignadas.ToolGrid.Tools("Desfinalizar").SharedProps.Visible = False

        ''Si l'activitat no esta finalitzada i ets el propietari O  si estàs fent una nova activitat es podran editar els textes
        'If oLinqExpediente.Finalizada = False AndAlso Me.oclsActividad Is Nothing = False AndAlso Me.oclsActividad.oEsPropietari = True OrElse oLinqActividad.ID_ActividadCRM = 0 Then
        '    Me.TE_Codigo.ReadOnly = False
        '    Me.C_Estado.ReadOnly = False
        '    Me.C_Resolucion.ReadOnly = False
        '    Me.DT_FechaPrevFinalizacion.ReadOnly = False
        '    Me.DT_FechaFinalizacion.ReadOnly = False
        '    Me.T_Descripcion.ReadOnly = False
        '    'Me.GRD_Destinatarios.M.
        '    Me.GRD_PersonasAsignadas.M.clsToolBar.ActivarBotonesEdicion()
        '    Me.R_DescripcionAmpliada.RichText.ReadOnly = False
        '    Me.GRD_PersonasAsignadas.ToolGrid.Tools("Desfinalizar").SharedProps.Visible = True  'si ets el propietari podràs desfinalitzar
        'Else
        '    If oLinqActividad.Finalizada = False Then  'una persona que no sigui propietaria i que sigui destinataria de l'activitat podrà crear noves activitats

        '    End If
        'End If
    End Sub

#End Region

#Region "Grid Personas asignadas"

    Private Sub CargaGrid_PersonasAsignadas(ByVal pId As Integer)
        Try
            Dim _PersonasAsignadas As IEnumerable(Of SolicitudPersonaAsignada) = From taula In oDTC.SolicitudPersonaAsignada Where taula.ID_Solicitud = pId Select taula

            With Me.GRD_PersonasAsignadas
                .M.clsUltraGrid.CargarIEnumerable(_PersonasAsignadas)
                .M_Editable()
                If Seguretat.oUser.CampoAux2 <> EnumTipusUsuari.Autoritzador Then
                    .GRID.DisplayLayout.Bands(0).Columns("Aceptado").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                End If
            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_PersonasAsignadas_M_ToolGrid_ToolAfegir(ByRef sender As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager, ByRef e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles GRD_PersonasAsignadas.M_ToolGrid_ToolAfegir
        Try
            With Me.GRD_PersonasAsignadas

                If oLinqSolicitud.ID_Solicitud = 0 AndAlso Guardar() = False Then
                    Exit Sub
                End If

                .M_ExitEditMode()
                .M_AfegirFila()

                .GRID.Rows(.GRID.Rows.Count - 1).Cells("Solicitud").Value = oLinqSolicitud
            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_PersonasAsignadas_M_ToolGrid_ToolEliminarRow(ByRef sender As UltraGrid, ByRef e As UltraGridRow) Handles GRD_PersonasAsignadas.M_ToolGrid_ToolEliminarRow
        Try

            If e.IsAddRow Then
                oLinqSolicitud.SolicitudPersonaAsignada.Remove(e.ListObject)
                Exit Sub
            End If

            If Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE_PREGUNTA, "") = M_Mensaje.Botons.SI Then
                e.Delete(False)
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE)
            End If

            oDTC.SubmitChanges()

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_PersonasAsignadas_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles GRD_PersonasAsignadas.M_GRID_AfterRowUpdate
        Try
            oDTC.SubmitChanges()
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

#End Region

#Region "Events Varis"

    Private Sub CH_PedidoRealizado_CheckedChanged(sender As Object, e As EventArgs) Handles CH_PedidoRealizado.CheckedChanged
        If Me.CH_PedidoRealizado.Checked = True Then
            Me.DT_FechaEntrega.ReadOnly = False
        Else
            Me.DT_FechaEntrega.ReadOnly = True
            Me.DT_FechaEntrega.Value = Nothing
        End If
    End Sub

    Private Sub TE_Codigo_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles TE_Codigo.EditorButtonClick
        If e.Button.Key = "Lupeta" Then
            Call Cridar_Llistat_Generic()
        End If
    End Sub

    Public Sub BloqujarBotonsEstat()
        'estats de la solicitud

        Me.ToolForm.ToolForm.Tools("PasarSolicitudAEnCurso").SharedProps.Enabled = True
        Me.ToolForm.ToolForm.Tools("PasarSolicitudAPendiente").SharedProps.Enabled = True
        Me.ToolForm.ToolForm.Tools("PasarSolicitudAAceptada").SharedProps.Enabled = True
        Me.ToolForm.ToolForm.Tools("PasarSolicitudADenegada").SharedProps.Enabled = True
        Util.Activar(Me, M_Util.Enum_Controles_Activacion.TODOS, True)
        Me.ToolForm.ToolForm.Tools("Eliminar").SharedProps.Enabled = True
        Me.ToolForm.ToolForm.Tools("Guardar").SharedProps.Enabled = True

        If Seguretat.oUser.CampoAux2 = EnumTipusUsuari.Solicitant Then
            Me.ToolForm.ToolForm.Tools("PasarSolicitudAEnCurso").SharedProps.Enabled = False
            Me.ToolForm.ToolForm.Tools("PasarSolicitudAPendiente").SharedProps.Enabled = False
            Me.ToolForm.ToolForm.Tools("PasarSolicitudAAceptada").SharedProps.Enabled = False
            Me.ToolForm.ToolForm.Tools("PasarSolicitudADenegada").SharedProps.Enabled = False

            Me.T_ObservacionesAutorizador.ReadOnly = True
            Me.CH_LeidoAutorizador.Checked = False
            Me.CH_LeidoSolicitante.Checked = True
            Me.CH_PedidoRealizado.Enabled = False
            Me.DT_FechaEntrega.ReadOnly = True

            If oLinqSolicitud.ID_SolicitudEstado = EnumEstatsSolicitud.EnCurso Then  'un solicitant podrà passar la seva solicitud d'encurso a pendent
                Me.ToolForm.ToolForm.Tools("PasarSolicitudAPendiente").SharedProps.Enabled = True
            End If
        Else
            If oLinqSolicitud.ID_SolicitudEstado = EnumEstatsSolicitud.Aceptada Then
                Me.ToolForm.ToolForm.Tools("PasarSolicitudAEnCurso").SharedProps.Enabled = False
                Me.ToolForm.ToolForm.Tools("PasarSolicitudAAceptada").SharedProps.Enabled = False
                Me.ToolForm.ToolForm.Tools("PasarSolicitudADenegada").SharedProps.Enabled = False
            End If

            If oLinqSolicitud.ID_SolicitudEstado = EnumEstatsSolicitud.Denegada Then
                Me.ToolForm.ToolForm.Tools("PasarSolicitudAEnCurso").SharedProps.Enabled = False
                Me.ToolForm.ToolForm.Tools("PasarSolicitudAAceptada").SharedProps.Enabled = False
                Me.ToolForm.ToolForm.Tools("PasarSolicitudADenegada").SharedProps.Enabled = False
            End If

            If oLinqSolicitud.ID_SolicitudEstado = EnumEstatsSolicitud.EnCurso Then
                Me.ToolForm.ToolForm.Tools("PasarSolicitudAEnCurso").SharedProps.Enabled = False
            End If

            If oLinqSolicitud.ID_SolicitudEstado = EnumEstatsSolicitud.Pendiente Then
                Me.ToolForm.ToolForm.Tools("PasarSolicitudAPendiente").SharedProps.Enabled = False
            End If
        End If

        'modificar les dades de la solicitud
        If oLinqSolicitud.ID_SolicitudEstado = EnumEstatsSolicitud.Aceptada Or oLinqSolicitud.ID_SolicitudEstado = EnumEstatsSolicitud.Denegada Then
            Util.DesActivar(Me, M_Util.Enum_Controles_Activacion.TODOS, True)
            Me.TE_Codigo.ButtonsRight("Lupeta").Enabled = True

            Me.ToolForm.ToolForm.Tools("Eliminar").SharedProps.Enabled = False
            Me.ToolForm.ToolForm.Tools("Guardar").SharedProps.Enabled = False
        End If

        If oLinqSolicitud.ID_SolicitudEstado = EnumEstatsSolicitud.EnCurso And Seguretat.oUser.CampoAux2 = EnumTipusUsuari.Solicitant Then
            Util.DesActivar(Me, M_Util.Enum_Controles_Activacion.TODOS, True)
            Me.TE_Codigo.ButtonsRight("Lupeta").Enabled = True

            Me.ToolForm.ToolForm.Tools("Eliminar").SharedProps.Enabled = False
            Me.ToolForm.ToolForm.Tools("Guardar").SharedProps.Enabled = False
        End If

        If Seguretat.oUser.CampoAux2 Is Nothing = True OrElse Seguretat.oUser.CampoAux2.Length < 1 Then
            Util.DesActivar(Me, M_Util.Enum_Controles_Activacion.TODOS, True)
            Me.TE_Codigo.ButtonsRight("Lupeta").Enabled = True

            Me.ToolForm.ToolForm.Tools("Eliminar").SharedProps.Enabled = False
            Me.ToolForm.ToolForm.Tools("Guardar").SharedProps.Enabled = False
        End If

    End Sub

#End Region

    Private Sub C_Tipo_ValueChanged(sender As Object, e As EventArgs) Handles C_Tipo.ValueChanged
        If IsNumeric(Me.C_Tipo.Value) = True Then
            If Me.C_Tipo.Value = EnumTipoSolicitud.Autorizacion Then
                Me.T_ImporteAproximado.Enabled = True
            Else
                Me.T_ImporteAproximado.Enabled = False
            End If
        End If
    End Sub
End Class