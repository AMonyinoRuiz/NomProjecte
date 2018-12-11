<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLlistatLiniesAlbaran
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
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.Validar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DT_Fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_Inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_Planta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.CH_CamionesEntrePlantas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NumRegistro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataDadquisicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescripcioMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Quantitat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Pes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NomVenedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrimerCognom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SegonCognom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataNaixement = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nacionalitat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Domicili = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NumDocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TipusVehicle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Marca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Matricula = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OP = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CH_CamionesEntrePlantas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.pMode_Toolbar = m_ToolForm.clsToolForm.Enum_ToolMode.Sortir
        Me.ToolForm.Size = New System.Drawing.Size(623, 24)
        '
        'Validar
        '
        Me.Validar.Location = New System.Drawing.Point(637, 62)
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
        Me.DT_Fin.Location = New System.Drawing.Point(249, 64)
        Me.DT_Fin.Name = "DT_Fin"
        Me.DT_Fin.Size = New System.Drawing.Size(80, 21)
        Me.DT_Fin.TabIndex = 188
        Me.DT_Fin.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(249, 49)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel3.TabIndex = 189
        Me.UltraLabel3.Text = "*Fecha fin:"
        '
        'DT_Inicio
        '
        Me.DT_Inicio.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Inicio.Location = New System.Drawing.Point(149, 64)
        Me.DT_Inicio.MaskInput = "{date}"
        Me.DT_Inicio.Name = "DT_Inicio"
        Me.DT_Inicio.Size = New System.Drawing.Size(80, 21)
        Me.DT_Inicio.TabIndex = 186
        Me.DT_Inicio.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(149, 49)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel10.TabIndex = 187
        Me.UltraLabel10.Text = "*Fecha inicio:"
        '
        'C_Planta
        '
        Me.C_Planta.Location = New System.Drawing.Point(12, 64)
        Me.C_Planta.Name = "C_Planta"
        Me.C_Planta.Size = New System.Drawing.Size(122, 21)
        Me.C_Planta.TabIndex = 264
        Me.C_Planta.Text = "C_Planta"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(12, 49)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel6.TabIndex = 265
        Me.UltraLabel6.Text = "*Planta:"
        '
        'CH_CamionesEntrePlantas
        '
        Me.CH_CamionesEntrePlantas.Location = New System.Drawing.Point(338, 59)
        Me.CH_CamionesEntrePlantas.Name = "CH_CamionesEntrePlantas"
        Me.CH_CamionesEntrePlantas.Size = New System.Drawing.Size(138, 27)
        Me.CH_CamionesEntrePlantas.TabIndex = 319
        Me.CH_CamionesEntrePlantas.Text = "Visualizar también los camiones entre plantas"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 104)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1482, 519)
        Me.GridControl1.TabIndex = 320
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NumRegistro, Me.DataDadquisicio, Me.DescripcioMaterial, Me.Quantitat, Me.Pes, Me.NomVenedor, Me.PrimerCognom, Me.SegonCognom, Me.DataNaixement, Me.Nacionalitat, Me.Domicili, Me.NumDocument, Me.TipusVehicle, Me.Marca, Me.Model, Me.Matricula})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.NumRegistro, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'NumRegistro
        '
        Me.NumRegistro.Caption = "Num Registre"
        Me.NumRegistro.FieldName = "NumRegistro"
        Me.NumRegistro.Name = "NumRegistro"
        Me.NumRegistro.OptionsColumn.AllowEdit = False
        Me.NumRegistro.Visible = True
        Me.NumRegistro.VisibleIndex = 0
        Me.NumRegistro.Width = 137
        '
        'DataDadquisicio
        '
        Me.DataDadquisicio.AppearanceCell.Options.UseTextOptions = True
        Me.DataDadquisicio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DataDadquisicio.Caption = "Data d'adquisició"
        Me.DataDadquisicio.FieldName = "DataDadquisicio"
        Me.DataDadquisicio.Name = "DataDadquisicio"
        Me.DataDadquisicio.OptionsColumn.AllowEdit = False
        Me.DataDadquisicio.Visible = True
        Me.DataDadquisicio.VisibleIndex = 1
        Me.DataDadquisicio.Width = 91
        '
        'DescripcioMaterial
        '
        Me.DescripcioMaterial.Caption = "Descripció/Identificació material"
        Me.DescripcioMaterial.FieldName = "DescripcioMaterial"
        Me.DescripcioMaterial.Name = "DescripcioMaterial"
        Me.DescripcioMaterial.OptionsColumn.AllowEdit = False
        Me.DescripcioMaterial.Visible = True
        Me.DescripcioMaterial.VisibleIndex = 2
        Me.DescripcioMaterial.Width = 195
        '
        'Quantitat
        '
        Me.Quantitat.Caption = "Quantitat"
        Me.Quantitat.DisplayFormat.FormatString = "#.#"
        Me.Quantitat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Quantitat.FieldName = "Quantitat"
        Me.Quantitat.GroupFormat.FormatString = "#.#"
        Me.Quantitat.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Quantitat.Name = "Quantitat"
        Me.Quantitat.OptionsColumn.AllowEdit = False
        Me.Quantitat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantitat", "SUMA={0:#,#}")})
        Me.Quantitat.Visible = True
        Me.Quantitat.VisibleIndex = 3
        Me.Quantitat.Width = 101
        '
        'Pes
        '
        Me.Pes.Caption = "Pes en Kg"
        Me.Pes.DisplayFormat.FormatString = "0.00"
        Me.Pes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Pes.FieldName = "Pes"
        Me.Pes.GroupFormat.FormatString = "0.00"
        Me.Pes.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Pes.Name = "Pes"
        Me.Pes.OptionsColumn.AllowEdit = False
        Me.Pes.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pes", "SUMA={0:#,#0.00}")})
        Me.Pes.Visible = True
        Me.Pes.VisibleIndex = 4
        Me.Pes.Width = 124
        '
        'NomVenedor
        '
        Me.NomVenedor.Caption = "Nom"
        Me.NomVenedor.FieldName = "NomVenedor"
        Me.NomVenedor.Name = "NomVenedor"
        Me.NomVenedor.OptionsColumn.AllowEdit = False
        Me.NomVenedor.Visible = True
        Me.NomVenedor.VisibleIndex = 5
        Me.NomVenedor.Width = 196
        '
        'PrimerCognom
        '
        Me.PrimerCognom.Caption = "1er Cognom"
        Me.PrimerCognom.FieldName = "PrimerCognom"
        Me.PrimerCognom.Name = "PrimerCognom"
        Me.PrimerCognom.OptionsColumn.AllowEdit = False
        Me.PrimerCognom.Visible = True
        Me.PrimerCognom.VisibleIndex = 6
        Me.PrimerCognom.Width = 116
        '
        'SegonCognom
        '
        Me.SegonCognom.Caption = "2on Cognom"
        Me.SegonCognom.FieldName = "SegonCognom"
        Me.SegonCognom.Name = "SegonCognom"
        Me.SegonCognom.OptionsColumn.AllowEdit = False
        Me.SegonCognom.Visible = True
        Me.SegonCognom.VisibleIndex = 7
        Me.SegonCognom.Width = 115
        '
        'DataNaixement
        '
        Me.DataNaixement.AppearanceCell.Options.UseTextOptions = True
        Me.DataNaixement.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DataNaixement.Caption = "Data Naixement"
        Me.DataNaixement.FieldName = "DataNaixement"
        Me.DataNaixement.Name = "DataNaixement"
        Me.DataNaixement.OptionsColumn.AllowEdit = False
        Me.DataNaixement.Visible = True
        Me.DataNaixement.VisibleIndex = 8
        Me.DataNaixement.Width = 87
        '
        'Nacionalitat
        '
        Me.Nacionalitat.Caption = "Nacionalitat"
        Me.Nacionalitat.FieldName = "Nacionalitat"
        Me.Nacionalitat.Name = "Nacionalitat"
        Me.Nacionalitat.OptionsColumn.AllowEdit = False
        Me.Nacionalitat.Visible = True
        Me.Nacionalitat.VisibleIndex = 9
        Me.Nacionalitat.Width = 87
        '
        'Domicili
        '
        Me.Domicili.Caption = "Domicili"
        Me.Domicili.FieldName = "Domicili"
        Me.Domicili.Name = "Domicili"
        Me.Domicili.OptionsColumn.AllowEdit = False
        Me.Domicili.Visible = True
        Me.Domicili.VisibleIndex = 10
        Me.Domicili.Width = 209
        '
        'NumDocument
        '
        Me.NumDocument.Caption = "Num Document"
        Me.NumDocument.FieldName = "NumDocument"
        Me.NumDocument.Name = "NumDocument"
        Me.NumDocument.OptionsColumn.AllowEdit = False
        Me.NumDocument.Visible = True
        Me.NumDocument.VisibleIndex = 11
        Me.NumDocument.Width = 101
        '
        'TipusVehicle
        '
        Me.TipusVehicle.Caption = "Tipus de vehicle"
        Me.TipusVehicle.FieldName = "TipusVehicle"
        Me.TipusVehicle.Name = "TipusVehicle"
        Me.TipusVehicle.OptionsColumn.AllowEdit = False
        Me.TipusVehicle.Visible = True
        Me.TipusVehicle.VisibleIndex = 12
        Me.TipusVehicle.Width = 90
        '
        'Marca
        '
        Me.Marca.Caption = "Marca"
        Me.Marca.FieldName = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.OptionsColumn.AllowEdit = False
        Me.Marca.Visible = True
        Me.Marca.VisibleIndex = 13
        '
        'Model
        '
        Me.Model.Caption = "Model"
        Me.Model.FieldName = "Model"
        Me.Model.Name = "Model"
        Me.Model.OptionsColumn.AllowEdit = False
        Me.Model.Visible = True
        Me.Model.VisibleIndex = 14
        Me.Model.Width = 96
        '
        'Matricula
        '
        Me.Matricula.Caption = "Matricula"
        Me.Matricula.FieldName = "Matricula"
        Me.Matricula.Name = "Matricula"
        Me.Matricula.OptionsColumn.AllowEdit = False
        Me.Matricula.Visible = True
        Me.Matricula.VisibleIndex = 15
        '
        'OP
        '
        Me.OP.CheckedIndex = 1
        ValueListItem4.DataValue = "venta"
        ValueListItem4.DisplayText = "Albaranes de venta"
        ValueListItem3.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem3.DataValue = "compra"
        ValueListItem3.DisplayText = "Albaranes de compra"
        Me.OP.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem4, ValueListItem3})
        Me.OP.Location = New System.Drawing.Point(482, 53)
        Me.OP.Name = "OP"
        Me.OP.Size = New System.Drawing.Size(139, 44)
        Me.OP.TabIndex = 321
        Me.OP.Text = "Albaranes de compra"
        '
        'frmLlistatLiniesAlbaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1506, 635)
        Me.Controls.Add(Me.OP)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.CH_CamionesEntrePlantas)
        Me.Controls.Add(Me.C_Planta)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.DT_Fin)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.DT_Inicio)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.Validar)
        Me.KeyPreview = True
        Me.Name = "frmLlistatLiniesAlbaran"
        Me.Text = "Listado de líneas de albarán (Formato Mossos)"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.Validar, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel10, 0)
        Me.Controls.SetChildIndex(Me.DT_Inicio, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel3, 0)
        Me.Controls.SetChildIndex(Me.DT_Fin, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel6, 0)
        Me.Controls.SetChildIndex(Me.C_Planta, 0)
        Me.Controls.SetChildIndex(Me.CH_CamionesEntrePlantas, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.OP, 0)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CH_CamionesEntrePlantas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Validar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DT_Fin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DT_Inicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_Planta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CH_CamionesEntrePlantas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NumRegistro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataDadquisicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DescripcioMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Quantitat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NomVenedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrimerCognom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SegonCognom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataNaixement As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nacionalitat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Domicili As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NumDocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TipusVehicle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Marca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Matricula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OP As Infragistics.Win.UltraWinEditors.UltraOptionSet
End Class
