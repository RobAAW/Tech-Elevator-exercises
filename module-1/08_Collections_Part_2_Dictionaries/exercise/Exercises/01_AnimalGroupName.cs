using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {

            if (animalName == null)
            {
                return "unknown";
            }

            Dictionary<string, string> animalHerds = new Dictionary<string, string>();

            animalHerds["rhino"] = "Crash";
            animalHerds["giraffe"] = "Tower";
            animalHerds["elephant"] = "Herd";
            animalHerds["lion"] = "Pride";
            animalHerds["crow"] = "Murder";
            animalHerds["pigeon"] = "Kit";
            animalHerds["flamingo"] = "Pat";
            animalHerds["deer"] = "Herd";
            animalHerds["dog"] = "Pack";
            animalHerds["crocodile"] = "Float";

            
            
            string searchAnimal = animalName.ToLower();
            
            if (animalHerds.ContainsKey(searchAnimal))
            {
                return animalHerds[searchAnimal];
            }
            
            

            return "unknown";
       


        }
    }
}
