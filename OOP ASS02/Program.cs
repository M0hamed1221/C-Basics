using System.Security.Cryptography.X509Certificates;

namespace OOP_ASS02
{

    enum WeekDays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

       
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    [Flags]
    enum Permissions:byte
    {
        Delete =1 ,
        Execute=2,
        Read =4,
        Write =8,
        
    }
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

      
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //foreach (int i in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine($"{i}: {Enum.GetName(typeof(WeekDays), i)}");
            //}

            #endregion

            #region Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the arra
            //Person[] people = new Person[3];
            //people[0] = new Person("mohamed", 25);
            //people[1] = new Person("khaled", 30);
            //people[2] = new Person("mohamed", 35);


            //Console.WriteLine("Details of all persons:");
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}
            #endregion
            #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter the name of a season ");
            //string input = Console.ReadLine();


            //if (Enum.TryParse(input, true, out Season season))
            //{

            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}
            #endregion
            #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //Permissions userPermissions = Permissions.Delete;

            //// Add permissions
            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;

            //Console.WriteLine($"Current Permissions: {userPermissions}");


            //userPermissions &= ~Permissions.Write;

            //Console.WriteLine($"Permissions after removing Write: {userPermissions}");


            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read permission exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Read permission does not exist.");
            //}

            //if ((userPermissions & Permissions.Execute) == Permissions.Execute)
            //{
            //    Console.WriteLine("Execute permission exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Execute permission does not exist.");
            //}


            #endregion
            #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or no
            //Console.WriteLine("Enter a color ");
            //string input = Console.ReadLine();

            //// Check if the input matches a primary color
            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    Console.WriteLine($"{input} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //}
            #endregion
            #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point GetPointFromUser(string pointName)
            //{
            //    Console.WriteLine($"Enter coordinates for {pointName}:");

            //    Console.Write("X: ");
            //    double x = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Y: ");
            //    double y = Convert.ToDouble(Console.ReadLine());

            //    return new Point(x, y);
            //}


            //Point point1 = GetPointFromUser("Point 1");
            //Point point2 = GetPointFromUser("Point 2");


            //double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

            //Console.WriteLine($"The distance between Point 1 ({point1.X}, {point1.Y}) and Point 2 ({point2.X}, {point2.Y}) is {distance:F2}");

            #endregion
            #region    Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            // int numberOfPersons = 3;
            //Person[] people = new Person[numberOfPersons];

            //for (int i = 0; i < numberOfPersons; i++)
            //{
            //    Console.WriteLine($"Enter details for Person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    people[i] = new Person(name, age);
            //}

            ////  the oldest person
            //Person oldest = people[0];
            //foreach (var person in people)
            //{
            //    if (person.Age > oldest.Age)
            //    {
            //        oldest = person;
            //    }
            //}

            //Console.WriteLine($"\nThe oldest person is {oldest.Name} with an age of {oldest.Age}.");


            #endregion
        }
            #region part02 
            class Employee
        {

            private int id;
            private string name;
            private int securityLevel;
            private decimal salary;
            private DateTime hireDate;
            private string gender;
            public int ID
            {
                get; set;
            }
            public string Name
            {
                get; set;

            }
            public int SecurityLevel
            {
                get; set;
            }
            public DateTime HireDate
            {
                get { return hireDate; }
                set { hireDate = value; }
            }
            public string Gender
            {
                get { return gender; }  
                set { gender = value; }
            }

            #endregion
        }
    }
}