<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_the_attendance_of_staff.aspx.cs" Inherits="myproject.module.hod.view_the_attendance_of_staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="staff_attendance" runat="server" AutoGenerateColumns="False" Height="218px" Width="329px">
            <Columns>
                <asp:BoundField DataField="staffname" HeaderText="name of staff">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="staffemailaddress" HeaderText="e_mail of staff">
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="staffmobilenumber" HeaderText="mobile number">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
