using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Collections.Specialized.BitVector32;
using System.Buffers.Text;
using System.Reflection;
using System;
using System.Text.RegularExpressions;
using System.Reflection.PortableExecutable;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Diagnostics;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.ObjectModel;

namespace C_Sharp_HashSet
{
    class Program
    {
        //SECTION 1: Features of HastSet:
        //Here are some salient features of HashSet.

        // - This class represent a set of values.
        // - This class provides high-performance set of operations.
        // - This is a set of collection that contains no duplicate elements and there is no specific order for the elements stored in it.
        // - In the .NET Framework 4.6 release, the HashSet implements IReadOnlyCollection interface along with the ISet interface.
        // - The HashSet class does not have any maximum capacity for the number of elements stored in it.This capacity keeps increasing as the number of elements are added in it.

        //SECTION 2: Eliminating Duplicates in C# HashSet:
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("Assignment: C# Using HashSet");
            Console.WriteLine();
            Console.WriteLine("Using HashSet");
            Console.WriteLine();

            //1. Defining String Array (Note that the string "mahesh" is repeated) 
            string[] names = new string[] {
                "mahesh",
                "vikram",
                "mahesh",
                "mayur",
                "suprotim",
                "saket",
                "manish"
            };

            //2. Length of Array and Printing array
            Console.WriteLine("Length of Array " + names.Length);
            Console.WriteLine();
            Console.WriteLine("The Data in Array");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            //3. Defining HashSet by passing an Array of string to it
            HashSet<string> hSet = new HashSet<string>(names);

            //4. Count of Elements in HashSet
            Console.WriteLine("Count of Data in HashSet " + hSet.Count);

            //5. Printing Data in HashSet, this will eliminate duplication of "mahesh" 
            Console.WriteLine("Data in HashSet");
            foreach (var n in hSet)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();

            //SECTION2
            //1.Declare an array of string of name names, which stores names in it.This array has a duplicate entry for string “mahesh”.
            //2.Print(s) the length of array and data in it.
            //3.Defines a HashSet of type string.This object is initialized using array which adds items in HashSet from the array automatically.
            //4.As discussed in Section 1, the HashSet object does not allow duplicate entry, hence the result will show the count of the data present in the HashSet less than the array count.
            //5.Displays the data in HashSet.
            //SECTION2


            //SECTION 3: Modify HashSet Using UnionWith() Method:
            //The UnionWith() method is used to modify the HashSet to contain all elements present in itself along with elements in other(IEnumerable) collection with which the union is established.

            //The following code is the implementation on UnionWith().

            //1.
            string[] names1 = new string[]
            {
                "mahesh","sabnis","manish","sharma","saket","karnik"
            };
            string[] names2 = new string[]
            {
                "suprotim","agarwal","vikram","pendse","mahesh","mitkari"
            };

            //2.
            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in First HashSet");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_______________________________________________________________");
            HashSet<string> hSetN2 = new HashSet<string>(names2);
            Console.WriteLine("Data in Second HashSet");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("________________________________________________________________");

            //3.
            Console.WriteLine("Data After Union");
            hSetN1.UnionWith(hSetN2);
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }

            //SECTION3
            //1. Array objects declare Names1 and Names2 which contains string data in it.
            //2. This step defines two HashSet objects hSetN1 and hSetN2 based on names1 and names2 respectively and data from both HashSet is printed.
            //3. This step calls UnionWith() method on the hSetN1 and passes hSetN2 object to it and displays all data from hSetN1 after union.
            //SECTION3


            //SECTION 4: Modify Hashset Using ExceptWith() Method:
            //This method is used to modify the HashSet by removing all elements which match with elements in another collection

            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HashSet before using Except With");
            Console.WriteLine("_________________________________");
            
            //storing data of hSetN3 in temporary HashSet
            HashSet<string> hSetN3 = new HashSet<string>(names1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using Except With");
            Console.WriteLine("_________________________________");
            hSetN3.ExceptWith(hSetN2);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }


            //SECTION 5: Modify Hashset using SymmetricExceptWith() method:
            //This method modifies the HashSet object to contain those elements which are only present in one of the two collections, but not both.
            
            //All the matching elements will be removed.

            HashSet<string> hSetN4 = new HashSet<string>(names1);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("HashSet 2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            hSetN4.SymmetricExceptWith(hSetN2);
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            //The SymmetircExceptWith() method is called on hSetN4 HashSet by passing hSetN2 HashSet to it. Both these HashSets contains a string name “mahesh”.
            //The hSetN4 will be merged with values from hSetN2 by eliminating the matching entry. After running the application, the result will be as follows:


            //SECTION 6: Checking performance of operations like Add, Remove, Contains on HashSet vs List.
            //All of the above sections have explained various methods of the HashSet.

            //But when a developer wants to make a decision for selecting the most suitable collections type based on the performance, -
            //- then it is important to check which operations are frequently performed on the collection.

            //Generally, Add, Remove, Contains are the operations that are performed on In-Memory collections.
            //To perform comparison between List vs HashSet for Add, Remove and Contains operation, the following string array is used. (Note: You can use any other data)
        }
        static string[] names = new string[] {
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
        "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
        "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
        "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
        "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
        "Leena", "Neema", "Sita",
        "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis"};

        static void Get_Add_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while Adding Item");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Add(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while Adding Item");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Add(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

            //The above method performs Add() operation on the List and HashSet by iterating strings from the names array.

            //Operation performance is calculated using the StopWatch class from System.Diagnostics namespace.

            //The List<> takes less time to add strings when compared to HashSet.
            //The reason behind this is List.Add() simply adds an item to the list whereas HashSet.Add() will skip new item if it(is)equal to one of the existing items - 
            //- This takes time to execute HashSet.Add() method as compare to List.Add() method.


            //HashSet vs List – Contains() method:
            
            static void Get_Contains_Performance_HashSet_vs_List()
            {

                Console.WriteLine("____________________________________");
                Console.WriteLine("List Performance while checking Contains operation");
                Console.WriteLine();
                List<string> lstNames = new List<string>();
                var s2 = Stopwatch.StartNew();
                foreach (string s in names)
                {
                    lstNames.Contains(s);
                }
                s2.Stop();

                Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
                Console.WriteLine("Ends Here");
                Console.WriteLine();
                Console.WriteLine("____________________________________");
                Console.WriteLine("HashSet Performance while checking Contains operation");
                Console.WriteLine();

                HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
                var s1 = Stopwatch.StartNew();
                foreach (string s in names)
                {
                    hStringNames.Contains(s);
                }
                s1.Stop();

                Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
                Console.WriteLine();
                Console.WriteLine("Ends Here");
                Console.WriteLine("____________________________________");
                Console.WriteLine();

                //The above method checks if the List and HashSet contains item passed as an input parameter to the Contains() method.
                //Run the application, the result will be shown as in the following image


                //HashSet vs List – Remove() method:

                static void Get_Remove_Performance_HashSet_vs_List()
                {

                    Console.WriteLine("____________________________________");
                    Console.WriteLine("List Performance while performing Remove item operation");
                    Console.WriteLine();
                    List<string> lstNames = new List<string>();
                    var s2 = Stopwatch.StartNew();
                    foreach (string s in names)
                    {
                        lstNames.Remove(s);
                    }
                    s2.Stop();

                    Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
                    Console.WriteLine("Ends Here");
                    Console.WriteLine();
                    Console.WriteLine("____________________________________");
                    Console.WriteLine("HashSet Performance while performing Remove item operation");
                    Console.WriteLine();

                    HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
                    var s1 = Stopwatch.StartNew();
                    foreach (string s in names)
                    {
                        hStringNames.Remove(s);
                    }
                    s1.Stop();

                    Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
                    Console.WriteLine("Ends Here");
                    Console.WriteLine("____________________________________");
                    Console.WriteLine();

                //The above method performs remove operation on List and HashSet using Remove() method.


                //The Removal operation of HashSet is faster than the List. The Remove operation also works similar to the Contains operation.
                
                //Conclusion: HashSet in C# .NET is a high-performance collection store. The advantage of using HashSet object is to perform standard operations like Union, Intersection, etc.-
                //- which provides an easy and maintainable coding experience.
                //On the other hand, List object has the feature of item ordering, duplication, etc.
                    
                //So based on the requirements of data handling, one can take a wise decision for choosing an appropriate collection.
                }
            }
        }
    }
}

   