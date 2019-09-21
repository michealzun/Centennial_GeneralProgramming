using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static List<Student> students = new List<Student>
        {
             new Student{ First="Xavier", Last="Thomas", Id=111, Scores=new List<int>{97,92 ,81 , 55, 60 } },
             new Student{ First="Lyoid", Last="Lopes", Id=112, Scores=new List<int>{96, 88, 86, 77, 55 } },
             new Student{ First="Navdeep", Last="Singh", Id=113, Scores=new List<int>{92, 97, 65, 89,  45} },
             new Student{ First="Lyle", Last="Spurrell", Id=114, Scores=new List<int>{90, 95, 75, 78, 83 } },
             new Student{ First="Viktor", Last="Salnichenko", Id=115, Scores=new List<int>{87, 96, 65, 34,  90} },
             new Student{ First="Sukhpratap", Last="Singh", Id=116, Scores=new List<int>{90, 87, 56, 98, 78 } },
             new Student{ First="Dannel", Last="Alon", Id=117, Scores=new List<int>{90, 84,59 ,67 , 98 } },
             new Student{ First="Francis", Last="Acheampong", Id=118, Scores=new List<int>{89, 56, 56, 67, 87 } },
             new Student{ First="Mahamod", Last="Masleh", Id=119, Scores=new List<int>{67, 78,46 , 78, 98 } },
             new Student{ First="John", Last="Calma", Id=120, Scores=new List<int>{89, 76, 78, 67,  87} },
             new Student{ First="Sarina", Last="Luu", Id=121, Scores=new List<int>{67, 67, 87, 74,  95} },
             new Student{ First="Valerie", Last="Chan", Id=122, Scores=new List<int>{87, 69, 95, 67,  49} },
             new Student{ First="Tej", Last="Singh", Id=127, Scores=new List<int>{90, 87, 96, 98, 78 } },
             new Student{ First="Mabel", Last="Tang", Id=123, Scores=new List<int>{87, 78,59 , 75,  67} },
             new Student{ First="Rishav", Last="Giri", Id=124, Scores=new List<int>{65, 87, 58, 92,  68} },
             new Student{ First="Toni", Last="Lea", Id=125, Scores=new List<int>{78, 97, 83, 83,  87} },
             new Student{ First="Melanie", Last="March", Id=126, Scores=new List<int>{89, 79, 80, 95, 97 } }
        };
        static List<Person> persons = new List<Person>()
        {
            new Person(){ Age = 72, Asset = 7.0, Country="South Africa", IsFemale=false, Name="Nicky Oppenheimer"},
            new Person(){ Age = 67, Asset = 7.6, Country="India", IsFemale=true, Name="Savitri Jindal"},
            new Person(){ Age = 81, Asset = 3.1, Country="India", IsFemale=true, Name="Indu Jain"},
            new Person(){ Age = 70, Asset = 2.5, Country="India", IsFemale=true, Name="Vinod Gupta"},
            new Person(){ Age = 77, Asset = 27.0, Country = "US",IsFemale = true,Name = "Jacqueline Mars"},
            new Person(){ Age = 76, Asset = 25.2, Country = "Italy", IsFemale = true, Name = "Maria Franca Fissolo"},
            new Person(){ Age = 55, Asset = 20.4, Country = "Germany", IsFemale = true, Name = "Susanne Klatten"},
            new Person(){ Age = 53, Asset = 20.0, Country = "US",IsFemale = true,Name = "Laurene Jobs"},
            new Person(){ Age = 60, Asset = 12.5, Country = "Nigeria", IsFemale=false, Name="Aliko Dangote" },
            new Person(){ Age = 76, Asset = 10.9, Country = "Ethiopia", IsFemale=false, Name="Mohammed Al Amoudi"},
            new Person(){ Age = 60, Asset = 30.7, Country = "Canada", IsFemale=false, Name="David Thomson" },
            new Person(){ Age = 76, Asset = 11.4, Country = "Canada", IsFemale=false, Name="Galen Weston"},
            new Person(){ Age = 60, Asset = 22.3, Country = "India", IsFemale=false, Name="Mukesh Ambani"},
            new Person(){ Age = 50, Asset = 17.5, Country = "India", IsFemale=false, Name="Dilip Shanghvi"},
            new Person(){ Age = 83, Asset = 30.4, Country = "US", IsFemale=false, Name="Sheldon Adelson"},
            new Person(){ Age = 78, Asset = 30.0, Country = "Brazil", IsFemale=false, Name="Jorge Lemann"},
            new Person(){ Age = 62, Asset = 18.4, Country = "Russia", IsFemale=false, Name="Leonid Mikhelson"},
            new Person(){ Age = 51, Asset = 17.5, Country = "Russia", IsFemale=false, Name="Alexey Mordashov"},
            new Person(){ Age = 89, Asset = 31.2, Country = "Hong Kong", IsFemale=false, Name="Li Ka-shing"},
            new Person(){ Age = 62, Asset = 31.2, Country = "China", IsFemale=false, Name="Wang Jianlin"},
            new Person(){ Age = 67, Asset = 33.8, Country = "US", IsFemale=true, Name="Alice Walton" },
            new Person(){ Age = 60, Asset = 34.0, Country = "US", IsFemale=false, Name="Jim Walton"},
            new Person(){ Age = 72, Asset = 34.1, Country = "US", IsFemale=false, Name="Rob Walton"},
            new Person(){ Age = 94, Asset = 39.5, Country = "France", IsFemale=true, Name="Liliane Bettencourt"},
            new Person(){ Age = 43, Asset = 39.8, Country = "US", IsFemale=false, Name="Sergey Brin"},
            new Person(){ Age = 43, Asset = 39.6, Country = "US", IsFemale=false, Name="Larry Page"},
            new Person(){ Age = 68, Asset = 41.5, Country = "France", IsFemale=false, Name="Bernard Arnault"},
            new Person(){ Age = 75, Asset = 47.5, Country = "US", IsFemale=false, Name="Michael Bloomberg"},
            new Person(){ Age = 77, Asset = 48.3, Country = "US", IsFemale=false, Name="David Koch"},
            new Person(){ Age = 81, Asset = 48.3, Country = "US", IsFemale=false, Name="Charles Koch"},
            new Person(){ Age = 72, Asset = 52.2, Country = "US", IsFemale=false, Name="Larry Ellison"},
            new Person(){ Age = 77, Asset = 54.5, Country = "Mexico", IsFemale=false, Name="Carlos Slim Helu"},
            new Person(){ Age = 33, Asset = 56.0, Country = "US", IsFemale=false, Name="Mark Zuckerberg"},
            new Person(){ Age = 81, Asset = 71.3, Country = "Spain", IsFemale=false, Name="Amancio Ortega"},
            new Person(){ Age = 53, Asset = 72.8, Country = "US", IsFemale=false, Name="Jeff Bezos" },
            new Person(){ Age = 85, Asset = 75.6, Country = "US", IsFemale=false, Name="Warren Buffet" },
            new Person(){ Age = 60, Asset = 86.0, Country = "US", IsFemale=false, Name="Bill Gates"}
           };
        static List<Fruit> fruits = new List<Fruit>()
        {
            new Fruit(){ Name="Mango", Origin="Guyana", Price=5.67},
            new Fruit(){ Name="Kiwi", Origin="New Zeeland", Price=1.34},
            new Fruit(){ Name="Dragon Fruit", Origin="China", Price=3.45},
            new Fruit(){ Name="Avacado", Origin="Mexico", Price=2.56},
            new Fruit(){ Name="Banana", Origin="Ecuador", Price=0.25},
            new Fruit(){ Name="Persimon", Origin="Spain", Price=1.36 },
            new Fruit(){ Name="Blueberry", Origin="Canada", Price=0.19 },
            new Fruit(){ Name="Strawberry", Origin="Russia", Price=0.45 },
            new Fruit(){ Name="Avocado", Origin="Mexico", Price=0.45 }
        };
        static void Main(string[] args)
        {
            Q1();
            Q2();
            Q3();
            Q4();
            Q5();
            Q6();
            Q7();
            Q8();
            Q9();
            Console.ReadLine();
        }
        public static void Q1()
        {
            Console.WriteLine(" 1.	Show all non-US citizens");
            var citizens = persons.Where(a => a.Country != "US");
            foreach (var citizen in citizens)
                Console.WriteLine(citizen.Name + " from " + citizen.Country);
            Console.WriteLine("");
        }
        static public void Q2()
        {
            Console.WriteLine("2.	Shows only the name of all US citizens ");
            var citizens = persons.Where(a => a.Country == "US");
            foreach (var citizen in citizens)
                Console.WriteLine(citizen.Name);
            Console.WriteLine("");
        }
        static public void Q3()
        {
            Console.WriteLine("3.	Show all females from India.");
            var indianFemale = persons.Where(a => a.Country == "India"&& a.IsFemale);
            foreach (var indi in indianFemale)
                Console.WriteLine(indi);
            Console.WriteLine("");
        }
        static public void Q4()
        {
            Console.WriteLine("4.	Sort the collection by last name and then first name");
            var people = persons.OrderByDescending(a => a.Name.Split()[1]).ThenByDescending(a => a.Name.Split()[0]);
            foreach (var person in people)
                Console.WriteLine(person.Name);
            Console.WriteLine("");
        }
        static public void Q5()
        {
            Console.WriteLine("5.	Group the collection by gender");
            var group = persons.GroupBy(a=>a.IsFemale);
            foreach (var people in group)
            {
                foreach (var person in people)
                {
                    string sex = person.IsFemale ? "female" : "male";
                    Console.WriteLine(person.Name + " gender of " + sex);
                }
            }
            Console.WriteLine("");
        }
        public static void Q6()
        {
            Console.WriteLine(" 6.The first longest word in the string array words");
            string[] arr = { "one", "two", "three", "four", "oooo" };
            var firstLongWord= arr.OrderByDescending(a => a.Length).First();
            Console.WriteLine(firstLongWord);
            Console.WriteLine("");
        }
        public static void Q7()
        {
            Console.WriteLine(" 7.The first word with the most vowels.");
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string[] arr = { "one", "two", "three","four","oooo"};
            var word = arr.OrderByDescending(a => a.Count(b => vowels.Contains(b))).First();
            Console.WriteLine(word);
            Console.WriteLine("");
        }
        public static void Q8()
        {
            Console.WriteLine(" 8.All the elements in second and third with no duplicates.");
            var citizens = persons.Where(a => a.Country == "US" || (a.Country == "India" && a.IsFemale) );
            foreach (var citizen in citizens)
                Console.WriteLine(citizen.Name);
            Console.WriteLine("");
        }
        public static void Q9()
        {
            List<Student> studentsA = new List<Student>
        {
             new Student{ First="Xavier", Last="Thomas", Id=111, Scores=new List<int>{97,92 ,81 , 55, 60 } },
             new Student{ First="Lyoid", Last="Lopes", Id=112, Scores=new List<int>{96, 88, 86, 77, 55 } },
             new Student{ First="Navdeep", Last="Singh", Id=113, Scores=new List<int>{92, 97, 65, 89,  45} }
        };
            List<Fruit> fruitsA = new List<Fruit>()
        {
            new Fruit(){ Name="Xavier", Origin="Guyana", Price=5.67},
            new Fruit(){ Name="Lyoid", Origin="New Zeeland", Price=1.34},
            new Fruit(){ Name="Dragon Fruit", Origin="China", Price=3.45}
        };

            Console.WriteLine("9.Inner ");
        var IJoin = from x in studentsA
                    join y in fruitsA
                    on x.First equals y.Name
                    select x;
        foreach (var item in IJoin)
            Console.WriteLine(item.First);
            Console.WriteLine("");

            Console.WriteLine("left");
        var LJoin = from x in studentsA
                    join y in fruitsA
                    on x.First equals y.Name into a
                    from b in a.DefaultIfEmpty(new Fruit())
                    select x;
        foreach (var item in LJoin)
            Console.WriteLine(item.First);
            Console.WriteLine("");

            Console.WriteLine("right");
        var RJoin = from x in fruitsA
                    join y in studentsA
                    on x.Name equals y.First into a
                    from b in a.DefaultIfEmpty(new Student())
                    select x;
        foreach (var item in RJoin)
                Console.WriteLine(item.Name);
            Console.WriteLine("");
        }
}
}
