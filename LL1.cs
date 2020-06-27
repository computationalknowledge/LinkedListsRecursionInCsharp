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
        // #todo: implmented a doubly linked list: forward and backward
        // specify which city is the tail
        // traverse the list by starting at the tail
        // follow the linked all the way back to the head
        public City tail;

        public void MakeACity()
        {
            head = new City("Toronto");

            head.previousCity = null;

            City Pickering = new City("Pickering");
            City Ajax = new City("Ajax");
            City Oshawa = new City("Oshawa");
            City Elmer = new City("Elmer");

            head.nextCity = Pickering;
            Pickering.nextCity = Oshawa;
            Oshawa.nextCity = Elmer;

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
