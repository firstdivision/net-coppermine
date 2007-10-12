Public Partial Class DynamicImage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Dim myImageManager As New libDotNetCoppermine.ImageResizer

      Response.Clear()
      Response.ContentType = "image/jpeg"
      myImageManager.ResizeToJPEG(Request.QueryString("OriginalImageURL"), Response.OutputStream, Request.QueryString("Quality"), Request.QueryString("Height"), Request.QueryString("Width"))
    End Sub

End Class