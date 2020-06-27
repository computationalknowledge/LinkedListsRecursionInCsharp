using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CityMap cm = new CityMap();
            cm.MakeACity();
            cm.NodeTraversal(CityMap.head);

        }
    }

    class CityMap
    {
        public static City head;
        public City tail;
        bool thereIsAnotherCity = true;

        public void MakeACity()
        {
            head = new City("Toronto");
            head.nextCity = new City("Pickering");
            head.previousCity = null;
        }
        
        public void NodeTraversal(City a)
        {
            try { 
                while(a.nextCity != null) {
                    Console.WriteLine("{0}", a.CityName);
                    a = a.nextCity;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
        }
    }
    class City
    {   // City is going to a NODE in a LINKED LIST

        public City(string cityName)
        {
            this.CityName = cityName;
        }
       

        public City previousCity;
        public City nextCity;

        public String CityName;

    }
}
