Imports Infragistics.Win
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet


Public Class frmLlistatHacienda

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

        Util.Cargar_Combo(Me.C_Mes, "SELECT ID_Mes, Descripcion FROM Mes ORDER BY ID_Mes", True)
        Me.C_Mes.Value = 10

        If IsNumeric(Me.C_Mes.Value) = True Then

            Call CargaGrid()
            Call CargaGrid2()
            Call CargaGrid3()
            Call CargaGrid4()

        End If

    End Sub

#End Region

#Region "Grid"
    Private Sub CargaGrid()
        Try
            With Me.GRD

                Dim DTS As New DataSet
                BD.CargarDataSet(DTS, "Select ID_RevisionIvaHacienda, NumFactura, 'ES' + NifEmisor as NifEmisor, Nombre, CuotaDeducible, TipoImpositivo, BaseImponible, CuotaSoportada, FechaExpedicion, ImporteTotal, FechaOperacion, DescripcionOperacion, (SELECT COUNT(*) FROM RevisionIvaSage where ID_Mes = " & Me.C_Mes.Value & " and RevisionIvaSage.CifEuropeo = 'ES' + RevisionIvaHacienda.NifEmisor and RevisionIvaSage.CuotaIva = RevisionIvaHacienda.CuotaDeducible and RevisionIvaSage.FechaFactura = RevisionIvaHacienda.FechaExpedicion) as Sage from RevisionIvaHacienda where ID_Mes = " & Me.C_Mes.Value & " order by Sage")
                
                Dim dtTemp As DataTable = BD.RetornaDataTable("Select * from RevisionIvaSage where ID_Mes = " & Me.C_Mes.Value, True)
                dtTemp.TableName = "pepe"
                DTS.Tables.Add(dtTemp)

                Dim parentColumns As DataColumn() = {DTS.Tables(0).Columns("NifEmisor"), DTS.Tables(0).Columns("CuotaDeducible"), DTS.Tables(0).Columns("FechaExpedicion")}
                Dim ChildColumns As DataColumn() = {dtTemp.Columns("CifEuropeo"), dtTemp.Columns("CuotaIva"), dtTemp.Columns("FechaFactura")}

                Dim drRelacion1 As New DataRelation("NombreRelacionQueMeDaIgual1", parentColumns, ChildColumns, False) '
           
                DTS.Relations.Add(drRelacion1)
                .M.clsUltraGrid.Cargar(DTS)

                .GRID.ActiveRow = Nothing

            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub CargaGrid2()
        Try
            With Me.GRD2

                Dim DTS As New DataSet
                BD.CargarDataSet(DTS, "Select *, (SELECT COUNT(*) FROM RevisionIvaHacienda where RevisionIvaSage.CifEuropeo = 'ES' + RevisionIvaHacienda.NIFEmisor and RevisionIvaSage.CuotaIva = RevisionIvaHacienda.CuotaDeducible and RevisionIvaSage.FechaFactura = RevisionIvaHacienda.FechaExpedicion and ID_Mes = " & Me.C_Mes.Value & ") as Hacienda from RevisionIvaSage	where ID_Mes = " & Me.C_Mes.Value & " order by Hacienda")

                Dim dtTemp As DataTable = BD.RetornaDataTable("Select ID_RevisionIvaHacienda, NumFactura, 'ES' + NifEmisor as NifEmisor, Nombre, CuotaDeducible, TipoImpositivo, BaseImponible, CuotaSoportada, FechaExpedicion, ImporteTotal, FechaOperacion, DescripcionOperacion from RevisionIvaHacienda where ID_Mes = " & Me.C_Mes.Value, True)
                dtTemp.TableName = "pepa"
                DTS.Tables.Add(dtTemp)

                Dim parentColumns As DataColumn() = {DTS.Tables(0).Columns("CifEuropeo"), DTS.Tables(0).Columns("CuotaIva"), DTS.Tables(0).Columns("FechaFactura")}
                Dim ChildColumns As DataColumn() = {dtTemp.Columns("NifEmisor"), dtTemp.Columns("CuotaDeducible"), dtTemp.Columns("FechaExpedicion")}

                Dim drRelacion1 As New DataRelation("NombreRelacionQueMeDaIgual2", parentColumns, ChildColumns, False) '

                DTS.Relations.Add(drRelacion1)
                .M.clsUltraGrid.Cargar(DTS)

                .GRID.ActiveRow = Nothing

            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub CargaGrid3()
        Try
            With Me.GRD3

                Dim DTS As New DataSet
                BD.CargarDataSet(DTS, "Select 'ES' + NifEmisor as NifEmisor, Nombre, sum(BaseImponible) as BaseImponible,sum(CuotaDeducible) as CuotaDeducible, sum(ImporteTotal) as ImporteTotal, (Select SUM(CuotaIva) from RevisionIvaSage where RevisionIvaSage.CifEuropeo = 'ES' + RevisionIvaHacienda.NifEmisor) as CuotaIvaSage, sum(CuotaDeducible) - (Select SUM(CuotaIva) from RevisionIvaSage where RevisionIvaSage.CifEuropeo = 'ES' + RevisionIvaHacienda.NifEmisor and ID_Mes = " & Me.C_Mes.Value & ") as DiferenciaIVA from RevisionIvaHacienda where ID_Mes = " & Me.C_Mes.Value & " group by NifEmisor, Nombre order by Nombre")

                Dim dtTemp As DataTable = BD.RetornaDataTable("Select 'ES' + NifEmisor AS NifEmisor, Nombre,BaseImponible, CuotaDeducible, ImporteTotal from RevisionIvaHacienda where ID_Mes = " & Me.C_Mes.Value & " order by Nombre", True)
                dtTemp.TableName = "pepi"
                DTS.Tables.Add(dtTemp)

                Dim parentColumns As DataColumn() = {DTS.Tables(0).Columns("NifEmisor")}
                Dim ChildColumns As DataColumn() = {dtTemp.Columns("NifEmisor")}

                Dim drRelacion1 As New DataRelation("NombreRelacionQueMeDaIgual3", parentColumns, ChildColumns, False) '

                DTS.Relations.Add(drRelacion1)
                .M.clsUltraGrid.Cargar(DTS)

                .GRID.ActiveRow = Nothing

            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub CargaGrid4()
        Try
            With Me.GRD4

                Dim DTS As New DataSet
                BD.CargarDataSet(DTS, "Select CifEuropeo, Nombre, sum(BaseIva) as BaseIva, sum(CuotaIva) as CuotaIva, sum(ImporteFactura) as ImporteFacturam, (Select SUM(CuotaDeducible) from RevisionIvaHacienda where RevisionIvaSage.CifEuropeo = 'ES' + RevisionIvaHacienda.NIFEmisor) as CuotaIVAHacienda, sum(CuotaIva) - (Select SUM(CuotaDeducible) from RevisionIvaHacienda where RevisionIvaSage.CifEuropeo = 'ES' + RevisionIvaHacienda.NIFEmisor and ID_Mes = " & Me.C_Mes.Value & ") as DiferenciaIVA from RevisionIvaSage where ID_Mes = " & Me.C_Mes.Value & " group by CifEuropeo, Nombre order by Nombre")

                Dim dtTemp As DataTable = BD.RetornaDataTable("Select CifEuropeo, Nombre, BaseIva, CuotaIva, ImporteFactura from RevisionIvaSage where ID_Mes = " & Me.C_Mes.Value & " order by Nombre", True)
                dtTemp.TableName = "pepi"
                DTS.Tables.Add(dtTemp)

                Dim parentColumns As DataColumn() = {DTS.Tables(0).Columns("CifEuropeo")}
                Dim ChildColumns As DataColumn() = {dtTemp.Columns("CifEuropeo")}

                Dim drRelacion1 As New DataRelation("NombreRelacionQueMeDaIgual4", parentColumns, ChildColumns, False) '

                DTS.Relations.Add(drRelacion1)
                .M.clsUltraGrid.Cargar(DTS)

                .GRID.ActiveRow = Nothing

            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

#End Region

    Private Sub C_Mes_ValueChanged(sender As Object, e As EventArgs) Handles C_Mes.ValueChanged
        If IsNumeric(Me.C_Mes.Value) = True Then
            Call CargaGrid()
            Call CargaGrid2()
            Call CargaGrid3()
            Call CargaGrid4()
        End If
    End Sub
End Class