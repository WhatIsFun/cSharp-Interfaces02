namespace cSharp_Interface02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(3);
            Square square1 = new Square(2);

            Console.WriteLine(square.CompareTo(square1));
        }
    }
}