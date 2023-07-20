<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Problema1))
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Limpiarp1 = New Button()
        Calcular = New Button()
        Error5 = New Label()
        Error4 = New Label()
        Dias = New ComboBox()
        sLabel = New Label()
        dLabel = New Label()
        Semana = New TextBox()
        Error3 = New Label()
        Error2 = New Label()
        Error1 = New Label()
        estado = New Label()
        Modo = New ComboBox()
        Label3 = New Label()
        SalarioPagado = New TextBox()
        Sueldo = New Label()
        Label1 = New Label()
        HorasIngresadas = New TextBox()
        Button2 = New TableLayoutPanel()
        Label4 = New Label()
        Closepageform = New Button()
        menusliptt = New Button()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Button2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel1.Controls.Add(Button2, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 39F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(631, 410)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Limpiarp1)
        Panel2.Controls.Add(Calcular)
        Panel2.Controls.Add(Error5)
        Panel2.Controls.Add(Error4)
        Panel2.Controls.Add(Dias)
        Panel2.Controls.Add(sLabel)
        Panel2.Controls.Add(dLabel)
        Panel2.Controls.Add(Semana)
        Panel2.Controls.Add(Error3)
        Panel2.Controls.Add(Error2)
        Panel2.Controls.Add(Error1)
        Panel2.Controls.Add(estado)
        Panel2.Controls.Add(Modo)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(SalarioPagado)
        Panel2.Controls.Add(Sueldo)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(HorasIngresadas)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 39)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(631, 371)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(60, 155)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.MaximumSize = New Size(199, 137)
        PictureBox1.MinimumSize = New Size(199, 137)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(199, 137)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Limpiarp1
        ' 
        Limpiarp1.BackColor = Color.Black
        Limpiarp1.FlatAppearance.BorderSize = 0
        Limpiarp1.FlatAppearance.MouseOverBackColor = Color.Silver
        Limpiarp1.FlatStyle = FlatStyle.Flat
        Limpiarp1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Limpiarp1.ForeColor = Color.White
        Limpiarp1.Location = New Point(286, 252)
        Limpiarp1.Margin = New Padding(0)
        Limpiarp1.MaximumSize = New Size(150, 23)
        Limpiarp1.MinimumSize = New Size(150, 40)
        Limpiarp1.Name = "Limpiarp1"
        Limpiarp1.Size = New Size(150, 40)
        Limpiarp1.TabIndex = 19
        Limpiarp1.Text = "Limpiar campos"
        Limpiarp1.UseVisualStyleBackColor = False
        ' 
        ' Calcular
        ' 
        Calcular.BackColor = Color.MidnightBlue
        Calcular.FlatAppearance.BorderSize = 0
        Calcular.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Calcular.FlatStyle = FlatStyle.Flat
        Calcular.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Calcular.ForeColor = Color.White
        Calcular.Location = New Point(475, 252)
        Calcular.Margin = New Padding(0)
        Calcular.MaximumSize = New Size(90, 40)
        Calcular.MinimumSize = New Size(90, 40)
        Calcular.Name = "Calcular"
        Calcular.Size = New Size(90, 40)
        Calcular.TabIndex = 18
        Calcular.Text = "Calcular"
        Calcular.UseVisualStyleBackColor = False
        ' 
        ' Error5
        ' 
        Error5.AutoSize = True
        Error5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Error5.ForeColor = Color.Red
        Error5.Location = New Point(530, 193)
        Error5.Name = "Error5"
        Error5.Size = New Size(24, 32)
        Error5.TabIndex = 17
        Error5.Text = "*"
        ' 
        ' Error4
        ' 
        Error4.AutoSize = True
        Error4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Error4.ForeColor = Color.Red
        Error4.Location = New Point(375, 193)
        Error4.Name = "Error4"
        Error4.Size = New Size(24, 32)
        Error4.TabIndex = 16
        Error4.Text = "*"
        ' 
        ' Dias
        ' 
        Dias.FormattingEnabled = True
        Dias.Location = New Point(291, 167)
        Dias.Name = "Dias"
        Dias.Size = New Size(108, 23)
        Dias.TabIndex = 15
        ' 
        ' sLabel
        ' 
        sLabel.AutoSize = True
        sLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        sLabel.ForeColor = Color.White
        sLabel.Location = New Point(454, 123)
        sLabel.Name = "sLabel"
        sLabel.Size = New Size(86, 21)
        sLabel.TabIndex = 14
        sLabel.Text = "Semanas :"
        ' 
        ' dLabel
        ' 
        dLabel.AutoSize = True
        dLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dLabel.ForeColor = Color.White
        dLabel.Location = New Point(291, 123)
        dLabel.Name = "dLabel"
        dLabel.Size = New Size(44, 21)
        dLabel.TabIndex = 13
        dLabel.Text = "Día :"
        ' 
        ' Semana
        ' 
        Semana.Location = New Point(444, 167)
        Semana.Name = "Semana"
        Semana.PlaceholderText = " # de semanas"
        Semana.Size = New Size(121, 23)
        Semana.TabIndex = 12
        ' 
        ' Error3
        ' 
        Error3.AutoSize = True
        Error3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Error3.ForeColor = Color.Red
        Error3.Location = New Point(175, 82)
        Error3.Name = "Error3"
        Error3.Size = New Size(24, 32)
        Error3.TabIndex = 10
        Error3.Text = "*"
        ' 
        ' Error2
        ' 
        Error2.AutoSize = True
        Error2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Error2.ForeColor = Color.Red
        Error2.Location = New Point(375, 98)
        Error2.Name = "Error2"
        Error2.Size = New Size(24, 32)
        Error2.TabIndex = 9
        Error2.Text = "*"
        ' 
        ' Error1
        ' 
        Error1.AutoSize = True
        Error1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Error1.ForeColor = Color.Red
        Error1.Location = New Point(541, 98)
        Error1.Name = "Error1"
        Error1.Size = New Size(24, 32)
        Error1.TabIndex = 8
        Error1.Text = "*"
        ' 
        ' estado
        ' 
        estado.AutoSize = True
        estado.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        estado.ForeColor = Color.White
        estado.Location = New Point(27, 295)
        estado.Name = "estado"
        estado.Size = New Size(232, 21)
        estado.TabIndex = 7
        estado.Text = "Salario que se le debe pagar :"
        ' 
        ' Modo
        ' 
        Modo.FormattingEnabled = True
        Modo.Location = New Point(444, 60)
        Modo.Name = "Modo"
        Modo.Size = New Size(121, 23)
        Modo.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(233, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 21)
        Label3.TabIndex = 5
        Label3.Text = "Salario del trabajador :"
        ' 
        ' SalarioPagado
        ' 
        SalarioPagado.Location = New Point(291, 60)
        SalarioPagado.Name = "SalarioPagado"
        SalarioPagado.PlaceholderText = "B/. "
        SalarioPagado.Size = New Size(108, 23)
        SalarioPagado.TabIndex = 4
        ' 
        ' Sueldo
        ' 
        Sueldo.AutoSize = True
        Sueldo.BackColor = Color.Gray
        Sueldo.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Sueldo.ForeColor = Color.White
        Sueldo.Location = New Point(159, 331)
        Sueldo.Margin = New Padding(0)
        Sueldo.Name = "Sueldo"
        Sueldo.Padding = New Padding(3)
        Sueldo.Size = New Size(61, 31)
        Sueldo.TabIndex = 3
        Sueldo.Text = "0.00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 21)
        Label1.TabIndex = 2
        Label1.Text = "Horas del trabajador :"
        ' 
        ' HorasIngresadas
        ' 
        HorasIngresadas.Location = New Point(99, 60)
        HorasIngresadas.Name = "HorasIngresadas"
        HorasIngresadas.PlaceholderText = " Hrs"
        HorasIngresadas.Size = New Size(100, 23)
        HorasIngresadas.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.ColumnCount = 3
        Button2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 36F))
        Button2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Button2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 75F))
        Button2.Controls.Add(Label4, 1, 0)
        Button2.Controls.Add(Closepageform, 2, 0)
        Button2.Controls.Add(menusliptt, 0, 0)
        Button2.Dock = DockStyle.Fill
        Button2.Location = New Point(0, 0)
        Button2.Margin = New Padding(0)
        Button2.MaximumSize = New Size(0, 39)
        Button2.Name = "Button2"
        Button2.RowCount = 1
        Button2.RowStyles.Add(New RowStyle(SizeType.Absolute, 39F))
        Button2.Size = New Size(631, 39)
        Button2.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label4.Location = New Point(36, 0)
        Label4.Margin = New Padding(0)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(38, 0, 0, 0)
        Label4.Size = New Size(520, 39)
        Label4.TabIndex = 8
        Label4.Text = "Calcular el Salario Semanal "
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Closepageform
        ' 
        Closepageform.BackColor = Color.Red
        Closepageform.Cursor = Cursors.Hand
        Closepageform.Dock = DockStyle.Fill
        Closepageform.FlatAppearance.BorderSize = 0
        Closepageform.FlatStyle = FlatStyle.Flat
        Closepageform.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Closepageform.ForeColor = Color.White
        Closepageform.Location = New Point(556, 0)
        Closepageform.Margin = New Padding(0)
        Closepageform.MaximumSize = New Size(75, 39)
        Closepageform.MinimumSize = New Size(75, 39)
        Closepageform.Name = "Closepageform"
        Closepageform.Size = New Size(75, 39)
        Closepageform.TabIndex = 0
        Closepageform.Text = "Finalizar"
        Closepageform.UseVisualStyleBackColor = False
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
        menusliptt.TabIndex = 9
        menusliptt.UseVisualStyleBackColor = True
        ' 
        ' Problema1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(631, 410)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        Name = "Problema1"
        ShowIcon = False
        Text = "Form2"
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Button2.ResumeLayout(False)
        Button2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HorasIngresadas As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SalarioPagado As TextBox
    Friend WithEvents Sueldo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Modo As ComboBox
    Friend WithEvents estado As Label
    Friend WithEvents Error1 As Label
    Friend WithEvents Error3 As Label
    Friend WithEvents Error2 As Label
    Friend WithEvents Error5 As Label
    Friend WithEvents Error4 As Label
    Friend WithEvents Dias As ComboBox
    Friend WithEvents sLabel As Label
    Friend WithEvents dLabel As Label
    Friend WithEvents Semana As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiarp1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As TableLayoutPanel
    Friend WithEvents menusliptt As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Closepageform As Button
End Class
