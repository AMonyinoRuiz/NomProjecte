Imports Infragistics.Win
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet
Imports System.Globalization


Public Class frmLlistatGPDR

    Dim _DTC As New DTCDataContext(BD.Conexion)
    Dim _Missatge_contador As Integer
    Dim _NumRegistroParaTabla As Integer = 0
    Dim _AdrecaPlanta As String
    Dim _LocalitatPlanta As String
    Dim _Tel As String
    Dim _Email As String

#Region "M_ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada()
        Me.AplicarDisseny()

        Util.Cargar_Combo(Me.C_Año, "SELECT ID_Año, Descripcion FROM Año where ID_Año > 1 ORDER BY ID_Año asc", True) 'fem el where per k no surti el 2017 al combo

        Call CargaGrid()

    End Sub

    Private Sub Validar_Click(sender As Object, e As EventArgs) Handles Validar.Click
        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Call CargaGrid()
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                'oClsControls.ControlBuit(.TE_Codigo)
                oClsControls.ControlBuit(.C_Año)
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function


#End Region

#Region "Grid"

    Private Sub CargaGrid()

        If Me.C_Año.Value > 0 Then
            Me.GRD_proveedores.M.clsUltraGrid.Cargar("select CodigoProveedor, RazonSocial, MAX(FechaAlbaran) as FechaUltimaCompra, GDPR from C_LCLARIANA_LineasAlbaranCompra_2 where CodigoProveedor like '40%' and year(FechaAlbaran) = " & Me.C_Año.Text & " group by CodigoProveedor, RazonSocial, GDPR order by RazonSocial", BD)
            Me.T_P_Pendientes.Value = BD.RetornaValorSQL("select count(*) from (select CodigoProveedor, RazonSocial, MAX(FechaAlbaran) as FechaUltimaCompra, GDPR from C_LCLARIANA_LineasAlbaranCompra_2 where CodigoProveedor like '40%' and year(FechaAlbaran) = " & Me.C_Año.Text & " group by CodigoProveedor, RazonSocial, GDPR) as tabla where GDPR is null")
            Me.T_P_Respondidas.Value = BD.RetornaValorSQL("select count(*) from (select CodigoProveedor, RazonSocial, MAX(FechaAlbaran) as FechaUltimaCompra, GDPR from C_LCLARIANA_LineasAlbaranCompra_2 where CodigoProveedor like '40%' and year(FechaAlbaran) = " & Me.C_Año.Text & " group by CodigoProveedor, RazonSocial, GDPR) as tabla where GDPR is not null")
            Me.T_P_Porcentaje.Value = Me.T_P_Respondidas.Value / Me.T_P_Pendientes.Value * 100

            Me.GRD_clientes.M.clsUltraGrid.Cargar("select CodigoCliente, RazonSocial, MAX(FechaAlbaran) as FechaUltimaCompra, GDPR from C_LCLARIANA_LineasAlbaranVenta_2 where year(FechaAlbaran) = " & Me.C_Año.Text & " group by CodigoCliente, RazonSocial, GDPR order by RazonSocial", BD)
            Me.T_C_Pendientes.Value = BD.RetornaValorSQL("select count(*) from (select CodigoCliente, RazonSocial, MAX(FechaAlbaran) as FechaUltimaCompra, GDPR from C_LCLARIANA_LineasAlbaranVenta_2 where year(FechaAlbaran) = " & Me.C_Año.Text & " group by CodigoCliente, RazonSocial, GDPR) as tabla where GDPR is null")
            Me.T_C_Respondidas.Value = BD.RetornaValorSQL("select count(*) from (select CodigoCliente, RazonSocial, MAX(FechaAlbaran) as FechaUltimaCompra, GDPR from C_LCLARIANA_LineasAlbaranVenta_2 where year(FechaAlbaran) = " & Me.C_Año.Text & " group by CodigoCliente, RazonSocial, GDPR) as tabla where GDPR is not null")
            Me.T_C_Porcentaje.Value = Me.T_C_Respondidas.Value / Me.T_C_Pendientes.Value * 100

            Me.GRD_Acreedores.M.clsUltraGrid.Cargar("select CodigoCuentaFactura, RazonSocial, MAX(FechaFactura) as FechaUltimaCompra, GDPR from C_LCCLARIANA_Acreedores where CodigoCuentaFactura like '41%' and year(FechaFactura) = " & Me.C_Año.Text & " group by CodigoCuentaFactura, RazonSocial, GDPR order by RazonSocial", BD)
            Me.T_A_Pendientes.Value = BD.RetornaValorSQL("select count(*) from (select CodigoCuentaFactura, RazonSocial, MAX(FechaFactura) as FechaUltimaCompra, GDPR from C_LCCLARIANA_Acreedores where CodigoCuentaFactura like '41%' and year(FechaFactura) = " & Me.C_Año.Text & " group by CodigoCuentaFactura, RazonSocial, GDPR) as tabla where GDPR is null")
            Me.T_A_respondidas.Value = BD.RetornaValorSQL("select count(*) from (select CodigoCuentaFactura, RazonSocial, MAX(FechaFactura) as FechaUltimaCompra, GDPR from C_LCCLARIANA_Acreedores where CodigoCuentaFactura like '41%' and year(FechaFactura) = " & Me.C_Año.Text & " group by CodigoCuentaFactura, RazonSocial, GDPR) as tabla where GDPR is not null")
            Me.T_A_Porcentaje.Value = Me.T_A_respondidas.Value / Me.T_A_Pendientes.Value * 100

        End If


        For Each _Row In Me.GRD_proveedores.GRID.Rows
            If _Row.Cells("GDPR").Value.Equals("SI") Then
                _Row.Appearance.BackColor = Color.LightGreen
            End If
            If _Row.Cells("GDPR").Value.Equals("NO") Then
                _Row.Appearance.BackColor = Color.LightCoral
            End If
        Next

        For Each _Row In Me.GRD_clientes.GRID.Rows
            If _Row.Cells("GDPR").Value.Equals("SI") Then
                _Row.Appearance.BackColor = Color.LightGreen
            End If
            If _Row.Cells("GDPR").Value.Equals("NO") Then
                _Row.Appearance.BackColor = Color.LightCoral
            End If
        Next

        For Each _Row In Me.GRD_Acreedores.GRID.Rows
            If _Row.Cells("GDPR").Value.Equals("SI") Then
                _Row.Appearance.BackColor = Color.LightGreen
            End If
            If _Row.Cells("GDPR").Value.Equals("NO") Then
                _Row.Appearance.BackColor = Color.LightCoral
            End If
        Next
    End Sub

#End Region

End Class