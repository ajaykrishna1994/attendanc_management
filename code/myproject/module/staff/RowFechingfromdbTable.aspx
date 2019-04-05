<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RowFechingfromdbTable.aspx.cs" Inherits="myproject.module.staff.RowFechingfromdbTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 516px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
      <asp:GridView ID="studentFetch" runat="server" AutoGenerateColumns="False" Width="399px" OnSelectedIndexChanged="studentFetch_SelectedIndexChanged"  >
            <Columns>
                <asp:BoundField DataField="studentname" HeaderText ="name of student" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="email" HeaderText ="student Email" >
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="mobilenumber" HeaderText ="student Mobile" >
             
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
             
                <asp:TemplateField HeaderText="attendance mark">
                    <ItemTemplate>
                       <asp:HiddenField ID="hdnRNo" runat="server" Value='<%# Eval("roll_no") %>' />
                        <asp:CheckBox ID="chkAtt" runat="server" />
                       
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </div>
        <asp:Button ID="updateAttendance" runat="server" OnClick="updateAttendance_Click" Text="update attendance" Width="125px" />
        <asp:Label ID="statuslabel" runat="server" Text="statuslabel"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
