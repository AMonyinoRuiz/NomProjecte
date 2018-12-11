Imports Infragistics.Win
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet


Public Class frmLlistatPlusAssistencia

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

        Call CargaGrid()

    End Sub


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
                For i As Integer = 1 To Date.DaysInMonth(Me.C_Ano.Text, Me.C_Mes.Value)
                    If Weekday(New DateTime(Me.C_Ano.Text, Me.C_Mes.Value, i), FirstDayOfWeek.Monday) = 6 Or Weekday(New DateTime(Me.C_Ano.Text, Me.C_Mes.Value, i), FirstDayOfWeek.Monday) = 7 Then
                        _DiesCS = _DiesCS + 1
                    End If
                    _DiesTots = _DiesTots + 1
                Next

                BD.CargarDataSet(DTS, "SELECT dbo.Personal.ID_Personal, dbo.Personal.Nombre, COUNT(dbo.Personal_Ausencia.ID_Personal_Ausencia) AS Dies_Ausencia, (SELECT " & _DiesTots & " - (Select COUNT(*) from DiaFiesta Where MONTH(Data) = " & CInt(Me.C_Mes.Value) & " and YEAR(Data) = " & CInt(Me.C_Ano.Text) & ") - " & _DiesCS & ") As Dies_Laborals, (SELECT " & _DiesTots & " - (Select COUNT(*) from DiaFiesta Where MONTH(Data) = " & CInt(Me.C_Mes.Value) & " and YEAR(Data) = " & CInt(Me.C_Ano.Text) & ")) - COUNT(dbo.Personal_Ausencia.ID_Personal_Ausencia) - " & _DiesCS & " as Dias_laborals_A_Cobrar FROM dbo.Personal INNER JOIN dbo.Personal_Ausencia ON dbo.Personal.ID_Personal = dbo.Personal_Ausencia.ID_Personal INNER JOIN dbo.AusenciaTipo ON dbo.Personal_Ausencia.ID_AusenciaTipo = dbo.AusenciaTipo.ID_AusenciaTipo WHERE dbo.AusenciaTipo.ComptaPerHores = 0 and (MONTH(dbo.Personal_Ausencia.Fecha) = " & CInt(Me.C_Mes.Value) & ") and YEAR(dbo.Personal_Ausencia.Fecha) = " & CInt(Me.C_Ano.Text) & " GROUP BY dbo.Personal.ID_Personal, dbo.Personal.Nombre")
                BD.CargarDataSet(DTS, "SELECT dbo.Personal.ID_Personal, dbo.Personal_Ausencia.Fecha, dbo.AusenciaTipo.Descripcion FROM dbo.Personal INNER JOIN dbo.Personal_Ausencia ON dbo.Personal.ID_Personal = dbo.Personal_Ausencia.ID_Personal INNER JOIN dbo.AusenciaTipo ON dbo.Personal_Ausencia.ID_AusenciaTipo = dbo.AusenciaTipo.ID_AusenciaTipo WHERE dbo.AusenciaTipo.ComptaPerHores = 0 and (MONTH(dbo.Personal_Ausencia.Fecha) = " & CInt(Me.C_Mes.Value) & ") and YEAR(dbo.Personal_Ausencia.Fecha) = " & CInt(Me.C_Ano.Text), "NombreRelacionQueMeDaIgual", 0, "ID_Personal", "ID_Personal", False)

                .M.clsUltraGrid.Cargar(DTS)

                .GRID.ActiveRow = Nothing

            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

#End Region

End Class