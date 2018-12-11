<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParte
    'Inherits System.Windows.Forms.Form
    Inherits M_GenericForm.frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    Try
    '        If disposing AndAlso components IsNot Nothing Then
    '            components.Dispose()
    '        End If
    '    Finally
    '        MyBase.Dispose(disposing)
    '    End Try
    'End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GRD_Ficheros = New M_UltraGrid.m_UltraGrid()
        Me.TABPage_General = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CH_Compensado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.T_Horas = New M_MaskEditor.m_MaskEditor()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_AusenciaTipo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_Inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_Fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.T_Observaciones = New M_TextEditor.m_TextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_Personal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_Planta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.TE_Codigo = New M_MaskEditor.m_MaskEditor()
        Me.C_Usuario = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_Estado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_Alta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Tab_Principal = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.TABPage_General.SuspendLayout()
        CType(Me.CH_Compensado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_AusenciaTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.T_Observaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Alta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tab_Principal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.Size = New System.Drawing.Size(585, 24)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.GRD_Ficheros)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(923, 340)
        '
        'GRD_Ficheros
        '
        Me.GRD_Ficheros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRD_Ficheros.Location = New System.Drawing.Point(0, 0)
        Me.GRD_Ficheros.Name = "GRD_Ficheros"
        Me.GRD_Ficheros.pAccessibleName = Nothing
        Me.GRD_Ficheros.pActivarBotonFiltro = False
        Me.GRD_Ficheros.pText = " "
        Me.GRD_Ficheros.Size = New System.Drawing.Size(923, 340)
        Me.GRD_Ficheros.TabIndex = 262
        '
        'TABPage_General
        '
        Me.TABPage_General.Controls.Add(Me.CH_Compensado)
        Me.TABPage_General.Controls.Add(Me.T_Horas)
        Me.TABPage_General.Controls.Add(Me.UltraLabel19)
        Me.TABPage_General.Controls.Add(Me.C_AusenciaTipo)
        Me.TABPage_General.Controls.Add(Me.UltraLabel8)
        Me.TABPage_General.Controls.Add(Me.DT_Inicio)
        Me.TABPage_General.Controls.Add(Me.UltraLabel4)
        Me.TABPage_General.Controls.Add(Me.DT_Fin)
        Me.TABPage_General.Controls.Add(Me.UltraLabel3)
        Me.TABPage_General.Controls.Add(Me.UltraTabControl1)
        Me.TABPage_General.Controls.Add(Me.T_Observaciones)
        Me.TABPage_General.Controls.Add(Me.UltraLabel5)
        Me.TABPage_General.Controls.Add(Me.C_Personal)
        Me.TABPage_General.Controls.Add(Me.UltraLabel2)
        Me.TABPage_General.Controls.Add(Me.C_Planta)
        Me.TABPage_General.Controls.Add(Me.UltraLabel24)
        Me.TABPage_General.Controls.Add(Me.TE_Codigo)
        Me.TABPage_General.Controls.Add(Me.C_Usuario)
        Me.TABPage_General.Controls.Add(Me.UltraLabel6)
        Me.TABPage_General.Controls.Add(Me.UltraLabel1)
        Me.TABPage_General.Controls.Add(Me.C_Estado)
        Me.TABPage_General.Controls.Add(Me.UltraLabel13)
        Me.TABPage_General.Controls.Add(Me.DT_Alta)
        Me.TABPage_General.Controls.Add(Me.UltraLabel7)
        Me.TABPage_General.Location = New System.Drawing.Point(2, 24)
        Me.TABPage_General.Name = "TABPage_General"
        Me.TABPage_General.Size = New System.Drawing.Size(958, 580)
        '
        'CH_Compensado
        '
        Me.CH_Compensado.Location = New System.Drawing.Point(816, 72)
        Me.CH_Compensado.Name = "CH_Compensado"
        Me.CH_Compensado.Size = New System.Drawing.Size(122, 26)
        Me.CH_Compensado.TabIndex = 316
        Me.CH_Compensado.Text = "Compensado"
        Me.CH_Compensado.Visible = False
        '
        'T_Horas
        '
        Me.T_Horas.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.T_Horas.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.T_Horas.InputMask = "nn.nn"
        Me.T_Horas.Location = New System.Drawing.Point(651, 79)
        Me.T_Horas.Name = "T_Horas"
        Me.T_Horas.NonAutoSizeHeight = 20
        Me.T_Horas.Size = New System.Drawing.Size(83, 20)
        Me.T_Horas.TabIndex = 314
        '
        'UltraLabel19
        '
        Me.UltraLabel19.Location = New System.Drawing.Point(651, 64)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(75, 16)
        Me.UltraLabel19.TabIndex = 315
        Me.UltraLabel19.Text = "*Horas:"
        '
        'C_AusenciaTipo
        '
        Me.C_AusenciaTipo.Location = New System.Drawing.Point(283, 78)
        Me.C_AusenciaTipo.Name = "C_AusenciaTipo"
        Me.C_AusenciaTipo.Size = New System.Drawing.Size(348, 21)
        Me.C_AusenciaTipo.TabIndex = 312
        Me.C_AusenciaTipo.Text = "C_AusenciaTipo"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Location = New System.Drawing.Point(283, 64)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(126, 16)
        Me.UltraLabel8.TabIndex = 313
        Me.UltraLabel8.Text = "*Tipo de ausencia:"
        '
        'DT_Inicio
        '
        Me.DT_Inicio.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Inicio.Location = New System.Drawing.Point(548, 31)
        Me.DT_Inicio.Name = "DT_Inicio"
        Me.DT_Inicio.Size = New System.Drawing.Size(83, 21)
        Me.DT_Inicio.TabIndex = 310
        Me.DT_Inicio.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(548, 16)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(86, 16)
        Me.UltraLabel4.TabIndex = 311
        Me.UltraLabel4.Text = "*Fecha inicio:"
        '
        'DT_Fin
        '
        Me.DT_Fin.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Fin.Location = New System.Drawing.Point(651, 31)
        Me.DT_Fin.Name = "DT_Fin"
        Me.DT_Fin.Size = New System.Drawing.Size(83, 21)
        Me.DT_Fin.TabIndex = 308
        Me.DT_Fin.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(651, 16)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(86, 16)
        Me.UltraLabel3.TabIndex = 309
        Me.UltraLabel3.Text = "*Fecha fin:"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Location = New System.Drawing.Point(15, 202)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl1.Size = New System.Drawing.Size(927, 366)
        Me.UltraTabControl1.TabIndex = 307
        UltraTab2.TabPage = Me.UltraTabPageControl1
        UltraTab2.Text = "Documentos adjuntos"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(923, 340)
        '
        'T_Observaciones
        '
        Me.T_Observaciones.Location = New System.Drawing.Point(16, 129)
        Me.T_Observaciones.MaxLength = 3999
        Me.T_Observaciones.Multiline = True
        Me.T_Observaciones.Name = "T_Observaciones"
        Me.T_Observaciones.Size = New System.Drawing.Size(926, 67)
        Me.T_Observaciones.TabIndex = 240
        Me.T_Observaciones.Text = "T_Observaciones"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(16, 114)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(174, 16)
        Me.UltraLabel5.TabIndex = 241
        Me.UltraLabel5.Text = "Observaciones:"
        '
        'C_Personal
        '
        Me.C_Personal.Location = New System.Drawing.Point(16, 78)
        Me.C_Personal.Name = "C_Personal"
        Me.C_Personal.Size = New System.Drawing.Size(251, 21)
        Me.C_Personal.TabIndex = 232
        Me.C_Personal.Text = "C_Personal"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 64)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(125, 16)
        Me.UltraLabel2.TabIndex = 233
        Me.UltraLabel2.Text = "*Personal:"
        '
        'C_Planta
        '
        Me.C_Planta.Location = New System.Drawing.Point(283, 30)
        Me.C_Planta.Name = "C_Planta"
        Me.C_Planta.ReadOnly = True
        Me.C_Planta.Size = New System.Drawing.Size(143, 21)
        Me.C_Planta.TabIndex = 230
        Me.C_Planta.Text = "C_Planta"
        '
        'UltraLabel24
        '
        Me.UltraLabel24.Location = New System.Drawing.Point(283, 16)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(69, 16)
        Me.UltraLabel24.TabIndex = 231
        Me.UltraLabel24.Text = "*Planta:"
        '
        'TE_Codigo
        '
        Me.TE_Codigo.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.TE_Codigo.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Long]
        Me.TE_Codigo.InputMask = "nnnnnn"
        Me.TE_Codigo.Location = New System.Drawing.Point(15, 31)
        Me.TE_Codigo.Name = "TE_Codigo"
        Me.TE_Codigo.NonAutoSizeHeight = 20
        Me.TE_Codigo.ReadOnly = True
        Me.TE_Codigo.Size = New System.Drawing.Size(90, 20)
        Me.TE_Codigo.TabIndex = 221
        '
        'C_Usuario
        '
        Me.C_Usuario.Location = New System.Drawing.Point(124, 31)
        Me.C_Usuario.Name = "C_Usuario"
        Me.C_Usuario.ReadOnly = True
        Me.C_Usuario.Size = New System.Drawing.Size(143, 21)
        Me.C_Usuario.TabIndex = 220
        Me.C_Usuario.Text = "C_Usuario"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(125, 17)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(142, 16)
        Me.UltraLabel6.TabIndex = 219
        Me.UltraLabel6.Text = "*Responsable:"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(14, 16)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(91, 16)
        Me.UltraLabel1.TabIndex = 10
        Me.UltraLabel1.Text = "*Código:"
        '
        'C_Estado
        '
        Me.C_Estado.Location = New System.Drawing.Point(814, 31)
        Me.C_Estado.MaxDropDownItems = 15
        Me.C_Estado.Name = "C_Estado"
        Me.C_Estado.ReadOnly = True
        Me.C_Estado.Size = New System.Drawing.Size(128, 21)
        Me.C_Estado.TabIndex = 1
        Me.C_Estado.Text = "C_Estado"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.Location = New System.Drawing.Point(814, 16)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(91, 16)
        Me.UltraLabel13.TabIndex = 17
        Me.UltraLabel13.Text = "*Estado:"
        '
        'DT_Alta
        '
        Me.DT_Alta.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Alta.Location = New System.Drawing.Point(445, 31)
        Me.DT_Alta.Name = "DT_Alta"
        Me.DT_Alta.ReadOnly = True
        Me.DT_Alta.Size = New System.Drawing.Size(83, 21)
        Me.DT_Alta.TabIndex = 2
        Me.DT_Alta.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Location = New System.Drawing.Point(445, 16)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(86, 16)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "*Fecha alta:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Tab_Principal
        '
        Me.Tab_Principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Principal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.Tab_Principal.Controls.Add(Me.TABPage_General)
        Me.Tab_Principal.Location = New System.Drawing.Point(12, 43)
        Me.Tab_Principal.Name = "Tab_Principal"
        Me.Tab_Principal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.Tab_Principal.Size = New System.Drawing.Size(962, 606)
        Me.Tab_Principal.TabIndex = 20
        UltraTab3.Key = "General"
        UltraTab3.TabPage = Me.TABPage_General
        UltraTab3.Text = "General"
        Me.Tab_Principal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(958, 580)
        '
        'frmParte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.Tab_Principal)
        Me.KeyPreview = True
        Me.Name = "frmParte"
        Me.Text = "Parte"
        Me.Controls.SetChildIndex(Me.Tab_Principal, 0)
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.TABPage_General.ResumeLayout(False)
        Me.TABPage_General.PerformLayout()
        CType(Me.CH_Compensado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_AusenciaTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.T_Observaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Alta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tab_Principal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Principal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Tab_Principal As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents TABPage_General As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_Estado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DT_Alta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_Usuario As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents TE_Codigo As M_MaskEditor.m_MaskEditor
    Friend WithEvents C_Planta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_Personal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents T_Observaciones As M_TextEditor.m_TextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GRD_Ficheros As M_UltraGrid.m_UltraGrid
    Friend WithEvents DT_Inicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DT_Fin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents T_Horas As M_MaskEditor.m_MaskEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_AusenciaTipo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CH_Compensado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
