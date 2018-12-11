<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManteniment
    'Inherits System.Windows.Forms.Form
    Inherits M_GenericForm.frmBase



    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Btn_Apli = New Infragistics.Win.Misc.UltraButton()
        Me.UCP = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.GRD = New M_UltraGrid.m_UltraGrid()
        Me.C_Taula = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Tap_Principal = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Taula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tap_Principal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tap_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.pMode_Toolbar = m_ToolForm.clsToolForm.Enum_ToolMode.GuardarSortir
        Me.ToolForm.Size = New System.Drawing.Size(1063, 24)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Btn_Apli)
        Me.UltraTabPageControl1.Controls.Add(Me.UCP)
        Me.UltraTabPageControl1.Controls.Add(Me.GRD)
        Me.UltraTabPageControl1.Controls.Add(Me.C_Taula)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1059, 557)
        '
        'Btn_Apli
        '
        Me.Btn_Apli.Location = New System.Drawing.Point(697, 33)
        Me.Btn_Apli.Name = "Btn_Apli"
        Me.Btn_Apli.Size = New System.Drawing.Size(68, 20)
        Me.Btn_Apli.TabIndex = 5
        Me.Btn_Apli.Text = "Aplicar"
        Me.Btn_Apli.Visible = False
        '
        'UCP
        '
        Me.UCP.Location = New System.Drawing.Point(544, 32)
        Me.UCP.Name = "UCP"
        Me.UCP.Size = New System.Drawing.Size(148, 21)
        Me.UCP.TabIndex = 4
        Me.UCP.Text = "Control"
        Me.UCP.Visible = False
        '
        'GRD
        '
        Me.GRD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRD.Location = New System.Drawing.Point(0, 68)
        Me.GRD.Name = "GRD"
        Me.GRD.pAccessibleName = Nothing
        Me.GRD.pActivarBotonFiltro = False
        Me.GRD.pText = " "
        Me.GRD.Size = New System.Drawing.Size(1059, 489)
        Me.GRD.TabIndex = 0
        '
        'C_Taula
        '
        Me.C_Taula.Location = New System.Drawing.Point(3, 32)
        Me.C_Taula.Name = "C_Taula"
        Me.C_Taula.Size = New System.Drawing.Size(535, 21)
        Me.C_Taula.TabIndex = 2
        Me.C_Taula.Text = "C_Taula"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(3, 16)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(124, 19)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Maestros:"
        '
        'Tap_Principal
        '
        Me.Tap_Principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tap_Principal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.Tap_Principal.Controls.Add(Me.UltraTabPageControl1)
        Me.Tap_Principal.Location = New System.Drawing.Point(12, 39)
        Me.Tap_Principal.Name = "Tap_Principal"
        Me.Tap_Principal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.Tap_Principal.Size = New System.Drawing.Size(1063, 583)
        Me.Tap_Principal.TabIndex = 7
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "General"
        Me.Tap_Principal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1059, 557)
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(592, 22)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(115, 22)
        Me.UltraButton1.TabIndex = 8
        Me.UltraButton1.Text = "Importar articles"
        Me.UltraButton1.Visible = False
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(713, 22)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(115, 22)
        Me.UltraButton2.TabIndex = 9
        Me.UltraButton2.Text = "Importar QR"
        Me.UltraButton2.Visible = False
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(438, 24)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(148, 20)
        Me.UltraButton3.TabIndex = 6
        Me.UltraButton3.Text = "Eliminar Festivos y FS"
        Me.UltraButton3.Visible = False
        '
        'frmManteniment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 638)
        Me.Controls.Add(Me.UltraButton3)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.Tap_Principal)
        Me.KeyPreview = True
        Me.Name = "frmManteniment"
        Me.Text = "Mantenimiento de maestros"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.Tap_Principal, 0)
        Me.Controls.SetChildIndex(Me.UltraButton1, 0)
        Me.Controls.SetChildIndex(Me.UltraButton2, 0)
        Me.Controls.SetChildIndex(Me.UltraButton3, 0)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.UCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Taula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tap_Principal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tap_Principal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GRD As M_UltraGrid.m_UltraGrid
    Friend WithEvents C_Taula As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Tap_Principal As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Btn_Apli As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UCP As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
End Class
