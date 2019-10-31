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
            MusteriyeAitSehriDropdownIcindenSeciliDurumaGetir();
            SehirDropDownunuDoldur();

        }

        public void MusteriyeAitSehriDropdownIcindenSeciliDurumaGetir()
        {
            Label1.Text = Request.QueryString["id"];
            string querystr = Label1.Text;
            if (!Page.IsPostBack)
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("Select * from Musteri where MusteriId='" + querystr +
                     "'", baglanti);
                

                SqlDataReader dr = sorgu.ExecuteReader();
                Convert.ToInt32(querystr);
                
                if (dr.Read())
                {
                    Label1.Text = dr["SehirId"].ToString();
                    MusteriAd.Text = dr["MusteriAd"].ToString();
                    MusteriTip.Text = dr["MusteriTipi"].ToString();
                    baglanti.Close();
                }
                //benim sorunum şuanda sehir idleri nerede ve nasıl birleştirecegim şuanda çalıştırdıgımda otomatik olarak
                // ilk sıradaki şehri gösteriyor bir atama yapılmadıgından dolayı. o atamayı yapamadım.
            }
        }
            public void SehirDropDownunuDoldur()
            {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Sehir", baglanti);
             SqlDataReader dr = komut.ExecuteReader();
            
                DropDownList1.DataSource = dr;
                
                DropDownList1.DataValueField = "SehirId";
                DropDownList1.DataTextField = "SehirAd";
                DropDownList1.DataBind();
            
            }
        }
    }
