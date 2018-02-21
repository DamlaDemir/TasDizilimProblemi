using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımSınamaÖdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
      
            if (IsNumeric(txtBasamakSayisi.Text))
            {
                if (Convert.ToInt32(txtBasamakSayisi.Text) == 0)
                    MessageBox.Show("Sıfırdan büyük bir değer giriniz!");
                else
                {
                    IkiliAgacDugumu kok = new IkiliAgacDugumu(1);
                    IkiliAgac agac = new IkiliAgac(kok, Convert.ToInt32(txtBasamakSayisi.Text));
                    agac.AgacOlustur();
                    agac.AgaciGez();
                    rtxtElemanlar.Text = agac.elemanlar;
                    lblElemanSayisi.Text = agac.elemanSayisi.ToString() + " adet farklı dizilim vardır.";
                    lblElemanSayisi.Visible = true;
                }
            }
       
            else
            {
                MessageBox.Show("Lütfen sayı giriniz!");

            }
    

        }

        public bool IsNumeric(string text)
        {
            bool sayiMi=true;
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr))
                    sayiMi = false;
            }
            return sayiMi;
        }

    }
}
