<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Voting.aspx.cs" Inherits="EVoting.Voting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 971px; background-image:url('');">
    <form id="form1" runat="server">
    <div align="center" style="height: 972px; background-color: red; margin-left:300px; margin-right:300px; text-align: left; color:white; font-weight: bold; font-size: large; 
        opacity: .8;"> 
        <div style="margin-left:30px;">
        <asp:Label ID="Label1" runat="server" Text="President" ></asp:Label><br />
        </div>
        <div style="margin-left:70px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="presRadio" runat="server">
            </asp:RadioButtonList>
            <br />
        </div>

        <div style="margin-left:30px;">
            <br />
        <asp:Label ID="Label2" runat="server" Text="Vice President Internal" ></asp:Label><br />
        </div>
        <div style="margin-left:70px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:RadioButtonList ID="vpinternal" runat="server"></asp:RadioButtonList>
        </div>

        <div style="margin-left:30px;">
            <br />
        <asp:Label ID="Label3" runat="server" Text="Vice President External" ></asp:Label><br />
            
        </div>
        <div style="margin-left:70px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:RadioButtonList ID="vpexternal" runat="server"></asp:RadioButtonList>
        </div>

        <div style="margin-left:30px;">
            <br />
        <asp:Label ID="Label4" runat="server" Text="Secretary" ></asp:Label><br />
        </div>
        <div style="margin-left:70px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:RadioButtonList ID="secradio" runat="server"></asp:RadioButtonList>
        </div>

        <div style="margin-left:30px;">
            <br />
        <asp:Label ID="Label5" runat="server" Text="Treasurer" ></asp:Label><br />
        </div>
        <div style="margin-left:70px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:RadioButtonList ID="treasurerradio" runat="server"></asp:RadioButtonList>
        </div>

        <div style="margin-left:30px;">
            <br />
        <asp:Label ID="Label6" runat="server" Text="Auditor" ></asp:Label><br />
        </div>
        <div style="margin-left:70px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:RadioButtonList ID="auditorradio" runat="server"></asp:RadioButtonList>
        </div>

        <div style="margin-left:30px;">
            <br />
        <asp:Label ID="Label7" runat="server" Text="Business Manager" ></asp:Label><br />
        </div>
        <div style="margin-left:70px;">
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<br />
            <asp:CheckBoxList ID="businesscheck" runat="server"></asp:CheckBoxList>
        </div>

        <div style="margin-left:30px;">
            <br />
        <asp:Label ID="Label8" runat="server" Text="P.I.O" ></asp:Label><br />
        </div>
        <div style="margin-left:70px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:CheckBoxList ID="PIOcheck" runat="server"></asp:CheckBoxList>
        </div>
        
        <br />
&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
