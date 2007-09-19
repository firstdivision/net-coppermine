Imports MySql.Data.MySqlClient
Partial Public Class SchemaHelp
   Inherits System.Web.UI.Page

   Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Dim MyConnection As New MySqlConnection(ConfigurationManager.ConnectionStrings("CoppermineConnection").ConnectionString)
      Dim myCommand As New MySqlCommand("", MyConnection)

      myCommand.CommandText = "SELECT user_id, user_group, user_active, user_name, user_group_list, user_email, " & _
         "user_profile3, user_profile1, user_profile2, user_actkey FROM " & ConfigurationManager.AppSettings("CoppermineTablePrefix") & "users;"
      myCommand.Connection.Open()
      gvUsers.DataSource = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
      gvUsers.DataBind()
      MyConnection.Close()
      'myCommand.Connection.Close()

      myCommand.CommandText = "SELECT * FROM " & ConfigurationManager.AppSettings("CoppermineTablePrefix") & "pictures LIMIT 25;"
      myCommand.Connection.Open()
      gvPictures.DataSource = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
      gvPictures.DataBind()
      MyConnection.Close()
      'myCommand.Connection.Close()

      myCommand.CommandText = "SELECT * FROM " & ConfigurationManager.AppSettings("CoppermineTablePrefix") & "albums ORDER BY aid;"
      myCommand.Connection.Open()
      gvAlbums.DataSource = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
      gvAlbums.DataBind()
      MyConnection.Close()
      'myCommand.Connection.Close()

   End Sub

   Private Sub gvPictures_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvPictures.RowDataBound
      If e.Row.RowType = DataControlRowType.DataRow Then
         Dim imgThumb As Image = e.Row.FindControl("imgThumb")
         Dim hlnkImage As HyperLink = e.Row.FindControl("hlnkImage")

         imgThumb.ImageUrl = ConfigurationManager.AppSettings("CoppermineBaseURL") & "albums/" & e.Row.DataItem("FilePath") & "thumb_" & e.Row.DataItem("filename")
         hlnkImage.NavigateUrl = ConfigurationManager.AppSettings("CoppermineBaseURL") & "albums/" & e.Row.DataItem("FilePath") & e.Row.DataItem("filename")
      End If

   End Sub
End Class