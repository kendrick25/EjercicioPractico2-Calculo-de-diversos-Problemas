Imports System.Reflection.Emit
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32
Public Class Problema4
    'declaracion de variables
    Const VALOR_MAXIMO As Double = 1313486231 ' Establecer el valor máximo 
    Private Sub Closepageform4_Click(sender As Object, e As EventArgs) Handles Closepageform4.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar el Problema 4?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            MenuPrincipal.entrada4 += -1
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
    Const LOCAL As Decimal = 0.03
    Const NACIONAL As Decimal = 0.06
    Const INTERNACIONAL As Decimal = 0.1
    Private Sub Problema4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'errores
        ErrorCliiente.Visible = False
        ErrorFactura.Visible = False
        ErrorMinutos.Visible = False
        ErrorMensajeGRID.Visible = False
        'Llenar el ComboBox con los tipos de llamadas
        ComboboxTipoLlamada.Items.Insert(0, "Nacional Local")
        ComboboxTipoLlamada.Items.Insert(1, "Nacional Larga Distancia")
        ComboboxTipoLlamada.Items.Insert(2, "Larga Distancia Internacional")
        ComboboxTipoLlamada.SelectedIndex = 0
        ComboboxTipoLlamada.DropDownStyle = ComboBoxStyle.DropDownList ' Bloquear el combo box para que solo se pueda seleccionar
        'Llenar el ComboBox con los tipos de Opciones
        ComboboxOpciones.Items.Insert(0, "Registrar")
        ComboboxOpciones.Items.Insert(1, "Editar")
        ComboboxOpciones.Items.Insert(2, "Eliminar")
        ComboboxOpciones.Items.Insert(3, "Imprimir Factura")
        ComboboxOpciones.Items.Insert(4, "Limpiar Campos")
        ComboboxOpciones.SelectedIndex = 0
        ComboboxOpciones.DropDownStyle = ComboBoxStyle.DropDownList ' Bloquear el combo box para que solo se pueda seleccionar
        'tablas
        titutloRegistro.Visible = True
        DataGridView1.Visible = True
        DataGridView1.ReadOnly = True 'Hace que todo el datagridview sea de solo lectura
        'tabla 
        DataGridView1.Rows.Add("1", "1", "25", "Nacional Local", "100.00", "registrar", "hoy", "mañana")
        DataGridView1.Rows.Add("1", "2", "50", "Nacional Local", "100.00", "registrar", "hoy", "mañana")
        DataGridView1.Rows.Add("1", "3", "60", "Nacional Larga Distancia", "100.00", "registrar", "hoy", "mañana")
        DataGridView1.Rows.Add("1", "4", "120", "Nacional Larga Distancia", "100.00", "registrar", "hoy", "mañana")
        DataGridView1.Rows.Add("1", "5", "240", "Larga Distancia Internacional", "100.00", "registrar", "hoy", "mañana")
        DataGridView1.Rows.Add("1", "6", "480", "Larga Distancia Internacional", "100.00", "registrar", "hoy", "mañana")
    End Sub

    Private Sub NumCliente_TextChanged(sender As Object, e As EventArgs) Handles NumCliente.TextChanged
        Dim regex As New Regex("^[0]+") 'inicio 0
        ' Declarar una variable para almacenar el valor ingresado
        Dim valor As Double
        Double.TryParse(NumCliente.Text, valor)
        If NumCliente.Text = “” Or valor > VALOR_MAXIMO Or regex.IsMatch(NumCliente.Text) Or Not IsNumeric(NumCliente.Text) Then
            If valor > VALOR_MAXIMO Then
                NumCliente.Text = ""
                NumCliente.Select()
            End If
            If NumCliente.Text = “” Or Not IsNumeric(NumCliente.Text) Then
                NumCliente.Text = ""
                DataGridView1.ClearSelection()
                ErrorMensajeGRID.Visible = False
                BtnAccionLLamada.Visible = False
                ErrorCliiente.Visible = True
            End If
            If regex.IsMatch(NumCliente.Text) Then
                NumCliente.Text = regex.Replace(NumCliente.Text, "") 'no perimitir 01
            End If
        Else
            ErrorCliiente.Visible = False
            If ComboboxOpciones.SelectedItem.ToString() = "Registrar" And NumCliente.Text <> "" Then
                Dim columna As Integer = 0
                Dim encontrado As Boolean = False
                Dim valor2 As Integer
                Integer.TryParse(NumCliente.Text, valor2)

                If String.IsNullOrEmpty(DataGridView1.RowCount.ToString) Then 'Si el gridview tiene al menos una fila
                    MessageBox.Show("No hay datos Del Cliente Registrados") 'Muestra un mensaje
                    Exit Sub
                Else
                    For Each row As DataGridViewRow In DataGridView1.Rows 'Recorre las filas del gridview
                        If row.Cells(columna).Value = valor2 Then 'Si el valor de la celda convertido a entero coincide con el valor buscado
                            encontrado = True 'Cambia el indicador a verdadero
                            ErrorCliiente.Visible = True
                            NumCliente.SelectionStart = NumCliente.Text.Length
                            BtnAccionLLamada.Visible = False
                            DataGridView1.ClearSelection()
                            DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                            row.Selected = True 'Selecciona la fila
                            Exit For 'Sale del bucle
                        End If
                    Next
                    If Not encontrado Then 'Si no se encontró el valor
                        ErrorCliiente.Visible = False
                        ErrorCliiente.Visible = False
                        ErrorMensajeGRID.Visible = False
                        If NumFactura.Text <> "" And IngresoMinutos.Text <> "" Then
                            DataGridView1.ClearSelection()
                            BtnAccionLLamada.Visible = True
                            BtnAccionLLamada.BackColor = Color.Green
                            BtnAccionLLamada.Text = "Registrar"
                        End If
                        Exit Sub
                    End If
                    'validar 
                End If
            End If
            '------------------------------------------
            If ComboboxOpciones.SelectedItem.ToString() = "Imprimir Factura" And NumCliente.Text <> "" Then
                If NumCliente.Text = "" Then
                    DataGridView1.ClearSelection()
                    BtnAccionLLamada.Visible = False
                Else
                    Dim columna2 As Integer = 0
                    Dim valor4 As Integer
                    Dim encontrado As Boolean = False
                    Integer.TryParse(NumCliente.Text, valor4)
                    DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                    DataGridView1.ClearSelection()
                    For Each row As DataGridViewRow In DataGridView1.Rows 'Recorre las filas del gridview
                        If row.Cells(columna2).Value = valor4 Then 'Si el valor de la celda convertido a entero coincide con el valor buscado
                            encontrado = True 'Cambia el indicador a verdadero
                            ErrorMensajeGRID.Visible = False
                            row.Selected = True 'Selecciona la fila
                        End If
                    Next
                    If Not encontrado Then 'Si no se encontró el valor
                        ErrorCliiente.Visible = True
                        ErrorMensajeGRID.Visible = True
                        BtnAccionLLamada.Visible = False
                        DataGridView1.ClearSelection()
                        ErrorMensajeGRID.Text = "El cliente no esta registrado"
                    Else
                        BtnAccionLLamada.BackColor = Color.Yellow
                        BtnAccionLLamada.Text = "Imprimir Factura"
                        BtnAccionLLamada.Visible = True
                    End If
                End If
            End If
            '------------------------------------------
            If ComboboxOpciones.SelectedItem.ToString() = "Editar" Then
                If NumCliente.Text = "" Then
                    BtnAccionLLamada.Visible = False
                Else
                    DataGridView1.ClearSelection()
                    BtnAccionLLamada.BackColor = Color.Black
                    BtnAccionLLamada.Text = "Buscar"
                    BtnAccionLLamada.Visible = True

                End If
            End If
            '------------------------------------------
            '-------------------------Eliminar
            If ComboboxOpciones.SelectedItem.ToString() = "Eliminar" Then
                Dim columna2 As Integer = 0
                Dim valor4 As Integer
                Dim encontrado As Boolean = False
                Integer.TryParse(NumCliente.Text, valor4)
                DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                DataGridView1.ClearSelection()
                For Each row As DataGridViewRow In DataGridView1.Rows 'Recorre las filas del gridview
                    If row.Cells(columna2).Value = valor4 Then 'Si el valor de la celda convertido a entero coincide con el valor buscado
                        encontrado = True 'Cambia el indicador a verdadero
                        ErrorMensajeGRID.Visible = False
                        row.Selected = True 'Selecciona la fila
                        BtnAccionLLamada.Visible = True
                        BtnAccionLLamada.BackColor = Color.Red
                        BtnAccionLLamada.Text = "Eliminar"
                    End If
                Next
                If Not encontrado Then 'Si no se encontró el valor
                    BtnAccionLLamada.Visible = False
                    ErrorCliiente.Visible = True
                    ErrorMensajeGRID.Visible = True
                    ErrorMensajeGRID.Text = "El cliente que desea eliminar no esta registrado"
                End If
            End If
            '------------------------------------------
        End If

    End Sub
    Private Sub NumCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumCliente.KeyPress
        'Permitir solo números enteros
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub NumCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles NumCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            If BtnAccionLLamada.Visible = True Then
                BtnAccionLLamada.Select()
            Else
                NumFactura.Select()
            End If
        End If
    End Sub
    Private Sub NumFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles NumFactura.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            If BtnAccionLLamada.Visible = True Then
                BtnAccionLLamada.Select()
            Else
                IngresoMinutos.Select()
            End If
        End If
    End Sub
    Private Sub IngresoMinutos_KeyDown(sender As Object, e As KeyEventArgs) Handles IngresoMinutos.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            If BtnAccionLLamada.Visible = True Then
                BtnAccionLLamada.Select()
            Else
                NumCliente.Select()
            End If
        End If
    End Sub
    Private Sub NumFactura_TextChanged(sender As Object, e As EventArgs) Handles NumFactura.TextChanged
        Dim regex As New Regex("^[0]+") 'inicio 0
        ' Declarar una variable para almacenar el valor ingresado
        Dim valor As Double
        Double.TryParse(NumFactura.Text, valor)
        If NumFactura.Text = “” Or valor > VALOR_MAXIMO Or regex.IsMatch(NumFactura.Text) Or Not IsNumeric(NumFactura.Text) Then
            If valor > VALOR_MAXIMO Then
                NumFactura.Text = ""
                NumFactura.SelectionStart = NumFactura.Text.Length
            End If
            If NumFactura.Text = “” Or Not IsNumeric(NumFactura.Text) Then
                NumFactura.Text = ""
                ErrorMensajeGRID.Visible = False
                ErrorFactura.Visible = True
                BtnAccionLLamada.Visible = False
            End If
            If regex.IsMatch(NumFactura.Text) Then
                NumFactura.Text = regex.Replace(NumFactura.Text, "") 'no perimitir 01
            End If
        Else
            ErrorFactura.Visible = False
            If ComboboxOpciones.SelectedItem.ToString() = "Registrar" Then
                Dim columna As Integer = 1
                Dim columna2 As Integer = 0
                Dim encontrado As Boolean = False
                Dim valor2 As Integer
                Integer.TryParse(NumFactura.Text, valor2)
                Dim valor3 As Integer
                Integer.TryParse(NumCliente.Text, valor3)

                If String.IsNullOrEmpty(DataGridView1.RowCount.ToString) Then 'Si el gridview tiene al menos una fila
                    MessageBox.Show("No hay datos Del Cliente Registrados") 'Muestra un mensaje
                    Exit Sub
                Else
                    For Each row As DataGridViewRow In DataGridView1.Rows 'Recorre las filas del gridview
                        If row.Cells(columna).Value = valor2 And row.Cells(columna2).Value = valor3 Then 'Si el valor de la celda convertido a entero coincide con el valor buscado
                            row.Selected = True 'Selecciona la fila
                            NumFactura.Text = ""
                            encontrado = True
                            NumFactura.SelectionStart = NumFactura.Text.Length
                            BtnAccionLLamada.Visible = False
                            DataGridView1.ClearSelection()
                            DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                            row.Selected = True 'Selecciona la fila
                            Exit For 'Sale del bucle
                        End If
                    Next
                    If Not encontrado Then 'Si no se encontró el valor
                        ErrorCliiente.Visible = False
                        ErrorMensajeGRID.Visible = False
                        DataGridView1.ClearSelection()
                        If NumFactura.Text <> "" And IngresoMinutos.Text <> "" Then
                            BtnAccionLLamada.Visible = True
                            BtnAccionLLamada.BackColor = Color.Green
                            BtnAccionLLamada.Text = "Registrar"
                        End If
                        Exit Sub
                    End If
                End If
            End If
            '------------------------------------------
            If ComboboxOpciones.SelectedItem.ToString() = "Editar" Then
                If NumFactura.Text = "" Then
                    BtnAccionLLamada.Visible = False
                Else
                    DataGridView1.ClearSelection()
                    BtnAccionLLamada.BackColor = Color.Black
                    BtnAccionLLamada.Text = "Buscar"
                    BtnAccionLLamada.Visible = True
                End If
            End If
            '------------------------------------------
            '-------------------------Eliminar
            If ComboboxOpciones.SelectedItem.ToString() = "Eliminar" Then
                Dim columna2 As Integer = 0
                Dim valor4 As Integer

                Integer.TryParse(NumCliente.Text, valor4)
                Dim columna3 As Integer = 0
                Dim valor5 As Integer

                Integer.TryParse(NumCliente.Text, valor5)
                Dim encontrado As Boolean = False
                DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                For Each row As DataGridViewRow In DataGridView1.Rows 'Recorre las filas del gridview
                    If row.Cells(columna2).Value = valor4 And row.Cells(columna3).Value = valor5 Then 'Si el valor de la celda convertido a entero coincide con el valor buscado
                        encontrado = True 'Cambia el indicador a verdadero
                        ErrorMensajeGRID.Visible = False
                        DataGridView1.ClearSelection()
                        row.Selected = True 'Selecciona la fila
                        BtnAccionLLamada.Visible = True
                        BtnAccionLLamada.BackColor = Color.Red
                        BtnAccionLLamada.Text = "Eliminar"
                    End If
                Next
                If Not encontrado Then 'Si no se encontró el valor
                    BtnAccionLLamada.Visible = False
                    ErrorCliiente.Visible = True
                    ErrorMensajeGRID.Visible = True
                    ErrorMensajeGRID.Text = "El cliente que desea eliminar no esta registrado"
                End If
            End If
        End If
    End Sub
    Private Sub NumFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumFactura.KeyPress
        'Permitir solo números enteros
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub IngresoMinutos_TextChanged(sender As Object, e As EventArgs) Handles IngresoMinutos.TextChanged
        Dim regex As New Regex("^[0]+") 'inicio 0
        ' Declarar una variable para almacenar el valor ingresado
        Dim valor As Double
        Double.TryParse(IngresoMinutos.Text, valor)
        If IngresoMinutos.Text = “” Or valor > VALOR_MAXIMO Or regex.IsMatch(IngresoMinutos.Text) Or Not IsNumeric(IngresoMinutos.Text) Then
            If valor > VALOR_MAXIMO Then
                IngresoMinutos.Text = ""
                IngresoMinutos.SelectionStart = IngresoMinutos.Text.Length
            End If
            If IngresoMinutos.Text = “” Or Not IsNumeric(IngresoMinutos.Text) Then
                IngresoMinutos.Text = ""
                ErrorMinutos.Visible = True
                BtnAccionLLamada.Visible = False
            End If
            If regex.IsMatch(IngresoMinutos.Text) Then
                IngresoMinutos.Text = regex.Replace(IngresoMinutos.Text, "") 'no perimitir 01
            End If
        Else
            ErrorMinutos.Visible = False
            If NumCliente.Text <> "" And NumFactura.Text <> "" And ComboboxOpciones.SelectedItem.ToString() = "Registrar" Then
                BtnAccionLLamada.Visible = True
                BtnAccionLLamada.BackColor = Color.Green
                BtnAccionLLamada.Text = "Registrar"
            Else
                BtnAccionLLamada.Visible = False
            End If
            If ComboboxOpciones.SelectedItem.ToString() <> "Registrar" Then
                IngresoMinutos.Enabled = False
                IngresoMinutos.Text = ""
            Else
                IngresoMinutos.Enabled = True
            End If
        End If
    End Sub
    Private Sub IngresoMinutos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IngresoMinutos.KeyPress
        'Permitir solo números enteros
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboboxOpciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboboxOpciones.SelectedIndexChanged
        'limpiar
        If ComboboxOpciones.SelectedItem.ToString() = "Limpiar Campos" Then
            limpiarCampos()
            ComboboxOpciones.SelectedIndex = 0
        End If
        'Registrar
        If ComboboxOpciones.SelectedItem.ToString() = "Registrar" Then
            limpiarCampos()
            If NumCliente.Text <> "" And NumFactura.Text <> "" And IngresoMinutos.Text <> "" Then
                BtnAccionLLamada.Visible = True
                NumFactura.Enabled = True
                IngresoMinutos.Enabled = True
            Else
                BtnAccionLLamada.Visible = False
            End If
        End If
        'editar
        If ComboboxOpciones.SelectedItem.ToString() = "Editar" Then
            limpiarCampos()
            DataGridView1.ReadOnly = False
            DataGridView1.Columns(7).Visible = True
            DataGridView1.Columns(5).ReadOnly = True
            DataGridView1.Columns(6).ReadOnly = True
            'Enable falsess
            ComboboxTipoLlamada.Enabled = False
            'enable true
            NumFactura.Enabled = True
            ComboboxOpciones.Enabled = True
            IngresoMinutos.Enabled = False
            DataGridView1.AllowUserToAddRows = True
            'btn
            BtnAccionLLamada.Visible = True
            BtnAccionLLamada.BackColor = Color.Black
            BtnAccionLLamada.Text = "Buscar"
            '---------------------------------------------------------------------------
        End If
        'eliminar
        'DataGridView1.AllowUserToDeleteRows = False 'Impide que los usuarios eliminen filas existentes
        If ComboboxOpciones.SelectedItem.ToString() = "Eliminar" Then
            limpiarCampos()
            IngresoMinutos.Enabled = False
            ComboboxTipoLlamada.Enabled = False
            NumCliente.Enabled = True
            NumFactura.Enabled = True
            ComboboxOpciones.Enabled = True
            IngresoMinutos.Enabled = False
            DataGridView1.AllowUserToAddRows = False
        End If
        'imprimir
        If ComboboxOpciones.SelectedItem.ToString() = "Imprimir Factura" Then
            limpiarCampos()
            IngresoMinutos.Enabled = False
            ComboboxTipoLlamada.Enabled = False
            NumFactura.Enabled = False
            ComboboxOpciones.Enabled = True
        End If
    End Sub
    Public Sub limpiarCampos()
        'limpiar seleccion
        DataGridView1.ClearSelection()
        DataGridView1.Columns(7).Visible = False
        'editar campos
        DataGridView1.ReadOnly = True
        'opcion para agregar campos directamente
        DataGridView1.AllowUserToAddRows = False
        '# cliente
        NumCliente.Text = ""
        ErrorCliiente.Visible = False
        'factura
        NumFactura.Enabled = True
        NumFactura.Text = ""
        ErrorFactura.Visible = False
        'minutos
        IngresoMinutos.Enabled = True
        IngresoMinutos.Text = ""
        ErrorMinutos.Visible = False
        'default
        BtnAccionLLamada.Visible = False
        ComboboxTipoLlamada.Enabled = True

    End Sub
    'LOCAL As Decimal = 0.03
    'NACIONAL As Decimal = 0.06
    'INTERNACIONAL As Decimal = 0.1
    Private Sub BtnAccionLLamada_Click(sender As Object, e As EventArgs) Handles BtnAccionLLamada.Click
        If NumCliente.Text <> "" And NumFactura.Text <> "" Then
            If ComboboxOpciones.SelectedItem.ToString() = "Registrar" Then
                Dim NumMinut As Double 'numero de minutos
                Double.TryParse(IngresoMinutos.Text, NumMinut)
                Dim calhorario As Integer 'numero de minutos
                'Calculo de monto
                'Variable para almacenar el costo de la llamada
                'calculo de horario
                Dim fecha As DateTime = DateTime.Now 'Obtener la fecha y hora actual
                'Obtener la hora de la fecha
                Dim Horario As String 'Variable para almacenar el mensaje
                Integer.TryParse(fecha.Hour, calhorario)
                'Comparar la hora con los rangos de mañana, tarde y noche
                If calhorario >= 6 And calhorario < 12 Then
                    Horario = "mañana"
                ElseIf calhorario >= 12 And calhorario < 18 Then
                    Horario = "Tarde"
                Else
                    Horario = "noche"
                End If
                Dim costo As Double = 0
                'Calcular el costo según el tipo y el horario de la llamada
                If ComboboxTipoLlamada.Text = "Nacional Local" Then
                    'Si la llamada es local y dura más de 10 minutos, se cobra el exceso
                    If NumMinut > 10 Then
                        costo = (NumMinut - 10) * LOCAL
                    End If

                    'Si la llamada es local y se realizó por la mañana, se duplica el costo
                    If Horario = "mañana" Then
                        costo *= 2
                    End If
                    ErrorMensajeGRID.Visible = False
                End If
                If ComboboxTipoLlamada.Text = "Nacional Larga Distancia" Then
                    'Si la llamada es nacional, se cobra por minuto
                    costo = NumMinut * NACIONAL

                    'Si la llamada es nacional y se realizó por la mañana, se duplica el costo
                    If Horario = "mañana" Then
                        costo *= 2
                    End If
                    ErrorMensajeGRID.Visible = False
                End If
                If ComboboxTipoLlamada.Text = "Larga Distancia Internacional" Then
                    'Si la llamada es internacional, se cobra por minuto
                    costo = NumMinut * INTERNACIONAL

                    'Si la llamada es internacional y se realizó por la mañana, se duplica el costo
                    If Horario = "mañana" Then
                        costo *= 2

                    End If
                    ErrorMensajeGRID.Visible = False
                End If
                'Mostrar el costo de la llamada en un label con formato de moneda
                '--------------------------------------------
                '******************************
                'tabla 1
                DataGridView1.Columns(7).Visible = True
                Me.DataGridView1.Rows.Add(NumCliente.Text, NumFactura.Text, IngresoMinutos.Text, ComboboxTipoLlamada.Text, costo.ToString("###0.0000"), ComboboxOpciones.Text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), Horario)
                BtnAccionLLamada.Visible = False
                DataGridView1.Columns(7).Visible = False
                limpiarCampos()
                NumCliente.Select()
            End If

        Else
            BtnAccionLLamada.Visible = False
        End If
        'Imprimir Factura
        '----------------------------------------------------------------
        If ComboboxOpciones.SelectedItem.ToString() = "Imprimir Factura" Then
            Dim columna2 As Integer = 0
            Dim valor4 As Integer
            Integer.TryParse(NumCliente.Text, valor4)
            DataGridView1.ClearSelection()
            DataGridView1.Columns(7).Visible = True
            For Each row As DataGridViewRow In DataGridView1.Rows 'Recorre las filas del gridview
                If row.Cells(columna2).Value = valor4 Then 'Si el valor de la celda convertido a entero coincide con el valor buscado
                    row.Selected = True
                End If
            Next
            'Variable para almacenar la suma de los datos seleccionados
            ' Crear una variable para almacenar la suma
            Dim Suma As Double = 0
            ' Recorrer las filas seleccionadas del DataGridView
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                ' Sumar el valor de la celda de la columna "TOP_PUNTAJE"
                Suma += row.Cells("Monto").Value.ToString()
            Next
            'impresion de factura 
            Dim newfact As New InformeFactura
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                newfact.DataGridView1.Rows.Add(row.Cells("Factura").Value.ToString, row.Cells("Minutostabla1").Value.ToString, row.Cells("TipoLLamada1").Value.ToString, row.Cells("horarioTable").Value.ToString, row.Cells("Monto").Value.ToString)
            Next
            newfact.DataGridView1.Sort(newfact.DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            newfact.NClient.Text = "Factura del cliente # " & valor4
            newfact.NMontoFinal.Text = Suma.ToString("C")
            newfact.Show()
            'finito
            DataGridView1.Columns(7).Visible = False
            ErrorMensajeGRID.Visible = False
            NumCliente.Text = ""
            NumFactura.Text = ""
            IngresoMinutos.Text = ""
            ComboboxTipoLlamada.SelectedIndex = 0
            BtnAccionLLamada.Visible = False
        End If
        '----------------------------------------------------------------
        '----------Editar------------------
        If ComboboxOpciones.SelectedItem.ToString() = "Editar" Then
            If NumCliente.Text = "" Then
                DataGridView1.ClearSelection()
                BtnAccionLLamada.Visible = False
            Else
                Dim columna2 As Integer = 0
                Dim valor4 As Integer
                Dim columna3 As Integer = 1
                Dim valor5 As Integer
                Dim encontrado As Boolean = False
                Integer.TryParse(NumCliente.Text, valor4)
                Integer.TryParse(NumFactura.Text, valor5)

                DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                If NumFactura.Text = "" Then
                    DataGridView1.ClearSelection()
                    For Each row As DataGridViewRow In DataGridView1.Rows 'Recorre las filas del gridview
                        If row.Cells(columna2).Value = valor4 Then 'Si el valor de la celda convertido a entero coincide con el valor buscado
                            encontrado = True 'Cambia el indicador a verdadero
                            ErrorMensajeGRID.Visible = False
                            row.Selected = True 'Selecciona la fila
                        End If
                    Next
                Else
                    For Each row As DataGridViewRow In DataGridView1.Rows 'Recorre las filas del gridview
                        If row.Cells(columna2).Value = valor4 And row.Cells(columna3).Value = valor5 Then 'Si el valor de la celda convertido a entero coincide con el valor buscado
                            encontrado = True 'Cambia el indicador a verdadero

                            ErrorMensajeGRID.Visible = False
                            DataGridView1.ClearSelection()
                            row.Selected = True 'Selecciona la fila
                            Exit For
                        End If
                    Next
                End If
                If Not encontrado Then 'Si no se encontró el valor
                    DataGridView1.ClearSelection()
                    ErrorCliiente.Visible = True
                    ErrorMensajeGRID.Visible = True
                    ErrorMensajeGRID.Text = "El cliente no esta registrado"

                End If
            End If
        End If
        '-------------------------Eliminar
        If ComboboxOpciones.SelectedItem.ToString() = "Eliminar" Then
            Dim columna2 As Integer = 0
            Dim valor4 As Integer
            Dim columna3 As Integer = 1
            Dim valor5 As Integer
            Dim encontrado As Boolean = False
            Integer.TryParse(NumCliente.Text, valor4)
            Integer.TryParse(NumFactura.Text, valor5)

            DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            If NumFactura.Text = "" Then
                DataGridView1.ClearSelection()
                For Each row As DataGridViewRow In DataGridView1.Rows 'Recorre las filas del gridview
                    If row.Cells(columna2).Value = valor4 Then 'Si el valor de la celda convertido a entero coincide con el valor buscado
                        encontrado = True 'Cambia el indicador a verdadero
                        ErrorMensajeGRID.Visible = False
                        row.Selected = True 'Selecciona la fila
                    End If
                Next
            Else
                For Each row As DataGridViewRow In DataGridView1.Rows 'Recorre las filas del gridview
                    If row.Cells(columna2).Value = valor4 And row.Cells(columna3).Value = valor5 Then 'Si el valor de la celda convertido a entero coincide con el valor buscado
                        encontrado = True 'Cambia el indicador a verdadero
                        ErrorMensajeGRID.Visible = False
                        DataGridView1.ClearSelection()
                        row.Selected = True 'Selecciona la fila
                        Exit For
                    End If
                Next
            End If
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
            If Not encontrado Then 'Si no se encontró el valor
                DataGridView1.ClearSelection()
                ErrorCliiente.Visible = True
                ErrorMensajeGRID.Visible = True
                ErrorMensajeGRID.Text = "El cliente que desea eliminar no esta registrado"

            End If
        End If
        '------------------------------------------
    End Sub
    '-------------------------validaciones de datagridview
    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        ' Remove any existing handler to avoid adding multiple handlers
        RemoveHandler e.Control.KeyPress, AddressOf DataGridView1_KeyPress

        ' Add the new handler
        AddHandler e.Control.KeyPress, AddressOf DataGridView1_KeyPress
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim column As Integer = DataGridView1.CurrentCell.ColumnIndex
        Dim row As Integer = DataGridView1.CurrentCell.RowIndex
        Dim value As String = DataGridView1.EditingControl.Text
        If column = 0 Or column = 1 Or column = 2 Then ' Integer column
            DataGridView1.Rows(row).Cells("Opciones").Value = "Editar"
            DataGridView1.Rows(row).Cells("Ultimo").Value = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
            If value.Length >= 10 Or Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf column = 4 Then ' Decimal column
            If value.Length >= 10 Or Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
                e.Handled = True
            End If
        ElseIf column = 3 Or column = 5 Or column = 6 Or column = 7 Then ' String column
            ' Add any validation for the string column here
            If value.Length >= 20 AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If

        ' Add any additional validation for maximum values here
    End Sub
End Class