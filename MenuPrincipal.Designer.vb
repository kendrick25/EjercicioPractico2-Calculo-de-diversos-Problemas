<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        border = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        MovForm = New Panel()
        Label2 = New Label()
        BtnClose = New Button()
        BtnMax = New Button()
        BtnMin = New Button()
        SplitContainer1 = New SplitContainer()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel1 = New Panel()
        MenuStrip1 = New MenuStrip()
        ArchivosToolStripMenuItem = New ToolStripMenuItem()
        OpcionesToolStripMenuItem = New ToolStripMenuItem()
        VerMenuToolStripMenuItem1 = New ToolStripMenuItem()
        CerrarTodoToolStripMenuItem = New ToolStripMenuItem()
        Problema1ToolStripMenuItem = New ToolStripMenuItem()
        Problema2ToolStripMenuItem = New ToolStripMenuItem()
        Problema3ToolStripMenuItem = New ToolStripMenuItem()
        Problema4ToolStripMenuItem = New ToolStripMenuItem()
        SoporteToolStripMenuItem = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        TipsToolStripMenuItem = New ToolStripMenuItem()
        Problema1ToolStripMenuItem1 = New ToolStripMenuItem()
        Problema2ToolStripMenuItem1 = New ToolStripMenuItem()
        Problema3ToolStripMenuItem1 = New ToolStripMenuItem()
        Problema4ToolStripMenuItem1 = New ToolStripMenuItem()
        Version35ToolStripMenuItem = New ToolStripMenuItem()
        NosotrosToolStripMenuItem = New ToolStripMenuItem()
        ContForms = New TabControl()
        TabPage1 = New TabPage()
        Panel2 = New Panel()
        btnp1 = New Button()
        menusliptt = New Button()
        btnp2 = New Button()
        Label3 = New Label()
        btnp3 = New Button()
        btnp4 = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PanelNosotros = New Panel()
        Label6 = New Label()
        PictureBox3 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        border.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        MovForm.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        ContForms.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        PanelNosotros.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' border
        ' 
        border.Controls.Add(TableLayoutPanel1)
        border.Dock = DockStyle.Fill
        border.Location = New Point(0, 0)
        border.Margin = New Padding(0)
        border.Name = "border"
        border.Padding = New Padding(3)
        border.Size = New Size(900, 400)
        border.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(MovForm, 0, 0)
        TableLayoutPanel1.Controls.Add(SplitContainer1, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(894, 394)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' MovForm
        ' 
        MovForm.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        MovForm.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        MovForm.Controls.Add(Label2)
        MovForm.Controls.Add(BtnClose)
        MovForm.Controls.Add(BtnMax)
        MovForm.Controls.Add(BtnMin)
        MovForm.ForeColor = SystemColors.ActiveCaptionText
        MovForm.Location = New Point(0, 0)
        MovForm.Margin = New Padding(0)
        MovForm.Name = "MovForm"
        MovForm.Size = New Size(894, 30)
        MovForm.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(18, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 19)
        Label2.TabIndex = 3
        Label2.Text = "DK-CODE"
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnClose.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), Image)
        BtnClose.BackgroundImageLayout = ImageLayout.Center
        BtnClose.FlatAppearance.BorderSize = 0
        BtnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnClose.FlatStyle = FlatStyle.Flat
        BtnClose.ForeColor = Color.Transparent
        BtnClose.Location = New Point(868, 0)
        BtnClose.Margin = New Padding(0)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(26, 30)
        BtnClose.TabIndex = 2
        BtnClose.UseVisualStyleBackColor = False
        ' 
        ' BtnMax
        ' 
        BtnMax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnMax.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnMax.BackgroundImage = CType(resources.GetObject("BtnMax.BackgroundImage"), Image)
        BtnMax.BackgroundImageLayout = ImageLayout.Center
        BtnMax.FlatAppearance.BorderSize = 0
        BtnMax.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnMax.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnMax.FlatStyle = FlatStyle.Flat
        BtnMax.ForeColor = Color.White
        BtnMax.Location = New Point(838, 0)
        BtnMax.Margin = New Padding(0)
        BtnMax.Name = "BtnMax"
        BtnMax.Size = New Size(30, 30)
        BtnMax.TabIndex = 1
        BtnMax.UseVisualStyleBackColor = False
        ' 
        ' BtnMin
        ' 
        BtnMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnMin.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnMin.BackgroundImage = CType(resources.GetObject("BtnMin.BackgroundImage"), Image)
        BtnMin.BackgroundImageLayout = ImageLayout.Center
        BtnMin.FlatAppearance.BorderSize = 0
        BtnMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnMin.FlatStyle = FlatStyle.Flat
        BtnMin.ForeColor = Color.White
        BtnMin.Location = New Point(806, 0)
        BtnMin.Margin = New Padding(0)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(32, 32)
        BtnMin.TabIndex = 0
        BtnMin.UseVisualStyleBackColor = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.BackColor = Color.FromArgb(CByte(190), CByte(190), CByte(252))
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 30)
        SplitContainer1.Margin = New Padding(0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.Transparent
        SplitContainer1.Panel1.Controls.Add(TableLayoutPanel2)
        SplitContainer1.Panel1MinSize = 150
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.CornflowerBlue
        SplitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Center
        SplitContainer1.Panel2.Controls.Add(ContForms)
        SplitContainer1.Panel2.Controls.Add(FlowLayoutPanel1)
        SplitContainer1.Panel2MinSize = 600
        SplitContainer1.Size = New Size(894, 364)
        SplitContainer1.SplitterDistance = 213
        SplitContainer1.TabIndex = 2
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(213, 364)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(213, 364)
        Panel1.TabIndex = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.DimGray
        MenuStrip1.Dock = DockStyle.Fill
        MenuStrip1.GripMargin = New Padding(0)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivosToolStripMenuItem, SoporteToolStripMenuItem, NosotrosToolStripMenuItem})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(0)
        MenuStrip1.Size = New Size(213, 364)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivosToolStripMenuItem
        ' 
        ArchivosToolStripMenuItem.BackColor = Color.Transparent
        ArchivosToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
        ArchivosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpcionesToolStripMenuItem, Problema1ToolStripMenuItem, Problema2ToolStripMenuItem, Problema3ToolStripMenuItem, Problema4ToolStripMenuItem})
        ArchivosToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ArchivosToolStripMenuItem.ForeColor = Color.White
        ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        ArchivosToolStripMenuItem.Padding = New Padding(4, 20, 4, 20)
        ArchivosToolStripMenuItem.Size = New Size(212, 64)
        ArchivosToolStripMenuItem.Text = "Archivos"
        ArchivosToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal
        ' 
        ' OpcionesToolStripMenuItem
        ' 
        OpcionesToolStripMenuItem.BackColor = Color.DimGray
        OpcionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerMenuToolStripMenuItem1, CerrarTodoToolStripMenuItem})
        OpcionesToolStripMenuItem.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        OpcionesToolStripMenuItem.ForeColor = Color.White
        OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        OpcionesToolStripMenuItem.Size = New Size(156, 24)
        OpcionesToolStripMenuItem.Text = "Opciones"
        ' 
        ' VerMenuToolStripMenuItem1
        ' 
        VerMenuToolStripMenuItem1.BackColor = Color.DimGray
        VerMenuToolStripMenuItem1.ForeColor = Color.White
        VerMenuToolStripMenuItem1.Name = "VerMenuToolStripMenuItem1"
        VerMenuToolStripMenuItem1.Size = New Size(157, 24)
        VerMenuToolStripMenuItem1.Text = "Ver Menu"
        ' 
        ' CerrarTodoToolStripMenuItem
        ' 
        CerrarTodoToolStripMenuItem.BackColor = Color.DimGray
        CerrarTodoToolStripMenuItem.ForeColor = Color.White
        CerrarTodoToolStripMenuItem.Name = "CerrarTodoToolStripMenuItem"
        CerrarTodoToolStripMenuItem.Size = New Size(157, 24)
        CerrarTodoToolStripMenuItem.Text = "Cerrar todo"
        ' 
        ' Problema1ToolStripMenuItem
        ' 
        Problema1ToolStripMenuItem.BackColor = Color.DimGray
        Problema1ToolStripMenuItem.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Problema1ToolStripMenuItem.ForeColor = Color.White
        Problema1ToolStripMenuItem.Margin = New Padding(0, 1, 0, 1)
        Problema1ToolStripMenuItem.Name = "Problema1ToolStripMenuItem"
        Problema1ToolStripMenuItem.Padding = New Padding(0, 2, 0, 2)
        Problema1ToolStripMenuItem.Size = New Size(156, 26)
        Problema1ToolStripMenuItem.Text = "Problema 1"
        ' 
        ' Problema2ToolStripMenuItem
        ' 
        Problema2ToolStripMenuItem.BackColor = Color.DimGray
        Problema2ToolStripMenuItem.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Problema2ToolStripMenuItem.ForeColor = Color.White
        Problema2ToolStripMenuItem.Margin = New Padding(0, 1, 0, 1)
        Problema2ToolStripMenuItem.Name = "Problema2ToolStripMenuItem"
        Problema2ToolStripMenuItem.Padding = New Padding(0, 2, 0, 2)
        Problema2ToolStripMenuItem.Size = New Size(156, 26)
        Problema2ToolStripMenuItem.Text = "Problema 2"
        ' 
        ' Problema3ToolStripMenuItem
        ' 
        Problema3ToolStripMenuItem.BackColor = Color.DimGray
        Problema3ToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Problema3ToolStripMenuItem.ForeColor = Color.White
        Problema3ToolStripMenuItem.Margin = New Padding(0, 1, 0, 1)
        Problema3ToolStripMenuItem.Name = "Problema3ToolStripMenuItem"
        Problema3ToolStripMenuItem.Padding = New Padding(0, 2, 0, 2)
        Problema3ToolStripMenuItem.Size = New Size(156, 26)
        Problema3ToolStripMenuItem.Text = "Problema 3"
        ' 
        ' Problema4ToolStripMenuItem
        ' 
        Problema4ToolStripMenuItem.BackColor = Color.DimGray
        Problema4ToolStripMenuItem.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Problema4ToolStripMenuItem.ForeColor = Color.White
        Problema4ToolStripMenuItem.Margin = New Padding(0, 1, 0, 1)
        Problema4ToolStripMenuItem.Name = "Problema4ToolStripMenuItem"
        Problema4ToolStripMenuItem.Padding = New Padding(0, 2, 0, 2)
        Problema4ToolStripMenuItem.Size = New Size(156, 26)
        Problema4ToolStripMenuItem.Text = "Problema 4"
        ' 
        ' SoporteToolStripMenuItem
        ' 
        SoporteToolStripMenuItem.BackColor = Color.Transparent
        SoporteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AcercaDeToolStripMenuItem, Version35ToolStripMenuItem})
        SoporteToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SoporteToolStripMenuItem.ForeColor = Color.White
        SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        SoporteToolStripMenuItem.Padding = New Padding(4, 20, 4, 20)
        SoporteToolStripMenuItem.Size = New Size(212, 65)
        SoporteToolStripMenuItem.Text = "Soporte"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.BackColor = Color.Black
        AcercaDeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TipsToolStripMenuItem})
        AcercaDeToolStripMenuItem.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        AcercaDeToolStripMenuItem.ForeColor = Color.White
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(162, 24)
        AcercaDeToolStripMenuItem.Text = "Acerca de...."
        ' 
        ' TipsToolStripMenuItem
        ' 
        TipsToolStripMenuItem.BackColor = Color.Black
        TipsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Problema1ToolStripMenuItem1, Problema2ToolStripMenuItem1, Problema3ToolStripMenuItem1, Problema4ToolStripMenuItem1})
        TipsToolStripMenuItem.ForeColor = Color.White
        TipsToolStripMenuItem.Name = "TipsToolStripMenuItem"
        TipsToolStripMenuItem.Size = New Size(105, 24)
        TipsToolStripMenuItem.Text = "Tips"
        ' 
        ' Problema1ToolStripMenuItem1
        ' 
        Problema1ToolStripMenuItem1.BackColor = Color.Black
        Problema1ToolStripMenuItem1.ForeColor = Color.White
        Problema1ToolStripMenuItem1.Name = "Problema1ToolStripMenuItem1"
        Problema1ToolStripMenuItem1.Size = New Size(156, 24)
        Problema1ToolStripMenuItem1.Text = "Problema 1"
        ' 
        ' Problema2ToolStripMenuItem1
        ' 
        Problema2ToolStripMenuItem1.BackColor = Color.Black
        Problema2ToolStripMenuItem1.ForeColor = Color.White
        Problema2ToolStripMenuItem1.Name = "Problema2ToolStripMenuItem1"
        Problema2ToolStripMenuItem1.Size = New Size(156, 24)
        Problema2ToolStripMenuItem1.Text = "Problema 2"
        ' 
        ' Problema3ToolStripMenuItem1
        ' 
        Problema3ToolStripMenuItem1.BackColor = Color.Black
        Problema3ToolStripMenuItem1.ForeColor = Color.White
        Problema3ToolStripMenuItem1.Name = "Problema3ToolStripMenuItem1"
        Problema3ToolStripMenuItem1.Size = New Size(156, 24)
        Problema3ToolStripMenuItem1.Text = "Problema 3"
        ' 
        ' Problema4ToolStripMenuItem1
        ' 
        Problema4ToolStripMenuItem1.BackColor = Color.Black
        Problema4ToolStripMenuItem1.ForeColor = Color.White
        Problema4ToolStripMenuItem1.Name = "Problema4ToolStripMenuItem1"
        Problema4ToolStripMenuItem1.Size = New Size(156, 24)
        Problema4ToolStripMenuItem1.Text = "Problema 4"
        ' 
        ' Version35ToolStripMenuItem
        ' 
        Version35ToolStripMenuItem.BackColor = Color.Black
        Version35ToolStripMenuItem.Enabled = False
        Version35ToolStripMenuItem.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Version35ToolStripMenuItem.ForeColor = Color.White
        Version35ToolStripMenuItem.Name = "Version35ToolStripMenuItem"
        Version35ToolStripMenuItem.Size = New Size(162, 24)
        Version35ToolStripMenuItem.Text = "Version 3.5"
        ' 
        ' NosotrosToolStripMenuItem
        ' 
        NosotrosToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NosotrosToolStripMenuItem.ForeColor = Color.White
        NosotrosToolStripMenuItem.Name = "NosotrosToolStripMenuItem"
        NosotrosToolStripMenuItem.Padding = New Padding(4, 20, 4, 20)
        NosotrosToolStripMenuItem.Size = New Size(212, 65)
        NosotrosToolStripMenuItem.Text = "Nosotros"
        ' 
        ' ContForms
        ' 
        ContForms.Controls.Add(TabPage1)
        ContForms.Dock = DockStyle.Fill
        ContForms.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ContForms.Location = New Point(0, 0)
        ContForms.Margin = New Padding(0)
        ContForms.Name = "ContForms"
        ContForms.SelectedIndex = 0
        ContForms.Size = New Size(677, 364)
        ContForms.TabIndex = 1
        ContForms.Visible = False
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel2)
        TabPage1.Location = New Point(4, 30)
        TabPage1.Margin = New Padding(0)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(669, 330)
        TabPage1.TabIndex = 0
        TabPage1.Text = "     +"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel2.Controls.Add(btnp1)
        Panel2.Controls.Add(menusliptt)
        Panel2.Controls.Add(btnp2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btnp3)
        Panel2.Controls.Add(btnp4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(669, 330)
        Panel2.TabIndex = 6
        ' 
        ' btnp1
        ' 
        btnp1.Anchor = AnchorStyles.Top
        btnp1.BackColor = Color.Black
        btnp1.Cursor = Cursors.Hand
        btnp1.FlatAppearance.BorderSize = 0
        btnp1.FlatStyle = FlatStyle.Flat
        btnp1.ForeColor = Color.White
        btnp1.Location = New Point(157, 118)
        btnp1.Margin = New Padding(0)
        btnp1.MaximumSize = New Size(120, 50)
        btnp1.MinimumSize = New Size(120, 50)
        btnp1.Name = "btnp1"
        btnp1.Size = New Size(120, 50)
        btnp1.TabIndex = 0
        btnp1.Text = "Problema 1"
        btnp1.UseVisualStyleBackColor = False
        ' 
        ' menusliptt
        ' 
        menusliptt.BackgroundImage = CType(resources.GetObject("menusliptt.BackgroundImage"), Image)
        menusliptt.BackgroundImageLayout = ImageLayout.Stretch
        menusliptt.Cursor = Cursors.Hand
        menusliptt.FlatAppearance.BorderSize = 0
        menusliptt.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        menusliptt.FlatStyle = FlatStyle.Flat
        menusliptt.Location = New Point(0, 0)
        menusliptt.Margin = New Padding(1, 0, 0, 0)
        menusliptt.MaximumSize = New Size(60, 75)
        menusliptt.MinimumSize = New Size(38, 41)
        menusliptt.Name = "menusliptt"
        menusliptt.Size = New Size(50, 55)
        menusliptt.TabIndex = 5
        menusliptt.UseVisualStyleBackColor = True
        ' 
        ' btnp2
        ' 
        btnp2.Anchor = AnchorStyles.Top
        btnp2.BackColor = Color.Black
        btnp2.Cursor = Cursors.Hand
        btnp2.FlatAppearance.BorderSize = 0
        btnp2.FlatStyle = FlatStyle.Flat
        btnp2.ForeColor = Color.White
        btnp2.Location = New Point(398, 118)
        btnp2.Margin = New Padding(0)
        btnp2.MaximumSize = New Size(120, 50)
        btnp2.MinimumSize = New Size(120, 50)
        btnp2.Name = "btnp2"
        btnp2.Size = New Size(120, 50)
        btnp2.TabIndex = 1
        btnp2.Text = "Problema 2"
        btnp2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(268, 66)
        Label3.MaximumSize = New Size(143, 30)
        Label3.MinimumSize = New Size(143, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 30)
        Label3.TabIndex = 4
        Label3.Text = "PROBLEMAS"
        ' 
        ' btnp3
        ' 
        btnp3.Anchor = AnchorStyles.Top
        btnp3.BackColor = Color.Black
        btnp3.Cursor = Cursors.Hand
        btnp3.FlatAppearance.BorderSize = 0
        btnp3.FlatStyle = FlatStyle.Flat
        btnp3.ForeColor = Color.White
        btnp3.Location = New Point(157, 183)
        btnp3.Margin = New Padding(0)
        btnp3.MaximumSize = New Size(120, 50)
        btnp3.MinimumSize = New Size(120, 50)
        btnp3.Name = "btnp3"
        btnp3.Size = New Size(120, 50)
        btnp3.TabIndex = 2
        btnp3.Text = "Problema 3"
        btnp3.UseVisualStyleBackColor = False
        ' 
        ' btnp4
        ' 
        btnp4.Anchor = AnchorStyles.Top
        btnp4.BackColor = Color.Black
        btnp4.Cursor = Cursors.Hand
        btnp4.FlatAppearance.BorderSize = 0
        btnp4.FlatStyle = FlatStyle.Flat
        btnp4.ForeColor = Color.White
        btnp4.Location = New Point(398, 183)
        btnp4.Margin = New Padding(0)
        btnp4.MaximumSize = New Size(120, 50)
        btnp4.MinimumSize = New Size(120, 50)
        btnp4.Name = "btnp4"
        btnp4.Size = New Size(120, 50)
        btnp4.TabIndex = 3
        btnp4.Text = "Problema 4"
        btnp4.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), Image)
        FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
        FlowLayoutPanel1.Controls.Add(PanelNosotros)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.MinimumSize = New Size(160, 178)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(677, 364)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' PanelNosotros
        ' 
        PanelNosotros.AutoScroll = True
        PanelNosotros.Controls.Add(Label6)
        PanelNosotros.Controls.Add(PictureBox3)
        PanelNosotros.Controls.Add(Label5)
        PanelNosotros.Controls.Add(Label4)
        PanelNosotros.Controls.Add(PictureBox2)
        PanelNosotros.Controls.Add(Label1)
        PanelNosotros.Controls.Add(PictureBox1)
        PanelNosotros.Location = New Point(0, 0)
        PanelNosotros.Margin = New Padding(0)
        PanelNosotros.MaximumSize = New Size(671, 358)
        PanelNosotros.MinimumSize = New Size(671, 358)
        PanelNosotros.Name = "PanelNosotros"
        PanelNosotros.Size = New Size(671, 358)
        PanelNosotros.TabIndex = 0
        PanelNosotros.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(353, 300)
        Label6.Margin = New Padding(0)
        Label6.MaximumSize = New Size(295, 21)
        Label6.MinimumSize = New Size(295, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(295, 21)
        Label6.TabIndex = 6
        Label6.Text = "Correo : DKCodeSolution@gmail.com"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(297, 291)
        PictureBox3.Margin = New Padding(3, 0, 0, 0)
        PictureBox3.MaximumSize = New Size(56, 44)
        PictureBox3.MinimumSize = New Size(56, 44)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(56, 44)
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(76, 300)
        Label5.Margin = New Padding(0)
        Label5.MaximumSize = New Size(213, 21)
        Label5.MinimumSize = New Size(213, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(213, 21)
        Label5.TabIndex = 4
        Label5.Text = "Telefono :  +507 6592-1274"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(281, 257)
        Label4.Margin = New Padding(0)
        Label4.MaximumSize = New Size(105, 21)
        Label4.MinimumSize = New Size(105, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 21)
        Label4.TabIndex = 3
        Label4.Text = "Contáctenos"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(17, 291)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.MaximumSize = New Size(56, 44)
        PictureBox2.MinimumSize = New Size(56, 44)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(56, 44)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(99, 181)
        Label1.Margin = New Padding(0)
        Label1.MaximumSize = New Size(464, 63)
        Label1.MinimumSize = New Size(464, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(464, 63)
        Label1.TabIndex = 1
        Label1.Text = "Somos una Empresa de Desarrollo de Sistemas informáticos" & vbCrLf & "que brinda soluciones óptimas para el cálculo de cualquier " & vbCrLf & "índole que se requiera."
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(249, 33)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.MaximumSize = New Size(209, 141)
        PictureBox1.MinimumSize = New Size(209, 141)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 141)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' MenuPrincipal
        ' 
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(900, 400)
        Controls.Add(border)
        Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MinimumSize = New Size(900, 400)
        Name = "MenuPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "-  CODE"
        border.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        MovForm.ResumeLayout(False)
        MovForm.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContForms.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        PanelNosotros.ResumeLayout(False)
        PanelNosotros.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents border As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MovForm As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnMax As Button
    Friend WithEvents BtnMin As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents NosotrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents ContForms As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents btnp4 As Button
    Friend WithEvents btnp3 As Button
    Friend WithEvents btnp2 As Button
    Friend WithEvents btnp1 As Button
    Friend WithEvents menusliptt As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerMenuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CerrarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Version35ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Problema2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Problema3ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Problema4ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PanelNosotros As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
