using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormWebServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            /*
             WEB SERVİSLER HTTP PROTOKOLUNU KULLANARAK HİZMET SAĞLARLAR 
             İSTEMCİ YANİ CLİENT İSTEK ATAR VE BİR GERİ DÖNÜŞ GERÇEKLEŞİR 
             BU GERİ DÖNÜŞTE KULLLANILAN SERVİSE GÖRE XML , JSON VB YAPILAR KULLANILIR
             VE BİLGİ ALIŞVERİŞİ SAĞLANMIŞ OLUR
             BURADA TEXTBOXLAR ÜZERİNDEN GİRİLEN VERİLER ALINIP SORGULAMA YAPILIR VE GERİ DÖNÜŞ TİP OLARAK 
             TRUE YADA FALSE OLAN BOOL BİR DEĞER DÖNDÜRDÜK.
             AYRICA PROJEMİZE ADD SERVİCE REFERENCE DİYEREK DE URL MİZİ GEÇİRDİK
             
              
             */


            long kimlikNo = long.Parse(txt_tc.Text);
            int yil = int.Parse(txt_yil.Text);
            bool durum;

            try
            {
                using (TcDogrula.KPSPublicSoapClient service =new TcDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kimlikNo, txt_isim.Text, txt_soyisim.Text, yil);

                }

            }

            catch(Exception)
            {
                throw;

            }


            MessageBox.Show(durum.ToString());

        }
    }
}
