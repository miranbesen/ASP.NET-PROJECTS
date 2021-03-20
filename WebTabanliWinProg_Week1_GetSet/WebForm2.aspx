<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebTabanliWinProg_Week1_GetSet.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Hoşgeldiniz"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="40px" OnClick="Button1_Click" Text="Dugme" Width="66px" />
            <asp:TextBox ID="TextBox1" runat="server" Height="18px" style="margin-left: 49px; margin-top: 18px; margin-bottom: 0px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.comu.edu.tr">HyperLink</asp:HyperLink>
&nbsp;
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
