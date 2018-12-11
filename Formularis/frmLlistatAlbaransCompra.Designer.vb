<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLlistatAlbaransCompra
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
        Me.GRD = New M_UltraGrid.m_UltraGrid()
        Me.C_Planta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.Validar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DT_Fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_Inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.CH_RAE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.OP = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CH_RAE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.pMode_Toolbar = m_ToolForm.clsToolForm.Enum_ToolMode.Sortir
        Me.ToolForm.Size = New System.Drawing.Size(125, 24)
        '
        'GRD
        '
        Me.GRD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRD.Location = New System.Drawing.Point(12, 93)
        Me.GRD.Name = "GRD"
        Me.GRD.pAccessibleName = Nothing
        Me.GRD.pActivarBotonFiltro = False
        Me.GRD.pText = " "
        Me.GRD.Size = New System.Drawing.Size(984, 530)
        Me.GRD.TabIndex = 177
        '
        'C_Planta
        '
        Me.C_Planta.Location = New System.Drawing.Point(12, 58)
        Me.C_Planta.Name = "C_Planta"
        Me.C_Planta.Size = New System.Drawing.Size(211, 21)
        Me.C_Planta.TabIndex = 0
        Me.C_Planta.Text = "C_Planta"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(12, 43)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel6.TabIndex = 181
        Me.UltraLabel6.Text = "*Planta:"
        '
        'Validar
        '
        Me.Validar.Location = New System.Drawing.Point(773, 56)
        Me.Validar.Name = "Validar"
        Me.Validar.Size = New System.Drawing.Size(72, 25)
        Me.Validar.TabIndex = 3
        Me.Validar.Text = "Buscar"
        Me.Validar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DT_Fin
        '
        Me.DT_Fin.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Fin.Location = New System.Drawing.Point(337, 58)
        Me.DT_Fin.Name = "DT_Fin"
        Me.DT_Fin.Size = New System.Drawing.Size(91, 21)
        Me.DT_Fin.TabIndex = 188
        Me.DT_Fin.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(337, 43)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel3.TabIndex = 189
        Me.UltraLabel3.Text = "*Fecha fin:"
        '
        'DT_Inicio
        '
        Me.DT_Inicio.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Inicio.Location = New System.Drawing.Point(239, 58)
        Me.DT_Inicio.MaskInput = "{date}"
        Me.DT_Inicio.Name = "DT_Inicio"
        Me.DT_Inicio.Size = New System.Drawing.Size(80, 21)
        Me.DT_Inicio.TabIndex = 186
        Me.DT_Inicio.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(239, 43)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel10.TabIndex = 187
        Me.UltraLabel10.Text = "*Fecha inicio:"
        '
        'CH_RAE
        '
        Me.CH_RAE.Location = New System.Drawing.Point(434, 56)
        Me.CH_RAE.Name = "CH_RAE"
        Me.CH_RAE.Size = New System.Drawing.Size(190, 23)
        Me.CH_RAE.TabIndex = 309
        Me.CH_RAE.Text = "Sólo visualizar los artículos RAE"
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
        Me.OP.Location = New System.Drawing.Point(619, 48)
        Me.OP.Name = "OP"
        Me.OP.Size = New System.Drawing.Size(139, 44)
        Me.OP.TabIndex = 322
        Me.OP.Text = "Albaranes de compra"
        '
        'frmLlistatAlbaransCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 635)
        Me.Controls.Add(Me.OP)
        Me.Controls.Add(Me.CH_RAE)
        Me.Controls.Add(Me.DT_Fin)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.DT_Inicio)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.Validar)
        Me.Controls.Add(Me.C_Planta)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.GRD)
        Me.KeyPreview = True
        Me.Name = "frmLlistatAlbaransCompra"
        Me.Text = "Listado líneas de albaranes"
        Me.Controls.SetChildIndex(Me.GRD, 0)
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel6, 0)
        Me.Controls.SetChildIndex(Me.C_Planta, 0)
        Me.Controls.SetChildIndex(Me.Validar, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel10, 0)
        Me.Controls.SetChildIndex(Me.DT_Inicio, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel3, 0)
        Me.Controls.SetChildIndex(Me.DT_Fin, 0)
        Me.Controls.SetChildIndex(Me.CH_RAE, 0)
        Me.Controls.SetChildIndex(Me.OP, 0)
        CType(Me.C_Planta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CH_RAE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRD As M_UltraGrid.m_UltraGrid
    Friend WithEvents C_Planta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Validar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DT_Fin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DT_Inicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CH_RAE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents OP As Infragistics.Win.UltraWinEditors.UltraOptionSet
End Class
