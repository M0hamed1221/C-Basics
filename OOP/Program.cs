using System.Reflection.Metadata.Ecma335;

namespace oop_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        #region part 01  inheriatence
        internal class Parent
        {
            public Parent(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }
            public override string ToString()
            {
                return $" X ={X} , Y = {Y} ";
            }
            public virtual int product()
            {
                return X * Y;
            }

        }
        internal class Chlid : Parent
        {
            public Chlid(int x, int y, int z) : base(x, y)
            {
                Z = z;
            }
            public int Z { get; set; }

            public override string ToString()
            {
                return base.ToString() + $"Z ={Z}";
            }
            public override int product()
            {
                return base.product() * Z;
            }
        }

        #endregion
        #region part 2  Access Modifiers

        internal class TypeA
        {
            public TypeA(int a, int b, int c, int d, int e)
            {
                A = a;
                B = b;
                C = c;
                D = d;
                E = e;
            }

            public int A { get; set; }
            private int B { get; set; }

            protected int C { get; set; } /* the member is accessible with class*/
            private protected int D { get; set; }  /* the member is accessible with class*/

            protected internal int E { get; set; }/* the member is accessible with assembly*/

        }
        internal class TypeB : TypeA
        {
            public TypeB(int a, int b, int c, int d, int e, int f, int g) : base(a, b, c, d, e)
            {
                F = f;
                G = g;
            }

            /* inherate A , E */
            public int F { get; set; }
            public int G { get; set; }

        }

        #endregion
        #region part 3  Relation Between Classes

        internal class Porduct
        {
            public int ID { get; set; }
            public required string Name { get; set; }
            public decimal UintPrice { get; set; }

            public int UnitOfStock { get; set; }
        }
        /*Association RelationShip of type Composition  : if no product , no order item  */
        internal class OrderItem
        {
            //public OrderItem(int iD, Porduct porduct)
            //{
            //    ID = iD;
            //    Porduct = porduct;
            //}

            public int ID { get; set; }
            public required Porduct Porduct { get; set; }
        }
        internal class OrderI
        {
            public int ID { get; set; }

            public required string UserEmail { get; set; }

            public decimal OrderTotal { get; set; }

            public required List<OrderItem>? Items { get; set; }
        }

        internal class Employee

        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int age { get; set; }
            public decimal salary { get; set; }
        }

        internal class Department

        {
            public int Code { get; set; }
            public required string Name { get; set; }
            /* OPtional*/

            public List<Employee>? Employees { get; set; }
        }
        #endregion

    }
}