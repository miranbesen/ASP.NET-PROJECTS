<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebTabanliWinProg_Week2_DolarConvertTL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Amout in US Dollars:
            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="168px"></asp:TextBox>
     <asp:Button ID="Button1" runat="server" Height="31px" OnClick="Button1_Click" style="margin-left: 27px; margin-top: 2px; margin-bottom: 0px" Text="Convert to TL" OnClientClick="return confirm(&quot;Are you sure you really want to convert value to Turkish Liras?&quot;) " />
        </div>
        <p>
&nbsp;<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
