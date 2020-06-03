using System;

namespace ConsoleApp2
{
    class Catalog
    {
        string[] Brand = { "Ford ", "BMW", "Tesla", "Toyota", "Honda", "Ferrari", "Jeep", "Audi", "Honda", "Toyota" };
        string[] Color = { "Blue", "Black", "White", "Red", "Ping", "Black", "Red", "Blue", "White", "Orange" };
        string[] Number = { "AA5556BB", "AO6665AM", "BC7814HH", "AA8997CH", "AO0100CK", "AO1555BB", "AO1001PP", "AH2002AA", "AO2001AM", "AO7668AM" };
        string[] Year = { "2010", "2016", "2010", "2019", "1998", "2019", "2005", "2014", "2013", "2002" };
        string[] OwnerData = { "Poirot 1997", "Marple 2001", "Montag 1992", "Smith 2002", "Gloury 1999", "King 2001", "Kent 1997", "Karpelo 2001", "Ozbern 2002", "Bonaldon 1990" };
        public Catalog()
        {

        }
        public void print()
        {

            Console.WriteLine("Information: \tColor: \tNumber: \tAge: \tInfornation about Owner: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("" + Brand[i] + "\t\t" + Color[i] + "\t" + Number[i] + "\t" + Year[i] + "\t" + OwnerData[i]);
            }
        }
        public static void Main()
        {
            Catalog s1 = new Catalog();
            s1.print();
        }
    }
}
