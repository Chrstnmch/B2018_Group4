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
    public partial class Department : System.Web.UI.Page
    {
        public static string constr = WebConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        SqlConnection Connect = new SqlConnection(constr);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
         }

       
        
        void LoadData()
        {
           Connect.Open();
           SqlCommand loadcmd = new SqlCommand("SELECT * from Department_Table", Connect);
           SqlDataAdapter SDA = new SqlDataAdapter(loadcmd);
           DataTable DT = new DataTable();
           SDA.Fill(DT);
           GridView1.DataSource = DT;
           GridView1.DataBind();
           Connect.Close();
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();
                SqlCommand AddCmd = new SqlCommand("INSERT INTO Department_Table (Department_Name,Department_Description) values ('" + ADeptName.Text + "', '" + ADeptDesc.Text + "')", Connect);
                AddCmd.ExecuteNonQuery();
                ADeptName.Text = "";
                ADeptDesc.Text = "";
                Connect.Close();
                LoadData();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }   
        }
        
    }
}