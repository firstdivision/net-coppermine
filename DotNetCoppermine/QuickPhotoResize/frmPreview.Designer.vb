<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
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
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
      Me.picPreview = New System.Windows.Forms.PictureBox
      Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
      Me.trkQuality = New System.Windows.Forms.TrackBar
      Me.lblQuality = New System.Windows.Forms.Label
      Me.btnOk = New System.Windows.Forms.Button
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.Panel2.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainer2.Panel1.SuspendLayout()
      Me.SplitContainer2.Panel2.SuspendLayout()
      Me.SplitContainer2.SuspendLayout()
      CType(Me.trkQuality, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'SplitContainer1
      '
      Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
      Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer1.Name = "SplitContainer1"
      Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'SplitContainer1.Panel1
      '
      Me.SplitContainer1.Panel1.Controls.Add(Me.picPreview)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
      Me.SplitContainer1.Size = New System.Drawing.Size(632, 446)
      Me.SplitContainer1.SplitterDistance = 399
      Me.SplitContainer1.TabIndex = 0
      '
      'picPreview
      '
      Me.picPreview.Dock = System.Windows.Forms.DockStyle.Fill
      Me.picPreview.Location = New System.Drawing.Point(0, 0)
      Me.picPreview.Name = "picPreview"
      Me.picPreview.Size = New System.Drawing.Size(632, 399)
      Me.picPreview.TabIndex = 2
      Me.picPreview.TabStop = False
      '
      'SplitContainer2
      '
      Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
      Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer2.Name = "SplitContainer2"
      '
      'SplitContainer2.Panel1
      '
      Me.SplitContainer2.Panel1.Controls.Add(Me.trkQuality)
      '
      'SplitContainer2.Panel2
      '
      Me.SplitContainer2.Panel2.Controls.Add(Me.lblQuality)
      Me.SplitContainer2.Panel2.Controls.Add(Me.btnOk)
      Me.SplitContainer2.Size = New System.Drawing.Size(632, 43)
      Me.SplitContainer2.SplitterDistance = 491
      Me.SplitContainer2.TabIndex = 0
      '
      'trkQuality
      '
      Me.trkQuality.Dock = System.Windows.Forms.DockStyle.Fill
      Me.trkQuality.Location = New System.Drawing.Point(0, 0)
      Me.trkQuality.Maximum = 100
      Me.trkQuality.Name = "trkQuality"
      Me.trkQuality.Size = New System.Drawing.Size(491, 43)
      Me.trkQuality.TabIndex = 3
      '
      'lblQuality
      '
      Me.lblQuality.Location = New System.Drawing.Point(3, 13)
      Me.lblQuality.Name = "lblQuality"
      Me.lblQuality.Size = New System.Drawing.Size(64, 19)
      Me.lblQuality.TabIndex = 5
      Me.lblQuality.Text = "-"
      '
      'btnOk
      '
      Me.btnOk.Location = New System.Drawing.Point(78, 9)
      Me.btnOk.Name = "btnOk"
      Me.btnOk.Size = New System.Drawing.Size(47, 23)
      Me.btnOk.TabIndex = 4
      Me.btnOk.Text = "Ok"
      Me.btnOk.UseVisualStyleBackColor = True
      '
      'frmPreview
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(632, 446)
      Me.Controls.Add(Me.SplitContainer1)
      Me.Name = "frmPreview"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "frmPreview"
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      Me.SplitContainer1.ResumeLayout(False)
      CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer2.Panel1.ResumeLayout(False)
      Me.SplitContainer2.Panel1.PerformLayout()
      Me.SplitContainer2.Panel2.ResumeLayout(False)
      Me.SplitContainer2.ResumeLayout(False)
      CType(Me.trkQuality, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents picPreview As System.Windows.Forms.PictureBox
   Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
   Friend WithEvents trkQuality As System.Windows.Forms.TrackBar
   Friend WithEvents lblQuality As System.Windows.Forms.Label
   Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
