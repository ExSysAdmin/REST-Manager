<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESTManagerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RESTManMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESTManMainStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RESTManMainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.RESTManMainTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ResponseMainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ResponseViewLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DesignDataGridView = New System.Windows.Forms.DataGridView()
        Me.RawDataTextBox = New System.Windows.Forms.TextBox()
        Me.LogTextBox = New System.Windows.Forms.TextBox()
        Me.QASTableBtn = New System.Windows.Forms.Button()
        Me.QASDesignBtn = New System.Windows.Forms.Button()
        Me.QASRawDataBtn = New System.Windows.Forms.Button()
        Me.QASLogBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QASURITextBox = New System.Windows.Forms.TextBox()
        Me.QASRunQueryBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.QASHeaderLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.QASMHBtn = New System.Windows.Forms.Button()
        Me.QASDHBtn = New System.Windows.Forms.Button()
        Me.QASHeaderListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.QASAHBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.QASParameterLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.QASMPBtn = New System.Windows.Forms.Button()
        Me.QASDPBtn = New System.Windows.Forms.Button()
        Me.QASParameterListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.QASAPBtn = New System.Windows.Forms.Button()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResponseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESTManMainMenu.SuspendLayout()
        Me.RESTManMainStatus.SuspendLayout()
        Me.RESTManMainLayoutPanel.SuspendLayout()
        Me.RESTManMainTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ResponseMainLayoutPanel.SuspendLayout()
        Me.ResponseViewLayoutPanel.SuspendLayout()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.QASHeaderLayoutPanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.QASParameterLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RESTManMainMenu
        '
        Me.RESTManMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.RESTManMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.RESTManMainMenu.Name = "RESTManMainMenu"
        Me.RESTManMainMenu.Size = New System.Drawing.Size(800, 24)
        Me.RESTManMainMenu.TabIndex = 0
        Me.RESTManMainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RESTManMainStatus
        '
        Me.RESTManMainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.RESTManMainStatus.Location = New System.Drawing.Point(0, 428)
        Me.RESTManMainStatus.Name = "RESTManMainStatus"
        Me.RESTManMainStatus.Size = New System.Drawing.Size(800, 22)
        Me.RESTManMainStatus.TabIndex = 1
        Me.RESTManMainStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'RESTManMainLayoutPanel
        '
        Me.RESTManMainLayoutPanel.ColumnCount = 3
        Me.RESTManMainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.RESTManMainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RESTManMainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.RESTManMainLayoutPanel.Controls.Add(Me.RESTManMainTabControl, 1, 1)
        Me.RESTManMainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RESTManMainLayoutPanel.Location = New System.Drawing.Point(0, 24)
        Me.RESTManMainLayoutPanel.Name = "RESTManMainLayoutPanel"
        Me.RESTManMainLayoutPanel.RowCount = 3
        Me.RESTManMainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.RESTManMainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RESTManMainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.RESTManMainLayoutPanel.Size = New System.Drawing.Size(800, 404)
        Me.RESTManMainLayoutPanel.TabIndex = 2
        '
        'RESTManMainTabControl
        '
        Me.RESTManMainTabControl.Controls.Add(Me.TabPage1)
        Me.RESTManMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RESTManMainTabControl.Location = New System.Drawing.Point(23, 23)
        Me.RESTManMainTabControl.Name = "RESTManMainTabControl"
        Me.RESTManMainTabControl.SelectedIndex = 0
        Me.RESTManMainTabControl.Size = New System.Drawing.Size(754, 358)
        Me.RESTManMainTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(746, 332)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Query API Structure"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.QASURITextBox, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.QASRunQueryBtn, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 4, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(740, 326)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 6)
        Me.GroupBox1.Controls.Add(Me.ResponseMainLayoutPanel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(13, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 120)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Response"
        '
        'ResponseMainLayoutPanel
        '
        Me.ResponseMainLayoutPanel.ColumnCount = 5
        Me.ResponseMainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.ResponseMainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.ResponseMainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.ResponseMainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.ResponseMainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ResponseMainLayoutPanel.Controls.Add(Me.ResponseViewLayoutPanel, 0, 1)
        Me.ResponseMainLayoutPanel.Controls.Add(Me.QASTableBtn, 0, 0)
        Me.ResponseMainLayoutPanel.Controls.Add(Me.QASDesignBtn, 1, 0)
        Me.ResponseMainLayoutPanel.Controls.Add(Me.QASRawDataBtn, 2, 0)
        Me.ResponseMainLayoutPanel.Controls.Add(Me.QASLogBtn, 3, 0)
        Me.ResponseMainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResponseMainLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.ResponseMainLayoutPanel.Name = "ResponseMainLayoutPanel"
        Me.ResponseMainLayoutPanel.RowCount = 2
        Me.ResponseMainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.ResponseMainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ResponseMainLayoutPanel.Size = New System.Drawing.Size(708, 101)
        Me.ResponseMainLayoutPanel.TabIndex = 0
        '
        'ResponseViewLayoutPanel
        '
        Me.ResponseViewLayoutPanel.ColumnCount = 4
        Me.ResponseMainLayoutPanel.SetColumnSpan(Me.ResponseViewLayoutPanel, 5)
        Me.ResponseViewLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ResponseViewLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0!))
        Me.ResponseViewLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0!))
        Me.ResponseViewLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0!))
        Me.ResponseViewLayoutPanel.Controls.Add(Me.TableDataGridView, 0, 0)
        Me.ResponseViewLayoutPanel.Controls.Add(Me.DesignDataGridView, 1, 0)
        Me.ResponseViewLayoutPanel.Controls.Add(Me.RawDataTextBox, 2, 0)
        Me.ResponseViewLayoutPanel.Controls.Add(Me.LogTextBox, 3, 0)
        Me.ResponseViewLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResponseViewLayoutPanel.Location = New System.Drawing.Point(3, 33)
        Me.ResponseViewLayoutPanel.Name = "ResponseViewLayoutPanel"
        Me.ResponseViewLayoutPanel.RowCount = 1
        Me.ResponseViewLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ResponseViewLayoutPanel.Size = New System.Drawing.Size(702, 65)
        Me.ResponseViewLayoutPanel.TabIndex = 0
        '
        'TableDataGridView
        '
        Me.TableDataGridView.AllowUserToAddRows = False
        Me.TableDataGridView.AllowUserToDeleteRows = False
        Me.TableDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableDataGridView.GridColor = System.Drawing.SystemColors.Window
        Me.TableDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.TableDataGridView.Name = "TableDataGridView"
        Me.TableDataGridView.ReadOnly = True
        Me.TableDataGridView.Size = New System.Drawing.Size(696, 59)
        Me.TableDataGridView.TabIndex = 0
        '
        'DesignDataGridView
        '
        Me.DesignDataGridView.AllowUserToAddRows = False
        Me.DesignDataGridView.AllowUserToDeleteRows = False
        Me.DesignDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DesignDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DesignDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DesignDataGridView.GridColor = System.Drawing.SystemColors.Window
        Me.DesignDataGridView.Location = New System.Drawing.Point(705, 3)
        Me.DesignDataGridView.Name = "DesignDataGridView"
        Me.DesignDataGridView.ReadOnly = True
        Me.DesignDataGridView.Size = New System.Drawing.Size(1, 59)
        Me.DesignDataGridView.TabIndex = 1
        '
        'RawDataTextBox
        '
        Me.RawDataTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RawDataTextBox.Location = New System.Drawing.Point(705, 3)
        Me.RawDataTextBox.Multiline = True
        Me.RawDataTextBox.Name = "RawDataTextBox"
        Me.RawDataTextBox.ReadOnly = True
        Me.RawDataTextBox.Size = New System.Drawing.Size(1, 59)
        Me.RawDataTextBox.TabIndex = 2
        '
        'LogTextBox
        '
        Me.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogTextBox.Location = New System.Drawing.Point(705, 3)
        Me.LogTextBox.Multiline = True
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.ReadOnly = True
        Me.LogTextBox.Size = New System.Drawing.Size(1, 59)
        Me.LogTextBox.TabIndex = 3
        '
        'QASTableBtn
        '
        Me.QASTableBtn.Location = New System.Drawing.Point(3, 3)
        Me.QASTableBtn.Name = "QASTableBtn"
        Me.QASTableBtn.Size = New System.Drawing.Size(69, 23)
        Me.QASTableBtn.TabIndex = 1
        Me.QASTableBtn.Text = "Table"
        Me.QASTableBtn.UseVisualStyleBackColor = True
        '
        'QASDesignBtn
        '
        Me.QASDesignBtn.Location = New System.Drawing.Point(78, 3)
        Me.QASDesignBtn.Name = "QASDesignBtn"
        Me.QASDesignBtn.Size = New System.Drawing.Size(69, 23)
        Me.QASDesignBtn.TabIndex = 2
        Me.QASDesignBtn.Text = "Design"
        Me.QASDesignBtn.UseVisualStyleBackColor = True
        '
        'QASRawDataBtn
        '
        Me.QASRawDataBtn.Location = New System.Drawing.Point(153, 3)
        Me.QASRawDataBtn.Name = "QASRawDataBtn"
        Me.QASRawDataBtn.Size = New System.Drawing.Size(69, 23)
        Me.QASRawDataBtn.TabIndex = 3
        Me.QASRawDataBtn.Text = "Raw Data"
        Me.QASRawDataBtn.UseVisualStyleBackColor = True
        '
        'QASLogBtn
        '
        Me.QASLogBtn.Location = New System.Drawing.Point(228, 3)
        Me.QASLogBtn.Name = "QASLogBtn"
        Me.QASLogBtn.Size = New System.Drawing.Size(69, 23)
        Me.QASLogBtn.TabIndex = 4
        Me.QASLogBtn.Text = "View Log"
        Me.QASLogBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(658, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 24)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "View Query"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Endpoint URI:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QASURITextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.QASURITextBox, 3)
        Me.QASURITextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QASURITextBox.Location = New System.Drawing.Point(113, 13)
        Me.QASURITextBox.Name = "QASURITextBox"
        Me.QASURITextBox.Size = New System.Drawing.Size(464, 20)
        Me.QASURITextBox.TabIndex = 1
        '
        'QASRunQueryBtn
        '
        Me.QASRunQueryBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QASRunQueryBtn.Location = New System.Drawing.Point(583, 13)
        Me.QASRunQueryBtn.Name = "QASRunQueryBtn"
        Me.QASRunQueryBtn.Size = New System.Drawing.Size(69, 24)
        Me.QASRunQueryBtn.TabIndex = 2
        Me.QASRunQueryBtn.Text = "Run Query"
        Me.QASRunQueryBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox2, 3)
        Me.GroupBox2.Controls.Add(Me.QASHeaderLayoutPanel)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(13, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 124)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Headers"
        '
        'QASHeaderLayoutPanel
        '
        Me.QASHeaderLayoutPanel.ColumnCount = 4
        Me.QASHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.QASHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.QASHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.QASHeaderLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.QASHeaderLayoutPanel.Controls.Add(Me.QASMHBtn, 1, 0)
        Me.QASHeaderLayoutPanel.Controls.Add(Me.QASDHBtn, 2, 0)
        Me.QASHeaderLayoutPanel.Controls.Add(Me.QASHeaderListView, 0, 1)
        Me.QASHeaderLayoutPanel.Controls.Add(Me.QASAHBtn, 0, 0)
        Me.QASHeaderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QASHeaderLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.QASHeaderLayoutPanel.Name = "QASHeaderLayoutPanel"
        Me.QASHeaderLayoutPanel.RowCount = 2
        Me.QASHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.QASHeaderLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.QASHeaderLayoutPanel.Size = New System.Drawing.Size(348, 105)
        Me.QASHeaderLayoutPanel.TabIndex = 0
        '
        'QASMHBtn
        '
        Me.QASMHBtn.Enabled = False
        Me.QASMHBtn.Location = New System.Drawing.Point(78, 3)
        Me.QASMHBtn.Name = "QASMHBtn"
        Me.QASMHBtn.Size = New System.Drawing.Size(69, 21)
        Me.QASMHBtn.TabIndex = 7
        Me.QASMHBtn.Text = "Modify"
        Me.QASMHBtn.UseVisualStyleBackColor = True
        '
        'QASDHBtn
        '
        Me.QASDHBtn.Enabled = False
        Me.QASDHBtn.Location = New System.Drawing.Point(153, 3)
        Me.QASDHBtn.Name = "QASDHBtn"
        Me.QASDHBtn.Size = New System.Drawing.Size(69, 21)
        Me.QASDHBtn.TabIndex = 6
        Me.QASDHBtn.Text = "Delete"
        Me.QASDHBtn.UseVisualStyleBackColor = True
        '
        'QASHeaderListView
        '
        Me.QASHeaderListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.QASHeaderLayoutPanel.SetColumnSpan(Me.QASHeaderListView, 4)
        Me.QASHeaderListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QASHeaderListView.HideSelection = False
        Me.QASHeaderListView.Location = New System.Drawing.Point(3, 33)
        Me.QASHeaderListView.MultiSelect = False
        Me.QASHeaderListView.Name = "QASHeaderListView"
        Me.QASHeaderListView.Size = New System.Drawing.Size(342, 69)
        Me.QASHeaderListView.TabIndex = 4
        Me.QASHeaderListView.UseCompatibleStateImageBehavior = False
        Me.QASHeaderListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        '
        'QASAHBtn
        '
        Me.QASAHBtn.Location = New System.Drawing.Point(3, 3)
        Me.QASAHBtn.Name = "QASAHBtn"
        Me.QASAHBtn.Size = New System.Drawing.Size(69, 21)
        Me.QASAHBtn.TabIndex = 5
        Me.QASAHBtn.Text = "Add"
        Me.QASAHBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox3, 3)
        Me.GroupBox3.Controls.Add(Me.QASParameterLayoutPanel)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(373, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 124)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parameters"
        '
        'QASParameterLayoutPanel
        '
        Me.QASParameterLayoutPanel.ColumnCount = 4
        Me.QASParameterLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.QASParameterLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.QASParameterLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.QASParameterLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.QASParameterLayoutPanel.Controls.Add(Me.QASMPBtn, 1, 0)
        Me.QASParameterLayoutPanel.Controls.Add(Me.QASDPBtn, 2, 0)
        Me.QASParameterLayoutPanel.Controls.Add(Me.QASParameterListView, 0, 1)
        Me.QASParameterLayoutPanel.Controls.Add(Me.QASAPBtn, 0, 0)
        Me.QASParameterLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QASParameterLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.QASParameterLayoutPanel.Name = "QASParameterLayoutPanel"
        Me.QASParameterLayoutPanel.RowCount = 2
        Me.QASParameterLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.QASParameterLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.QASParameterLayoutPanel.Size = New System.Drawing.Size(348, 105)
        Me.QASParameterLayoutPanel.TabIndex = 0
        '
        'QASMPBtn
        '
        Me.QASMPBtn.Enabled = False
        Me.QASMPBtn.Location = New System.Drawing.Point(78, 3)
        Me.QASMPBtn.Name = "QASMPBtn"
        Me.QASMPBtn.Size = New System.Drawing.Size(69, 21)
        Me.QASMPBtn.TabIndex = 7
        Me.QASMPBtn.Text = "Modify"
        Me.QASMPBtn.UseVisualStyleBackColor = True
        '
        'QASDPBtn
        '
        Me.QASDPBtn.Enabled = False
        Me.QASDPBtn.Location = New System.Drawing.Point(153, 3)
        Me.QASDPBtn.Name = "QASDPBtn"
        Me.QASDPBtn.Size = New System.Drawing.Size(69, 21)
        Me.QASDPBtn.TabIndex = 6
        Me.QASDPBtn.Text = "Delete"
        Me.QASDPBtn.UseVisualStyleBackColor = True
        '
        'QASParameterListView
        '
        Me.QASParameterListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.QASParameterLayoutPanel.SetColumnSpan(Me.QASParameterListView, 4)
        Me.QASParameterListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QASParameterListView.HideSelection = False
        Me.QASParameterListView.Location = New System.Drawing.Point(3, 33)
        Me.QASParameterListView.MultiSelect = False
        Me.QASParameterListView.Name = "QASParameterListView"
        Me.QASParameterListView.Size = New System.Drawing.Size(342, 69)
        Me.QASParameterListView.TabIndex = 4
        Me.QASParameterListView.UseCompatibleStateImageBehavior = False
        Me.QASParameterListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Value"
        '
        'QASAPBtn
        '
        Me.QASAPBtn.Location = New System.Drawing.Point(3, 3)
        Me.QASAPBtn.Name = "QASAPBtn"
        Me.QASAPBtn.Size = New System.Drawing.Size(69, 21)
        Me.QASAPBtn.TabIndex = 5
        Me.QASAPBtn.Text = "Add"
        Me.QASAPBtn.UseVisualStyleBackColor = True
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllToolStripMenuItem, Me.RequestToolStripMenuItem, Me.ResponseToolStripMenuItem})
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AllToolStripMenuItem.Text = "All"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RequestToolStripMenuItem.Text = "Request"
        '
        'ResponseToolStripMenuItem
        '
        Me.ResponseToolStripMenuItem.Name = "ResponseToolStripMenuItem"
        Me.ResponseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResponseToolStripMenuItem.Text = "Response"
        '
        'RESTManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RESTManMainLayoutPanel)
        Me.Controls.Add(Me.RESTManMainStatus)
        Me.Controls.Add(Me.RESTManMainMenu)
        Me.MainMenuStrip = Me.RESTManMainMenu
        Me.Name = "RESTManagerForm"
        Me.ShowIcon = False
        Me.Text = "REST Manager"
        Me.RESTManMainMenu.ResumeLayout(False)
        Me.RESTManMainMenu.PerformLayout()
        Me.RESTManMainStatus.ResumeLayout(False)
        Me.RESTManMainStatus.PerformLayout()
        Me.RESTManMainLayoutPanel.ResumeLayout(False)
        Me.RESTManMainTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResponseMainLayoutPanel.ResumeLayout(False)
        Me.ResponseViewLayoutPanel.ResumeLayout(False)
        Me.ResponseViewLayoutPanel.PerformLayout()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.QASHeaderLayoutPanel.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.QASParameterLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RESTManMainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RESTManMainStatus As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents RESTManMainLayoutPanel As TableLayoutPanel
    Friend WithEvents RESTManMainTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents QASURITextBox As TextBox
    Friend WithEvents QASRunQueryBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents QASHeaderLayoutPanel As TableLayoutPanel
    Friend WithEvents QASMHBtn As Button
    Friend WithEvents QASDHBtn As Button
    Friend WithEvents QASHeaderListView As ListView
    Friend WithEvents QASAHBtn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents QASParameterLayoutPanel As TableLayoutPanel
    Friend WithEvents QASMPBtn As Button
    Friend WithEvents QASDPBtn As Button
    Friend WithEvents QASParameterListView As ListView
    Friend WithEvents QASAPBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ResponseMainLayoutPanel As TableLayoutPanel
    Friend WithEvents ResponseViewLayoutPanel As TableLayoutPanel
    Friend WithEvents TableDataGridView As DataGridView
    Friend WithEvents DesignDataGridView As DataGridView
    Friend WithEvents RawDataTextBox As TextBox
    Friend WithEvents LogTextBox As TextBox
    Friend WithEvents QASTableBtn As Button
    Friend WithEvents QASDesignBtn As Button
    Friend WithEvents QASRawDataBtn As Button
    Friend WithEvents QASLogBtn As Button
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResponseToolStripMenuItem As ToolStripMenuItem
End Class
