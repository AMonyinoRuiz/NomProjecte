<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLlistatAlbaransSAGE
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
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GRD_Clientes = New M_UltraGrid.m_UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GRD = New M_UltraGrid.m_UltraGrid()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Buscar = New System.Windows.Forms.Button()
        Me.DT_FechaInicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_Planta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_fechaFin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_FechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_fechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.pMode_Toolbar = m_ToolForm.clsToolForm.Enum_ToolMode.Sortir
        Me.ToolForm.Size = New System.Drawing.Size(379, 24)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.GRD_Clientes)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1234, 505)
        '
        'GRD_Clientes
        '
        Me.GRD_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRD_Clientes.Location = New System.Drawing.Point(0, 0)
        Me.GRD_Clientes.Name = "GRD_Clientes"
        Me.GRD_Clientes.pAccessibleName = Nothing
        Me.GRD_Clientes.pActivarBotonFiltro = False
        Me.GRD_Clientes.pText = " "
        Me.GRD_Clientes.Size = New System.Drawing.Size(1234, 505)
        Me.GRD_Clientes.TabIndex = 188
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.GRD)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1234, 505)
        '
        'GRD
        '
        Me.GRD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRD.Location = New System.Drawing.Point(0, 0)
        Me.GRD.Name = "GRD"
        Me.GRD.pAccessibleName = Nothing
        Me.GRD.pActivarBotonFiltro = False
        Me.GRD.pText = " "
        Me.GRD.Size = New System.Drawing.Size(1234, 505)
        Me.GRD.TabIndex = 187
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(436, 58)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(72, 25)
        Me.Buscar.TabIndex = 183
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'DT_FechaInicio
        '
        Me.DT_FechaInicio.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_FechaInicio.Location = New System.Drawing.Point(182, 60)
        Me.DT_FechaInicio.MaskInput = "{date}"
        Me.DT_FechaInicio.Name = "DT_FechaInicio"
        Me.DT_FechaInicio.Size = New System.Drawing.Size(108, 21)
        Me.DT_FechaInicio.TabIndex = 262
        Me.DT_FechaInicio.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(182, 44)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(108, 16)
        Me.UltraLabel10.TabIndex = 263
        Me.UltraLabel10.Text = "*Fecha inicio:"
        '
        'C_Planta
        '
        Me.C_Planta.Location = New System.Drawing.Point(12, 60)
        Me.C_Planta.Name = "C_Planta"
        Me.C_Planta.Size = New System.Drawing.Size(149, 21)
        Me.C_Planta.TabIndex = 266
        Me.C_Planta.Text = "C_Planta"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(12, 45)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel6.TabIndex = 267
        Me.UltraLabel6.Text = "*Planta:"
        '
        'DT_fechaFin
        '
        Me.DT_fechaFin.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_fechaFin.Location = New System.Drawing.Point(311, 60)
        Me.DT_fechaFin.MaskInput = "{date}"
        Me.DT_fechaFin.Name = "DT_fechaFin"
        Me.DT_fechaFin.Size = New System.Drawing.Size(108, 21)
        Me.DT_fechaFin.TabIndex = 268
        Me.DT_fechaFin.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(311, 44)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(108, 16)
        Me.UltraLabel1.TabIndex = 269
        Me.UltraLabel1.Text = "*Fecha fin:"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Location = New System.Drawing.Point(12, 92)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(1238, 531)
        Me.UltraTabControl1.TabIndex = 270
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Albaranes de venta"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Albaranes de compra"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1234, 505)
        '
        'frmLlistatAlbaransSAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 635)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.DT_fechaFin)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.C_Planta)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.DT_FechaInicio)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.Buscar)
        Me.KeyPreview = True
        Me.Name = "frmLlistatAlbaransSAGE"
        Me.Text = "Listado de albaranes"
        Me.Controls.SetChildIndex(Me.Buscar, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel10, 0)
        Me.Controls.SetChildIndex(Me.DT_FechaInicio, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel6, 0)
        Me.Controls.SetChildIndex(Me.C_Planta, 0)
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel1, 0)
        Me.Controls.SetChildIndex(Me.DT_fechaFin, 0)
        Me.Controls.SetChildIndex(Me.UltraTabControl1, 0)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_FechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_fechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents DT_FechaInicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_Planta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents GRD As M_UltraGrid.m_UltraGrid
    Friend WithEvents DT_fechaFin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GRD_Clientes As M_UltraGrid.m_UltraGrid
End Class
