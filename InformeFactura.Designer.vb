<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeFactura
    Inherits System.Windows.Forms.Form

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
        NClient = New Label()
        Label2 = New Label()
        NMontoFinal = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NClient
        ' 
        NClient.AutoSize = True
        NClient.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        NClient.ForeColor = Color.Black
        NClient.Location = New Point(193, 54)
        NClient.Name = "NClient"
        NClient.Size = New Size(0, 32)
        NClient.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(149, 403)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 21)
        Label2.TabIndex = 1
        Label2.Text = "Monto Mensual a Pagar : "
        ' 
        ' NMontoFinal
        ' 
        NMontoFinal.AutoSize = True
        NMontoFinal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        NMontoFinal.ForeColor = Color.Red
        NMontoFinal.Location = New Point(417, 408)
        NMontoFinal.Name = "NMontoFinal"
        NMontoFinal.Size = New Size(43, 15)
        NMontoFinal.TabIndex = 2
        NMontoFinal.Text = "Label3"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(12, 119)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(612, 247)
        DataGridView1.TabIndex = 3
        ' 
        ' Column1
        ' 
        Column1.Frozen = True
        Column1.HeaderText = "# Factura"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.Frozen = True
        Column2.HeaderText = "Minutos"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.Frozen = True
        Column3.HeaderText = "Tipo de Llamada"
        Column3.Name = "Column3"
        Column3.Width = 170
        ' 
        ' Column4
        ' 
        Column4.Frozen = True
        Column4.HeaderText = "Recargo"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.Frozen = True
        Column5.HeaderText = "Monto (B/.)"
        Column5.Name = "Column5"
        ' 
        ' InformeFactura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(630, 456)
        Controls.Add(DataGridView1)
        Controls.Add(NMontoFinal)
        Controls.Add(Label2)
        Controls.Add(NClient)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "InformeFactura"
        ShowIcon = False
        Text = "Factura"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NClient As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NMontoFinal As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
