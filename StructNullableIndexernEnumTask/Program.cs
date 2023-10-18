using StructNullableIndexernEnumTask.Models;

namespace StructNullableIndexernEnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt myList = new ListInt();
            myList.Add(52);
            myList.AddRange(10, 52, 52);
            Console.WriteLine( myList.ToString());
            Console.WriteLine(myList.Sum());
            Console.WriteLine(myList.Contains(10));
        }
    }
}