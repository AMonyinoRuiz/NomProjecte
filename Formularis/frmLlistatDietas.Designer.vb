﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLlistatDietas
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
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Buscar = New System.Windows.Forms.Button()
        Me.C_Ano = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.C_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.GRD = New M_UltraGrid.m_UltraGrid()
        Me.OP_Fecha = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.DT_Fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.DT_Inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Ano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OP_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Buscar.Location = New System.Drawing.Point(547, 50)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(72, 25)
        Me.Buscar.TabIndex = 183
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'C_Ano
        '
        Me.C_Ano.Location = New System.Drawing.Point(224, 57)
        Me.C_Ano.Name = "C_Ano"
        Me.C_Ano.Size = New System.Drawing.Size(124, 21)
        Me.C_Ano.TabIndex = 182
        Me.C_Ano.Text = "C_Ano"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(224, 36)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel6.TabIndex = 184
        Me.UltraLabel6.Text = "*Año:"
        '
        'C_Mes
        '
        Me.C_Mes.Location = New System.Drawing.Point(368, 57)
        Me.C_Mes.Name = "C_Mes"
        Me.C_Mes.Size = New System.Drawing.Size(148, 21)
        Me.C_Mes.TabIndex = 185
        Me.C_Mes.Text = "C_Mes"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(368, 36)
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
        Me.GRD.Location = New System.Drawing.Point(12, 86)
        Me.GRD.Name = "GRD"
        Me.GRD.pAccessibleName = Nothing
        Me.GRD.pActivarBotonFiltro = False
        Me.GRD.pText = " "
        Me.GRD.Size = New System.Drawing.Size(1238, 537)
        Me.GRD.TabIndex = 187
        '
        'OP_Fecha
        '
        Me.OP_Fecha.CheckedIndex = 0
        ValueListItem2.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem2.DataValue = "Meses"
        ValueListItem2.DisplayText = "FIltrar por meses"
        ValueListItem2.Tag = "1"
        ValueListItem3.DataValue = "fecha"
        ValueListItem3.DisplayText = "Filtrar por rango de fecha"
        ValueListItem3.Tag = "2"
        Me.OP_Fecha.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3})
        Me.OP_Fecha.Location = New System.Drawing.Point(12, 38)
        Me.OP_Fecha.Name = "OP_Fecha"
        Me.OP_Fecha.Size = New System.Drawing.Size(197, 47)
        Me.OP_Fecha.TabIndex = 261
        Me.OP_Fecha.Text = "FIltrar por meses"
        '
        'DT_Fin
        '
        Me.DT_Fin.DateTime = New Date(2007, 1, 23, 0, 0, 0, 0)
        Me.DT_Fin.Location = New System.Drawing.Point(368, 57)
        Me.DT_Fin.Name = "DT_Fin"
        Me.DT_Fin.Size = New System.Drawing.Size(148, 21)
        Me.DT_Fin.TabIndex = 264
        Me.DT_Fin.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(368, 35)
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
        Me.UltraLabel10.Location = New System.Drawing.Point(224, 36)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(140, 16)
        Me.UltraLabel10.TabIndex = 263
        Me.UltraLabel10.Text = "*Fecha inicio:"
        '
        'frmLlistatDietas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 635)
        Me.Controls.Add(Me.DT_Fin)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.DT_Inicio)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.OP_Fecha)
        Me.Controls.Add(Me.GRD)
        Me.Controls.Add(Me.C_Mes)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.C_Ano)
        Me.Controls.Add(Me.UltraLabel6)
        Me.KeyPreview = True
        Me.Name = "frmLlistatDietas"
        Me.Text = "Listado de dietas"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel6, 0)
        Me.Controls.SetChildIndex(Me.C_Ano, 0)
        Me.Controls.SetChildIndex(Me.Buscar, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel1, 0)
        Me.Controls.SetChildIndex(Me.C_Mes, 0)
        Me.Controls.SetChildIndex(Me.GRD, 0)
        Me.Controls.SetChildIndex(Me.OP_Fecha, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel10, 0)
        Me.Controls.SetChildIndex(Me.DT_Inicio, 0)
        Me.Controls.SetChildIndex(Me.UltraLabel3, 0)
        Me.Controls.SetChildIndex(Me.DT_Fin, 0)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Ano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OP_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents C_Ano As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents C_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents GRD As M_UltraGrid.m_UltraGrid
    Friend WithEvents OP_Fecha As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents DT_Fin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DT_Inicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
End Class
