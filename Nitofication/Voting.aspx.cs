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
    public partial class Voting : System.Web.UI.Page
    {
        public static string constr = WebConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        SqlConnection Connect = new SqlConnection(constr);
        public string pres, vpin, vpex, sec, aud, tre, bm, pio;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                presidentList();
                vpinternallist();
                vpexternallist();
                secretarylist();
                auditorlist();
                treasurerlist();
                bmanagerlist();
                piolist();
            }
        }
        public void presidentList()
        {
            pres = "President";
            Connect.Open();
            SqlCommand getPresident = new SqlCommand("SELECT * FROM Candidate_TABLE Where Position = '"+ pres +"'", Connect);
            SqlDataAdapter PSDA = new SqlDataAdapter(getPresident);
            DataTable PDT = new DataTable();
            PSDA.Fill(PDT);
            presRadio.DataSource = PDT;
            presRadio.DataTextField = "Last_Name";
            presRadio.DataValueField = "Last_Name";
            presRadio.DataBind();
            Connect.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        public void vpinternallist()
        {
            vpin = "Vice President Internal";
            Connect.Open();
            SqlCommand getVPInternal = new SqlCommand("SELECT * FROM Candidate_TABLE Where Position = '" + vpin + "'", Connect);
            SqlDataAdapter PSDA = new SqlDataAdapter(getVPInternal);
            DataTable PDT = new DataTable();
            PSDA.Fill(PDT);
            vpinternal.DataSource = PDT;
            vpinternal.DataTextField = "Last_Name";
            vpinternal.DataValueField = "Last_Name";
            vpinternal.DataBind();
            Connect.Close();
        }
        public void vpexternallist()
        {
            vpex = "Vice President External";
            Connect.Open();
            SqlCommand getVPExternal = new SqlCommand("SELECT * FROM Candidate_TABLE Where Position = '" + vpex + "'", Connect);
            SqlDataAdapter PSDA = new SqlDataAdapter(getVPExternal);
            DataTable PDT = new DataTable();
            PSDA.Fill(PDT);
            vpexternal.DataSource = PDT;
            vpexternal.DataTextField = "Last_Name";
            vpexternal.DataValueField = "Last_Name";
            vpexternal.DataBind();
            Connect.Close();
        }
        public void secretarylist()
        {
            sec = "Secretary";
            Connect.Open();
            SqlCommand getSecretary = new SqlCommand("SELECT * FROM Candidate_TABLE Where Position = '" + sec + "'", Connect);
            SqlDataAdapter PSDA = new SqlDataAdapter(getSecretary);
            DataTable PDT = new DataTable();
            PSDA.Fill(PDT);
            secradio.DataSource = PDT;
            secradio.DataTextField = "Last_Name";
            secradio.DataValueField = "Last_Name";
            secradio.DataBind();
            Connect.Close();
        }
        public void auditorlist()
        {
            aud = "Auditor";
            Connect.Open();
            SqlCommand getAuditor = new SqlCommand("SELECT * FROM Candidate_TABLE Where Position = '" + aud + "'", Connect);
            SqlDataAdapter PSDA = new SqlDataAdapter(getAuditor);
            DataTable PDT = new DataTable();
            PSDA.Fill(PDT);
            auditorradio.DataSource = PDT;
            auditorradio.DataTextField = "Last_Name";
            auditorradio.DataValueField = "Last_Name";
            auditorradio.DataBind();
            Connect.Close();
        }
        public void treasurerlist()
        {
            tre = "Treasurer";
            Connect.Open();
            SqlCommand getTreasurer = new SqlCommand("SELECT * FROM Candidate_TABLE Where Position = '" + tre + "'", Connect);
            SqlDataAdapter PSDA = new SqlDataAdapter(getTreasurer);
            DataTable PDT = new DataTable();
            PSDA.Fill(PDT);
            treasurerradio.DataSource = PDT;
            treasurerradio.DataTextField = "Last_Name";
            treasurerradio.DataValueField = "Last_Name";
            treasurerradio.DataBind();
            Connect.Close();
        }
        public void bmanagerlist()
        {
            bm = "Business Manager";
            Connect.Open();
            SqlCommand getBmanager = new SqlCommand("SELECT * FROM Candidate_TABLE Where Position = '" + bm + "'", Connect);
            SqlDataAdapter PSDA = new SqlDataAdapter(getBmanager);
            DataTable PDT = new DataTable();
            PSDA.Fill(PDT);
            businesscheck.DataSource = PDT;
            businesscheck.DataTextField = "Last_Name";
            businesscheck.DataValueField = "Last_Name";
            businesscheck.DataBind();
            Connect.Close();
        }
        public void piolist()
        {
            pio = "P.I.O";
            Connect.Open();
            SqlCommand getPIO = new SqlCommand("SELECT * FROM Candidate_TABLE Where Position = '" + pio + "'", Connect);
            SqlDataAdapter PSDA = new SqlDataAdapter(getPIO);
            DataTable PDT = new DataTable();
            PSDA.Fill(PDT);
            PIOcheck.DataSource = PDT;
            PIOcheck.DataTextField = "Last_Name";
            PIOcheck.DataValueField = "Last_Name";
            PIOcheck.DataBind();
            Connect.Close();
        }
    }
}