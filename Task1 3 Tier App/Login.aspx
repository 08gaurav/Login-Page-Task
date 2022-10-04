<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Task1_3_Tier_App.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
        <legend>Task 1 3-Tier Login</legend>
            <table style="width: 20%;">
                <tr>
                    <td>User Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Login" /></td>
                    
                </tr>
            </table>
                </fieldset>
        </div>
    </form>
</body>
</html>
