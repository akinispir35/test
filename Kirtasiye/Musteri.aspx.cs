using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Kirtasiye
{
    public partial class Musteri : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Server=192.168.1.200;user id=akin;Password=akin;Database=AKIN;");
    
        public void Page_Load(object sender, EventArgs e)
        {

             SqlCommand komut = new SqlCommand("Select * from Musteri", baglanti);
             baglanti.Open();
             SqlDataAdapter da = new SqlDataAdapter();
             da.SelectCommand = komut;
             DataTable dt = new DataTable();

             da.Fill(dt);
             dt.Columns.Add("Guncelleme");
              baglanti.Close();
             string html = Environment.NewLine + "<table id='Sonuc'>";
             for (int i = 0; i < dt.Rows.Count; i++)
             {
                 dt.Rows[i]["Guncelleme"] = "Guncelle";
                
             }
            html += Environment.NewLine + "<tr>";
             for (int i = 0; i < dt.Columns.Count; i++)
                 html += Environment.NewLine + "<td>" + dt.Columns[i].ColumnName + "</td>" + Environment.NewLine;
             html += Environment.NewLine + "</tr>";

             for (int i = 0; i < dt.Rows.Count; i++)
             {
                 html += Environment.NewLine + "<tr>";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (j == 4)
                    {
                        html += Environment.NewLine + "<td>" + "(<a id=" + (char)34 + i + (char)34 + " href=" + (char)34 + "downlist.aspx?id="
                           + dt.Rows[i][0] +
                          (char)34 + ">Guncelle</a>)" + "</td>" + Environment.NewLine;
                    }
                    else
                    {
                        html += Environment.NewLine + "<td>" + dt.Rows[i][j].ToString() + "</td>" + Environment.NewLine;
                    }
                   
 
                }

                 html += "</tr>";
             }
             html += "</table>";

      


             html += "</tr>";
             Response.Write(html);





            //SqlCommand komut = new SqlCommand("Select * from Musteri", baglanti);
            //baglanti.Open();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = komut;
            
           
            ////DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dt.Columns.Add("Guncelleme");
            
            //for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        dt.Rows[i]["Guncelleme"] = "Guncelle";
            //    }
            //    GridView1.DataSource = dt;
            //GridView1.DataBind();
            //baglanti.Close();

        }

       
    }
}