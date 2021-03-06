<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("multi-script support")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("multi-language support")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("execute up to 4 scripts at a time")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("undetectable scripts")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("scripts", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User-friendly UI")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("sepparate, dockable containers")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("buttons")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("can add custom programmable buttons")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UI", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("functions", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode10})
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.p1 = New System.Windows.Forms.ProgressBar()
        Me.p2 = New System.Windows.Forms.ProgressBar()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.t1 = New System.Windows.Forms.Timer(Me.components)
        Me.t2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the installer! This will install the XtraDemolition Game Hacker/Script" &
    "er injector."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Installation Path:"
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Location = New System.Drawing.Point(103, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(308, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "style.hidden({default.settings.installationpath}\{application.name}.{extension})"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.No
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(417, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(674, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "The installer killed explorer.exe to make sure that it doesn't interfere with the" &
    " installer. It will automatically start when the installation is complete."
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Demo scripts", "Roblox scripts (rev7)", "Minecraft scripts (unstable) (rev3)", "Among Us scripts (new) (unstable) (rev1)", "App activation scripts (rev14)"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 64)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(776, 124)
        Me.CheckedListBox1.TabIndex = 6
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 194)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node2"
        TreeNode1.Text = "multi-script support"
        TreeNode2.Name = "Node3"
        TreeNode2.Text = "multi-language support"
        TreeNode3.Name = "Node4"
        TreeNode3.Text = "execute up to 4 scripts at a time"
        TreeNode4.Name = "Node5"
        TreeNode4.Text = "undetectable scripts"
        TreeNode5.Name = "Node1"
        TreeNode5.Text = "scripts"
        TreeNode6.Name = "Node7"
        TreeNode6.Text = "User-friendly UI"
        TreeNode7.Name = "Node8"
        TreeNode7.Text = "sepparate, dockable containers"
        TreeNode8.Name = "Node10"
        TreeNode8.Text = "buttons"
        TreeNode9.Name = "Node11"
        TreeNode9.Text = "can add custom programmable buttons"
        TreeNode10.Name = "Node6"
        TreeNode10.Text = "UI"
        TreeNode11.Name = "Node0"
        TreeNode11.Text = "functions"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode11})
        Me.TreeView1.Size = New System.Drawing.Size(776, 121)
        Me.TreeView1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Download data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(12, 350)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Install data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'p1
        '
        Me.p1.Location = New System.Drawing.Point(116, 321)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(672, 23)
        Me.p1.TabIndex = 10
        '
        'p2
        '
        Me.p2.Location = New System.Drawing.Point(116, 350)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(672, 23)
        Me.p2.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(713, 379)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        't1
        '
        '
        't2
        '
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 379)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "debug: enable taskmgr"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(148, 379)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(130, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "debug: disable taskmgr"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.XtraDemolition_v1_installer.My.Resources.Resources.xD
        Me.PictureBox1.Location = New System.Drawing.Point(734, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(484, 382)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(223, 20)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = "https://discordgift.site/c/wh7X0x6PwI7M0jug"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 413)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XtraDemolition installer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents p1 As ProgressBar
    Friend WithEvents p2 As ProgressBar
    Friend WithEvents Button4 As Button
    Friend WithEvents t1 As Timer
    Friend WithEvents t2 As Timer
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
End Class
