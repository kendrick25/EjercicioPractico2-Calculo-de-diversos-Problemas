<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Problema3))
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Closepageform3 = New Button()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        ErrorTonelada = New Label()
        Errokm = New Label()
        errorunidad = New Label()
        labelUnidades = New Label()
        labeltextUnidades = New Label()
        PrecioUnidad = New TextBox()
        labeltextprecioUnidad = New Label()
        PrecioTotal = New Label()
        preciotexttotal = New Label()
        Toneladas = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        KmRecorrido = New TextBox()
        Label1 = New Label()
        Listvehiculos = New ComboBox()
        menusliptt = New Button()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 39F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(673, 355)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 75F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 75F))
        TableLayoutPanel2.Controls.Add(menusliptt, 0, 0)
        TableLayoutPanel2.Controls.Add(Closepageform3, 2, 0)
        TableLayoutPanel2.Controls.Add(Label4, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(673, 39)
        TableLayoutPanel2.TabIndex = 4
        ' 
        ' Closepageform3
        ' 
        Closepageform3.BackColor = Color.Red
        Closepageform3.Dock = DockStyle.Fill
        Closepageform3.FlatAppearance.BorderSize = 0
        Closepageform3.FlatStyle = FlatStyle.Flat
        Closepageform3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Closepageform3.ForeColor = Color.White
        Closepageform3.Location = New Point(598, 0)
        Closepageform3.Margin = New Padding(0)
        Closepageform3.Name = "Closepageform3"
        Closepageform3.Size = New Size(75, 39)
        Closepageform3.TabIndex = 2
        Closepageform3.Text = "Finalizar"
        Closepageform3.UseVisualStyleBackColor = False
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
        Label4.Size = New Size(523, 39)
        Label4.TabIndex = 9
        Label4.Text = "Importe a Pagar por un Vehículo"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(ErrorTonelada)
        Panel1.Controls.Add(Errokm)
        Panel1.Controls.Add(errorunidad)
        Panel1.Controls.Add(labelUnidades)
        Panel1.Controls.Add(labeltextUnidades)
        Panel1.Controls.Add(PrecioUnidad)
        Panel1.Controls.Add(labeltextprecioUnidad)
        Panel1.Controls.Add(PrecioTotal)
        Panel1.Controls.Add(preciotexttotal)
        Panel1.Controls.Add(Toneladas)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(KmRecorrido)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Listvehiculos)
        Panel1.Dock = DockStyle.Fill
        Panel1.ForeColor = Color.Blue
        Panel1.Location = New Point(0, 39)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(673, 316)
        Panel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.Location = New Point(358, 3)
        Panel2.MaximumSize = New Size(260, 200)
        Panel2.MinimumSize = New Size(260, 200)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(260, 200)
        Panel2.TabIndex = 18
        ' 
        ' ErrorTonelada
        ' 
        ErrorTonelada.AutoSize = True
        ErrorTonelada.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ErrorTonelada.ForeColor = Color.Red
        ErrorTonelada.Location = New Point(9, 175)
        ErrorTonelada.Margin = New Padding(0)
        ErrorTonelada.MaximumSize = New Size(20, 25)
        ErrorTonelada.MinimumSize = New Size(20, 25)
        ErrorTonelada.Name = "ErrorTonelada"
        ErrorTonelada.Size = New Size(20, 25)
        ErrorTonelada.TabIndex = 17
        ErrorTonelada.Text = "*"
        ' 
        ' Errokm
        ' 
        Errokm.AutoSize = True
        Errokm.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Errokm.ForeColor = Color.Red
        Errokm.Location = New Point(195, 89)
        Errokm.Margin = New Padding(0)
        Errokm.MaximumSize = New Size(20, 25)
        Errokm.MinimumSize = New Size(20, 25)
        Errokm.Name = "Errokm"
        Errokm.Size = New Size(20, 25)
        Errokm.TabIndex = 15
        Errokm.Text = "*"
        ' 
        ' errorunidad
        ' 
        errorunidad.AutoSize = True
        errorunidad.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        errorunidad.ForeColor = Color.Red
        errorunidad.Location = New Point(195, 174)
        errorunidad.Margin = New Padding(0)
        errorunidad.MaximumSize = New Size(20, 25)
        errorunidad.MinimumSize = New Size(20, 25)
        errorunidad.Name = "errorunidad"
        errorunidad.Size = New Size(20, 25)
        errorunidad.TabIndex = 14
        errorunidad.Text = "*"
        ' 
        ' labelUnidades
        ' 
        labelUnidades.AutoSize = True
        labelUnidades.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        labelUnidades.ForeColor = Color.Black
        labelUnidades.Location = New Point(12, 250)
        labelUnidades.MinimumSize = New Size(150, 20)
        labelUnidades.Name = "labelUnidades"
        labelUnidades.Size = New Size(150, 21)
        labelUnidades.TabIndex = 13
        labelUnidades.Text = "#"
        ' 
        ' labeltextUnidades
        ' 
        labeltextUnidades.AutoSize = True
        labeltextUnidades.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        labeltextUnidades.ForeColor = Color.Blue
        labeltextUnidades.Location = New Point(12, 208)
        labeltextUnidades.MinimumSize = New Size(150, 20)
        labeltextUnidades.Name = "labeltextUnidades"
        labeltextUnidades.Size = New Size(153, 21)
        labeltextUnidades.TabIndex = 12
        labeltextUnidades.Text = "Total de unidades :"
        ' 
        ' PrecioUnidad
        ' 
        PrecioUnidad.Location = New Point(198, 151)
        PrecioUnidad.Margin = New Padding(0)
        PrecioUnidad.MaximumSize = New Size(150, 23)
        PrecioUnidad.MinimumSize = New Size(150, 23)
        PrecioUnidad.Name = "PrecioUnidad"
        PrecioUnidad.PlaceholderText = "B/."
        PrecioUnidad.Size = New Size(150, 23)
        PrecioUnidad.TabIndex = 11
        ' 
        ' labeltextprecioUnidad
        ' 
        labeltextprecioUnidad.AutoSize = True
        labeltextprecioUnidad.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        labeltextprecioUnidad.ForeColor = Color.Blue
        labeltextprecioUnidad.Location = New Point(194, 111)
        labeltextprecioUnidad.MinimumSize = New Size(150, 20)
        labeltextprecioUnidad.Name = "labeltextprecioUnidad"
        labeltextprecioUnidad.Size = New Size(154, 21)
        labeltextprecioUnidad.TabIndex = 10
        labeltextprecioUnidad.Text = "Precio por unidad: "
        ' 
        ' PrecioTotal
        ' 
        PrecioTotal.AutoSize = True
        PrecioTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PrecioTotal.ForeColor = Color.Black
        PrecioTotal.Location = New Point(198, 250)
        PrecioTotal.MinimumSize = New Size(150, 20)
        PrecioTotal.Name = "PrecioTotal"
        PrecioTotal.Size = New Size(150, 21)
        PrecioTotal.TabIndex = 8
        PrecioTotal.Text = "Precio"
        ' 
        ' preciotexttotal
        ' 
        preciotexttotal.AutoSize = True
        preciotexttotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        preciotexttotal.ForeColor = Color.Blue
        preciotexttotal.Location = New Point(194, 208)
        preciotexttotal.MinimumSize = New Size(150, 20)
        preciotexttotal.Name = "preciotexttotal"
        preciotexttotal.Size = New Size(150, 21)
        preciotexttotal.TabIndex = 7
        preciotexttotal.Text = "Precio Total :"
        ' 
        ' Toneladas
        ' 
        Toneladas.Location = New Point(12, 152)
        Toneladas.Margin = New Padding(0)
        Toneladas.MaximumSize = New Size(150, 23)
        Toneladas.MinimumSize = New Size(150, 23)
        Toneladas.Name = "Toneladas"
        Toneladas.PlaceholderText = "T"
        Toneladas.Size = New Size(150, 23)
        Toneladas.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(12, 111)
        Label5.MinimumSize = New Size(150, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 21)
        Label5.TabIndex = 5
        Label5.Text = "Toneladas : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(12, 25)
        Label2.MinimumSize = New Size(150, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 21)
        Label2.TabIndex = 3
        Label2.Text = "Tipo de vehículo : "
        ' 
        ' KmRecorrido
        ' 
        KmRecorrido.Location = New Point(195, 66)
        KmRecorrido.Margin = New Padding(0)
        KmRecorrido.MaximumSize = New Size(150, 23)
        KmRecorrido.MinimumSize = New Size(150, 23)
        KmRecorrido.Name = "KmRecorrido"
        KmRecorrido.PlaceholderText = "Km"
        KmRecorrido.Size = New Size(150, 23)
        KmRecorrido.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(195, 26)
        Label1.MaximumSize = New Size(150, 20)
        Label1.MinimumSize = New Size(150, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 20)
        Label1.TabIndex = 1
        Label1.Text = "Km Recorridos : "
        ' 
        ' Listvehiculos
        ' 
        Listvehiculos.FormattingEnabled = True
        Listvehiculos.Location = New Point(12, 65)
        Listvehiculos.Margin = New Padding(0)
        Listvehiculos.MaximumSize = New Size(150, 0)
        Listvehiculos.MinimumSize = New Size(150, 0)
        Listvehiculos.Name = "Listvehiculos"
        Listvehiculos.Size = New Size(150, 23)
        Listvehiculos.TabIndex = 0
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
        menusliptt.TabIndex = 11
        menusliptt.UseVisualStyleBackColor = True
        ' 
        ' Problema3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(673, 355)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "Problema3"
        Text = "Form2"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Closepageform3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Listvehiculos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents KmRecorrido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrecioTotal As Label
    Friend WithEvents preciotexttotal As Label
    Friend WithEvents Toneladas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PrecioUnidad As TextBox
    Friend WithEvents labeltextprecioUnidad As Label
    Friend WithEvents labeltextUnidades As Label
    Friend WithEvents labelUnidades As Label
    Friend WithEvents ErrorTonelada As Label
    Friend WithEvents Errokm As Label
    Friend WithEvents errorunidad As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents menusliptt As Button
End Class
