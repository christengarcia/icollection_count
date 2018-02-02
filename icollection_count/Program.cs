﻿/*
 *  C# Program to Demonstrate the icollection Count
 */
using System;
using System.Collections;

namespace icollection_count
{
    public class CountArray
    {
        public static void Main()
        {
            string[] strings = { "Ajax", "Atlas", "a", "b" };
            DisplayCollectionProperty(strings);
            Console.ReadLine();
        }

        public static void DisplayCollectionProperty
           (ICollection iCollection)
        {
            Console.WriteLine("Count = {0}", iCollection.Count);
        }
    }
}
