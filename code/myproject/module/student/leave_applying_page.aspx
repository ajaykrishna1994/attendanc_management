<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leave_applying_page.aspx.cs" Inherits="myproject.module.student.leave_applying_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 277px;
        }
        .auto-style3 {
            width: 277px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 277px;
            height: 28px;
        }
        .auto-style6 {
            height: 28px;
        }
    </style>

   
    <link href="../../css/pikaday.css" rel="stylesheet" />
   



</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="student name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="leave_student_name" runat="server" Width="186px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="student class"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="leave_student_class" runat="server" Width="185px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="type of leave"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>sick</asp:ListItem>
                        <asp:ListItem>other</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="leave start date"></asp:Label>
                </td>
                <td class="auto-style6">
                    <div class="pika-single">

                    <script type="text/javascript">
              var picker = new Pikaday(
                        {
        field: document.getElementById('TextBox1'),
        firstDay: 1,
        minDate: new Date('2000-01-01'),
        maxDate: new Date('2020-12-31'),
        yearRange: [2000, 2020],
        numberOfMonths: 3,
        theme: 'dark-theme'
    });
                        </script>
                        <asp:TextBox ID="leave_start_date" runat="server" TextMode="Date"></asp:TextBox>
                        </div>

                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="leave end date"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="leave_end_date" runat="server" OnTextChanged="leave_end_date_TextChanged" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="detail"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="submit" runat="server" OnClick="Button1_Click" Text="submit" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
