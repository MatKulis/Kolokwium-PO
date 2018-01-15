using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos
{
    class Blok : ProjektDomu
    {
       override  public void PomalujElewacje(Kolor kolor) 
        {
            PomalujElewacje(kolor);
        }
        override public void ZamontujDrzwi(string rodzajDrzwi)
        {
            Console.WriteLine("brazowe,dab");
        }
        public string ToString()
        {
            return "a";
        }
    }
}
