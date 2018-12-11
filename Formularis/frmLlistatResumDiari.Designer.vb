<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLlistatResumDiari
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.CodigoArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DescripcionArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.FechaAlbaran = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Matricula = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.NumeroAlbaran = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Proveedor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Unidades = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.CodigoArticulo1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DescripcionArticulo1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.FechaAlbaran1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Matricula1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.NumeroAlbaran1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Proveedor1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Unidades1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalUnidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalUnidadesHastaHoy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BandedGridView3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.BandedGridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn11 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn12 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn13 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn14 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Validar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DT_Fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TE_RutaExportacio = New M_TextEditor.m_TextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_Planta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.C_Proveedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Detalle = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Table2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_RutaExportacio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.C_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.pMode_Toolbar = m_ToolForm.clsToolForm.Enum_ToolMode.Sortir
        Me.ToolForm.Size = New System.Drawing.Size(380, 24)
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.Table2})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.FechaAlbaran, Me.NumeroAlbaran, Me.Proveedor, Me.Matricula, Me.CodigoArticulo, Me.DescripcionArticulo, Me.Unidades})
        Me.BandedGridView1.GridControl = Me.GridControl1
        Me.BandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsMenu.EnableFooterMenu = False
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.RowAutoHeight = True
        Me.BandedGridView1.OptionsView.ShowFooter = True
        '
        'CodigoArticulo
        '
        Me.CodigoArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.CodigoArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CodigoArticulo.Caption = "Código Artículo"
        Me.CodigoArticulo.FieldName = "CodigoArticulo"
        Me.CodigoArticulo.Name = "CodigoArticulo"
        Me.CodigoArticulo.OptionsColumn.AllowEdit = False
        Me.CodigoArticulo.Visible = True
        Me.CodigoArticulo.Width = 89
        '
        'DescripcionArticulo
        '
        Me.DescripcionArticulo.Caption = "Descripción Artículo"
        Me.DescripcionArticulo.FieldName = "DescripcionArticulo"
        Me.DescripcionArticulo.Name = "DescripcionArticulo"
        Me.DescripcionArticulo.OptionsColumn.AllowEdit = False
        Me.DescripcionArticulo.Visible = True
        Me.DescripcionArticulo.Width = 186
        '
        'FechaAlbaran
        '
        Me.FechaAlbaran.AppearanceCell.Options.UseTextOptions = True
        Me.FechaAlbaran.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FechaAlbaran.Caption = "Fecha Albarán"
        Me.FechaAlbaran.FieldName = "FechaAlbaran"
        Me.FechaAlbaran.Name = "FechaAlbaran"
        Me.FechaAlbaran.OptionsColumn.AllowEdit = False
        Me.FechaAlbaran.Visible = True
        Me.FechaAlbaran.Width = 94
        '
        'Matricula
        '
        Me.Matricula.Caption = "Matrícula"
        Me.Matricula.FieldName = "Matricula"
        Me.Matricula.Name = "Matricula"
        Me.Matricula.OptionsColumn.AllowEdit = False
        Me.Matricula.Visible = True
        Me.Matricula.Width = 108
        '
        'NumeroAlbaran
        '
        Me.NumeroAlbaran.Caption = "Nº Albarán"
        Me.NumeroAlbaran.DisplayFormat.FormatString = "###,###,##0.##"
        Me.NumeroAlbaran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NumeroAlbaran.FieldName = "NumeroAlbaran"
        Me.NumeroAlbaran.Name = "NumeroAlbaran"
        Me.NumeroAlbaran.OptionsColumn.AllowEdit = False
        Me.NumeroAlbaran.Visible = True
        Me.NumeroAlbaran.Width = 97
        '
        'Proveedor
        '
        Me.Proveedor.Caption = "Proveedor"
        Me.Proveedor.FieldName = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.OptionsColumn.AllowEdit = False
        Me.Proveedor.Visible = True
        Me.Proveedor.Width = 166
        '
        'Unidades
        '
        Me.Unidades.Caption = "Kg"
        Me.Unidades.DisplayFormat.FormatString = "###,###,##0.##"
        Me.Unidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Unidades.FieldName = "Unidades"
        Me.Unidades.Name = "Unidades"
        Me.Unidades.OptionsColumn.AllowEdit = False
        Me.Unidades.Visible = True
        Me.Unidades.Width = 91
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.BandedGridView1
        GridLevelNode1.RelationName = "Movimientos del mes"
        GridLevelNode2.LevelTemplate = Me.BandedGridView2
        GridLevelNode2.RelationName = "Movimientos del día"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GridControl1.Location = New System.Drawing.Point(3, 16)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(619, 519)
        Me.GridControl1.TabIndex = 191
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView2, Me.GridView1, Me.GridView3, Me.BandedGridView1})
        '
        'BandedGridView2
        '
        Me.BandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.Detalle})
        Me.BandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.FechaAlbaran1, Me.NumeroAlbaran1, Me.Proveedor1, Me.Matricula1, Me.CodigoArticulo1, Me.DescripcionArticulo1, Me.Unidades1})
        Me.BandedGridView2.GridControl = Me.GridControl1
        Me.BandedGridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.BandedGridView2.Name = "BandedGridView2"
        Me.BandedGridView2.OptionsMenu.EnableFooterMenu = False
        Me.BandedGridView2.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView2.OptionsView.RowAutoHeight = True
        Me.BandedGridView2.OptionsView.ShowFooter = True
        '
        'CodigoArticulo1
        '
        Me.CodigoArticulo1.AppearanceCell.Options.UseTextOptions = True
        Me.CodigoArticulo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CodigoArticulo1.Caption = "Código Artículo"
        Me.CodigoArticulo1.FieldName = "CodigoArticulo"
        Me.CodigoArticulo1.Name = "CodigoArticulo1"
        Me.CodigoArticulo1.OptionsColumn.AllowEdit = False
        Me.CodigoArticulo1.Visible = True
        Me.CodigoArticulo1.Width = 87
        '
        'DescripcionArticulo1
        '
        Me.DescripcionArticulo1.Caption = "Descripción Artículo"
        Me.DescripcionArticulo1.FieldName = "DescripcionArticulo"
        Me.DescripcionArticulo1.Name = "DescripcionArticulo1"
        Me.DescripcionArticulo1.OptionsColumn.AllowEdit = False
        Me.DescripcionArticulo1.Visible = True
        Me.DescripcionArticulo1.Width = 192
        '
        'FechaAlbaran1
        '
        Me.FechaAlbaran1.AppearanceCell.Options.UseTextOptions = True
        Me.FechaAlbaran1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FechaAlbaran1.Caption = "Fecha Albarán"
        Me.FechaAlbaran1.FieldName = "FechaAlbaran"
        Me.FechaAlbaran1.Name = "FechaAlbaran1"
        Me.FechaAlbaran1.OptionsColumn.AllowEdit = False
        Me.FechaAlbaran1.Visible = True
        Me.FechaAlbaran1.Width = 91
        '
        'Matricula1
        '
        Me.Matricula1.Caption = "Matrícula"
        Me.Matricula1.FieldName = "Matricula"
        Me.Matricula1.Name = "Matricula1"
        Me.Matricula1.OptionsColumn.AllowEdit = False
        Me.Matricula1.Visible = True
        Me.Matricula1.Width = 111
        '
        'NumeroAlbaran1
        '
        Me.NumeroAlbaran1.Caption = "Nº Albarán"
        Me.NumeroAlbaran1.FieldName = "NumeroAlbaran"
        Me.NumeroAlbaran1.Name = "NumeroAlbaran1"
        Me.NumeroAlbaran1.OptionsColumn.AllowEdit = False
        Me.NumeroAlbaran1.Visible = True
        Me.NumeroAlbaran1.Width = 96
        '
        'Proveedor1
        '
        Me.Proveedor1.Caption = "Proveedor"
        Me.Proveedor1.FieldName = "Proveedor"
        Me.Proveedor1.Name = "Proveedor1"
        Me.Proveedor1.OptionsColumn.AllowEdit = False
        Me.Proveedor1.Visible = True
        Me.Proveedor1.Width = 168
        '
        'Unidades1
        '
        Me.Unidades1.Caption = "Kg"
        Me.Unidades1.DisplayFormat.FormatString = "###,###,##0.##"
        Me.Unidades1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Unidades1.FieldName = "Unidades"
        Me.Unidades1.Name = "Unidades1"
        Me.Unidades1.OptionsColumn.AllowEdit = False
        Me.Unidades1.Visible = True
        Me.Unidades1.Width = 92
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Codigo, Me.Descripcion, Me.TotalUnidades, Me.TotalUnidadesHastaHoy})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'Codigo
        '
        Me.Codigo.AppearanceCell.Options.UseTextOptions = True
        Me.Codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Codigo.Caption = "Código Artículo"
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.OptionsColumn.AllowEdit = False
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 0
        Me.Codigo.Width = 102
        '
        'Descripcion
        '
        Me.Descripcion.Caption = "Descripción Artículo"
        Me.Descripcion.FieldName = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.OptionsColumn.AllowEdit = False
        Me.Descripcion.Visible = True
        Me.Descripcion.VisibleIndex = 1
        Me.Descripcion.Width = 229
        '
        'TotalUnidades
        '
        Me.TotalUnidades.Caption = "Total día"
        Me.TotalUnidades.DisplayFormat.FormatString = "###,###,##0.##"
        Me.TotalUnidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalUnidades.FieldName = "TotalUnidades"
        Me.TotalUnidades.Name = "TotalUnidades"
        Me.TotalUnidades.OptionsColumn.AllowEdit = False
        Me.TotalUnidades.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalUnidades", "SUMA={0:###,###,##0.##}")})
        Me.TotalUnidades.Visible = True
        Me.TotalUnidades.VisibleIndex = 2
        Me.TotalUnidades.Width = 118
        '
        'TotalUnidadesHastaHoy
        '
        Me.TotalUnidadesHastaHoy.Caption = "Total mes"
        Me.TotalUnidadesHastaHoy.DisplayFormat.FormatString = "###,###,##0.##"
        Me.TotalUnidadesHastaHoy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalUnidadesHastaHoy.FieldName = "TotalUnidadesHastaHoy"
        Me.TotalUnidadesHastaHoy.Name = "TotalUnidadesHastaHoy"
        Me.TotalUnidadesHastaHoy.OptionsColumn.AllowEdit = False
        Me.TotalUnidadesHastaHoy.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalUnidadesHastaHoy", "SUMA={0:###,###,##0.##}")})
        Me.TotalUnidadesHastaHoy.Visible = True
        Me.TotalUnidadesHastaHoy.VisibleIndex = 3
        Me.TotalUnidadesHastaHoy.Width = 182
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        '
        'BandedGridView3
        '
        Me.BandedGridView3.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView3.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn2, Me.BandedGridColumn1, Me.BandedGridColumn3, Me.BandedGridColumn4, Me.BandedGridColumn5, Me.BandedGridColumn6, Me.BandedGridColumn7})
        Me.BandedGridView3.GridControl = Me.GridControl2
        Me.BandedGridView3.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.BandedGridView3.Name = "BandedGridView3"
        Me.BandedGridView3.OptionsMenu.EnableFooterMenu = False
        Me.BandedGridView3.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView3.OptionsView.RowAutoHeight = True
        Me.BandedGridView3.OptionsView.ShowFooter = True
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.Caption = "Nº Albarán"
        Me.BandedGridColumn1.DisplayFormat.FormatString = "###,###,##0.##"
        Me.BandedGridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn1.FieldName = "NumeroAlbaran"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn1.Visible = True
        Me.BandedGridColumn1.Width = 101
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn2.Caption = "Fecha Albarán"
        Me.BandedGridColumn2.FieldName = "FechaAlbaran"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 87
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.Caption = "Client"
        Me.BandedGridColumn3.FieldName = "RazonSocial"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.Width = 166
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.Caption = "Matrícula"
        Me.BandedGridColumn4.FieldName = "Matricula"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn4.Visible = True
        Me.BandedGridColumn4.Width = 108
        '
        'BandedGridColumn5
        '
        Me.BandedGridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BandedGridColumn5.Caption = "Código Artículo"
        Me.BandedGridColumn5.FieldName = "CodigoArticulo"
        Me.BandedGridColumn5.Name = "BandedGridColumn5"
        Me.BandedGridColumn5.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn5.Visible = True
        Me.BandedGridColumn5.Width = 90
        '
        'BandedGridColumn6
        '
        Me.BandedGridColumn6.Caption = "Descripción Artículo"
        Me.BandedGridColumn6.FieldName = "DescripcionArticulo"
        Me.BandedGridColumn6.Name = "BandedGridColumn6"
        Me.BandedGridColumn6.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn6.Visible = True
        Me.BandedGridColumn6.Width = 204
        '
        'BandedGridColumn7
        '
        Me.BandedGridColumn7.Caption = "Kg"
        Me.BandedGridColumn7.DisplayFormat.FormatString = "###,###,##0.##"
        Me.BandedGridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn7.FieldName = "Unidades"
        Me.BandedGridColumn7.Name = "BandedGridColumn7"
        Me.BandedGridColumn7.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn7.Visible = True
        Me.BandedGridColumn7.Width = 84
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode3.LevelTemplate = Me.BandedGridView3
        GridLevelNode3.RelationName = "Movimientos del mes"
        GridLevelNode4.LevelTemplate = Me.BandedGridView4
        GridLevelNode4.RelationName = "Movimientos del día"
        Me.GridControl2.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3, GridLevelNode4})
        Me.GridControl2.Location = New System.Drawing.Point(3, 16)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(606, 519)
        Me.GridControl2.TabIndex = 192
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView4, Me.GridView2, Me.BandedGridView3})
        '
        'BandedGridView4
        '
        Me.BandedGridView4.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.BandedGridView4.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn9, Me.BandedGridColumn8, Me.BandedGridColumn10, Me.BandedGridColumn11, Me.BandedGridColumn12, Me.BandedGridColumn13, Me.BandedGridColumn14})
        Me.BandedGridView4.GridControl = Me.GridControl2
        Me.BandedGridView4.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.BandedGridView4.Name = "BandedGridView4"
        Me.BandedGridView4.OptionsMenu.EnableFooterMenu = False
        Me.BandedGridView4.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView4.OptionsView.RowAutoHeight = True
        Me.BandedGridView4.OptionsView.ShowFooter = True
        '
        'BandedGridColumn8
        '
        Me.BandedGridColumn8.Caption = "Nº Albarán"
        Me.BandedGridColumn8.FieldName = "NumeroAlbaran"
        Me.BandedGridColumn8.Name = "BandedGridColumn8"
        Me.BandedGridColumn8.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn8.Visible = True
        Me.BandedGridColumn8.Width = 95
        '
        'BandedGridColumn9
        '
        Me.BandedGridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn9.Caption = "Fecha Albarán"
        Me.BandedGridColumn9.FieldName = "FechaAlbaran"
        Me.BandedGridColumn9.Name = "BandedGridColumn9"
        Me.BandedGridColumn9.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn9.Visible = True
        Me.BandedGridColumn9.Width = 89
        '
        'BandedGridColumn10
        '
        Me.BandedGridColumn10.Caption = "Client"
        Me.BandedGridColumn10.FieldName = "RazonSocial"
        Me.BandedGridColumn10.Name = "BandedGridColumn10"
        Me.BandedGridColumn10.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn10.Visible = True
        Me.BandedGridColumn10.Width = 158
        '
        'BandedGridColumn11
        '
        Me.BandedGridColumn11.Caption = "Matrícula"
        Me.BandedGridColumn11.FieldName = "Matricula"
        Me.BandedGridColumn11.Name = "BandedGridColumn11"
        Me.BandedGridColumn11.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn11.Visible = True
        Me.BandedGridColumn11.Width = 79
        '
        'BandedGridColumn12
        '
        Me.BandedGridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.BandedGridColumn12.Caption = "Código Artículo"
        Me.BandedGridColumn12.FieldName = "CodigoArticulo"
        Me.BandedGridColumn12.Name = "BandedGridColumn12"
        Me.BandedGridColumn12.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn12.Visible = True
        Me.BandedGridColumn12.Width = 95
        '
        'BandedGridColumn13
        '
        Me.BandedGridColumn13.Caption = "Descripción Artículo"
        Me.BandedGridColumn13.FieldName = "DescripcionArticulo"
        Me.BandedGridColumn13.Name = "BandedGridColumn13"
        Me.BandedGridColumn13.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn13.Visible = True
        Me.BandedGridColumn13.Width = 228
        '
        'BandedGridColumn14
        '
        Me.BandedGridColumn14.Caption = "Kg"
        Me.BandedGridColumn14.DisplayFormat.FormatString = "###,###,##0.##"
        Me.BandedGridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn14.FieldName = "Unidades"
        Me.BandedGridColumn14.Name = "BandedGridColumn14"
        Me.BandedGridColumn14.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn14.Visible = True
        Me.BandedGridColumn14.Width = 92
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsMenu.EnableFooterMenu = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.Caption = "Código Artículo"
        Me.GridColumn1.FieldName = "Codigo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 102
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción Artículo"
        Me.GridColumn2.FieldName = "Descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 229
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Total día"
        Me.GridColumn3.DisplayFormat.FormatString = "###,###,##0.##"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "TotalUnidades"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalUnidades", "SUMA={0:###,###,##0.##}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 118
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Total mes"
        Me.GridColumn4.DisplayFormat.FormatString = "###,###,##0.##"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "TotalUnidadesHastaHoy"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalUnidadesHastaHoy", "SUMA={0:###,###,##0.##}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 182
        '
        'Validar
        '
        Me.Validar.Location = New System.Drawing.Point(611, 52)
        Me.Validar.Name = "Validar"
        Me.Validar.Size = New System.Drawing.Size(72, 25)
        Me.Validar.TabIndex = 3
        Me.Validar.Text = "Cargar"
        Me.Validar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DT_Fecha
        '
        Me.DT_Fecha.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Fecha.Location = New System.Drawing.Point(10, 56)
        Me.DT_Fecha.MaskInput = "{date}"
        Me.DT_Fecha.Name = "DT_Fecha"
        Me.DT_Fecha.Size = New System.Drawing.Size(80, 21)
        Me.DT_Fecha.TabIndex = 186
        Me.DT_Fecha.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(10, 41)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel10.TabIndex = 187
        Me.UltraLabel10.Text = "*Fecha:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 25)
        Me.Button1.TabIndex = 190
        Me.Button1.Text = "Exportar Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TE_RutaExportacio
        '
        Me.TE_RutaExportacio.Location = New System.Drawing.Point(6, 36)
        Me.TE_RutaExportacio.MaxLength = 3999
        Me.TE_RutaExportacio.Name = "TE_RutaExportacio"
        Me.TE_RutaExportacio.ReadOnly = True
        Me.TE_RutaExportacio.Size = New System.Drawing.Size(294, 21)
        Me.TE_RutaExportacio.TabIndex = 262
        Me.TE_RutaExportacio.Text = "TE_RutaExportacio"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 21)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(155, 16)
        Me.UltraLabel1.TabIndex = 263
        Me.UltraLabel1.Text = "*Ruta d'exportación:"
        '
        'C_Planta
        '
        Me.C_Planta.Location = New System.Drawing.Point(105, 56)
        Me.C_Planta.Name = "C_Planta"
        Me.C_Planta.ReadOnly = True
        Me.C_Planta.Size = New System.Drawing.Size(165, 21)
        Me.C_Planta.TabIndex = 264
        Me.C_Planta.Text = "C_Planta"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(105, 41)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel6.TabIndex = 265
        Me.UltraLabel6.Text = "*Planta:"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.TE_RutaExportacio)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.Button1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(866, 22)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(385, 65)
        Me.UltraGroupBox1.TabIndex = 318
        Me.UltraGroupBox1.Text = "Exportación"
        Me.UltraGroupBox1.Visible = False
        '
        'C_Proveedor
        '
        Me.C_Proveedor.Location = New System.Drawing.Point(285, 56)
        Me.C_Proveedor.Name = "C_Proveedor"
        Me.C_Proveedor.Size = New System.Drawing.Size(310, 21)
        Me.C_Proveedor.TabIndex = 319
        Me.C_Proveedor.Text = "C_Proveedor"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(285, 41)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel2.TabIndex = 320
        Me.UltraLabel2.Text = "Proveedor:"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.GridControl1)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(625, 538)
        Me.UltraGroupBox2.TabIndex = 321
        Me.UltraGroupBox2.Text = "Entradas"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 85)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraGroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraGroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1241, 538)
        Me.SplitContainer1.SplitterDistance = 625
        Me.SplitContainer1.TabIndex = 322
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.GridControl2)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(612, 538)
        Me.UltraGroupBox3.TabIndex = 323
        Me.UltraGroupBox3.Text = "Salidas"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Detalle"
        Me.GridBand1.Columns.Add(Me.BandedGridColumn1)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn2)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn3)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn4)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn5)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn6)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn7)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 840
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "Detalle"
        Me.GridBand2.Columns.Add(Me.BandedGridColumn8)
        Me.GridBand2.Columns.Add(Me.BandedGridColumn9)
        Me.GridBand2.Columns.Add(Me.BandedGridColumn10)
        Me.GridBand2.Columns.Add(Me.BandedGridColumn11)
        Me.GridBand2.Columns.Add(Me.BandedGridColumn12)
        Me.GridBand2.Columns.Add(Me.BandedGridColumn13)
        Me.GridBand2.Columns.Add(Me.BandedGridColumn14)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.VisibleIndex = 0
        Me.GridBand2.Width = 836
        '
        'Detalle
        '
        Me.Detalle.Caption = "Detalle"
        Me.Detalle.Columns.Add(Me.NumeroAlbaran1)
        Me.Detalle.Columns.Add(Me.FechaAlbaran1)
        Me.Detalle.Columns.Add(Me.Proveedor1)
        Me.Detalle.Columns.Add(Me.Matricula1)
        Me.Detalle.Columns.Add(Me.CodigoArticulo1)
        Me.Detalle.Columns.Add(Me.DescripcionArticulo1)
        Me.Detalle.Columns.Add(Me.Unidades1)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.VisibleIndex = 0
        Me.Detalle.Width = 837
        '
        'Table2
        '
        Me.Table2.Caption = "Detalle"
        Me.Table2.Columns.Add(Me.NumeroAlbaran)
        Me.Table2.Columns.Add(Me.FechaAlbaran)
        Me.Table2.Columns.Add(Me.Proveedor)
        Me.Table2.Columns.Add(Me.Matricula)
        Me.Table2.Columns.Add(Me.CodigoArticulo)
        Me.Table2.Columns.Add(Me.DescripcionArticulo)
        Me.Table2.Columns.Add(Me.Unidades)
        Me.Table2.Name = "Table2"
        Me.Table2.VisibleIndex = 0
        Me.Table2.Width = 831
        '
        'frmLlistatResumDiari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 635)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.C_Proveedor)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.C_Planta)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.DT_Fecha)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.Validar)
        Me.KeyPreview = True
        Me.Name = "frmLlistatResumDiari"
        Me.Text = "Resum diari"
        Me.Controls.SetChildIndex(Me.Validar, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel10, 0)
        Me.Controls.SetChildIndex(Me.DT_Fecha, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel6, 0)
        Me.Controls.SetChildIndex(Me.C_Planta, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel2, 0)
        Me.Controls.SetChildIndex(Me.C_Proveedor, 0)
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_RutaExportacio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.C_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Validar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DT_Fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalUnidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TE_RutaExportacio As M_TextEditor.m_TextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_Planta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents C_Proveedor As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents FechaAlbaran As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents NumeroAlbaran As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Proveedor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Matricula As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CodigoArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DescripcionArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Unidades As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TotalUnidadesHastaHoy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents FechaAlbaran1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents NumeroAlbaran1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Proveedor1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Matricula1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CodigoArticulo1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DescripcionArticulo1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Unidades1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridView4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents BandedGridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn11 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn12 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn13 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn14 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Table2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Detalle As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
