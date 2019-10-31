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
    public partial class MusteriGuncelle : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Server=192.168.1.200;user id=akin;Password=akin;Database=AKIN;");
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = Request.QueryString["id"];
            string querystr = Label1.Text;
            if (!Page.IsPostBack)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from Musteri where MusteriId='" + querystr +
                     "'", baglanti);
                
                
                SqlDataReader dr = komut.ExecuteReader();
                Convert.ToInt32(querystr);
                if (dr.Read())
                {
                    MusteriId.Text = dr["MusteriId"].ToString();
                    MusteriAd.Text = dr["MusteriAd"].ToString();
                    Sehir.Text = dr["SehirId"].ToString();
                    MusteriTip.Text = dr["MusteriTipi"].ToString();
                }

                baglanti.Close();
            }
            //if (Page.IsPostBack)
            //{
            //    baglanti.Open();
            //    SqlCommand sorgu = new SqlCommand("Select SehirAd from Sehir Where Musteri.SehirId'" + querystr + "'");
            //    SqlDataReader dr2 = sorgu.ExecuteReader();
            //    Convert.ToInt32(querystr);
            //    if (dr2.Read())
            //    {
            //        Sehir.Text = dr2["SehirAd"].ToString();
            //    }
            //}
           
        }
           
            public void kayitGuncelle()
        {
            if(MusteriAd !=null && MusteriTip !=null )
            {
                baglanti.Open();
                string update = "update Musteri set MusteriAd=@mAD,Sehir=@Sehir,MusteriTipi=@mTip where MusteriId=@mid";
                    
                SqlCommand komut = new SqlCommand(update, baglanti);

                komut.Parameters.AddWithValue("@mAD", MusteriAd.Text);
                komut.Parameters.AddWithValue("@Sehir", Sehir.Text);
                komut.Parameters.AddWithValue("@mTip",  MusteriTip.Text);
                komut.Parameters.AddWithValue("@mid",  MusteriId.Text);
                string islem = ""+MusteriAd.Text+""+Sehir.Text+""+MusteriTip.Text+""+MusteriId.Text;

                komut.ExecuteNonQuery();
                baglanti.Close();
            
                
                
                Label2.Text="Güncellendi...";
                
                
                
            }
            else
            {
                Label2.Text = "Alanları boş bırakmayın";
            }
        }
        public void yenile()
        {
            baglanti.Open();
            string kayit = "Select * from Musteri";
            SqlCommand komut =new SqlCommand (kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            baglanti.Close();
        }
         protected void btnUpdate_Click(object sender, EventArgs e)
        {
            kayitGuncelle();
        }
      protected void btnYenile_Click(object sender, EventArgs e)
        {
            yenile();
        }
    }

    }
