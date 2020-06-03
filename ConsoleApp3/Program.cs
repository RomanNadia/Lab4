using System;

namespace ConsoleApp3
{
    public class Test
    {

        class Note
        {

            private string number = "Enter data";
            private string nametag = "Enter date for filling";
            private string make = "Enter date for filling";
            private string price = "Enter date for filling";
            private string quantity = "Enter date for filling";

            public Note()
            {
                number = "Enter date";
                nametag = "Enter date";
                make = "Enter date";
                price = "Enter date";
                quantity = "Enter date";
            }

            public Note(string n, string na, string m, string p, string q)
            {
                number = n;
                nametag = na;
                make = m;
                price = p;
                quantity = q;
            }

            public void setNumber(string n)
            {
                number = n;
            }

            public string getNumber()
            {
                return number;
            }

            public void setNametag(string na)
            {
                nametag = na;
            }

            public string getNametag()
            {
                return nametag;
            }

            public void setMake(string m)
            {
                make = m;
            }

            public string getMake()
            {
                return make;
            }

            public void setPrice(string p)
            {
                price = p;
            }

            public string getPrice()
            {
                return price;
            }

            public void setQuantity(string q)
            {
                quantity = q;
            }

            public string getQuantity()
            {
                return quantity;
            }

            public void add()
            {
                Console.WriteLine("Enter number:");
                number = Console.ReadLine();

                Console.WriteLine("Enter name:");
                nametag = Console.ReadLine();

                Console.WriteLine("Enter brand:");
                make = Console.ReadLine();

                Console.WriteLine("Enter price:");
                price = Console.ReadLine();

                Console.WriteLine("Enter count:");
                quantity = Console.ReadLine();
            }

            public void edit()
            {
                Console.WriteLine("Enter number:");
                number = Console.ReadLine();

                Console.WriteLine("Enter name:");
                nametag = Console.ReadLine();

                Console.WriteLine("Enter brand:");
                make = Console.ReadLine();

                Console.WriteLine("Enter price:");
                price = Console.ReadLine();

                Console.WriteLine("Enter count:");
                quantity = Console.ReadLine();
            }

            public void del()
            {
                number = "delete";
                nametag = "delete";
                make = "delete";
                price = "delete";
                quantity = "delete";
            }

            public void print()
            {
                Console.WriteLine("number: " + number);
                Console.WriteLine("name: " + nametag);
                Console.WriteLine("brand: " + make);
                Console.WriteLine("price: " + price);
                Console.WriteLine("count: " + quantity);
            }
        }

        class Date
        {

            public Note[] arr = new Note[10];

            public Date()
            {
                for (int i = 0; i < 10; i++)
                {
                    arr[i] = new Note();
                }
            }

            public void sort()
            {
                Array.Sort(arr);
            }

            public void find()
            {

                string z = "";
                Console.WriteLine("Enter number for seeking: ");
                z = Console.ReadLine();
                bool x = true;

                for (int i = 0; i < 10; i++)
                {
                    if (String.Equals(arr[i].getNumber(), z))
                    {
                        arr[i].print();
                        x = false;
                    }
                }

                if (x)
                {
                    Console.WriteLine("Number: " + z + " does not exist");
                }

            }

            public void add()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Add element" + i);
                    arr[i].add();
                }
            }

            public void edit()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Change element" + i);
                    arr[i].edit();
                }
            }

            public void print()
            {
                for (int i = 0; i < 10; i++)
                {
                    arr[i].print();
                    Console.WriteLine("--------------------------");
                }
            }

        }


        public static void Main()
        {
            Date d1 = new Date();
            d1.print();

            string s = "";

            Console.WriteLine("Choose manu option: ");
            Console.WriteLine("1. Add new record, press a");
            Console.WriteLine("2. Edit record, press e");
            Console.WriteLine("3. Find record, press f");
            Console.WriteLine("4. Exit x");
            s = Console.ReadLine();

            switch (s)
            {
                case "a":
                    d1.add();
                    break;
                case "e":
                    d1.edit();
                    break;
                case "f":
                    d1.find();
                    break;
                case "x":
                    Console.WriteLine("Exit");
                    break;
            }


        }
    }
}
