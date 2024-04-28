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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPENFILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECTALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECTALLToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1055, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EWToolStripMenuItem, Me.SAVEASToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.OPENFILEToolStripMenuItem, Me.MOVEToolStripMenuItem, Me.DELETEToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'EWToolStripMenuItem
        '
        Me.EWToolStripMenuItem.Name = "EWToolStripMenuItem"
        Me.EWToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.EWToolStripMenuItem.Text = "NEW"
        '
        'SAVEASToolStripMenuItem
        '
        Me.SAVEASToolStripMenuItem.Name = "SAVEASToolStripMenuItem"
        Me.SAVEASToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.SAVEASToolStripMenuItem.Text = "SAVE AS"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.SAVEToolStripMenuItem.Text = "SAVE"
        '
        'OPENFILEToolStripMenuItem
        '
        Me.OPENFILEToolStripMenuItem.Name = "OPENFILEToolStripMenuItem"
        Me.OPENFILEToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.OPENFILEToolStripMenuItem.Text = "OPEN FILE"
        '
        'MOVEToolStripMenuItem
        '
        Me.MOVEToolStripMenuItem.Name = "MOVEToolStripMenuItem"
        Me.MOVEToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.MOVEToolStripMenuItem.Text = "MOVE"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CUTToolStripMenuItem, Me.COPYToolStripMenuItem, Me.SELECTALLToolStripMenuItem, Me.DELETEALLToolStripMenuItem, Me.SELECTALLToolStripMenuItem1})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'CUTToolStripMenuItem
        '
        Me.CUTToolStripMenuItem.Name = "CUTToolStripMenuItem"
        Me.CUTToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.CUTToolStripMenuItem.Text = "UNDO"
        '
        'COPYToolStripMenuItem
        '
        Me.COPYToolStripMenuItem.Name = "COPYToolStripMenuItem"
        Me.COPYToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.COPYToolStripMenuItem.Text = "REDO"
        '
        'SELECTALLToolStripMenuItem
        '
        Me.SELECTALLToolStripMenuItem.Name = "SELECTALLToolStripMenuItem"
        Me.SELECTALLToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.SELECTALLToolStripMenuItem.Text = "CUT"
        '
        'DELETEALLToolStripMenuItem
        '
        Me.DELETEALLToolStripMenuItem.Name = "DELETEALLToolStripMenuItem"
        Me.DELETEALLToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.DELETEALLToolStripMenuItem.Text = "PASTE"
        '
        'SELECTALLToolStripMenuItem1
        '
        Me.SELECTALLToolStripMenuItem1.Name = "SELECTALLToolStripMenuItem1"
        Me.SELECTALLToolStripMenuItem1.Size = New System.Drawing.Size(154, 24)
        Me.SELECTALLToolStripMenuItem1.Text = "SELECT ALL"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(24, 113)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(996, 529)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1055, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(25, 22)
        Me.ToolStripLabel1.Text = "<-"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 740)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "NOTEPAD"
        Me.UseWaitCursor = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPENFILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SELECTALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SELECTALLToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton

End Class
