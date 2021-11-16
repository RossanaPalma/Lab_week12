/// Chapter No. 24 - Lab_week12
/// File Name: Lab_week12.java
/// @author: Rossana Palma
/// Date:  November 15, 2021
///
/// Problem Statement: Create a phone lookup program. You should have the ability to add,
/// delete, and find phones number. The key will be a person’s name, for the example use 
/// just a first name and this will retrieve a person’s phone number. Use the Dictionary 
/// Collection.
/// 
/// Overall Plan:
/// 1) Create a dictionary and add elements
/// 2) Display the elements of the dictionary
/// 3) Remove an element of the dictionary and display the updated dictionary
/// 4) Find for an element using the key that is person's name. Display its phone number.
///


using System;
using System.Collections.Generic;

namespace Lab_week12
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mydict1 = new Dictionary<string,string>();
            mydict1.Add("Paul", "6198762366");
            mydict1.Add("John", "8587865525");
            mydict1.Add("Carrie", "6199821765");
            mydict1.Add("Maria", "8583298547");
            
            //Display phone list
            foreach(KeyValuePair<string, string> ele1 in mydict1)
            {
                Console.WriteLine("Name: {0} \tphone number: {1}", ele1.Key, ele1.Value);
            }



            Dictionary<string, string> mydict2 = new Dictionary<string, string>();

            //Remove
            Console.WriteLine("\nAfter removing one element:");
            mydict1.Remove("John");

            //Display phone list
            foreach (KeyValuePair<string, string> ele1 in mydict1)
            {
                
                Console.WriteLine("Name: {0} \tphone number: {1}", ele1.Key, ele1.Value);
            }


            //Find number
            Console.WriteLine("\nLooking for phone number of the element:");
            if(mydict1.ContainsKey("Carrie"))
            {
                //Console.WriteLine("Found it");
                Console.WriteLine(mydict1["Carrie"]);

            }
            else
            {
                Console.WriteLine("not found");
            }



            Console.ReadLine();

        }
    }
}
