using System;
using System.Collections.Generic;
using System.Text;

namespace MVCConsoleApp
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country c)
        {
            DisplayCountry = c;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            for (int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                Console.WriteLine($"Colors: {DisplayCountry.Colors[i]}");
            }
        }


    }
}
