using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    class Addess 
    {
        int index;
        string country;
        string city;
        string street;
        int house;
        int apartment;

        public int Index
        {
            set { index = value; }
            get { return index; }
        }

        public string Country
        {
            set { country = value; }
            get { return country; }
        }

        public string City
        {
            set { city = value; }
            get { return city; }
        }

        public string Street
        {
            set { street = value; }
            get { return street; }
        }

        public int House
        {
            set { house = value; }
            get { return house; }           
        }

        public int Apartment
        {
            set { apartment = value; }
            get { return apartment; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Addess addess = new Addess();

            addess.Index = 123456;
            addess.Country = "Rusland";
            addess.City = "Moscow";
            addess.Street = "Tverskaya";
            addess.House = 4;
            addess.Apartment = 22;

            Console.WriteLine(addess.Index);
            Console.WriteLine(addess.Country);
            Console.WriteLine(addess.City);
            Console.WriteLine(addess.Street);
            Console.WriteLine(addess.House);
            Console.WriteLine(addess.Apartment);

            // Delay
            Console.ReadKey();
        }
    }
}
