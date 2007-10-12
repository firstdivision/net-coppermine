Imports MySql.Data.MySqlClient
Partial Public Class _Default
   Inherits System.Web.UI.Page

   Protected Sub lnkResize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkResize.Click
      Try
         Dim myDirOriginals As New IO.DirectoryInfo(Server.MapPath("Images"))
         Dim MyImage As New Image
         For Each File As System.IO.FileInfo In myDirOriginals.GetFiles
            If File.Extension.ToLower = ".jpg" Then
               MyImage = New Image
               MyImage.ImageUrl = "DynamicImage.aspx?OriginalImageURL=" & File.FullName & "&Height=" & txtHeight.Text & "&Width=" & txtWidth.Text & "&Quality=" & txtQuality.Text
               plhResize.Controls.Add(MyImage)
            End If
         Next
      Catch ex As Exception
         Response.Write(ex.ToString)
      End Try
   End Sub

   Protected Sub lnkSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkSave.Click
      SaveToDisk(txtQuality.Text, txtHeight.Text, txtWidth.Text)
   End Sub

   Protected Sub lnkResizeLongestSide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkResizeLongestSide.Click
      Try
         Dim myDirOriginals As New IO.DirectoryInfo(Server.MapPath("Images"))
         Dim MyImage As New Image
         For Each File As System.IO.FileInfo In myDirOriginals.GetFiles
            If File.Extension.ToLower = ".jpg" Then
               MyImage = New Image
               MyImage.ImageUrl = "DynamicImage.aspx?LongestLength=" & Me.txtLongestSide.Text & "&OriginalImageURL=" & File.FullName & "&Quality=" & txtQuality.Text
               plhResize.Controls.Add(MyImage)
            End If
         Next
      Catch ex As Exception
         Response.Write(ex.ToString)
      End Try
   End Sub

   Protected Sub lnkPercentReduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkPercentReduction.Click
      Try
         Dim myDirOriginals As New IO.DirectoryInfo(Server.MapPath("Images"))
         Dim MyImage As New Image
         For Each File As System.IO.FileInfo In myDirOriginals.GetFiles
            If File.Extension.ToLower = ".jpg" Then
               MyImage = New Image
               MyImage.ImageUrl = "DynamicImage.aspx?OriginalImageURL=" & File.FullName & "&PercentReduction=" & txtPercentage.Text & "&Quality=" & txtQuality.Text
               plhResize.Controls.Add(MyImage)
            End If
         Next
      Catch ex As Exception
         Response.Write(ex.ToString)
      End Try
   End Sub

   Protected Sub lnkTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkTest.Click
      Dim dtResults As New DataTable
      dtResults.Columns.Add("Quality")
      dtResults.Columns.Add("Render Time")

      'Quality Test
      For i As Integer = 10 To 100 Step 10
         Dim dr As DataRow = dtResults.NewRow
         dr(0) = i
         dr(1) = SaveToDisk(i, txtHeight.Text, txtWidth.Text)
         dtResults.Rows.Add(dr)
      Next

      Dim MyLabel As New Label
      MyLabel.Text = "<h3>Test Effect of Quality Setting on Generation Time</h3>"
      plhResize.Controls.Add(MyLabel)

      Dim myGridView As New GridView
      plhResize.Controls.Add(myGridView)
      myGridView.DataSource = dtResults
      myGridView.DataBind()


      'FileSize Test
      dtResults.Clear()
      dtResults.Columns(0).ColumnName = "Quality"
      dtResults.Columns(1).ColumnName = "File Size"
      For i As Integer = 10 To 100 Step 10
         Dim dr As DataRow = dtResults.NewRow
         dr(0) = i
         dr(1) = SaveToDisk(i, txtHeight.Text, txtWidth.Text, True)
         dtResults.Rows.Add(dr)
      Next

      Dim MyLabel3 As New Label
      MyLabel3.Text = "<h3>Test Effect of Quality on File Size</h3>"
      plhResize.Controls.Add(MyLabel3)

      Dim myGridView3 As New GridView
      plhResize.Controls.Add(myGridView3)
      myGridView3.DataSource = dtResults
      myGridView3.DataBind()


      'Dimension Test
      dtResults.Clear()
      dtResults.Columns(0).ColumnName = "Dimension Size"
      dtResults.Columns(1).ColumnName = "Render Time"
      For i As Integer = 10 To 1010 Step 100
         Dim dr As DataRow = dtResults.NewRow
         dr(0) = i
         dr(1) = SaveToDisk(txtQuality.Text, i, i)
         dtResults.Rows.Add(dr)
      Next

      Dim MyLabel2 As New Label
      MyLabel2.Text = "<h3>Test Effect of Size on Render Time</h3>"
      plhResize.Controls.Add(MyLabel2)

      Dim myGridView2 As New GridView
      plhResize.Controls.Add(myGridView2)
      myGridView2.DataSource = dtResults
      myGridView2.DataBind()

   End Sub

   Private Function SaveToDisk(ByVal intQuality As Integer, ByVal Height As Integer, ByVal Width As Integer, Optional ByVal ReturnFileSize As Boolean = False) As String
      Try
         Dim myImageManager As New libMage.ImageResizer
         Dim myDirOriginals As New IO.DirectoryInfo(Server.MapPath("Images"))
         Dim myDirOutput As New IO.DirectoryInfo(Server.MapPath("Images\Thumbs"))
         Dim dblTotalFileSize As Double
         Dim intTotalFiles As Integer

         If Not myDirOutput.Exists Then myDirOutput.Create()


         Dim MyFile As IO.FileInfo

         Dim StartTime As Date = Now

         For Each File As System.IO.FileInfo In myDirOriginals.GetFiles
            If File.Extension.ToLower = ".jpg" Then
               MyFile = New IO.FileInfo(myDirOutput.FullName & "\thumb_" & File.Name)
               MyFile.Delete()

               Dim OutputStream As System.IO.FileStream = MyFile.Create
               myImageManager.ResizeToJPEG(File.FullName, OutputStream, Height, Width, intQuality)

               dblTotalFileSize += MyFile.Length
               intTotalFiles += 1

               OutputStream.Close()
               OutputStream.Dispose()
            End If
         Next

         If ReturnFileSize Then
            Return (dblTotalFileSize / intTotalFiles).ToString("n2")
         Else
            Return Date.Now.Subtract(StartTime).TotalSeconds.ToString("n2")
         End If
      Catch ex As Exception
         Response.Write(ex.ToString)
      End Try
   End Function

 

End Class