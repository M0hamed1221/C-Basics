namespace OOP_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        #region First Project:

       
        internal class Point3D
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            // Constructor chaining
            public Point3D() : this(0, 0, 0) { }

            public Point3D(int x) : this(x, 0, 0) { }

            public Point3D(int x, int y) : this(x, y, 0) { }

            public Point3D(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            // Overriding ToString
            public override string ToString()
            {
                return $"Point Coordinates: ({X}, {Y}, {Z})";
            }

            private static Point3D ReadPoint(string pointName)
            {
                int x, y, z;

                Console.WriteLine($"Enter coordinates for {pointName}:");

                x = ReadCoordinate("X");
                y = ReadCoordinate("Y");
                z = ReadCoordinate("Z");

                return new Point3D(x, y, z);
            }
            private static int ReadCoordinate(string coordinateName)
            {
                int value;
                while (true)
                {
                    Console.Write($"Enter {coordinateName}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out value))
                        return value;

                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

        }


        #endregion
        #region Second Project:

        internal class Math
        {

            private static double Add(double A , double B)
            {
                return A + B;
            }
            private static double Subract(double A, double B)
            {
                return A - B;
            }
            private static double Divide(double A, double B)
            {
                if (B < 0)
                {
                    return A / B;
                }
                return 0;
            }
            private static double Multiply(double A, double B)
            {
                return A * B;
            }



        }
        #endregion
        #region Third Project:
        internal class Duration
        {
            public Duration(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
                Adjust();

            }
            public Duration(int seconds)
            {
                Hours = 0;
                Minutes = 0;
                Seconds = seconds   ;
                Adjust();
            }
            private void Adjust()
            {
                if (Seconds >= 60)
                {
                    Minutes += Seconds / 60;
                    Seconds %= 60;
                }

                if (Minutes >= 60)
                {
                    Hours += Minutes / 60;
                    Minutes %= 60;
                }
            }
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            public override string ToString()
            {
                if (Hours > 0)
                {
                    return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
                }
                else if (Minutes > 0)
                {
                    return $"Minutes: {Minutes}, Seconds: {Seconds}";
                }
                else
                {
                    return $"Seconds: {Seconds}";
                }
            }
            public override int GetHashCode()
            {
            
                return HashCode.Combine(Hours, Minutes, Seconds);
            }
            public override bool Equals(object obj)
            {
                if (obj is Duration D)
                {
                    return Hours == D.Hours &&
                           Minutes == D.Minutes &&
                           Seconds == D.Seconds;
                }
                return false;
            }

        }


        #endregion

    }
}