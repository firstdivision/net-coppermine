<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="DotNetCoppermine._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style>
        .ControlBox{
            border : 1px Solid #cccccc;
            background-color : Ivory;
            pading : 5px;
            margin : 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
		<h1>Coppermine Test Pages</h1>
		<ul>
		    <li><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DrillDown.aspx">Drill Down into Albums</asp:HyperLink></li>
		    <li><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/SchemaHelp.aspx">Schema Dump</asp:HyperLink></li>
		</ul>
		
		<h1>Test Image Resize</h1>
		
		<div class="ControlBox">
            Quality Setting
		Applies to All:<br />
		Quality: <asp:TextBox id="txtQuality" runat="Server" Text="70" Width="96px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1"
                runat="server" ControlToValidate="txtQuality"
                Display="Dynamic" ErrorMessage="Valid values are 0 to 100"
                MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                runat="server" ControlToValidate="txtQuality"
                Display="Dynamic" ErrorMessage="Required"></asp:RequiredFieldValidator></div>
        
        <div class="ControlBox">
		    New Width: <asp:TextBox id="txtWidth" runat="Server" Text="0" Width="96px" ValidationGroup="HeightWidth"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator2"
                runat="server" ControlToValidate="txtWidth"
                Display="Dynamic" ErrorMessage="Valid values are 0 to 1000"
                MaximumValue="1000" MinimumValue="0"
                Type="Integer" ValidationGroup="HeightWidth"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                runat="server" ControlToValidate="txtWidth"
                Display="Dynamic" ErrorMessage="Required"
                ValidationGroup="HeightWidth"></asp:RequiredFieldValidator><br />
            New Height:
            <asp:TextBox ID="txtHeight" runat="server"
                Text="75" Width="96px" ValidationGroup="HeightWidth"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator3"
                runat="server" ControlToValidate="txtHeight"
                Display="Dynamic" ErrorMessage="Valid values are 0 to 1000"
                MaximumValue="1000" MinimumValue="0"
                Type="Integer" ValidationGroup="HeightWidth"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                runat="server" ControlToValidate="txtHeight"
                Display="Dynamic" ErrorMessage="Required"
                ValidationGroup="HeightWidth"></asp:RequiredFieldValidator><br />
		    <asp:LinkButton ID="lnkResize" runat="Server" Text="Resize to new Height/Width" ValidationGroup="HeightWidth"></asp:LinkButton> | 
		    <asp:LinkButton ID="lnkSave" runat="Server" Text="Save" Enabled="False"></asp:LinkButton><br />
            Hint: Leaving one value at zero will force
            all the images to have the same length for
            the greater than zero dimension, while the
            dimension set to zero will be scaled accordingly<br />
		</div>
        
        <div class="ControlBox">
		    Make Longest Side:
            <asp:TextBox ID="txtLongestSide" runat="server" Text="80" Width="32px" ValidationGroup="LongestSide"></asp:TextBox>
            pixels.&nbsp;
            <asp:RangeValidator ID="RangeValidator4"
                runat="server" ControlToValidate="txtLongestSide"
                Display="Dynamic" ErrorMessage="Valid values are 1 to 1000"
                MaximumValue="1000" MinimumValue="1"
                Type="Integer" ValidationGroup="LongestSide"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                runat="server" ControlToValidate="txtLongestSide"
                Display="Dynamic" ErrorMessage="Required"
                ValidationGroup="LongestSide"></asp:RequiredFieldValidator><br />
            <asp:LinkButton ID="lnkResizeLongestSide" runat="server" Text="Resize Based on Longest Side" ValidationGroup="LongestSide"></asp:LinkButton>
		</div>
		
		<div class="ControlBox">
		    New Size by Percentage:
            <asp:TextBox ID="txtPercentage" runat="server" Text=".25" Width="32px" ValidationGroup="Percentage"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator5"
                runat="server" ControlToValidate="txtPercentage"
                Display="Dynamic" ErrorMessage="Valid values are .1 to 4"
                MaximumValue="4" MinimumValue=".1" Type="Double"
                ValidationGroup="Percentage"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                runat="server" ControlToValidate="txtPercentage"
                Display="Dynamic" ErrorMessage="Required"
                ValidationGroup="Percentage"></asp:RequiredFieldValidator><br />
            <asp:LinkButton ID="lnkPercentReduction" runat="server" Text="Percent Reduction" ValidationGroup="Percentage"></asp:LinkButton>
		</div>

        <asp:LinkButton ID="lnkTest" runat="server" Text="TestPerformace" Enabled="False"></asp:LinkButton>
            
        <br /><br />
        
        <div class="ControlBox">
	        <asp:placeholder ID="plhResize" runat="server"></asp:placeholder>
        </div>
    </form>
</body>
</html>
