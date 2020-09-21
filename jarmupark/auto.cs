using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmupark
{
    class auto
    {
        private string szin, tipus;
        private double uzemanyag, fogyaszt,km,megtehetokm;
        public auto(string szin,string tipus,double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.km = 0;
            this.uzemanyag=0;
            this.megtehetokm = 0;

        }
        private void megteheto()
        {
            megtehetokm = 100 / fogyaszt * uzemanyag;
        }
        public void tankol(double mennyit)
        {
            uzemanyag+= mennyit;
            megteheto();
            
        }
        public void megy(double km)
        {
            this.km += km;
            double fogy = km / 100 * fogyaszt;
            
            this.uzemanyag = this.uzemanyag - fogy;
            megteheto();
        }
        public void állapot()
        {
            Console.WriteLine($"Típus: {tipus} Szín: {szin} Tartály: {uzemanyag}l  Fogyasztása: {fogyaszt}/100km Km óra: {km}km");
            Console.WriteLine("Megtehő km: {0}",megtehetokm);
        }
       

    }
}
