using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos
{
    class Dom
    {
        string drzwi;
        Kolor kolorElewacji;
        string okno;


         public void PomalujElewacje(Kolor kolor)
        {
            this.kolorElewacji = kolor;        
        }

         public void WstawOkna(string rodzajOkien)
        {
            this.okno = rodzajOkien;
        }

         public void ZamontujDrzwi(string rodzajDrzwi)
        {
            this.drzwi = rodzajDrzwi;
        }

          public string ToString()
         {
             return drzwi;            
         }
    }
}
