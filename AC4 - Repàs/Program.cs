using System.Collections;
using System.Diagnostics;

namespace AC4R
{
    public class Program
    {
        public static bool InRange(int num, int min, int max)
        {
            return (num >= min && num <= max);
        }

        public static void Main()
        {
            // EXERCICI 3
            Dictionary<string, int> ages = new Dictionary<string, int>();
            int age = 0;
            int numElements = 0;
            string name = "";

            Console.Write("Quants elements vols guardar? ");
            numElements = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numElements; i++)
            {
                Console.Write("Type your name: ");
                name = Console.ReadLine();
                do
                {
                    Console.Write("Type your age (above 0): ");
                    age = Convert.ToInt32(Console.ReadLine());
                } while (!InRange(age, 0, 200));
                ages.Add(name, age);
            }

            foreach (var element in ages)
            {
                Console.WriteLine("Name: {0}\nAge: {1}\n", element.Key, element.Value);
            }
        }
    }
}
