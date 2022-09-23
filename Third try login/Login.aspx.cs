using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

//var connectionString = "Host=myserver;Username=mylogin;Password=mypass;Database=mydatabase";

//await using var conn = new NpgsqlConnection(connectionString);
//await conn.OpenAsync();

namespace Third_try_login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            successfulConnect.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Data Source=34.160.91.144,5432;Network Library=DBMSSOCN;Initial Catalog=Bmonky13.Classified;User ID=Bmonky13;Password=v2_3uK8C_jArJzeSymZ9haEmzqwgLusg";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            successfulConnect.Visible=true;
            cnn.Close();
        }

    }
}