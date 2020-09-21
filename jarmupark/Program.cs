using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmupark
{
    class Program
    {
        static void Main(string[] args)
        {
            auto lada= new auto("piros","Lada 2112",11);
            auto trabant = new auto("zöld","Trabant 1.1",8);
            /*lada.fogyaszt= 11;
            lada.km = 212342;
            trabant.fogyaszt = 8;
            trabant.km = 302999;*/

            trabant.tankol(20);
            lada.tankol(20);
            
            Console.WriteLine("Mennyit menjen a trabant?");
            double trabantb = double.Parse(Console.ReadLine());

            Console.WriteLine("Mennyit menjen a lada?");
            double ladab = double.Parse(Console.ReadLine());

            trabant.megy(trabantb);
            lada.megy(ladab);

            trabant.állapot();
            lada.állapot();
            Console.WriteLine("Trabant KM: {0}",trabant.KM);
            Console.WriteLine("trabant üzemanyaga: {0}",trabant.UZEMANYAG);
            Console.ReadKey();
        }
    }
}
