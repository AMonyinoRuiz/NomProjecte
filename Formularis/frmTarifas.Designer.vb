<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifas
    'Inherits System.Windows.Forms.Form
    Inherits M_GenericForm.frmBase
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim AllColumns1 As DevExpress.DataAccess.Sql.AllColumns = New DevExpress.DataAccess.Sql.AllColumns()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarifas))
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim CustomAxisLabel1 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel2 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel3 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel4 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel5 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel6 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel7 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel8 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel9 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel10 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel11 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim CustomAxisLabel12 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim ChartControlCommandGalleryItemGroup2DColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
        Dim CreateBarChartItem1 As DevExpress.XtraCharts.UI.CreateBarChartItem = New DevExpress.XtraCharts.UI.CreateBarChartItem()
        Dim CreateFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
        Dim CreateSideBySideFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
        Dim CreateSideBySideStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
        Dim CreateStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
        Dim ChartControlCommandGalleryItemGroup3DColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
        Dim CreateBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateBar3DChartItem = New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
        Dim CreateFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
        Dim CreateManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreateManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
        Dim CreateSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
        Dim CreateSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
        Dim CreateStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
        Dim ChartControlCommandGalleryItemGroupCylinderColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
        Dim CreateCylinderBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
        Dim CreateCylinderFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
        Dim CreateCylinderManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
        Dim CreateCylinderSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
        Dim CreateCylinderSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
        Dim CreateCylinderStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
        Dim ChartControlCommandGalleryItemGroupConeColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
        Dim CreateConeBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
        Dim CreateConeFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
        Dim CreateConeManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
        Dim CreateConeSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
        Dim CreateConeSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
        Dim CreateConeStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
        Dim ChartControlCommandGalleryItemGroupPyramidColumn1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
        Dim CreatePyramidBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
        Dim CreatePyramidFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
        Dim CreatePyramidManhattanBarChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem = New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
        Dim CreatePyramidSideBySideFullStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
        Dim CreatePyramidSideBySideStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
        Dim CreatePyramidStackedBar3DChartItem1 As DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem = New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
        Dim ChartControlCommandGalleryItemGroup2DLine1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
        Dim CreateLineChartItem1 As DevExpress.XtraCharts.UI.CreateLineChartItem = New DevExpress.XtraCharts.UI.CreateLineChartItem()
        Dim CreateFullStackedLineChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
        Dim CreateScatterLineChartItem1 As DevExpress.XtraCharts.UI.CreateScatterLineChartItem = New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
        Dim CreateSplineChartItem1 As DevExpress.XtraCharts.UI.CreateSplineChartItem = New DevExpress.XtraCharts.UI.CreateSplineChartItem()
        Dim CreateStackedLineChartItem1 As DevExpress.XtraCharts.UI.CreateStackedLineChartItem = New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
        Dim CreateStepLineChartItem1 As DevExpress.XtraCharts.UI.CreateStepLineChartItem = New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
        Dim ChartControlCommandGalleryItemGroup3DLine1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
        Dim CreateLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateLine3DChartItem = New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
        Dim CreateFullStackedLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
        Dim CreateSpline3DChartItem1 As DevExpress.XtraCharts.UI.CreateSpline3DChartItem = New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
        Dim CreateStackedLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
        Dim CreateStepLine3DChartItem1 As DevExpress.XtraCharts.UI.CreateStepLine3DChartItem = New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
        Dim ChartControlCommandGalleryItemGroup2DPie1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
        Dim CreatePieChartItem1 As DevExpress.XtraCharts.UI.CreatePieChartItem = New DevExpress.XtraCharts.UI.CreatePieChartItem()
        Dim CreateDoughnutChartItem1 As DevExpress.XtraCharts.UI.CreateDoughnutChartItem = New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
        Dim CreateNestedDoughnutChartItem1 As DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem = New DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem()
        Dim ChartControlCommandGalleryItemGroup3DPie1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
        Dim CreatePie3DChartItem1 As DevExpress.XtraCharts.UI.CreatePie3DChartItem = New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
        Dim CreateDoughnut3DChartItem1 As DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem = New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
        Dim ChartControlCommandGalleryItemGroup2DBar1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
        Dim CreateRotatedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
        Dim CreateRotatedFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
        Dim CreateRotatedSideBySideFullStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
        Dim CreateRotatedSideBySideStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
        Dim CreateRotatedStackedBarChartItem1 As DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem = New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
        Dim ChartControlCommandGalleryItemGroup2DArea1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
        Dim CreateAreaChartItem1 As DevExpress.XtraCharts.UI.CreateAreaChartItem = New DevExpress.XtraCharts.UI.CreateAreaChartItem()
        Dim CreateFullStackedAreaChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
        Dim CreateFullStackedSplineAreaChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
        Dim CreateFullStackedStepAreaChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedStepAreaChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedStepAreaChartItem()
        Dim CreateSplineAreaChartItem1 As DevExpress.XtraCharts.UI.CreateSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
        Dim CreateStackedAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStackedAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
        Dim CreateStackedStepAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStackedStepAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedStepAreaChartItem()
        Dim CreateStackedSplineAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem = New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
        Dim CreateStepAreaChartItem1 As DevExpress.XtraCharts.UI.CreateStepAreaChartItem = New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
        Dim ChartControlCommandGalleryItemGroup3DArea1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
        Dim CreateArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateArea3DChartItem = New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
        Dim CreateFullStackedArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
        Dim CreateFullStackedSplineArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
        Dim CreateSplineArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
        Dim CreateStackedArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
        Dim CreateStackedSplineArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
        Dim CreateStepArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateStepArea3DChartItem = New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
        Dim ChartControlCommandGalleryItemGroupPoint1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
        Dim CreatePointChartItem1 As DevExpress.XtraCharts.UI.CreatePointChartItem = New DevExpress.XtraCharts.UI.CreatePointChartItem()
        Dim CreateBubbleChartItem1 As DevExpress.XtraCharts.UI.CreateBubbleChartItem = New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
        Dim ChartControlCommandGalleryItemGroupFunnel1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
        Dim CreateFunnelChartItem1 As DevExpress.XtraCharts.UI.CreateFunnelChartItem = New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
        Dim CreateFunnel3DChartItem1 As DevExpress.XtraCharts.UI.CreateFunnel3DChartItem = New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
        Dim ChartControlCommandGalleryItemGroupFinancial1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
        Dim CreateStockChartItem1 As DevExpress.XtraCharts.UI.CreateStockChartItem = New DevExpress.XtraCharts.UI.CreateStockChartItem()
        Dim CreateCandleStickChartItem1 As DevExpress.XtraCharts.UI.CreateCandleStickChartItem = New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
        Dim ChartControlCommandGalleryItemGroupRadar1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
        Dim CreateRadarPointChartItem1 As DevExpress.XtraCharts.UI.CreateRadarPointChartItem = New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
        Dim CreateRadarLineChartItem1 As DevExpress.XtraCharts.UI.CreateRadarLineChartItem = New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
        Dim CreateRadarAreaChartItem1 As DevExpress.XtraCharts.UI.CreateRadarAreaChartItem = New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
        Dim CreateRadarRangeAreaChartItem1 As DevExpress.XtraCharts.UI.CreateRadarRangeAreaChartItem = New DevExpress.XtraCharts.UI.CreateRadarRangeAreaChartItem()
        Dim CreateScatterRadarLineChartItem1 As DevExpress.XtraCharts.UI.CreateScatterRadarLineChartItem = New DevExpress.XtraCharts.UI.CreateScatterRadarLineChartItem()
        Dim ChartControlCommandGalleryItemGroupPolar1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
        Dim CreatePolarPointChartItem1 As DevExpress.XtraCharts.UI.CreatePolarPointChartItem = New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
        Dim CreatePolarLineChartItem1 As DevExpress.XtraCharts.UI.CreatePolarLineChartItem = New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
        Dim CreatePolarAreaChartItem1 As DevExpress.XtraCharts.UI.CreatePolarAreaChartItem = New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
        Dim CreatePolarRangeAreaChartItem1 As DevExpress.XtraCharts.UI.CreatePolarRangeAreaChartItem = New DevExpress.XtraCharts.UI.CreatePolarRangeAreaChartItem()
        Dim CreateScatterPolarLineChartItem1 As DevExpress.XtraCharts.UI.CreateScatterPolarLineChartItem = New DevExpress.XtraCharts.UI.CreateScatterPolarLineChartItem()
        Dim ChartControlCommandGalleryItemGroupRange1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
        Dim CreateRangeBarChartItem1 As DevExpress.XtraCharts.UI.CreateRangeBarChartItem = New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
        Dim CreateSideBySideRangeBarChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
        Dim CreateRangeAreaChartItem1 As DevExpress.XtraCharts.UI.CreateRangeAreaChartItem = New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
        Dim CreateRangeArea3DChartItem1 As DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem = New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
        Dim ChartControlCommandGalleryItemGroupGantt1 As DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt = New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
        Dim CreateGanttChartItem1 As DevExpress.XtraCharts.UI.CreateGanttChartItem = New DevExpress.XtraCharts.UI.CreateGanttChartItem()
        Dim CreateSideBySideGanttChartItem1 As DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem = New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GRD_CambiosPrecionManuales = New M_UltraGrid.m_UltraGrid()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GRD_Cambio_Precios = New M_UltraGrid.m_UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GRD_Messes = New M_UltraGrid.m_UltraGrid()
        Me.GRD_Albarans = New M_UltraGrid.m_UltraGrid()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.c_KilosPorProveedorArticuloAñoMesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.B_Producte_DesSeleccionarTots = New System.Windows.Forms.Button()
        Me.B_Producte_DesSeleccionar = New System.Windows.Forms.Button()
        Me.B_Producte_SeleccionarTots = New System.Windows.Forms.Button()
        Me.B_Producte_Seleccionar = New System.Windows.Forms.Button()
        Me.GRD_ArticulosSeleccionados = New M_UltraGrid.m_UltraGrid()
        Me.GRD_ArticulosTodos = New M_UltraGrid.m_UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.B_Proveidor_DesSeleccionarTots = New System.Windows.Forms.Button()
        Me.B_Proveidor_DesSeleccionar = New System.Windows.Forms.Button()
        Me.B_Proveidor_SeleccionarTots = New System.Windows.Forms.Button()
        Me.B_Proveidor_Seleccionar = New System.Windows.Forms.Button()
        Me.GRD_ProveedoresSeleccionados = New M_UltraGrid.m_UltraGrid()
        Me.GRD_ProveedoresTodos = New M_UltraGrid.m_UltraGrid()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.C_Proveedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.GRD_Individual = New M_UltraGrid.m_UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.DT_Modificacio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel35 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.T_Import = New M_MaskEditor.m_MaskEditor()
        Me.B_Aplicar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.C_CambioAlbaran_Articulo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_CambioAlbaran_Proveedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.B_CambioAlbaran_Aplicar = New Infragistics.Win.Misc.UltraButton()
        Me.T_CambioAlbaran_NuevoPrecio = New M_MaskEditor.m_MaskEditor()
        Me.B_CambioAlbaran_Buscar = New Infragistics.Win.Misc.UltraButton()
        Me.DT_CambioAlbaran_FechaFin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_CambioAlbaran_FechaInicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.GRD_CambioAlbaran = New M_UltraGrid.m_UltraGrid()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ChartBarController1 = New DevExpress.XtraCharts.UI.ChartBarController()
        Me.CommandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.CommandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
        Me.XML_Proveidors = New System.Windows.Forms.Button()
        Me.TE_RutaExportacio = New M_TextEditor.m_TextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl9.SuspendLayout()
        Me.UltraTabPageControl8.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c_KilosPorProveedorArticuloAñoMesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        CType(Me.C_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.DT_Modificacio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.C_CambioAlbaran_Articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_CambioAlbaran_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_CambioAlbaran_FechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_CambioAlbaran_FechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        CType(Me.ChartBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_RutaExportacio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.pMode_Toolbar = m_ToolForm.clsToolForm.Enum_ToolMode.Sortir
        Me.ToolForm.Size = New System.Drawing.Size(582, 24)
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.GRD_CambiosPrecionManuales)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(427, 550)
        '
        'GRD_CambiosPrecionManuales
        '
        Me.GRD_CambiosPrecionManuales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRD_CambiosPrecionManuales.Location = New System.Drawing.Point(0, 0)
        Me.GRD_CambiosPrecionManuales.Name = "GRD_CambiosPrecionManuales"
        Me.GRD_CambiosPrecionManuales.pAccessibleName = Nothing
        Me.GRD_CambiosPrecionManuales.pActivarBotonFiltro = False
        Me.GRD_CambiosPrecionManuales.pText = " "
        Me.GRD_CambiosPrecionManuales.Size = New System.Drawing.Size(427, 550)
        Me.GRD_CambiosPrecionManuales.TabIndex = 5
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.GRD_Cambio_Precios)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(427, 550)
        '
        'GRD_Cambio_Precios
        '
        Me.GRD_Cambio_Precios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRD_Cambio_Precios.Location = New System.Drawing.Point(0, 0)
        Me.GRD_Cambio_Precios.Name = "GRD_Cambio_Precios"
        Me.GRD_Cambio_Precios.pAccessibleName = Nothing
        Me.GRD_Cambio_Precios.pActivarBotonFiltro = False
        Me.GRD_Cambio_Precios.pText = " "
        Me.GRD_Cambio_Precios.Size = New System.Drawing.Size(427, 550)
        Me.GRD_Cambio_Precios.TabIndex = 4
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.GRD_Messes)
        Me.UltraTabPageControl5.Controls.Add(Me.GRD_Albarans)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(427, 550)
        '
        'GRD_Messes
        '
        Me.GRD_Messes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRD_Messes.Location = New System.Drawing.Point(399, 0)
        Me.GRD_Messes.Name = "GRD_Messes"
        Me.GRD_Messes.pAccessibleName = Nothing
        Me.GRD_Messes.pActivarBotonFiltro = False
        Me.GRD_Messes.pText = " "
        Me.GRD_Messes.Size = New System.Drawing.Size(25, 550)
        Me.GRD_Messes.TabIndex = 4
        '
        'GRD_Albarans
        '
        Me.GRD_Albarans.Dock = System.Windows.Forms.DockStyle.Left
        Me.GRD_Albarans.Location = New System.Drawing.Point(0, 0)
        Me.GRD_Albarans.Name = "GRD_Albarans"
        Me.GRD_Albarans.pAccessibleName = Nothing
        Me.GRD_Albarans.pActivarBotonFiltro = False
        Me.GRD_Albarans.pText = " "
        Me.GRD_Albarans.Size = New System.Drawing.Size(393, 550)
        Me.GRD_Albarans.TabIndex = 3
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.ChartControl1)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(427, 550)
        '
        'ChartControl1
        '
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.c_KilosPorProveedorArticuloAñoMesBindingSource
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.Name = "Series 1"
        Series2.Name = "Series 2"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        Me.ChartControl1.Size = New System.Drawing.Size(427, 550)
        Me.ChartControl1.TabIndex = 0
        '
        'c_KilosPorProveedorArticuloAñoMesBindingSource
        '
        Me.c_KilosPorProveedorArticuloAñoMesBindingSource.DataMember = "C_KilosPorProveedorArticuloAñoMes"
        Me.c_KilosPorProveedorArticuloAñoMesBindingSource.DataSource = Me.SqlDataSource1
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ClarianaCentral.My.MySettings.BDClarianaCentralConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Table1.MetaSerializable = "30|30|125|153"
        Table1.Name = "C_KilosPorProveedorArticuloAñoMes"
        AllColumns1.Table = Table1
        SelectQuery1.Columns.Add(AllColumns1)
        SelectQuery1.Name = "C_KilosPorProveedorArticuloAñoMes"
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.ChartControl2)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(427, 550)
        '
        'ChartControl2
        '
        Me.ChartControl2.DataBindings = Nothing
        Me.ChartControl2.DataSource = Me.c_KilosPorProveedorArticuloAñoMesBindingSource
        CustomAxisLabel1.AxisValueSerializable = "1"
        CustomAxisLabel1.Name = "Enero"
        CustomAxisLabel2.AxisValueSerializable = "2"
        CustomAxisLabel2.Name = "Febrero"
        CustomAxisLabel3.AxisValueSerializable = "3"
        CustomAxisLabel3.Name = "Marzo"
        CustomAxisLabel4.AxisValueSerializable = "4"
        CustomAxisLabel4.Name = "Abril"
        CustomAxisLabel5.AxisValueSerializable = "5"
        CustomAxisLabel5.Name = "Mayo"
        CustomAxisLabel6.AxisValueSerializable = "6"
        CustomAxisLabel6.Name = "Junio"
        CustomAxisLabel7.AxisValueSerializable = "7"
        CustomAxisLabel7.Name = "Julio"
        CustomAxisLabel8.AxisValueSerializable = "8"
        CustomAxisLabel8.Name = "Agosto"
        CustomAxisLabel9.AxisValueSerializable = "9"
        CustomAxisLabel9.Name = "Septiembre"
        CustomAxisLabel10.AxisValueSerializable = "10"
        CustomAxisLabel10.Name = "Octubre"
        CustomAxisLabel11.AxisValueSerializable = "11"
        CustomAxisLabel11.Name = "Noviembre"
        CustomAxisLabel12.AxisValueSerializable = "12"
        CustomAxisLabel12.Name = "Diciembre"
        XyDiagram2.AxisX.CustomLabels.AddRange(New DevExpress.XtraCharts.CustomAxisLabel() {CustomAxisLabel1, CustomAxisLabel2, CustomAxisLabel3, CustomAxisLabel4, CustomAxisLabel5, CustomAxisLabel6, CustomAxisLabel7, CustomAxisLabel8, CustomAxisLabel9, CustomAxisLabel10, CustomAxisLabel11, CustomAxisLabel12})
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl2.Diagram = XyDiagram2
        Me.ChartControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl2.Legend.Name = "Default Legend"
        Me.ChartControl2.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl2.Name = "ChartControl2"
        Series3.ArgumentDataMember = "Mes"
        Series3.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("Año", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 2017)})
        Series3.Name = "2017"
        Series3.ValueDataMembersSerializable = "Cantidad"
        Series4.ArgumentDataMember = "Mes"
        Series4.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("Año", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 2016)})
        Series4.Name = "2016"
        Series4.ValueDataMembersSerializable = "Cantidad"
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3, Series4}
        Me.ChartControl2.Size = New System.Drawing.Size(427, 550)
        Me.ChartControl2.TabIndex = 0
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.B_Producte_DesSeleccionarTots)
        Me.UltraTabPageControl1.Controls.Add(Me.B_Producte_DesSeleccionar)
        Me.UltraTabPageControl1.Controls.Add(Me.B_Producte_SeleccionarTots)
        Me.UltraTabPageControl1.Controls.Add(Me.B_Producte_Seleccionar)
        Me.UltraTabPageControl1.Controls.Add(Me.GRD_ArticulosSeleccionados)
        Me.UltraTabPageControl1.Controls.Add(Me.GRD_ArticulosTodos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(966, 553)
        '
        'B_Producte_DesSeleccionarTots
        '
        Me.B_Producte_DesSeleccionarTots.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Producte_DesSeleccionarTots.Location = New System.Drawing.Point(299, 294)
        Me.B_Producte_DesSeleccionarTots.Name = "B_Producte_DesSeleccionarTots"
        Me.B_Producte_DesSeleccionarTots.Size = New System.Drawing.Size(27, 23)
        Me.B_Producte_DesSeleccionarTots.TabIndex = 5
        Me.B_Producte_DesSeleccionarTots.Text = "<<"
        Me.B_Producte_DesSeleccionarTots.UseVisualStyleBackColor = True
        '
        'B_Producte_DesSeleccionar
        '
        Me.B_Producte_DesSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Producte_DesSeleccionar.Location = New System.Drawing.Point(299, 265)
        Me.B_Producte_DesSeleccionar.Name = "B_Producte_DesSeleccionar"
        Me.B_Producte_DesSeleccionar.Size = New System.Drawing.Size(27, 23)
        Me.B_Producte_DesSeleccionar.TabIndex = 4
        Me.B_Producte_DesSeleccionar.Text = "<"
        Me.B_Producte_DesSeleccionar.UseVisualStyleBackColor = True
        '
        'B_Producte_SeleccionarTots
        '
        Me.B_Producte_SeleccionarTots.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Producte_SeleccionarTots.Location = New System.Drawing.Point(299, 198)
        Me.B_Producte_SeleccionarTots.Name = "B_Producte_SeleccionarTots"
        Me.B_Producte_SeleccionarTots.Size = New System.Drawing.Size(27, 23)
        Me.B_Producte_SeleccionarTots.TabIndex = 3
        Me.B_Producte_SeleccionarTots.Text = ">>"
        Me.B_Producte_SeleccionarTots.UseVisualStyleBackColor = True
        '
        'B_Producte_Seleccionar
        '
        Me.B_Producte_Seleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Producte_Seleccionar.Location = New System.Drawing.Point(299, 169)
        Me.B_Producte_Seleccionar.Name = "B_Producte_Seleccionar"
        Me.B_Producte_Seleccionar.Size = New System.Drawing.Size(27, 23)
        Me.B_Producte_Seleccionar.TabIndex = 2
        Me.B_Producte_Seleccionar.Text = ">"
        Me.B_Producte_Seleccionar.UseVisualStyleBackColor = True
        '
        'GRD_ArticulosSeleccionados
        '
        Me.GRD_ArticulosSeleccionados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRD_ArticulosSeleccionados.Location = New System.Drawing.Point(332, 3)
        Me.GRD_ArticulosSeleccionados.Name = "GRD_ArticulosSeleccionados"
        Me.GRD_ArticulosSeleccionados.pAccessibleName = Nothing
        Me.GRD_ArticulosSeleccionados.pActivarBotonFiltro = False
        Me.GRD_ArticulosSeleccionados.pText = " "
        Me.GRD_ArticulosSeleccionados.Size = New System.Drawing.Size(631, 547)
        Me.GRD_ArticulosSeleccionados.TabIndex = 1
        '
        'GRD_ArticulosTodos
        '
        Me.GRD_ArticulosTodos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRD_ArticulosTodos.Location = New System.Drawing.Point(-1, 3)
        Me.GRD_ArticulosTodos.Name = "GRD_ArticulosTodos"
        Me.GRD_ArticulosTodos.pAccessibleName = Nothing
        Me.GRD_ArticulosTodos.pActivarBotonFiltro = False
        Me.GRD_ArticulosTodos.pText = " "
        Me.GRD_ArticulosTodos.Size = New System.Drawing.Size(293, 547)
        Me.GRD_ArticulosTodos.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.B_Proveidor_DesSeleccionarTots)
        Me.UltraTabPageControl2.Controls.Add(Me.B_Proveidor_DesSeleccionar)
        Me.UltraTabPageControl2.Controls.Add(Me.B_Proveidor_SeleccionarTots)
        Me.UltraTabPageControl2.Controls.Add(Me.B_Proveidor_Seleccionar)
        Me.UltraTabPageControl2.Controls.Add(Me.GRD_ProveedoresSeleccionados)
        Me.UltraTabPageControl2.Controls.Add(Me.GRD_ProveedoresTodos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(966, 553)
        '
        'B_Proveidor_DesSeleccionarTots
        '
        Me.B_Proveidor_DesSeleccionarTots.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Proveidor_DesSeleccionarTots.Location = New System.Drawing.Point(315, 297)
        Me.B_Proveidor_DesSeleccionarTots.Name = "B_Proveidor_DesSeleccionarTots"
        Me.B_Proveidor_DesSeleccionarTots.Size = New System.Drawing.Size(27, 23)
        Me.B_Proveidor_DesSeleccionarTots.TabIndex = 9
        Me.B_Proveidor_DesSeleccionarTots.Text = "<<"
        Me.B_Proveidor_DesSeleccionarTots.UseVisualStyleBackColor = True
        '
        'B_Proveidor_DesSeleccionar
        '
        Me.B_Proveidor_DesSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Proveidor_DesSeleccionar.Location = New System.Drawing.Point(315, 268)
        Me.B_Proveidor_DesSeleccionar.Name = "B_Proveidor_DesSeleccionar"
        Me.B_Proveidor_DesSeleccionar.Size = New System.Drawing.Size(27, 23)
        Me.B_Proveidor_DesSeleccionar.TabIndex = 8
        Me.B_Proveidor_DesSeleccionar.Text = "<"
        Me.B_Proveidor_DesSeleccionar.UseVisualStyleBackColor = True
        '
        'B_Proveidor_SeleccionarTots
        '
        Me.B_Proveidor_SeleccionarTots.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Proveidor_SeleccionarTots.Location = New System.Drawing.Point(315, 201)
        Me.B_Proveidor_SeleccionarTots.Name = "B_Proveidor_SeleccionarTots"
        Me.B_Proveidor_SeleccionarTots.Size = New System.Drawing.Size(27, 23)
        Me.B_Proveidor_SeleccionarTots.TabIndex = 7
        Me.B_Proveidor_SeleccionarTots.Text = ">>"
        Me.B_Proveidor_SeleccionarTots.UseVisualStyleBackColor = True
        '
        'B_Proveidor_Seleccionar
        '
        Me.B_Proveidor_Seleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Proveidor_Seleccionar.Location = New System.Drawing.Point(315, 172)
        Me.B_Proveidor_Seleccionar.Name = "B_Proveidor_Seleccionar"
        Me.B_Proveidor_Seleccionar.Size = New System.Drawing.Size(27, 23)
        Me.B_Proveidor_Seleccionar.TabIndex = 6
        Me.B_Proveidor_Seleccionar.Text = ">"
        Me.B_Proveidor_Seleccionar.UseVisualStyleBackColor = True
        '
        'GRD_ProveedoresSeleccionados
        '
        Me.GRD_ProveedoresSeleccionados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRD_ProveedoresSeleccionados.Location = New System.Drawing.Point(348, 3)
        Me.GRD_ProveedoresSeleccionados.Name = "GRD_ProveedoresSeleccionados"
        Me.GRD_ProveedoresSeleccionados.pAccessibleName = Nothing
        Me.GRD_ProveedoresSeleccionados.pActivarBotonFiltro = False
        Me.GRD_ProveedoresSeleccionados.pText = " "
        Me.GRD_ProveedoresSeleccionados.Size = New System.Drawing.Size(625, 547)
        Me.GRD_ProveedoresSeleccionados.TabIndex = 3
        '
        'GRD_ProveedoresTodos
        '
        Me.GRD_ProveedoresTodos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRD_ProveedoresTodos.Location = New System.Drawing.Point(3, 3)
        Me.GRD_ProveedoresTodos.Name = "GRD_ProveedoresTodos"
        Me.GRD_ProveedoresTodos.pAccessibleName = Nothing
        Me.GRD_ProveedoresTodos.pActivarBotonFiltro = False
        Me.GRD_ProveedoresTodos.pText = " "
        Me.GRD_ProveedoresTodos.Size = New System.Drawing.Size(306, 547)
        Me.GRD_ProveedoresTodos.TabIndex = 2
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraTabControl3)
        Me.UltraTabPageControl4.Controls.Add(Me.C_Proveedor)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl4.Controls.Add(Me.GRD_Individual)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(976, 615)
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl3.Location = New System.Drawing.Point(544, 36)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(431, 576)
        Me.UltraTabControl3.TabIndex = 5
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Cambios de precio manuales"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "Cambios de precio en albarán"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Resumen"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Gráfico"
        UltraTab6.Visible = False
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Gráfico"
        Me.UltraTabControl3.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab8, UltraTab5, UltraTab6, UltraTab7})
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(427, 550)
        '
        'C_Proveedor
        '
        Me.C_Proveedor.Location = New System.Drawing.Point(76, 7)
        Me.C_Proveedor.Name = "C_Proveedor"
        Me.C_Proveedor.Size = New System.Drawing.Size(277, 21)
        Me.C_Proveedor.TabIndex = 4
        Me.C_Proveedor.Text = "C_Proveedor"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(3, 7)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(67, 19)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Proveedor:"
        '
        'GRD_Individual
        '
        Me.GRD_Individual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GRD_Individual.Location = New System.Drawing.Point(3, 36)
        Me.GRD_Individual.Name = "GRD_Individual"
        Me.GRD_Individual.pAccessibleName = Nothing
        Me.GRD_Individual.pActivarBotonFiltro = False
        Me.GRD_Individual.pText = " "
        Me.GRD_Individual.Size = New System.Drawing.Size(535, 576)
        Me.GRD_Individual.TabIndex = 2
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.DT_Modificacio)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraLabel35)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraTabControl1)
        Me.UltraTabPageControl3.Controls.Add(Me.T_Import)
        Me.UltraTabPageControl3.Controls.Add(Me.B_Aplicar)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(976, 615)
        '
        'DT_Modificacio
        '
        Me.DT_Modificacio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DT_Modificacio.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Modificacio.Location = New System.Drawing.Point(668, 587)
        Me.DT_Modificacio.MaskInput = "{date}"
        Me.DT_Modificacio.Name = "DT_Modificacio"
        Me.DT_Modificacio.Size = New System.Drawing.Size(100, 21)
        Me.DT_Modificacio.TabIndex = 14
        Me.DT_Modificacio.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel35
        '
        Me.UltraLabel35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel35.Location = New System.Drawing.Point(552, 591)
        Me.UltraLabel35.Name = "UltraLabel35"
        Me.UltraLabel35.Size = New System.Drawing.Size(110, 16)
        Me.UltraLabel35.TabIndex = 15
        Me.UltraLabel35.Text = "*Fecha modificación:"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(3, 3)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(970, 579)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Artículos"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Proveedores"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(966, 553)
        '
        'T_Import
        '
        Me.T_Import.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T_Import.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Currency
        Me.T_Import.InputMask = "{currency:-9.2}"
        Me.T_Import.Location = New System.Drawing.Point(774, 588)
        Me.T_Import.Name = "T_Import"
        Me.T_Import.NonAutoSizeHeight = 20
        Me.T_Import.Size = New System.Drawing.Size(100, 20)
        Me.T_Import.TabIndex = 3
        Me.T_Import.Text = " €"
        '
        'B_Aplicar
        '
        Me.B_Aplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Aplicar.Location = New System.Drawing.Point(896, 588)
        Me.B_Aplicar.Name = "B_Aplicar"
        Me.B_Aplicar.Size = New System.Drawing.Size(71, 20)
        Me.B_Aplicar.TabIndex = 2
        Me.B_Aplicar.Text = "Aplicar"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.C_CambioAlbaran_Articulo)
        Me.UltraTabPageControl10.Controls.Add(Me.UltraLabel6)
        Me.UltraTabPageControl10.Controls.Add(Me.C_CambioAlbaran_Proveedor)
        Me.UltraTabPageControl10.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl10.Controls.Add(Me.B_CambioAlbaran_Aplicar)
        Me.UltraTabPageControl10.Controls.Add(Me.T_CambioAlbaran_NuevoPrecio)
        Me.UltraTabPageControl10.Controls.Add(Me.B_CambioAlbaran_Buscar)
        Me.UltraTabPageControl10.Controls.Add(Me.DT_CambioAlbaran_FechaFin)
        Me.UltraTabPageControl10.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl10.Controls.Add(Me.DT_CambioAlbaran_FechaInicio)
        Me.UltraTabPageControl10.Controls.Add(Me.GRD_CambioAlbaran)
        Me.UltraTabPageControl10.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl10.Controls.Add(Me.UltraLabel4)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(976, 615)
        '
        'C_CambioAlbaran_Articulo
        '
        Me.C_CambioAlbaran_Articulo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.C_CambioAlbaran_Articulo.Location = New System.Drawing.Point(248, 28)
        Me.C_CambioAlbaran_Articulo.Name = "C_CambioAlbaran_Articulo"
        Me.C_CambioAlbaran_Articulo.Size = New System.Drawing.Size(192, 21)
        Me.C_CambioAlbaran_Articulo.TabIndex = 24
        Me.C_CambioAlbaran_Articulo.Text = "C_CambioAlbaranArticulo"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(248, 14)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(67, 19)
        Me.UltraLabel6.TabIndex = 23
        Me.UltraLabel6.Text = "Artículo:"
        '
        'C_CambioAlbaran_Proveedor
        '
        Me.C_CambioAlbaran_Proveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.C_CambioAlbaran_Proveedor.Location = New System.Drawing.Point(7, 28)
        Me.C_CambioAlbaran_Proveedor.Name = "C_CambioAlbaran_Proveedor"
        Me.C_CambioAlbaran_Proveedor.Size = New System.Drawing.Size(227, 21)
        Me.C_CambioAlbaran_Proveedor.TabIndex = 22
        Me.C_CambioAlbaran_Proveedor.Text = "C_CambioAlbaran_Proveedor"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(7, 14)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(67, 19)
        Me.UltraLabel5.TabIndex = 21
        Me.UltraLabel5.Text = "Proveedor:"
        '
        'B_CambioAlbaran_Aplicar
        '
        Me.B_CambioAlbaran_Aplicar.Location = New System.Drawing.Point(897, 30)
        Me.B_CambioAlbaran_Aplicar.Name = "B_CambioAlbaran_Aplicar"
        Me.B_CambioAlbaran_Aplicar.Size = New System.Drawing.Size(71, 20)
        Me.B_CambioAlbaran_Aplicar.TabIndex = 19
        Me.B_CambioAlbaran_Aplicar.Text = "Aplicar"
        '
        'T_CambioAlbaran_NuevoPrecio
        '
        Me.T_CambioAlbaran_NuevoPrecio.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Currency
        Me.T_CambioAlbaran_NuevoPrecio.InputMask = "{currency:-9.2}"
        Me.T_CambioAlbaran_NuevoPrecio.Location = New System.Drawing.Point(791, 29)
        Me.T_CambioAlbaran_NuevoPrecio.Name = "T_CambioAlbaran_NuevoPrecio"
        Me.T_CambioAlbaran_NuevoPrecio.NonAutoSizeHeight = 20
        Me.T_CambioAlbaran_NuevoPrecio.Size = New System.Drawing.Size(100, 20)
        Me.T_CambioAlbaran_NuevoPrecio.TabIndex = 18
        Me.T_CambioAlbaran_NuevoPrecio.Text = " €"
        '
        'B_CambioAlbaran_Buscar
        '
        Me.B_CambioAlbaran_Buscar.Location = New System.Drawing.Point(690, 29)
        Me.B_CambioAlbaran_Buscar.Name = "B_CambioAlbaran_Buscar"
        Me.B_CambioAlbaran_Buscar.Size = New System.Drawing.Size(71, 20)
        Me.B_CambioAlbaran_Buscar.TabIndex = 17
        Me.B_CambioAlbaran_Buscar.Text = "Buscar"
        '
        'DT_CambioAlbaran_FechaFin
        '
        Me.DT_CambioAlbaran_FechaFin.Location = New System.Drawing.Point(573, 28)
        Me.DT_CambioAlbaran_FechaFin.Name = "DT_CambioAlbaran_FechaFin"
        Me.DT_CambioAlbaran_FechaFin.Size = New System.Drawing.Size(111, 21)
        Me.DT_CambioAlbaran_FechaFin.TabIndex = 15
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel3.Location = New System.Drawing.Point(573, 12)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(111, 17)
        Me.UltraLabel3.TabIndex = 16
        Me.UltraLabel3.Text = "Fecha fin albarán:"
        '
        'DT_CambioAlbaran_FechaInicio
        '
        Me.DT_CambioAlbaran_FechaInicio.Location = New System.Drawing.Point(451, 28)
        Me.DT_CambioAlbaran_FechaInicio.Name = "DT_CambioAlbaran_FechaInicio"
        Me.DT_CambioAlbaran_FechaInicio.Size = New System.Drawing.Size(111, 21)
        Me.DT_CambioAlbaran_FechaInicio.TabIndex = 13
        '
        'GRD_CambioAlbaran
        '
        Me.GRD_CambioAlbaran.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRD_CambioAlbaran.Location = New System.Drawing.Point(7, 56)
        Me.GRD_CambioAlbaran.Name = "GRD_CambioAlbaran"
        Me.GRD_CambioAlbaran.pAccessibleName = Nothing
        Me.GRD_CambioAlbaran.pActivarBotonFiltro = False
        Me.GRD_CambioAlbaran.pText = " "
        Me.GRD_CambioAlbaran.Size = New System.Drawing.Size(963, 523)
        Me.GRD_CambioAlbaran.TabIndex = 12
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel2.Location = New System.Drawing.Point(451, 12)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(111, 17)
        Me.UltraLabel2.TabIndex = 14
        Me.UltraLabel2.Text = "Fecha inicio albarán:"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel4.Location = New System.Drawing.Point(791, 13)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(111, 17)
        Me.UltraLabel4.TabIndex = 20
        Me.UltraLabel4.Text = "Nuevo precio:"
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl10)
        Me.UltraTabControl2.Location = New System.Drawing.Point(12, 39)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(980, 641)
        Me.UltraTabControl2.TabIndex = 4
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Tarifas por proveedor"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Tarifas por proveedor y artículo"
        UltraTab10.Key = "Cambios"
        UltraTab10.TabPage = Me.UltraTabPageControl10
        UltraTab10.Text = "Cambios de precio en albaranes"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab3, UltraTab10})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(976, 615)
        '
        'ChartBarController1
        '
        Me.ChartBarController1.Control = Me.ChartControl1
        '
        'CommandBarGalleryDropDown1
        '
        '
        '
        '
        CreateBarChartItem1.Caption = "Columnas Agrupadas"
        CreateBarChartItem1.Description = "Compare values across categories by using vertical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the" & _
    " order of categories is not important or for displaying item counts such as a hi" & _
    "stogram."
        CreateBarChartItem1.Hint = "Compare values across categories by using vertical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when the" & _
    " order of categories is not important or for displaying item counts such as a hi" & _
    "stogram."
        CreateFullStackedBarChartItem1.Caption = "Columnas Apiladas 100%"
        CreateFullStackedBarChartItem1.Description = "Compara el porcentaje que cada valor contribuye a un total entre categorías utili" & _
    "zando rectángulos verticales." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Se usa para destacar la proporción de cada seri" & _
    "e de datos."
        CreateFullStackedBarChartItem1.Hint = "Compara el porcentaje que cada valor contribuye a un total entre categorías utili" & _
    "zando rectángulos verticales." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Se usa para destacar la proporción de cada seri" & _
    "e de datos."
        CreateSideBySideFullStackedBarChartItem1.Caption = "Columnas Apiladas y Agrupadas 100%"
        CreateSideBySideFullStackedBarChartItem1.Description = "Combina las ventajas de los gráficos de Columnas Apiladas y Columnas Agrupadas, p" & _
    "ara poder apilar las columnas y agruparlas en el mismo eje."
        CreateSideBySideFullStackedBarChartItem1.Hint = "Combina las ventajas de los gráficos de Columnas Apiladas y Columnas Agrupadas, p" & _
    "ara poder apilar las columnas y agruparlas en el mismo eje."
        CreateSideBySideStackedBarChartItem1.Caption = "Columnas Apiladas Agrupadas"
        CreateSideBySideStackedBarChartItem1.Description = "Combina las ventajas de los gráficos de Columnas Apiladas y Columnas Agrupadas, p" & _
    "ara poder apilar las columnas y agruparlas en el mismo eje."
        CreateSideBySideStackedBarChartItem1.Hint = "Combina las ventajas de los gráficos de Columnas Apiladas y Columnas Agrupadas, p" & _
    "ara poder apilar las columnas y agruparlas en el mismo eje."
        CreateStackedBarChartItem1.Caption = "Columnas Apiladas"
        CreateStackedBarChartItem1.Description = "Compare the contribution of each value to a total across categories by using vert" & _
    "ical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the total across series for one category" & _
    "."
        CreateStackedBarChartItem1.Hint = "Compare the contribution of each value to a total across categories by using vert" & _
    "ical rectangles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the total across series for one category" & _
    "."
        ChartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBarChartItem1, CreateFullStackedBarChartItem1, CreateSideBySideFullStackedBarChartItem1, CreateSideBySideStackedBarChartItem1, CreateStackedBarChartItem1})
        CreateBar3DChartItem1.Caption = "Columnas Agrupadas 3D"
        CreateBar3DChartItem1.Description = "Comparar los valores a través de todas las categorías y mostrar con el formato de" & _
    " columnas agrupadas en 3D."
        CreateBar3DChartItem1.Hint = "Comparar los valores a través de todas las categorías y mostrar con el formato de" & _
    " columnas agrupadas en 3D."
        CreateFullStackedBar3DChartItem1.Caption = "Columnas Apiladas  3D 100%"
        CreateFullStackedBar3DChartItem1.Description = "Comparar el porcentaje de cada valor a través de todas las categorías y mostrar c" & _
    "on el formato de columnas apiladas en 3D."
        CreateFullStackedBar3DChartItem1.Hint = "Comparar el porcentaje de cada valor a través de todas las categorías y mostrar c" & _
    "on el formato de columnas apiladas en 3D."
        CreateManhattanBarChartItem1.Caption = "Columnas 3D"
        CreateManhattanBarChartItem1.Description = "Compare values across categories and across series on three axes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when " & _
    "the categories and series are equally important."
        CreateManhattanBarChartItem1.Hint = "Compare values across categories and across series on three axes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it when " & _
    "the categories and series are equally important."
        CreateSideBySideFullStackedBar3DChartItem1.Caption = "Columnas Apiladas y Agrupadas 100% en 3D"
        CreateSideBySideFullStackedBar3DChartItem1.Description = "Combina las ventajas de los gráficos de Columnas Apiladas y Columnas Agrupadas, p" & _
    "ara poder apilar las columnas y agruparlas en el mismo eje."
        CreateSideBySideFullStackedBar3DChartItem1.Hint = "Combina las ventajas de los gráficos de Columnas Apiladas y Columnas Agrupadas, p" & _
    "ara poder apilar las columnas y agruparlas en el mismo eje."
        CreateSideBySideStackedBar3DChartItem1.Caption = "Columnas Apiladas Agrupadas en 3D"
        CreateSideBySideStackedBar3DChartItem1.Description = "Combina las ventajas de los gráficos de Columnas Apiladas y Columnas Agrupadas, p" & _
    "ara poder apilar las columnas y agruparlas en el mismo eje."
        CreateSideBySideStackedBar3DChartItem1.Hint = "Combina las ventajas de los gráficos de Columnas Apiladas y Columnas Agrupadas, p" & _
    "ara poder apilar las columnas y agruparlas en el mismo eje."
        CreateStackedBar3DChartItem1.Caption = "Columnas Apiladas en 3D"
        CreateStackedBar3DChartItem1.Description = "Comparar la contribución de cada valor a través de todas las categorías y mostrar" & _
    " con el formato de columnas apiladas en 3D."
        CreateStackedBar3DChartItem1.Hint = "Comparar la contribución de cada valor a través de todas las categorías y mostrar" & _
    " con el formato de columnas apiladas en 3D."
        ChartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateBar3DChartItem1, CreateFullStackedBar3DChartItem1, CreateManhattanBarChartItem1, CreateSideBySideFullStackedBar3DChartItem1, CreateSideBySideStackedBar3DChartItem1, CreateStackedBar3DChartItem1})
        CreateCylinderBar3DChartItem1.Caption = "Cilindros Agrupados"
        CreateCylinderBar3DChartItem1.Description = "Comparar valores a través de las categorías."
        CreateCylinderBar3DChartItem1.Hint = "Comparar valores a través de las categorías."
        CreateCylinderFullStackedBar3DChartItem1.Caption = "Cilindros Apilados 100%"
        CreateCylinderFullStackedBar3DChartItem1.Description = "Comparar el porcentaje de cada valor a través de todas las categorías."
        CreateCylinderFullStackedBar3DChartItem1.Hint = "Comparar el porcentaje de cada valor a través de todas las categorías."
        CreateCylinderManhattanBarChartItem1.Caption = "Cilindro 3D"
        CreateCylinderManhattanBarChartItem1.Description = "Comparar los valores a través de todas las categorías y mostrar con el formato de" & _
    " cilindros con 3 ejes."
        CreateCylinderManhattanBarChartItem1.Hint = "Comparar los valores a través de todas las categorías y mostrar con el formato de" & _
    " cilindros con 3 ejes."
        CreateCylinderSideBySideFullStackedBar3DChartItem1.Caption = "Cilindros Apilados y Agrupados 100%"
        CreateCylinderSideBySideFullStackedBar3DChartItem1.Description = "Combina las ventajas de los gráficos de Cilindros Apilados y Cilindros Agrupados," & _
    " para poder apilar los cilindros y agruparlos en el mismo eje."
        CreateCylinderSideBySideFullStackedBar3DChartItem1.Hint = "Combina las ventajas de los gráficos de Cilindros Apilados y Cilindros Agrupados," & _
    " para poder apilar los cilindros y agruparlos en el mismo eje."
        CreateCylinderSideBySideStackedBar3DChartItem1.Caption = "Cilindros Apilados y Agrupados"
        CreateCylinderSideBySideStackedBar3DChartItem1.Description = "Combina las ventajas de los gráficos de Cilindros Apilados y Cilindros Agrupados," & _
    " para poder apilar los cilindros y agruparlos en el mismo eje."
        CreateCylinderSideBySideStackedBar3DChartItem1.Hint = "Combina las ventajas de los gráficos de Cilindros Apilados y Cilindros Agrupados," & _
    " para poder apilar los cilindros y agruparlos en el mismo eje."
        CreateCylinderStackedBar3DChartItem1.Caption = "Cilindros Apilados"
        CreateCylinderStackedBar3DChartItem1.Description = "Comparar la contribución de cada punto sobre el total a través de las categorías." & _
    ""
        CreateCylinderStackedBar3DChartItem1.Hint = "Comparar la contribución de cada punto sobre el total a través de las categorías." & _
    ""
        ChartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateCylinderBar3DChartItem1, CreateCylinderFullStackedBar3DChartItem1, CreateCylinderManhattanBarChartItem1, CreateCylinderSideBySideFullStackedBar3DChartItem1, CreateCylinderSideBySideStackedBar3DChartItem1, CreateCylinderStackedBar3DChartItem1})
        CreateConeBar3DChartItem1.Caption = "Conos Agrupados"
        CreateConeBar3DChartItem1.Description = "Comparar valores a través de las categorías."
        CreateConeBar3DChartItem1.Hint = "Comparar valores a través de las categorías."
        CreateConeFullStackedBar3DChartItem1.Caption = "Conos Apilados 100%"
        CreateConeFullStackedBar3DChartItem1.Description = "Comparar el porcentaje de cada valor a través de todas las categorías."
        CreateConeFullStackedBar3DChartItem1.Hint = "Comparar el porcentaje de cada valor a través de todas las categorías."
        CreateConeManhattanBarChartItem1.Caption = "Cono 3D"
        CreateConeManhattanBarChartItem1.Description = "Comparar los valores a través de todas las categorías y mostrar con el formato de" & _
    " conos con 3 ejes."
        CreateConeManhattanBarChartItem1.Hint = "Comparar los valores a través de todas las categorías y mostrar con el formato de" & _
    " conos con 3 ejes."
        CreateConeSideBySideFullStackedBar3DChartItem1.Caption = "Conos Apilados y Agrupados 100%"
        CreateConeSideBySideFullStackedBar3DChartItem1.Description = "Combina las ventajas de los gráficos de Conos Apilados y Conos Agrupados, para po" & _
    "der apilar los conos y agruparlos en el mismo eje."
        CreateConeSideBySideFullStackedBar3DChartItem1.Hint = "Combina las ventajas de los gráficos de Conos Apilados y Conos Agrupados, para po" & _
    "der apilar los conos y agruparlos en el mismo eje."
        CreateConeSideBySideStackedBar3DChartItem1.Caption = "Conos Apilados y Agrupados"
        CreateConeSideBySideStackedBar3DChartItem1.Description = "Combina las ventajas de los gráficos de Conos Apilados y Conos Agrupados, para po" & _
    "der apilar los conos y agruparlos en el mismo eje."
        CreateConeSideBySideStackedBar3DChartItem1.Hint = "Combina las ventajas de los gráficos de Conos Apilados y Conos Agrupados, para po" & _
    "der apilar los conos y agruparlos en el mismo eje."
        CreateConeStackedBar3DChartItem1.Caption = "Conos Apilados"
        CreateConeStackedBar3DChartItem1.Description = "Comparar la contribución de cada punto sobre el total a través de las categorías." & _
    ""
        CreateConeStackedBar3DChartItem1.Hint = "Comparar la contribución de cada punto sobre el total a través de las categorías." & _
    ""
        ChartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateConeBar3DChartItem1, CreateConeFullStackedBar3DChartItem1, CreateConeManhattanBarChartItem1, CreateConeSideBySideFullStackedBar3DChartItem1, CreateConeSideBySideStackedBar3DChartItem1, CreateConeStackedBar3DChartItem1})
        CreatePyramidBar3DChartItem1.Caption = "Pirámide Agrupado"
        CreatePyramidBar3DChartItem1.Description = "Comparar valores a través de las categorías."
        CreatePyramidBar3DChartItem1.Hint = "Comparar valores a través de las categorías."
        CreatePyramidFullStackedBar3DChartItem1.Caption = "Pirámides Apilados 100%"
        CreatePyramidFullStackedBar3DChartItem1.Description = "Comparar el porcentaje de cada valor a través de todas las categorías."
        CreatePyramidFullStackedBar3DChartItem1.Hint = "Comparar el porcentaje de cada valor a través de todas las categorías."
        CreatePyramidManhattanBarChartItem1.Caption = "Pirámide en 3D"
        CreatePyramidManhattanBarChartItem1.Description = "Comparar los valores a través de todas las categorías y mostrar con el formato de" & _
    " pirámides con 3 ejes."
        CreatePyramidManhattanBarChartItem1.Hint = "Comparar los valores a través de todas las categorías y mostrar con el formato de" & _
    " pirámides con 3 ejes."
        CreatePyramidSideBySideFullStackedBar3DChartItem1.Caption = "Pirámides Apilados y Agrupados 100%"
        CreatePyramidSideBySideFullStackedBar3DChartItem1.Description = "Combina las ventajas de los gráficos de Pirámides Apilados y Pirámides Agrupados," & _
    " para poder apilar los pirámides y agruparlos en el mismo eje."
        CreatePyramidSideBySideFullStackedBar3DChartItem1.Hint = "Combina las ventajas de los gráficos de Pirámides Apilados y Pirámides Agrupados," & _
    " para poder apilar los pirámides y agruparlos en el mismo eje."
        CreatePyramidSideBySideStackedBar3DChartItem1.Caption = "Pirámides Apilados y Agrupados"
        CreatePyramidSideBySideStackedBar3DChartItem1.Description = "Combina las ventajas de los gráficos de Pirámides Apilados y Pirámides Agrupados," & _
    " para poder apilar los pirámides y agruparlos en el mismo eje."
        CreatePyramidSideBySideStackedBar3DChartItem1.Hint = "Combina las ventajas de los gráficos de Pirámides Apilados y Pirámides Agrupados," & _
    " para poder apilar los pirámides y agruparlos en el mismo eje."
        CreatePyramidStackedBar3DChartItem1.Caption = "Pirámide Apilada"
        CreatePyramidStackedBar3DChartItem1.Description = "Comparar la contribución de cada punto sobre el total a través de las categorías." & _
    ""
        CreatePyramidStackedBar3DChartItem1.Hint = "Comparar la contribución de cada punto sobre el total a través de las categorías." & _
    ""
        ChartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePyramidBar3DChartItem1, CreatePyramidFullStackedBar3DChartItem1, CreatePyramidManhattanBarChartItem1, CreatePyramidSideBySideFullStackedBar3DChartItem1, CreatePyramidSideBySideStackedBar3DChartItem1, CreatePyramidStackedBar3DChartItem1})
        Me.CommandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DColumn1, ChartControlCommandGalleryItemGroup3DColumn1, ChartControlCommandGalleryItemGroupCylinderColumn1, ChartControlCommandGalleryItemGroupConeColumn1, ChartControlCommandGalleryItemGroupPyramidColumn1})
        Me.CommandBarGalleryDropDown1.Manager = Nothing
        Me.CommandBarGalleryDropDown1.Name = "CommandBarGalleryDropDown1"
        '
        'CommandBarGalleryDropDown2
        '
        '
        '
        '
        CreateLineChartItem1.Caption = "Línea"
        CreateLineChartItem1.Description = "Mostrar tendencias a través del tiempo (fechas, años) sobre categorías ordenadas." & _
    " Sirve para mostrar muchos puntos de datos cuando el orden carece de importancia" & _
    "."
        CreateLineChartItem1.Hint = "Mostrar tendencias a través del tiempo (fechas, años) sobre categorías ordenadas." & _
    " Sirve para mostrar muchos puntos de datos cuando el orden carece de importancia" & _
    "."
        CreateFullStackedLineChartItem1.Caption = "Líneas Apiladas 100%"
        CreateFullStackedLineChartItem1.Description = "Muestra la tendencia de un porcentaje durante un periodo o sobre categorías orden" & _
    "adas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quizás debe considerar usando el gráfico de Área Apilada 100% en su lug" & _
    "ar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "...."
        CreateFullStackedLineChartItem1.Hint = "Muestra la tendencia de un porcentaje durante un periodo o sobre categorías orden" & _
    "adas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quizás debe considerar usando el gráfico de Área Apilada 100% en su lug" & _
    "ar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "...."
        CreateScatterLineChartItem1.Caption = "Línea Dispersión"
        CreateScatterLineChartItem1.Description = "Representa puntos de una serie en el mismo orden que la colección."
        CreateScatterLineChartItem1.Hint = "Representa puntos de una serie en el mismo orden que la colección."
        CreateSplineChartItem1.Caption = "Contorno"
        CreateSplineChartItem1.Description = "Tramar una curva ajustada a cada punto de datos de la serie."
        CreateSplineChartItem1.Hint = "Tramar una curva ajustada a cada punto de datos de la serie."
        CreateStackedLineChartItem1.Caption = "Líneas Apiladas"
        CreateStackedLineChartItem1.Description = "Muestra la tendencia de la contribución de cada valor a través del tiempo o por c" & _
    "ategorías ordenadas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quizás debería considerar el gráfico de Área Apilada en " & _
    "su lugar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    "
        CreateStackedLineChartItem1.Hint = "Muestra la tendencia de la contribución de cada valor a través del tiempo o por c" & _
    "ategorías ordenadas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quizás debería considerar el gráfico de Área Apilada en " & _
    "su lugar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    "
        CreateStepLineChartItem1.Caption = "Línea Escalonada"
        CreateStepLineChartItem1.Description = "Muestra hasta que punto los valores cambian en relación a distintos puntos en la " & _
    "misma serie"
        CreateStepLineChartItem1.Hint = "Muestra hasta que punto los valores cambian en relación a distintos puntos en la " & _
    "misma serie"
        ChartControlCommandGalleryItemGroup2DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateLineChartItem1, CreateFullStackedLineChartItem1, CreateScatterLineChartItem1, CreateSplineChartItem1, CreateStackedLineChartItem1, CreateStepLineChartItem1})
        CreateLine3DChartItem1.Caption = "Líneas 3D"
        CreateLine3DChartItem1.Description = "Mostrar cada fila o columna de datos como una cinta en 3 dimensiones en los tres " & _
    "ejes."
        CreateLine3DChartItem1.Hint = "Mostrar cada fila o columna de datos como una cinta en 3 dimensiones en los tres " & _
    "ejes."
        CreateFullStackedLine3DChartItem1.Caption = "Líneas Apiladas 3D 100%"
        CreateFullStackedLine3DChartItem1.Description = "Muestra todas las series apiladas y se emplea para comparar cuánto contribuye cad" & _
    "a serie al total agregado para los argumentos específicos (por ejemplo porcentaj" & _
    "es)."
        CreateFullStackedLine3DChartItem1.Hint = "Muestra todas las series apiladas y se emplea para comparar cuánto contribuye cad" & _
    "a serie al total agregado para los argumentos específicos (por ejemplo porcentaj" & _
    "es)."
        CreateSpline3DChartItem1.Caption = "Contorno 3D"
        CreateSpline3DChartItem1.Description = "Tramar una curva ajustada a cada punto de datos de la serie."
        CreateSpline3DChartItem1.Hint = "Tramar una curva ajustada a cada punto de datos de la serie."
        CreateStackedLine3DChartItem1.Caption = "Líneas Apiladas en 3D"
        CreateStackedLine3DChartItem1.Description = "Muestra todos los puntos de las distintas series de modo apilada. Es especialment" & _
    "e útil para comparar cuanto de cada series contribuye al total agregado para los" & _
    " argumentos específicos."
        CreateStackedLine3DChartItem1.Hint = "Muestra todos los puntos de las distintas series de modo apilada. Es especialment" & _
    "e útil para comparar cuanto de cada series contribuye al total agregado para los" & _
    " argumentos específicos."
        CreateStepLine3DChartItem1.Caption = "Línea de Escalones en 3D"
        CreateStepLine3DChartItem1.Description = "Muestra hasta que punto los valores cambian en relación a distintos puntos en la " & _
    "misma serie"
        CreateStepLine3DChartItem1.Hint = "Muestra hasta que punto los valores cambian en relación a distintos puntos en la " & _
    "misma serie"
        ChartControlCommandGalleryItemGroup3DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateLine3DChartItem1, CreateFullStackedLine3DChartItem1, CreateSpline3DChartItem1, CreateStackedLine3DChartItem1, CreateStepLine3DChartItem1})
        Me.CommandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DLine1, ChartControlCommandGalleryItemGroup3DLine1})
        Me.CommandBarGalleryDropDown2.Manager = Nothing
        Me.CommandBarGalleryDropDown2.Name = "CommandBarGalleryDropDown2"
        '
        'CommandBarGalleryDropDown3
        '
        '
        '
        '
        CreatePieChartItem1.Caption = "Tarta"
        CreatePieChartItem1.Description = "Muestra la contribución de cada valor al total." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Utiliza cuando los valores se " & _
    "pueden agregar juntos o cuando tienes solo datos de la serie y todos los valores" & _
    " son positivos."
        CreatePieChartItem1.Hint = "Muestra la contribución de cada valor al total." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Utiliza cuando los valores se " & _
    "pueden agregar juntos o cuando tienes solo datos de la serie y todos los valores" & _
    " son positivos."
        CreateDoughnutChartItem1.Caption = "Donut"
        CreateDoughnutChartItem1.Description = "Muestra la contribución de cada valor sobre el total como el gráfico de tarta, pe" & _
    "ro permite múltiples series."
        CreateDoughnutChartItem1.Hint = "Muestra la contribución de cada valor sobre el total como el gráfico de tarta, pe" & _
    "ro permite múltiples series."
        CreateNestedDoughnutChartItem1.Caption = "Anidado Donut"
        CreateNestedDoughnutChartItem1.Description = "Mostrar la contribución de cada valor a un total mientras que compararon la serie" & _
    " con una rosquilla anidado en otro."
        CreateNestedDoughnutChartItem1.Hint = "Mostrar la contribución de cada valor a un total mientras que compararon la serie" & _
    " con una rosquilla anidado en otro."
        ChartControlCommandGalleryItemGroup2DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePieChartItem1, CreateDoughnutChartItem1, CreateNestedDoughnutChartItem1})
        CreatePie3DChartItem1.Caption = "Tarta en 3D"
        CreatePie3DChartItem1.Description = "Mostrar la contribución de cada punto sobre un total."
        CreatePie3DChartItem1.Hint = "Mostrar la contribución de cada punto sobre un total."
        CreateDoughnut3DChartItem1.Caption = "Donut en 3D"
        CreateDoughnut3DChartItem1.Description = "Comparar el porcentaje de los valores de la misma categoría y mostrar con el form" & _
    "ato de tarta, pero con un agujero en medio."
        CreateDoughnut3DChartItem1.Hint = "Comparar el porcentaje de los valores de la misma categoría y mostrar con el form" & _
    "ato de tarta, pero con un agujero en medio."
        ChartControlCommandGalleryItemGroup3DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePie3DChartItem1, CreateDoughnut3DChartItem1})
        Me.CommandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DPie1, ChartControlCommandGalleryItemGroup3DPie1})
        Me.CommandBarGalleryDropDown3.Manager = Nothing
        Me.CommandBarGalleryDropDown3.Name = "CommandBarGalleryDropDown3"
        '
        'CommandBarGalleryDropDown4
        '
        '
        '
        '
        CreateRotatedBarChartItem1.Caption = "Barras"
        CreateRotatedBarChartItem1.Description = "Insert a bar chart." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bar charts are the best chart type for comparing multiple " & _
    "values."
        CreateRotatedBarChartItem1.Hint = "Insert a bar chart." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bar charts are the best chart type for comparing multiple " & _
    "values."
        CreateRotatedFullStackedBarChartItem1.Caption = "Barras Apiladas al 100%"
        CreateRotatedFullStackedBarChartItem1.Description = resources.GetString("CreateRotatedFullStackedBarChartItem1.Description")
        CreateRotatedFullStackedBarChartItem1.Hint = resources.GetString("CreateRotatedFullStackedBarChartItem1.Hint")
        CreateRotatedSideBySideFullStackedBarChartItem1.Caption = "Barras Apiladas y Agrupadas 100%"
        CreateRotatedSideBySideFullStackedBarChartItem1.Description = "Combina las ventajas de los gráficos de Barras Apiladas 100% y Barras Agrupadas, " & _
    "para poder apilar las barras y agruparlas en el mismo eje."
        CreateRotatedSideBySideFullStackedBarChartItem1.Hint = "Combina las ventajas de los gráficos de Barras Apiladas 100% y Barras Agrupadas, " & _
    "para poder apilar las barras y agruparlas en el mismo eje."
        CreateRotatedSideBySideStackedBarChartItem1.Caption = "Barras Apiladas y Agrupadas"
        CreateRotatedSideBySideStackedBarChartItem1.Description = "Combina las ventajas de los gráficos de Barras Apiladas y Barras Agrupadas, para " & _
    "poder apilar las barras y agruparlos en el mismo eje."
        CreateRotatedSideBySideStackedBarChartItem1.Hint = "Combina las ventajas de los gráficos de Barras Apiladas y Barras Agrupadas, para " & _
    "poder apilar las barras y agruparlos en el mismo eje."
        CreateRotatedStackedBarChartItem1.Caption = "Barras Apiladas"
        CreateRotatedStackedBarChartItem1.Description = "Comparar la contribución de cada valor a través de todas las categorías y mostrar" & _
    " con el formato de rectángulos horizontales."
        CreateRotatedStackedBarChartItem1.Hint = "Comparar la contribución de cada valor a través de todas las categorías y mostrar" & _
    " con el formato de rectángulos horizontales."
        ChartControlCommandGalleryItemGroup2DBar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRotatedBarChartItem1, CreateRotatedFullStackedBarChartItem1, CreateRotatedSideBySideFullStackedBarChartItem1, CreateRotatedSideBySideStackedBarChartItem1, CreateRotatedStackedBarChartItem1})
        Me.CommandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DBar1})
        Me.CommandBarGalleryDropDown4.Manager = Nothing
        Me.CommandBarGalleryDropDown4.Name = "CommandBarGalleryDropDown4"
        '
        'CommandBarGalleryDropDown5
        '
        '
        '
        '
        CreateAreaChartItem1.Caption = "Área"
        CreateAreaChartItem1.Description = "Muestra la tendencia de valores a través del tiempo o de categorías ordenadas."
        CreateAreaChartItem1.Hint = "Muestra la tendencia de valores a través del tiempo o de categorías ordenadas."
        CreateFullStackedAreaChartItem1.Caption = "Área Apliada 100%"
        CreateFullStackedAreaChartItem1.Description = "Displays the trend of the percentage each value contributes over time or categori" & _
    "es." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the trend in the proportion of each series."
        CreateFullStackedAreaChartItem1.Hint = "Displays the trend of the percentage each value contributes over time or categori" & _
    "es." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use it to emphasize the trend in the proportion of each series."
        CreateFullStackedSplineAreaChartItem1.Caption = "Área de Contorno Apilado 100%"
        CreateFullStackedSplineAreaChartItem1.Description = "Comportamiento similar a un gráfico de Área Apilada 100%, pero traza una línea a " & _
    "través de cada punto en una serie ."
        CreateFullStackedSplineAreaChartItem1.Hint = "Comportamiento similar a un gráfico de Área Apilada 100%, pero traza una línea a " & _
    "través de cada punto en una serie ."
        CreateFullStackedStepAreaChartItem1.Caption = "100% Stacked Step Area"
        CreateFullStackedStepAreaChartItem1.Description = "Se comporta semejantemente al 100% gráfico de área apilada, pero conecta los punt" & _
    "os de datos mediante líneas horizontales y verticales."
        CreateFullStackedStepAreaChartItem1.Hint = "Se comporta semejantemente al 100% gráfico de área apilada, pero conecta los punt" & _
    "os de datos mediante líneas horizontales y verticales."
        CreateSplineAreaChartItem1.Caption = "Contorno Área"
        CreateSplineAreaChartItem1.Description = "Comportamiento similar a un gráfico de Área , pero traza una línea a través de ca" & _
    "da punto en una serie ."
        CreateSplineAreaChartItem1.Hint = "Comportamiento similar a un gráfico de Área , pero traza una línea a través de ca" & _
    "da punto en una serie ."
        CreateStackedAreaChartItem1.Caption = "Área de Contorno"
        CreateStackedAreaChartItem1.Description = "Displays the trend of the contribution of each value over time or categories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
    "Use it to emphasize the trend in the total across series for one category."
        CreateStackedAreaChartItem1.Hint = "Displays the trend of the contribution of each value over time or categories." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
    "Use it to emphasize the trend in the total across series for one category."
        CreateStackedStepAreaChartItem1.Caption = "Stacked Step Area"
        CreateStackedStepAreaChartItem1.Description = "Participar igual que el gráfico de área apilada pero conecta los puntos de datos " & _
    "mediante líneas horizontales y verticales."
        CreateStackedStepAreaChartItem1.Hint = "Participar igual que el gráfico de área apilada pero conecta los puntos de datos " & _
    "mediante líneas horizontales y verticales."
        CreateStackedSplineAreaChartItem1.Caption = "Área de Contorno Apilado"
        CreateStackedSplineAreaChartItem1.Description = "Comportamiento similar a un gráfico de Área Apilada, pero traza una línea a travé" & _
    "s de cada punto en una serie ."
        CreateStackedSplineAreaChartItem1.Hint = "Comportamiento similar a un gráfico de Área Apilada, pero traza una línea a travé" & _
    "s de cada punto en una serie ."
        CreateStepAreaChartItem1.Caption = "Área de Escalón"
        CreateStepAreaChartItem1.Description = "Muestra hasta que punto los valores cambian en relación a distintos puntos de la " & _
    "misma serie"
        CreateStepAreaChartItem1.Hint = "Muestra hasta que punto los valores cambian en relación a distintos puntos de la " & _
    "misma serie"
        ChartControlCommandGalleryItemGroup2DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateAreaChartItem1, CreateFullStackedAreaChartItem1, CreateFullStackedSplineAreaChartItem1, CreateFullStackedStepAreaChartItem1, CreateSplineAreaChartItem1, CreateStackedAreaChartItem1, CreateStackedStepAreaChartItem1, CreateStackedSplineAreaChartItem1, CreateStepAreaChartItem1})
        CreateArea3DChartItem1.Caption = "Área 3D"
        CreateArea3DChartItem1.Description = resources.GetString("CreateArea3DChartItem1.Description")
        CreateArea3DChartItem1.Hint = resources.GetString("CreateArea3DChartItem1.Hint")
        CreateFullStackedArea3DChartItem1.Caption = "Área Apliada3D 100%"
        CreateFullStackedArea3DChartItem1.Description = resources.GetString("CreateFullStackedArea3DChartItem1.Description")
        CreateFullStackedArea3DChartItem1.Hint = resources.GetString("CreateFullStackedArea3DChartItem1.Hint")
        CreateFullStackedSplineArea3DChartItem1.Caption = "Área de Contorno Apilado 3D 100%"
        CreateFullStackedSplineArea3DChartItem1.Description = "Comportamiento similar a un gráfico de Área Apilada 100% en 3D, pero traza una lí" & _
    "nea a través de cada punto de los datos."
        CreateFullStackedSplineArea3DChartItem1.Hint = "Comportamiento similar a un gráfico de Área Apilada 100% en 3D, pero traza una lí" & _
    "nea a través de cada punto de los datos."
        CreateSplineArea3DChartItem1.Caption = "Área de Contorno en 3D"
        CreateSplineArea3DChartItem1.Description = "Comportamiento similar a un gráfico de Área 3D, pero tramando una curva con los p" & _
    "untos de cada serie."
        CreateSplineArea3DChartItem1.Hint = "Comportamiento similar a un gráfico de Área 3D, pero tramando una curva con los p" & _
    "untos de cada serie."
        CreateStackedArea3DChartItem1.Caption = "Área Apilada en 3D"
        CreateStackedArea3DChartItem1.Description = "Muestra una serie de áreas en un gráfico, para que cada valor de cada punto de da" & _
    "tos se agrega con los valores de datos subyacentes."
        CreateStackedArea3DChartItem1.Hint = "Muestra una serie de áreas en un gráfico, para que cada valor de cada punto de da" & _
    "tos se agrega con los valores de datos subyacentes."
        CreateStackedSplineArea3DChartItem1.Caption = "Área de Contorno Apilado en 3D"
        CreateStackedSplineArea3DChartItem1.Description = "Comportamiento similar a un gráfico de Área Apilada en 3D, pero traza una línea a" & _
    " través de cada punto en una serie ."
        CreateStackedSplineArea3DChartItem1.Hint = "Comportamiento similar a un gráfico de Área Apilada en 3D, pero traza una línea a" & _
    " través de cada punto en una serie ."
        CreateStepArea3DChartItem1.Caption = "Área de Escalones en 3D"
        CreateStepArea3DChartItem1.Description = "Muestra hasta que punto los valores cambian en relación a distintos puntos en la " & _
    "misma serie"
        CreateStepArea3DChartItem1.Hint = "Muestra hasta que punto los valores cambian en relación a distintos puntos en la " & _
    "misma serie"
        ChartControlCommandGalleryItemGroup3DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateArea3DChartItem1, CreateFullStackedArea3DChartItem1, CreateFullStackedSplineArea3DChartItem1, CreateSplineArea3DChartItem1, CreateStackedArea3DChartItem1, CreateStackedSplineArea3DChartItem1, CreateStepArea3DChartItem1})
        Me.CommandBarGalleryDropDown5.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroup2DArea1, ChartControlCommandGalleryItemGroup3DArea1})
        Me.CommandBarGalleryDropDown5.Manager = Nothing
        Me.CommandBarGalleryDropDown5.Name = "CommandBarGalleryDropDown5"
        '
        'CommandBarGalleryDropDown6
        '
        '
        '
        '
        CreatePointChartItem1.Caption = "Puntos"
        CreatePointChartItem1.Description = "Concebido para mostrar puntos individuales en la misma traza del gráfico."
        CreatePointChartItem1.Hint = "Concebido para mostrar puntos individuales en la misma traza del gráfico."
        CreateBubbleChartItem1.Caption = "Burbuja"
        CreateBubbleChartItem1.Description = "Se parece a un gráfico de Dispersión, pero compara conjuntos de tres valores en l" & _
    "ugar de dos. El tercer valor indica el valor del marcador de burbuja."
        CreateBubbleChartItem1.Hint = "Se parece a un gráfico de Dispersión, pero compara conjuntos de tres valores en l" & _
    "ugar de dos. El tercer valor indica el valor del marcador de burbuja."
        ChartControlCommandGalleryItemGroupPoint1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePointChartItem1, CreateBubbleChartItem1})
        CreateFunnelChartItem1.Caption = "Embudo"
        CreateFunnelChartItem1.Description = resources.GetString("CreateFunnelChartItem1.Description")
        CreateFunnelChartItem1.Hint = resources.GetString("CreateFunnelChartItem1.Hint")
        CreateFunnel3DChartItem1.Caption = "Embudo 3D"
        CreateFunnel3DChartItem1.Description = resources.GetString("CreateFunnel3DChartItem1.Description")
        CreateFunnel3DChartItem1.Hint = resources.GetString("CreateFunnel3DChartItem1.Hint")
        ChartControlCommandGalleryItemGroupFunnel1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateFunnelChartItem1, CreateFunnel3DChartItem1})
        CreateStockChartItem1.Caption = "Stock"
        CreateStockChartItem1.Description = resources.GetString("CreateStockChartItem1.Description")
        CreateStockChartItem1.Hint = resources.GetString("CreateStockChartItem1.Hint")
        CreateCandleStickChartItem1.Caption = "Vela"
        CreateCandleStickChartItem1.Description = resources.GetString("CreateCandleStickChartItem1.Description")
        CreateCandleStickChartItem1.Hint = resources.GetString("CreateCandleStickChartItem1.Hint")
        ChartControlCommandGalleryItemGroupFinancial1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateStockChartItem1, CreateCandleStickChartItem1})
        CreateRadarPointChartItem1.Caption = "Punto Radar"
        CreateRadarPointChartItem1.Description = "Mostrar puntos de dos o mas series para los mismos puntos de argumentos en una re" & _
    "jilla circular que contiene múltiples ejes donde se trazaran sus datos."
        CreateRadarPointChartItem1.Hint = "Mostrar puntos de dos o mas series para los mismos puntos de argumentos en una re" & _
    "jilla circular que contiene múltiples ejes donde se trazaran sus datos."
        CreateRadarLineChartItem1.Caption = "Línea Radar"
        CreateRadarLineChartItem1.Description = "Muestra tendencias para varias series y compara sus valores para los mismos punto" & _
    "s de argumentos en una rejilla circular que contiene múltiples ejes donde se tra" & _
    "zaran sus datos."
        CreateRadarLineChartItem1.Hint = "Muestra tendencias para varias series y compara sus valores para los mismos punto" & _
    "s de argumentos en una rejilla circular que contiene múltiples ejes donde se tra" & _
    "zaran sus datos."
        CreateRadarAreaChartItem1.Caption = "Área Radar"
        CreateRadarAreaChartItem1.Description = "Mostrar las series como una área rellena en una rejilla circular que contiene múl" & _
    "tiples ejes, a través de los cuales se tramará los puntos."
        CreateRadarAreaChartItem1.Hint = "Mostrar las series como una área rellena en una rejilla circular que contiene múl" & _
    "tiples ejes, a través de los cuales se tramará los puntos."
        CreateRadarRangeAreaChartItem1.Caption = "Radar Range Area"
        CreateRadarRangeAreaChartItem1.Description = resources.GetString("CreateRadarRangeAreaChartItem1.Description")
        CreateRadarRangeAreaChartItem1.Hint = resources.GetString("CreateRadarRangeAreaChartItem1.Hint")
        CreateScatterRadarLineChartItem1.Caption = "Scatter Radar Line"
        CreateScatterRadarLineChartItem1.Description = resources.GetString("CreateScatterRadarLineChartItem1.Description")
        CreateScatterRadarLineChartItem1.Hint = resources.GetString("CreateScatterRadarLineChartItem1.Hint")
        ChartControlCommandGalleryItemGroupRadar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRadarPointChartItem1, CreateRadarLineChartItem1, CreateRadarAreaChartItem1, CreateRadarRangeAreaChartItem1, CreateScatterRadarLineChartItem1})
        CreatePolarPointChartItem1.Caption = "Punto Polar"
        CreatePolarPointChartItem1.Description = "Mostrar puntos de uno o mas series en el mismo gráfico circular basándose en los " & _
    "ángulos."
        CreatePolarPointChartItem1.Hint = "Mostrar puntos de uno o mas series en el mismo gráfico circular basándose en los " & _
    "ángulos."
        CreatePolarLineChartItem1.Caption = "Línea Polar"
        CreatePolarLineChartItem1.Description = "Mostrar tendencias para varias series y comparar sus valores para los mismos punt" & _
    "os de argumentos en un gráfico circular basándose en los ángulos."
        CreatePolarLineChartItem1.Hint = "Mostrar tendencias para varias series y comparar sus valores para los mismos punt" & _
    "os de argumentos en un gráfico circular basándose en los ángulos."
        CreatePolarAreaChartItem1.Caption = "Área Polar"
        CreatePolarAreaChartItem1.Description = "Mostrar series como zonas en un gráfico circular basándose en los ángulos."
        CreatePolarAreaChartItem1.Hint = "Mostrar series como zonas en un gráfico circular basándose en los ángulos."
        CreatePolarRangeAreaChartItem1.Caption = "Polar Range Area"
        CreatePolarRangeAreaChartItem1.Description = resources.GetString("CreatePolarRangeAreaChartItem1.Description")
        CreatePolarRangeAreaChartItem1.Hint = resources.GetString("CreatePolarRangeAreaChartItem1.Hint")
        CreateScatterPolarLineChartItem1.Caption = "Scatte Polar Line"
        CreateScatterPolarLineChartItem1.Description = resources.GetString("CreateScatterPolarLineChartItem1.Description")
        CreateScatterPolarLineChartItem1.Hint = resources.GetString("CreateScatterPolarLineChartItem1.Hint")
        ChartControlCommandGalleryItemGroupPolar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreatePolarPointChartItem1, CreatePolarLineChartItem1, CreatePolarAreaChartItem1, CreatePolarRangeAreaChartItem1, CreateScatterPolarLineChartItem1})
        CreateRangeBarChartItem1.Caption = "Rango de Columnas"
        CreateRangeBarChartItem1.Description = "Mostrar columnas verticales en el eje  Y (el eje de los valores). Cada columna re" & _
    "presenta un rango de datos para cada valor de argumento."
        CreateRangeBarChartItem1.Hint = "Mostrar columnas verticales en el eje  Y (el eje de los valores). Cada columna re" & _
    "presenta un rango de datos para cada valor de argumento."
        CreateSideBySideRangeBarChartItem1.Caption = "Columnas Agrupadas por Rango"
        CreateSideBySideRangeBarChartItem1.Description = "Mostrar columnas de actividad de series distintas agrupadas por sus argumentos. C" & _
    "ada columna representa un rango de datos con dos valores cada uno."
        CreateSideBySideRangeBarChartItem1.Hint = "Mostrar columnas de actividad de series distintas agrupadas por sus argumentos. C" & _
    "ada columna representa un rango de datos con dos valores cada uno."
        CreateRangeAreaChartItem1.Caption = "Área de Rango"
        CreateRangeAreaChartItem1.Description = resources.GetString("CreateRangeAreaChartItem1.Description")
        CreateRangeAreaChartItem1.Hint = resources.GetString("CreateRangeAreaChartItem1.Hint")
        CreateRangeArea3DChartItem1.Caption = "Área de Rango en 3D"
        CreateRangeArea3DChartItem1.Description = resources.GetString("CreateRangeArea3DChartItem1.Description")
        CreateRangeArea3DChartItem1.Hint = resources.GetString("CreateRangeArea3DChartItem1.Hint")
        ChartControlCommandGalleryItemGroupRange1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateRangeBarChartItem1, CreateSideBySideRangeBarChartItem1, CreateRangeAreaChartItem1, CreateRangeArea3DChartItem1})
        CreateGanttChartItem1.Caption = "Gantt"
        CreateGanttChartItem1.Description = "Trazar distintas actividades durante el mismo periodo."
        CreateGanttChartItem1.Hint = "Trazar distintas actividades durante el mismo periodo."
        CreateSideBySideGanttChartItem1.Caption = "Gantt Agrupado"
        CreateSideBySideGanttChartItem1.Description = resources.GetString("CreateSideBySideGanttChartItem1.Description")
        CreateSideBySideGanttChartItem1.Hint = resources.GetString("CreateSideBySideGanttChartItem1.Hint")
        ChartControlCommandGalleryItemGroupGantt1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {CreateGanttChartItem1, CreateSideBySideGanttChartItem1})
        Me.CommandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {ChartControlCommandGalleryItemGroupPoint1, ChartControlCommandGalleryItemGroupFunnel1, ChartControlCommandGalleryItemGroupFinancial1, ChartControlCommandGalleryItemGroupRadar1, ChartControlCommandGalleryItemGroupPolar1, ChartControlCommandGalleryItemGroupRange1, ChartControlCommandGalleryItemGroupGantt1})
        Me.CommandBarGalleryDropDown6.Manager = Nothing
        Me.CommandBarGalleryDropDown6.Name = "CommandBarGalleryDropDown6"
        '
        'CommandBarGalleryDropDown7
        '
        Me.CommandBarGalleryDropDown7.Manager = Nothing
        Me.CommandBarGalleryDropDown7.Name = "CommandBarGalleryDropDown7"
        '
        'XML_Proveidors
        '
        Me.XML_Proveidors.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XML_Proveidors.Location = New System.Drawing.Point(496, 16)
        Me.XML_Proveidors.Name = "XML_Proveidors"
        Me.XML_Proveidors.Size = New System.Drawing.Size(110, 25)
        Me.XML_Proveidors.TabIndex = 191
        Me.XML_Proveidors.Text = "Exportar XML"
        Me.XML_Proveidors.UseVisualStyleBackColor = True
        '
        'TE_RutaExportacio
        '
        Me.TE_RutaExportacio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TE_RutaExportacio.Location = New System.Drawing.Point(612, 18)
        Me.TE_RutaExportacio.MaxLength = 3999
        Me.TE_RutaExportacio.Name = "TE_RutaExportacio"
        Me.TE_RutaExportacio.ReadOnly = True
        Me.TE_RutaExportacio.Size = New System.Drawing.Size(380, 21)
        Me.TE_RutaExportacio.TabIndex = 264
        Me.TE_RutaExportacio.Text = "TE_RutaExportacio"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraLabel7.Location = New System.Drawing.Point(612, 3)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(155, 16)
        Me.UltraLabel7.TabIndex = 265
        Me.UltraLabel7.Text = "*Ruta d'exportación:"
        '
        'frmTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 692)
        Me.Controls.Add(Me.TE_RutaExportacio)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.XML_Proveidors)
        Me.Controls.Add(Me.UltraTabControl2)
        Me.KeyPreview = True
        Me.Name = "frmTarifas"
        Me.Text = "Tarifas"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.UltraTabControl2, 0)
        Me.Controls.SetChildIndex(Me.XML_Proveidors, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel7, 0)
        Me.Controls.SetChildIndex(Me.TE_RutaExportacio, 0)
        Me.UltraTabPageControl9.ResumeLayout(False)
        Me.UltraTabPageControl8.ResumeLayout(False)
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c_KilosPorProveedorArticuloAñoMesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraTabPageControl4.PerformLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        CType(Me.C_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.DT_Modificacio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabPageControl10.ResumeLayout(False)
        Me.UltraTabPageControl10.PerformLayout()
        CType(Me.C_CambioAlbaran_Articulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_CambioAlbaran_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_CambioAlbaran_FechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_CambioAlbaran_FechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        CType(Me.ChartBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_RutaExportacio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents B_Producte_DesSeleccionarTots As System.Windows.Forms.Button
    Friend WithEvents B_Producte_DesSeleccionar As System.Windows.Forms.Button
    Friend WithEvents B_Producte_SeleccionarTots As System.Windows.Forms.Button
    Friend WithEvents B_Producte_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents GRD_ArticulosSeleccionados As M_UltraGrid.m_UltraGrid
    Friend WithEvents GRD_ArticulosTodos As M_UltraGrid.m_UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GRD_ProveedoresSeleccionados As M_UltraGrid.m_UltraGrid
    Friend WithEvents GRD_ProveedoresTodos As M_UltraGrid.m_UltraGrid
    Friend WithEvents B_Aplicar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents T_Import As M_MaskEditor.m_MaskEditor
    Friend WithEvents B_Proveidor_DesSeleccionarTots As System.Windows.Forms.Button
    Friend WithEvents B_Proveidor_DesSeleccionar As System.Windows.Forms.Button
    Friend WithEvents B_Proveidor_SeleccionarTots As System.Windows.Forms.Button
    Friend WithEvents B_Proveidor_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents C_Proveedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents GRD_Individual As M_UltraGrid.m_UltraGrid
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GRD_Messes As M_UltraGrid.m_UltraGrid
    Friend WithEvents GRD_Albarans As M_UltraGrid.m_UltraGrid
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents CommandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown6 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents CommandBarGalleryDropDown7 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
    Friend WithEvents ChartBarController1 As DevExpress.XtraCharts.UI.ChartBarController
    Friend WithEvents c_KilosPorProveedorArticuloAñoMesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GRD_Cambio_Precios As M_UltraGrid.m_UltraGrid
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents C_CambioAlbaran_Articulo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_CambioAlbaran_Proveedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents B_CambioAlbaran_Aplicar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents T_CambioAlbaran_NuevoPrecio As M_MaskEditor.m_MaskEditor
    Friend WithEvents B_CambioAlbaran_Buscar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents DT_CambioAlbaran_FechaFin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DT_CambioAlbaran_FechaInicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents GRD_CambioAlbaran As M_UltraGrid.m_UltraGrid
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DT_Modificacio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel35 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents XML_Proveidors As System.Windows.Forms.Button
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GRD_CambiosPrecionManuales As M_UltraGrid.m_UltraGrid
    Friend WithEvents TE_RutaExportacio As M_TextEditor.m_TextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
End Class
