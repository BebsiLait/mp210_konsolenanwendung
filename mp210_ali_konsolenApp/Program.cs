using System;
using System.Collections.Generic;

namespace mp210_ali_konsolenApp
{
    public class MainApplication
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Geben Sie ihren Namen ein: ");
                string sName = Console.ReadLine();
                Console.WriteLine("Willkommen " + sName + "!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("FEHLER: " + ex.Message);
            }
        }
    }
}

