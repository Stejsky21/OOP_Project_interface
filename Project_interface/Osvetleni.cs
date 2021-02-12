using System;
using System.Collections.Generic;
using System.Text;

namespace Project_interface
{
    class Osvetleni : ZakladniZarizeni, Zarizeni
    {
        public Osvetleni(string nazev) : base(nazev)
        {
                
        }

        public override void Zapni() 
        {

            if (!stav == true)
            {
                base.Zapni();
                Console.WriteLine("Osvetleni Zapnute");
            }
        }

        public override void Vypni()
        {
            if (!stav == true)
            {
                base.Vypni();
                Console.WriteLine("Osvetleni Vypnute");
            }
        }
    }
}
