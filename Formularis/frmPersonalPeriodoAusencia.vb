Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinToolbars

Public Class frmPersonalPeriodoAusencia
    Implements IDisposable
    Dim oDTC As DTCDataContext
    Dim oLinqPersonal As Personal

#Region "M_ToolForm"

    Private Sub M_ToolForm1_m_ToolForm_Guardar() Handles ToolForm.m_ToolForm_Guardar
        Call Guardar()
    End Sub

    Private Sub M_ToolForm1_m_ToolForm_Sortir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada(ByRef pPersonal As Personal, ByRef pDTC As DTCDataContext, ByRef TipoAusencia As Integer)
        Try
            Me.AplicarDisseny()

            oDTC = pDTC
            oLinqPersonal = pPersonal

            If TipoAusencia = EnumTipoAusencia.Vacaciones Then
                Util.Cargar_Combo(Me.C_TipoAusencia, "SELECT ID_AusenciaTipo, Descripcion FROM AusenciaTipo where ID_AusenciaTipo = " & EnumTipoAusencia.Vacaciones & " ORDER BY ID_AusenciaTipo", False)
                Me.C_TipoAusencia.SelectedIndex = 1
                Me.T_Horas_Ausencia.Visible = False
                Me.UltraLabel31.Visible = False
            Else
                Util.Cargar_Combo(Me.C_TipoAusencia, "SELECT ID_AusenciaTipo, Descripcion FROM AusenciaTipo where ID_AusenciaTipo <> " & EnumTipoAusencia.Vacaciones & " ORDER BY ID_AusenciaTipo", False)
                Me.C_TipoAusencia.SelectedIndex = -1
            End If

            Call Netejar_Pantalla()

            Me.KeyPreview = False

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Try
            If ComprovacioCampsRequeritsError() = True Then
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
                Exit Function
            End If

            If Me.T_Horas_Ausencia.Value > 24 Then
                Mensaje.Mostrar_Mensaje("No se pueden introducir mas de 24 horas de ausencia por día", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                Exit Function
            End If

            If Me.DT_Inici.Value > Me.DT_Final.Value Then
                Mensaje.Mostrar_Mensaje("El día de inicio debe ser mayor que el dia de final", M_Mensaje.Missatge_Modo.ERRORS, , , True)
                Exit Function
            End If

            Dim _DataInici As Date = Me.DT_Inici.Value
            Dim _DataFi As Date = Me.DT_Final.Value

            Do Until _DataInici > _DataFi
                Dim _Ausencia As New Personal_Ausencia
                _Ausencia.Fecha = _DataInici
                _Ausencia.AusenciaTipo = oDTC.AusenciaTipo.Where(Function(f) f.ID_AusenciaTipo = CInt(Me.C_TipoAusencia.Value)).FirstOrDefault
                _Ausencia.NumHores = CDec(Me.T_Horas_Ausencia.Value)
                _Ausencia.Observaciones = Me.T_Obser.Text
                oLinqPersonal.Personal_Ausencia.Add(_Ausencia)

                _DataInici = _DataInici.AddDays(1)
            Loop

            oDTC.SubmitChanges()

            Me.FormTancar()

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Private Sub Netejar_Pantalla()

        Util.Blanquejar(Me, M_Util.Enum_Controles_Activacion.TODOS, True)

        Me.TE_Codigo.Value = Nothing
        Me.TE_Codigo.Tag = Nothing

        Me.DT_Inici.Value = Now
        Me.DT_Final.Value = Now


        ErrorProvider1.Clear()

    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()

                oClsControls.ControlBuit(.DT_Inici)
                oClsControls.ControlBuit(.DT_Final)
                oClsControls.ControlBuit(.C_TipoAusencia)

            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

#End Region

End Class