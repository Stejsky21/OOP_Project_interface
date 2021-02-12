using System;

namespace Project_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // base = super


            Dum domek = new Dum(new Vytapeni("domekVytapeni"), new Osvetleni("domekOsvetleni"));


            domek.ZapniVytapeni();
            domek.ZapniSvetlo();

            try
            {


            }
            catch (Exception)
            {
                Console.WriteLine("chyba");
                domek.NastavTeplotu(25);
            }
            finally
            {
                domek.VypniVytapeni(); 
            }


            Console.WriteLine(domek.vytapeni.teplota);










        }
    }
}
