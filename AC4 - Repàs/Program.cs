using System.Collections;
using System.Diagnostics;

namespace AC4R
{
    public class Program
    {
        public static void Main()
        {
            // EXERCICI 4
            int numElements = 0;

            List<string> names = new List<string>();
            Console.Write("Quants elements vols guardar? ");
            numElements = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numElements; i++)
            {
                Console.Write("Escriu valor: ");
                names.Add(Console.ReadLine());
            }
            names.Sort();
            foreach (var element in names)
            {
                Console.WriteLine(element);
            }
        }
    }
}