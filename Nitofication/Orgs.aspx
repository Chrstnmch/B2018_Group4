<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orgs.aspx.cs" Inherits="EVoting.Orgs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.5.1/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
    <style>
        html,body,h1,h2,h3,h4,h5 {font-family: "Raleway", sans-serif}
        .Submit:hover {
            background-color: dodgerblue; 
            color: white;
        }
    </style>
    <title></title>
</head>
<body class="w3-light-grey">
    <form id="form1" runat="server">

    <!-- Top container -->
    <div class="w3-bar w3-top w3-red w3-large" style="z-index:4">
      <button class="w3-bar-item w3-button w3-hide-large w3-hover-none w3-hover-text-light-grey" onclick="w3_open();"><i class="fa fa-bars"></i>  Menu</button>
      <span class="w3-bar-item w3-right">Logo</span>
    </div>

    <!-- Sidebar/menu -->
    <nav class="w3-sidebar w3-collapse w3-white w3-animate-left" style="z-index:3;width:300px;" id="mySidebar"><br>
  
        <div class="w3-col s8 w3-bar">
          <center> <span>Welcome back,  <strong>Admin</strong></span><br> </center> <br />
        </div>
      <hr>
      <div class="w3-container">
        <h5>Dashboard</h5>
      </div>
      <div class="w3-bar-block">
        <a href="#" class="w3-bar-item w3-button w3-padding-16 w3-hide-large w3-dark-grey w3-hover-black" onclick="w3_close()" title="close menu"><i class="fa fa-remove fa-fw"></i>  Close Menu</a>
        <a href="Admin_Dashboard.aspx" class="w3-bar-item w3-button w3-padding"><i class="fa fa-users fa-fw"></i>  Overview</a>
        <a href="Department.aspx" class="w3-bar-item w3-button w3-padding w3-blue"><i class="fa fa-users fa-fw"></i>  Departments </a>
        <a href="Course.aspx" class="w3-bar-item w3-button w3-padding"><i class="fa fa-vcard"></i>  Course </a>
        <a href="Orgs.aspx" class="w3-bar-item w3-button w3-padding"><i class="fa fa-users fa-fw"></i>  Organizations </a>
        <a href="Candidates.aspx" class="w3-bar-item w3-button w3-padding"><i class="fa fa-users fa-fw"></i>  Candidates </a>
        <a href="Students.aspx" class="w3-bar-item w3-button w3-padding"><i class="fa fa-user-circle fa-fw"></i>  Users </a>
        <a href="Login.aspx" class="w3-bar-item w3-button w3-padding"><i class="fa fa-cog fa-fw"></i>  Logout </a><br/><br/>
      </div>
    </nav>


    <!-- Overlay effect when opening sidebar on small screens -->
    <div class="w3-overlay w3-hide-large w3-animate-opacity" onclick="w3_close()" style="cursor:pointer" title="close side menu" id="myOverlay"></div>

    <!-- !PAGE CONTENT! -->
    <div class="w3-main" style="margin-left:300px;margin-top:43px;">

      <!-- Header -->
      <header class="w3-container" style="padding-top:22px">
        <h5><b> Organization </b></h5>
      </header>

  
      <div class="w3-overlay w3-hide-large w3-animate-opacity" onclick="w3_close()" style="cursor:pointer" title="close side menu" id="myOverlay"></div>
        <script>
    // Get the Sidebar
    var mySidebar = document.getElementById("mySidebar");

    // Get the DIV with overlay effect
    var overlayBg = document.getElementById("myOverlay");

    // Toggle between showing and hiding the sidebar, and add overlay effect
    function w3_open() {
      if (mySidebar.style.display === 'block') {
        mySidebar.style.display = 'none';
        overlayBg.style.display = "none";
      } else {
        mySidebar.style.display = 'block';
        overlayBg.style.display = "block";
      }
    }

    // Close the sidebar with the close button
    function w3_close() {
      mySidebar.style.display = "none";
      overlayBg.style.display = "none";
    }
    </script>
        <div style="height: 438px; margin-bottom: 0px">
            <asp:Label ID="Label1" runat="server" Text="Department Name" style = "margin-left:1.5%;"></asp:Label>  
            <asp:Label ID="Label2" runat="server" Text="Course" style = "margin-left:26.1%;"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" style = "margin-left:1.5%; background-color: transparent; height: 40px; margin-top: 10px; width: 30%;" >
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" style = "margin-left:6.1%; background-color: transparent; height: 40px; margin-top: 10px; width: 30%;">
            </asp:DropDownList><br /><br />
            <asp:Label ID="Label3" runat="server" Text="Label" style = "margin-left:1.5%;">Organization</asp:Label>
            <br />
            <asp:TextBox ID="Org_Name" runat="server" Style ="width: 30%; border: none; margin-left:1.5%; border-bottom: 1px solid black; outline: none; height: 40px; color: black; 
    background-color: transparent;"></asp:TextBox>
            <br /> <br />
            <asp:Button ID="AddOrg" runat="server" Text="Save" style ="margin-left:1.5%; border-radius: 10px;" CssClass ="Submit" OnClick="AddOrg_Click"/> <br /> <br />
            <center>
                <asp:GridView ID="GridView1" runat="server" Height="30px" Width="1075px"  AutoGenerateColumns ="False" CellPadding="3" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
                    <Columns>
                        <asp:BoundField DataField = "Department_Name" HeaderText = "Department Name" />
                        <asp:BoundField DataField = "Course_Name" HeaderText = "Course" />
                        <asp:BoundField DataField = "Org_Name" HeaderText = "Organization" />
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </Center>
        </div>
        </form>
    </body>
</html>
