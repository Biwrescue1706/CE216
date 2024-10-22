namespace Abstract_and_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Console.WriteLine($"Area of circle = {c.GetArea()}");

            Ring r = new Ring(5,6);
            Console.WriteLine($"Area of ring = {r.GetArea()}");
        }
    }
}
