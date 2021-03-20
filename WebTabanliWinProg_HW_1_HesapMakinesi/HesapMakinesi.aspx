<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HesapMakinesi.aspx.cs" Inherits="WebTabanliWinProg_HW_1_HesapMakinesi.HesapMakinesi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 417px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Height="39px" OnTextChanged="TextBox1_TextChanged" style="margin-left: 51px; margin-bottom: 8px" Width="255px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" style="margin-left: 52px" Text="7" Width="40px" />
&nbsp;<asp:Button ID="Button2" runat="server" Height="32px" OnClick="Button2_Click" style="margin-left: 25px; margin-right: 0px" Text="8" Width="40px" />
&nbsp;<asp:Button ID="Button3" runat="server" Height="31px" OnClick="Button3_Click" style="margin-left: 25px; margin-right: 0px" Text="9" Width="40px" />
&nbsp;&nbsp; <asp:Button ID="Button4" runat="server" Height="33px" OnClick="Button4_Click" style="margin-left: 25px; margin-right: 0px" Text="/" Width="40px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" Height="38px" OnClick="Button5_Click" style="margin-left: 52px" Text="4" Width="40px" />
&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" Height="34px" OnClick="Button6_Click" style="margin-left: 17px" Text="5" Width="37px" />
&nbsp;<asp:Button ID="Button7" runat="server" Height="30px" OnClick="Button7_Click" style="margin-left: 30px; margin-top: 0px;" Text="6" Width="37px" />
&nbsp;<asp:Button ID="Button8" runat="server" Height="33px" OnClick="Button8_Click" style="margin-left: 35px" Text="*" Width="40px" />
        </p>
        <p style="margin-left: 40px">
            <asp:Button ID="Button9" runat="server" Height="35px" OnClick="Button9_Click" style="margin-left: 13px" Text="1" Width="40px" />
            <asp:Button ID="Button10" runat="server" Height="31px" OnClick="Button10_Click" style="margin-left: 31px" Text="2" Width="40px" />
            <asp:Button ID="Button11" runat="server" Height="33px" OnClick="Button11_Click" style="margin-left: 28px" Text="3" Width="40px" />
            <asp:Button ID="Button12" runat="server" Height="33px" OnClick="Button12_Click" style="margin-left: 41px" Text="-" Width="40px" />
        </p>
        <p style="margin-left: 40px">
            <asp:Button ID="Button13" runat="server" Height="34px" OnClick="Button13_Click" style="margin-left: 13px" Text="0" Width="36px" />
            <asp:Button ID="Button14" runat="server" Height="34px" OnClick="Button14_Click" style="margin-left: 32px" Text="+" Width="40px" />
            <asp:Button ID="Button15" runat="server" Height="33px" OnClick="Button15_Click" style="margin-left: 34px" Text="CLC" Width="40px" />
            <asp:Button ID="Button16" runat="server" Height="33px" OnClick="Button16_Click" style="margin-left: 39px" Text="=" Width="39px" />
        </p>
    </form>
</body>
</html>
