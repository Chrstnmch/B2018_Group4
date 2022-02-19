using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EVoting
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            SqlConnection Connect = new SqlConnection(constr);
            try {
                 
                Connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from User_Table where Username = '" + UN.Text + "' AND Password = '" + PW.Text + "'", Connect);
                SqlDataReader SDR = cmd.ExecuteReader();
                int LoginCount = 0;
                string getUserType = "";
                while (SDR.Read()){
                    LoginCount += 1;
                    getUserType = SDR.GetValue(3).ToString();
                }
                if(LoginCount > 0) {
                    if(getUserType == "Admin"){
                        Response.Redirect("Admin_Dashboard.aspx");
                    } else if(getUserType == "Student"){
                        Response.Redirect("Student_Dashboard.aspx");
                    }
                } else {
                    Response.Write("<script> alert('Error Login!')</script>");
                }
            } catch(Exception ex){
                Response.Write(ex.Message);
            }
        }
    }
}