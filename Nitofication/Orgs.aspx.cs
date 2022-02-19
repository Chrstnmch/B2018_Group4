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
    public partial class Orgs : System.Web.UI.Page
    {
        public static string conn = WebConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        SqlConnection Connect = new SqlConnection(conn);
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

            Connect.Open();
            SqlCommand CourseQ = new SqlCommand("SELECT Course_Name from Course_Table WHERE Department_Name = '" + DropDownList1.Text + "'", Connect);
            SqlDataAdapter Course_SDA = new SqlDataAdapter(CourseQ);
            DataTable Course_DT = new DataTable();
            Course_SDA.Fill(Course_DT);
            DropDownList2.DataSource = Course_DT;
            DropDownList2.DataValueField = "Course_Name";
            DropDownList2.DataTextField = "Course_Name";
            DropDownList2.DataBind();
            Connect.Close();

            if (!IsPostBack)
            {
                LoadData();
            }
        }
        
        void LoadData()
        {
            Connect.Open();
            SqlCommand loadcmd = new SqlCommand("SELECT * from Org_Table", Connect);
            SqlDataAdapter SDA = new SqlDataAdapter(loadcmd);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            GridView1.DataSource = DT;
            GridView1.DataBind();
            Connect.Close();
        }

        protected void AddOrg_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();
                SqlCommand AddCmd = new SqlCommand("INSERT INTO Org_Table values ('" + DropDownList1.Text + "', '" + DropDownList2.Text + "', '"+ Org_Name.Text +"')", Connect);
                AddCmd.ExecuteNonQuery();
                Org_Name.Text = "";
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