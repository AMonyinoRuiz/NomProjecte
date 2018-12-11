<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLlistatMossos
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
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.Validar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DT_Fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_Inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NomEstabliment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NumRegistro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Adreca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Localitat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TelContacte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AdrecaElectronica = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.TE_RutaExportacio = New M_TextEditor.m_TextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_Planta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.CH_VisualizarColumnas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.T_Num = New M_MaskEditor.m_MaskEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.OP = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.OP2 = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.CH_CamionesEntrePlantas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_RutaExportacio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CH_VisualizarColumnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.OP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CH_CamionesEntrePlantas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.pMode_Toolbar = m_ToolForm.clsToolForm.Enum_ToolMode.Sortir
        Me.ToolForm.Size = New System.Drawing.Size(623, 24)
        '
        'Validar
        '
        Me.Validar.Location = New System.Drawing.Point(775, 61)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 25)
        Me.Button1.TabIndex = 190
        Me.Button1.Text = "Exportar Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 105)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1482, 518)
        Me.GridControl1.TabIndex = 191
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.Cif, Me.NomEstabliment, Me.NumRegistro, Me.Adreca, Me.Localitat, Me.TelContacte, Me.AdrecaElectronica, Me.DataDadquisicio, Me.DescripcioMaterial, Me.Quantitat, Me.Pes, Me.NomVenedor, Me.PrimerCognom, Me.SegonCognom, Me.DataNaixement, Me.Nacionalitat, Me.Domicili, Me.NumDocument, Me.TipusVehicle, Me.Marca, Me.Model, Me.Matricula})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.NumRegistro, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'Cif
        '
        Me.Cif.Caption = "CIF"
        Me.Cif.FieldName = "Cif"
        Me.Cif.Name = "Cif"
        Me.Cif.OptionsColumn.AllowEdit = False
        Me.Cif.Visible = True
        Me.Cif.VisibleIndex = 0
        '
        'NomEstabliment
        '
        Me.NomEstabliment.Caption = "Nom establiment"
        Me.NomEstabliment.FieldName = "NomEstabliment"
        Me.NomEstabliment.Name = "NomEstabliment"
        Me.NomEstabliment.OptionsColumn.AllowEdit = False
        Me.NomEstabliment.Visible = True
        Me.NomEstabliment.VisibleIndex = 1
        Me.NomEstabliment.Width = 113
        '
        'NumRegistro
        '
        Me.NumRegistro.Caption = "Num Registre"
        Me.NumRegistro.FieldName = "NumRegistro"
        Me.NumRegistro.Name = "NumRegistro"
        Me.NumRegistro.OptionsColumn.AllowEdit = False
        Me.NumRegistro.Visible = True
        Me.NumRegistro.VisibleIndex = 2
        Me.NumRegistro.Width = 137
        '
        'Adreca
        '
        Me.Adreca.Caption = "Adreça"
        Me.Adreca.FieldName = "Adreca"
        Me.Adreca.Name = "Adreca"
        Me.Adreca.OptionsColumn.AllowEdit = False
        Me.Adreca.Visible = True
        Me.Adreca.VisibleIndex = 3
        Me.Adreca.Width = 157
        '
        'Localitat
        '
        Me.Localitat.Caption = "Localitat"
        Me.Localitat.FieldName = "Localitat"
        Me.Localitat.Name = "Localitat"
        Me.Localitat.OptionsColumn.AllowEdit = False
        Me.Localitat.Visible = True
        Me.Localitat.VisibleIndex = 4
        Me.Localitat.Width = 94
        '
        'TelContacte
        '
        Me.TelContacte.AppearanceCell.Options.UseTextOptions = True
        Me.TelContacte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TelContacte.Caption = "Tel. contacte"
        Me.TelContacte.FieldName = "TelContacte"
        Me.TelContacte.Name = "TelContacte"
        Me.TelContacte.OptionsColumn.AllowEdit = False
        Me.TelContacte.Visible = True
        Me.TelContacte.VisibleIndex = 5
        Me.TelContacte.Width = 101
        '
        'AdrecaElectronica
        '
        Me.AdrecaElectronica.Caption = "Adreça electronica"
        Me.AdrecaElectronica.FieldName = "AdrecaElectronica"
        Me.AdrecaElectronica.Name = "AdrecaElectronica"
        Me.AdrecaElectronica.OptionsColumn.AllowEdit = False
        Me.AdrecaElectronica.Visible = True
        Me.AdrecaElectronica.VisibleIndex = 6
        Me.AdrecaElectronica.Width = 157
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
        Me.DataDadquisicio.VisibleIndex = 7
        Me.DataDadquisicio.Width = 91
        '
        'DescripcioMaterial
        '
        Me.DescripcioMaterial.Caption = "Descripció/Identificació material"
        Me.DescripcioMaterial.FieldName = "DescripcioMaterial"
        Me.DescripcioMaterial.Name = "DescripcioMaterial"
        Me.DescripcioMaterial.OptionsColumn.AllowEdit = False
        Me.DescripcioMaterial.Visible = True
        Me.DescripcioMaterial.VisibleIndex = 8
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
        Me.Quantitat.VisibleIndex = 9
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
        Me.Pes.VisibleIndex = 10
        Me.Pes.Width = 124
        '
        'NomVenedor
        '
        Me.NomVenedor.Caption = "Nom venedor"
        Me.NomVenedor.FieldName = "NomVenedor"
        Me.NomVenedor.Name = "NomVenedor"
        Me.NomVenedor.OptionsColumn.AllowEdit = False
        Me.NomVenedor.Visible = True
        Me.NomVenedor.VisibleIndex = 11
        Me.NomVenedor.Width = 196
        '
        'PrimerCognom
        '
        Me.PrimerCognom.Caption = "1er Cognom"
        Me.PrimerCognom.FieldName = "PrimerCognom"
        Me.PrimerCognom.Name = "PrimerCognom"
        Me.PrimerCognom.OptionsColumn.AllowEdit = False
        Me.PrimerCognom.Visible = True
        Me.PrimerCognom.VisibleIndex = 12
        Me.PrimerCognom.Width = 116
        '
        'SegonCognom
        '
        Me.SegonCognom.Caption = "2on Cognom"
        Me.SegonCognom.FieldName = "SegonCognom"
        Me.SegonCognom.Name = "SegonCognom"
        Me.SegonCognom.OptionsColumn.AllowEdit = False
        Me.SegonCognom.Visible = True
        Me.SegonCognom.VisibleIndex = 13
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
        Me.DataNaixement.VisibleIndex = 14
        Me.DataNaixement.Width = 87
        '
        'Nacionalitat
        '
        Me.Nacionalitat.Caption = "Nacionalitat"
        Me.Nacionalitat.FieldName = "Nacionalitat"
        Me.Nacionalitat.Name = "Nacionalitat"
        Me.Nacionalitat.OptionsColumn.AllowEdit = False
        Me.Nacionalitat.Visible = True
        Me.Nacionalitat.VisibleIndex = 15
        Me.Nacionalitat.Width = 87
        '
        'Domicili
        '
        Me.Domicili.Caption = "Domicili"
        Me.Domicili.FieldName = "Domicili"
        Me.Domicili.Name = "Domicili"
        Me.Domicili.OptionsColumn.AllowEdit = False
        Me.Domicili.Visible = True
        Me.Domicili.VisibleIndex = 16
        Me.Domicili.Width = 209
        '
        'NumDocument
        '
        Me.NumDocument.Caption = "Num Document"
        Me.NumDocument.FieldName = "NumDocument"
        Me.NumDocument.Name = "NumDocument"
        Me.NumDocument.OptionsColumn.AllowEdit = False
        Me.NumDocument.Visible = True
        Me.NumDocument.VisibleIndex = 17
        Me.NumDocument.Width = 101
        '
        'TipusVehicle
        '
        Me.TipusVehicle.Caption = "Tipus de vehicle"
        Me.TipusVehicle.FieldName = "TipusVehicle"
        Me.TipusVehicle.Name = "TipusVehicle"
        Me.TipusVehicle.OptionsColumn.AllowEdit = False
        Me.TipusVehicle.Visible = True
        Me.TipusVehicle.VisibleIndex = 18
        Me.TipusVehicle.Width = 90
        '
        'Marca
        '
        Me.Marca.Caption = "Marca"
        Me.Marca.FieldName = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.OptionsColumn.AllowEdit = False
        Me.Marca.Visible = True
        Me.Marca.VisibleIndex = 19
        '
        'Model
        '
        Me.Model.Caption = "Model"
        Me.Model.FieldName = "Model"
        Me.Model.Name = "Model"
        Me.Model.OptionsColumn.AllowEdit = False
        Me.Model.Visible = True
        Me.Model.VisibleIndex = 20
        Me.Model.Width = 96
        '
        'Matricula
        '
        Me.Matricula.Caption = "Matricula"
        Me.Matricula.FieldName = "Matricula"
        Me.Matricula.Name = "Matricula"
        Me.Matricula.OptionsColumn.AllowEdit = False
        Me.Matricula.Visible = True
        Me.Matricula.VisibleIndex = 21
        '
        'TE_RutaExportacio
        '
        Me.TE_RutaExportacio.Location = New System.Drawing.Point(6, 33)
        Me.TE_RutaExportacio.MaxLength = 3999
        Me.TE_RutaExportacio.Name = "TE_RutaExportacio"
        Me.TE_RutaExportacio.ReadOnly = True
        Me.TE_RutaExportacio.Size = New System.Drawing.Size(304, 21)
        Me.TE_RutaExportacio.TabIndex = 262
        Me.TE_RutaExportacio.Text = "TE_RutaExportacio"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 18)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(155, 16)
        Me.UltraLabel1.TabIndex = 263
        Me.UltraLabel1.Text = "*Ruta d'exportación:"
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
        'CH_VisualizarColumnas
        '
        Me.CH_VisualizarColumnas.Location = New System.Drawing.Point(621, 16)
        Me.CH_VisualizarColumnas.Name = "CH_VisualizarColumnas"
        Me.CH_VisualizarColumnas.Size = New System.Drawing.Size(285, 27)
        Me.CH_VisualizarColumnas.TabIndex = 308
        Me.CH_VisualizarColumnas.Text = "Visualizar columnas estáticas"
        Me.CH_VisualizarColumnas.Visible = False
        '
        'T_Num
        '
        Me.T_Num.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_Num.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.T_Num.InputMask = "nnnnnnnnnnnnnn"
        Me.T_Num.Location = New System.Drawing.Point(350, 64)
        Me.T_Num.Name = "T_Num"
        Me.T_Num.NonAutoSizeHeight = 20
        Me.T_Num.ReadOnly = True
        Me.T_Num.Size = New System.Drawing.Size(113, 20)
        Me.T_Num.TabIndex = 315
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(350, 49)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(130, 16)
        Me.UltraLabel2.TabIndex = 316
        Me.UltraLabel2.Text = "*Nº de registro:"
        '
        'OP
        '
        Me.OP.CheckedIndex = 0
        ValueListItem3.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem3.DataValue = "albaran"
        ValueListItem3.DisplayText = "Exportar nº de albarán "
        ValueListItem4.DataValue = "registro"
        ValueListItem4.DisplayText = "Exportar nº de registro"
        Me.OP.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.OP.Location = New System.Drawing.Point(476, 55)
        Me.OP.Name = "OP"
        Me.OP.Size = New System.Drawing.Size(139, 44)
        Me.OP.TabIndex = 317
        Me.OP.Text = "Exportar nº de albarán "
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.OP2)
        Me.UltraGroupBox1.Controls.Add(Me.TE_RutaExportacio)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.Button1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(1104, 9)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(390, 90)
        Me.UltraGroupBox1.TabIndex = 318
        Me.UltraGroupBox1.Text = "Exportación"
        '
        'OP2
        '
        Me.OP2.CheckedIndex = 0
        ValueListItem1.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem1.DataValue = "oficial"
        ValueListItem1.DisplayText = "Excel Mossos Oficial"
        ValueListItem2.DataValue = "generico"
        ValueListItem2.DisplayText = "Excel Mossos Genérico"
        ValueListItem5.DataValue = "guardia_civil"
        ValueListItem5.DisplayText = "Excel Guardia Civil"
        Me.OP2.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem5})
        Me.OP2.Location = New System.Drawing.Point(6, 61)
        Me.OP2.Name = "OP2"
        Me.OP2.Size = New System.Drawing.Size(376, 23)
        Me.OP2.TabIndex = 319
        Me.OP2.Text = "Excel Mossos Oficial"
        '
        'CH_CamionesEntrePlantas
        '
        Me.CH_CamionesEntrePlantas.Location = New System.Drawing.Point(621, 62)
        Me.CH_CamionesEntrePlantas.Name = "CH_CamionesEntrePlantas"
        Me.CH_CamionesEntrePlantas.Size = New System.Drawing.Size(154, 27)
        Me.CH_CamionesEntrePlantas.TabIndex = 319
        Me.CH_CamionesEntrePlantas.Text = "Visualizar también los camiones entre plantas"
        '
        'frmLlistatMossos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1506, 635)
        Me.Controls.Add(Me.CH_CamionesEntrePlantas)
        Me.Controls.Add(Me.CH_VisualizarColumnas)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.OP)
        Me.Controls.Add(Me.T_Num)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.C_Planta)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.DT_Fin)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.DT_Inicio)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.Validar)
        Me.KeyPreview = True
        Me.Name = "frmLlistatMossos"
        Me.Text = "Listado Mossos"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.Validar, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel10, 0)
        Me.Controls.SetChildIndex(Me.DT_Inicio, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel3, 0)
        Me.Controls.SetChildIndex(Me.DT_Fin, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel6, 0)
        Me.Controls.SetChildIndex(Me.C_Planta, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel2, 0)
        Me.Controls.SetChildIndex(Me.T_Num, 0)
        Me.Controls.SetChildIndex(Me.OP, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.CH_VisualizarColumnas, 0)
        Me.Controls.SetChildIndex(Me.CH_CamionesEntrePlantas, 0)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_RutaExportacio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CH_VisualizarColumnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.OP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CH_CamionesEntrePlantas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Cif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NomEstabliment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Adreca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Localitat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TelContacte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdrecaElectronica As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents TE_RutaExportacio As M_TextEditor.m_TextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_Planta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CH_VisualizarColumnas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents T_Num As M_MaskEditor.m_MaskEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents NumRegistro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OP As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OP2 As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents CH_CamionesEntrePlantas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
