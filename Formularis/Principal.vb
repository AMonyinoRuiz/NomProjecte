Imports System.Deployment
Imports Infragistics.Win.UltraWinToolbars
Imports System.Threading
Imports DevExpress.XtraTreeList.Nodes



Public Class Principal
    Dim Temps_Blinking As Integer
    ' Dim oProjects As Projects

#Region "Events formulari"
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Seguretat = New M_Seguretat.clsSeguretat(Me)
        Seguretat.pFrameWork40 = False
        Seguretat.pIdioma = M_Mensaje.clsLog.EnumIdioma.Español
        Seguretat.pNomDelPrograma = "Clariana central"
        Seguretat.pUtilitzarGridDevExpress = True
        Seguretat.pFotoPantallaLogin = Leer_Imagen("LogoClarianaCentral.jpg")
        'Seguretat.pFotoPantallaLoginMantainAspectRatio=True
        Seguretat.pNomDeLaBaseDades = "BDClarianaCentral"

        RichTextCaixaText = New M_RichText.M_RichText
        RichTextCaixaText.pIdioma = M_Mensaje.clsLog.EnumIdioma.Español


        DevExpress.XtraPrinting.Native.PrintingSettings.UseNewPdfExport = False

        'Seguretat.pNomDeLaBaseDades2 = "AbidosNova"
 
        ' Seguretat.pNomDeLaInstanciaSqlServer = "10.7.7.41"

        Select Case My.Computer.Name.ToUpper
            Case "HOME2017", "PROGRAMACIO2-PC"
                ' Seguretat.pNomDeLaInstanciaSqlServer = "10.99.99.1"
                ' Seguretat.pNomDeLaInstanciaSqlServer = "25.61.125.205"
                ' Seguretat.pNomDeLaInstanciaSqlServer = "192.168.1.225"
                Seguretat.pNomDeLaInstanciaSqlServer = "192.168.100.1" '"217.126.82.60"
                Seguretat.pUsuariPerDefecte = "Carles"
                Seguretat.pContrasenyaPerDefecte = "Carles123"
                ' Seguretat.pValidarUsuariPerDefecte = True
            Case Else
                Seguretat.pNomDeLaInstanciaSqlServer = "192.168.100.1"
        End Select

        Seguretat.pMultipleActiveResultSets = True 'Fem això per a que poguem exportar múltiples fitxers al disc dur sense que peti i  a sobre va més ràpid.

        If Seguretat.ObrirFormulariLogin(False) = False Then
            Seguretat = Nothing
            Me.Close()
            End
            Exit Sub
        End If

        Util = Seguretat.pUtil
        Mensaje = Seguretat.pMensaje
        BD = Seguretat.pBD

        'If Seguretat.pUtilitzarFitxerKey = True Then
        '    Call ActualizacionBD()
        'End If

        LlistatsADV = New M_LlistatADV.clsLlistatADV(Me)
        LlistatsADV.pBD = BD
        LlistatsADV.pMensaje = Mensaje
        LlistatsADV.pUtil = Util
        LlistatsADV.pToolbarPrincipal = Me.ToolManagerPrincipal
        LlistatsADV.pSeguretat = Seguretat

        AddHandler LlistatsADV.AlFerDobleClickEnElLlistat, AddressOf AlFerDobleClickEnElLlistatADV

        Informes = New M_Informes.clsInformes(Me)
        Informes.pBD = BD
        Informes.pMensaje = Mensaje
        Informes.pUtil = Util

        AddHandler Informes.EventDobleClick, AddressOf EventDobleClickEnUnLlistat

        Call Util.SplashObrir("Iniciando " & Seguretat.pNomDelPrograma & "...")

        oclsPilaFormularis.NetejarPila()

        AddHandler M_Mensaje.clsLog.Actualitzacio_Log, AddressOf Mostrar_Missatges_En_Log
        AddHandler M_UltraGrid.m_UltraGrid.Actualitzacio_Log, AddressOf Mostrar_Missatges_En_Log
        frmPrincipal = Me


        If IsNothing(Seguretat.oUser.CampoAux1) = False Then
            If Seguretat.oUser.CampoAux1 = 0 Then
                M_GenericForm.frmBase.pUsarReductorDeMemoria = False
            Else
                M_GenericForm.frmBase.pUsarReductorDeMemoria = True
            End If
        End If


        'Dim pepe2 As New Form1
        'pepe2.Entrada()
        'pepe2.FormObrir(Me, True)
        'Call Informes.CarregarMenusLlistats(Seguretat.oUser.NivelSeguridad, Me.ToolManagerPrincipal)
        Call LlistatsADV.CarregarMenusLlistats(Seguretat.oUser.NivelSeguridad)
        'Call LlistatsADV.CarregarMenusGauge(Seguretat.oUser.NivelSeguridad)
        'Call FerInvisiblesElsFormularisQueNoEstePermis()
        M_RichText.M_RichText.pNomFontPredeterminada = "Calibri"
        M_RichText.M_RichText.pSizeFontPredeterminada = 10

        Dim oDTC As New DTCDataContext(BD.Conexion)

        'Dim oDTC As New DTCDataContext(BD.Conexion)
        M_Informes.clsInformes.pSeguretat = Seguretat


        Call Util.SplashTancar()

        Call Util.WaitFormObrir()

        Dim _BIUsuario As BI_Usuario
        Dim _Usuari As Usuario = oDTC.Usuario.Where(Function(F) F.ID_Usuario = Seguretat.oUser.ID_Usuario).FirstOrDefault

        For Each _BIUsuario In _Usuari.BI_Usuario.Where(Function(F) F.CargarAlIniciarPrograma = True)
            LlistatsADV.ObrirBI(oDTC, _BIUsuario.ID_BI)
        Next

        Call Util.WaitFormTancar()

        'oInforme.ObrirInformeManteniment(oDTC)
        'oInforme.ObrirInformePreparacio(oDTC, 2, "ID_Instalacion=39", "aaa")
        'oInforme.ObrirInformePlantillaManteniment()

        'Dim thread1 As Threading.Thread = New Threading.Thread(New ThreadStart(AddressOf DisplayThread1))
        'thread1.Start()

        AddHandler Me.UltraStatusBarPrincipal.PanelDoubleClick, AddressOf AlFerDobleClickSobreUnPanelDeLaStatusBar

        Me.ToolManagerPrincipal.Tools("ListadosADV").SharedProps.Visible = False
        Me.ToolManagerPrincipal.Tools("m_mantenimiento_listado").SharedProps.Visible = False
        Me.ToolManagerPrincipal.Tools("m_mantenimiento_listadosADV").SharedProps.Visible = False
        Me.ToolManagerPrincipal.Tools("m_grupo_usuario").SharedProps.Visible = False
        Me.ToolManagerPrincipal.Tools("m_usuario").SharedProps.Visible = False
        Me.ToolManagerPrincipal.Tools("m_formulario").SharedProps.Visible = False
        Me.ToolManagerPrincipal.Tools("m_login").SharedProps.Visible = False
        Me.ToolManagerPrincipal.Tools("m_informe_plantilla").SharedProps.Visible = False

        If Seguretat.oUser.ID_Usuario = 1 Then  'Si sóc l'usuari Carles
            Me.ToolManagerPrincipal.Tools("m_grupo_usuario").SharedProps.Visible = True
            Me.ToolManagerPrincipal.Tools("m_usuario").SharedProps.Visible = True
            Me.ToolManagerPrincipal.Tools("m_informe_plantilla").SharedProps.Visible = True

        End If


        Dim _Boto As Infragistics.Win.UltraWinToolbars.ToolBase
        Dim _ToolBar As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager = CObj(frmPrincipal).ToolManagerPrincipal

        Dim i2 As Integer
        For i2 = 0 To 2 'Xapuça!!!  Si fas només una pasada pot ser que es trobi un Popup menú dins d'un popup menú amb fills totalment invisibles i ell no s'acabi fent invisible. Si fem dos, el popup fill ja estarà invisible i ell també s'hi podrà possar si s'escau
            'si un popup no te res a ins el farem ocult
            For Each _Boto In _ToolBar.Tools
                Dim _CountFills As Boolean = False

                If _Boto.GetType.ToString.Contains("Popup") Then
                    Dim a As Infragistics.Win.UltraWinToolbars.PopupMenuTool
                    a = _Boto
                    'MsgBox(a.Key)
                    Dim _ToolsFills As Infragistics.Win.UltraWinToolbars.ToolBase

                    For Each _toolfills In a.Tools
                        If _toolfills.SharedProps.Visible = True Then
                            'MsgBox("Un de visible:" & _toolfills.Key)
                            _CountFills = True
                        End If
                    Next
                    If _CountFills = False Then
                        a.SharedProps.Visible = False
                        '_CountFills = False
                    Else
                        ' a.SharedProps.Visible = False
                    End If
                End If
            Next
        Next

        Me.Timer2.Enabled = True
        Me.Timer3.Enabled = True

        Me.ToolManagerPrincipal.Tools("m_prova").SharedProps.Visible = False
    End Sub
    Private Sub Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Mensaje Is Nothing Then 'Fem això pq si estas en la pantalla Login i apretes el botó sortir la variable Mensaje es nothing i peta
            Exit Sub
        End If

        If Mensaje.Mostrar_Mensaje("¿Desea salir de la aplicación?", M_Mensaje.Missatge_Modo.PREGUNTA, "Clariana .NET") = M_Mensaje.Botons.NO Then
            e.Cancel = True
            Exit Sub
        Else
            'ho fem dos vegades pq la primera vegada no ho neteja tot pq la pila es buida després d'eliminar els forms. Així la segona vegada la pila ja esta buida i tots els forms en cache s'eliminen definitivament
            Call oclsPilaFormularis.NetejarPila()
            Call oclsPilaFormularis.NetejarPila()
            e.Cancel = False

        End If

        Seguretat.TancarSesioControlUsuaris()

        'frmWEB.TancadaForçada = True

    End Sub
    Private Sub Principal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.OemBackslash Then
            If M_UltraGrid.clsParametres.pNivellSeguretat = 1 Then
                M_UltraGrid.clsParametres.pModoProgramacio = Not M_UltraGrid.clsParametres.pModoProgramacio
                M_GenericForm.frmBase.pModeDisseny = Not M_GenericForm.frmBase.pModeDisseny
            End If
        End If

        If e.Control = True And e.KeyCode = Keys.OemMinus Then
            Dim i As Integer = M_Disseny.ClsDisseny.pStyle
            i = i + 1
            If i = 6 Then
                i = 0
            End If
            M_Disseny.ClsDisseny.pStyle = i
        End If

        If e.Control = True And e.KeyCode = Keys.Oem5 And e.Shift = True Then
            Me.AppStylistRuntime1.ShowRuntimeApplicationStylingEditor(Me, "Hola")
        End If

        Call Seguretat.ActivarTemporitzadorControlInactivitat() 'cada cop que apretin una tecla el control d'inactivitat s'incialitzarà
    End Sub
    Private Sub Principal_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        'Me.BackgroundImageLayout = ImageLayout.None
        'Me.BackgroundImageLayout = ImageLayout.Stretch
        'Me.Refresh()
    End Sub
    Private Sub ToolManagerPrincipal_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles ToolManagerPrincipal.ToolClick

        Select Case e.Tool.Key.ToLower

            Case "m_compras_suministros"
                Dim frm As New frmLlistatComprasSuministros
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_listado_resumen_diario_plantas"
                Dim frm As New frmLlistatResumDiariPlantas
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_llistat_gpdr"
                Dim frm As New frmLlistatGPDR
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_movimientos_bancarios"
                Dim frm As New frmMovimientosBancarios
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_listado_lineas_albaran"
                Dim frm As New frmLlistatLiniesAlbaran
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_listado_albaranes"
                Dim frm As New frmLlistatAlbaransSAGE
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_hacienda"
                Dim frm As New frmLlistatHacienda
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_llistat_albarans_compra"
                Dim frm As New frmLlistatAlbaransCompra
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_listado_plus_assistencia"
                Dim frm As New frmLlistatPlusAssistencia
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_llistat_mosso"
                Dim frm As New frmLlistatMossos
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_listado_dietas"
                Dim frm As New frmLlistatDietas
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_provaa"
                Dim frm As New frmProva
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_manteniment"
                Dim frm As New frmManteniment
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_movimientos"
                Dim frm As New frmMovimientos
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_solicitudes"
                Dim frm As New frmLlistatSolicitud
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_partes"
                Dim frm As New frmLlistatPartes
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_personal"
                Dim frm As New frmPersonal
                frm.Entrada()
                frm.FormObrir(Me)

            Case "m_mantenimiento_informe"
                Dim oDTC As New DTCDataContext(BD.Conexion)
                Informes.ObrirInformeManteniment(oDTC)
                'Dim frm As New frmManteniment_Informe
                'frm.Entrada()
                'frm.FormObrir(Me)

            Case "m_informe_plantilla"
                Informes.ObrirInformePlantillaManteniment()
                'Dim frm As New frmMantenimient_Informe_Plantilla
                'frm.Entrada()
                'frm.FormObrir(Me)

            Case "m_usuario"
                Seguretat.ObrirFormulariUsuaris()
                'Dim frm As New frmManteniment_Usuario
                'frm.Entrada()
                'frm.FormObrir(Me)
            Case "m_grupo_usuario"
                Seguretat.ObrirFormulariGrupUsuaris()
                'Dim frm As New frmManteniment_Usuario_Grupo
                'frm.Entrada()
                'frm.FormObrir(Me)
            Case "m_formulario"
                Seguretat.ObrirFormulariMantenimentFormularis()
                'Dim frm As New frmManteniment_Formulario
                'frm.Entrada()
                'frm.FormObrir(Me)
            Case "m_login"
                'Call CridarFormulariLogin()
                Seguretat.ObrirFormulariLogin(True)

                'If pCarregaPerInactivitat = False Then
                'Call DestruirMenusLlistats()
                'Call CarregarMenusLlistats()
                'Call FerInvisiblesElsFormularisQueNoEstePermis()
                'End If

                ' Case "m_movimiento"
                'Dim frm As New frmMovimiento
                'frm.Entrada()
                'frm.FormObrir(Me)

            Case "m_mantenimiento_listadosadv"
                LlistatsADV.ObrirPantallaManteniment()
                Exit Sub

            Case "m_tarifas"
                Dim frm As New frmTarifas
                frm.Entrada()
                frm.FormObrir(Me, True)

            Case "m_listado_articulosporplantayproveedor"
                Dim frm As New frmLlistatSergiSanchezArticlesPerPlanta
                frm.Entrada()
                frm.FormObrir(Me, True)

            Case "m_listado_garita"
                Dim frm As New frmLlistatGarita
                frm.Entrada()
                frm.FormObrir(Me, True)

            Case "m_listadoreumencompras"
                Dim frm As New frmllistatResumCompres
                frm.Entrada()
                frm.FormObrir(Me, True)

            Case "m_resumen_diario"
                Dim frm As New frmLlistatResumDiari
                frm.Entrada()
                frm.FormObrir(Me, True)

            Case Else
                Dim _Key As String = e.Tool.Key
                If _Key.StartsWith("@") Then
                    _Key = Mid(_Key, 2, _Key.Length)
                End If

                If IsNumeric(_Key) Then
                    Dim oDTC As New DTCDataContext(BD.Conexion)
                    If e.Tool.SharedProps.Tag Is Nothing = False AndAlso e.Tool.SharedProps.Tag = "ADV" Then
                        LlistatsADV.ObrirLlistat(oDTC, CInt(_Key), True)
                    Else

                    End If
                End If
                Exit Sub
        End Select

        Call Seguretat.ActivarTemporitzadorControlInactivitat()
    End Sub

#End Region

#Region "Timers"

    <System.Diagnostics.DebuggerStepThrough()> Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Temps_Blinking = Temps_Blinking + 1
        Me.UltraStatusBarPrincipal.Panels(0).Appearance.ForeColor = Color.Black
        Dim Color_Original As Color = Me.UltraStatusBarPrincipal.Panels(1).Appearance.BackColor
        If Me.UltraStatusBarPrincipal.Panels(0).Appearance.BackColor = Color_Original Then
            If Me.UltraStatusBarPrincipal.Panels(0).Tag Is Nothing Then
                Me.UltraStatusBarPrincipal.Panels(0).Appearance.BackColor = Color.LightGreen
            Else
                Me.UltraStatusBarPrincipal.Panels(0).Appearance.BackColor = Color.LightCoral
            End If
        Else
            Me.UltraStatusBarPrincipal.Panels(0).Appearance.BackColor = Color_Original
        End If
        If Temps_Blinking = 8 Then
            Me.UltraStatusBarPrincipal.Panels(0).Appearance.BackColor = Color_Original
            Me.UltraStatusBarPrincipal.Panels(0).Text = ""
            Me.Timer1.Stop()
        End If

    End Sub

    <System.Diagnostics.DebuggerStepThrough()> Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'alertes de solicituds pendents
        Dim _BD2 As New M_Conexion.clsConexion
        _BD2.Conectar(BD.pBDNomInstancia, BD.pBDNomBaseDades, BD.pBDUsuari, BD.pBDContrasenya)
       
        Dim _NumSolicitudsPendents As Integer
        If Seguretat.oUser.CampoAux2 = EnumTipusUsuari.Autoritzador Then
            _NumSolicitudsPendents = _BD2.RetornaValorSQL("Select count(*) from Solicitud where LeidoAutorizador = 0 and DataCambioEstado < '" & Now.AddMinutes(-2) & "'")
            If _NumSolicitudsPendents > 0 Then
                Me.NotifyIcon1.ShowBalloonTip(3600000, "Informació", "Tienes " & _NumSolicitudsPendents & " solicitudes pendientes de revisar", ToolTipIcon.Info)
                _BD2.EjecutarConsulta("UPDATE Solicitud SET LeidoAutorizador = 1")
            End If
        End If
        '3600000 és una hora
        If Seguretat.oUser.CampoAux2 = EnumTipusUsuari.Solicitant Then
            _NumSolicitudsPendents = _BD2.RetornaValorSQL("Select count(*) from Solicitud where LeidoSolicitante = 0 and DataCambioEstado < '" & Now.AddMinutes(-2) & "' and id_usuario=" & Seguretat.oUser.ID_Usuario)
            If _NumSolicitudsPendents > 0 Then
                Me.NotifyIcon1.ShowBalloonTip(3600000, "Informació", "Tienes " & _NumSolicitudsPendents & " solicitudes pendientes de revisar", ToolTipIcon.Info)
                _BD2.EjecutarConsulta("UPDATE Solicitud SET LeidoSolicitante = 1 where id_usuario=" & Seguretat.oUser.ID_Usuario)
            End If
        End If
    End Sub

    'Temporitzador que mira si hi ha conexió o no
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'If BD.ProvarConexioActiva() = False Then
        '    Call MissatgeConexioPerduda()
        'End If

        Try
            Dim prueva As Integer = BD.RetornaValorSQL("select count(*) from Grid")
        Catch oErr As Exception
            Call MissatgeConexioPerduda()
        End Try
    End Sub

    Private Shared Sub MissatgeConexioPerduda()
        ' If BD.Conectado = False Then
        frmPrincipal.Timer3.Enabled = False
        Dim Missatge As String = "Atención, se ha perdido la conexión con el servidor. Desea intentar reconectar? (Si selecciona NO se cerrará el programa)"
        If MsgBox(Missatge, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Util.WaitFormObrir()
            If BD.Conectar(BD.pBDNomInstancia, BD.pBDNomBaseDades, BD.pBDUsuari, BD.pBDContrasenya) Then
                Util.WaitFormTancar()
                frmPrincipal.Timer3.Enabled = True
                frmPrincipal.Enabled = True
            Else
                Util.WaitFormTancar()
                Mensaje.Mostrar_Mensaje("La conexión con la base de datos no funciona", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)
                Call MissatgeConexioPerduda()
            End If
        Else
            End
        End If
        'End If
    End Sub
    'Fi temporitzador per reconectar

#End Region

#Region "Varis"

    Private Sub Mostrar_Missatges_En_Log(ByVal pTexte As String, ByVal pFuncio As String, ByVal pTipoMensaje As M_Mensaje.Missatge_Modo, ByVal pStackTrace As String)
        Dim Texte As String = ""
        Try
            With UltraStatusBarPrincipal.Panels(0)
                Texte = pTexte
                If pTipoMensaje = M_Mensaje.Missatge_Modo.ERRORS Then
                    If pFuncio = "" Then
                        Texte = pTexte
                    Else
                        Texte = "[" & pFuncio & "] " & pTexte
                    End If
                    If pStackTrace Is Nothing OrElse pStackTrace.Length = 0 Then 'Si no hi ha stacktrace vol dir que no ha estat un error automàtic i que ha estat un error de tipus (texto requerido donat per mi per exemple)
                        .Tag = Nothing
                    Else
                        .Tag = "Error"
                    End If

                Else
                    '.Appearance.ForeColor = Color.Green
                    .Tag = Nothing
                End If

                .Text = Texte

                Me.Timer1.Stop()
                Me.Timer1.Interval = 500
                Temps_Blinking = 0
                Me.Timer1.Start()

                Call Seguretat.ActivarTemporitzadorControlInactivitat()
            End With
        Catch ex As Exception
            MsgBox(Reflection.MethodBase.GetCurrentMethod.Name.ToString & "  " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub TancaPrograma()

        End
    End Sub

    Private Sub UltraTabbedMdiManagerPrincipal_TabClosing(sender As Object, e As Infragistics.Win.UltraWinTabbedMdi.CancelableMdiTabEventArgs) Handles UltraTabbedMdiManagerPrincipal.TabClosing
        If e.Tab.IsFormEnabled = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub AlFerDobleClickSobreUnPanelDeLaStatusBar(Sender As Object, ByVal e As Infragistics.Win.UltraWinStatusBar.PanelClickEventArgs)

    End Sub

    Private Sub EventDobleClickEnUnLlistat(ByVal pNomTaula As String, ByVal pID As Integer)
        'Dim oDTC As New DTCDataContext(BD.Conexion)

        'Select Case pNomTaula
        '    Case "Cliente"
        '        Dim frm As New frmCliente
        '        frm.Entrada(pID)
        '        frm.FormObrir(frmPrincipal, True)
        '    Case "Proveedor"
        '        Dim frm As New frmProveedor
        '        frm.Entrada(pID)
        '        frm.FormObrir(frmPrincipal, True)
        '    Case "Personal"
        '        Dim frm As New frmPersonal
        '        frm.Entrada(pID)
        '        frm.FormObrir(frmPrincipal, True)
        '    Case "Instalacion"
        '        Dim frm As frmInstalacion = oclsPilaFormularis.ObrirFormulari(GetType(frmInstalacion))
        '        frm.Entrada(pID)
        '        frm.FormObrir(frmPrincipal, True)
        '    Case "Parte"
        '        Dim frm As frmParte = oclsPilaFormularis.ObrirFormulari(GetType(frmParte))
        '        frm.Entrada(pID)
        '        frm.FormObrir(frmPrincipal, True)
        '    Case "Propuesta"

        '        Dim _Propuesta As Propuesta = oDTC.Propuesta.Where(Function(F) F.ID_Propuesta = pID).FirstOrDefault
        '        If _Propuesta Is Nothing = False Then

        '            Dim frm As frmInstalacion = oclsPilaFormularis.ObrirFormulari(GetType(frmInstalacion))
        '            frm.Entrada(_Propuesta.ID_Instalacion)
        '            frm.FormObrir(frmPrincipal, True)

        '            Dim frm2 As New frmPropuesta
        '            frm2.Entrada(frm.oLinqInstalacion, frm.oDTC, _Propuesta.ID_Propuesta)
        '            AddHandler frm2.FormClosing, AddressOf frm.AlTancarfrmPropuesta
        '            frm2.FormObrir(frm)

        '        End If

        '    Case "Producto"
        '        Dim frm As frmProducto = oclsPilaFormularis.ObrirFormulari(GetType(frmProducto))
        '        frm.Entrada(pID)
        '        frm.FormObrir(frmPrincipal, True)
        '    Case "Producto División"

        '    Case "Usuarios"

        'End Select

    End Sub

    Private Sub AlFerDobleClickEnElLlistatADV(ByVal pIDLlistatADV As Integer, ByVal pIDSeleccionatEnGrid As Integer)
        Dim oDTC As New DTCDataContext(BD.Conexion)
        Dim _llistatADV As ListadoADV
        _llistatADV = oDTC.ListadoADV.Where(Function(F) F.ID_ListadoADV = pIDLlistatADV).FirstOrDefault

        Dim juan As Type
        juan = Type.GetType("River." & _llistatADV.Formulario.NombreReal)

        Dim _frm2 As Object
        _frm2 = Activator.CreateInstance(juan)
        If _llistatADV.CodigoApertura Is Nothing = False AndAlso _llistatADV.CodigoApertura.Length > 0 Then
            _frm2.Entrada(pIDSeleccionatEnGrid, pIDSeleccionatEnGrid)
        Else
            _frm2.Entrada(pIDSeleccionatEnGrid)
        End If

        _frm2.FormObrir(Me)
    End Sub

#End Region

    Public Function Leer_Imagen(ByRef NomImagen As String) As Image
        Dim thisType As Type

        Try
            thisType = Me.GetType()

            Dim st As System.IO.Stream = thisType.Module.Assembly.GetManifestResourceStream(thisType, NomImagen)

            Leer_Imagen = New Bitmap(st)

            st.Close()

        Catch oerr As Exception
            Throw New Exception(oerr.Message & " " & Reflection.MethodBase.GetCurrentMethod.Name.ToString)
        End Try
    End Function

End Class
