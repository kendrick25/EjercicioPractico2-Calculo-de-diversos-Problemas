Imports System.Reflection.Emit
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports EjercicioPractico2.MenuPrincipal
Public Class Problema3
    'boton para cerrar
    Private Sub Closepageform3_Click(sender As Object, e As EventArgs) Handles Closepageform3.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar el Problema 3?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            MenuPrincipal.entrada3 += -1
            'borrar Pagina actual
            Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
            MenuPrincipal.ContForms.TabPages.Remove(tab)
            Me.Close()
        End If

    End Sub
    'boton para ocultar barra
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles menusliptt.Click
        If MenuPrincipal.SplitContainer1.Panel1Collapsed = True Then
            MenuPrincipal.SplitContainer1.Panel1Collapsed = False
            menusliptt.BackgroundImage = Image.FromFile("C:\Users\kendr\source\repos\EJCHG\tabRigth.png")
            menusliptt.BackgroundImageLayout = ImageLayout.Stretch
            'Mostrar "--->"
        Else
            MenuPrincipal.SplitContainer1.Panel1Collapsed = True

            menusliptt.BackgroundImage = Image.FromFile("C:\Users\kendr\source\repos\EJCHG\tableft.png")
            menusliptt.BackgroundImageLayout = ImageLayout.Stretch
            'ocultar "<---"
        End If
    End Sub
    'evento LOAD
    Private Sub Problema3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Llenar el ComboBox con los tipos de vehículos
        Listvehiculos.Items.Insert(0, "Ninguno")
        Listvehiculos.Items.Insert(1, "Bicicleta")
        Listvehiculos.Items.Insert(2, "Moto")
        Listvehiculos.Items.Insert(3, "Carro")
        Listvehiculos.Items.Insert(4, "Camión")
        Listvehiculos.SelectedIndex = 0
        'errores
        errorunidad.Visible = False
        Errokm.Visible = False
        ErrorTonelada.Visible = False

        Listvehiculos.DropDownStyle = ComboBoxStyle.DropDownList ' Bloquear el combo box para que solo se pueda seleccionar
        Panel1.Cursor = Cursors.Arrow
    End Sub
    '------------Desarrollo del Problema #3

    Const VALOR_MAXIMO As Double = 1313486231570 ' Establecer el valor máximo
    'habilitar vists con la seleccion
    Private Sub Listvehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listvehiculos.SelectedIndexChanged
        If Listvehiculos.SelectedItem.ToString() = "Ninguno" Then '--------------------------
            KmRecorrido.Enabled = False
            Toneladas.Enabled = False
            'numero de unidades
            labelUnidades.Visible = False  '#
            labeltextUnidades.Visible = False
            'Precio total
            PrecioTotal.Visible = False 'precio
            preciotexttotal.Visible = False
            'Precio Unidad
            PrecioUnidad.Visible = False
            labeltextprecioUnidad.Visible = False
            'texbox
            KmRecorrido.Text = ""
            Toneladas.Text = ""
            PrecioUnidad.Text = ""
            'imagen
            Panel2.Visible = False
            Errokm.Visible = False
            ErrorTonelada.Visible = False
        End If
        '100 unidades
        If Listvehiculos.SelectedItem.ToString() = "Bicicleta" Then '--------------------------
            Errokm.Visible = False
            ErrorTonelada.Visible = False
            'Precio Unidad
            PrecioUnidad.Visible = True
            labeltextprecioUnidad.Visible = True
            'imagen 
            Panel2.Visible = True
            Panel2.BackgroundImage = Image.FromFile("C:\Users\kendr\source\repos\EJCHG\bici.png")
            Panel2.BackgroundImageLayout = ImageLayout.Zoom
            KmRecorrido.Enabled = False
            Toneladas.Enabled = False
            'numero de unidades
            labeltextUnidades.Visible = True
            labelUnidades.Visible = True  '#
            labelUnidades.Text = "100"
            If PrecioUnidad.Text = "" Then
                errorunidad.Visible = True
            Else
                errorunidad.Visible = False
                'Precio total
                PrecioTotal.Visible = True 'precio
                preciotexttotal.Visible = True
            End If
        End If
        '30 unidades por Km
        If Listvehiculos.SelectedItem.ToString() = "Moto" Then '--------------------------
            labelUnidades.Text = ""
            'Precio Unidad
            PrecioUnidad.Visible = True
            labeltextprecioUnidad.Visible = True
            'imagen 
            Panel2.Visible = True
            Panel2.BackgroundImage = Image.FromFile("C:\Users\kendr\source\repos\EJCHG\moto.jpg")
            Panel2.BackgroundImageLayout = ImageLayout.Zoom
            KmRecorrido.Enabled = True
            Toneladas.Enabled = False
            If PrecioUnidad.Text = "" Or KmRecorrido.Text = "" Then
                If PrecioUnidad.Text = "" Then
                    errorunidad.Visible = True
                End If
                'numero de unidades
                If KmRecorrido.Text = "" Then
                    labeltextUnidades.Visible = False
                    labelUnidades.Visible = False  '#
                    Errokm.Visible = True
                End If
            Else
                'error de kilomeros
                Errokm.Visible = False
                'numero de unidades
                labeltextUnidades.Visible = True
                labelUnidades.Visible = True  '#
                errorunidad.Visible = False
                'Precio total
                PrecioTotal.Visible = True 'precio
                preciotexttotal.Visible = True
            End If
        End If
        If Listvehiculos.SelectedItem.ToString() = "Carro" Then '--------------------------
            labelUnidades.Text = ""
            'Precio Unidad
            PrecioUnidad.Visible = True
            labeltextprecioUnidad.Visible = True
            'imagen 
            Panel2.Visible = True
            Panel2.BackgroundImage = Image.FromFile("C:\Users\kendr\source\repos\EJCHG\carro.png")
            Panel2.BackgroundImageLayout = ImageLayout.Zoom
            KmRecorrido.Enabled = True
            Toneladas.Enabled = False
            If PrecioUnidad.Text = "" Or KmRecorrido.Text = "" Then
                If PrecioUnidad.Text = "" Then
                    errorunidad.Visible = True
                End If
                'numero de unidades
                If KmRecorrido.Text = "" Then
                    labeltextUnidades.Visible = False
                    labelUnidades.Visible = False  '#
                    Errokm.Visible = True
                End If
            Else
                'error de kilomeros
                Errokm.Visible = False
                'numero de unidades
                labeltextUnidades.Visible = True
                labelUnidades.Visible = True  '#
                errorunidad.Visible = False
                'Precio total
                PrecioTotal.Visible = True 'precio
                preciotexttotal.Visible = True
            End If
        End If
        If Listvehiculos.SelectedItem.ToString() = "Camión" Then '--------------------------
            labelUnidades.Text = ""
            'Precio Unidad
            PrecioUnidad.Visible = True
            labeltextprecioUnidad.Visible = True
            'imagen 
            Panel2.Visible = True
            Panel2.BackgroundImage = Image.FromFile("C:\Users\kendr\source\repos\EJCHG\camion.png")
            Panel2.BackgroundImageLayout = ImageLayout.Zoom
            KmRecorrido.Enabled = True
            Toneladas.Enabled = True
            If PrecioUnidad.Text = "" Or KmRecorrido.Text = "" Or Toneladas.Text = "" Then
                If PrecioUnidad.Text = "" Then
                    errorunidad.Visible = True
                End If
                'numero de unidades
                If KmRecorrido.Text = "" Then
                    labeltextUnidades.Visible = False
                    labelUnidades.Visible = False  '#
                    Errokm.Visible = True
                End If
                If Toneladas.Text = "" Then
                    ErrorTonelada.Visible = True
                End If
            Else
                'erro toneladas
                ErrorTonelada.Visible = False
                'error de kilomeros
                Errokm.Visible = False
                'numero de unidades
                labeltextUnidades.Visible = True
                labelUnidades.Visible = True  '#
                errorunidad.Visible = False
                'Precio total
                PrecioTotal.Visible = True 'precio
                preciotexttotal.Visible = True
            End If
        End If

    End Sub
    Private Sub KmRecorrido_TextChanged(sender As Object, e As EventArgs) Handles KmRecorrido.TextChanged
        Dim valor As Double
        Dim regex As New Regex("^[0]+") 'inicio 0
        Double.TryParse(KmRecorrido.Text, valor)
        If KmRecorrido.Text = “” Or valor > VALOR_MAXIMO Or regex.IsMatch(KmRecorrido.Text) Or KmRecorrido.Text.Length > 18 Or Not IsNumeric(KmRecorrido.Text) Then
            If valor > VALOR_MAXIMO Or KmRecorrido.Text.Length > 18 Then
                Dim Borrar As String = KmRecorrido.Text.Remove(KmRecorrido.Text.Length - 1)
                KmRecorrido.Text = Borrar
                KmRecorrido.SelectionStart = KmRecorrido.Text.Length
            End If
            If regex.IsMatch(KmRecorrido.Text) Then
                KmRecorrido.Text = regex.Replace(KmRecorrido.Text, "") 'no perimitir 01
            End If
            If KmRecorrido.Text = “” Or Not IsNumeric(KmRecorrido.Text) Then
                'precio
                KmRecorrido.Text = ""
                preciotexttotal.Visible = False
                PrecioTotal.Visible = False
                'error
                Errokm.Visible = True
                'unidad
                labeltextUnidades.Visible = False
                labelUnidades.Visible = False  '#
            End If

        Else
            'error
            Errokm.Visible = False
            'unidad
            labeltextUnidades.Visible = True
            labelUnidades.Visible = True  '#
            If Listvehiculos.SelectedItem.ToString() = "Moto" Or Listvehiculos.SelectedItem.ToString() = "Carro" Then
                '30 unidades por Km
                Dim valor2 As Double
                Double.TryParse(KmRecorrido.Text, valor2)
                Dim calcUnidaddes As Double = 30 * valor2
                labelUnidades.Text = calcUnidaddes.ToString("###0")
                'precio
                If PrecioUnidad.Text = "" Then
                    preciotexttotal.Visible = False
                    PrecioTotal.Visible = False
                Else
                    preciotexttotal.Visible = True
                    PrecioTotal.Visible = True
                    Dim valor3 As Double
                    Double.TryParse(PrecioUnidad.Text, valor3)
                    Dim calctotal As Double = calcUnidaddes * valor3
                    preciotexttotal.Visible = True
                    PrecioTotal.Visible = True
                    PrecioTotal.Text = "B/. " & calctotal.ToString("#,##0.00")
                    errorunidad.Visible = False
                End If
            End If
            If Listvehiculos.SelectedItem.ToString() = "Camión" Then
                Dim valor2 As Double
                Double.TryParse(PrecioUnidad.Text, valor2)
                Dim valor3 As Double
                Double.TryParse(KmRecorrido.Text, valor3)
                Dim valor4 As Double
                Double.TryParse(Toneladas.Text, valor4)
                Dim calcUnidaddes As Double = valor3 * 30 + valor4 * 25
                If Toneladas.Text = "" Then
                    'unidades
                    labeltextUnidades.Visible = False
                    labelUnidades.Visible = False
                Else
                    'unidades
                    labeltextUnidades.Visible = True
                    labelUnidades.Visible = True
                    'calc unidades
                    labelUnidades.Text = calcUnidaddes.ToString("###0")

                End If
                Dim calctotal As Double = calcUnidaddes * valor2
                If PrecioUnidad.Text <> "" And Toneladas.Text <> "" And KmRecorrido.Text <> "" Then
                    'calc precio total
                    preciotexttotal.Visible = True
                    PrecioTotal.Visible = True
                    PrecioTotal.Text = "B/. " & calctotal.ToString("#,##0.00")
                    errorunidad.Visible = False
                Else
                    'precios 
                    preciotexttotal.Visible = False
                    PrecioTotal.Visible = False
                End If
            End If
        End If
    End Sub
    Private Sub KmRecorrido_KeyDown(sender As Object, e As KeyEventArgs) Handles KmRecorrido.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            PrecioUnidad.Select()
        End If
    End Sub
    Private Sub PrecioUnidad_KeyDown(sender As Object, e As KeyEventArgs) Handles PrecioUnidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            If Toneladas.Enabled = True Then
                Toneladas.Select()
            Else
                KmRecorrido.Select()
            End If

        End If
    End Sub
    Private Sub Toneladas_TextChanged(sender As Object, e As EventArgs) Handles Toneladas.TextChanged
        Dim valor As Double
        Dim regex As New Regex("^[0]+") 'inicio 0
        Double.TryParse(Toneladas.Text, valor)
        If Toneladas.Text = “” Or valor > VALOR_MAXIMO Or regex.IsMatch(Toneladas.Text) Or Toneladas.Text.Length > 18 Or Not IsNumeric(Toneladas.Text) Then
            If valor > VALOR_MAXIMO Or Toneladas.Text.Length > 18 Then
                Dim Borrar As String = Toneladas.Text.Remove(Toneladas.Text.Length - 1)
                Toneladas.Text = Borrar
                Toneladas.SelectionStart = Toneladas.Text.Length
            End If
            If regex.IsMatch(Toneladas.Text) Then
                Toneladas.Text = regex.Replace(Toneladas.Text, "") 'no perimitir 01
            End If
            If Toneladas.Text = “” Or Not IsNumeric(Toneladas.Text) Then
                preciotexttotal.Visible = False
                PrecioTotal.Visible = False
                Toneladas.Text = ""
                ErrorTonelada.Visible = True

                labeltextUnidades.Visible = False
                labelUnidades.Visible = False
            End If
        Else

            ErrorTonelada.Visible = False
            If Listvehiculos.SelectedItem.ToString() = "Camión" Then
                Dim valor2 As Double
                Double.TryParse(PrecioUnidad.Text, valor2)
                Dim valor3 As Double
                Double.TryParse(KmRecorrido.Text, valor3)
                Dim valor4 As Double
                Double.TryParse(Toneladas.Text, valor4)
                Dim calcUnidaddes As Double = valor3 * 30 + valor4 * 25
                If KmRecorrido.Text = "" Then
                    'unidades
                    labeltextUnidades.Visible = False
                    labelUnidades.Visible = False
                Else
                    'unidades
                    labeltextUnidades.Visible = True
                    labelUnidades.Visible = True
                    'calc unidades
                    labelUnidades.Text = calcUnidaddes.ToString("###0")

                End If
                Dim calctotal As Double = calcUnidaddes * valor2
                If PrecioUnidad.Text <> "" And Toneladas.Text <> "" And KmRecorrido.Text <> "" Then
                    'calc precio total
                    preciotexttotal.Visible = True
                    PrecioTotal.Visible = True
                    PrecioTotal.Text = "B/. " & calctotal.ToString("#,##0.00")
                    errorunidad.Visible = False
                Else
                    'precios 
                    preciotexttotal.Visible = False
                    PrecioTotal.Visible = False
                End If
            End If
        End If
    End Sub
    Private Sub Toneladas_KeyDown(sender As Object, e As KeyEventArgs) Handles Toneladas.KeyDown
        If Toneladas.Enabled = True And e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            KmRecorrido.Select()
        End If
    End Sub
    Private Sub PrecioUnidad_TextChanged(sender As Object, e As EventArgs) Handles PrecioUnidad.TextChanged
        Dim valor As Double
        Dim regex As New Regex("^[0]+") 'inicio 0
        Double.TryParse(PrecioUnidad.Text, valor)
        If PrecioUnidad.Text = “” Or valor > VALOR_MAXIMO Or regex.IsMatch(PrecioUnidad.Text) Or PrecioUnidad.Text.Length > 18 Or Not IsNumeric(PrecioUnidad.Text) Then
            If valor > VALOR_MAXIMO Or PrecioUnidad.Text.Length > 18 Then
                Dim Borrar As String = PrecioUnidad.Text.Remove(PrecioUnidad.Text.Length - 1)
                PrecioUnidad.Text = Borrar
                PrecioUnidad.SelectionStart = PrecioUnidad.Text.Length
            End If
            If regex.IsMatch(PrecioUnidad.Text) Then
                PrecioUnidad.Text = regex.Replace(PrecioUnidad.Text, "") 'no perimitir 01
            End If
            If PrecioUnidad.Text = “” Or Not IsNumeric(PrecioUnidad.Text) Then
                PrecioUnidad.Text = ""
                preciotexttotal.Visible = False
                PrecioTotal.Visible = False
                errorunidad.Visible = True
            End If

        Else
            errorunidad.Visible = False
            If Listvehiculos.SelectedItem.ToString() = "Bicicleta" Then
                errorunidad.Visible = False
                preciotexttotal.Visible = True
                PrecioTotal.Visible = True
                Dim valor2 As Double
                Double.TryParse(PrecioUnidad.Text, valor2)
                Dim calctotal As Double = 100 * valor2
                PrecioTotal.Text = "B/. " & calctotal.ToString("#,##0.00")
            End If
            If Listvehiculos.SelectedItem.ToString() = "Moto" Or Listvehiculos.SelectedItem.ToString() = "Carro" Then
                If KmRecorrido.Text = "" Then
                    preciotexttotal.Visible = False
                    PrecioTotal.Visible = False
                Else
                    Dim valor2 As Double
                    Double.TryParse(PrecioUnidad.Text, valor2)
                    Dim valor3 As Double
                    Double.TryParse(KmRecorrido.Text, valor3)
                    Dim calctotal As Double = valor2 * 30 * valor3
                    preciotexttotal.Visible = True
                    PrecioTotal.Visible = True
                    PrecioTotal.Text = "B/. " & calctotal.ToString("#,##0.00")
                    errorunidad.Visible = False
                End If
            End If
            If Listvehiculos.SelectedItem.ToString() = "Camión" Then
                If PrecioUnidad.Text <> "" And Toneladas.Text <> "" And KmRecorrido.Text <> "" Then
                    Dim valor2 As Double
                    Double.TryParse(PrecioUnidad.Text, valor2)
                    Dim valor3 As Double
                    Double.TryParse(KmRecorrido.Text, valor3)
                    Dim valor4 As Double
                    Double.TryParse(Toneladas.Text, valor4)
                    'calc unidades
                    Dim calcUnidaddes As Double = valor3 * 30 + valor4 * 25
                    'calc precio total
                    preciotexttotal.Visible = True
                    PrecioTotal.Visible = True
                    Dim calctotal As Double = calcUnidaddes * valor2
                    PrecioTotal.Text = "B/. " & calctotal.ToString("#,##0.00")
                    errorunidad.Visible = False
                Else
                    'precio
                    preciotexttotal.Visible = False
                    PrecioTotal.Visible = False
                End If
            End If
        End If

    End Sub
    'valiidaciones de teclado
    Private Sub KmRecorrido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles KmRecorrido.KeyPress
        'Permitir solo números decimales y enteros,
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If
    End Sub
    Private Sub PrecioUnidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrecioUnidad.KeyPress
        'Permitir solo números decimales y enteros,
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If
    End Sub
    Private Sub Toneladas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Toneladas.KeyPress
        'Permitir solo números decimales y enteros,
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If
    End Sub
End Class