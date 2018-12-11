Imports System.Reflection

Public Class frmLogTransacciones
    Dim oDTC As DTCDataContext

    Public Sub Entrada()
        Me.AplicarDisseny()

        oDTC = New DTCDataContext(BD.Conexion)

        Me.ToolForm.M.Botons.tSeleccionar.SharedProps.Visible = False
        Util.Cargar_Combo(Me.C_Tabla, "Select Tabla as Nom, Tabla From logTransacciones Group By Tabla Order by Tabla")
        Me.C_Tabla.SelectedIndex = 0

        Me.DT_Inicio.Value = Date.Now
        Me.DT_Fin.Value = Date.Now




        '        Util.Cargar_Combo(Me.C_Tabla, "Select Tabla From logTransacciones Where Tabla='" & Me.C_Tabla.Text & " and FechaTrn beetwen " & Me.DT_Inicio.Value & " and " & Me.DT_Fin.Value & " Order by FechaTrn")

        'Me.GRD.M.clsUltraGrid.Cargar("Select * From C_Listado_Parte Where Activo=1 Order by FechaAlta Desc", BD)
    End Sub

    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

    Private Sub B_Buscar_Click(sender As Object, e As EventArgs) Handles B_Buscar.Click
        Try
            Dim FechaInicio As Date
            Dim FechaFin As Date
            FechaInicio = Me.DT_Inicio.Value
            FechaInicio = CDate(FechaInicio.ToShortDateString).AddSeconds(1)

            FechaFin = Me.DT_Fin.Value
            FechaFin = CDate(FechaFin.ToShortDateString).AddDays(1)
            FechaFin = FechaFin.AddSeconds(-1)

            If Me.C_Tabla.SelectedIndex <> -1 AndAlso Me.DT_Inicio.Value Is Nothing = False And Me.DT_Fin.Value Is Nothing = False Then
                Util.WaitFormObrir()
                'Me.GRD.GRID.DataSource = BD.RetornaDataTable("Select * From logTransacciones Where Tabla='" & Me.C_Tabla.Text & "' and FechaTrn between '" & FechaInicio & "' and '" & FechaFin & "' Order by FechaTrn")
                Me.GRD.M.clsUltraGrid.Cargar(BD.RetornaDataTable("Select * From logTransacciones Where Tabla='" & Me.C_Tabla.Text & "' and FechaTrn between '" & FechaInicio & "' and '" & FechaFin & "' Order by FechaTrn"))
                Util.WaitFormTancar()
            End If
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        Try
            Dim FechaInicio As Date
            Dim FechaFin As Date
            FechaInicio = Me.DT_Inicio.Value
            FechaInicio = CDate(FechaInicio.ToShortDateString).AddSeconds(1)

            FechaFin = Me.DT_Fin.Value
            FechaFin = CDate(FechaInicio.ToShortDateString).AddDays(1)
            FechaFin = FechaFin.AddSeconds(-1)

            If Me.C_Tabla.SelectedIndex <> -1 AndAlso Me.DT_Inicio.Value Is Nothing = False And Me.DT_Fin.Value Is Nothing = False Then
                Me.GridControl1.DataSource = BD.RetornaDataTable("Select * From logTransacciones Where Tabla='" & Me.C_Tabla.Text & "' and FechaTrn between '" & FechaInicio & "' and '" & FechaFin & "' Order by FechaTrn")
            End If
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_Load(sender As Object, e As EventArgs) Handles GRD.Load

    End Sub
End Class