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
      Try
         Dim myImageManager As New libDotNetCoppermine.ImageResizer
         Dim myDirOriginals As New IO.DirectoryInfo(Server.MapPath("Images"))
         Dim myDirOutput As New IO.DirectoryInfo(Server.MapPath("Images\Thumbs"))

         If Not myDirOutput.Exists Then myDirOutput.Create()


         Dim MyFile As IO.FileInfo

         Dim StartTime As Date = Now

         For Each File As System.IO.FileInfo In myDirOriginals.GetFiles
            If File.Extension.ToLower = ".jpg" Then
               MyFile = New IO.FileInfo(myDirOutput.FullName & "\thumb_" & File.Name)
               MyFile.Delete()

               Dim OutputStream As System.IO.FileStream = MyFile.Create
               myImageManager.ResizeToJPEG(File.FullName, OutputStream, 100, txtHeight.Text, txtWidth.Text)
               OutputStream.Close()
               OutputStream.Dispose()
            End If
         Next

         'Dim EndTime As Date = Now

         Response.Write("Execution Time :" & Date.Now.Subtract(StartTime).TotalSeconds.ToString)
      Catch ex As Exception
         Response.Write(ex.ToString)
      End Try
   End Sub
End Class