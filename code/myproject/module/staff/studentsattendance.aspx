<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentsattendance.aspx.cs" Inherits="myproject.module.staff.studentsattendance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="rptCustomers" runat="server" OnItemCommand="rptCustomers_ItemCommand">
    <HeaderTemplate>
        <table id="tblCustomers" border="0" cellpadding="0" cellspacing="0">
            <thead>
                <tr>
                    <th><asp:CheckBox ID="chkHeader" runat="server" /></th>
                    <th>student name</th>
                    <th>attendance</th>
                   
                </tr>
            </thead>
    </HeaderTemplate>
    <ItemTemplate>
        <tbody>
            <tr>
                <td><asp:CheckBox ID="chkRow" runat="server" /></td>
                <td><%#Eval("Id")%></td>
                <td><%#Eval("Name")%></td>
              
            </tr>
        </tbody>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>
    
    </div>
    </form>
</body>
</html>
