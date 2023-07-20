<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Problema4))
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        menusliptt = New Button()
        Label4 = New Label()
        Closepageform4 = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Panel1 = New Panel()
        ErrorMensajeGRID = New Label()
        titutloRegistro = New Label()
        DataGridView1 = New DataGridView()
        Cliente = New DataGridViewTextBoxColumn()
        Factura = New DataGridViewTextBoxColumn()
        Minutostabla1 = New DataGridViewTextBoxColumn()
        TipoLLamada1 = New DataGridViewTextBoxColumn()
        Monto = New DataGridViewTextBoxColumn()
        Opciones = New DataGridViewTextBoxColumn()
        Ultimo = New DataGridViewTextBoxColumn()
        horarioTable = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        ErrorMinutos = New Label()
        ErrorFactura = New Label()
        ErrorCliiente = New Label()
        BtnAccionLLamada = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        ComboboxOpciones = New ComboBox()
        ComboboxTipoLlamada = New ComboBox()
        IngresoMinutos = New TextBox()
        NumFactura = New TextBox()
        NumCliente = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 39F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(745, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 75F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 75F))
        TableLayoutPanel2.Controls.Add(menusliptt, 0, 0)
        TableLayoutPanel2.Controls.Add(Label4, 1, 0)
        TableLayoutPanel2.Controls.Add(Closepageform4, 2, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(745, 39)
        TableLayoutPanel2.TabIndex = 0
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
        menusliptt.TabIndex = 12
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
        Label4.Size = New Size(595, 39)
        Label4.TabIndex = 10
        Label4.Text = "Registro de Compañía de Teléfono"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Closepageform4
        ' 
        Closepageform4.BackColor = Color.Red
        Closepageform4.Dock = DockStyle.Fill
        Closepageform4.FlatAppearance.BorderSize = 0
        Closepageform4.FlatStyle = FlatStyle.Flat
        Closepageform4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Closepageform4.ForeColor = Color.White
        Closepageform4.Location = New Point(670, 0)
        Closepageform4.Margin = New Padding(0)
        Closepageform4.Name = "Closepageform4"
        Closepageform4.Size = New Size(75, 39)
        Closepageform4.TabIndex = 0
        Closepageform4.Text = "Finalizar"
        Closepageform4.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(Panel1, 0, 1)
        TableLayoutPanel3.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 39)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(745, 411)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoScroll = True
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Controls.Add(ErrorMensajeGRID)
        Panel1.Controls.Add(titutloRegistro)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(0, 60)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(745, 351)
        Panel1.TabIndex = 0
        ' 
        ' ErrorMensajeGRID
        ' 
        ErrorMensajeGRID.AutoSize = True
        ErrorMensajeGRID.BackColor = Color.Transparent
        ErrorMensajeGRID.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        ErrorMensajeGRID.ForeColor = Color.Red
        ErrorMensajeGRID.Location = New Point(12, 9)
        ErrorMensajeGRID.Name = "ErrorMensajeGRID"
        ErrorMensajeGRID.Size = New Size(21, 25)
        ErrorMensajeGRID.TabIndex = 14
        ErrorMensajeGRID.Text = "*"
        ' 
        ' titutloRegistro
        ' 
        titutloRegistro.Anchor = AnchorStyles.Top
        titutloRegistro.AutoSize = True
        titutloRegistro.BackColor = Color.Transparent
        titutloRegistro.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        titutloRegistro.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        titutloRegistro.Location = New Point(280, 10)
        titutloRegistro.MaximumSize = New Size(118, 25)
        titutloRegistro.MinimumSize = New Size(200, 25)
        titutloRegistro.Name = "titutloRegistro"
        titutloRegistro.Size = New Size(200, 25)
        titutloRegistro.TabIndex = 2
        titutloRegistro.Text = "Registro de Clientes"
        titutloRegistro.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Cliente, Factura, Minutostabla1, TipoLLamada1, Monto, Opciones, Ultimo, horarioTable})
        DataGridView1.GridColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridView1.Location = New Point(12, 45)
        DataGridView1.Margin = New Padding(0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 40
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(724, 297)
        DataGridView1.TabIndex = 0
        ' 
        ' Cliente
        ' 
        Cliente.HeaderText = "Cliente"
        Cliente.MinimumWidth = 100
        Cliente.Name = "Cliente"
        Cliente.ReadOnly = True
        ' 
        ' Factura
        ' 
        Factura.HeaderText = "Factura"
        Factura.MinimumWidth = 100
        Factura.Name = "Factura"
        Factura.ReadOnly = True
        ' 
        ' Minutostabla1
        ' 
        Minutostabla1.HeaderText = "MInutos"
        Minutostabla1.Name = "Minutostabla1"
        Minutostabla1.ReadOnly = True
        ' 
        ' TipoLLamada1
        ' 
        TipoLLamada1.HeaderText = "Tipo de llamada"
        TipoLLamada1.Name = "TipoLLamada1"
        TipoLLamada1.ReadOnly = True
        TipoLLamada1.Width = 170
        ' 
        ' Monto
        ' 
        Monto.HeaderText = "Monto Total ( B/. )"
        Monto.MinimumWidth = 190
        Monto.Name = "Monto"
        Monto.ReadOnly = True
        Monto.Width = 190
        ' 
        ' Opciones
        ' 
        Opciones.HeaderText = "Acción"
        Opciones.MinimumWidth = 100
        Opciones.Name = "Opciones"
        Opciones.ReadOnly = True
        ' 
        ' Ultimo
        ' 
        Ultimo.HeaderText = "Ultima Modificacion"
        Ultimo.MinimumWidth = 190
        Ultimo.Name = "Ultimo"
        Ultimo.ReadOnly = True
        Ultimo.Width = 190
        ' 
        ' horarioTable
        ' 
        horarioTable.HeaderText = "Horario"
        horarioTable.Name = "horarioTable"
        horarioTable.ReadOnly = True
        horarioTable.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel2.Controls.Add(ErrorMinutos)
        Panel2.Controls.Add(ErrorFactura)
        Panel2.Controls.Add(ErrorCliiente)
        Panel2.Controls.Add(BtnAccionLLamada)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(ComboboxOpciones)
        Panel2.Controls.Add(ComboboxTipoLlamada)
        Panel2.Controls.Add(IngresoMinutos)
        Panel2.Controls.Add(NumFactura)
        Panel2.Controls.Add(NumCliente)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(745, 60)
        Panel2.TabIndex = 1
        ' 
        ' ErrorMinutos
        ' 
        ErrorMinutos.AutoSize = True
        ErrorMinutos.BackColor = Color.Transparent
        ErrorMinutos.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        ErrorMinutos.ForeColor = Color.Red
        ErrorMinutos.Location = New Point(280, 27)
        ErrorMinutos.Name = "ErrorMinutos"
        ErrorMinutos.Size = New Size(21, 25)
        ErrorMinutos.TabIndex = 13
        ErrorMinutos.Text = "*"
        ' 
        ' ErrorFactura
        ' 
        ErrorFactura.AutoSize = True
        ErrorFactura.BackColor = Color.Transparent
        ErrorFactura.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        ErrorFactura.ForeColor = Color.Red
        ErrorFactura.Location = New Point(184, 28)
        ErrorFactura.Name = "ErrorFactura"
        ErrorFactura.Size = New Size(21, 25)
        ErrorFactura.TabIndex = 12
        ErrorFactura.Text = "*"
        ' 
        ' ErrorCliiente
        ' 
        ErrorCliiente.AutoSize = True
        ErrorCliiente.BackColor = Color.Transparent
        ErrorCliiente.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        ErrorCliiente.ForeColor = Color.Red
        ErrorCliiente.Location = New Point(91, 27)
        ErrorCliiente.Name = "ErrorCliiente"
        ErrorCliiente.Size = New Size(21, 25)
        ErrorCliiente.TabIndex = 11
        ErrorCliiente.Text = "*"
        ' 
        ' BtnAccionLLamada
        ' 
        BtnAccionLLamada.BackColor = Color.Black
        BtnAccionLLamada.FlatAppearance.BorderSize = 0
        BtnAccionLLamada.FlatStyle = FlatStyle.Flat
        BtnAccionLLamada.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAccionLLamada.ForeColor = Color.White
        BtnAccionLLamada.Location = New Point(555, 26)
        BtnAccionLLamada.Margin = New Padding(0)
        BtnAccionLLamada.MaximumSize = New Size(200, 20)
        BtnAccionLLamada.MinimumSize = New Size(0, 23)
        BtnAccionLLamada.Name = "BtnAccionLLamada"
        BtnAccionLLamada.Size = New Size(75, 23)
        BtnAccionLLamada.TabIndex = 10
        BtnAccionLLamada.Text = "NULO"
        BtnAccionLLamada.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(431, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 15)
        Label6.TabIndex = 9
        Label6.Text = "Opciones :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(298, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 15)
        Label5.TabIndex = 8
        Label5.Text = "Tipo de Llamada :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(206, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 7
        Label3.Text = "Minutos :"
        ' 
        ' ComboboxOpciones
        ' 
        ComboboxOpciones.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ComboboxOpciones.FormattingEnabled = True
        ComboboxOpciones.Location = New Point(431, 27)
        ComboboxOpciones.Name = "ComboboxOpciones"
        ComboboxOpciones.Size = New Size(121, 23)
        ComboboxOpciones.TabIndex = 6
        ' 
        ' ComboboxTipoLlamada
        ' 
        ComboboxTipoLlamada.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ComboboxTipoLlamada.FormattingEnabled = True
        ComboboxTipoLlamada.Location = New Point(298, 27)
        ComboboxTipoLlamada.Name = "ComboboxTipoLlamada"
        ComboboxTipoLlamada.Size = New Size(121, 23)
        ComboboxTipoLlamada.TabIndex = 5
        ' 
        ' IngresoMinutos
        ' 
        IngresoMinutos.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        IngresoMinutos.Location = New Point(205, 27)
        IngresoMinutos.Name = "IngresoMinutos"
        IngresoMinutos.PlaceholderText = "min"
        IngresoMinutos.Size = New Size(82, 23)
        IngresoMinutos.TabIndex = 4
        ' 
        ' NumFactura
        ' 
        NumFactura.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        NumFactura.Location = New Point(109, 28)
        NumFactura.Name = "NumFactura"
        NumFactura.PlaceholderText = "#"
        NumFactura.Size = New Size(81, 23)
        NumFactura.TabIndex = 3
        ' 
        ' NumCliente
        ' 
        NumCliente.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        NumCliente.Location = New Point(12, 27)
        NumCliente.Name = "NumCliente"
        NumCliente.PlaceholderText = "#"
        NumCliente.Size = New Size(82, 23)
        NumCliente.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(109, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 1
        Label2.Text = "# de Factura :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "# de Cliente :"
        ' 
        ' Problema4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(745, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(640, 450)
        Name = "Problema4"
        Text = "Problema 4"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Closepageform4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnAccionLLamada As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboboxOpciones As ComboBox
    Friend WithEvents ComboboxTipoLlamada As ComboBox
    Friend WithEvents IngresoMinutos As TextBox
    Friend WithEvents NumFactura As TextBox
    Friend WithEvents NumCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents titutloRegistro As Label
    Friend WithEvents ErrorMensajeGRID As Label
    Friend WithEvents ErrorMinutos As Label
    Friend WithEvents ErrorFactura As Label
    Friend WithEvents ErrorCliiente As Label
    Friend WithEvents menusliptt As Button
    Friend WithEvents ContGanancias As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Factura As DataGridViewTextBoxColumn
    Friend WithEvents Minutostabla1 As DataGridViewTextBoxColumn
    Friend WithEvents TipoLLamada1 As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Opciones As DataGridViewTextBoxColumn
    Friend WithEvents Ultimo As DataGridViewTextBoxColumn
    Friend WithEvents horarioTable As DataGridViewTextBoxColumn
End Class
