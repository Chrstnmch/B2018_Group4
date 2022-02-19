using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace EVoting
{
    public partial class Candidacy_Form : System.Web.UI.Page
    {
        public static string constr = WebConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        SqlConnection Connect = new SqlConnection(constr);
        public int getID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();
                SqlCommand newID = new SqlCommand("SELECT Max(Candidate_ID) FROM Candidate_Table", Connect);
                SqlDataReader SDR = newID.ExecuteReader();
                string transferID = "";
                while (SDR.Read())
                {
                    transferID = SDR.GetValue(0).ToString();
                }
                getID = int.Parse(transferID);
                Connect.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();
                int maxID = getID + 1;
                SqlCommand AddCmd = new SqlCommand("INSERT INTO Candidate_Table (Candidate_ID, First_Name, Last_Name, Email_Address, Gender, Course, Partylist, Position) values ('"+ maxID +"','" + Firstname.Text + "', '" + Lastname.Text + "', '" + Email.Text + "', '" + Gender.Text + "', '" + Department.Text + "', '" + PartyList.Text + "', '" + Position.Text + "')", Connect);
                AddCmd.ExecuteNonQuery();
                Firstname.Text = "";
                Lastname.Text = "";
                Email.Text = "";
                Gender.Text = "";
                Department.Text = "";
                PartyList.Text = "";
                Position.Text = "";
                Connect.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        
    }
}