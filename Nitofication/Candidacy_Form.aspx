<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Candidacy_Form.aspx.cs" Inherits="EVoting.Candidacy_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 28px;
        }
        .auto-style2 {
            height: 50px;
        }
    </style>
</head>
<body style="background-image: url('tcu.jpg'); background-repeat:no-repeat; background-attachment:fixed; background-size:cover;">
    <form id="form1" runat="server">
<h3 style ="font-family: Calibri; font-size: 25pt; font-style: normal; font-weight: bold; color: #332e56; text-align: center; text-decoration: underline;">Registration Candidacy</h3>

 
<table align="center" cellpadding = "10" style ="font-family: Calibri; color: white; font-size: normal; font-weight: bold; text-align:; background-color: #d00e20;
    border-collapse: collapse; border: 4px solid #808080; table-layout: auto; width: 680px; ">
 
<!----- First Name ---------------------------------------------------------->
<tr>
<td>FIRST NAME</td>
<td>
    <asp:TextBox ID="Firstname" runat="server"></asp:TextBox>
&nbsp;(max 30 characters a-z and A-Z)
</td>
</tr>
 
<!----- Last Name ---------------------------------------------------------->
<tr>
<td class="auto-style2">LAST NAME</td>
<td class="auto-style2">
    <asp:TextBox ID="Lastname" runat="server"></asp:TextBox>
&nbsp;(max 30 characters a-z and A-Z)
</td>
</tr>
 
<!----- Email Id ---------------------------------------------------------->
<tr>
<td>EMAIL ID</td>
<td>
    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
    </td>
</tr>
 
<!----- Gender ----------------------------------------------------------->
<tr>
<td>GENDER</td>
<td>
    <asp:RadioButtonList ID="Gender" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
&nbsp;</td>
</tr>
 
<!----- Address ---------------------------------------------------------->
<tr>
<td>Department</td>
<td>
    <asp:DropDownList ID="Department" runat="server">
        <asp:ListItem>--Department--</asp:ListItem>
        <asp:ListItem>CICT</asp:ListItem>
        <asp:ListItem>CHTM</asp:ListItem>
        <asp:ListItem>CCJ</asp:ListItem>
        <asp:ListItem>CBM</asp:ListItem>
        <asp:ListItem>CET</asp:ListItem>
        <asp:ListItem>CAS</asp:ListItem>
    </asp:DropDownList>
&nbsp;</td>
</tr>

<!----- partylist ---------------------------------->
<tr>
    <td>Party List</td>
    <td>
        <asp:TextBox ID="PartyList" runat="server"></asp:TextBox>
&nbsp;(If there is no Party-List, put Independent)
    </td>
</tr>
 
<!----- Qualification---------------------------------------------------------->
<tr>
<td>POSITION OF CANDIDACY <br /><br /><br /><br /><br /><br /><br /></td>
 
<td>

 
    <asp:RadioButtonList ID="Position" runat="server">
        <asp:ListItem>President</asp:ListItem>
        <asp:ListItem>Vice President Internal</asp:ListItem>
        <asp:ListItem>Vice President External</asp:ListItem>
        <asp:ListItem>Secretary</asp:ListItem>
        <asp:ListItem>Auditor</asp:ListItem>
        <asp:ListItem>Treasurer</asp:ListItem>
        <asp:ListItem>P.I.O</asp:ListItem>
        <asp:ListItem>Business Manager</asp:ListItem>
    </asp:RadioButtonList>
 
</td>
</tr>

 
<!----- Submit and Reset ------------------------------------------------->
<tr>
<td colspan="2" align="center">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;<input type="reset" value="Reset">
</td>
</tr>
</table>
    <br />
    <br />
 
 <footer style ="text-align:center; padding: 3px; background-color:dimgrey; Color:white;">
     <p style =" margin-top:15px;">Taguig City University</p>
 </footer>
    </form>
</body>
</html>
