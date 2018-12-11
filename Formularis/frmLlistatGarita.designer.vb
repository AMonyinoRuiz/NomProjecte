<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLlistatGarita
    'Inherits System.Windows.Forms.Form
    Inherits M_GenericForm.frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GRD = New M_UltraGrid.m_UltraGrid()
        Me.L_MovimientosDia = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_Fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.B_Buscar = New Infragistics.Win.Misc.UltraButton()
        CType(Me.DT_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GRD.Location = New System.Drawing.Point(12, 78)
        Me.GRD.Name = "GRD"
        Me.GRD.pAccessibleName = Nothing
        Me.GRD.pActivarBotonFiltro = False
        Me.GRD.pText = " "
        Me.GRD.Size = New System.Drawing.Size(984, 545)
        Me.GRD.TabIndex = 177
        '
        'L_MovimientosDia
        '
        Me.L_MovimientosDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_MovimientosDia.Location = New System.Drawing.Point(417, 39)
        Me.L_MovimientosDia.Name = "L_MovimientosDia"
        Me.L_MovimientosDia.Size = New System.Drawing.Size(433, 33)
        Me.L_MovimientosDia.TabIndex = 183
        Me.L_MovimientosDia.Text = "Movimientos del dia:"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 52)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(54, 18)
        Me.UltraLabel1.TabIndex = 184
        Me.UltraLabel1.Text = "Fecha:"
        '
        'DT_Fecha
        '
        Me.DT_Fecha.Location = New System.Drawing.Point(61, 47)
        Me.DT_Fecha.Name = "DT_Fecha"
        Me.DT_Fecha.Size = New System.Drawing.Size(92, 21)
        Me.DT_Fecha.TabIndex = 185
        '
        'B_Buscar
        '
        Me.B_Buscar.Location = New System.Drawing.Point(167, 47)
        Me.B_Buscar.Name = "B_Buscar"
        Me.B_Buscar.Size = New System.Drawing.Size(88, 21)
        Me.B_Buscar.TabIndex = 186
        Me.B_Buscar.Text = "Buscar"
        '
        'frmLlistatGarita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 635)
        Me.Controls.Add(Me.B_Buscar)
        Me.Controls.Add(Me.DT_Fecha)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.GRD)
        Me.Controls.Add(Me.L_MovimientosDia)
        Me.KeyPreview = True
        Me.Name = "frmLlistatGarita"
        Me.Text = "Listado de movimientos para la garita"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.L_MovimientosDia, 0)
        Me.Controls.SetChildIndex(Me.GRD, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel1, 0)
        Me.Controls.SetChildIndex(Me.DT_Fecha, 0)
        Me.Controls.SetChildIndex(Me.B_Buscar, 0)
        CType(Me.DT_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRD As M_UltraGrid.m_UltraGrid
    Friend WithEvents L_MovimientosDia As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DT_Fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents B_Buscar As Infragistics.Win.Misc.UltraButton
End Class
