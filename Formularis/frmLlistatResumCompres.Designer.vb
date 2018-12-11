<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmllistatResumCompres
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
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.Table2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.NumeroAlbaran = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.FechaAlbaran = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Proveedor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Matricula = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.CodigoArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DescripcionArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Unidades = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BaseImponible = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalUnidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalBaseImponible = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Validar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DT_Fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_Inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TE_RutaExportacio = New M_TextEditor.m_TextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_Planta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.C_Proveedor = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_RutaExportacio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.C_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.FechaAlbaran, Me.NumeroAlbaran, Me.Proveedor, Me.Matricula, Me.CodigoArticulo, Me.DescripcionArticulo, Me.Unidades, Me.BaseImponible})
        Me.BandedGridView1.GridControl = Me.GridControl1
        Me.BandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsMenu.EnableFooterMenu = False
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.RowAutoHeight = True
        Me.BandedGridView1.OptionsView.ShowFooter = True
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
        Me.Table2.Columns.Add(Me.BaseImponible)
        Me.Table2.Name = "Table2"
        Me.Table2.VisibleIndex = 0
        Me.Table2.Width = 905
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
        Me.NumeroAlbaran.Width = 74
        '
        'FechaAlbaran
        '
        Me.FechaAlbaran.Caption = "Fecha Albarán"
        Me.FechaAlbaran.FieldName = "FechaAlbaran"
        Me.FechaAlbaran.Name = "FechaAlbaran"
        Me.FechaAlbaran.Visible = True
        Me.FechaAlbaran.Width = 81
        '
        'Proveedor
        '
        Me.Proveedor.Caption = "Proveedor"
        Me.Proveedor.FieldName = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.OptionsColumn.AllowEdit = False
        Me.Proveedor.Visible = True
        Me.Proveedor.Width = 170
        '
        'Matricula
        '
        Me.Matricula.Caption = "Matrícula"
        Me.Matricula.FieldName = "Matricula"
        Me.Matricula.Name = "Matricula"
        Me.Matricula.OptionsColumn.AllowEdit = False
        Me.Matricula.Visible = True
        Me.Matricula.Width = 88
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
        Me.CodigoArticulo.Width = 81
        '
        'DescripcionArticulo
        '
        Me.DescripcionArticulo.Caption = "Descripción Artículo"
        Me.DescripcionArticulo.FieldName = "DescripcionArticulo"
        Me.DescripcionArticulo.Name = "DescripcionArticulo"
        Me.DescripcionArticulo.OptionsColumn.AllowEdit = False
        Me.DescripcionArticulo.Visible = True
        Me.DescripcionArticulo.Width = 227
        '
        'Unidades
        '
        Me.Unidades.Caption = "Cantidad"
        Me.Unidades.DisplayFormat.FormatString = "###,###,##0.##"
        Me.Unidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Unidades.FieldName = "Unidades"
        Me.Unidades.Name = "Unidades"
        Me.Unidades.OptionsColumn.AllowEdit = False
        Me.Unidades.Visible = True
        Me.Unidades.Width = 96
        '
        'BaseImponible
        '
        Me.BaseImponible.Caption = "Importe"
        Me.BaseImponible.DisplayFormat.FormatString = "###,###,##0.## €"
        Me.BaseImponible.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BaseImponible.FieldName = "BaseImponible"
        Me.BaseImponible.Name = "BaseImponible"
        Me.BaseImponible.OptionsColumn.AllowEdit = False
        Me.BaseImponible.Visible = True
        Me.BaseImponible.Width = 88
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode1.LevelTemplate = Me.BandedGridView1
        GridLevelNode1.RelationName = "Table2"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(12, 93)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1239, 530)
        Me.GridControl1.TabIndex = 191
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.BandedGridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Codigo, Me.Descripcion, Me.TotalUnidades, Me.TotalBaseImponible})
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
        Me.Descripcion.Width = 250
        '
        'TotalUnidades
        '
        Me.TotalUnidades.Caption = "Cantidad"
        Me.TotalUnidades.DisplayFormat.FormatString = "###,###,##0.##"
        Me.TotalUnidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalUnidades.FieldName = "TotalUnidades"
        Me.TotalUnidades.Name = "TotalUnidades"
        Me.TotalUnidades.OptionsColumn.AllowEdit = False
        Me.TotalUnidades.Visible = True
        Me.TotalUnidades.VisibleIndex = 2
        Me.TotalUnidades.Width = 96
        '
        'TotalBaseImponible
        '
        Me.TotalBaseImponible.Caption = "Importe"
        Me.TotalBaseImponible.DisplayFormat.FormatString = "###,###,##0.## €"
        Me.TotalBaseImponible.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalBaseImponible.FieldName = "TotalBaseImponible"
        Me.TotalBaseImponible.Name = "TotalBaseImponible"
        Me.TotalBaseImponible.OptionsColumn.AllowEdit = False
        Me.TotalBaseImponible.Visible = True
        Me.TotalBaseImponible.VisibleIndex = 3
        Me.TotalBaseImponible.Width = 123
        '
        'Validar
        '
        Me.Validar.Location = New System.Drawing.Point(718, 52)
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
        'DT_Fin
        '
        Me.DT_Fin.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Fin.Location = New System.Drawing.Point(110, 56)
        Me.DT_Fin.Name = "DT_Fin"
        Me.DT_Fin.Size = New System.Drawing.Size(80, 21)
        Me.DT_Fin.TabIndex = 188
        Me.DT_Fin.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(110, 41)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel3.TabIndex = 189
        Me.UltraLabel3.Text = "*Fecha fin:"
        '
        'DT_Inicio
        '
        Me.DT_Inicio.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Inicio.Location = New System.Drawing.Point(10, 56)
        Me.DT_Inicio.MaskInput = "{date}"
        Me.DT_Inicio.Name = "DT_Inicio"
        Me.DT_Inicio.Size = New System.Drawing.Size(80, 21)
        Me.DT_Inicio.TabIndex = 186
        Me.DT_Inicio.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(10, 41)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel10.TabIndex = 187
        Me.UltraLabel10.Text = "*Fecha inicio:"
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
        Me.C_Planta.Location = New System.Drawing.Point(212, 56)
        Me.C_Planta.Name = "C_Planta"
        Me.C_Planta.Size = New System.Drawing.Size(165, 21)
        Me.C_Planta.TabIndex = 264
        Me.C_Planta.Text = "C_Planta"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(212, 41)
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
        Me.C_Proveedor.Location = New System.Drawing.Point(392, 56)
        Me.C_Proveedor.Name = "C_Proveedor"
        Me.C_Proveedor.Size = New System.Drawing.Size(310, 21)
        Me.C_Proveedor.TabIndex = 319
        Me.C_Proveedor.Text = "C_Proveedor"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(392, 41)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel2.TabIndex = 320
        Me.UltraLabel2.Text = "Proveedor:"
        '
        'frmllistatResumCompres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 635)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.C_Proveedor)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.C_Planta)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.DT_Fin)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.DT_Inicio)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.Validar)
        Me.KeyPreview = True
        Me.Name = "frmllistatResumCompres"
        Me.Text = "Resumen de compras por artículo"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.Validar, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel10, 0)
        Me.Controls.SetChildIndex(Me.DT_Inicio, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel3, 0)
        Me.Controls.SetChildIndex(Me.DT_Fin, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel6, 0)
        Me.Controls.SetChildIndex(Me.C_Planta, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel2, 0)
        Me.Controls.SetChildIndex(Me.C_Proveedor, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_RutaExportacio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.C_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Validar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DT_Fin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DT_Inicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TotalBaseImponible As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents BaseImponible As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Table2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
