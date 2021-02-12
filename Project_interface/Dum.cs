using System;
using System.Collections.Generic;
using System.Text;

namespace Project_interface
{
    class Dum
    {
        public Vytapeni vytapeni;
        public Osvetleni osvetleni;

        public Dum(Vytapeni vytapeni, Osvetleni osvetleni)
        {
            this.vytapeni = vytapeni;
            this.osvetleni = osvetleni;
        }

        public void ZapniSvetlo()
        {
            osvetleni.Zapni();
        }

        public void VypniSvetlo()
        {
            osvetleni.Vypni();
        }

        public void ZapniVytapeni()
        {
            vytapeni.Zapni();
        }

        public void VypniVytapeni()
        {
            vytapeni.Vypni();
        }

        public void NastavTeplotu(int teplota)
        {
            vytapeni.NastavTeplotu(teplota);
        }
    }
}
