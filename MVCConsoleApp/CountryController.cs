using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MVCConsoleApp
{
    class CountryController
    {
        public List<Country> CountryDb = new List<Country>();
        public CountryController()
        {
            Country usa = new Country();
            List<string> usacolor = new List<string>() { "Red", "White", "Blue" };
            usa.Name = "United States of America";
            usa.Continent = "North America";
            usa.Colors = usacolor;
            CountryDb.Add(usa);
            Country can = new Country();
            List<string> cancolor = new List<string>() { "Red", "White" };
            can.Name = "Canada";
            can.Continent = "North America";
            can.Colors = cancolor;
            CountryDb.Add(can);
            Country mex = new Country();
            List<string> mexcolor = new List<string>() { "Green", "White", "Red" };
            mex.Name = "Mexico";
            mex.Continent = "North America";
            mex.Colors = mexcolor;
            CountryDb.Add(mex);
            Country bra = new Country();
            List<string> bracolor = new List<string>() { "Green", "Yellow", "Blue", "White" };
            bra.Name = "Brazil";
            bra.Continent = "South America";
            bra.Colors = bracolor;
            CountryDb.Add(bra);
        }

        public void CountryAction(Country c)
        {
            CountryView country = new CountryView(c);
            country.Display();
        }

        public void WelcomeAction()
        {
            CountryListView countries = new CountryListView(CountryDb);
            countries.Display();
            Console.Write("Hello welcome to the country app. Please select a country: ");
            string answer = Console.ReadLine();
            int index = int.Parse(answer) - 1;
            Console.WriteLine();
            CountryAction(CountryDb[index]);
            Console.WriteLine();
        }

        public void SecondAction()
        {
            CountryListView countries = new CountryListView(CountryDb);
            countries.Display();
            Console.WriteLine("Please select a country from the following list: ");
            string answer = Console.ReadLine();
            int index = int.Parse(answer);
            Console.WriteLine();
            CountryAction(CountryDb[index]);
            Console.WriteLine();
        }

    }
}
