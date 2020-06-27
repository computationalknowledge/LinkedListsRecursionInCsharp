using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {  

        }
    }

    class CityMap
    {
        City head;
        City tail
        bool thereIsAnotherCity = true;

        public void MakeACity()
        {
            head = new City("Toronto");
            head.nextCity = new City("Pickering");
            head.previousCity = null;
        }
        
        public void LinkTraversal(City a)
        {
            while(thereIsAnotherCity) {
                Console.WriteLine("{0}", a.CityName);
            }
            
        }
    }
    class City
    {
        public City(string cityName)
        {
            this.CityName = cityName;
        }
        // City is going to a NODE in a LINKED LIST

        public City previousCity a;
        public City nextCity b;

        public String CityName;

    }
}
