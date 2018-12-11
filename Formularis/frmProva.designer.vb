<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProva
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
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProva))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.fieldNombre1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNumHores1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDescripcion1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolForm
        '
        Me.ToolForm.Size = New System.Drawing.Size(448, 24)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "Personal"
        Me.PivotGridControl1.DataSource = Me.SqlDataSource1
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldNombre1, Me.fieldNumHores1, Me.fieldDescripcion1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(12, 39)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(416, 155)
        Me.PivotGridControl1.TabIndex = 1
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "217.126.82.60_BDClarianaCentral_Connection 3"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery2.Name = "Personal"
        CustomSqlQuery2.Sql = resources.GetString("CustomSqlQuery2.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'fieldNombre1
        '
        Me.fieldNombre1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNombre1.AreaIndex = 0
        Me.fieldNombre1.FieldName = "Nombre"
        Me.fieldNombre1.Name = "fieldNombre1"
        Me.fieldNombre1.Width = 241
        '
        'fieldNumHores1
        '
        Me.fieldNumHores1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNumHores1.AreaIndex = 0
        Me.fieldNumHores1.CellFormat.FormatString = "0.00"
        Me.fieldNumHores1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldNumHores1.FieldName = "NumHores"
        Me.fieldNumHores1.Name = "fieldNumHores1"
        Me.fieldNumHores1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldDescripcion1
        '
        Me.fieldDescripcion1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldDescripcion1.AreaIndex = 0
        Me.fieldDescripcion1.FieldName = "Descripcion"
        Me.fieldDescripcion1.Name = "fieldDescripcion1"
        Me.fieldDescripcion1.Width = 134
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(536, 195)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(75, 23)
        Me.UltraButton1.TabIndex = 2
        Me.UltraButton1.Text = "UltraButton1"
        '
        'frmProva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 480)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.KeyPreview = True
        Me.Name = "frmProva"
        Me.Text = "Prova"
        Me.Controls.SetChildIndex(Me.ToolForm, 0)
        Me.Controls.SetChildIndex(Me.PivotGridControl1, 0)
        Me.Controls.SetChildIndex(Me.UltraButton1, 0)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents fieldNombre1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNumHores1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDescripcion1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
End Class
