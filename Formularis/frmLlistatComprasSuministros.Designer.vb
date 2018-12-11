<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLlistatComprasSuministros
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
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Buscar = New System.Windows.Forms.Button()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.GRD = New M_UltraGrid.m_UltraGrid()
        Me.DT_Fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_Inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.OP_Fecha = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OP_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.pMode_Toolbar = m_ToolForm.clsToolForm.Enum_ToolMode.Sortir
        Me.ToolForm.Size = New System.Drawing.Size(379, 24)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(526, 55)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(72, 25)
        Me.Buscar.TabIndex = 183
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(224, 39)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel6.TabIndex = 184
        Me.UltraLabel6.Text = "*Año:"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(368, 39)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel1.TabIndex = 186
        Me.UltraLabel1.Text = "*Mes:"
        '
        'GRD
        '
        Me.GRD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRD.Location = New System.Drawing.Point(12, 101)
        Me.GRD.Name = "GRD"
        Me.GRD.pAccessibleName = Nothing
        Me.GRD.pActivarBotonFiltro = False
        Me.GRD.pText = " "
        Me.GRD.Size = New System.Drawing.Size(1238, 522)
        Me.GRD.TabIndex = 187
        '
        'DT_Fin
        '
        Me.DT_Fin.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Fin.Location = New System.Drawing.Point(368, 57)
        Me.DT_Fin.Name = "DT_Fin"
        Me.DT_Fin.Size = New System.Drawing.Size(124, 21)
        Me.DT_Fin.TabIndex = 264
        Me.DT_Fin.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(368, 38)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(153, 16)
        Me.UltraLabel3.TabIndex = 265
        Me.UltraLabel3.Text = "*Fecha fin:"
        '
        'DT_Inicio
        '
        Me.DT_Inicio.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Inicio.Location = New System.Drawing.Point(224, 57)
        Me.DT_Inicio.MaskInput = "{date}"
        Me.DT_Inicio.Name = "DT_Inicio"
        Me.DT_Inicio.Size = New System.Drawing.Size(124, 21)
        Me.DT_Inicio.TabIndex = 262
        Me.DT_Inicio.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(224, 39)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(140, 16)
        Me.UltraLabel10.TabIndex = 263
        Me.UltraLabel10.Text = "*Fecha inicio:"
        '
        'OP_Fecha
        '
        Me.OP_Fecha.CheckedIndex = 0
        ValueListItem2.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem2.DataValue = "No_filtrar"
        ValueListItem2.DisplayText = "Sin agrupar"
        ValueListItem2.Tag = "1"
        ValueListItem3.DataValue = "agrupado_articulo"
        ValueListItem3.DisplayText = "Agrupado por artículo"
        ValueListItem3.Tag = "2"
        ValueListItem1.DataValue = "agrupacio_producto_proveedor"
        ValueListItem1.DisplayText = "Agrupado por artículo y proveedor"
        Me.OP_Fecha.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3, ValueListItem1})
        Me.OP_Fecha.Location = New System.Drawing.Point(12, 33)
        Me.OP_Fecha.Name = "OP_Fecha"
        Me.OP_Fecha.Size = New System.Drawing.Size(197, 62)
        Me.OP_Fecha.TabIndex = 266
        Me.OP_Fecha.Text = "Sin agrupar"
        '
        'frmLlistatComprasSuministros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 635)
        Me.Controls.Add(Me.OP_Fecha)
        Me.Controls.Add(Me.DT_Fin)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.DT_Inicio)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.GRD)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.UltraLabel6)
        Me.KeyPreview = True
        Me.Name = "frmLlistatComprasSuministros"
        Me.Text = "Compras de suministros"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel6, 0)
        Me.Controls.SetChildIndex(Me.Buscar, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel1, 0)
        Me.Controls.SetChildIndex(Me.GRD, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel10, 0)
        Me.Controls.SetChildIndex(Me.DT_Inicio, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel3, 0)
        Me.Controls.SetChildIndex(Me.DT_Fin, 0)
        Me.Controls.SetChildIndex(Me.OP_Fecha, 0)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OP_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents GRD As M_UltraGrid.m_UltraGrid
    Friend WithEvents DT_Fin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DT_Inicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents OP_Fecha As Infragistics.Win.UltraWinEditors.UltraOptionSet
End Class
