<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonal_ListadoRanking
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_Any = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Any, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.pMode_Toolbar = m_ToolForm.clsToolForm.Enum_ToolMode.Sortir
        Me.ToolForm.Size = New System.Drawing.Size(125, 24)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(12, 43)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel10.TabIndex = 187
        Me.UltraLabel10.Text = "*Año:"
        '
        'C_Any
        '
        Me.C_Any.Location = New System.Drawing.Point(12, 58)
        Me.C_Any.Name = "C_Any"
        Me.C_Any.Size = New System.Drawing.Size(96, 21)
        Me.C_Any.TabIndex = 188
        Me.C_Any.Text = "C_Any"
        '
        'frmPersonal_ListadoRancking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 635)
        Me.Controls.Add(Me.C_Any)
        Me.Controls.Add(Me.UltraLabel10)
        Me.KeyPreview = True
        Me.Name = "frmPersonal_ListadoRancking"
        Me.Text = "Ranking de ausencias"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel10, 0)
        Me.Controls.SetChildIndex(Me.C_Any, 0)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Any, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_Any As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
