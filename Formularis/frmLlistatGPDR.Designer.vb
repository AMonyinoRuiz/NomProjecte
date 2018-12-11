<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLlistatGPDR
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GRD_clientes = New M_UltraGrid.m_UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GRD_proveedores = New M_UltraGrid.m_UltraGrid()
        Me.Validar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.C_Año = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.T_C_Pendientes = New M_MaskEditor.m_MaskEditor()
        Me.T_C_Respondidas = New M_MaskEditor.m_MaskEditor()
        Me.T_C_Porcentaje = New M_MaskEditor.m_MaskEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.T_P_Pendientes = New M_MaskEditor.m_MaskEditor()
        Me.T_P_Respondidas = New M_MaskEditor.m_MaskEditor()
        Me.T_P_Porcentaje = New M_MaskEditor.m_MaskEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GRD_Acreedores = New M_UltraGrid.m_UltraGrid()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.T_A_Pendientes = New M_MaskEditor.m_MaskEditor()
        Me.T_A_respondidas = New M_MaskEditor.m_MaskEditor()
        Me.T_A_Porcentaje = New M_MaskEditor.m_MaskEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Año, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.pMode_Toolbar = m_ToolForm.clsToolForm.Enum_ToolMode.Sortir
        Me.ToolForm.Size = New System.Drawing.Size(395, 24)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.GRD_clientes)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(908, 391)
        '
        'GRD_clientes
        '
        Me.GRD_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRD_clientes.Location = New System.Drawing.Point(0, 0)
        Me.GRD_clientes.Name = "GRD_clientes"
        Me.GRD_clientes.pAccessibleName = Nothing
        Me.GRD_clientes.pActivarBotonFiltro = False
        Me.GRD_clientes.pText = " "
        Me.GRD_clientes.Size = New System.Drawing.Size(908, 391)
        Me.GRD_clientes.TabIndex = 188
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.GRD_proveedores)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(908, 391)
        '
        'GRD_proveedores
        '
        Me.GRD_proveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRD_proveedores.Location = New System.Drawing.Point(0, 0)
        Me.GRD_proveedores.Name = "GRD_proveedores"
        Me.GRD_proveedores.pAccessibleName = Nothing
        Me.GRD_proveedores.pActivarBotonFiltro = False
        Me.GRD_proveedores.pText = " "
        Me.GRD_proveedores.Size = New System.Drawing.Size(908, 391)
        Me.GRD_proveedores.TabIndex = 189
        '
        'Validar
        '
        Me.Validar.Location = New System.Drawing.Point(140, 60)
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
        'C_Año
        '
        Me.C_Año.Location = New System.Drawing.Point(12, 64)
        Me.C_Año.Name = "C_Año"
        Me.C_Año.Size = New System.Drawing.Size(122, 21)
        Me.C_Año.TabIndex = 264
        Me.C_Año.Text = "C_Año"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(12, 49)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel6.TabIndex = 265
        Me.UltraLabel6.Text = "*Año:"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Location = New System.Drawing.Point(12, 107)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(1254, 435)
        Me.UltraTabControl1.TabIndex = 266
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Clientes"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Proveedores"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Acreedores"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1250, 409)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.T_C_Pendientes)
        Me.UltraGroupBox1.Controls.Add(Me.T_C_Respondidas)
        Me.UltraGroupBox1.Controls.Add(Me.T_C_Porcentaje)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(546, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(235, 116)
        Me.UltraGroupBox1.TabIndex = 267
        Me.UltraGroupBox1.Text = "Clientes"
        '
        'T_C_Pendientes
        '
        Me.T_C_Pendientes.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
        Me.T_C_Pendientes.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_C_Pendientes.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.T_C_Pendientes.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.T_C_Pendientes.InputMask = "nnnnnnn"
        Me.T_C_Pendientes.Location = New System.Drawing.Point(150, 55)
        Me.T_C_Pendientes.Name = "T_C_Pendientes"
        Me.T_C_Pendientes.NonAutoSizeHeight = 20
        Me.T_C_Pendientes.ReadOnly = True
        Me.T_C_Pendientes.Size = New System.Drawing.Size(74, 20)
        Me.T_C_Pendientes.TabIndex = 289
        '
        'T_C_Respondidas
        '
        Me.T_C_Respondidas.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
        Me.T_C_Respondidas.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_C_Respondidas.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.T_C_Respondidas.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.T_C_Respondidas.InputMask = "nnnnnnn"
        Me.T_C_Respondidas.Location = New System.Drawing.Point(150, 23)
        Me.T_C_Respondidas.Name = "T_C_Respondidas"
        Me.T_C_Respondidas.NonAutoSizeHeight = 20
        Me.T_C_Respondidas.ReadOnly = True
        Me.T_C_Respondidas.Size = New System.Drawing.Size(74, 20)
        Me.T_C_Respondidas.TabIndex = 290
        '
        'T_C_Porcentaje
        '
        Me.T_C_Porcentaje.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
        Me.T_C_Porcentaje.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_C_Porcentaje.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.T_C_Porcentaje.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.T_C_Porcentaje.InputMask = "nnn.nn%"
        Me.T_C_Porcentaje.Location = New System.Drawing.Point(150, 85)
        Me.T_C_Porcentaje.Name = "T_C_Porcentaje"
        Me.T_C_Porcentaje.NonAutoSizeHeight = 20
        Me.T_C_Porcentaje.ReadOnly = True
        Me.T_C_Porcentaje.Size = New System.Drawing.Size(74, 20)
        Me.T_C_Porcentaje.TabIndex = 279
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(6, 89)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(146, 16)
        Me.UltraLabel3.TabIndex = 271
        Me.UltraLabel3.Text = "% de solicitudes realizadas:"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(6, 58)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(128, 16)
        Me.UltraLabel2.TabIndex = 270
        Me.UltraLabel2.Text = "Solicitudes pendentes:"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 26)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(128, 16)
        Me.UltraLabel1.TabIndex = 269
        Me.UltraLabel1.Text = "Solicitudes respondidas:"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox2.Controls.Add(Me.T_P_Pendientes)
        Me.UltraGroupBox2.Controls.Add(Me.T_P_Respondidas)
        Me.UltraGroupBox2.Controls.Add(Me.T_P_Porcentaje)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(787, 12)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(235, 116)
        Me.UltraGroupBox2.TabIndex = 268
        Me.UltraGroupBox2.Text = "Proveedores"
        '
        'T_P_Pendientes
        '
        Me.T_P_Pendientes.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
        Me.T_P_Pendientes.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_P_Pendientes.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.T_P_Pendientes.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.T_P_Pendientes.InputMask = "nnnnnnn"
        Me.T_P_Pendientes.Location = New System.Drawing.Point(149, 55)
        Me.T_P_Pendientes.Name = "T_P_Pendientes"
        Me.T_P_Pendientes.NonAutoSizeHeight = 20
        Me.T_P_Pendientes.ReadOnly = True
        Me.T_P_Pendientes.Size = New System.Drawing.Size(74, 20)
        Me.T_P_Pendientes.TabIndex = 287
        '
        'T_P_Respondidas
        '
        Me.T_P_Respondidas.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
        Me.T_P_Respondidas.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_P_Respondidas.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.T_P_Respondidas.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.T_P_Respondidas.InputMask = "nnnnnnn"
        Me.T_P_Respondidas.Location = New System.Drawing.Point(149, 23)
        Me.T_P_Respondidas.Name = "T_P_Respondidas"
        Me.T_P_Respondidas.NonAutoSizeHeight = 20
        Me.T_P_Respondidas.ReadOnly = True
        Me.T_P_Respondidas.Size = New System.Drawing.Size(74, 20)
        Me.T_P_Respondidas.TabIndex = 288
        '
        'T_P_Porcentaje
        '
        Me.T_P_Porcentaje.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
        Me.T_P_Porcentaje.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_P_Porcentaje.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.T_P_Porcentaje.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.T_P_Porcentaje.InputMask = "nnn.nn%"
        Me.T_P_Porcentaje.Location = New System.Drawing.Point(149, 85)
        Me.T_P_Porcentaje.Name = "T_P_Porcentaje"
        Me.T_P_Porcentaje.NonAutoSizeHeight = 20
        Me.T_P_Porcentaje.ReadOnly = True
        Me.T_P_Porcentaje.Size = New System.Drawing.Size(74, 20)
        Me.T_P_Porcentaje.TabIndex = 280
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(6, 89)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(146, 16)
        Me.UltraLabel4.TabIndex = 274
        Me.UltraLabel4.Text = "% de solicitudes realizadas:"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(6, 58)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(128, 16)
        Me.UltraLabel5.TabIndex = 273
        Me.UltraLabel5.Text = "Solicitudes pendentes:"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Location = New System.Drawing.Point(6, 26)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(128, 16)
        Me.UltraLabel7.TabIndex = 272
        Me.UltraLabel7.Text = "Solicitudes respondidas:"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.GRD_Acreedores)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1250, 409)
        '
        'GRD_Acreedores
        '
        Me.GRD_Acreedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRD_Acreedores.Location = New System.Drawing.Point(0, 0)
        Me.GRD_Acreedores.Name = "GRD_Acreedores"
        Me.GRD_Acreedores.pAccessibleName = Nothing
        Me.GRD_Acreedores.pActivarBotonFiltro = False
        Me.GRD_Acreedores.pText = " "
        Me.GRD_Acreedores.Size = New System.Drawing.Size(1250, 409)
        Me.GRD_Acreedores.TabIndex = 189
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox3.Controls.Add(Me.T_A_Pendientes)
        Me.UltraGroupBox3.Controls.Add(Me.T_A_respondidas)
        Me.UltraGroupBox3.Controls.Add(Me.T_A_Porcentaje)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(1028, 12)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(235, 116)
        Me.UltraGroupBox3.TabIndex = 269
        Me.UltraGroupBox3.Text = "Acreedores"
        '
        'T_A_Pendientes
        '
        Me.T_A_Pendientes.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
        Me.T_A_Pendientes.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_A_Pendientes.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.T_A_Pendientes.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.T_A_Pendientes.InputMask = "nnnnnnn"
        Me.T_A_Pendientes.Location = New System.Drawing.Point(149, 55)
        Me.T_A_Pendientes.Name = "T_A_Pendientes"
        Me.T_A_Pendientes.NonAutoSizeHeight = 20
        Me.T_A_Pendientes.ReadOnly = True
        Me.T_A_Pendientes.Size = New System.Drawing.Size(74, 20)
        Me.T_A_Pendientes.TabIndex = 287
        '
        'T_A_respondidas
        '
        Me.T_A_respondidas.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
        Me.T_A_respondidas.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_A_respondidas.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.T_A_respondidas.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.T_A_respondidas.InputMask = "nnnnnnn"
        Me.T_A_respondidas.Location = New System.Drawing.Point(149, 23)
        Me.T_A_respondidas.Name = "T_A_respondidas"
        Me.T_A_respondidas.NonAutoSizeHeight = 20
        Me.T_A_respondidas.ReadOnly = True
        Me.T_A_respondidas.Size = New System.Drawing.Size(74, 20)
        Me.T_A_respondidas.TabIndex = 288
        '
        'T_A_Porcentaje
        '
        Me.T_A_Porcentaje.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
        Me.T_A_Porcentaje.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_A_Porcentaje.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.T_A_Porcentaje.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.T_A_Porcentaje.InputMask = "nnn.nn%"
        Me.T_A_Porcentaje.Location = New System.Drawing.Point(149, 85)
        Me.T_A_Porcentaje.Name = "T_A_Porcentaje"
        Me.T_A_Porcentaje.NonAutoSizeHeight = 20
        Me.T_A_Porcentaje.ReadOnly = True
        Me.T_A_Porcentaje.Size = New System.Drawing.Size(74, 20)
        Me.T_A_Porcentaje.TabIndex = 280
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Location = New System.Drawing.Point(6, 89)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(146, 16)
        Me.UltraLabel8.TabIndex = 274
        Me.UltraLabel8.Text = "% de solicitudes realizadas:"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.Location = New System.Drawing.Point(6, 58)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(128, 16)
        Me.UltraLabel9.TabIndex = 273
        Me.UltraLabel9.Text = "Solicitudes pendentes:"
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(6, 26)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(128, 16)
        Me.UltraLabel10.TabIndex = 272
        Me.UltraLabel10.Text = "Solicitudes respondidas:"
        '
        'frmLlistatGPDR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 554)
        Me.Controls.Add(Me.UltraGroupBox3)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.C_Año)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.Validar)
        Me.KeyPreview = True
        Me.Name = "frmLlistatGPDR"
        Me.Text = "Listado RGPD"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.Validar, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel6, 0)
        Me.Controls.SetChildIndex(Me.C_Año, 0)
        Me.Controls.SetChildIndex(Me.UltraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox3, 0)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Año, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Validar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents C_Año As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GRD_clientes As M_UltraGrid.m_UltraGrid
    Friend WithEvents GRD_proveedores As M_UltraGrid.m_UltraGrid
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents T_P_Pendientes As M_MaskEditor.m_MaskEditor
    Friend WithEvents T_P_Respondidas As M_MaskEditor.m_MaskEditor
    Friend WithEvents T_P_Porcentaje As M_MaskEditor.m_MaskEditor
    Friend WithEvents T_C_Pendientes As M_MaskEditor.m_MaskEditor
    Friend WithEvents T_C_Respondidas As M_MaskEditor.m_MaskEditor
    Friend WithEvents T_C_Porcentaje As M_MaskEditor.m_MaskEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GRD_Acreedores As M_UltraGrid.m_UltraGrid
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents T_A_Pendientes As M_MaskEditor.m_MaskEditor
    Friend WithEvents T_A_respondidas As M_MaskEditor.m_MaskEditor
    Friend WithEvents T_A_Porcentaje As M_MaskEditor.m_MaskEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
End Class
