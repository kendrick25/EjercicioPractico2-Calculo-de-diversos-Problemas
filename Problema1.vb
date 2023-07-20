Imports System.Reflection.Emit
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports EjercicioPractico2.MenuPrincipal
Imports System.Text.RegularExpressions
Public Class Problema1
    'declaraciones de variables
    Const slp As Double = 15.0
    Const extr As Double = 22.5
    'boton para cerrar
    Private Sub Closepageform_Click(sender As Object, e As EventArgs) Handles Closepageform.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar el Problema 1?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            MenuPrincipal.entrada1 += -1
            'borrar Pagina actual
            Dim tab As TabPage = MenuPrincipal.ContForms.SelectedTab
            MenuPrincipal.ContForms.TabPages.Remove(tab)
            Me.Close()
        End If

    End Sub
    'boton para ocultar barra
    Private Sub menusliptt_Click(sender As Object, e As EventArgs) Handles menusliptt.Click
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
    Private Sub Problema1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Cursor = Cursors.Arrow
        Button2.Text = "<---"
        SalarioPagado.Text = "15.00"
        Modo.Items.Insert(0, "Automático")
        Modo.Items.Insert(1, "Manual")
        Modo.DropDownStyle = ComboBoxStyle.DropDownList ' Bloquear el combo box para que solo se pueda seleccionar
        Dias.DropDownStyle = ComboBoxStyle.DropDownList ' Bloquear el combo box para que solo se pueda seleccionar
        Dias.Items.Insert(0, "1")
        Dias.Items.Insert(1, "2")
        Dias.Items.Insert(2, "3")
        Dias.Items.Insert(3, "4")
        Dias.Items.Insert(4, "5")
        Dias.Items.Insert(5, "6")
        Dias.Items.Insert(6, "7")
        Dias.SelectedIndex = 0
        Modo.SelectedIndex = 0
        PictureBox1.Visible = False
        Sueldo.Visible = False
        estado.Visible = False
        Error1.Visible = False
        Error2.Visible = False
        Error3.Visible = False
        Error4.Visible = False
        Error5.Visible = False
        Dias.Visible = False
        Semana.Visible = False
        dLabel.Visible = False
        sLabel.Visible = False
        Calcular.Visible = False
        Panel2.Cursor = Cursors.Arrow
        Limpiarp1.Visible = False
    End Sub
    '---------Desarrollo del Problema 1
    Const VALOR_MAXIMO As Integer = 200000000 ' Establecer el valor máximo int32
    Private Sub HorasIngresadas_TextChanged(sender As Object, e As EventArgs) Handles HorasIngresadas.TextChanged
        Dim valor As Double  ' Declarar una variable para almacenar el valor ingresado
        Dim valor2 As Double  ' Declarar una variable para almacenar el valor ingresado
        Dim valor3 As Double
        Dim regex As New Regex("^[0]+")
        Double.TryParse(HorasIngresadas.Text, valor)
        Double.TryParse(Semana.Text, valor2)
        If HorasIngresadas.Text = “” Or valor > VALOR_MAXIMO Or regex.IsMatch(HorasIngresadas.Text) Or Not IsNumeric(HorasIngresadas.Text) Or HorasIngresadas.Text.Length > 12 Then ' Si el texto está vacío 
            If valor > VALOR_MAXIMO Or HorasIngresadas.Text.Length > 12 Then
                Dim Borrar As String = HorasIngresadas.Text.Remove(HorasIngresadas.Text.Length - 1)
                HorasIngresadas.Text = Borrar
                HorasIngresadas.SelectionStart = HorasIngresadas.Text.Length
            End If
            If HorasIngresadas.Text = “” Or Not IsNumeric(HorasIngresadas.Text) Then
                HorasIngresadas.Text = ""
                Calcular.Visible = False
                Sueldo.Visible = False
                PictureBox1.Visible = False
                estado.Visible = True
                estado.Text = " Revisé que ningún campo este vacío. "
            End If
            If regex.IsMatch(HorasIngresadas.Text) Then
                HorasIngresadas.Text = regex.Replace(HorasIngresadas.Text, "") 'no perimitir 01
            End If
            Error3.Visible = True
        Else
            Error3.Visible = False
            Dim sl As Double
            Dim hrs As Double
            Double.TryParse(HorasIngresadas.Text, hrs)
            If Modo.SelectedItem.ToString() = "Automático" Then
                Calcular.Visible = False
                If hrs <= 35 Then
                    sl = slp * hrs
                    SalarioPagado.Text = "15.00"
                Else
                    If hrs > 35 Then
                        sl = (35 * 15) + (extr * (hrs - 35))
                        SalarioPagado.Text = "22.50"
                    End If
                End If
                PictureBox1.Visible = True
                Sueldo.Visible = True
                Sueldo.Text = " B/. " & sl.ToString("#,##0.00")
                estado.Visible = True
                estado.Text = " Salario a Pagar : "
            ElseIf Modo.SelectedItem.ToString() = "Manual" Then
                Double.TryParse(Dias.SelectedItem.ToString(), valor3)
                Dim calct As Double = valor3 * 24 * valor2
                If valor > calct Then
                    Dim Borrar As String = HorasIngresadas.Text.Remove(HorasIngresadas.Text.Length - 1)
                    HorasIngresadas.Text = Borrar
                    HorasIngresadas.SelectionStart = HorasIngresadas.Text.Length
                Else
                    Error3.Visible = False
                End If
            End If
            If HorasIngresadas.Text = "" Or SalarioPagado.Text = "" Or Semana.Text = "" Then
                Calcular.Visible = False
            Else
                Calcular.Visible = True
            End If
        End If
    End Sub

    Private Sub SalarioPagado_TextChanged(sender As Object, e As EventArgs) Handles SalarioPagado.TextChanged
        Dim valor2 As Double ' Declarar una variable para almacenar el valor ingresado
        Dim regex As New Regex("^[0]+")
        Double.TryParse(SalarioPagado.Text, valor2)
        If SalarioPagado.Text = “” Or valor2 > VALOR_MAXIMO Or regex.IsMatch(SalarioPagado.Text) Or SalarioPagado.Text.Length > 18 Or Not IsNumeric(SalarioPagado.Text) Then  ' Si el texto está vacío 
            If valor2 > VALOR_MAXIMO Or SalarioPagado.Text.Length > 18 Then
                Dim Borrar As String = SalarioPagado.Text.Remove(SalarioPagado.Text.Length - 1)
                SalarioPagado.Text = Borrar
                SalarioPagado.SelectionStart = SalarioPagado.Text.Length
            End If
            If SalarioPagado.Text = “” Or Not IsNumeric(SalarioPagado.Text) Then
                Calcular.Visible = False
                estado.Visible = True
                estado.Text = " Revisé que ningún campo este vacío. "
                SalarioPagado.Text = ""
            End If
            If regex.IsMatch(SalarioPagado.Text) Then
                SalarioPagado.Text = regex.Replace(SalarioPagado.Text, "") 'no perimitir 01
            End If
            Error2.Visible = True
        Else
            Error2.Visible = False
        End If
        If HorasIngresadas.Text = "" Or SalarioPagado.Text = "" Or Semana.Text = "" Then
            Calcular.Visible = False
        Else
            Calcular.Visible = True
        End If
    End Sub
    Private Sub HorasIngresadas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HorasIngresadas.KeyPress
        'Permitir solo números enteros
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub SalarioPagado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SalarioPagado.KeyPress
        'Permitir solo números decimales y enteros,
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Modo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Modo.SelectedIndexChanged
        If Modo.SelectedItem.ToString() = "Manual" Then
            SalarioPagado.Enabled = True
            Sueldo.Visible = False
            PictureBox1.Visible = False
            estado.Visible = False
            dLabel.Visible = True
            sLabel.Visible = True
            Semana.Visible = True
            Dias.Visible = True
            Semana.Text = "1"
            Dias.SelectedIndex = 0
            HorasIngresadas.Text = ""
            SalarioPagado.Text = ""

        End If
        If Modo.SelectedItem.ToString() = "Automático" Then
            dLabel.Visible = False
            sLabel.Visible = False
            Semana.Visible = False
            Dias.Visible = False
            Calcular.Visible = False
            Limpiarp1.Visible = False
            SalarioPagado.Text = "15.00"
            SalarioPagado.Enabled = False
            Semana.Text = ""
        End If
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If Semana.Text = “” Or HorasIngresadas.Text = “” Or SalarioPagado.Text = “” Then
            estado.Visible = True
            estado.Text = " Revisé que ningún campo este vacío. "
            If Semana.Text = “” Then
                Error5.Visible = True
                Sueldo.Visible = False
                PictureBox1.Visible = False
            End If
            If HorasIngresadas.Text = “” Then
                Error3.Visible = True
                Sueldo.Visible = False
                PictureBox1.Visible = False
            End If
            If SalarioPagado.Text = “” Then
                Error2.Visible = True
                Sueldo.Visible = False
                PictureBox1.Visible = False
            End If
        Else
            Sueldo.Visible = True
            estado.Visible = True
            Dim sl As Double
            Dim hrs As Integer = Convert.ToDouble(HorasIngresadas.Text)
            Dim ds As Integer = Convert.ToInt32(Dias.SelectedItem.ToString())
            Dim sem As Integer = Convert.ToInt32(Semana.Text)
            Dim mn As Double = Convert.ToDouble(SalarioPagado.Text)
            If hrs <= 35 Then
                sl = mn * hrs * ds * sem
            Else
                If hrs > 35 Then
                    sl = ((35 * mn) + (extr * (hrs - 35))) * ds * sem
                End If
            End If
            PictureBox1.Visible = True
            Sueldo.Visible = True
            estado.Visible = True
            estado.Text = " Salario que se le debe pagar : : "
            Sueldo.Text = " B/. " & sl.ToString("#,##0.00")
            Limpiarp1.Visible = True
        End If
    End Sub
    Private Sub Semana_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Semana.KeyPress
        'Permitir solo números enteros
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Limpiarp1_Click(sender As Object, e As EventArgs) Handles Limpiarp1.Click
        HorasIngresadas.Clear()
        SalarioPagado.Text = ""
        Semana.Text = "1"
        Dias.SelectedIndex = 0
        Modo.SelectedIndex = 1
        Limpiarp1.Visible = False
    End Sub

    Private Sub Semana_TextChanged(sender As Object, e As EventArgs) Handles Semana.TextChanged
        Dim regex As New Regex("^[0]+")
        Dim valor As Integer ' Declarar una variable para almacenar el valor ingresado
        Integer.TryParse(Semana.Text, valor)
        If Semana.Text = “” Or valor > VALOR_MAXIMO Or regex.IsMatch(Semana.Text) Or Semana.Text.Length > 18 Or Not IsNumeric(Semana.Text) Then
            If valor > VALOR_MAXIMO Or Semana.Text.Length > 18 Then
                Dim Borrar As String = Semana.Text.Remove(Semana.Text.Length - 1)
                Semana.Text = Borrar
                Semana.SelectionStart = Semana.Text.Length
            End If
            If Semana.Text = “” Or Not IsNumeric(Semana.Text) Then
                Error5.Visible = True
                estado.Visible = True
                Calcular.Visible = False
                estado.Text = " Revisé que ningún campo este vacío. "
                PictureBox1.Visible = False
                Sueldo.Visible = False
                Semana.Text = ""
            End If
            If regex.IsMatch(Semana.Text) Then
                Semana.Text = regex.Replace(Semana.Text, "1") 'no perimitir 01
                Semana.SelectionStart = Semana.Text.Length
            End If
        Else
            estado.Visible = False
            PictureBox1.Visible = False
            Sueldo.Visible = False
            Error5.Visible = False
            Dim valor2 As Double
            Dim valor3 As Double
            Double.TryParse(HorasIngresadas.Text, valor2)
            Double.TryParse(Dias.SelectedItem.ToString(), valor3)
            Dim calct As Double = valor3 * 24 * valor
            If valor2 > calct Then
                HorasIngresadas.Text = ""
                Error3.Visible = True
            Else
                Calcular.Visible = True
                Error3.Visible = False
            End If
        End If
        If HorasIngresadas.Text = "" Or SalarioPagado.Text = "" Or Semana.Text = "" Then
            Calcular.Visible = False
        Else
            Calcular.Visible = True
        End If
    End Sub

    Private Sub Dias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dias.SelectedIndexChanged
        Dim valor2 As Double
        Dim valor3 As Double
        Dim valor4 As Double
        Double.TryParse(HorasIngresadas.Text, valor2)
        Double.TryParse(Dias.SelectedItem.ToString(), valor3)
        Double.TryParse(Semana.Text, valor4)
        Dim calct As Double = valor3 * 24 * valor4
        If valor2 > calct Then
            HorasIngresadas.Text = ""
            Error3.Visible = True
        Else
            Calcular.Visible = True
            Error3.Visible = False
        End If
    End Sub

End Class