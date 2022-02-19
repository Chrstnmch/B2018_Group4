using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;
using System.Data.OleDb;


namespace EVoting
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            string getPath = Server.MapPath("~/ExcelFile/Data.xlsx");
            getExcel(getPath, ".xlsx", "Yes");
        }
        public void getExcel(string FileP, string extension, string ishdr)
        {
            string conStr = ConfigurationManager.ConnectionStrings["ExcelConnection"].ConnectionString;

            conStr = String.Format(conStr, FileP, ishdr);
            OleDbConnection myExcelConn = new OleDbConnection(conStr);
            OleDbCommand myExcelCmd = new OleDbCommand();
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            DataTable mydt = new DataTable();
            myExcelCmd.Connection = myExcelConn;

            myExcelConn.Open();
            DataTable dtExcelSchema = myExcelConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            //Fetch the name of First Sheet
            string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
            

            //Read Data from First Sheet
            myExcelCmd.CommandText = "SELECT * from [" + SheetName + "]";
            myDataAdapter.SelectCommand = myExcelCmd;
            myDataAdapter.Fill(mydt);
            myExcelConn.Close();

            //Bind mySessionTable to gridview control
            GridView1.Caption = Path.GetFileName(FileP);
            GridView1.DataSource = mydt;
            GridView1.DataBind();
        }
    }
}