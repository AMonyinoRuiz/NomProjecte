Imports Infragistics.Win


Public Class frmLlistatPartes
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

        Me.GRD.M.clsToolBar.Boto_Afegir("AcceptarPartes", "Aprobar todos los partes", True)

        Me.DT_Inicio.Value = New Date(Now.Year, Now.Month, 1)
        Me.DT_Fin.Value = Now

        If Seguretat.oUser.CampoAux3 <> EnumRRHH.Si Then
            Me.C_Planta.ReadOnly = True
            Me.C_Planta.Value = Seguretat.oUser.CampoAux1
        Else
            Me.C_Planta.Value = 0
        End If

        Call BuscarLlistat()


    End Sub

    Private Sub BuscarLlistat()
        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Dim _DT As New DataTable 'CReeem les columnes

        _DT.Columns.Add("ID_Parte", GetType(Integer))
        _DT.Columns.Add("ID_Usuario", GetType(Integer))
        _DT.Columns.Add("ID_Personal", GetType(Integer))
        _DT.Columns.Add("ID_AusenciaTipo", GetType(Integer))
        _DT.Columns.Add("ID_ParteEstado", GetType(Integer))
        _DT.Columns.Add("ID_Planta", GetType(Integer))
        _DT.Columns.Add("FechaAlta", GetType(Date))
        _DT.Columns.Add("FechaInicio", GetType(Date))
        _DT.Columns.Add("FechaFin", GetType(Date))
        _DT.Columns.Add("HorasAusencia", GetType(Integer))
        _DT.Columns.Add("AusenciaTipo", GetType(String))
        _DT.Columns.Add("Personal", GetType(String))
        _DT.Columns.Add("ParteEstado", GetType(String))
        _DT.Columns.Add("Usuario", GetType(String))

        Dim _ValorsGrid As DataTable
        If Me.OP.Value = "alta" Then
            If Me.C_Planta.Value = 0 Then
                _ValorsGrid = BD.RetornaDataTable("Select * From C_Partes where FechaAlta BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' order by FechaAlta")
            Else
                _ValorsGrid = BD.RetornaDataTable("Select * From C_Partes where FechaAlta BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' and ID_Planta = " & Me.C_Planta.Value & " order by FechaAlta")
            End If
        Else
            If Me.C_Planta.Value = 0 Then
                _ValorsGrid = BD.RetornaDataTable("Select * From C_Partes where FechaInicio BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' order by FechaAlta")
            Else
                _ValorsGrid = BD.RetornaDataTable("Select * From C_Partes where FechaInicio BETWEEN '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' and ID_Planta = " & Me.C_Planta.Value & " order by FechaAlta")
            End If

        End If

        Me.GRD.M.clsUltraGrid.Cargar(_ValorsGrid)

        For Each _pRow In Me.GRD.GRID.Rows
            Select Case _pRow.Cells("ID_ParteEstado").Value
                Case CInt(EnumEstatsPartes.Aceptado)
                    _pRow.Appearance.BackColor = Color.LightGreen
                Case CInt(EnumEstatsPartes.Denegado)
                    _pRow.Appearance.BackColor = Color.LightCoral
                Case CInt(EnumEstatsPartes.Pendiente)
                    _pRow.Appearance.BackColor = Color.LightYellow
            End Select
        Next

        If Seguretat.oUser.CampoAux3 <> EnumRRHH.Si Then 'Si no ets de RRHH no pots esborrar cap parte
            Me.GRD.ToolGrid.Tools("Eliminar").SharedProps.Enabled = False
            Me.GRD.ToolGrid.Tools("AcceptarPartes").SharedProps.Visible = False
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

#Region "Grid"
    Private Sub GRD_M_ToolGrid_ToolEditar(ByRef sender As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager, ByRef e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles GRD.M_ToolGrid_ToolEditar
        Call GRD_M_ToolGrid_ToolVisualitzarDobleClickRow()
    End Sub

    Private Sub GRD_M_ToolGrid_ToolVisualitzarDobleClickRow() Handles GRD.M_ToolGrid_ToolVisualitzarDobleClickRow
        If Me.GRD.GRID.Selected.Rows.Count <> 1 Then
            Exit Sub
        End If

        Dim frm As New frmParte
        frm.Entrada(Me.GRD.GRID.Selected.Rows(0).Cells("ID_Parte").Value)
        AddHandler frm.FormClosing, AddressOf AlTancarFrm
        frm.FormObrir(Me, True)
    End Sub

    Private Sub GRD_M_ToolGrid_ToolAfegir(ByRef sender As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager, ByRef e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles GRD.M_ToolGrid_ToolAfegir
        Try
            Dim frm As New frmParte
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

                Dim _Parte As Parte = _DTC.Parte.Where(Function(F) F.ID_Parte = CInt(pRow.Cells("ID_Parte").Value)).FirstOrDefault
                _DTC.Parte_Archivo.DeleteAllOnSubmit(_Parte.Parte_Archivo)
                _DTC.Personal_Ausencia.DeleteAllOnSubmit(_Parte.Personal_Ausencia)
                _DTC.Parte.DeleteOnSubmit(_Parte)
                _DTC.SubmitChanges()

                Call BuscarLlistat()

                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE)
                'pRow.Hidden = True
            End If

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub AlTancarFrm()
        'If Seguretat.oUser.CampoAux3 <> EnumRRHH.Si Then
        Call BuscarLlistat()
        'End If
    End Sub

    Private Sub GRD_M_ToolGrid_ToolClickBotonsExtras2(ByRef sender As UltraWinToolbars.UltraToolbarsManager, ByRef e As UltraWinToolbars.ToolClickEventArgs, ByRef pGrid As M_UltraGrid.m_UltraGrid) Handles GRD.M_ToolGrid_ToolClickBotonsExtras2
        Select Case e.Tool.Key
            Case "AcceptarPartes"

                Dim _PartesPerPlanta As DataTable
                If Me.C_Planta.Value = 0 Then
                    _PartesPerPlanta = BD.RetornaDataTable("select ID_Parte from Parte where Id_ParteEstado = 1")
                Else
                    _PartesPerPlanta = BD.RetornaDataTable("select ID_Parte from Parte where Id_ParteEstado = 1 and ID_Planta = " & Me.C_Planta.Value)
                End If

                If IsNothing(_PartesPerPlanta) = False Then
                    If _PartesPerPlanta.Rows.Count > 0 Then
                        Dim _Row As DataRow
                        For Each _Row In _PartesPerPlanta.Rows

                            Dim _Parte As Parte
                            _Parte = _DTC.Parte.Where(Function(F) F.ID_Parte = CInt(_Row.Item("ID_Parte"))).FirstOrDefault
                            _Parte.ParteEstado = _DTC.ParteEstado.Where(Function(F) F.ID_ParteEstado = EnumEstatsPartes.Aceptado).FirstOrDefault
                            _DTC.SubmitChanges()

                            If _Parte.AusenciaTipo.Conta_Festius = False Then
                                Dim _DataIniciTemp As Date = _Parte.FechaInicio
                                While _DataIniciTemp <= _Parte.FechaFin
                                    Dim _AusenciaFestiva As Integer = _DTC.DiaFiesta.Where(Function(F) F.Data = _DataIniciTemp).Count
                                    If _AusenciaFestiva = 0 And Weekday(_DataIniciTemp, FirstDayOfWeek.Monday) <> 6 And Weekday(_DataIniciTemp, FirstDayOfWeek.Monday) <> 7 Then
                                        Dim _Absencia As New Personal_Ausencia
                                        _Absencia.Personal = _DTC.Personal.Where(Function(F) F.ID_Personal = CInt(_Parte.ID_Personal)).FirstOrDefault
                                        _Absencia.AusenciaTipo = _DTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(_Parte.ID_AusenciaTipo)).FirstOrDefault
                                        _Absencia.Parte = _Parte
                                        _Absencia.Fecha = _DataIniciTemp
                                        _Absencia.Observaciones = _Parte.Observaciones
                                        If IsDBNull(_Parte.HorasAusencia) = False Then
                                            _Absencia.NumHores = _Parte.HorasAusencia
                                        End If
                                        _DTC.Personal_Ausencia.InsertOnSubmit(_Absencia)
                                        _DTC.SubmitChanges()
                                    End If
                                    _DataIniciTemp = _DataIniciTemp.AddDays(1)
                                End While
                            Else
                                Dim _DataIniciTemp As Date = _Parte.FechaInicio
                                While _DataIniciTemp <= _Parte.FechaFin

                                    Dim _Absencia As New Personal_Ausencia
                                    _Absencia.Personal = _DTC.Personal.Where(Function(F) F.ID_Personal = CInt(_Parte.ID_Personal)).FirstOrDefault
                                    _Absencia.AusenciaTipo = _DTC.AusenciaTipo.Where(Function(F) F.ID_AusenciaTipo = CInt(_Parte.ID_AusenciaTipo)).FirstOrDefault
                                    _Absencia.Parte = _Parte
                                    _Absencia.Fecha = _DataIniciTemp
                                    _Absencia.Observaciones = _Parte.Observaciones
                                    If IsDBNull(_Parte.HorasAusencia) = False Then
                                        _Absencia.NumHores = _Parte.HorasAusencia
                                    End If
                                    _DTC.Personal_Ausencia.InsertOnSubmit(_Absencia)
                                    _DTC.SubmitChanges()

                                    _DataIniciTemp = _DataIniciTemp.AddDays(1)
                                End While
                            End If
                        Next
                    End If

                    Call BuscarLlistat()
                End If
        End Select
    End Sub
#End Region




End Class