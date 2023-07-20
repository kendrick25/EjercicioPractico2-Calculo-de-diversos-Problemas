Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports EjercicioPractico2.MenuPrincipal
Public Class Problema2
    'boton para cerrar
    Private Sub Closepageform2_Click(sender As Object, e As EventArgs) Handles Closepageform2.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar el Problema 1?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            MenuPrincipal.entrada2 += -1
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
    Private Sub Problema2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.AutoScroll = True
        erro1lab.Visible = False
        errorlab2.Visible = False
        erorrlabel3.Visible = False
        IngresoInteres.Visible = False
        DiasAtraso.Visible = False

        dLabel.Visible = False
        BtnCalcularDeuda.Visible = False
        iLabel.Visible = False
        deudaLabel.Visible = False
        Resultadointeres.Visible = False
        Panel2.Cursor = Cursors.Arrow
    End Sub
    '---------Desarrollo del Problema 2----------------------------------------------------------------------------
    Const VALOR_MAXIMO As Double = 1313486231570 ' Establecer el valor máximo 
    Private Sub IngresoMonto_TextChanged(sender As Object, e As EventArgs) Handles IngresoMonto.TextChanged
        IngresoInteres.Visible = False
        Dim regex As New Regex("^[0]+") 'inicio 0
        Dim valor As Double ' Declarar una variable para almacenar el valor ingresado
        Double.TryParse(IngresoMonto.Text, valor)
        If IngresoMonto.Text = “” Or valor > VALOR_MAXIMO Or regex.IsMatch(IngresoMonto.Text) Or IngresoMonto.Text.Length > 18 Or Not IsNumeric(IngresoMonto.Text) Then ' Si el texto está vacío o excede el valor MAX
            If valor > VALOR_MAXIMO Or IngresoMonto.Text.Length > 18 Then
                Dim Borrar As String = IngresoMonto.Text.Remove(IngresoMonto.Text.Length - 1)
                IngresoMonto.Text = Borrar
                IngresoMonto.SelectionStart = IngresoMonto.Text.Length
            End If
            If regex.IsMatch(IngresoMonto.Text) Then
                IngresoMonto.Text = regex.Replace(IngresoMonto.Text, "") 'no perimitir 01
            End If
            If IngresoMonto.Text = “” Or Not IsNumeric(IngresoMonto.Text) Then
                IngresoMonto.Text = ""
                erro1lab.Visible = True
            End If
        Else
            erro1lab.Visible = False
        End If
    End Sub
    'Validacion de Datos
    Private Sub IngresoMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IngresoMonto.KeyPress
        'Permitir solo números decimales y enteros,
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If
    End Sub
    Private Sub IngresoMonto_KeyDown(sender As Object, e As KeyEventArgs) Handles IngresoMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            If IngresoMonto.Text <> "" Then
                DiasAtraso.Visible = True
                DiasAtraso.Select()
                dLabel.Visible = True
                erro1lab.Visible = False
            Else
                erro1lab.Visible = True
            End If
        End If
    End Sub
    'Dias de Interesese
    Private Sub DiasAtraso_TextChanged(sender As Object, e As EventArgs) Handles DiasAtraso.TextChanged
        Dim regex As New Regex("^[0]+") 'inicio 0
        IngresoInteres.Visible = False
        iLabel.Visible = False
        BtnCalcularDeuda.Visible = False
        Resultadointeres.Visible = False
        deudaLabel.Visible = False
        ' Declarar una variable para almacenar el valor ingresado
        Dim valor As Double
        Double.TryParse(DiasAtraso.Text, valor)
        If DiasAtraso.Text = “” Or valor > VALOR_MAXIMO Or regex.IsMatch(DiasAtraso.Text) Or Not IsNumeric(DiasAtraso.Text) Then
            If valor > VALOR_MAXIMO Then
                Dim Borrar As String = DiasAtraso.Text.Remove(DiasAtraso.Text.Length - 1)
                DiasAtraso.Text = Borrar
                DiasAtraso.SelectionStart = DiasAtraso.Text.Length
            End If
            If DiasAtraso.Text = “” Or Not IsNumeric(DiasAtraso.Text) Then
                erorrlabel3.Visible = True
                DiasAtraso.Text = ""
            End If
            If regex.IsMatch(DiasAtraso.Text) Then
                DiasAtraso.Text = regex.Replace(DiasAtraso.Text, "") 'no perimitir 01
            End If
        Else
            erorrlabel3.Visible = False
        End If
    End Sub
    Private Sub DiasAtraso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DiasAtraso.KeyPress
        'Permitir solo números enteros
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub DiasAtraso_KeyDown(sender As Object, e As KeyEventArgs) Handles DiasAtraso.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            If DiasAtraso.Text = "" Then
                erorrlabel3.Visible = True
            Else
                iLabel.Visible = True
                BtnCalcularDeuda.Visible = True
                erorrlabel3.Visible = False
                Dim valor2 As Double
                Double.TryParse(DiasAtraso.Text, valor2)
                If valor2 < 30 Then
                    iLabel.Visible = False
                    IngresoInteres.Visible = False
                End If
                If valor2 >= 30 And valor2 <= 60 Then
                    IngresoInteres.Visible = True
                    IngresoInteres.Text = "2%"
                End If
                If valor2 > 60 And valor2 <= 90 Then
                    IngresoInteres.Visible = True
                    IngresoInteres.Text = "5%"
                End If
                If valor2 > 90 And valor2 <= 129 Then
                    IngresoInteres.Visible = True
                    IngresoInteres.Text = "7%"
                End If
                If valor2 > 129 Then
                    IngresoInteres.Visible = True
                    IngresoInteres.Text = "15%"
                End If
                BtnCalcularDeuda.Select()
            End If
        End If
    End Sub
    'texbox intereses-------------------------------------------------------
    Private Sub BtnCalcularDeuda_Click(sender As Object, e As EventArgs) Handles BtnCalcularDeuda.Click
        Dim intersPAG As Double
        Dim resultado As Double
        If IngresoInteres.Visible = False Then
            Dim monto As Double
            Double.TryParse(IngresoMonto.Text, monto)
            resultado = monto
        End If
        If IngresoInteres.Visible = True Then
            Dim monto As Double
            Double.TryParse(IngresoMonto.Text, monto)
            Dim cadena As String = IngresoInteres.Text.Remove(IngresoInteres.Text.Length - 1)
            intersPAG = Convert.ToDouble(cadena) / 100
            resultado = monto + (monto * intersPAG)
        End If
        deudaLabel.Visible = True
        Resultadointeres.Visible = True
        Resultadointeres.Text = " B/. " & resultado.ToString("#,##0.00")
    End Sub
    '----------------clicks
    Private Sub IngresoMonto_Click(sender As Object, e As EventArgs) Handles IngresoMonto.Click
        If DiasAtraso.Text <> "" Then
            DiasAtraso.Visible = True
            dLabel.Visible = True
        Else
            DiasAtraso.Visible = False
            dLabel.Visible = False
        End If
        IngresoInteres.Visible = False
        BtnCalcularDeuda.Visible = False
        iLabel.Visible = False
        deudaLabel.Visible = False
        Resultadointeres.Visible = False

    End Sub
    Private Sub DiasAtraso_Click(sender As Object, e As EventArgs) Handles DiasAtraso.Click
        IngresoInteres.Visible = False
        BtnCalcularDeuda.Visible = False
        iLabel.Visible = False
        deudaLabel.Visible = False
        Resultadointeres.Visible = False
    End Sub


End Class