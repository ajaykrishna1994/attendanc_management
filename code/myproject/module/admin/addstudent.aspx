<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addstudent.aspx.cs" Inherits="myproject.module.admin.addstudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    
        
        
        
        
            <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Text="rollno"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="rollno" runat="server" OnTextChanged="rollno_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="student name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="studentname" runat="server" Height="22px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">stream</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                         <asp:ListItem Enabled="true" Text="Select stream" Value="-1"></asp:ListItem>
                         <asp:ListItem Text="mca s1" Value="1"></asp:ListItem>
                        <asp:ListItem Text="mca s2" Value="2"></asp:ListItem>


                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">email</td>
                <td>
                    <asp:TextBox ID="studentemail" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">mobile number</td>
                <td>
                    <asp:TextBox ID="mobilenumber" runat="server" style="height: 22px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style5">usernamer</td>
                <td class="auto-style3">
                    <asp:TextBox ID="username" runat="server" OnTextChanged="username_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="password" runat="server" OnTextChanged="password_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">user type</td>
                <td>
                    <asp:TextBox ID="section" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
     </div>
        
    
    
    
    
    
    
    </form>
</body>
</html>
