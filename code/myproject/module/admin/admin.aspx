<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="myproject.module.admin.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>admin</title>
    <link href="../../css/admnin.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 281px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 36px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div class="firstframe" id="first">
      


        <table class="auto-style1">
            <tr>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
         <asp:Button ID="submit" runat="server" Text="add teacher" OnClick="submit_Click1" Width="137px" />
                   
                    
    

                </td>
            </tr>
            <tr>
                <td>
      


        <asp:Button ID="Button1" runat="server" Height="39px" Text="add studnt" Width="137px" OnClick="Button1_Click" />

                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
     <div class="secondframe"> 

          <object type="text/html" data="http://validator.w3.org/">
         </object>
     </div>

    </form>
</body>
</html>
