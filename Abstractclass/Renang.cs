using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Renang : JadwalEkstrakulikuler
    {
        public override void Hari()
        {
            Console.WriteLine("Mempelajari tatacara berenang");
            Console.WriteLine("Dengan melakukan gaya bebas, kupu-kupu, katak");
        }
    }
}
