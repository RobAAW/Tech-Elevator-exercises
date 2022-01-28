namespace Exercises.Classes
{
    public class FruitTree
    {

        public string TypeOfFruit { get; private set; }

        public int PiecesOfFruitLeft { get; private set; }
        //public int StartingPiecesOfFruit { get; private set; }

        public FruitTree (string typeOfFruit, int startingPiecesOfFruit)
        {
            TypeOfFruit = typeOfFruit;
            PiecesOfFruitLeft = startingPiecesOfFruit;
        }
        
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (PiecesOfFruitLeft >= numberOfPiecesToRemove)
            {
                PiecesOfFruitLeft = PiecesOfFruitLeft - numberOfPiecesToRemove;
                PiecesOfFruitLeft = PiecesOfFruitLeft;
                return true;
            }
            else if (PiecesOfFruitLeft < numberOfPiecesToRemove)
            {
                
                return false;
            }
            return false;
        }


    }
}
