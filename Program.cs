using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Jadwalekstrakulikuler jadwalekstrakulikuler;
            jadwalekstrakulikuler = new Basket();
            jadwalekstrakulikuler.Hari();

            Console.WriteLine();
            jadwalekstrakulikuler = new Renang();
            jadwalekstrakulikuler.Hari();
			
			console.WriteLine();
			jadwalekstrakulikuler = new E-sport();
			jadwalekstrakulikuler.Hari();*/

            IJadwalEkstrakulikuler jadwalekstrakulikuler;
            jadwalekstrakulikuler = new Basket();
            jadwalekstrakulikuler.Hari();

            Console.WriteLine();
            jadwalekstrakulikuler = new Renang();
            jadwalekstrakulikuler.Hari();
			
			Console.WriteLine();
            jadwalekstrakulikuler = new E-sport();
            jadwalekstrakulikuler.Hari();
            Console.ReadKey();
        }
    }
}
