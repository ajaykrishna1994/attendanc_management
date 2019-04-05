<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mark_attendance_of_staff.aspx.cs" Inherits="myproject.module.hod.mark_attendance_of_staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:GridView ID="fetch_Staff_Attendance" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="213px" Width="524px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="staffname" HeaderText="name of staff" />
                <asp:BoundField DataField="staffemailaddress" HeaderText="staff email address" />
                <asp:BoundField DataField="staffmobilenumber" HeaderText="staff mobile number" />
                <asp:TemplateField HeaderText="attendance status">
                    <ItemTemplate>
                        <asp:CheckBox ID="staff_attendance_checkbox" runat="server" />
                        <asp:HiddenField ID="hidden_num" runat="server" Value='<%# Eval("staffid") %>' />
                        
                    </ItemTemplate>
                </asp:TemplateField>
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
    
    </div>
        <asp:Button ID="submit" runat="server" Text="submit" OnClick="submit_Click" />
    </form>
</body>
</html>
