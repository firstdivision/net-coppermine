Public Class frmPreview

   Dim _Quality As Integer
   Dim _PathToOriginal As String

   Public Overloads Sub LoadPreview()
      LoadPreview(_PathToOriginal, _Quality)
   End Sub

   Public Overloads Sub LoadPreview(ByVal PathToOriginal As String, ByVal Quality As Integer)

      _PathToOriginal = PathToOriginal
      _Quality = Quality

      trkQuality.Value = _Quality

      Dim MyImageManager As New libMage.ImageResizer

      Dim MyStream As New System.IO.MemoryStream()
      MyImageManager.ResizeToJPEG(_PathToOriginal, MyStream, picPreview.Height, picPreview.Width, _Quality)

      Me.picPreview.Image = Image.FromStream(MyStream)
   End Sub

   Private Sub frmPreview_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
      If Me.WindowState = FormWindowState.Maximized Then
         LoadPreview()
      End If

   End Sub


   Private Sub frmPreview_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
      LoadPreview()
   End Sub

   Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
      CType(Me.Owner, frmMain).trkQuality.Value = trkQuality.Value
      Me.Close()
   End Sub

   Private Sub trkQuality_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trkQuality.MouseUp
      _Quality = trkQuality.Value
      LoadPreview()
   End Sub

   Private Sub trkQuality_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trkQuality.ValueChanged
      lblQuality.Text = trkQuality.Value
   End Sub
End Class