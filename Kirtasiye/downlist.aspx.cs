using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Kirtasiye
{
    public partial class downlist : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Server=192.168.1.200;user id=akin;Password=akin;Database=AKIN;");
        protected void Page_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Sehir",baglanti);

            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = komut;
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //DropDownList1.DataSource = dt;
            //DropDownList1.DataBind();
            SqlDataReader dr = komut.ExecuteReader();
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "SehirId";
            DropDownList1.DataTextField = "SehirAd";
            DropDownList1.DataBind();


        }
    }
}