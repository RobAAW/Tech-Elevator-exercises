namespace Lecture.Farming
{
    public class Cow : FarmAnimal, ISellable
    {

        public decimal Price { get; } 
        public Cow(decimal price) : base("Cow", "moo")
        {
            Price = price;
        }
    }
}
