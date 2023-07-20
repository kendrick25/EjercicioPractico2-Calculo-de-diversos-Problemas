<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tips
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Tips))
        Problem3 = New Panel()
        Label22 = New Label()
        Label21 = New Label()
        labelUnidades = New Label()
        labeltextUnidades = New Label()
        PrecioUnidad = New TextBox()
        labeltextprecioUnidad = New Label()
        PrecioTotal = New Label()
        preciotexttotal = New Label()
        Toneladas = New TextBox()
        Label18 = New Label()
        KmRecorrido = New TextBox()
        Label20 = New Label()
        Label19 = New Label()
        Listvehiculos = New ComboBox()
        Label17 = New Label()
        Problm2 = New Panel()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        TextBox5 = New TextBox()
        deudaLabel = New Label()
        mLabel = New Label()
        dLabel = New Label()
        iLabel = New Label()
        TextBox4 = New TextBox()
        Label11 = New Label()
        problem1 = New Panel()
        Label10 = New Label()
        Calcp1 = New Button()
        Lmp = New Button()
        Label9 = New Label()
        Label1 = New Label()
        Label8 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Problem4 = New Panel()
        Label31 = New Label()
        Label30 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        BtnAccionLLamada = New Button()
        Label29 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        ComboboxOpciones = New ComboBox()
        ComboboxTipoLlamada = New ComboBox()
        Label24 = New Label()
        IngresoMinutos = New TextBox()
        NumFactura = New TextBox()
        NumCliente = New TextBox()
        Label25 = New Label()
        Label26 = New Label()
        Label23 = New Label()
        Problem3.SuspendLayout()
        Problm2.SuspendLayout()
        problem1.SuspendLayout()
        Problem4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Problem3
        ' 
        Problem3.AutoScroll = True
        Problem3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Problem3.Controls.Add(Label22)
        Problem3.Controls.Add(Label21)
        Problem3.Controls.Add(labelUnidades)
        Problem3.Controls.Add(labeltextUnidades)
        Problem3.Controls.Add(PrecioUnidad)
        Problem3.Controls.Add(labeltextprecioUnidad)
        Problem3.Controls.Add(PrecioTotal)
        Problem3.Controls.Add(preciotexttotal)
        Problem3.Controls.Add(Toneladas)
        Problem3.Controls.Add(Label18)
        Problem3.Controls.Add(KmRecorrido)
        Problem3.Controls.Add(Label20)
        Problem3.Controls.Add(Label19)
        Problem3.Controls.Add(Listvehiculos)
        Problem3.Controls.Add(Label17)
        Problem3.Location = New Point(17, 258)
        Problem3.Name = "Problem3"
        Problem3.Size = New Size(43, 39)
        Problem3.TabIndex = 0
        Problem3.Visible = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(7, 328)
        Label22.Name = "Label22"
        Label22.Size = New Size(477, 75)
        Label22.TabIndex = 25
        Label22.Text = resources.GetString("Label22.Text")
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(7, 121)
        Label21.Name = "Label21"
        Label21.Size = New Size(475, 105)
        Label21.TabIndex = 24
        Label21.Text = resources.GetString("Label21.Text")
        ' 
        ' labelUnidades
        ' 
        labelUnidades.AutoSize = True
        labelUnidades.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        labelUnidades.ForeColor = Color.Black
        labelUnidades.Location = New Point(81, 276)
        labelUnidades.MinimumSize = New Size(150, 20)
        labelUnidades.Name = "labelUnidades"
        labelUnidades.Size = New Size(150, 20)
        labelUnidades.TabIndex = 23
        labelUnidades.Text = "# de Unidades"
        ' 
        ' labeltextUnidades
        ' 
        labeltextUnidades.AutoSize = True
        labeltextUnidades.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        labeltextUnidades.ForeColor = Color.Black
        labeltextUnidades.Location = New Point(81, 246)
        labeltextUnidades.MinimumSize = New Size(150, 20)
        labeltextUnidades.Name = "labeltextUnidades"
        labeltextUnidades.Size = New Size(150, 20)
        labeltextUnidades.TabIndex = 22
        labeltextUnidades.Text = "Total de unidades :"
        ' 
        ' PrecioUnidad
        ' 
        PrecioUnidad.Enabled = False
        PrecioUnidad.Location = New Point(316, 181)
        PrecioUnidad.Margin = New Padding(0)
        PrecioUnidad.MaximumSize = New Size(100, 23)
        PrecioUnidad.MinimumSize = New Size(100, 23)
        PrecioUnidad.Name = "PrecioUnidad"
        PrecioUnidad.PlaceholderText = "B/."
        PrecioUnidad.Size = New Size(100, 23)
        PrecioUnidad.TabIndex = 21
        ' 
        ' labeltextprecioUnidad
        ' 
        labeltextprecioUnidad.AutoSize = True
        labeltextprecioUnidad.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        labeltextprecioUnidad.ForeColor = Color.Black
        labeltextprecioUnidad.Location = New Point(316, 161)
        labeltextprecioUnidad.MaximumSize = New Size(120, 20)
        labeltextprecioUnidad.MinimumSize = New Size(120, 20)
        labeltextprecioUnidad.Name = "labeltextprecioUnidad"
        labeltextprecioUnidad.Size = New Size(120, 20)
        labeltextprecioUnidad.TabIndex = 20
        labeltextprecioUnidad.Text = "Precio por unidad: "
        ' 
        ' PrecioTotal
        ' 
        PrecioTotal.AutoSize = True
        PrecioTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        PrecioTotal.ForeColor = Color.Red
        PrecioTotal.Location = New Point(250, 276)
        PrecioTotal.MinimumSize = New Size(70, 20)
        PrecioTotal.Name = "PrecioTotal"
        PrecioTotal.Size = New Size(70, 20)
        PrecioTotal.TabIndex = 19
        PrecioTotal.Text = "B/.100"
        ' 
        ' preciotexttotal
        ' 
        preciotexttotal.AutoSize = True
        preciotexttotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        preciotexttotal.ForeColor = Color.Black
        preciotexttotal.Location = New Point(248, 246)
        preciotexttotal.MinimumSize = New Size(150, 20)
        preciotexttotal.Name = "preciotexttotal"
        preciotexttotal.Size = New Size(150, 20)
        preciotexttotal.TabIndex = 18
        preciotexttotal.Text = "Precio Total :"
        ' 
        ' Toneladas
        ' 
        Toneladas.Enabled = False
        Toneladas.Location = New Point(174, 181)
        Toneladas.Margin = New Padding(0)
        Toneladas.MaximumSize = New Size(100, 23)
        Toneladas.MinimumSize = New Size(100, 23)
        Toneladas.Name = "Toneladas"
        Toneladas.PlaceholderText = "T"
        Toneladas.Size = New Size(100, 23)
        Toneladas.TabIndex = 17
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(174, 161)
        Label18.MaximumSize = New Size(100, 20)
        Label18.MinimumSize = New Size(100, 20)
        Label18.Name = "Label18"
        Label18.Size = New Size(100, 20)
        Label18.TabIndex = 16
        Label18.Text = "Toneladas : "
        ' 
        ' KmRecorrido
        ' 
        KmRecorrido.Enabled = False
        KmRecorrido.Location = New Point(40, 181)
        KmRecorrido.Margin = New Padding(0)
        KmRecorrido.MaximumSize = New Size(100, 23)
        KmRecorrido.MinimumSize = New Size(100, 23)
        KmRecorrido.Name = "KmRecorrido"
        KmRecorrido.PlaceholderText = "Km"
        KmRecorrido.Size = New Size(100, 23)
        KmRecorrido.TabIndex = 15
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.ForeColor = Color.Black
        Label20.Location = New Point(40, 161)
        Label20.MaximumSize = New Size(100, 20)
        Label20.MinimumSize = New Size(100, 20)
        Label20.Name = "Label20"
        Label20.Size = New Size(100, 20)
        Label20.TabIndex = 14
        Label20.Text = "Km Recorridos : "
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(165, 59)
        Label19.MinimumSize = New Size(150, 20)
        Label19.Name = "Label19"
        Label19.Size = New Size(150, 20)
        Label19.TabIndex = 5
        Label19.Text = "Tipo de vehículo : "
        ' 
        ' Listvehiculos
        ' 
        Listvehiculos.DropDownStyle = ComboBoxStyle.DropDownList
        Listvehiculos.FormattingEnabled = True
        Listvehiculos.Items.AddRange(New Object() {"Ninguno", "Bicicleta", "Moto", "Carro", "Camión"})
        Listvehiculos.Location = New Point(165, 86)
        Listvehiculos.Margin = New Padding(0)
        Listvehiculos.MaximumSize = New Size(150, 0)
        Listvehiculos.MinimumSize = New Size(150, 0)
        Listvehiculos.Name = "Listvehiculos"
        Listvehiculos.Size = New Size(150, 23)
        Listvehiculos.TabIndex = 4
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(156, 12)
        Label17.Name = "Label17"
        Label17.Size = New Size(145, 32)
        Label17.TabIndex = 0
        Label17.Text = "Problema 3"
        ' 
        ' Problm2
        ' 
        Problm2.AutoScroll = True
        Problm2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Problm2.Controls.Add(Label16)
        Problm2.Controls.Add(Label15)
        Problm2.Controls.Add(Label14)
        Problm2.Controls.Add(Label13)
        Problm2.Controls.Add(Label12)
        Problm2.Controls.Add(TextBox5)
        Problm2.Controls.Add(deudaLabel)
        Problm2.Controls.Add(mLabel)
        Problm2.Controls.Add(dLabel)
        Problm2.Controls.Add(iLabel)
        Problm2.Controls.Add(TextBox4)
        Problm2.Controls.Add(Label11)
        Problm2.Location = New Point(429, 15)
        Problm2.Name = "Problm2"
        Problm2.Size = New Size(41, 38)
        Problm2.TabIndex = 1
        Problm2.Visible = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(29, 306)
        Label16.Name = "Label16"
        Label16.Size = New Size(436, 60)
        Label16.TabIndex = 16
        Label16.Text = " Y por último se muestra el monto total que adeuda el cliente moroso en label en " & vbCrLf & "rojo, si no se muestra nada es porque hay un campo vacío." & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.ForeColor = Color.Red
        Label15.Location = New Point(210, 291)
        Label15.Name = "Label15"
        Label15.Size = New Size(47, 15)
        Label15.TabIndex = 15
        Label15.Text = "B/, 100"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(45, 225)
        Label14.Name = "Label14"
        Label14.Size = New Size(381, 15)
        Label14.TabIndex = 14
        Label14.Text = "En esta parte se aplicara un interes dependiendo de los dias ingresados."
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(105, 202)
        Label13.Name = "Label13"
        Label13.Size = New Size(255, 15)
        Label13.TabIndex = 13
        Label13.Text = "2% >=30         5%>60         7%>90         15%>129"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(18, 106)
        Label12.Name = "Label12"
        Label12.Size = New Size(449, 45)
        Label12.TabIndex = 12
        Label12.Text = resources.GetString("Label12.Text")
        ' 
        ' TextBox5
        ' 
        TextBox5.Enabled = False
        TextBox5.Location = New Point(285, 74)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 11
        ' 
        ' deudaLabel
        ' 
        deudaLabel.AutoSize = True
        deudaLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        deudaLabel.Location = New Point(25, 255)
        deudaLabel.MaximumSize = New Size(281, 21)
        deudaLabel.Name = "deudaLabel"
        deudaLabel.Size = New Size(169, 15)
        deudaLabel.TabIndex = 10
        deudaLabel.Text = "Monto a pagar por el cliente :"
        deudaLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' mLabel
        ' 
        mLabel.AutoSize = True
        mLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        mLabel.Location = New Point(45, 56)
        mLabel.MaximumSize = New Size(281, 21)
        mLabel.Name = "mLabel"
        mLabel.Size = New Size(174, 15)
        mLabel.TabIndex = 7
        mLabel.Text = "Monto que adeuda el cliente : "
        mLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' dLabel
        ' 
        dLabel.AutoSize = True
        dLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        dLabel.Location = New Point(285, 56)
        dLabel.MaximumSize = New Size(281, 21)
        dLabel.Name = "dLabel"
        dLabel.Size = New Size(96, 15)
        dLabel.TabIndex = 9
        dLabel.Text = "Días de atraso  : "
        dLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' iLabel
        ' 
        iLabel.AutoSize = True
        iLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        iLabel.Location = New Point(29, 165)
        iLabel.MaximumSize = New Size(281, 21)
        iLabel.MinimumSize = New Size(180, 21)
        iLabel.Name = "iLabel"
        iLabel.Size = New Size(208, 21)
        iLabel.TabIndex = 8
        iLabel.Text = "Interés a pagar en el presente mes : "
        iLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox4
        ' 
        TextBox4.Enabled = False
        TextBox4.Location = New Point(110, 74)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(156, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(145, 32)
        Label11.TabIndex = 0
        Label11.Text = "Problema 2"
        ' 
        ' problem1
        ' 
        problem1.AutoScroll = True
        problem1.BackColor = SystemColors.ActiveCaption
        problem1.Controls.Add(Label10)
        problem1.Controls.Add(Calcp1)
        problem1.Controls.Add(Lmp)
        problem1.Controls.Add(Label9)
        problem1.Controls.Add(Label1)
        problem1.Controls.Add(Label8)
        problem1.Controls.Add(TextBox3)
        problem1.Controls.Add(Label7)
        problem1.Controls.Add(ComboBox2)
        problem1.Controls.Add(ComboBox1)
        problem1.Controls.Add(Label6)
        problem1.Controls.Add(Label5)
        problem1.Controls.Add(TextBox2)
        problem1.Controls.Add(Label4)
        problem1.Controls.Add(Label3)
        problem1.Controls.Add(TextBox1)
        problem1.Controls.Add(Label2)
        problem1.Location = New Point(12, 12)
        problem1.Name = "problem1"
        problem1.Size = New Size(38, 41)
        problem1.TabIndex = 1
        problem1.Visible = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(27, 455)
        Label10.Name = "Label10"
        Label10.Size = New Size(424, 90)
        Label10.TabIndex = 22
        Label10.Text = resources.GetString("Label10.Text")
        ' 
        ' Calcp1
        ' 
        Calcp1.BackColor = Color.MidnightBlue
        Calcp1.FlatAppearance.BorderSize = 0
        Calcp1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Calcp1.FlatStyle = FlatStyle.Flat
        Calcp1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Calcp1.ForeColor = Color.White
        Calcp1.Location = New Point(286, 396)
        Calcp1.Margin = New Padding(0)
        Calcp1.MaximumSize = New Size(90, 40)
        Calcp1.MinimumSize = New Size(90, 40)
        Calcp1.Name = "Calcp1"
        Calcp1.Size = New Size(90, 40)
        Calcp1.TabIndex = 21
        Calcp1.Text = "Calcular"
        Calcp1.UseVisualStyleBackColor = False
        ' 
        ' Lmp
        ' 
        Lmp.BackColor = Color.Black
        Lmp.FlatAppearance.BorderSize = 0
        Lmp.FlatAppearance.MouseOverBackColor = Color.Silver
        Lmp.FlatStyle = FlatStyle.Flat
        Lmp.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Lmp.ForeColor = Color.White
        Lmp.Location = New Point(86, 397)
        Lmp.Margin = New Padding(0)
        Lmp.MaximumSize = New Size(150, 23)
        Lmp.MinimumSize = New Size(150, 40)
        Lmp.Name = "Lmp"
        Lmp.Size = New Size(150, 40)
        Lmp.TabIndex = 20
        Lmp.Text = "Limpiar campos"
        Lmp.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(45, 301)
        Label9.Name = "Label9"
        Label9.Size = New Size(369, 30)
        Label9.TabIndex = 13
        Label9.Text = "Importante: No se podra ingresar numero mayor al numero de dias y" & vbCrLf & " semana seleccionadas."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(163, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 32)
        Label1.TabIndex = 0
        Label1.Text = "Problema 1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(38, 379)
        Label8.Name = "Label8"
        Label8.Size = New Size(263, 15)
        Label8.TabIndex = 12
        Label8.Text = "Este textbox solo mostrara los dias de la semana."
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Location = New Point(314, 202)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(314, 184)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 15)
        Label7.TabIndex = 10
        Label7.Text = "Salario del trabajador  :"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        ComboBox2.Location = New Point(172, 339)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Manual", "Automático"})
        ComboBox1.Location = New Point(154, 83)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(5, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(451, 60)
        Label6.TabIndex = 7
        Label6.Text = "En parte automática solo es necesario el ingreso de horas del trabajador y hará los" & vbCrLf & "cálculos correspondientes. En la parte manual se necesitaran otros campos como se " & vbCrLf & "muestra a continuación." & vbCrLf & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 50)
        Label5.Name = "Label5"
        Label5.Size = New Size(328, 30)
        Label5.TabIndex = 6
        Label5.Text = "Este problema tiene 2 funcionalidades, automática y manual." & vbCrLf & vbCrLf
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(175, 202)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(175, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 15)
        Label4.TabIndex = 4
        Label4.Text = "Semanas :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 239)
        Label3.Name = "Label3"
        Label3.Size = New Size(453, 45)
        Label3.TabIndex = 3
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(17, 202)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(17, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 15)
        Label2.TabIndex = 1
        Label2.Text = "Horas del trabajador :"
        ' 
        ' Problem4
        ' 
        Problem4.AutoScroll = True
        Problem4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Problem4.Controls.Add(Label31)
        Problem4.Controls.Add(Label30)
        Problem4.Controls.Add(Button3)
        Problem4.Controls.Add(Button2)
        Problem4.Controls.Add(Button1)
        Problem4.Controls.Add(BtnAccionLLamada)
        Problem4.Controls.Add(Label29)
        Problem4.Controls.Add(Label27)
        Problem4.Controls.Add(Label28)
        Problem4.Controls.Add(ComboboxOpciones)
        Problem4.Controls.Add(ComboboxTipoLlamada)
        Problem4.Controls.Add(Label24)
        Problem4.Controls.Add(IngresoMinutos)
        Problem4.Controls.Add(NumFactura)
        Problem4.Controls.Add(NumCliente)
        Problem4.Controls.Add(Label25)
        Problem4.Controls.Add(Label26)
        Problem4.Controls.Add(Label23)
        Problem4.Dock = DockStyle.Fill
        Problem4.Location = New Point(0, 0)
        Problem4.Name = "Problem4"
        Problem4.Size = New Size(487, 411)
        Problem4.TabIndex = 2
        Problem4.Visible = False
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(4, 361)
        Label31.Name = "Label31"
        Label31.Size = New Size(461, 240)
        Label31.TabIndex = 24
        Label31.Text = resources.GetString("Label31.Text")
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Location = New Point(3, 108)
        Label30.Name = "Label30"
        Label30.Size = New Size(461, 45)
        Label30.TabIndex = 23
        Label30.Text = resources.GetString("Label30.Text")
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(357, 332)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 22
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(276, 332)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 21
        Button2.Text = "Buscar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Yellow
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(148, 332)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 23)
        Button1.TabIndex = 20
        Button1.Text = "Imprimir Factura"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' BtnAccionLLamada
        ' 
        BtnAccionLLamada.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        BtnAccionLLamada.FlatAppearance.BorderSize = 0
        BtnAccionLLamada.FlatStyle = FlatStyle.Flat
        BtnAccionLLamada.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAccionLLamada.ForeColor = Color.White
        BtnAccionLLamada.Location = New Point(67, 332)
        BtnAccionLLamada.Name = "BtnAccionLLamada"
        BtnAccionLLamada.Size = New Size(75, 23)
        BtnAccionLLamada.TabIndex = 19
        BtnAccionLLamada.Text = "Registrar"
        BtnAccionLLamada.UseVisualStyleBackColor = False
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(4, 238)
        Label29.Name = "Label29"
        Label29.Size = New Size(466, 75)
        Label29.TabIndex = 18
        Label29.Text = resources.GetString("Label29.Text")
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label27.ForeColor = Color.Black
        Label27.Location = New Point(246, 175)
        Label27.Name = "Label27"
        Label27.Size = New Size(64, 15)
        Label27.TabIndex = 17
        Label27.Text = "Opciones :"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label28.ForeColor = Color.Black
        Label28.Location = New Point(113, 175)
        Label28.Name = "Label28"
        Label28.Size = New Size(102, 15)
        Label28.TabIndex = 16
        Label28.Text = "Tipo de Llamada :"
        ' 
        ' ComboboxOpciones
        ' 
        ComboboxOpciones.DropDownStyle = ComboBoxStyle.DropDownList
        ComboboxOpciones.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ComboboxOpciones.FormattingEnabled = True
        ComboboxOpciones.Items.AddRange(New Object() {"Registrar", "Editar", "Eliminar", "Imprimir Factura", "Limpiar Campos"})
        ComboboxOpciones.Location = New Point(246, 193)
        ComboboxOpciones.Name = "ComboboxOpciones"
        ComboboxOpciones.Size = New Size(121, 23)
        ComboboxOpciones.TabIndex = 15
        ' 
        ' ComboboxTipoLlamada
        ' 
        ComboboxTipoLlamada.DropDownStyle = ComboBoxStyle.DropDownList
        ComboboxTipoLlamada.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ComboboxTipoLlamada.FormattingEnabled = True
        ComboboxTipoLlamada.Items.AddRange(New Object() {"Nacional Local", "Nacional Larga Distancia", "Larga Distancia Internacional"})
        ComboboxTipoLlamada.Location = New Point(113, 193)
        ComboboxTipoLlamada.Name = "ComboboxTipoLlamada"
        ComboboxTipoLlamada.Size = New Size(121, 23)
        ComboboxTipoLlamada.TabIndex = 14
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label24.ForeColor = Color.Black
        Label24.Location = New Point(296, 53)
        Label24.Name = "Label24"
        Label24.Size = New Size(58, 15)
        Label24.TabIndex = 13
        Label24.Text = "Minutos :"
        ' 
        ' IngresoMinutos
        ' 
        IngresoMinutos.Enabled = False
        IngresoMinutos.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        IngresoMinutos.Location = New Point(295, 71)
        IngresoMinutos.Name = "IngresoMinutos"
        IngresoMinutos.PlaceholderText = "min"
        IngresoMinutos.Size = New Size(82, 23)
        IngresoMinutos.TabIndex = 12
        ' 
        ' NumFactura
        ' 
        NumFactura.Enabled = False
        NumFactura.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        NumFactura.Location = New Point(199, 72)
        NumFactura.Name = "NumFactura"
        NumFactura.PlaceholderText = "#"
        NumFactura.Size = New Size(81, 23)
        NumFactura.TabIndex = 11
        ' 
        ' NumCliente
        ' 
        NumCliente.Enabled = False
        NumCliente.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        NumCliente.Location = New Point(102, 71)
        NumCliente.Name = "NumCliente"
        NumCliente.PlaceholderText = "#"
        NumCliente.Size = New Size(82, 23)
        NumCliente.TabIndex = 10
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label25.ForeColor = Color.Black
        Label25.Location = New Point(199, 54)
        Label25.Name = "Label25"
        Label25.Size = New Size(81, 15)
        Label25.TabIndex = 9
        Label25.Text = "# de Factura :"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label26.ForeColor = Color.Black
        Label26.Location = New Point(102, 53)
        Label26.Name = "Label26"
        Label26.Size = New Size(79, 15)
        Label26.TabIndex = 8
        Label26.Text = "# de Cliente :"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.Location = New Point(173, 9)
        Label23.Name = "Label23"
        Label23.Size = New Size(145, 32)
        Label23.TabIndex = 0
        Label23.Text = "Problema 4"
        ' 
        ' Tips
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(487, 411)
        Controls.Add(Problem4)
        Controls.Add(problem1)
        Controls.Add(Problm2)
        Controls.Add(Problem3)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MaximumSize = New Size(503, 450)
        MinimizeBox = False
        MinimumSize = New Size(503, 450)
        Name = "Tips"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Problem3.ResumeLayout(False)
        Problem3.PerformLayout()
        Problm2.ResumeLayout(False)
        Problm2.PerformLayout()
        problem1.ResumeLayout(False)
        problem1.PerformLayout()
        Problem4.ResumeLayout(False)
        Problem4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Problem3 As Panel
    Friend WithEvents Problm2 As Panel
    Friend WithEvents problem1 As Panel
    Friend WithEvents Problem4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Lmp As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Calcp1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents deudaLabel As Label
    Friend WithEvents mLabel As Label
    Friend WithEvents dLabel As Label
    Friend WithEvents iLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Listvehiculos As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents labelUnidades As Label
    Friend WithEvents labeltextUnidades As Label
    Friend WithEvents PrecioUnidad As TextBox
    Friend WithEvents labeltextprecioUnidad As Label
    Friend WithEvents PrecioTotal As Label
    Friend WithEvents preciotexttotal As Label
    Friend WithEvents Toneladas As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents KmRecorrido As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents IngresoMinutos As TextBox
    Friend WithEvents NumFactura As TextBox
    Friend WithEvents NumCliente As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents ComboboxOpciones As ComboBox
    Friend WithEvents ComboboxTipoLlamada As ComboBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnAccionLLamada As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Button3 As Button
End Class
