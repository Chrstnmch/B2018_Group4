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
    public partial class Candidates : System.Web.UI.Page
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
            SqlCommand loadcmd = new SqlCommand("SELECT * from Candidate_Table", Connect);
            SqlDataAdapter SDA = new SqlDataAdapter(loadcmd);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            GridView1.DataSource = DT;
            GridView1.DataBind();
            Connect.Close();
        }
        
    }
}