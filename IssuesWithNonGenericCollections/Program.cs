using System;
using System.Collections;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithArrayList();

            Console.ReadKey();
        }

        static void SimpleBoxUnboxOperation()
        {
            // Make a ValueType (int) variable.
            int myInt = 25;

            // Box the object into an object reference.
            object boxedInt = myInt;

            // Unbox the reference into a corresponding int.
            int unboxedInt = (int)boxedInt;
        }

        static void WorkWithArrayList()
        {
            // Value types are automatically boxed when passed to a method requesting an object.
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);

            // Unboxing occurs when an object is converted back to stack-based data.
            int i = (int)myInts[0];

            // Now it is reboxed, as WriteLine() requires object types.
            Console.WriteLine("Value of your int: {0}", i);
        }
    }
}
