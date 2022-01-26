﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of Strings, return a List containing the same Strings in the same order
        except for any words that contain exactly 4 characters.
        No4LetterWords( {"Train", "Boat", "Car"} )  ->  ["Train", "Car"]
        No4LetterWords( {"Red", "White", "Blue"} )  ->  ["Red", "White"]
        No4LetterWords( {"Jack", "Jill", "Jane", "John", "Jim"} )  ->  ["Jim"]
        */
        public List<string> No4LetterWords(string[] stringArray)
        {

            List<string> listFromArray = new List<string>();

           // string noFours = "";
            
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length != 4)
                {
                    //noFours += i;
                    listFromArray.Add(stringArray[i]);
                }
            }
            return listFromArray;
 
        }
    }
}
