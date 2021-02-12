using System;
using System.Collections.Generic;
using System.Text;

namespace Project_interface
{
    abstract class ZakladniZarizeni : Zarizeni
    {
        protected internal bool stav;
        protected internal string nazev;

        public ZakladniZarizeni(string nazev)
        {
            this.nazev = nazev;
        }

        public virtual void Zapni()
        {
            if (!stav == true)
            {
                this.stav = true;
                Console.WriteLine("Zarizeni zapnute");
            }
        }

        public virtual void Vypni()
        {
            if (!stav == false)
            {
                this.stav = false;
                Console.WriteLine("Zarizeni vypnute");
            }
        }
    }
}
