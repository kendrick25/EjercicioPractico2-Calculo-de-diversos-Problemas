<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Problema2))
        Closepageform2 = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        menusliptt = New Button()
        Label4 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        errorlab2 = New Label()
        BtnCalcularDeuda = New Button()
        erorrlabel3 = New Label()
        erro1lab = New Label()
        deudaLabel = New Label()
        Resultadointeres = New Label()
        IngresoInteres = New Label()
        mLabel = New Label()
        IngresoMonto = New TextBox()
        dLabel = New Label()
        DiasAtraso = New TextBox()
        iLabel = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Closepageform2
        ' 
        Closepageform2.BackColor = Color.Red
        Closepageform2.Dock = DockStyle.Fill
        Closepageform2.FlatAppearance.BorderSize = 0
        Closepageform2.FlatStyle = FlatStyle.Flat
        Closepageform2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Closepageform2.ForeColor = Color.White
        Closepageform2.Location = New Point(618, 0)
        Closepageform2.Margin = New Padding(0)
        Closepageform2.Name = "Closepageform2"
        Closepageform2.Size = New Size(75, 39)
        Closepageform2.TabIndex = 0
        Closepageform2.Text = "Finalizar"
        Closepageform2.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 39F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(693, 408)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(693, 39)
        Panel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 75F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 75F))
        TableLayoutPanel2.Controls.Add(menusliptt, 0, 0)
        TableLayoutPanel2.Controls.Add(Closepageform2, 2, 0)
        TableLayoutPanel2.Controls.Add(Label4, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 39F))
        TableLayoutPanel2.Size = New Size(693, 39)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' menusliptt
        ' 
        menusliptt.BackgroundImage = CType(resources.GetObject("menusliptt.BackgroundImage"), Image)
        menusliptt.BackgroundImageLayout = ImageLayout.Stretch
        menusliptt.Cursor = Cursors.Hand
        menusliptt.FlatAppearance.BorderSize = 0
        menusliptt.FlatAppearance.MouseOverBackColor = SystemColors.Control
        menusliptt.FlatStyle = FlatStyle.Flat
        menusliptt.Location = New Point(1, 0)
        menusliptt.Margin = New Padding(1, 0, 0, 0)
        menusliptt.MaximumSize = New Size(36, 39)
        menusliptt.MinimumSize = New Size(36, 39)
        menusliptt.Name = "menusliptt"
        menusliptt.Size = New Size(36, 39)
        menusliptt.TabIndex = 10
        menusliptt.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label4.Location = New Point(75, 0)
        Label4.Margin = New Padding(0)
        Label4.Name = "Label4"
        Label4.Size = New Size(543, 39)
        Label4.TabIndex = 9
        Label4.Text = "Soluciones, S.A - Calcular Deuda"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(errorlab2)
        Panel2.Controls.Add(BtnCalcularDeuda)
        Panel2.Controls.Add(erorrlabel3)
        Panel2.Controls.Add(erro1lab)
        Panel2.Controls.Add(deudaLabel)
        Panel2.Controls.Add(Resultadointeres)
        Panel2.Controls.Add(IngresoInteres)
        Panel2.Controls.Add(mLabel)
        Panel2.Controls.Add(IngresoMonto)
        Panel2.Controls.Add(dLabel)
        Panel2.Controls.Add(DiasAtraso)
        Panel2.Controls.Add(iLabel)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 39)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(693, 369)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(420, 71)
        PictureBox1.MaximumSize = New Size(230, 201)
        PictureBox1.MinimumSize = New Size(230, 201)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(230, 201)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' errorlab2
        ' 
        errorlab2.AutoSize = True
        errorlab2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        errorlab2.ForeColor = Color.Red
        errorlab2.Location = New Point(400, 115)
        errorlab2.Name = "errorlab2"
        errorlab2.Size = New Size(21, 25)
        errorlab2.TabIndex = 8
        errorlab2.Text = "*"
        ' 
        ' BtnCalcularDeuda
        ' 
        BtnCalcularDeuda.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        BtnCalcularDeuda.FlatAppearance.BorderSize = 0
        BtnCalcularDeuda.FlatStyle = FlatStyle.Flat
        BtnCalcularDeuda.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCalcularDeuda.ForeColor = Color.White
        BtnCalcularDeuda.Location = New Point(264, 174)
        BtnCalcularDeuda.MaximumSize = New Size(150, 44)
        BtnCalcularDeuda.MinimumSize = New Size(150, 44)
        BtnCalcularDeuda.Name = "BtnCalcularDeuda"
        BtnCalcularDeuda.Size = New Size(150, 44)
        BtnCalcularDeuda.TabIndex = 11
        BtnCalcularDeuda.Text = "Calcular"
        BtnCalcularDeuda.UseVisualStyleBackColor = False
        ' 
        ' erorrlabel3
        ' 
        erorrlabel3.AutoSize = True
        erorrlabel3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        erorrlabel3.ForeColor = Color.Red
        erorrlabel3.Location = New Point(400, 67)
        erorrlabel3.Name = "erorrlabel3"
        erorrlabel3.Size = New Size(21, 25)
        erorrlabel3.TabIndex = 9
        erorrlabel3.Text = "*"
        ' 
        ' erro1lab
        ' 
        erro1lab.AutoSize = True
        erro1lab.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        erro1lab.ForeColor = Color.Red
        erro1lab.Location = New Point(400, 15)
        erro1lab.Name = "erro1lab"
        erro1lab.Size = New Size(21, 25)
        erro1lab.TabIndex = 7
        erro1lab.Text = "*"
        ' 
        ' deudaLabel
        ' 
        deudaLabel.AutoSize = True
        deudaLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        deudaLabel.Location = New Point(-1, 241)
        deudaLabel.MaximumSize = New Size(281, 21)
        deudaLabel.MinimumSize = New Size(281, 21)
        deudaLabel.Name = "deudaLabel"
        deudaLabel.Size = New Size(281, 21)
        deudaLabel.TabIndex = 6
        deudaLabel.Text = "Monto a pagar por el cliente :"
        deudaLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Resultadointeres
        ' 
        Resultadointeres.AutoSize = True
        Resultadointeres.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Resultadointeres.ForeColor = Color.Red
        Resultadointeres.Location = New Point(273, 301)
        Resultadointeres.Name = "Resultadointeres"
        Resultadointeres.Size = New Size(21, 25)
        Resultadointeres.TabIndex = 10
        Resultadointeres.Text = "*"
        ' 
        ' IngresoInteres
        ' 
        IngresoInteres.AutoSize = True
        IngresoInteres.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        IngresoInteres.ForeColor = Color.Red
        IngresoInteres.Location = New Point(316, 115)
        IngresoInteres.Name = "IngresoInteres"
        IngresoInteres.Size = New Size(0, 21)
        IngresoInteres.TabIndex = 12
        ' 
        ' mLabel
        ' 
        mLabel.AutoSize = True
        mLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        mLabel.Location = New Point(3, 19)
        mLabel.MaximumSize = New Size(281, 21)
        mLabel.MinimumSize = New Size(281, 21)
        mLabel.Name = "mLabel"
        mLabel.Size = New Size(281, 21)
        mLabel.TabIndex = 1
        mLabel.Text = "Monto que adeuda el cliente : "
        mLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' IngresoMonto
        ' 
        IngresoMonto.Location = New Point(290, 16)
        IngresoMonto.Name = "IngresoMonto"
        IngresoMonto.Size = New Size(104, 23)
        IngresoMonto.TabIndex = 0
        ' 
        ' dLabel
        ' 
        dLabel.AutoSize = True
        dLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dLabel.Location = New Point(-1, 71)
        dLabel.MaximumSize = New Size(281, 21)
        dLabel.MinimumSize = New Size(281, 21)
        dLabel.Name = "dLabel"
        dLabel.Size = New Size(281, 21)
        dLabel.TabIndex = 5
        dLabel.Text = "Días de atraso  : "
        dLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' DiasAtraso
        ' 
        DiasAtraso.Location = New Point(290, 69)
        DiasAtraso.Name = "DiasAtraso"
        DiasAtraso.Size = New Size(104, 23)
        DiasAtraso.TabIndex = 4
        ' 
        ' iLabel
        ' 
        iLabel.AutoSize = True
        iLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        iLabel.Location = New Point(-1, 112)
        iLabel.MaximumSize = New Size(281, 21)
        iLabel.MinimumSize = New Size(281, 21)
        iLabel.Name = "iLabel"
        iLabel.Size = New Size(281, 21)
        iLabel.TabIndex = 2
        iLabel.Text = "Interés a pagar en el presente mes : "
        iLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Problema2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(693, 408)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Problema2"
        ShowIcon = False
        Text = "Form2"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Closepageform2 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents mLabel As Label
    Friend WithEvents dLabel As Label
    Friend WithEvents DiasAtraso As TextBox
    Friend WithEvents iLabel As Label
    Friend WithEvents deudaLabel As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Resultadointeres As Label
    Friend WithEvents erorrlabel3 As Label
    Friend WithEvents errorlab2 As Label
    Friend WithEvents erro1lab As Label
    Friend WithEvents IngresoMonto As TextBox
    Friend WithEvents BtnCalcularDeuda As Button
    Friend WithEvents IngresoInteres As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents menusliptt As Button
End Class
