<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebTabanliWinProg_Alistirma2.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server">
                <br />
                <br />
                <br />
                <asp:Table ID="Table1" runat="server">
                </asp:Table>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Default.aspx">Return To Main Page</asp:HyperLink>
                <br />
                <br />
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server">
                <br />
                &nbsp;&nbsp;&nbsp; Your shopping Cart is Empty!!!<br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Return To Main Page</asp:HyperLink>
                <br />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
