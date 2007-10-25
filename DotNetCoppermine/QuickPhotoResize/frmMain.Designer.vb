<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
      Me.GroupBox1 = New System.Windows.Forms.GroupBox
      Me.btnBrowseOutput = New System.Windows.Forms.Button
      Me.btnBrowseInput = New System.Windows.Forms.Button
      Me.lblInput = New System.Windows.Forms.Label
      Me.lblOutput = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.GroupBox2 = New System.Windows.Forms.GroupBox
      Me.chk1920X1200 = New System.Windows.Forms.CheckBox
      Me.chk1600X1200 = New System.Windows.Forms.CheckBox
      Me.chk1280X1024 = New System.Windows.Forms.CheckBox
      Me.chk1024X768 = New System.Windows.Forms.CheckBox
      Me.chk640X480 = New System.Windows.Forms.CheckBox
      Me.chk800X600 = New System.Windows.Forms.CheckBox
      Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
      Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
      Me.GroupBox4 = New System.Windows.Forms.GroupBox
      Me.trkQuality = New System.Windows.Forms.TrackBar
      Me.btnResize = New System.Windows.Forms.Button
      Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
      Me.prgResizeProgress = New System.Windows.Forms.ToolStripProgressBar
      Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
      Me.btnPreview = New System.Windows.Forms.Button
      Me.GroupBox1.SuspendLayout()
      Me.GroupBox2.SuspendLayout()
      Me.GroupBox4.SuspendLayout()
      CType(Me.trkQuality, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.StatusStrip1.SuspendLayout()
      Me.SuspendLayout()
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.btnBrowseOutput)
      Me.GroupBox1.Controls.Add(Me.btnBrowseInput)
      Me.GroupBox1.Controls.Add(Me.lblInput)
      Me.GroupBox1.Controls.Add(Me.lblOutput)
      Me.GroupBox1.Controls.Add(Me.Label2)
      Me.GroupBox1.Controls.Add(Me.Label1)
      Me.GroupBox1.Location = New System.Drawing.Point(14, 17)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(523, 82)
      Me.GroupBox1.TabIndex = 0
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Input / Output"
      '
      'btnBrowseOutput
      '
      Me.btnBrowseOutput.Location = New System.Drawing.Point(427, 49)
      Me.btnBrowseOutput.Name = "btnBrowseOutput"
      Me.btnBrowseOutput.Size = New System.Drawing.Size(75, 23)
      Me.btnBrowseOutput.TabIndex = 6
      Me.btnBrowseOutput.Text = "Browse..."
      Me.btnBrowseOutput.UseVisualStyleBackColor = True
      '
      'btnBrowseInput
      '
      Me.btnBrowseInput.Location = New System.Drawing.Point(427, 21)
      Me.btnBrowseInput.Name = "btnBrowseInput"
      Me.btnBrowseInput.Size = New System.Drawing.Size(75, 23)
      Me.btnBrowseInput.TabIndex = 5
      Me.btnBrowseInput.Text = "Browse..."
      Me.btnBrowseInput.UseVisualStyleBackColor = True
      '
      'lblInput
      '
      Me.lblInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblInput.Location = New System.Drawing.Point(64, 25)
      Me.lblInput.Name = "lblInput"
      Me.lblInput.Size = New System.Drawing.Size(357, 17)
      Me.lblInput.TabIndex = 4
      '
      'lblOutput
      '
      Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblOutput.Location = New System.Drawing.Point(64, 53)
      Me.lblOutput.Name = "lblOutput"
      Me.lblOutput.Size = New System.Drawing.Size(357, 18)
      Me.lblOutput.TabIndex = 3
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(16, 53)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(42, 13)
      Me.Label2.TabIndex = 1
      Me.Label2.Text = "Output:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(16, 25)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(34, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Input:"
      '
      'GroupBox2
      '
      Me.GroupBox2.Controls.Add(Me.chk1920X1200)
      Me.GroupBox2.Controls.Add(Me.chk1600X1200)
      Me.GroupBox2.Controls.Add(Me.chk1280X1024)
      Me.GroupBox2.Controls.Add(Me.chk1024X768)
      Me.GroupBox2.Controls.Add(Me.chk640X480)
      Me.GroupBox2.Controls.Add(Me.chk800X600)
      Me.GroupBox2.Location = New System.Drawing.Point(14, 106)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(258, 139)
      Me.GroupBox2.TabIndex = 1
      Me.GroupBox2.TabStop = False
      Me.GroupBox2.Text = "Output Sizes"
      '
      'chk1920X1200
      '
      Me.chk1920X1200.AutoSize = True
      Me.chk1920X1200.Checked = True
      Me.chk1920X1200.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chk1920X1200.Location = New System.Drawing.Point(153, 19)
      Me.chk1920X1200.Name = "chk1920X1200"
      Me.chk1920X1200.Size = New System.Drawing.Size(87, 17)
      Me.chk1920X1200.TabIndex = 5
      Me.chk1920X1200.Text = "1920 X 1200"
      Me.chk1920X1200.UseVisualStyleBackColor = True
      '
      'chk1600X1200
      '
      Me.chk1600X1200.AutoSize = True
      Me.chk1600X1200.Checked = True
      Me.chk1600X1200.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chk1600X1200.Location = New System.Drawing.Point(153, 42)
      Me.chk1600X1200.Name = "chk1600X1200"
      Me.chk1600X1200.Size = New System.Drawing.Size(87, 17)
      Me.chk1600X1200.TabIndex = 4
      Me.chk1600X1200.Text = "1600 X 1200"
      Me.chk1600X1200.UseVisualStyleBackColor = True
      '
      'chk1280X1024
      '
      Me.chk1280X1024.AutoSize = True
      Me.chk1280X1024.Checked = True
      Me.chk1280X1024.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chk1280X1024.Location = New System.Drawing.Point(19, 88)
      Me.chk1280X1024.Name = "chk1280X1024"
      Me.chk1280X1024.Size = New System.Drawing.Size(87, 17)
      Me.chk1280X1024.TabIndex = 3
      Me.chk1280X1024.Text = "1280 X 1024"
      Me.chk1280X1024.UseVisualStyleBackColor = True
      '
      'chk1024X768
      '
      Me.chk1024X768.AutoSize = True
      Me.chk1024X768.Checked = True
      Me.chk1024X768.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chk1024X768.Location = New System.Drawing.Point(19, 65)
      Me.chk1024X768.Name = "chk1024X768"
      Me.chk1024X768.Size = New System.Drawing.Size(81, 17)
      Me.chk1024X768.TabIndex = 2
      Me.chk1024X768.Text = "1024 X 768"
      Me.chk1024X768.UseVisualStyleBackColor = True
      '
      'chk640X480
      '
      Me.chk640X480.AutoSize = True
      Me.chk640X480.Checked = True
      Me.chk640X480.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chk640X480.Location = New System.Drawing.Point(19, 19)
      Me.chk640X480.Name = "chk640X480"
      Me.chk640X480.Size = New System.Drawing.Size(75, 17)
      Me.chk640X480.TabIndex = 1
      Me.chk640X480.Text = "640 X 480"
      Me.chk640X480.UseVisualStyleBackColor = True
      '
      'chk800X600
      '
      Me.chk800X600.AutoSize = True
      Me.chk800X600.Checked = True
      Me.chk800X600.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chk800X600.Location = New System.Drawing.Point(19, 42)
      Me.chk800X600.Name = "chk800X600"
      Me.chk800X600.Size = New System.Drawing.Size(75, 17)
      Me.chk800X600.TabIndex = 0
      Me.chk800X600.Text = "800 X 600"
      Me.chk800X600.UseVisualStyleBackColor = True
      '
      'OpenFileDialog1
      '
      Me.OpenFileDialog1.FileName = "OpenFileDialog1"
      '
      'GroupBox4
      '
      Me.GroupBox4.Controls.Add(Me.trkQuality)
      Me.GroupBox4.Location = New System.Drawing.Point(290, 123)
      Me.GroupBox4.Name = "GroupBox4"
      Me.GroupBox4.Size = New System.Drawing.Size(247, 65)
      Me.GroupBox4.TabIndex = 3
      Me.GroupBox4.TabStop = False
      Me.GroupBox4.Text = "Output Qualilty"
      '
      'trkQuality
      '
      Me.trkQuality.Location = New System.Drawing.Point(21, 19)
      Me.trkQuality.Maximum = 100
      Me.trkQuality.Name = "trkQuality"
      Me.trkQuality.Size = New System.Drawing.Size(205, 45)
      Me.trkQuality.TabIndex = 0
      Me.trkQuality.Value = 80
      '
      'btnResize
      '
      Me.btnResize.Enabled = False
      Me.btnResize.Location = New System.Drawing.Point(441, 205)
      Me.btnResize.Name = "btnResize"
      Me.btnResize.Size = New System.Drawing.Size(75, 23)
      Me.btnResize.TabIndex = 4
      Me.btnResize.Text = "Resize"
      Me.btnResize.UseVisualStyleBackColor = True
      '
      'StatusStrip1
      '
      Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prgResizeProgress, Me.lblStatus})
      Me.StatusStrip1.Location = New System.Drawing.Point(0, 261)
      Me.StatusStrip1.Name = "StatusStrip1"
      Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.StatusStrip1.Size = New System.Drawing.Size(550, 22)
      Me.StatusStrip1.TabIndex = 5
      Me.StatusStrip1.Text = "StatusStrip1"
      '
      'prgResizeProgress
      '
      Me.prgResizeProgress.Name = "prgResizeProgress"
      Me.prgResizeProgress.Size = New System.Drawing.Size(100, 16)
      '
      'lblStatus
      '
      Me.lblStatus.Name = "lblStatus"
      Me.lblStatus.Size = New System.Drawing.Size(50, 17)
      Me.lblStatus.Text = "Status..."
      Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'btnPreview
      '
      Me.btnPreview.Enabled = False
      Me.btnPreview.Location = New System.Drawing.Point(338, 205)
      Me.btnPreview.Name = "btnPreview"
      Me.btnPreview.Size = New System.Drawing.Size(97, 23)
      Me.btnPreview.TabIndex = 6
      Me.btnPreview.Text = "Show Preview"
      Me.btnPreview.UseVisualStyleBackColor = True
      '
      'frmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(550, 283)
      Me.Controls.Add(Me.btnPreview)
      Me.Controls.Add(Me.StatusStrip1)
      Me.Controls.Add(Me.btnResize)
      Me.Controls.Add(Me.GroupBox4)
      Me.Controls.Add(Me.GroupBox2)
      Me.Controls.Add(Me.GroupBox1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.MaximizeBox = False
      Me.Name = "frmMain"
      Me.Text = "Quick Image Resize"
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.GroupBox2.ResumeLayout(False)
      Me.GroupBox2.PerformLayout()
      Me.GroupBox4.ResumeLayout(False)
      Me.GroupBox4.PerformLayout()
      CType(Me.trkQuality, System.ComponentModel.ISupportInitialize).EndInit()
      Me.StatusStrip1.ResumeLayout(False)
      Me.StatusStrip1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents lblInput As System.Windows.Forms.Label
   Friend WithEvents lblOutput As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents btnBrowseInput As System.Windows.Forms.Button
   Friend WithEvents btnBrowseOutput As System.Windows.Forms.Button
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents chk640X480 As System.Windows.Forms.CheckBox
   Friend WithEvents chk800X600 As System.Windows.Forms.CheckBox
   Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
   Friend WithEvents trkQuality As System.Windows.Forms.TrackBar
   Friend WithEvents btnResize As System.Windows.Forms.Button
   Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
   Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents prgResizeProgress As System.Windows.Forms.ToolStripProgressBar
   Friend WithEvents chk1024X768 As System.Windows.Forms.CheckBox
   Friend WithEvents btnPreview As System.Windows.Forms.Button
   Friend WithEvents chk1280X1024 As System.Windows.Forms.CheckBox
   Friend WithEvents chk1920X1200 As System.Windows.Forms.CheckBox
   Friend WithEvents chk1600X1200 As System.Windows.Forms.CheckBox

End Class
