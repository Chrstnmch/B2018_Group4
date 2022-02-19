using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace EVoting
{
    public partial class Course : System.Web.UI.Page
    {
        public static string constr = WebConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        SqlConnection Connect = new SqlConnection(constr);
        protected void Page_Load(object sender, EventArgs e)
        {
            Connect.Open();
            SqlCommand DeptQuery = new SqlCommand("SELECT Department_Name from Department_Table", Connect);
            SqlDataAdapter SDA = new SqlDataAdapter(DeptQuery);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            DropDownList1.DataSource = DT;
            DropDownList1.DataValueField = "Department_Name";
            DropDownList1.DataTextField = "Department_Name";
            DropDownList1.DataBind();
            Connect.Close();
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        void LoadData()
        {
            Connect.Open();
            SqlCommand loadcmd = new SqlCommand("SELECT * from Course_Table", Connect);
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
                SqlCommand AddCmd = new SqlCommand("INSERT INTO Course_Table values ('" + DropDownList1.Text + "', '" + Course_Name.Text + "')", Connect);
                AddCmd.ExecuteNonQuery();
                Course_Name.Text = "";
                Connect.Close();
                LoadData();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}