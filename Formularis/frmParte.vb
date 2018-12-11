Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmParte
    Implements IDisposable
    Dim oDTC As DTCDataContext
    Dim oLinqParte As Parte
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
            If oLinqParte.ID_Parte <> 0 Then
                If Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE_PREGUNTA) = M_Mensaje.Botons.SI Then

                    oDTC.Parte_Archivo.DeleteAllOnSubmit(oLinqParte.Parte_Archivo)
                    oDTC.Personal_Ausencia.DeleteAllOnSubmit(oLinqParte.Personal_Ausencia)
                    oDTC.Parte.DeleteOnSubmit(oLinqParte)
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

        If oLinqParte.ID_Parte = 0 Then
            Exit Sub
        End If

        'Informes.ObrirInformePreparacio(oDTC, 2, "[ID_Solicitud] = '" & Me.TE_Codigo.Value & "'", "Solicitud: " & Me.TE_Codigo.Value, , , , , , False)
    End Sub

    Private Sub ToolForm_m_ToolForm_ToolClick_Botones_Extras(Sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles ToolForm.m_ToolForm_ToolClick_Botones_Extras

        If oLinqParte.ID_Parte = 0 Then
            Mensaje.Mostrar_Mensaje("No hay un parte cargado en la pantalla", M_Mensaje.Missatge_Modo.ERRORS, , , True)
        Else
            Select Case e.Tool.Key
                Case "PasarParteAPendiente"
                    Me.C_Estado.Value = CInt(EnumEstatsPartes.Pendiente)
                    Me.ToolForm.ToolForm.Tools("PasarParteADenegado").SharedProps.Enabled = True
                    Me.ToolForm.ToolForm.Tools("PasarParteAAceptado").SharedProps.Enabled = True
                    Me.ToolForm.ToolForm.Tools("PasarParteAPendiente").SharedProps.Enabled = False

                    'al pasar-ho de nou a pendem, borrem les absencies creades amb el acceptar
                    oDTC.Personal_Ausencia.DeleteAllOnSubmit(oLinqParte.Personal_Ausencia)
                    oDTC.SubmitChanges()

                Case "PasarParteAAceptado"
                    Me.C_Estado.Value = CInt(EnumEstatsPartes.Aceptado)
                    Me.ToolForm.ToolForm.Tools("PasarParteADenegado").SharedProps.Enabled = False
                    Me.ToolForm.ToolForm.Tools("PasarParteAAceptado").SharedProps.Enabled = False
                    Me.ToolForm.ToolForm.Tools("PasarParteAPendiente").SharedProps.Enabled = True

                    If oDTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(Me.C_AusenciaTipo.Value)).FirstOrDefault.Conta_Festius = False Then
                        'afeguim una ausencia per cada dia del rang introduit
                        Dim _DataIniciTemp As Date = Me.DT_Inicio.Value
                        While _DataIniciTemp <= Me.DT_Fin.Value
                            Dim _AusenciaFestiva As Integer = oDTC.DiaFiesta.Where(Function(F) F.Data = _DataIniciTemp).Count
                            If _AusenciaFestiva = 0 And Weekday(_DataIniciTemp, FirstDayOfWeek.Monday) <> 6 And Weekday(_DataIniciTemp, FirstDayOfWeek.Monday) <> 7 Then
                                Dim _Absencia As New Personal_Ausencia
                                _Absencia.Personal = oDTC.Personal.Where(Function(F) F.ID_Personal = CInt(Me.C_Personal.Value)).FirstOrDefault
                                _Absencia.AusenciaTipo = oDTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(Me.C_AusenciaTipo.Value)).FirstOrDefault
                                _Absencia.Parte = oLinqParte
                                _Absencia.Fecha = _DataIniciTemp
                                _Absencia.Observaciones = Me.T_Observaciones.Text
                                _Absencia.Parte = oLinqParte
                                If IsDBNull(Me.T_Horas.Value) = False Then
                                    _Absencia.NumHores = DbnullToNothing(Me.T_Horas.Value)
                                End If
                                oDTC.Personal_Ausencia.InsertOnSubmit(_Absencia)
                                oDTC.SubmitChanges()
                            End If
                            _DataIniciTemp = _DataIniciTemp.AddDays(1)
                        End While
                    Else
                        Dim _DataIniciTemp As Date = Me.DT_Inicio.Value
                        While _DataIniciTemp <= Me.DT_Fin.Value
                            Dim _Absencia As New Personal_Ausencia
                            _Absencia.Personal = oDTC.Personal.Where(Function(F) F.ID_Personal = CInt(Me.C_Personal.Value)).FirstOrDefault
                            _Absencia.AusenciaTipo = oDTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(Me.C_AusenciaTipo.Value)).FirstOrDefault
                            _Absencia.Parte = oLinqParte
                            _Absencia.Fecha = _DataIniciTemp
                            _Absencia.Observaciones = Me.T_Observaciones.Text
                            _Absencia.Parte = oLinqParte
                            If IsDBNull(Me.T_Horas.Value) = False Then
                                _Absencia.NumHores = DbnullToNothing(Me.T_Horas.Value)
                            End If
                            oDTC.Personal_Ausencia.InsertOnSubmit(_Absencia)
                            oDTC.SubmitChanges()
                            _DataIniciTemp = _DataIniciTemp.AddDays(1)
                        End While
                    End If



                Case "PasarParteADenegado"
                    Me.C_Estado.Value = CInt(EnumEstatsPartes.Denegado)
                    Me.ToolForm.ToolForm.Tools("PasarParteADenegado").SharedProps.Enabled = False
                    Me.ToolForm.ToolForm.Tools("PasarParteAAceptado").SharedProps.Enabled = False
                    Me.ToolForm.ToolForm.Tools("PasarParteAPendiente").SharedProps.Enabled = True

                    oDTC.SubmitChanges()
            End Select

            If Me.C_Estado.Value = EnumEstatsPartes.Aceptado Then
                Me.ToolForm.M.Botons.tGuardar.SharedProps.Enabled = False
            Else
                Me.ToolForm.M.Botons.tGuardar.SharedProps.Enabled = True
            End If

            Call Guardar(False)
            oDTC.SubmitChanges()
        End If
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada(Optional ByVal pID As Integer = 0)

        Try

            Me.AplicarDisseny()

            'Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = True

            Fichero = New M_Archivos_Binarios.clsArchivosBinarios2(BD, Me.GRD_Ficheros, "Parte_Archivo", 1)

            Util.Cargar_Combo(Me.C_Estado, "SELECT ID_ParteEstado, Descripcion FROM ParteEstado ORDER BY ID_ParteEstado", False)
            Util.Cargar_Combo(Me.C_Usuario, "SELECT ID_Usuario, Nombre FROM Usuario Where Activo=1 ORDER BY Nombre", False)
            Util.Cargar_Combo(Me.C_Planta, "SELECT ID_Planta, Descripcion FROM Planta Where Activo = 1 and ID_Planta <> 10 ORDER BY ID_Planta desc", False) 'excluim la planta 10 per que es TODAS i no ens interesa en aquest cas aquesta opcio
            Util.Cargar_Combo(Me.C_Personal, "SELECT ID_Personal, Nombre FROM Personal Where Activo = 1 and ID_Personal_Estat = 1 ORDER BY Nombre", False)
            Util.Cargar_Combo(Me.C_AusenciaTipo, "SELECT ID_AusenciaTipo, Descripcion FROM AusenciaTipo ORDER BY Descripcion", False)

            Me.ToolForm.M.Botons.tNou.SharedProps.Visible = False
            Me.ToolForm.M.Botons.tAccions.SharedProps.Visible = True
            Me.ToolForm.M.clsToolBar.Afegir_BotoAccions("PasarParteAPendiente", "Pasar a 'Pendiente'", True)
            Me.ToolForm.M.clsToolBar.Afegir_BotoAccions("PasarParteADenegado", "Denegar parte", True)
            Me.ToolForm.M.clsToolBar.Afegir_BotoAccions("PasarParteAAceptado", "Aceptar parte", True)


            If Seguretat.oUser.CampoAux3 = EnumRRHH.Si Then
                Me.C_Planta.ReadOnly = False
                Me.ToolForm.ToolForm.Tools("PasarParteAPendiente").SharedProps.Enabled = False
                Me.ToolForm.ToolForm.Tools("PasarParteADenegado").SharedProps.Enabled = True
                Me.ToolForm.ToolForm.Tools("PasarParteAAceptado").SharedProps.Enabled = True
                'Me.CH_Compensado.Visible = True
                Me.CH_Compensado.Visible = False
            Else
                Me.C_Planta.ReadOnly = True
                Me.ToolForm.M.Botons.tEliminar.SharedProps.Enabled = False
                Me.ToolForm.ToolForm.Tools("PasarParteAPendiente").SharedProps.Enabled = False
                Me.ToolForm.ToolForm.Tools("PasarParteADenegado").SharedProps.Enabled = False
                Me.ToolForm.ToolForm.Tools("PasarParteAAceptado").SharedProps.Enabled = False
                Me.CH_Compensado.Visible = False
            End If


            If pID <> 0 Then
                Call Cargar_Form(pID)
            Else
                Call Netejar_Pantalla()
            End If

            If Me.C_Estado.Value = EnumEstatsPartes.Aceptado Then
                Me.ToolForm.M.Botons.tGuardar.SharedProps.Enabled = False
            Else
                Me.ToolForm.M.Botons.tGuardar.SharedProps.Enabled = True
            End If

            Me.C_AusenciaTipo.MaxDropDownItems = 20

            Me.KeyPreview = False
            'Me.GRD_Ficheros.Enabled = False

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    Private Function Guardar(Optional ByVal pComprovarPartesPerDies As Boolean = True) As Boolean
        Guardar = False
        Try
            Me.TE_Codigo.Focus()

            If ComprovacioCampsRequeritsError() = True Then
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
                Exit Function
            End If

            If Seguretat.oUser.CampoAux3 <> EnumRRHH.Si Then
                Dim _diaavui As Date = Now.Date
                If Me.DT_Inicio.Value < _diaavui.AddDays(-5) Then
                    Mensaje.Mostrar_Mensaje("No se puede introducir una fecha de inicio tan lejana. El máximo son 5 días a fecha de hoy", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                    Exit Function
                End If
            End If

            If Me.DT_Fin.Value > CDate(Me.DT_Inicio.Value).AddDays(40) Then
                Mensaje.Mostrar_Mensaje("La fecha de fin no puede ser superior a 40 días después de la fecha de inicio", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                Exit Function
            End If

            If Me.DT_Fin.Value < Me.DT_Inicio.Value Then
                Mensaje.Mostrar_Mensaje("La fecha de fin no puede ser menos que la fecha de inicio", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                Me.DT_Fin.Value = Now.Date
                Exit Function
            End If

            If oDTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(Me.C_AusenciaTipo.Value)).FirstOrDefault.ComptaPerHores = True And Me.DT_Inicio.Value <> Me.DT_Fin.Value Then
                Mensaje.Mostrar_Mensaje("Este tipo de ausencia no puede seleccionar un rango de mas de un día", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                Exit Function
            End If

            If IsDBNull(Me.T_Horas.Value) = False AndAlso Me.T_Horas.Value > 24 Then
                Mensaje.Mostrar_Mensaje("No puedes assignar mas de 24 horas en un día", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                Exit Function
            End If

            'comprovació de si existeix algun parte***********************************************************
            Dim _NumPartesExistents As Integer
            If oLinqParte.ID_Parte = 0 Then
                _NumPartesExistents = 0
            Else
                _NumPartesExistents = 1
            End If

            If pComprovarPartesPerDies = True Then
                If Me.DT_Inicio.Value = Me.DT_Fin.Value Then
                    If Me.T_Horas.ReadOnly = True Then 'va per dies el nou parte
                        If oDTC.Parte.Where(Function(F) F.ID_Personal = CInt(Me.C_Personal.Value) And F.FechaInicio <= CDate(Me.DT_Inicio.Value) And F.FechaFin >= CDate(Me.DT_Inicio.Value)).Count > _NumPartesExistents Then ' miru si hi ha algun`parte, sigui com sigui
                            Mensaje.Mostrar_Mensaje("No puedes introducir un parte para todo el día ya que para el día " & Me.DT_Inicio.Value & " ya existe uno", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                            Exit Function
                        End If
                    Else 'va per hores el nou parte  'primer de tot ja ho estàs comparant malament no has de mirar-te partes t'has de mirar la taula on guardem els dies aprovats. on es guarden dia a dia
                        If oDTC.Parte.Where(Function(F) F.ID_Personal = CInt(Me.C_Personal.Value) And F.FechaInicio <= CDate(Me.DT_Inicio.Value) And F.FechaFin >= CDate(Me.DT_Inicio.Value) And F.AusenciaTipo.ComptaPerHores = False).Count > _NumPartesExistents Then ' miru si hi ha algun parte per tot el dia
                            Mensaje.Mostrar_Mensaje("No puedes introducir un parte ya que para el día " & Me.DT_Inicio.Value & " ya existe una para todo el día", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                            Exit Function
                        Else 'miru si hi ha algun parte per hores, com el que estic intentan introduir
                            If oDTC.Parte.Where(Function(F) F.ID_Personal = CInt(Me.C_Personal.Value) And F.FechaInicio <= CDate(Me.DT_Inicio.Value) And F.FechaFin >= CDate(Me.DT_Inicio.Value) And F.AusenciaTipo.ComptaPerHores = True).Count > _NumPartesExistents Then ' miru si hi ha algun parte per tot el dia
                                If Mensaje.Mostrar_Mensaje("Ya existe un parte por horas para el día " & Me.DT_Inicio.Value & ". Deseas guardar igualmente?", M_Mensaje.Missatge_Modo.PREGUNTA, , , True) = M_Mensaje.Botons.NO Then
                                    Exit Function
                                End If
                            End If
                        End If
                    End If
                Else
                    Dim _DataTemposal As Date = Me.DT_Inicio.Value
                    Dim _ParteDuplicatPerDies As Integer = 0
                    Dim _ParteDuplicatPerHores As Integer = 0
                    While Me.DT_Fin.Value >= _DataTemposal
                        If oDTC.Parte.Where(Function(F) F.ID_Personal = CInt(Me.C_Personal.Value) And F.FechaInicio <= CDate(_DataTemposal) And F.FechaFin >= CDate(_DataTemposal) And F.AusenciaTipo.ComptaPerHores = False).Count > _NumPartesExistents Then 'mirem si nhi ha per dies
                            _ParteDuplicatPerDies = _ParteDuplicatPerDies + 1
                        End If
                        If oDTC.Parte.Where(Function(F) F.ID_Personal = CInt(Me.C_Personal.Value) And F.FechaInicio <= CDate(_DataTemposal) And F.FechaFin >= CDate(_DataTemposal) And F.AusenciaTipo.ComptaPerHores = True).Count > _NumPartesExistents Then 'mirem si nhi ha per hores
                            _ParteDuplicatPerHores = _ParteDuplicatPerHores + 1
                        End If
                        _DataTemposal = _DataTemposal.AddDays(1)
                    End While

                    If Me.T_Horas.ReadOnly = True And (_ParteDuplicatPerDies > 0 Or _ParteDuplicatPerHores > 0) Then
                        Mensaje.Mostrar_Mensaje("Imposible añadir un parte en estas fechas, uno o más días seleccionados coinciden con un parte ya introducido", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                        Exit Function
                    End If
                End If
            End If
            'comprovació de si existeix algun parte***********************************************************


            Call GetFromForm(oLinqParte)

            If oLinqParte.ID_Parte = 0 Then  ' Comprovacio per saber si es un insertar o un nou
                oDTC.Parte.InsertOnSubmit(oLinqParte)

                oDTC.SubmitChanges()

                Me.TE_Codigo.Value = oLinqParte.ID_Parte

                Call Fichero.Cargar_GRID(oLinqParte.ID_Parte)

                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_AFEGIR_REGISTRE)
                '  Call CargaGrid_PersonasAsignadas(oLinqExpediente.ID_Expediente)  'Fem això pq al apretar el botó afegir de la grid de personal, si la acció no estava guardada peta

            Else
                oDTC.SubmitChanges()
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_MODIFICAR_REGISTRE)
            End If

            Me.EstableixCaptionForm("Parte: " & (oLinqParte.ID_Parte))

            Guardar = True

            Me.FormTancar()

            Me.GRD_Ficheros.Enabled = True

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Private Sub SetToForm()
        Try
            With oLinqParte

                Me.TE_Codigo.Text = .ID_Parte
                Me.C_Usuario.Value = .ID_Usuario
                Me.C_Planta.Value = .ID_Planta
                Me.C_Estado.Value = .ID_ParteEstado
                Me.C_Personal.Value = .ID_Personal
                Me.C_AusenciaTipo.Value = .ID_AusenciaTipo
                Me.T_Observaciones.Text = .Observaciones
                Me.DT_Alta.Value = .FechaAlta
                Me.DT_Inicio.Value = .FechaInicio
                Me.DT_Fin.Value = .FechaFin
                Me.T_Horas.Value = .HorasAusencia
                Me.CH_Compensado.Checked = .Compensado

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GetFromForm(ByRef pParte As Parte)
        Try
            With pParte
                If pParte.ID_Parte = 0 Then
                    .Usuario = oDTC.Usuario.Where(Function(F) F.ID_Usuario = CInt(Me.C_Usuario.Value)).FirstOrDefault
                    .Planta = oDTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault
                    .FechaAlta = Me.DT_Alta.Value
                End If
                If IsDBNull(Me.T_Horas.Value) = False Then
                    .HorasAusencia = DbnullToNothing(Me.T_Horas.Value)
                End If
                .Personal = oDTC.Personal.Where(Function(F) F.ID_Personal = CInt(Me.C_Personal.Value)).FirstOrDefault
                .AusenciaTipo = oDTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(Me.C_AusenciaTipo.Value)).FirstOrDefault
                .ParteEstado = oDTC.ParteEstado.Where(Function(F) F.ID_ParteEstado = CInt(Me.C_Estado.Value)).FirstOrDefault
                .Observaciones = Me.T_Observaciones.Text
                .FechaFin = Me.DT_Fin.Value
                .FechaInicio = Me.DT_Inicio.Value
                .Compensado = Me.CH_Compensado.Checked
            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Cargar_Form(ByVal pID As Integer)
        Try
            Call Netejar_Pantalla()
            Call Fichero.Cargar_GRID(pID)

            oLinqParte = (From taula In oDTC.Parte Where taula.ID_Parte = pID Select taula).First

            Call SetToForm()

            Select Case Me.C_Estado.Value
                Case EnumEstatsPartes.Pendiente
                    Me.C_Estado.Value = CInt(EnumEstatsPartes.Pendiente)
                    Me.ToolForm.ToolForm.Tools("PasarParteADenegado").SharedProps.Enabled = True
                    Me.ToolForm.ToolForm.Tools("PasarParteAAceptado").SharedProps.Enabled = True
                    Me.ToolForm.ToolForm.Tools("PasarParteAPendiente").SharedProps.Enabled = False
                Case EnumEstatsPartes.Aceptado
                    Me.C_Estado.Value = CInt(EnumEstatsPartes.Aceptado)
                    Me.ToolForm.ToolForm.Tools("PasarParteADenegado").SharedProps.Enabled = False
                    Me.ToolForm.ToolForm.Tools("PasarParteAAceptado").SharedProps.Enabled = False
                    Me.ToolForm.ToolForm.Tools("PasarParteAPendiente").SharedProps.Enabled = True
                Case EnumEstatsPartes.Denegado
                    Me.C_Estado.Value = CInt(EnumEstatsPartes.Denegado)
                    Me.ToolForm.ToolForm.Tools("PasarParteADenegado").SharedProps.Enabled = False
                    Me.ToolForm.ToolForm.Tools("PasarParteAAceptado").SharedProps.Enabled = False
                    Me.ToolForm.ToolForm.Tools("PasarParteAPendiente").SharedProps.Enabled = True
            End Select

            Me.EstableixCaptionForm("Parte: " & (oLinqParte.ID_Parte))



        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Netejar_Pantalla()

        oLinqParte = New Parte
        oDTC = New DTCDataContext(BD.Conexion)

        Util.Blanquejar(Me, M_Util.Enum_Controles_Activacion.TODOS, True)

        Me.TE_Codigo.Value = Nothing
        Me.TE_Codigo.Tag = Nothing
        Me.DT_Alta.Value = Now.Date
        Me.DT_Fin.Value = Now.Date
        Me.DT_Inicio.Value = Now.Date
        Me.T_Horas.Value = Nothing
        Me.T_Horas.ReadOnly = True

        Call Fichero.Cargar_GRID(0)

        Me.C_Usuario.Value = Seguretat.oUser.ID_Usuario
        Me.C_Estado.Value = 1 'pendiente
        Me.C_Planta.Value = Seguretat.oUser.CampoAux1
        Me.C_Personal.Value = -1
        Me.C_AusenciaTipo.Value = -1

        Me.Tab_Principal.Tabs("General").Selected = True

        Me.EstableixCaptionForm("Parte")

        ErrorProvider1.Clear()
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                oClsControls.ControlBuit(.C_AusenciaTipo)
                oClsControls.ControlBuit(.C_Estado)
                oClsControls.ControlBuit(.C_Planta)
                oClsControls.ControlBuit(.C_Personal)
                oClsControls.ControlBuit(.C_Usuario)
                oClsControls.ControlBuit(.DT_Fin)
                oClsControls.ControlBuit(.DT_Inicio)
                oClsControls.ControlBuit(.DT_Alta)

                If oDTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(Me.C_AusenciaTipo.Value)).FirstOrDefault.ComptaPerHores = True Then
                    oClsControls.ControlBuit(.T_Horas)
                End If
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Private Sub Cridar_Llistat_Generic()
        Dim LlistatGeneric As New M_LlistatGeneric.clsLlistatGeneric

        If Seguretat.oUser.CampoAux3 = EnumRRHH.Si Then
            LlistatGeneric.Mostrar_Llistat("Select * From C_Partes order by ID_Parte", Me.TE_Codigo, "ID_Parte", "ID_Parte")
        Else
            LlistatGeneric.Mostrar_Llistat("Select * From C_Partes where ID_Planta = " & Seguretat.oUser.CampoAux1 & " order by ID_Parte", Me.TE_Codigo, "ID_Parte", "ID_Parte")
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

#End Region

#Region "Events Varis"
    Private Sub TE_Codigo_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles TE_Codigo.EditorButtonClick
        If e.Button.Key = "Lupeta" Then
            Call Cridar_Llistat_Generic()
        End If
    End Sub

    Private Sub C_Personal_BeforeDropDown(sender As Object, e As EventArgs) Handles C_Personal.BeforeDropDown

        Dim _SQL As String = ""

        If oLinqParte.ID_Parte <> 0 Then
            _SQL = " or ID_Personal= " & oLinqParte.ID_Personal
        End If

        If IsNothing(Me.C_Planta.Value) = False Then
            Util.Cargar_Combo(Me.C_Personal, "SELECT ID_Personal, Nombre FROM Personal Where Activo = 1 " & _SQL & " and ID_Planta =  " & Me.C_Planta.Value & " ORDER BY Nombre", False, False)
        End If
        Me.C_Personal.Value = oLinqParte.ID_Personal
    End Sub

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

#End Region

    Private Sub C_AusenciaTipo_ValueChanged(sender As Object, e As EventArgs) Handles C_AusenciaTipo.ValueChanged
        If IsNumeric(Me.C_AusenciaTipo.Value) = True AndAlso Me.C_AusenciaTipo.Value > 0 Then
            Dim _PerHores As Boolean = oDTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(Me.C_AusenciaTipo.Value)).FirstOrDefault.ComptaPerHores
            If _PerHores = False Then
                Me.T_Horas.ReadOnly = True
                Me.T_Horas.Value = Nothing
            Else
                Me.T_Horas.ReadOnly = False
            End If
        End If
    End Sub
End Class