Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinToolbars

Public Class frmPersonal
    Implements IDisposable
    Dim oDTC As DTCDataContext
    Dim oLinqPersonal As Personal
    Dim Fichero As M_Archivos_Binarios.clsArchivosBinarios2
    Dim Fichero2 As M_Archivos_Binarios.clsArchivosBinarios2
    Dim Fichero3 As M_Archivos_Binarios.clsArchivosBinarios2

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
            If oLinqPersonal.ID_Personal <> 0 Then
                If Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE_PREGUNTA) = M_Mensaje.Botons.SI Then
                    oLinqPersonal.Activo = False
                    oDTC.SubmitChanges()
                    Call Netejar_Pantalla()
                    Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE)
                End If
            End If
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)

        End Try
    End Sub

    Private Sub ToolForm_m_ToolForm_Imprimir() Handles ToolForm.m_ToolForm_Imprimir

        If oLinqPersonal.ID_Personal = 0 Then
            Exit Sub
        End If

        Informes.ObrirInformePreparacio(oDTC, 3, "[ID_Personal] = '" & Me.TE_Codigo.Value & "'", "Personal: " & Me.TE_Codigo.Value, , , , , , False)
    End Sub

    Private Sub ToolForm_m_ToolForm_Nuevo() Handles ToolForm.m_ToolForm_Nuevo
        Call Netejar_Pantalla()
    End Sub

    Private Sub ToolForm_m_ToolForm_ToolClick_Botones_Extras(Sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles ToolForm.m_ToolForm_ToolClick_Botones_Extras
        Select Case e.Tool.Key
            Case "Cuadrante"
                Dim frm As New frmPersonal_ListadoCuadrante
                frm.Entrada()
                frm.FormObrir(Me)
            Case "Rancking"
                Dim frm As New frmPersonal_ListadoRanking
                frm.Entrada()
                frm.FormObrir(Me)
        End Select
    End Sub


#End Region

#Region "Metodes"

    Public Sub Entrada(Optional ByVal pID As Integer = 0)
        Try
            Me.AplicarDisseny()

            Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = True

            Util.Cargar_Combo(Me.C_TipoVia, "SELECT ID_Personal_TipoVia, Descripcio FROM Personal_TipoVia ORDER BY Descripcio", False)
            Util.Cargar_Combo(Me.C_Nacionalitat, "SELECT ID_Personal_Nacionalidad, Descripcion FROM Personal_Nacionalidad ORDER BY Descripcion", False)
            Util.Cargar_Combo(Me.C_Cargo, "SELECT ID_Personal_PuestoTrabajo, Nombre FROM Personal_PuestoTrabajo ORDER BY Nombre", False)
            Util.Cargar_Combo(Me.C_Categoria, "SELECT ID_Personal_Categoria, Descripcion FROM Personal_Categoria ORDER BY ID_Personal_Categoria", False)
            Util.Cargar_Combo(Me.C_Sexo, "SELECT ID_Sexo, Descripcion FROM Sexo ORDER BY ID_Sexo", False)
            Util.Cargar_Combo(Me.C_Planta, "SELECT ID_Planta, Descripcion FROM Planta Where Activo = 1 and ID_Planta <> 10 ORDER BY ID_Planta desc", False)
            Util.Cargar_Combo(Me.C_Estado, "SELECT ID_Personal_Estat, Descripcion FROM Personal_Estat ORDER BY ID_Personal_Estat desc", False)
            Util.Cargar_Combo(Me.C_AñoVacaciones, "SELECT ID_Año, Descripcion FROM Año ORDER BY ID_Año asc", False)
            Util.Cargar_Combo(Me.C_AñoAusencias, "SELECT ID_Año, Descripcion FROM Año ORDER BY ID_Año asc", False)
            Util.Cargar_Combo(Me.C_AñoResumen, "SELECT ID_Año, Descripcion FROM Año ORDER BY ID_Año asc", False)

            'Me.GRD_Ausencias.M.clsToolBar.Boto_Afegir("Introducir período", "Introducir período", True)
            'Me.GRD_Vacaciones.M.clsToolBar.Boto_Afegir("Introducir período", "Introducir período", True)

            Me.GRD_Ficheros.M.clsToolBar.Boto_Afegir("FotoPredeterminada", "Foto Predeterminada", True)
            Me.GRD_Ficheros.M.clsToolBar.Boto_Afegir("QuitarFotoPredeterminada", "Quitar foto predeterminada", True)

            Fichero = New M_Archivos_Binarios.clsArchivosBinarios2(BD, Me.GRD_Ficheros, "Personal_Archivo", 1)
            Fichero2 = New M_Archivos_Binarios.clsArchivosBinarios2(BD, Me.GRD_Ficheros2, "Personal_Archivo2", 1)
            Fichero3 = New M_Archivos_Binarios.clsArchivosBinarios2(BD)

            AddHandler Fichero.DespresDeCarregarDades, AddressOf DespresDeCarregarDadesGridArchivos
            AddHandler Fichero.DespresDeEliminarRegistre, AddressOf DespresDeEliminarElRegistreArchivos

            Picture_FotoPersonal.Properties.ContextMenuStrip = New ContextMenuStrip

            Me.ToolForm.M.Botons.tAccions.SharedProps.Visible = True
            Me.ToolForm.M.clsToolBar.Afegir_BotoAccions("Cuadrante", "Listado cuadrante", True)
            Me.ToolForm.M.clsToolBar.Afegir_BotoAccions("Rancking", "Ranking de ausencias", True)

            If pID <> 0 Then
                Call Cargar_Form(pID)
            Else
                Call Netejar_Pantalla()
            End If

            Call DespresDeCarregarDadesGridArchivos()

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

            Call GetFromForm(oLinqPersonal)

            If oLinqPersonal.ID_Personal = 0 Then  ' Comprovacio per saber si es un insertar o un nou
                oDTC.Personal.InsertOnSubmit(oLinqPersonal)

                oDTC.SubmitChanges()

                Me.TE_Codigo.Value = oLinqPersonal.ID_Personal

                Call Fichero.Cargar_GRID(oLinqPersonal.ID_Personal)
                Call Fichero2.Cargar_GRID(oLinqPersonal.ID_Personal)
                Call CargarGid_Partes(oLinqPersonal.ID_Personal)


                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_AFEGIR_REGISTRE)
                '  Call CargaGrid_PersonasAsignadas(oLinqExpediente.ID_Expediente)  'Fem això pq al apretar el botó afegir de la grid de personal, si la acció no estava guardada peta

            Else
                oDTC.SubmitChanges()
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_MODIFICAR_REGISTRE)
            End If

            Me.EstableixCaptionForm("Personal: " & (oLinqPersonal.Nombre))

            If IsNothing(Me.DT_Nacimiento.Value) = False Then
                Me.T_Edad.Text = Math.Truncate(DateDiff("m", Me.DT_Nacimiento.Value, Now.Date) / 12)
            Else
                Me.T_Edad.Text = ""
            End If


            Guardar = True

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Private Sub SetToForm()
        Try
            With oLinqPersonal

                Me.TE_Codigo.Text = .ID_Personal
                Me.C_Planta.Value = .ID_Planta
                Me.C_Cargo.Value = .ID_Personal_PuestoTrabajo
                Me.C_Categoria.Value = .ID_Personal_Categoria
                Me.C_TipoVia.Value = .ID_Personal_TipoVia
                Me.C_Nacionalitat.Value = .ID_Personal_Nacionalitat
                Me.C_Sexo.Value = .ID_Sexo
                Me.C_Estado.Value = .ID_Personal_Estat
                Me.T_Nom.Text = .Nombre
                Me.T_Gestoria.Text = .NumGestoria
                Me.T_Tarifa.Text = .Tarifa
                Me.CH_Dietas.Checked = .ControlDietas
                Me.T_Contrato.Text = .CodigoContrato
                Me.T_ComptaComptable.Text = .CuentaComptable
                Me.T_DNI.Text = .Dni
                Me.T_SS.Text = .NumSS
                Me.T_CuentaCorriente.Text = .NumCuentaCorriente
                Me.T_Vacaciones_Anteriores.Value = DbnullToNothing(.Vacaciones_Anteriores)
                Me.T_Direccion.Text = .Direccion
                Me.T_Poblacio.Text = .Poblacion
                Me.T_Provincia.Text = .Provincia
                Me.T_CP.Text = .CP
                Me.T_TelCasa.Text = .TelCasa
                Me.T_TelMovil.Text = .TelMovil
                Me.T_TelMovilEmpresa.Text = .TelMovilEmpresa
                Me.T_ExtensionTelEmpresa.Text = .TelExtensioEmpresa
                Me.T_Mail.Text = .Email
                Me.T_MailEmpresa.Text = .Email_Empresa
                Me.DT_Baja.Value = .FechaBaja
                Me.DT_Antiguedad.Value = .FechaAntiguedad
                Me.DT_Nacimiento.Value = .FechaNacimiento
                Me.T_MotivoBaja.Text = .MotivoBaja
                Me.T_Observaciones.Text = .Observaciones

                Me.T_DiasAcordadosContrato.Value = oDTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(EnumAusenciaTipo.Dias_acordados)).FirstOrDefault.Hores_o_Dies
                Me.T_DiasAcordadosUtilizados.Value = oDTC.Personal_Ausencia.Where(Function(F) F.ID_Personal = CInt(.ID_Personal) And F.ID_AusenciaTipo = CInt(EnumAusenciaTipo.Dias_acordados)).Count
                Me.T_DiasAcordadosDescontar.Value = oDTC.Personal_Ausencia.Where(Function(F) F.ID_Personal = CInt(.ID_Personal) And F.AusenciaTipo.Desconta_20_min = True).Count * 0.25 / 7.75
                If (Math.Truncate(Me.T_DiasAcordadosDescontar.Value)) >= 1 Then
                    Me.T_DiasAcordadosPendientes.Value = Me.T_DiasAcordadosContrato.Value - Me.T_DiasAcordadosUtilizados.Value - Me.T_DiasAcordadosDescontar.Value
                Else
                    Me.T_DiasAcordadosPendientes.Value = Me.T_DiasAcordadosContrato.Value - Me.T_DiasAcordadosUtilizados.Value
                End If


                If IsNothing(Me.DT_Nacimiento.Value) = False Then
                    Me.T_Edad.Text = Math.Truncate(DateDiff("m", Me.DT_Nacimiento.Value, Now.Date) / 12)
                Else
                    Me.T_Edad.Text = ""
                End If

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GetFromForm(ByRef pPersonal As Personal)
        Try
            With pPersonal
                .Activo = True

                .Planta = oDTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault
                .Personal_Estat = oDTC.Personal_Estat.Where(Function(F) F.ID_Personal_Estat = CInt(Me.C_Estado.Value)).FirstOrDefault
                .Sexo = oDTC.Sexo.Where(Function(F) F.ID_Sexo = CInt(Me.C_Sexo.Value)).FirstOrDefault
                .Personal_Categoria = oDTC.Personal_Categoria.Where(Function(F) F.ID_Personal_Categoria = CInt(Me.C_Categoria.Value)).FirstOrDefault
                .Personal_PuestoTrabajo = oDTC.Personal_PuestoTrabajo.Where(Function(F) F.ID_Personal_PuestoTrabajo = CInt(Me.C_Cargo.Value)).FirstOrDefault
                .Personal_Nacionalidad = oDTC.Personal_Nacionalidad.Where(Function(F) F.ID_Personal_Nacionalidad = CInt(Me.C_Nacionalitat.Value)).FirstOrDefault
                .Personal_TipoVia = oDTC.Personal_TipoVia.Where(Function(F) F.ID_Personal_TipoVia = CInt(Me.C_TipoVia.Value)).FirstOrDefault

                .Nombre = Me.T_Nom.Text
                .NumGestoria = Me.T_Gestoria.Text
                .Tarifa = Me.T_Tarifa.Text
                .ControlDietas = Me.CH_Dietas.Checked
                .CodigoContrato = Me.T_Contrato.Text
                .CuentaComptable = Me.T_ComptaComptable.Text
                .FechaAntiguedad = Me.DT_Antiguedad.Value
                .FechaBaja = Me.DT_Baja.Value
                .FechaNacimiento = Me.DT_Nacimiento.Value
                .Dni = Me.T_DNI.Text
                .NumSS = Me.T_SS.Text
                .NumCuentaCorriente = Me.T_CuentaCorriente.Text
                If IsDBNull(Me.T_Vacaciones_Anteriores.Value) Then
                    Me.T_Vacaciones_Anteriores.Value = 0
                    .Vacaciones_Anteriores = 0
                Else
                    .Vacaciones_Anteriores = Me.T_Vacaciones_Anteriores.Value
                End If
                .Direccion = Me.T_Direccion.Text
                .Poblacion = Me.T_Poblacio.Text
                .Provincia = Me.T_Provincia.Text
                .CP = Me.T_CP.Text
                .TelCasa = Me.T_TelCasa.Text
                .TelMovil = Me.T_TelMovil.Text
                .TelMovilEmpresa = Me.T_TelMovilEmpresa.Text
                .TelExtensioEmpresa = Me.T_ExtensionTelEmpresa.Text
                .Email = Me.T_Mail.Text
                .Email_Empresa = Me.T_MailEmpresa.Text
                .MotivoBaja = Me.T_MotivoBaja.Text
                .Observaciones = Me.T_Observaciones.Text

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Cargar_Form(ByVal pID As Integer)
        Try
            Call Netejar_Pantalla()

            oLinqPersonal = (From taula In oDTC.Personal Where taula.ID_Personal = pID Select taula).First

            Call SetToForm()

            Call Fichero.Cargar_GRID(pID)
            Call Fichero2.Cargar_GRID(pID)
            Call CargarGid_Partes(pID)
            Call CargaGrid_Sanciones(pID)
            Call CargaGrid_Ausencias(pID)
            Call CargaGrid_Vacaciones(pID)
            Call CargaGrid_Resumen(pID)
            Call CargarFoto()

            Me.EstableixCaptionForm("Personal: " & (oLinqPersonal.Nombre))

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Netejar_Pantalla()

        oLinqPersonal = New Personal
        oDTC = New DTCDataContext(BD.Conexion)

        Util.Blanquejar(Me, M_Util.Enum_Controles_Activacion.TODOS, True)

        Me.TE_Codigo.Value = Nothing
        Me.TE_Codigo.Tag = Nothing
        Me.T_Vacaciones_Anteriores.Value = Nothing

        Me.C_Planta.SelectedIndex = 10 'todas
        Me.C_Categoria.SelectedIndex = -1
        Me.C_Nacionalitat.SelectedIndex = -1
        Me.C_TipoVia.SelectedIndex = -1
        Me.C_Cargo.SelectedIndex = -1
        Me.C_Sexo.SelectedIndex = -1
        Me.C_Estado.SelectedIndex = 1

        Me.C_AñoAusencias.Text = Now.Year
        Me.C_AñoVacaciones.Text = Now.Year
        Me.C_AñoResumen.Text = Now.Year

        Call Fichero.Cargar_GRID(0)
        Call Fichero2.Cargar_GRID(0)
        Call CargarGid_Partes(0)
        Call CargaGrid_Sanciones(0)
        Call CargaGrid_Ausencias(0)
        Call CargaGrid_Vacaciones(0)
        Call CargaGrid_Resumen(0)

        Util.TabPintarHeaderTab(Me.Tab_Principal.Tabs("AusenciasFicheros"), Nothing)

        Call CargarFoto()

        Me.EstableixCaptionForm("Personal")

        ErrorProvider1.Clear()

    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()

                oClsControls.ControlBuit(.T_Nom)
                oClsControls.ControlBuit(.C_Categoria)
                oClsControls.ControlBuit(.C_Nacionalitat)
                oClsControls.ControlBuit(.T_DNI)
                oClsControls.ControlBuit(.C_Estado)
                oClsControls.ControlBuit(.C_Cargo)
                oClsControls.ControlBuit(.C_Estado)

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
        LlistatGeneric.Mostrar_Llistat("Select * From C_Personal Where Activo=1 order by ID_Personal", Me.TE_Codigo, "ID_Personal", "ID_Personal")
        AddHandler LlistatGeneric.AlTancarLlistatGeneric, AddressOf AlTancarLlistat
    End Sub

    Private Sub AlTancarLlistat(ByVal pID As String)
        Try
            Call Cargar_Form(pID)
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    Private Sub CargarFoto()
        If oLinqPersonal.ID_Archivo_FotoPredeterminada.HasValue = True Then
            If oLinqPersonal.Archivo.CampoBinario Is Nothing = False Then
                Me.Picture_FotoPersonal.Image = Util.BinaryToImage(oLinqPersonal.Archivo.CampoBinario.ToArray)
            End If
        Else
            Me.Picture_FotoPersonal.Image = Nothing
        End If
    End Sub

#End Region

#Region "Events Varis"

    Private Sub TE_Codigo_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles TE_Codigo.EditorButtonClick
        If e.Button.Key = "Lupeta" Then
            Call Cridar_Llistat_Generic()
        End If
    End Sub

    Private Sub C_Estado_ValueChanged(sender As Object, e As EventArgs) Handles C_Estado.ValueChanged
        If IsNumeric(Me.C_Estado.Value) = True Then
            If Me.C_Estado.Value = EnumEstatPersonal.Baixa Then
                Me.UltraGroupBox2.Enabled = True
            Else
                Me.UltraGroupBox2.Enabled = False
            End If
        End If
    End Sub

    Private Sub Tab_Principal_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles Tab_Principal.SelectedTabChanged
        If e.Tab.Key = "Sanciones" Then
            Call CargaGrid_Sanciones(oLinqPersonal.ID_Personal)
        End If

        If e.Tab.Key = "Ausencias" Then
            Call CargaGrid_Ausencias(oLinqPersonal.ID_Personal)
        End If

        If e.Tab.Key = "Vacaciones" Then
            Call CargaGrid_Vacaciones(oLinqPersonal.ID_Personal)
        End If

        If e.Tab.Key = "Resumen" Then
            Call CargaGrid_Resumen(oLinqPersonal.ID_Personal)
        End If
    End Sub

#End Region

#Region "Grid sanciones"

    Private Sub CargaGrid_Sanciones(ByVal pId As Integer)
        Try
            Dim _Sancion As IEnumerable(Of Personal_Sanciones) = From taula In oDTC.Personal_Sanciones Where taula.ID_Personal = pId Order By taula.ID_Personal_Sanciones Select taula

            With Me.GRD_Sanciones

                .M.clsUltraGrid.CargarIEnumerable(_Sancion)
                .M_Editable()
                .M_TreureFocus()

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub


    Private Sub GRD_Sanciones_M_ToolGrid_ToolAfegir(ByRef sender As UltraToolbarsManager, ByRef e As ToolClickEventArgs) Handles GRD_Sanciones.M_ToolGrid_ToolAfegir

        If oLinqPersonal.ID_Personal = 0 Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_PRIMER_GUARDA_ENTITAT_PRINCIPAL)
            Exit Sub
        End If

        With Me.GRD_Sanciones
            .M_ExitEditMode()
            .M_AfegirFila()

            .GRID.Rows(.GRID.Rows.Count - 1).Cells("Fecha").Value = Now
            .GRID.Rows(.GRID.Rows.Count - 1).Cells("Personal").Value = oLinqPersonal
        End With

    End Sub

    Private Sub GRD_Sanciones_M_GRID_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles GRD_Sanciones.M_GRID_AfterRowUpdate
        Try
            oDTC.SubmitChanges()
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_Sanciones_M_ToolGrid_ToolEliminarRow(ByRef sender As UltraGrid, ByRef e As UltraGridRow) Handles GRD_Sanciones.M_ToolGrid_ToolEliminarRow
        Try
            If e.IsAddRow Then
                oLinqPersonal.Personal_Sanciones.Remove(e.ListObject)
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


#End Region

#Region "Grid Ausencias"

    Private Sub CargaGrid_Ausencias(ByVal pId As Integer)
        'Try
        '    Dim _Ausencia As IEnumerable(Of Personal_Ausencia) = From taula In oDTC.Personal_Ausencia Where taula.ID_Personal = pId And taula.Fecha.Year = CInt(Me.C_AñoAusencias.Text) And taula.ID_AusenciaTipo <> EnumTipoAusencia.Vacaciones Order By taula.ID_Personal_Ausencia Select taula

        '    With Me.GRD_Ausencias

        '        .M.clsUltraGrid.CargarIEnumerable(_Ausencia)

        '        .GRID.DisplayLayout.Bands(0).Columns("NumHores").Style = ColumnStyle.Double

        '    End With

        'Catch ex As Exception
        '    Mensaje.Mostrar_Mensaje_Error(ex)
        'End Try

        Try
            With Me.GRD_Ausencias

                Dim DTS As New DataSet
                BD.CargarDataSet(DTS, "Select * From C_PersonalAusencias Where ID_Personal = " & pId & " And ID_AusenciaTipo <> " & EnumTipoAusencia.Vacaciones & " and YEAR(Fecha) = " & Me.C_AñoAusencias.Text & " Order by Fecha")

                .M.clsUltraGrid.Cargar(DTS)
                .GRID.ActiveRow = Nothing
                .GRID.DisplayLayout.Bands(0).Columns("NumHores").Style = ColumnStyle.Double

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub C_AñoAusencias_ValueChanged(sender As Object, e As EventArgs) Handles C_AñoAusencias.ValueChanged
        If IsNumeric(Me.C_Estado.Value) = True Then
            Call CargaGrid_Ausencias(oLinqPersonal.ID_Personal)
        End If
    End Sub

    Private Sub GRD_Ausencias_M_ToolGrid_ToolVisualitzarDobleClickRow() Handles GRD_Ausencias.M_ToolGrid_ToolVisualitzarDobleClickRow
        If Me.GRD_Ausencias.GRID.Selected.Rows.Count <> 1 Then
            Exit Sub
        End If

        Dim frm As New frmParte
        frm.Entrada(Me.GRD_Ausencias.GRID.Selected.Rows(0).Cells("ID_Parte").Value)
        frm.FormObrir(Me, True)
    End Sub

    'Private Sub CargarCombo_AusenciaTipoA(ByVal pGrid As UltraWinGrid.UltraGrid, ByRef pCell As UltraWinGrid.UltraGridCell, ByVal pTots As Boolean)
    '    Try

    '        Dim oTaula As IQueryable(Of AusenciaTipo)
    '        Dim Valors As New Infragistics.Win.ValueList
    '        Dim _AusenciaTipo As AusenciaTipo = pCell.Value


    '        oTaula = (From Taula In oDTC.AusenciaTipo Where Taula.ID_AusenciaTipo <> EnumTipoAusencia.Vacaciones Order By Taula.Descripcion Select Taula)


    '        Dim Var As AusenciaTipo

    '        For Each Var In oTaula
    '            Valors.ValueListItems.Add(Var, Var.Descripcion)
    '        Next

    '        pCell.ValueList = Valors.Clone
    '        pGrid.DisplayLayout.Bands(0).Columns("AusenciaTipo").Style = ColumnStyle.DropDown

    '    Catch ex As Exception
    '        Mensaje.Mostrar_Mensaje_Error(ex)
    '    End Try
    'End Sub

    'Private Sub GRD_Ausencias_M_GRID_BeforeCellActivate(ByRef sender As UltraGrid, ByRef e As CancelableCellEventArgs) Handles GRD_Ausencias.M_GRID_BeforeCellActivate
    '    If e.Cell.Column.Key = "AusenciaTipo" Then
    '        Call CargarCombo_AusenciaTipoA(sender, e.Cell, False)
    '    End If
    'End Sub

    'Private Sub GRD_Ausencias_M_Grid_InitializeRow(Sender As Object, e As InitializeRowEventArgs) Handles GRD_Ausencias.M_Grid_InitializeRow
    '    If e.ReInitialize = False Then
    '        Call CargarCombo_AusenciaTipoA(Sender, e.Row.Cells("AusenciaTipo"), True)
    '    End If
    'End Sub

    'Private Sub GRD_Ausencias_M_ToolGrid_ToolAfegir(ByRef sender As UltraToolbarsManager, ByRef e As ToolClickEventArgs) Handles GRD_Ausencias.M_ToolGrid_ToolAfegir

    '    If oLinqPersonal.ID_Personal = 0 Then
    '        Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_PRIMER_GUARDA_ENTITAT_PRINCIPAL)
    '        Exit Sub
    '    End If

    '    With Me.GRD_Ausencias
    '        .M_ExitEditMode()
    '        .M_AfegirFila()

    '        .GRID.Rows(.GRID.Rows.Count - 1).Cells("Fecha").Value = Now
    '        .GRID.Rows(.GRID.Rows.Count - 1).Cells("Personal").Value = oLinqPersonal

    '    End With

    'End Sub

    'Private Sub GRD_Ausencias_M_GRID_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles GRD_Ausencias.M_GRID_AfterRowUpdate
    '    Try
    '        If oDTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(e.Row.Cells("ID_AusenciaTipo").Value)).FirstOrDefault.ComptaPerHores = True And (IsNothing(e.Row.Cells("NumHores").Value) = True Or e.Row.Cells("NumHores").Value = 0) Then
    '            Mensaje.Mostrar_Mensaje("Para este tipo de ausencia es obligatorio introducir el campo horas", M_Mensaje.Missatge_Modo.ERRORS, , , True)
    '            e.Row.CancelUpdate()
    '            Exit Sub
    '        End If

    '        oDTC.SubmitChanges()
    '    Catch ex As Exception
    '        Mensaje.Mostrar_Mensaje_Error(ex)
    '    End Try
    'End Sub

    Private Sub GRD_Ausencias_M_ToolGrid_ToolEliminarRow(ByRef sender As UltraGrid, ByRef e As UltraGridRow) Handles GRD_Ausencias.M_ToolGrid_ToolEliminarRow
        Try
            If e.IsAddRow Then
                oLinqPersonal.Personal_Ausencia.Remove(e.ListObject)
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


    'Private Sub GRD_Ausencias_M_ToolGrid_ToolClickBotonsExtras2(ByRef sender As UltraToolbarsManager, ByRef e As ToolClickEventArgs, ByRef pGrid As M_UltraGrid.m_UltraGrid) Handles GRD_Ausencias.M_ToolGrid_ToolClickBotonsExtras2
    '    Select Case e.Tool.Key
    '        Case "Introducir período"
    '            Dim frm As New frmPersonalPeriodoAusencia
    '            frm.Entrada(oLinqPersonal, oDTC, EnumTipoAusencia.Otros)
    '            AddHandler frm.FormClosing, AddressOf AlTancarfrmPeriodeA
    '            frm.FormObrir(Me)
    '    End Select
    'End Sub

    'Private Sub AlTancarfrmPeriodeA()
    '    Call CargaGrid_Ausencias(oLinqPersonal.ID_Personal)
    'End Sub

#End Region

#Region "Grid Vacaciones"

    Private Sub CargaGrid_Vacaciones(ByVal pId As Integer)
        'Try
        '    Dim _Ausencia As IEnumerable(Of Personal_Ausencia) = From taula In oDTC.Personal_Ausencia Where taula.ID_Personal = pId And taula.Fecha.Year = CInt(Me.C_AñoVacaciones.Text) And taula.ID_AusenciaTipo = EnumTipoAusencia.Vacaciones Order By taula.ID_Personal_Ausencia Select taula

        '    With Me.GRD_Vacaciones

        '        .M.clsUltraGrid.CargarIEnumerable(_Ausencia)

        '    End With

        'Catch ex As Exception
        '    Mensaje.Mostrar_Mensaje_Error(ex)
        'End Try

        Try
            With Me.GRD_Vacaciones

                Dim DTS As New DataSet
                BD.CargarDataSet(DTS, "Select * From C_PersonalAusencias Where ID_Personal = " & pId & " And ID_AusenciaTipo = " & EnumTipoAusencia.Vacaciones & " and YEAR(Fecha) = " & Me.C_AñoVacaciones.Text & " Order by Fecha")

                .M.clsUltraGrid.Cargar(DTS)
                .GRID.ActiveRow = Nothing
                .GRID.DisplayLayout.Bands(0).Columns("NumHores").Style = ColumnStyle.Double

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub C_AñoVacaciones_ValueChanged(sender As Object, e As EventArgs) Handles C_AñoVacaciones.ValueChanged
        If IsNumeric(Me.C_AñoVacaciones.Value) = True Then
            Call CargaGrid_Vacaciones(oLinqPersonal.ID_Personal)
        End If
    End Sub

    Private Sub GRD_Vacaciones_M_ToolGrid_ToolVisualitzarDobleClickRow() Handles GRD_Vacaciones.M_ToolGrid_ToolVisualitzarDobleClickRow
        If Me.GRD_Vacaciones.GRID.Selected.Rows.Count <> 1 Then
            Exit Sub
        End If

        Dim frm As New frmParte
        frm.Entrada(Me.GRD_Vacaciones.GRID.Selected.Rows(0).Cells("ID_Parte").Value)
        frm.FormObrir(Me, True)
    End Sub

    'Private Sub CargarCombo_AusenciaTipoV(ByVal pGrid As UltraWinGrid.UltraGrid, ByRef pCell As UltraWinGrid.UltraGridCell, ByVal pTots As Boolean)
    '    Try

    '        Dim oTaula As IQueryable(Of AusenciaTipo)
    '        Dim Valors As New Infragistics.Win.ValueList
    '        Dim _AusenciaTipo As AusenciaTipo = pCell.Value


    '        oTaula = (From Taula In oDTC.AusenciaTipo Where Taula.ID_AusenciaTipo = EnumTipoAusencia.Vacaciones Order By Taula.Descripcion Select Taula)


    '        Dim Var As AusenciaTipo

    '        For Each Var In oTaula
    '            Valors.ValueListItems.Add(Var, Var.Descripcion)
    '        Next

    '        pCell.ValueList = Valors.Clone
    '        pGrid.DisplayLayout.Bands(0).Columns("AusenciaTipo").Style = ColumnStyle.DropDown

    '    Catch ex As Exception
    '        Mensaje.Mostrar_Mensaje_Error(ex)
    '    End Try
    'End Sub

    'Private Sub GRD_Vacaciones_M_GRID_BeforeCellActivate(ByRef sender As UltraGrid, ByRef e As CancelableCellEventArgs) Handles GRD_Vacaciones.M_GRID_BeforeCellActivate
    '    If e.Cell.Column.Key = "AusenciaTipo" Then
    '        Call CargarCombo_AusenciaTipoV(sender, e.Cell, False)
    '    End If
    'End Sub

    'Private Sub GRD_Vacaciones_M_Grid_InitializeRow(Sender As Object, e As InitializeRowEventArgs) Handles GRD_Vacaciones.M_Grid_InitializeRow
    '    If e.ReInitialize = False Then
    '        Call CargarCombo_AusenciaTipoV(Sender, e.Row.Cells("AusenciaTipo"), True)
    '    End If
    'End Sub

    'Private Sub GRD_Vacaciones_M_ToolGrid_ToolAfegir(ByRef sender As UltraToolbarsManager, ByRef e As ToolClickEventArgs) Handles GRD_Vacaciones.M_ToolGrid_ToolAfegir

    '    If oLinqPersonal.ID_Personal = 0 Then
    '        Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_PRIMER_GUARDA_ENTITAT_PRINCIPAL)
    '        Exit Sub
    '    End If

    '    With Me.GRD_Vacaciones
    '        .M_ExitEditMode()
    '        .M_AfegirFila()

    '        '.GRID.Rows(.GRID.Rows.Count - 1).Cells("AusenciaTipo").Value = EnumTipoAusencia.Vacaciones
    '        .GRID.Rows(.GRID.Rows.Count - 1).Cells("Fecha").Value = Now
    '        .GRID.Rows(.GRID.Rows.Count - 1).Cells("AusenciaTipo").Value = oDTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(EnumTipoAusencia.Vacaciones)).FirstOrDefault
    '        .GRID.Rows(.GRID.Rows.Count - 1).Cells("Personal").Value = oLinqPersonal

    '    End With

    'End Sub

    'Private Sub GRD_Vacaciones_M_GRID_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles GRD_Vacaciones.M_GRID_AfterRowUpdate
    '    Try
    '        oDTC.SubmitChanges()
    '    Catch ex As Exception
    '        Mensaje.Mostrar_Mensaje_Error(ex)
    '    End Try
    'End Sub

    Private Sub GRD_Vacaciones_M_ToolGrid_ToolEliminarRow(ByRef sender As UltraGrid, ByRef e As UltraGridRow) Handles GRD_Vacaciones.M_ToolGrid_ToolEliminarRow
        Try
            If e.IsAddRow Then
                oLinqPersonal.Personal_Ausencia.Remove(e.ListObject)
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

    'Private Sub GRD_Vacaciones_M_ToolGrid_ToolClickBotonsExtras2(ByRef sender As UltraToolbarsManager, ByRef e As ToolClickEventArgs, ByRef pGrid As M_UltraGrid.m_UltraGrid) Handles GRD_Vacaciones.M_ToolGrid_ToolClickBotonsExtras2
    '    Select Case e.Tool.Key
    '        Case "Introducir período"
    '            Dim frm As New frmPersonalPeriodoAusencia
    '            frm.Entrada(oLinqPersonal, oDTC, EnumTipoAusencia.Vacaciones)
    '            AddHandler frm.FormClosing, AddressOf AlTancarfrmPeriodeV
    '            frm.FormObrir(Me)
    '    End Select
    'End Sub

    'Private Sub AlTancarfrmPeriodeV()
    '    Call CargaGrid_Vacaciones(oLinqPersonal.ID_Personal)
    'End Sub

#End Region

#Region "Grid Resumen"
    Private Sub CargaGrid_Resumen(ByVal pId As Integer)
        Try
            Dim _consulta As String = "SELECT dbo.Personal_Ausencia.ID_Personal, dbo.AusenciaTipo.Descripcion AS TipoAusencia, (dbo.AusenciaTipo.Hores_o_Dies + Case dbo.AusenciaTipo.ID_AusenciaTipo when 1 then isnull(dbo.Personal.Vacaciones_anteriores,0) else 0 end) as Dies_usables, Case dbo.AusenciaTipo.ComptaPerHores when 1 then NULL else COUNT(dbo.Personal_Ausencia.Fecha) End AS NumDies, SUM(dbo.Personal_Ausencia.NumHores) AS SumHores, Case dbo.AusenciaTipo.ID_AusenciaTipo when 1 then isnull(dbo.Personal.Vacaciones_anteriores,0) else NULL end As VacacionesAnteriores, case dbo.AusenciaTipo.Hores_o_Dies when 0 then NULL else (dbo.AusenciaTipo.Hores_o_Dies + Case dbo.AusenciaTipo.ID_AusenciaTipo when 1 then isnull(dbo.Personal.Vacaciones_anteriores,0) else 0 end - isnull(SUM(dbo.Personal_Ausencia.NumHores),0) - Case dbo.AusenciaTipo.ComptaPerHores when 1 then 0 else COUNT(dbo.Personal_Ausencia.Fecha) End) end AS Diferencia, Case dbo.AusenciaTipo.Desconta_20_min when 0 then NULL else (COUNT(dbo.Personal_Ausencia.Fecha) * 0.25) / 7.75 End AS Veinte_minutos FROM dbo.Personal_Ausencia INNER JOIN dbo.AusenciaTipo ON dbo.Personal_Ausencia.ID_AusenciaTipo = dbo.AusenciaTipo.ID_AusenciaTipo INNER JOIN dbo.Personal ON dbo.Personal.ID_Personal = dbo.Personal_Ausencia.ID_Personal WHERE dbo.Personal.ID_Personal = " & oLinqPersonal.ID_Personal & " and (Year(dbo.Personal_Ausencia.Fecha) = " & Me.C_AñoResumen.Text & ") GROUP BY dbo.Personal_Ausencia.ID_Personal, dbo.Personal_Ausencia.ID_AusenciaTipo, dbo.AusenciaTipo.Descripcion, dbo.AusenciaTipo.ComptaPerHores, dbo.AusenciaTipo.Hores_o_Dies, dbo.AusenciaTipo.ID_AusenciaTipo, dbo.Personal.Vacaciones_anteriores, dbo.AusenciaTipo.Desconta_20_min"

            Dim _Resumen As DataTable = BD.RetornaDataTable(_consulta)

            Me.GRD_Resumen.M.clsUltraGrid.Cargar(_Resumen)

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub C_AñoResumen_ValueChanged(sender As Object, e As EventArgs) Handles C_AñoResumen.ValueChanged
        If IsNumeric(Me.C_AñoResumen.Value) = True Then
            Call CargaGrid_Resumen(oLinqPersonal.ID_Personal)
        End If
    End Sub
#End Region

#Region "Grid Archivos"

    Private Sub GRD_Ficheros_M_ToolGrid_ToolClickBotonsExtras(ByRef sender As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager, ByRef e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles GRD_Ficheros.M_ToolGrid_ToolClickBotonsExtras
        Try
            If e.Tool.Key = "FotoPredeterminada" AndAlso Me.GRD_Ficheros.GRID.Selected.Rows.Count = 1 Then
                Dim _IDArchivo As Integer = Me.GRD_Ficheros.GRID.Selected.Rows(0).Cells("ID_Archivo").Value
                Dim _Archivo As Archivo
                _Archivo = oDTC.Archivo.Where(Function(F) F.ID_Archivo = _IDArchivo).FirstOrDefault
                If _Archivo.Tipo.ToString.ToLower.Contains("image") = True Or _Archivo.Tipo.ToString.ToLower.Contains("jpg") = True Or _Archivo.Tipo.ToString.ToLower.Contains("jpeg") = True Or _Archivo.Tipo.ToString.ToLower.Contains("png") = True Or _Archivo.Tipo.ToString.ToLower.Contains("tiff") = True Or _Archivo.Tipo.ToString.ToLower.Contains("gif") = True Or _Archivo.Tipo.ToString.ToLower.Contains("bmp") = True Then
                Else
                    Mensaje.Mostrar_Mensaje("Sólo se pueden predeterminar ficheros de tipo imagen", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)
                    Exit Sub
                End If
                oLinqPersonal.Archivo = _Archivo
                oDTC.SubmitChanges()

                Call DespresDeCarregarDadesGridArchivos()
                Call CargarFoto()
            End If

            If e.Tool.Key = "QuitarFotoPredeterminada" Then
                oLinqPersonal.Archivo = Nothing
                oDTC.SubmitChanges()
                'End If
                Call DespresDeCarregarDadesGridArchivos()
                Call CargarFoto()
            End If
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub DespresDeCarregarDadesGridArchivos()
        Try
            If Me.GRD_Ficheros.GRID.Rows.Count > 0 Then
                Dim pRow As UltraGridRow
                For Each pRow In Me.GRD_Ficheros.GRID.Rows
                    If oLinqPersonal.ID_Archivo_FotoPredeterminada.HasValue = True AndAlso pRow.Cells("ID_Archivo").Value = oLinqPersonal.ID_Archivo_FotoPredeterminada Then
                        pRow.CellAppearance.BackColor = Color.LightGreen
                    Else
                        pRow.CellAppearance.BackColor = Color.White
                    End If
                Next
                Me.GRD_Ficheros.GRID.ActiveRow = Nothing
                Me.GRD_Ficheros.GRID.Selected.Rows.Clear()
            End If
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub DespresDeEliminarElRegistreArchivos(ByVal pIDArchivo As Integer)
        If pIDArchivo = oLinqPersonal.ID_Archivo_FotoPredeterminada Then
            oLinqPersonal.ID_Archivo_FotoPredeterminada = Nothing
            oDTC.SubmitChanges()
        End If
    End Sub

    Private Sub GRD_Ficheros_M_ToolGrid_ToolEliminar(ByRef sender As UltraWinToolbars.UltraToolbarsManager, ByRef e As UltraWinToolbars.ToolClickEventArgs) Handles GRD_Ficheros.M_ToolGrid_ToolEliminar
        oLinqPersonal.Archivo = Nothing
        oDTC.SubmitChanges()
    End Sub

#End Region

#Region "Grid Archivos2"

    Private Sub CargarGid_Partes(ByVal pId As Integer)
        Try
            'Dim _Archivos_Partes As IEnumerable(Of Parte_Archivo) = From taula In oDTC.Parte_Archivo Where taula.Parte.ID_Personal = pId Order By taula.ID_Archivo Select taula
            With Me.GRD_Partes

                Dim DTS As New DataSet
                BD.CargarDataSet(DTS, "Select * From C_Parte_Archivo Where ID_Personal = " & pId & " Order by ID_Archivo")

                .M.clsUltraGrid.Cargar(DTS)
                .GRID.ActiveRow = Nothing


                If .GRID.Selected.Rows.Count > 0 Then
                    Util.TabPintarHeaderTab(Me.Tab_Principal.Tabs("AusenciasFicheros"), System.Drawing.Color.Cyan)
                End If

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_Partes_M_ToolGrid_ToolVisualitzarDobleClickRow() Handles GRD_Partes.M_ToolGrid_ToolVisualitzarDobleClickRow
        If Me.GRD_Partes.GRID.Selected.Rows.Count <> 1 Then
            Exit Sub
        End If

        Fichero3.Ejecutar_Aplicacion(System.IO.Path.GetTempPath.ToString(), Me.GRD_Partes.GRID.Selected.Rows(0).Cells("ID_Archivo").Value)



    End Sub

#End Region

End Class