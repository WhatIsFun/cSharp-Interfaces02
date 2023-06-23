namespace cSharp_Interface02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(3);
            Square square1 = new Square(2);

            Console.WriteLine(square.CompareTo(square1));
        
            int[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int a = 0; a < i.Length; a++)
            {
                Console.WriteLine(i[a]);
            }

            Console.WriteLine("Printing for each");
            Person[] persons = new Person[5];
            persons[0] = new Person("A", "32", 43);
            persons[1] = new Person("A", "32", 43);
            persons[2] = new Person("A", "32", 43);
            persons[3] = new Person("A", "32", 43);
            persons[4] = new Person("A", "32", 43);
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }

    }
}