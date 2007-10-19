Public Class frmMain

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
   End Sub



   Private Sub SaveToDisk(ByVal intQuality As Integer, ByVal Height As Integer, ByVal Width As Integer, Optional ByVal ReturnFileSize As Boolean = False)
      Try
         Dim myImageManager As New libMage.ImageResizer
         Dim myOriginal As New IO.FileInfo(lblInput.Text)
         Dim myDirOutput As New IO.DirectoryInfo(lblOutput.Text)
         Dim dblTotalFileSize As Double
         Dim intTotalFiles As Integer

         If Not myDirOutput.Exists Then myDirOutput.Create()


         Dim MyFile As IO.FileInfo

         Dim StartTime As Date = Now

         If myOriginal.Extension.ToLower = ".jpg" Then
            MyFile = New IO.FileInfo(myDirOutput.FullName & "\thumb_" & myOriginal.Name)
            MyFile.Delete()

            Dim OutputStream As System.IO.FileStream = MyFile.Create
            myImageManager.ResizeToJPEG(myOriginal.FullName, OutputStream, Height, -1, intQuality)

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
      SaveToDisk(trkQuality.Value, 800, 600)
   End Sub
End Class
