using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımSınamaÖdev1
{
    public class IkiliAgac
    {
        private IkiliAgacDugumu kok;
        public string elemanlar;
        int sayac = 1;
        int sayac2 = 0;
        private int basamakSayisi;
        public int elemanSayisi = 0;
        int[] dizi;

        public IkiliAgac(IkiliAgacDugumu kok,int basamakSayisi)
        {
            this.kok = kok;
            this.basamakSayisi = basamakSayisi;
            dizi = new int[basamakSayisi];
        }

        public void AgacOlustur( )
        {  
            Olustur(kok);
        }
        
        private void Olustur(IkiliAgacDugumu dugum)
        {
            if(sayac==basamakSayisi || dugum==null)
              return;
            
            if(sayac!=basamakSayisi && dugum != null)
            {
                    if(dugum.sol==null )
                    {
                        dugum.sol = new IkiliAgacDugumu(1);
                        sayac++;
                    }
                Olustur(dugum.sol);
            }

            if(dugum != null && dugum.veri == 1)
                dugum.sag = new IkiliAgacDugumu(0);
            Olustur(dugum.sag);
            sayac--;
        }

        public void AgaciGez()
        {
            Gez(kok);
        }
      
        private void Gez(IkiliAgacDugumu dugum)
        {  
            if (dugum == null)
            return;
           
           dizi[sayac2] = dugum.veri;

            if (sayac2 == basamakSayisi-1)
                Yazdir(dizi); 
            sayac2++;
            Gez(dugum.sol);
            Gez(dugum.sag);
            sayac2--;
        }

        private void Yazdir( int [] dizi)
        {    
            for (int i = 0; i < dizi.Length; i++)
            {
                elemanlar += dizi[i];       
            }
            elemanlar += " , ";
            this.elemanSayisi++;
        }

    }
}
