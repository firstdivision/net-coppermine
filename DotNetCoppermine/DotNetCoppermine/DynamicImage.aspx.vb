Public Partial Class DynamicImage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Dim myImageManager As New libDotNetCoppermine.ImageResizer

      Response.Clear()
      Response.ContentType = "image/jpeg"

      If Request.QueryString("PercentReduction") <> "" Then
         myImageManager.ResizeToJPEG(CStr(Request.QueryString("OriginalImageURL")), Response.OutputStream, CDec(Request.QueryString("PercentReduction")), CInt(Request.QueryString("Quality")))
      Else
         myImageManager.ResizeToJPEG(CStr(Request.QueryString("OriginalImageURL")), Response.OutputStream, CInt(Request.QueryString("Height")), CInt(Request.QueryString("Width")), CInt(Request.QueryString("Quality")))
      End If
   End Sub

End Class