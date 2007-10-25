Public Class frmMain

   Dim _OriginalImg As Image

   Private Sub btnBrowseOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseOutput.Click
      Me.FolderBrowserDialog1.ShowDialog()

      If Not FolderBrowserDialog1.SelectedPath = "" Then
         Me.lblOutput.Text = FolderBrowserDialog1.SelectedPath
      End If
   End Sub

   Private Sub btnBrowseInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseInput.Click
      OpenFileDialog1.Filter = "JPEG files (*.jpg)|*.jpg"
      Me.OpenFileDialog1.ShowDialog()

      If Not OpenFileDialog1.FileName = "" Then
         Me.lblInput.Text = OpenFileDialog1.FileName
      End If

      _OriginalImg = Image.FromFile(lblInput.Text)

   End Sub



   Private Sub SaveToDisk(ByVal intQuality As Integer, ByVal Width As Integer, ByVal Height As Integer, Optional ByVal ReturnFileSize As Boolean = False)
      Try
         Dim myImageManager As New libMage.ImageResizer
         Dim myOriginal As New IO.FileInfo(lblInput.Text)
         Dim myDirOutput As New IO.DirectoryInfo(lblOutput.Text)
         Dim dblTotalFileSize As Double
         Dim intTotalFiles As Integer

         If Not myDirOutput.Exists Then myDirOutput.Create()

         'get the original image
         'Dim OriginalImg As Image = Image.FromFile(myOriginal.FullName) ' Fetch User Filenam

         Dim MyFile As IO.FileInfo

         Dim StartTime As Date = Now

         If myOriginal.Extension.ToLower = ".jpg" Then

            'delete the file if it exists
            MyFile = New IO.FileInfo(myDirOutput.FullName & "\" & myOriginal.Name & "_" & Width.ToString & "_" & Height.ToString & ".jpg")
            MyFile.Delete()

            Dim OutputStream As System.IO.FileStream = MyFile.Create

            'resize the image based on its longest side to preserve aspect ratio
            If _OriginalImg.Width > _OriginalImg.Height Then
               myImageManager.ResizeToJPEG(myOriginal.FullName, OutputStream, -1, Width, intQuality)
            Else
               myImageManager.ResizeToJPEG(myOriginal.FullName, OutputStream, Height, -1, intQuality)
            End If


            dblTotalFileSize += MyFile.Length
            intTotalFiles += 1

            OutputStream.Close()
            OutputStream.Dispose()
         End If

      Catch ex As Exception
         Throw New Exception("Error creating file", ex)
      End Try
   End Sub

   Private Sub btnResize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResize.Click

      'For each checked box save the thumb

      '4:3 sizes
      If Me.chk640X480.Checked Then SaveToDisk(trkQuality.Value, 640, 480)
      If Me.chk800X600.Checked Then SaveToDisk(trkQuality.Value, 800, 600)
      If Me.chk640X480.Checked Then SaveToDisk(trkQuality.Value, 1024, 768)
      If Me.chk640X480.Checked Then SaveToDisk(trkQuality.Value, 1280, 1024)


      'Widescreen Sizes
      If Me.chk640X480.Checked Then SaveToDisk(trkQuality.Value, 1920, 1200)
      If Me.chk640X480.Checked Then SaveToDisk(trkQuality.Value, 1600, 1200)

   End Sub

   Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
      Dim MyPreview As New frmPreview
      Dim sngAspectRatio As Single
      Dim LongestLength As Integer = 600

      'set form dimensions
      'which side is longest?
      If _OriginalImg.Height > _OriginalImg.Width Then 'Height is the longest
         sngAspectRatio = _OriginalImg.Height / LongestLength

         MyPreview.Height = LongestLength
         MyPreview.Width = _OriginalImg.Width / sngAspectRatio

      Else 'Width is the longest
         sngAspectRatio = _OriginalImg.Width / LongestLength

         MyPreview.Width = LongestLength
         MyPreview.Height = _OriginalImg.Height / sngAspectRatio
      End If


      MyPreview.LoadPreview(lblInput.Text, trkQuality.Value)
      MyPreview.ShowDialog(Me)
   End Sub
End Class