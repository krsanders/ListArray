﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array
            string[] food = new string[10];
            string[] foo2 = ("taco", "pizza" );
            food[1] = "taco";
            food[1] = "pizza";
            Console.WriteLine(food[0]);

            int[] nums = new int[3];

            //Lists
            List<string> foodList = new List<string>() ("taco", "pizza");
            foodList.Add("ice cream");
            foodList.Add("cheeseburger");
            foodList.Add("hamburger");

            //Add at an index
            foodList.Insert(0, "apple");

            //replace value
            foodList[2] = "banana";

            //Get values from List
            string temp = foodList.ElementAt(3);
            string temp2 = foodList[3];

            //Get a value by name: This specifically comes in later
            for (int i = 0; i < foodList.Count; i++)
			{
			    if(foodList.ElementAt(i).Equals("apple"))
                {
                    one = foodList.ElementAt(i);
                }
			}

            // using Contains
            List<string>burgers = new List<string>();
            for (int i = 0; i < foodList.Count; i++)
			{
			    if (foodList.ElementAt(i).Contains("burger"))
			    {
                    //store elements containing burger
                    burgers.Add(foodList.ElementAt(i));
                }  
            }
            //sorting
            foodList.Sort(); //alphabetic
            foodList.Reverse(); //reverses (alphabetic) order of items within a list
            
            string first = foodList.First();
            string last = foodList.Last();

            //removing elements: It's much better to look first into a List & find something before deleting it.
            foodList.Remove("apple");
            foodList.RemoveAt(3);
            foodList.Clear(); //erases everything in the List


            //keep the console open
            Console.ReadKey();
        }
    }
}
