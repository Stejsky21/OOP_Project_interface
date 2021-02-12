using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace Project_interface
{
     class Vytapeni : ZakladniZarizeni, Zarizeni, Termostat
    {
        public int teplota;
        public const int MAX_TEPLOTA = 40;


        public Vytapeni(string nazev) : base(nazev)
        {

        }

        public override void Zapni()
        {
            this.stav = true;
            teplota = 25;
        }

        public override void Vypni()
        {
            this.stav = false;
            teplota = 0;
        }

        public void NastavTeplotu(int teplota)
        {
            if(teplota < 0 || teplota > MAX_TEPLOTA)
            {
                throw new ArgumentException("teplota musi byt 0-40");
            }

            this.teplota = teplota;
            Console.WriteLine("Aktualni Teplota: " + teplota);
        }
    }
}

