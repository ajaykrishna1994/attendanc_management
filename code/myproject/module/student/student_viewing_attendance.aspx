<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_viewing_attendance.aspx.cs" Inherits="myproject.module.student.student_viewing_attendance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="student_can_view_attendance_grid" runat="server" AutoGenerateColumns="False" Height="252px" Width="364px">
            <Columns>
                <asp:BoundField DataField="studentname" HeaderText="roll_no" >
                <ControlStyle BorderColor="#009900" />
                <FooterStyle BorderColor="Red" ForeColor="Red" />
                <HeaderStyle ForeColor="#CC0000" HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle BackColor="White" BorderStyle="Double" Font-Bold="False" Font-Size="Medium" ForeColor="#666666" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="date_of_absent" HeaderText="date of absent" >
                <HeaderStyle Font-Bold="False" ForeColor="Red" HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle BackColor="White" BorderStyle="Double" Font-Bold="True" ForeColor="#666666" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
