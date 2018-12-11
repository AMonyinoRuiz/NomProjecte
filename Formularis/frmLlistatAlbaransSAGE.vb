Imports Infragistics.Win
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet


Public Class frmLlistatAlbaransSAGE

    Dim _DTC As New DTCDataContext(BD.Conexion)
    Dim _Missatge_contador As Integer

#Region "M_ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

    Private Sub ToolForm_m_ToolForm_Imprimir() Handles ToolForm.m_ToolForm_Imprimir

        If Me.GRD.GRID.Selected.Rows.Count = 1 Then

            _DTC.Temp_AlbaranesSAGE.DeleteAllOnSubmit(_DTC.Temp_AlbaranesSAGE)
            _DTC.SubmitChanges()


            Dim _NumAlbaran As Integer = Me.GRD.GRID.Selected.Rows(0).Cells("NumeroAlbaran").Value
            Dim _DT As DataTable = BD.RetornaDataTable("Select * from C_LCClariana_LlistatAlbaransSAGE where NumeroAlbaran = " & _NumAlbaran & " and FechaAlbaran between '" & Me.DT_FechaInicio.Value & "' and '" & Me.DT_fechaFin.Value & "'")
            Dim _Row As DataRow
            For Each _Row In _DT.Rows
                Dim _AlbaranSAGE As New Temp_AlbaranesSAGE
                _AlbaranSAGE.NumeroAlbaran = _Row.Item("NumeroAlbaran")
                _AlbaranSAGE.FechaAlbaran = _Row.Item("FechaAlbaran")
                _AlbaranSAGE.RazonSocial = _Row.Item("RazonSocial")
                _AlbaranSAGE.Domicilio = _Row.Item("Domicilio")
                _AlbaranSAGE.Municipio = _Row.Item("Municipio")
                _AlbaranSAGE.Provincia = _Row.Item("Provincia")
                _AlbaranSAGE.CifEuropeo = _Row.Item("CifEuropeo")
                _AlbaranSAGE.Nacion = _Row.Item("Nacion")
                _AlbaranSAGE.Unidades = CInt(_Row.Item("Unidades"))
                _AlbaranSAGE.DescripcionArticulo = _Row.Item("DescripcionArticulo")
                _DTC.Temp_AlbaranesSAGE.InsertOnSubmit(_AlbaranSAGE)
                _DTC.SubmitChanges()
            Next
        Else
            Mensaje.Mostrar_Mensaje("Selecciona una fila para poder imprimir", M_Mensaje.Missatge_Modo.ERRORS, , , True)
        End If


        Dim DTC As New DTCDataContext(BD.Conexion)
        Informes.ObrirInformePreparacio(DTC, 7, "", "Listado albaranes SAGE - " & Me.DT_FechaInicio.Value, , , , , , False)
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada()
        Me.AplicarDisseny()

        Util.Cargar_Combo(Me.C_Planta, "SELECT ID_Planta, Descripcion FROM Planta Where Activo=1 and ID_Planta <> 10 ORDER BY Descripcion", True, True, "Todos")

        If IsNothing(Seguretat.oUser.CampoAux1) = False And IsDBNull(Seguretat.oUser.CampoAux1) = False Then
            Me.C_Planta.Value = Seguretat.oUser.CampoAux1
            If Seguretat.oUser.CampoAux1 = 1 Then
                Me.C_Planta.ReadOnly = False
            Else
                Me.C_Planta.ReadOnly = True
            End If
        End If

        

        Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = True

        Me.DT_FechaInicio.Value = Now.Date.AddDays(-1)
        Me.DT_fechaFin.Value = Now.Date

        Call CargaGrid()

    End Sub

#End Region

#Region "Grid"
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click

        If IsNothing(Me.DT_FechaInicio.Value) = True Or IsNothing(Me.DT_fechaFin.Value) = True Then
            Mensaje.Mostrar_Mensaje("Tienes que especificar el rango de días que quieres consultar", M_Mensaje.Missatge_Modo.ERRORS, , , True)
            Exit Sub
        End If

        If IsNothing(Me.C_Planta.Value) = True Then
            Mensaje.Mostrar_Mensaje("Tienes que especificar una planta en el campo correspondiente", M_Mensaje.Missatge_Modo.ERRORS, , , True)
            Exit Sub
        End If

        Call CargaGrid()
    End Sub

    Private Sub CargaGrid()
        Try
            With Me.GRD
                If Me.C_Planta.Value = 0 Then
                    .M.clsUltraGrid.Cargar("Select NumeroAlbaran, SerieAlbaran, FechaAlbaran, (Select top 1 Descripcion From Planta where Iniciales_LCLARIANA = Planta) as NomPlanta, RazonSocial, Domicilio, Municipio, Provincia, CifEuropeo, Nacion from C_LCClariana_LlistatAlbaransSAGE_Compras where FechaAlbaran between '" & Me.DT_FechaInicio.Value & "' and '" & Me.DT_fechaFin.Value & "' group by NumeroAlbaran, Planta, SerieAlbaran, FechaAlbaran, RazonSocial, Domicilio, Municipio, Provincia, CifEuropeo, Nacion", BD)
                Else
                    Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA
                    .M.clsUltraGrid.Cargar("Select NumeroAlbaran, SerieAlbaran, FechaAlbaran, RazonSocial, Domicilio, Municipio, Provincia, CifEuropeo, Nacion from C_LCClariana_LlistatAlbaransSAGE_Compras where Planta = '" & _Planta & "' and FechaAlbaran between '" & Me.DT_FechaInicio.Value & "' and '" & Me.DT_fechaFin.Value & "' group by NumeroAlbaran, SerieAlbaran, FechaAlbaran, RazonSocial, Domicilio, Municipio, Provincia, CifEuropeo, Nacion", BD)
                End If

                .GRID.ActiveRow = Nothing
            End With

            With Me.GRD_Clientes
                If Me.C_Planta.Value = 0 Then
                    .M.clsUltraGrid.Cargar("Select NumeroAlbaran, SerieAlbaran, FechaAlbaran, (Select top 1 Descripcion From Planta where Iniciales_LCLARIANA = Planta) as NomPlanta, RazonSocial, Domicilio, Municipio, Provincia, CifEuropeo, Nacion from C_LCClariana_LlistatAlbaransSAGE_Ventas where FechaAlbaran between '" & Me.DT_FechaInicio.Value & "' and '" & Me.DT_fechaFin.Value & "' group by NumeroAlbaran, Planta, SerieAlbaran, FechaAlbaran, RazonSocial, Domicilio, Municipio, Provincia, CifEuropeo, Nacion", BD)
                Else
                    Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA
                    .M.clsUltraGrid.Cargar("Select NumeroAlbaran, SerieAlbaran, FechaAlbaran, RazonSocial, Domicilio, Municipio, Provincia, CifEuropeo, Nacion from C_LCClariana_LlistatAlbaransSAGE_Ventas where Planta = '" & _Planta & "' and FechaAlbaran between '" & Me.DT_FechaInicio.Value & "' and '" & Me.DT_fechaFin.Value & "' group by NumeroAlbaran, SerieAlbaran, FechaAlbaran, RazonSocial, Domicilio, Municipio, Provincia, CifEuropeo, Nacion", BD)
                End If

                .GRID.ActiveRow = Nothing
            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

#End Region

End Class