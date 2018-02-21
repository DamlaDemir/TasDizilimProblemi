using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımSınamaÖdev1
{
    public class IkiliAgacDugumu
    {
        public int veri;
        public IkiliAgacDugumu sol;
        public IkiliAgacDugumu sag;
        public IkiliAgacDugumu(int veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
        }
    }
}
