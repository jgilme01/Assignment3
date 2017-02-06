<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 3 Community_Assist Connect</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Login</h1>
        <table>
            <tr>
                <td>Email</td>
                <td><asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"><!--hashes the password--></asp:TextBox></td>
           </tr>
            <tr>
                <td><asp:Button ID="LoginButton" runat="server" Text="Button" OnClick="LoginButton_Click" style="height: 26px" /></td>
                <td><asp:Label ID="ResultLabel" runat="server"></asp:Label></td>
           </tr>
        </table>
    </div>
    </form>
</body>
</html>
