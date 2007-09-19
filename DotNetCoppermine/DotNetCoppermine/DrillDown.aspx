<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DrillDown.aspx.vb" Inherits="DotNetCoppermine.DrillDown" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:MultiView ID="mvDrillDown" runat="server">
            <asp:View ID="vUsers" runat="server">
                <asp:DataList ID="dlstUsers" runat="server">
                    <ItemTemplate>
                        <asp:label ID="lblUserName" runat="server" Text="UserName"></asp:label><br />
                        &nbsp;-&nbsp;<asp:LinkButton ID="lnkShowAlbums" runat="server">Albums</asp:LinkButton><br />
                        &nbsp;-&nbsp;<asp:LinkButton ID="lnkShowComments" runat="server">Comments</asp:LinkButton>
                    </ItemTemplate>
                </asp:DataList></asp:View>
            <asp:View ID="vAlbums" runat="server">
                <asp:LinkButton ID="lnkUserList" runat="server">User List</asp:LinkButton><br />
                <br />
                <asp:Label ID="lblResults" runat="server"
                    Text="Your search did not return any albums..."></asp:Label><br />
                <br />
                <asp:DataList ID="dlstAlbums" runat="server">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkAlbum" runat="server">AlbumName</asp:LinkButton>
                    </ItemTemplate>
                </asp:DataList></asp:View>
            <asp:View ID="vPictures" runat="server">
                <asp:LinkButton ID="lnkUserList2" runat="server">User List</asp:LinkButton>
                -
                <asp:HyperLink ID="hlnkBackToAlbums" runat="server"
                    NavigateUrl="javascript:history.go(-1);">Back to Album List</asp:HyperLink><br />
                <asp:GridView ID="gvPictures" runat="server">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HyperLink ID="hlnkImage" runat="server"><asp:Image ID="imgThumb" runat="server" /></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </asp:View>
            <asp:View ID="vComments" runat="server">
                <asp:LinkButton ID="lnkUserList3" runat="server">User List</asp:LinkButton><br />
                <br />
                <asp:Label ID="lblCommentCount" runat="server" Text="Found blah Comments:"></asp:Label><br />
                <br />
                <asp:GridView ID="gvComments" runat="server">
                </asp:GridView>
            </asp:View>
        </asp:MultiView></div>
    </form>
</body>
</html>
