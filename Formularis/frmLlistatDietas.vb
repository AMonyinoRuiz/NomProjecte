Imports Infragistics.Win
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet


Public Class frmLlistatDietas

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

        Util.Cargar_Combo(Me.C_Ano, "SELECT ID_Año, Descripcion FROM Año ORDER BY ID_Año", True, , False)
        Util.Cargar_Combo(Me.C_Mes, "SELECT ID_Mes, Descripcion FROM Mes ORDER BY ID_Mes", True, , False)

        Me.C_Mes.Value = Now.Month
        Me.C_Ano.Text = Now.Year

        Me.DT_Inicio.Value = New Date(Now.Year, Now.Month, 1)
        Me.DT_Fin.Value = New Date(Now.Year, Now.Month, DateTime.DaysInMonth(Now.Year, Now.Month))


        Call CargaGrid()

    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                'oClsControls.ControlBuit(.TE_Codigo)
                oClsControls.ControlBuit(.C_Mes)
                oClsControls.ControlBuit(.C_Ano)
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

#End Region

#Region "Grid"
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Call CargaGrid()
    End Sub

    Private Sub CargaGrid()
        Try
            With Me.GRD

                Dim _DiesCS As Integer = 0
                Dim _DiesTots As Integer = 0

                Dim DTS As New DataSet
                If OP_Fecha.Value = "Meses" Then
                    For i As Integer = 1 To Date.DaysInMonth(Me.C_Ano.Text, Me.C_Mes.Value)
                        If Weekday(New DateTime(Me.C_Ano.Text, Me.C_Mes.Value, i), FirstDayOfWeek.Monday) = 6 Or Weekday(New DateTime(Me.C_Ano.Text, Me.C_Mes.Value, i), FirstDayOfWeek.Monday) = 7 Then
                            _DiesCS = _DiesCS + 1
                        End If
                        _DiesTots = _DiesTots + 1
                    Next

                    BD.CargarDataSet(DTS, "SELECT dbo.Personal.ID_Personal, dbo.Personal.Nombre, COUNT(dbo.Personal_Ausencia.ID_Personal_Ausencia) AS Dies_Ausencia, (SELECT " & _DiesTots & " - (Select COUNT(*) from DiaFiesta Where MONTH(Data) = " & CInt(Me.C_Mes.Value) & " and YEAR(Data) = " & CInt(Me.C_Ano.Text) & ") - " & _DiesCS & ") As Dies_Laborals, (SELECT " & _DiesTots & " - (Select COUNT(*) from DiaFiesta Where MONTH(Data) = " & CInt(Me.C_Mes.Value) & " and YEAR(Data) = " & CInt(Me.C_Ano.Text) & ")) - COUNT(dbo.Personal_Ausencia.ID_Personal_Ausencia) - " & _DiesCS & " as Dias_laborals_ausencias FROM dbo.Personal INNER JOIN dbo.Personal_Ausencia ON dbo.Personal.ID_Personal = dbo.Personal_Ausencia.ID_Personal INNER JOIN dbo.AusenciaTipo ON dbo.Personal_Ausencia.ID_AusenciaTipo = dbo.AusenciaTipo.ID_AusenciaTipo WHERE ((dbo.AusenciaTipo.ComptaPerHores = 0) or ((dbo.AusenciaTipo.ComptaPerHores = 1) and ((dbo.Personal_Ausencia.NumHores) >= 6))) AND (MONTH(dbo.Personal_Ausencia.Fecha) = " & CInt(Me.C_Mes.Value) & ") and YEAR(dbo.Personal_Ausencia.Fecha) = " & CInt(Me.C_Ano.Text) & " AND (dbo.Personal.ControlDietas = 1) GROUP BY dbo.Personal.ID_Personal, dbo.Personal.Nombre")
                    BD.CargarDataSet(DTS, "SELECT dbo.Personal.ID_Personal, dbo.Personal_Ausencia.Fecha, dbo.AusenciaTipo.Descripcion FROM dbo.Personal INNER JOIN dbo.Personal_Ausencia ON dbo.Personal.ID_Personal = dbo.Personal_Ausencia.ID_Personal INNER JOIN dbo.AusenciaTipo ON dbo.Personal_Ausencia.ID_AusenciaTipo = dbo.AusenciaTipo.ID_AusenciaTipo WHERE ((dbo.AusenciaTipo.ComptaPerHores = 0) or ((dbo.AusenciaTipo.ComptaPerHores = 1) and ((dbo.Personal_Ausencia.NumHores) >= 6))) AND (MONTH(dbo.Personal_Ausencia.Fecha) = " & CInt(Me.C_Mes.Value) & ") and YEAR(dbo.Personal_Ausencia.Fecha) = " & CInt(Me.C_Ano.Text) & " AND (dbo.Personal.ControlDietas = 1)", "NombreRelacionQueMeDaIgual", 0, "ID_Personal", "ID_Personal", False)
                End If



                If OP_Fecha.Value = "fecha" Then

                    Dim WContador_Fecha As Date = Me.DT_Inicio.Value
                    While WContador_Fecha <= Me.DT_Fin.Value
                        If Weekday(WContador_Fecha, FirstDayOfWeek.Monday) = 6 Or Weekday(WContador_Fecha, FirstDayOfWeek.Monday) = 7 Then
                            _DiesCS = _DiesCS + 1
                        End If
                        _DiesTots = _DiesTots + 1
                        WContador_Fecha = WContador_Fecha.AddDays(1)
                    End While

                    BD.CargarDataSet(DTS, "SELECT dbo.Personal.ID_Personal, dbo.Personal.Nombre, COUNT(dbo.Personal_Ausencia.ID_Personal_Ausencia) AS Dies_Ausencia, (" & _DiesTots & " - (Select COUNT(*) from DiaFiesta Where Data < '" & Me.DT_Fin.Value & "' and Data > '" & Me.DT_Inicio.Value & "') - " & _DiesCS & ") As Dies_Laborals, (SELECT " & _DiesTots & " - (Select COUNT(*) from DiaFiesta Where Data < '" & Me.DT_Fin.Value & "' and Data > '" & Me.DT_Inicio.Value & "')) - COUNT(dbo.Personal_Ausencia.ID_Personal_Ausencia) - " & _DiesCS & " as Dias_laborals_ausencias FROM dbo.Personal INNER JOIN dbo.Personal_Ausencia ON dbo.Personal.ID_Personal = dbo.Personal_Ausencia.ID_Personal INNER JOIN dbo.AusenciaTipo ON dbo.Personal_Ausencia.ID_AusenciaTipo = dbo.AusenciaTipo.ID_AusenciaTipo WHERE ((dbo.AusenciaTipo.ComptaPerHores = 0) or ((dbo.AusenciaTipo.ComptaPerHores = 1) and ((dbo.Personal_Ausencia.NumHores) >= 6))) AND (dbo.Personal_Ausencia.Fecha < '" & Me.DT_Fin.Value & "') and (dbo.Personal_Ausencia.Fecha > '" & Me.DT_Inicio.Value & "') AND (dbo.Personal.ControlDietas = 1) GROUP BY dbo.Personal.ID_Personal, dbo.Personal.Nombre")
                    BD.CargarDataSet(DTS, "SELECT dbo.Personal.ID_Personal, dbo.Personal_Ausencia.Fecha, dbo.AusenciaTipo.Descripcion FROM dbo.Personal INNER JOIN dbo.Personal_Ausencia ON dbo.Personal.ID_Personal = dbo.Personal_Ausencia.ID_Personal INNER JOIN dbo.AusenciaTipo ON dbo.Personal_Ausencia.ID_AusenciaTipo = dbo.AusenciaTipo.ID_AusenciaTipo WHERE ((dbo.AusenciaTipo.ComptaPerHores = 0) or ((dbo.AusenciaTipo.ComptaPerHores = 1) and ((dbo.Personal_Ausencia.NumHores) >= 6))) AND (dbo.Personal_Ausencia.Fecha < '" & Me.DT_Fin.Value & "') and (dbo.Personal_Ausencia.Fecha > '" & Me.DT_Inicio.Value & "') AND (dbo.Personal.ControlDietas = 1)", "NombreRelacionQueMeDaIgual", 0, "ID_Personal", "ID_Personal", False)
                End If


                .M.clsUltraGrid.Cargar(DTS)

                .GRID.ActiveRow = Nothing

            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

#End Region

    Private Sub OP_Fecha_ValueChanged(sender As Object, e As EventArgs) Handles OP_Fecha.ValueChanged
        If OP_Fecha.Value = "Meses" Then
            Me.UltraLabel6.Visible = True
            Me.UltraLabel1.Visible = True
            Me.C_Ano.Visible = True
            Me.C_Mes.Visible = True

            Me.UltraLabel10.Visible = False
            Me.UltraLabel3.Visible = False
            Me.DT_Fin.Visible = False
            Me.DT_Inicio.Visible = False
        End If

        If OP_Fecha.Value = "fecha" Then
            Me.UltraLabel6.Visible = False
            Me.UltraLabel1.Visible = False
            Me.C_Ano.Visible = False
            Me.C_Mes.Visible = False

            Me.UltraLabel10.Visible = True
            Me.UltraLabel3.Visible = True
            Me.DT_Fin.Visible = True
            Me.DT_Inicio.Visible = True
        End If
    End Sub
End Class