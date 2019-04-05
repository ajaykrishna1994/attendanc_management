<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAttendanceOfstudent.aspx.cs" Inherits="myproject.module.hod.viewAttendanceOfstudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="id_of_Absent_Students" runat="server" Width="546px" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
           
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
           
            <columns>
                 <asp:BoundField DataField="roll_no" HeaderText ="student rolno" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>

                 <asp:BoundField DataField="date_of_absent" HeaderText ="date of absent" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                
                  <asp:BoundField DataField="class" HeaderText ="class" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>




             </columns>

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
    </form>
</body>
</html>
