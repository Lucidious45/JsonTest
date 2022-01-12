using System;
using System.Collections.Generic;
using System.Text;

namespace JsonTest.Views
{
    class LeerlingView
    {
        public static Data.Models.Leerling CreateLeerling()
        {
            var leerling = new Data.Models.Leerling();
            Console.Write("Please enter your name: ");
            leerling.Voornaam = Console.ReadLine();

            Console.Write("Please enter your age: ");
            leerling.Age = Console.ReadLine();

            Console.Write("Please enter your class: ");
            leerling.Klas = Console.ReadLine();

            return leerling;
        }

        public static void ShowLeerling(Data.Models.Leerling leerling)
        {
            Console.WriteLine("Voornaam: " + leerling.Voornaam);
            Console.WriteLine("Leeftijd: " + leerling.Age);
            Console.WriteLine("Klas: " + leerling.Klas);
        }
    }
}
