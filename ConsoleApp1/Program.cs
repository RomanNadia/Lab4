using System;

namespace ConsoleApp1
{
    class Student
    {
        private string Name;
        private string LastName;
        private string Group;
        private int Year;
        private string Adress;
        private double Passport;
        private int Age;
        private string Telephon;
        private double Rating;
        public Student()
        {

        }
        public void setName()
        {
            Name = "Vasilina";
        }
        public string getName()
        {
            return Name;
        }
        public void setLastName()
        {
            LastName = "Toronto";
        }
        public string getLastName()
        {
            return LastName;
        }
        public void setGroup()
        {
            Group = "IT";
        }
        public string getGroup()
        {
            return Group;
        }
        public void setYear()
        {
            Year = 2019;
        }
        public int getYear()
        {
            return Year;
        }
        public void setAdress()
        {
            Adress = "Baker street, 66";
        }
        public string getAdress()
        {
            return Adress;
        }
        public void setPassport()
        {
            Passport = 6667;
        }
        public double getPassport()
        {
            return Passport;
        }
        public void setAge()
        {
            Age = 18;
        }
        public int getAge()
        {
            return Age;
        }
        public void setTelephon()
        {
            Telephon = "+380606060606";
        }
        public string getTelephon()
        {
            return Telephon;
        }
        public void setRating()
        {
            Rating = 99.9;
        }
        public double getRating()
        {
            return Rating;
        }
        public void print()
        {
            Console.WriteLine("First Name: " + Name);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Group: " + Group);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Adress: " + Adress);
            Console.WriteLine("ID Passport: " + Passport);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Telephon: " + Telephon);
            Console.WriteLine("Rating: " + Rating);

        }
        public void StudentRating()
        {
            double R = Rating;
            if (R >= 90) Console.WriteLine("\nCongratulations to the excellent student!");
            else if ((R >= 75) && (R < 90)) Console.WriteLine("\nYou can learn better");
            else Console.WriteLine("\nYou should pay more attention to training");
        }
        public static void Main()
        {
            Student s1 = new Student();
            s1.setName();
            s1.getName();
            s1.setLastName();
            s1.getLastName();
            s1.setGroup();
            s1.getGroup();
            s1.setYear();
            s1.getYear();
            s1.setAdress();
            s1.getAdress();
            s1.setPassport();
            s1.getPassport();
            s1.setAge();
            s1.getAge();
            s1.setTelephon();
            s1.getTelephon();
            s1.setRating();
            s1.getRating();
            s1.print();
            s1.StudentRating();
        }
    }
}
