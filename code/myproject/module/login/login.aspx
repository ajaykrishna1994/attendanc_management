<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="myproject.module.login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login</title>
    <link href="../../css/log.css" rel="stylesheet" />  
        
</head>
<body>
    <div class=".WebContainer">
    <form id="form1" runat="server">
    <section>
        <img src="../../images/hd_loginkeyboard.jpg" class="panel" />
        


    </section>
        <div class="sec2">
            
            <div class="container">
                <div class="social">

                    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/fbround.png" />
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/images/twitter-logor.png" />
                    
                   
                        <div class="content">

                            <h2>Log in</h2>
                           
                            
                          
                              <asp:TextBox ID="section" placeholder="user type"  runat="server"></asp:TextBox>
                           
                            <asp:TextBox ID="password"  placeholder="password" runat="server"></asp:TextBox>
                            
                            <br />
                            
                            <br />
                            <asp:Button ID="submit" runat="server" Text="submit" OnClick="submit_Click"/>
                            
                        </div>

                 </div>
            </div>


        </div>

    </form>
        </div>
</body>
</html>
