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
    </form>
</body>
</html>
