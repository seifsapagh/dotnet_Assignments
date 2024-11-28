using System;
using System.Collections;
using System.Threading.Channels;

namespace Day08
{
  
    class Point(int x, int y)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;

        public override string ToString()
        {
            return $"{(X, Y)}";
        }
    }

    class Program {
        static void breaker(string msg)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine(msg);
            Console.WriteLine("=========================================");

        }

        public static void TestEqualityReference(Point[] array)
        {
            Console.WriteLine("Hash Codes: ");
            for (int i = 0; i < array.Length; i++)
            {
                try {
                    Console.WriteLine($"P{i} =>{array[i].GetHashCode()}");
                }
                catch
                {
                    Console.WriteLine($"Something Went Wrong on array[{i}], type = {array[i].GetType()}, value ={array[i]}");
                }
            }

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"type = {array[i].GetType()}, value ={array[i]}\n With:");
                for (int j = i + 1; j < array.Length; j++)
                {
                    string res = "";

                    string ad = "";

                    if ((i == 0 && j == 3) || (i == 3 && j == 0))
                    {
                        ad = "(clone)";
                    }

                    Console.WriteLine($"\t type = {array[j].GetType()}, Value = {array[j]} {ad}");

                    Console.Write("\t\t== : ");
                    res = array[i] == array[j] ? "Eq" : "NEQ";
                    Console.WriteLine(res);

                    Console.Write("\t\tsystem.Object : ");
                    res = object.Equals(array[i], array[j]) ? "Eq" : "NEQ";
                    Console.WriteLine(res);

                    Console.Write("\t\tVirtual Equals : ");
                    res = array[i].Equals(array[j]) ? "Eq" : "NEQ";
                    Console.WriteLine(res);

                    Console.Write("\t\tstatic ReferenceEquals : ");
                    res = object.ReferenceEquals(array[i], array[j]) ? "Eq" : "NEQ";
                    Console.WriteLine(res);
                }

            }
        }
        public static void Main()
        {

            #region Check equality between 2 Reference Dt's
            breaker("Check Equality between 2 ref Dt");
            Point p1 = new(5, 6);
            Point p2 = new(5, 6);
            Point p3 = new(1, 2);

            Point p4 = p1;

            Point[] points = { p1, p2, p3, p4 };

            // 4 Ways to check Equality
            //  ==                     [Identity]
            //  system.Object
            //  virtual Equals         [Identity]
            //  static Equals          [Identity]
            //  static ReferenceEquals  [Identity]
            TestEqualityReference(points);
            #endregion

            #region Check equality between 2 ValueT Dt's
            breaker("Check Equality between 2 Value Dt");
            //  ==                     Not Implemented , you must overload it
            //  system.Object
            //  virtual Equals         [values][state]  override to ensure performance 
            //  static Equals          [values][state]
            //  static ReferenceEquals Doesn't NOT WORK PROPERLY
            #endregion

            #region Create Single Object From class  design patterns[SingleTon]
            Network_Card Crd = Network_Card.getCard();
            Network_Card Crd2 = Network_Card.getCard();

            Console.WriteLine(Crd.GetHashCode());
            Console.WriteLine(Crd2.GetHashCode()); // same as the other instance


            Network_Card Crd3 = Network_Card.Card;
            Network_Card Crd4 = Network_Card.Ncard;
            Network_Card Crd5 = Network_Card.Scard;
            Network_Card Crd6 = Network_Card.SScard;
            Console.WriteLine(Crd3.GetHashCode());
            Console.WriteLine(Crd4.GetHashCode());

            // these 2 are different only because its a completely different data field
            // The property created a data field with the name scard and sScard hence creating other objects
            // this behavior won't happen in a real case because you'd be using only one of the methods explained
            Console.WriteLine(Crd5.GetHashCode());
            Console.WriteLine(Crd6.GetHashCode());

            #endregion

            #region Generics
            breaker("Generics");

            // Generics are the same concept as C++ Templates
            Generic<string> gr = new();
            gr.show("hello");
            Generic<int> gr1 = new();
            // gr1.show("hey"); // this results in an error since the Generic type is specified as int not string
            gr1.show(10);


            // Generics have constraints to limit the types passed to the class
            // for example u can limit to a class or struct, a type that implements a certain interface like IEnumerable..etc
            // u can also use new() to limit to types that have a parameterless  constructor
            // Note: Structs always have a default parameterless  constructor so structs match the new() constraints in generics
            #endregion

            #region Array Big Issue
            // Arrays are fixed size
            // this can be solved using collections like List and ArrayList that are almost identical to Arrays

            #endregion

            #region Non Generic Collection 
            breaker("Non-Generic Collections");
            // An example of this is Array Lists
            // found in System.Collections;

            // Doesn't support type safety
            // heterogenous collection, able to store objects of different data types

            ArrayList ls = new ArrayList { 1, 2.5, true, new Point(5, 10), "test" };
            foreach (var item in ls)
            {
                Console.WriteLine($"{item}, {item.GetType()}");
            }

            // Flexible size
            Console.WriteLine(ls.Capacity);
            ls.Add(50); // Add a single item
            ls.AddRange(new int[] { 10, 20, 30 }); // add multiple items
            Console.WriteLine(ls.Capacity); // Capacity Increased
            Console.WriteLine();
            foreach (var item in ls)
            {
                Console.WriteLine($"{item}, {item.GetType()}");
            }



            #endregion

            #region Generic Collections
            #region List
            breaker("Generic Collections");
            // Found in system.Collections.Generic
            // Homogenous collection, stores objects of the same data type only

            List<int> LS = new List<int>(5); // initial capacity
            // Like in array we can use new() on the right side
            Console.WriteLine(LS.Capacity);

            Console.WriteLine(LS.Count); // List is empty
            for (int i = 0; i < 6; i++)
            {
                LS.Add(i * 10);
            }
            // LS[1000] = 5; Runtime Error

            foreach (int item in LS)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Capacity: " + LS.Capacity);
            LS.TrimExcess(); // remove unused memory
            Console.WriteLine("Capacity: " + LS.Capacity);
            #endregion

            #region Dictionary
            breaker("Dictionary");
            Dictionary<int, string> dict = new() { { 1, "50" }, {912,"90" } }; // Dictionary is a collection of key,value Pairs
            dict[500] = "hello world"; // Runtime Insertion works

            foreach(KeyValuePair<int,string> x in dict)
            {
                Console.WriteLine(x.Key+":"+ x.Value);
            }
            #endregion
            #endregion
        }
    }
}
    
