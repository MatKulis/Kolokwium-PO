using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos
{
   abstract class ProjektDomu
    {
        protected Dom dom;

        public void  NowyDom()
        {
            Dom dom;
        }
        abstract public void PomalujElewacje(Kolor kolor);
        
       virtual public void WstawOkna(string rodzajOkna) 
        {
            dom.WstawOkna(rodzajOkna);
        }
        virtual public void ZamontujDrzwi(string rodzajDrzwi) 
        {
            dom.ZamontujDrzwi(rodzajDrzwi);
        }
         public string ToString()
        {
            return "a";
        }
    }
}
