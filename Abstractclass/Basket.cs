using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Basket : JadwalEkstrakulikuler
    {
        public override void Hari()
        {
            Console.WriteLine("Mempelajari tatacara bermain basket yg baik dan benar");
            Console.WriteLine("Dengan melakukan Dribble, Lay Up, Passing, Pivot");
        }
    }
}
