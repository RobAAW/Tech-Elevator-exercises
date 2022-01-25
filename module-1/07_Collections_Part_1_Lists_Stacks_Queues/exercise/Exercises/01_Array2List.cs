﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of Strings, return a List containing the same Strings in the same order
        Array2List( {"Apple", "Orange", "Banana"} )  ->  ["Apple", "Orange", "Banana"]
        Array2List( {"Red", "Orange", "Yellow"} )  ->  ["Red", "Orange", "Yellow"]
        Array2List( {"Left", "Right", "Forward", "Back"} )  ->  ["Left", "Right", "Forward", "Back"]
        */
        public List<string> Array2List(string[] stringArray)
        {

            List<string> listFromArray = new List<string>();
            

            /*for (int i = 0; i < stringArray.Length; i++)
            {
                listFromArray.Add(stringArray[i]);
            }*/

            foreach(string singleString in stringArray)
            {
                listFromArray.Add(singleString);
            }
            return listFromArray;
        }
    }
}
