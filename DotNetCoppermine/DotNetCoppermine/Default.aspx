<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="DotNetCoppermine._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
		<h1>Coppermine Test Pages</h1>
		<ul>
		    <li><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DrillDown.aspx">Drill Down into Albums</asp:HyperLink></li>
		    <li><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/SchemaHelp.aspx">Schema Dump</asp:HyperLink></li>
		</ul>
		
		<h1>Test Image Resize</h1>
		New Width: <asp:TextBox id="txtWidth" runat="Server" Text="200"></asp:TextBox><br />
        New Height:
        <asp:TextBox ID="txtHeight" runat="server"
            Text="200"></asp:TextBox><br />
		New Quality: <asp:TextBox id="txtQuality" runat="Server" Text="100"></asp:TextBox><br />
		<asp:LinkButton ID="lnkResize" runat="Server" Text="Resize"></asp:LinkButton> | 
		<asp:LinkButton ID="lnkSave" runat="Server" Text="Save"></asp:LinkButton>
        <br />
        <br />
	    <asp:placeholder ID="plhResize" runat="server"></asp:placeholder>
    </form>
</body>
</html>
