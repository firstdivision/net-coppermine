Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class ImageResizer

   '----------------------------------------------------------------------------------------------------'
   ' Code adapted from original article at http://www.glennjones.net/posts/Post.aspx?PostID=799         '
   '----------------------------------------------------------------------------------------------------'

   ''' <summary>
   ''' Resizes a JPEG based on a supplied quality, and a percentage reduction or enlargement.
   ''' </summary>
   ''' <param name="OriginalImagePath">The path to the original JPEG file.</param>
   ''' <param name="OutputStream">The stream that the new image should be resized to (HTTPResponse or FileStream, etc)</param>
   ''' <param name="PercentageToResize">Percentage to resize (.50 for 50 percent)</param>
   ''' <param name="Quality">Optional quality, 0 to 100, for new JPEG. (Default 100%)</param>
   ''' <remarks></remarks>
   Public Overloads Sub ResizeToJPEG(ByVal OriginalImagePath As String, ByRef OutputStream As Stream, ByVal PercentageToResize As Decimal, Optional ByVal Quality As Integer = 100)

      Dim originalimg, thumb As System.Drawing.Image
      Try
         originalimg = Image.FromFile(OriginalImagePath) ' Fetch User Filename

         'do the actual resize
         thumb = MakeThumbnail(originalimg, originalimg.Height * PercentageToResize, originalimg.Width * PercentageToResize)

         Dim codecEncoder As ImageCodecInfo = GetEncoder("image/jpeg")
         Dim encodeParams As New EncoderParameters(1)
         Dim qualityParam As New EncoderParameter(Imaging.Encoder.Quality, Quality)
         encodeParams.Param(0) = qualityParam
         thumb.Save(OutputStream, codecEncoder, encodeParams)

         originalimg.Dispose()
         thumb.Dispose()
      Catch ex As Exception
         Throw New Exception("Error processing JPEG", ex)
      End Try
   End Sub


   ''' <summary>
   ''' Resizes a JPEG based on a supplied quality, height and width.
   ''' </summary>
   ''' <param name="OriginalImagePath">The path to the original JPEG file.</param>
   ''' <param name="OutputStream">The stream that the new image should be resized to (HTTPResponse or FileStream, etc)</param>
   ''' <param name="Height">Desired Height for new JPEG.</param>
   ''' <param name="Width">Desired Height for new JPEG.</param>
   ''' <param name="Quality">Optional quality, 0 to 100, for new JPEG. (Default 100%)</param>
   ''' <remarks>If only one of height and width is greater than zero, the other dimension will be scaled proportionally.</remarks>
   Public Overloads Sub ResizeToJPEG(ByVal OriginalImagePath As String, ByRef OutputStream As Stream, ByVal Height As Integer, ByVal Width As Integer, Optional ByVal Quality As Integer = 100)

      Dim originalimg, thumb As System.Drawing.Image
      Try
         originalimg = Image.FromFile(OriginalImagePath) ' Fetch User Filename

         'do the actual resize
         thumb = MakeThumbnail(originalimg, Height, Width)

         Dim codecEncoder As ImageCodecInfo = GetEncoder("image/jpeg")
         Dim encodeParams As New EncoderParameters(1)
         Dim qualityParam As New EncoderParameter(Imaging.Encoder.Quality, Quality)
         encodeParams.Param(0) = qualityParam
         thumb.Save(OutputStream, codecEncoder, encodeParams)

         originalimg.Dispose()
         thumb.Dispose()
      Catch ex As Exception
         Throw New Exception("Error processing JPEG", ex)
      End Try
   End Sub

   Function GetEncoder(ByVal mimeType As String) As ImageCodecInfo
      Try
         Dim codecs() As ImageCodecInfo = ImageCodecInfo.GetImageEncoders()
         For Each codec As ImageCodecInfo In codecs
            If codec.MimeType = mimeType Then
               Return codec
            End If
         Next
      Catch ex As Exception
         Throw New Exception("Error processing GetEncoder (MimeType)", ex)
      End Try
   End Function


   Function MakeThumbnail(ByVal Source_Img As System.Drawing.Image, ByVal Height As Integer, ByVal Width As Integer) As System.Drawing.Image
      Try
         Dim intOriginalWidth As Integer
         Dim intOriginalHeight As Integer
         Dim sngAspectRatio As Single

         intOriginalWidth = Source_Img.Width
         intOriginalHeight = Source_Img.Height

         Select Case True
            Case Height > 0 And Width > 0
               'do nothing

            Case Height > 0
               sngAspectRatio = intOriginalHeight / Height
               Width = intOriginalWidth / sngAspectRatio

            Case Width > 0
               sngAspectRatio = intOriginalWidth / Width
               Height = intOriginalHeight / sngAspectRatio
         End Select

         Dim thumb As System.Drawing.Image = New Bitmap(width, height)
         Dim objGraphics As System.Drawing.Graphics
         objGraphics = System.Drawing.Graphics.FromImage(thumb)
         objGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic
         objGraphics.SmoothingMode = SmoothingMode.HighQuality
         objGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality
         objGraphics.CompositingQuality = CompositingQuality.HighQuality

         objGraphics.DrawImage(Source_Img, 0, 0, width, height)
         Return thumb
      Catch ex As Exception
         Throw (New Exception("Error in MakeThumbnail", ex))
      End Try

   End Function

End Class