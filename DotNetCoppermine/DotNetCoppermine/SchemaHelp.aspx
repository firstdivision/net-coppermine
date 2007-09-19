<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SchemaHelp.aspx.vb" Inherits="DotNetCoppermine.SchemaHelp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Users:<br />
        <asp:GridView ID="gvUsers" runat="server"
            CellPadding="4" EnableViewState="False"
            ForeColor="#333333" GridLines="None">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True"
                ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True"
                ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White"
                HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True"
                ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <br />
        Pictures:<br />
        <asp:GridView ID="gvPictures" runat="server"
            CellPadding="4" EnableViewState="False"
            ForeColor="#333333" GridLines="None">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True"
                ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True"
                ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White"
                HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True"
                ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="Thumb">
                    <ItemTemplate>
                        
                        <asp:HyperLink ID="hlnkImage" runat="server"><asp:Image ID="imgThumb" runat="server" /></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        Albums:<br />
        <asp:GridView ID="gvAlbums" runat="server"
            CellPadding="4" EnableViewState="False"
            ForeColor="#333333" GridLines="None">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True"
                ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True"
                ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White"
                HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True"
                ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
