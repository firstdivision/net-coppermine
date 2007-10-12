Public Partial Class DynamicImage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Dim myImageManager As New libMage.ImageResizer

      Response.Clear()
      Response.ContentType = "image/jpeg"

      Select Case True
         Case Request.QueryString("LongestLength") <> ""
            myImageManager.ResizeToJPEG(CInt(Request.QueryString("LongestLength")), CStr(Request.QueryString("OriginalImageURL")), Response.OutputStream, CInt(Request.QueryString("Quality")))

         Case Request.QueryString("PercentReduction") <> ""
            myImageManager.ResizeToJPEG(CStr(Request.QueryString("OriginalImageURL")), Response.OutputStream, CDec(Request.QueryString("PercentReduction")), CInt(Request.QueryString("Quality")))

         Case Else
            myImageManager.ResizeToJPEG(CStr(Request.QueryString("OriginalImageURL")), Response.OutputStream, CInt(Request.QueryString("Height")), CInt(Request.QueryString("Width")), CInt(Request.QueryString("Quality")))
      End Select
   End Sub

End Class