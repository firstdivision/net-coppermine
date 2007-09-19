Imports MySql.Data.MySqlClient
Partial Public Class DrillDown
   Inherits System.Web.UI.Page
   Dim myCommand As New MySqlCommand("", New MySqlConnection(ConfigurationManager.ConnectionStrings("CoppermineConnection").ConnectionString))


   Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

      If Not IsPostBack Then
         'bind the user list
         myCommand.CommandText = "SELECT * FROM " & ConfigurationManager.AppSettings("CoppermineTablePrefix") & "users;"
         myCommand.Connection.Open()
         dlstUsers.DataSource = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
         dlstUsers.DataBind()
         myCommand.Connection.Close()

         mvDrillDown.SetActiveView(Me.vUsers)
      End If

   End Sub

   Private Sub dlstUsers_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs) Handles dlstUsers.ItemCreated
      Dim lnkShowAlbums As LinkButton = e.Item.FindControl("lnkShowAlbums")
      AddHandler lnkShowAlbums.Click, AddressOf lnkShowAlbums_Click

      Dim lnkShowComments As LinkButton = e.Item.FindControl("lnkShowComments")
      AddHandler lnkShowComments.Click, AddressOf lnkShowComments_Click
   End Sub

   Private Sub dlstUsers_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs) Handles dlstUsers.ItemDataBound
      Dim lnkShowAlbums As LinkButton = e.Item.FindControl("lnkShowAlbums")
      Dim lnkShowComments As LinkButton = e.Item.FindControl("lnkShowComments")
      Dim lblUserName As Label = e.Item.FindControl("lblUserName")

      lnkShowComments.CommandArgument = e.Item.DataItem("User_Name")
      lblUserName.Text = " (uid = " & e.Item.DataItem("user_id") & ") " & e.Item.DataItem("User_Name")
      lnkShowAlbums.CommandArgument = e.Item.DataItem("user_id")
   End Sub

   Private Sub dlstAlbums_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs) Handles dlstAlbums.ItemCreated
      Dim lnkUser As LinkButton = e.Item.FindControl("lnkAlbum")
      AddHandler lnkUser.Click, AddressOf lnkAlbum_Click
   End Sub


   Private Sub dlstAlbums_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs) Handles dlstAlbums.ItemDataBound
      Dim lnkAlbum As LinkButton = e.Item.FindControl("lnkAlbum")

      lnkAlbum.Text = e.Item.DataItem("title")
      lnkAlbum.CommandArgument = e.Item.DataItem("aid")
   End Sub



   Private Sub lnkShowAlbums_Click(ByVal sender As Object, ByVal a As EventArgs)
      'user click a 'user link' so:

      'TODO show the albums datalist for the user
      myCommand.CommandText = "SELECT * FROM " & ConfigurationManager.AppSettings("CoppermineTablePrefix") & "albums WHERE RIGHT(category,4) = ?User_ID"
      myCommand.Connection.Open()
      myCommand.Parameters.Add("?User_ID", MySqlDbType.Int32).Value = CType(sender, LinkButton).CommandArgument
      dlstAlbums.DataSource = myCommand.ExecuteReader
      dlstAlbums.DataBind()
      myCommand.Connection.Close()

      lblResults.Text = String.Format("Found {0} Albums:", dlstAlbums.Items.Count)

      'TODO: show the album view
      mvDrillDown.SetActiveView(vAlbums)
   End Sub

   Private Sub lnkShowComments_Click(ByVal sender As Object, ByVal a As EventArgs)
      'user click a 'user link' so:

      'TODO show the albums datalist for the user
      myCommand.CommandText = "SELECT * FROM " & ConfigurationManager.AppSettings("CoppermineTablePrefix") & "comments WHERE msg_author = '" & CType(sender, LinkButton).CommandArgument & "';"
      myCommand.Connection.Open()
      gvComments.DataSource = myCommand.ExecuteReader
      gvComments.DataBind()
      myCommand.Connection.Close()

      lblCommentCount.Text = String.Format("Found {0} Comments:", gvComments.Rows.Count)

      'TODO: show the album view
      mvDrillDown.SetActiveView(vComments)
   End Sub



   Private Sub lnkAlbum_Click(ByVal sender As Object, ByVal a As EventArgs)
      'user click a 'user link' so:

      'TODO show the albums datalist for the user
      myCommand.CommandText = "SELECT * FROM " & ConfigurationManager.AppSettings("CoppermineTablePrefix") & "pictures WHERE aid = " & CType(sender, LinkButton).CommandArgument
      myCommand.Connection.Open()
      gvPictures.DataSource = myCommand.ExecuteReader
      gvPictures.DataBind()
      myCommand.Connection.Close()

      'TODO: show the album view
      mvDrillDown.SetActiveView(vPictures)
   End Sub


   Protected Sub lnkUserList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles lnkUserList.Click, lnkUserList2.Click, lnkUserList3.Click
      mvDrillDown.SetActiveView(vUsers)
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