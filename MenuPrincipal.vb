Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports EjercicioPractico2.Problema1
Imports EjercicioPractico2.Problema2
Imports EjercicioPractico2.Problema3
Imports EjercicioPractico2.Problema4

Public Class MenuPrincipal

    'variable para tabs
    Dim tapp1 As TabPage
    Dim tapp2 As TabPage
    Dim tapp3 As TabPage
    Dim tapp4 As TabPage
    Public entrada1 As Integer
    Public entrada2 As Integer
    Public entrada3 As Integer
    Public entrada4 As Integer

    ' Variables para guardar la posición y el tamaño del formulario
    Dim mouseDownm As Boolean = False
    Dim mouseX As Integer = 0
    Dim mouseY As Integer = 0
    Dim formWidth As Integer = 0
    Dim formHeight As Integer = 0

    ' Método para detectar cuando se presiona el mouse sobre el borde
    Private Sub Border_MouseDown(sender As Object, e As MouseEventArgs) Handles border.MouseDown
        mouseDownm = True ' Indica que se presionó el mouse
        mouseX = e.X ' Guarda la posición X del mouse
        mouseY = e.Y ' Guarda la posición Y del mouse
        formWidth = Me.Width ' Guarda el ancho del formulario
        formHeight = Me.Height ' Guarda el alto del formulario
    End Sub

    ' Método para detectar cuando se mueve el mouse sobre el borde
    Private Sub Border_MouseMove(sender As Object, e As MouseEventArgs) Handles border.MouseMove
        If mouseDownm Then ' Si se presionó el mouse
            Dim newWidth As Integer = formWidth + (e.X - mouseX) ' Calcula el nuevo ancho del formulario
            Dim newHeight As Integer = formHeight + (e.Y - mouseY) ' Calcula el nuevo alto del formulario
            Me.Size = New Size(newWidth, newHeight) ' Cambia el tamaño del formulario al nuevo tamaño

        Else ' Si no se presionó el mouse
            Dim val As Integer = 3
            If e.X < val And e.Y < val Then ' Si está cerca de la esquina superior izquierda
                border.Cursor = Cursors.SizeNWSE ' Cambia el cursor a diagonal descendente
            ElseIf e.X > border.Width - val And e.Y < val Then ' Si está cerca de la esquina superior derecha
                border.Cursor = Cursors.SizeNESW ' Cambia el cursor a diagonal ascendente
            ElseIf e.X < val And e.Y > border.Height - val Then ' Si está cerca de la esquina inferior izquierda
                border.Cursor = Cursors.SizeNESW ' Cambia el cursor a diagonal ascendente
            ElseIf e.X > border.Width - val And e.Y > border.Height - val Then ' Si está cerca de la esquina inferior derecha
                border.Cursor = Cursors.SizeNWSE ' Cambia el cursor a diagonal descendente
            ElseIf e.X < val Then ' Si está cerca del borde izquierdo
                border.Cursor = Cursors.SizeWE ' Cambia el cursor a horizontal
            ElseIf e.X > border.Width - val Then ' Si está cerca del borde derecho
                border.Cursor = Cursors.SizeWE ' Cambia el cursor a horizontal
            ElseIf e.Y < val Then ' Si está cerca del borde superior
                border.Cursor = Cursors.SizeNS ' Cambia el cursor a vertical
            ElseIf e.Y > border.Height - val Then ' Si está cerca del borde inferior
                border.Cursor = Cursors.SizeNS ' Cambia el cursor a vertical
            Else ' Si no está cerca de ningún borde
                border.Cursor = Cursors.Arrow  ' Cambia el cursor al predeterminado
            End If
        End If
    End Sub

    ' Método para detectar cuando se suelta el mouse sobre el borde
    Private Sub Border_MouseUp(sender As Object, e As MouseEventArgs) Handles border.MouseUp
        mouseDownm = False ' Indica que se soltó el mouse        
        border.Cursor = Cursors.Arrow  ' Cambia el cursor al predeterminado
    End Sub


    'BOTONES DE VENTANA--------------------------------------------------------------------------------------------

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar Todo?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BtnMax_Click_1(sender As Object, e As EventArgs) Handles BtnMax.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            'Button2.text  imagen de boton <-----
        Else
            Me.WindowState = FormWindowState.Maximized
            'Button2.text  imagen de boton <-----
        End If
    End Sub

    Private Sub BtnMin_Click_1(sender As Object, e As EventArgs) Handles BtnMin.Click
        If (Me.WindowState = FormWindowState.Normal) Or (Me.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
    'Mover Ventana -------------------------------------------------------------------------------------------
    Public Enum ResizeDirection
        None = 0
        Left = 1
        TopLeft = 2
        Top = 3
        TopRight = 4
        Right = 5
        BottomRight = 6
        Bottom = 7
        BottomLeft = 8
    End Enum
    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

    Private Sub MoveForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub
    Private Sub MovFom_MouseDown(sender As Object, e As MouseEventArgs) Handles MovForm.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            MoveForm()
        End If
    End Sub
    Private Sub MovFom_MouseUp(sender As Object, e As MouseEventArgs) Handles MovForm.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.WindowState = FormWindowState.Normal
        End If
        MovForm.Cursor = Cursors.Arrow
    End Sub
    'cursor hover--------------------------------------------------------------------------
    'Problema1----------------------------------------------------------------------------------
    Private Sub Problema1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem.Click
        OpenProblema1()

    End Sub
    'Problema2----------------------------------------------------------------------------------
    Private Sub Problema2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem.Click
        OpenProblema2()

    End Sub
    'Problema3----------------------------------------------------------------------------------
    Private Sub Problema3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema3ToolStripMenuItem.Click
        OpenProblema3()
    End Sub
    'Problema4----------------------------------------------------------------------------------
    Private Sub Problema4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema4ToolStripMenuItem.Click
        OpenProblema4()
    End Sub
    'Funcion Para limpiar el panel----------------------------------------------------------------------------------
    'Evento LOAD----------------------------------------------------------------------------------
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelNosotros.Visible = False
        PanelNosotros.Visible = False
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        menusliptt.BackgroundImageLayout = ImageLayout.Stretch
        'ocultar "<---"
        MenuStrip1.Cursor = Cursors.Arrow
        SplitContainer1.Cursor = Cursors.Arrow
        Me.Cursor = Cursors.Arrow
        CerrarTodoToolStripMenuItem.Visible = False
        border.Cursor = Cursors.Arrow
        ContForms.Cursor = Cursors.Arrow
        'colores de menu
        MenuStrip1.Renderer = New renderer()
    End Sub

    Private Sub Menusliptt_Click(sender As Object, e As EventArgs) Handles menusliptt.Click
        If SplitContainer1.Panel1Collapsed = True Then
            SplitContainer1.Panel1Collapsed = False

            menusliptt.BackgroundImage = Image.FromFile("C:\Users\kendr\source\repos\EJCHG\tabRigth.png")
            menusliptt.BackgroundImageLayout = ImageLayout.Stretch
            'Mostrar "--->"
        Else
            SplitContainer1.Panel1Collapsed = True

            menusliptt.BackgroundImage = Image.FromFile("C:\Users\kendr\source\repos\EJCHG\tableft.png")
            menusliptt.BackgroundImageLayout = ImageLayout.Stretch
            'ocultar "<---"
        End If
    End Sub
    'opens de Problema 1
    Public Sub OpenProblema1()
        If ContForms.TabCount >= 1 Then
            CerrarTodoToolStripMenuItem.Visible = True
        Else
            If ContForms.TabCount = 0 Then
                CerrarTodoToolStripMenuItem.Visible = False
            End If
        End If
        Dim mensaje As New Problema1
        ' Si no hay nada abierto
        SplitContainer1.Panel1Collapsed = True
        ContForms.Visible = True
        mensaje.MdiParent = Me
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        If ContForms.TabCount > 1 Then
            tapp1 = ContForms.TabPages(ContForms.TabCount - 1)
        Else
            tapp1 = ContForms.TabPages(0)
        End If
        ContForms.TabPages.Remove(tapp1)
        If entrada1 >= 1 Then
            entrada1 += 1
            Dim newPage As New TabPage("Problema 1 (" & (entrada1) & ")")
            'mover tabb
            newPage.Controls.Add(mensaje)
            ContForms.TabPages.Add(newPage)
        Else
            entrada1 += 1
            Dim newPage As New TabPage("Problema 1")
            'mover tabb
            newPage.Controls.Add(mensaje)
            ContForms.TabPages.Add(newPage)
        End If
        ContForms.TabPages.Add(tapp1)
        ContForms.SelectedIndex = ContForms.TabCount - 2
        mensaje.Show()
    End Sub

    'opens de Problema 2
    Public Sub OpenProblema2()
        If ContForms.TabCount >= 1 Then
            CerrarTodoToolStripMenuItem.Visible = True
        Else
            If ContForms.TabCount = 0 Then
                CerrarTodoToolStripMenuItem.Visible = False
            End If
        End If
        Dim mensaje As New Problema2
        ' Si no hay nada abierto
        SplitContainer1.Panel1Collapsed = True
        ContForms.Visible = True
        mensaje.MdiParent = Me
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        If ContForms.TabCount > 1 Then
            tapp2 = ContForms.TabPages(ContForms.TabCount - 1)
        Else
            tapp2 = ContForms.TabPages(0)
        End If
        ContForms.TabPages.Remove(tapp2)
        If entrada2 >= 1 Then
            entrada2 += 1
            Dim newPage As New TabPage("Problema 2 (" & (entrada2) & ")")
            'mover tabb
            newPage.Controls.Add(mensaje)
            ContForms.TabPages.Add(newPage)
        Else
            entrada2 += 1
            Dim newPage As New TabPage("Problema 2")
            'mover tabb
            newPage.Controls.Add(mensaje)
            ContForms.TabPages.Add(newPage)
        End If
        ContForms.TabPages.Add(tapp2)
        ContForms.SelectedIndex = ContForms.TabCount - 2
        mensaje.Show()
    End Sub
    'opens de Problema 3
    Public Sub OpenProblema3()
        If ContForms.TabCount >= 1 Then
            CerrarTodoToolStripMenuItem.Visible = True
        Else
            If ContForms.TabCount = 0 Then
                CerrarTodoToolStripMenuItem.Visible = False
            End If
        End If
        Dim mensaje As New Problema3
        ' Si no hay nada abierto
        SplitContainer1.Panel1Collapsed = True
        ContForms.Visible = True
        mensaje.MdiParent = Me
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        If ContForms.TabCount > 1 Then
            tapp3 = ContForms.TabPages(ContForms.TabCount - 1)
        Else
            tapp3 = ContForms.TabPages(0)
        End If
        ContForms.TabPages.Remove(tapp3)
        If entrada3 >= 1 Then
            entrada3 += 1
            Dim newPage As New TabPage("Problema 3 (" & (entrada3) & ")")
            'mover tabb
            newPage.Controls.Add(mensaje)
            ContForms.TabPages.Add(newPage)
        Else
            entrada3 += 1
            Dim newPage As New TabPage("Problema 3")
            'mover tabb
            newPage.Controls.Add(mensaje)
            ContForms.TabPages.Add(newPage)
        End If
        ContForms.TabPages.Add(tapp3)
        ContForms.SelectedIndex = ContForms.TabCount - 2
        mensaje.Show()
    End Sub
    'opens de Problema 4
    Public Sub OpenProblema4()
        If ContForms.TabCount >= 1 Then
            CerrarTodoToolStripMenuItem.Visible = True
        Else
            If ContForms.TabCount = 0 Then
                CerrarTodoToolStripMenuItem.Visible = False
            End If
        End If
        Dim mensaje As New Problema4
        ' Si no hay nada abierto
        SplitContainer1.Panel1Collapsed = True
        ContForms.Visible = True
        mensaje.MdiParent = Me
        mensaje.Dock = DockStyle.Fill ' Hace que el formulario se ajuste al tamaño del TabPage
        ' Agrega el formulario al primer TabPage
        If ContForms.TabCount > 1 Then
            tapp4 = ContForms.TabPages(ContForms.TabCount - 1)
        Else
            tapp4 = ContForms.TabPages(0)
        End If
        ContForms.TabPages.Remove(tapp4)
        If entrada4 >= 1 Then
            entrada4 += 1
            Dim newPage As New TabPage("Problema 4 (" & (entrada4) & ")")
            'mover tabb
            newPage.Controls.Add(mensaje)
            ContForms.TabPages.Add(newPage)
        Else
            entrada4 += 1
            Dim newPage As New TabPage("Problema 4")
            'mover tabb
            newPage.Controls.Add(mensaje)
            ContForms.TabPages.Add(newPage)
        End If
        ContForms.TabPages.Add(tapp4)
        ContForms.SelectedIndex = ContForms.TabCount - 2
        mensaje.Show()
    End Sub
    Private Sub Btnp1_Click(sender As Object, e As EventArgs) Handles btnp1.Click
        OpenProblema1()
    End Sub
    Private Sub Btnp2_Click(sender As Object, e As EventArgs) Handles btnp2.Click
        OpenProblema2()
    End Sub
    Private Sub Btnp3_Click(sender As Object, e As EventArgs) Handles btnp3.Click
        OpenProblema3()
    End Sub

    Private Sub Btnp4_Click(sender As Object, e As EventArgs) Handles btnp4.Click
        OpenProblema4()
    End Sub

    Private Sub VerMenuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerMenuToolStripMenuItem1.Click
        VerMenuToolStripMenuItem1.Text = "Ver Menu"
        If ContForms.Visible = False Then
            VerMenuToolStripMenuItem1.Text = "Ocultar Menu"
            ContForms.Visible = True
        Else
            ContForms.Visible = False
        End If
    End Sub

    Private Sub CerrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodoToolStripMenuItem.Click
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea Cerrar Todo?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            entrada1 = Nothing
            entrada2 = Nothing
            entrada3 = Nothing
            entrada4 = Nothing
            ContForms.TabPages.Clear()
            ContForms.Visible = False
            CerrarTodoToolStripMenuItem.Visible = False
            Dim newPage As New TabPage("     +")
            'mover tabb
            newPage.Controls.Add(Panel2)
            ContForms.TabPages.Add(newPage)
        End If

    End Sub
    Private Sub NosotrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NosotrosToolStripMenuItem.Click
        PanelNosotros.Visible = True
        ContForms.Visible = False
        FlowLayoutPanel1.BackgroundImage = Nothing
    End Sub

    Private Sub ArchivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivosToolStripMenuItem.Click
        PanelNosotros.Visible = False
        FlowLayoutPanel1.BackgroundImage = Image.FromFile("C:\Users\kendr\source\repos\EJCHG\Logo 2023.png")
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        If ContForms.Visible = True Then
            VerMenuToolStripMenuItem1.Text = "Ocultar Menu"
        Else
            VerMenuToolStripMenuItem1.Text = "Ver Menu"
        End If
    End Sub
    'ajustes de colores de menu strip
    Private Class renderer
        Inherits ToolStripProfessionalRenderer
        Public Sub New()
            MyBase.New(New cols())
        End Sub
    End Class

    Private Class cols
        Inherits ProfessionalColorTable
        'over de menu
        Public Overrides ReadOnly Property MenuItemSelected As Color
            ' cuando el menú está seleccionado
            Get
                Return Color.CornflowerBlue  'Elige el color que desees para el fondo del menú seleccionado
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
            Get
                Return Color.CornflowerBlue 'Elige el color que desees para el inicio del gradiente del menú seleccionado
            End Get
        End Property
        'sub menu
        Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
            Get
                Return Color.CornflowerBlue 'Elige el color que desees para el final del gradiente del menú seleccionado
            End Get
        End Property
        'Seleccion de menu
        Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
            Get
                Return Color.CornflowerBlue  'Elige el color que desees para el inicio del gradiente del submenú seleccionado
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
            Get
                Return Color.CornflowerBlue  'Elige el color que desees para el final del gradiente del submenú seleccionado
            End Get
        End Property

    End Class
    'sub menu
    Private Sub Problema1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem1.Click
        Dim newtipsmensaje As New Tips
        newtipsmensaje.Text = " Tip Problema 1"
        newtipsmensaje.problem1.Visible = True
        newtipsmensaje.problem1.Dock = DockStyle.Fill
        newtipsmensaje.Show()
    End Sub

    Private Sub Problema2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem1.Click
        Dim newtipsmensaje As New Tips
        newtipsmensaje.Text = " Tip Problema 2"
        newtipsmensaje.Problm2.Visible = True
        newtipsmensaje.Problm2.Dock = DockStyle.Fill
        newtipsmensaje.Show()
    End Sub

    Private Sub Problema3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Problema3ToolStripMenuItem1.Click
        Dim newtipsmensaje As New Tips
        newtipsmensaje.Text = " Tip Problema 3"
        newtipsmensaje.Problem3.Visible = True
        newtipsmensaje.Problem3.Dock = DockStyle.Fill
        newtipsmensaje.Show()
    End Sub

    Private Sub Problema4ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Problema4ToolStripMenuItem1.Click
        Dim newtipsmensaje As New Tips
        newtipsmensaje.Text = " Tip Problema 4"
        newtipsmensaje.Problem4.Visible = True
        newtipsmensaje.Problem4.Dock = DockStyle.Fill
        newtipsmensaje.Show()
    End Sub


End Class