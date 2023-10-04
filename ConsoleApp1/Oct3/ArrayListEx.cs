using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Oct3
{
    internal class ArrayListEx
    {
        class Address
        {
            public string City { get; set; }
            public string State { get; set; }

            public Address(string city, string state)
            {
                City = city;
                State = state;
            }

            public object Clone()
            {
                return MemberwiseClone();
            }
        }

        public static void Main()
        {
            ArrayList products = new ArrayList();
            products.Add("Iphone");
            products.Add("Macbook");
            products.Add("Apple Watch");
            products.Add("Apple Airpods");
            // we can add null as an element in arraylist
            products.Add("");

            Console.WriteLine("Product list using ArrayList(), Fixed Size: " + products.IsFixedSize);

            //printing each elements of arraylist
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            // making arraylist fixed size
            ArrayList productsfixed = ArrayList.FixedSize(products);
            Console.WriteLine("New list with fixed size, Fixed Size: " +productsfixed.IsFixedSize);


            // creating new arrayList for using AddRange() method
            ArrayList items = new ArrayList();
            items.Add("item1");
            items.Add("item2");
            items.Add("item3");
            products.AddRange(items);

            Console.WriteLine("After using AddRange() method: ");

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }


            Address ad1 = new Address("Piscataway", "New Jersey");
            Address ad2 = new Address("NYC", "New York");

            // cloning the object
            Address ad3 = (Address)ad1.Clone();

            Console.WriteLine($"Here is the address1 details, City: {ad1.City}, State: {ad1.State}");
            Console.WriteLine($"Here is the Cloned address details, City: {ad3.City}, State: {ad3.State}");
        }
    }
}
