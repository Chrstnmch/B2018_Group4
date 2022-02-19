<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EVoting.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> TCU E-Voting System | Login </title>
    <link href = "Style.css" rel = "stylesheet" />
</head>
<body>
    <div class = "Login">
        <img src="Stock/user.png" alt="User Profile"/>
        <h2> Login Here </h2> <br />
        <form runat ="server">
            <asp:TextBox runat ="server" CssClass ="Email" placeholder ="Enter Username" ID ="UN"></asp:TextBox>
            <asp:TextBox runat ="server" CssClass = "Password" placeholder ="Enter Password" ID="PW" TextMode="Password"></asp:TextBox>
            <asp:Button Text ="Login" CssClass ="Submit" runat ="server" OnClick="Login_Click" />
        </form>
    </div>
</body>
</html>
