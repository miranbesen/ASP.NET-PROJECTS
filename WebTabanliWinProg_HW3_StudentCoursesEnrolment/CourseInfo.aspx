<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseInfo.aspx.cs" Inherits="WebTabanliWinProg_StudentCoursesEnrolment.CourseInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Algerian" Font-Overline="False" Font-Size="20pt" Font-Strikeout="False" Text="Course Info"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CourseID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" Height="50px" OnPageIndexChanging="DetailsView1_PageIndexChanging" Width="125px">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <Fields>
                    <asp:BoundField DataField="CourseID" HeaderText="CourseID" InsertVisible="False" ReadOnly="True" SortExpression="CourseID" />
                    <asp:BoundField DataField="CourseCode" HeaderText="CourseCode" SortExpression="CourseCode" />
                    <asp:BoundField DataField="CourseName" HeaderText="CourseName" SortExpression="CourseName" />
                    <asp:BoundField DataField="Instructor" HeaderText="Instructor" SortExpression="Instructor" />
                    <asp:CommandField ShowEditButton="True" />
                </Fields>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
            </asp:DetailsView>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Courses] WHERE ([CourseID] = @İd)" UpdateCommand="UPDATE [Courses] SET [CourseCode] = @CourseCode, [CourseName] = @CourseName, [Instructor]=@Instructor  WHERE [CourseID] = @CourseID">
                <SelectParameters>
                    <asp:QueryStringParameter Name="İd" QueryStringField="İd" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="CourseCode" />
                    <asp:Parameter Name="CourseName" />
                    <asp:Parameter Name="Instructor" />
                    <asp:Parameter Name="CourseID" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="20pt" Text="Registered Students"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="StudentID" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="StudentID" HeaderText="StudentID" InsertVisible="False" ReadOnly="True" SortExpression="StudentID" />
                    <asp:HyperLinkField DataNavigateUrlFields="StudentID" DataNavigateUrlFormatString="StudentInfo.aspx?İd={0}" DataTextField="StudentName" HeaderText="Student Name" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Students.StudentID,Students.StudentName FROM Enrolment, Students WHERE Students.StudentID=Enrolment.StudentID AND  Enrolment.CourseID = @CourseID">
                <SelectParameters>
                    <asp:QueryStringParameter Name="CourseID" QueryStringField="İd" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Overline="False" Font-Size="15pt" Text="Register a New Student"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="StudentName" DataValueField="StudentID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>&lt;Select student&gt;</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#CC3300"></asp:Label>
            <br />
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Students] ORDER BY [StudentName]"></asp:SqlDataSource>
            <br />
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Enrolment] WHERE [StudentID] = @StudentID AND [CourseID] = @CourseID" InsertCommand="INSERT INTO [Enrolment] ([StudentID], [CourseID]) VALUES (@StudentID, @CourseID)" SelectCommand="SELECT * FROM [Enrolment]">
                <DeleteParameters>
                    <asp:Parameter Name="StudentID" Type="Int32" />
                    <asp:Parameter Name="CourseID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="StudentID" PropertyName="SelectedValue" Type="Int32" />
                    <asp:QueryStringParameter Name="CourseID" QueryStringField="İd" Type="Int32" />
                </InsertParameters>
            </asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>
