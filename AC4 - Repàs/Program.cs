using System.Collections;
using System.Diagnostics;

namespace AC4R
{
    public class Program
    {
        public static void Main()
        {
            // EXERCICI 2
            int numElements = 0;

            ArrayList arr = new ArrayList();
            Console.Write("Quants elements vols guardar? ");
            numElements = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numElements; i++)
            {
                Console.Write("Escriu valor: ");
                arr.Add(Console.ReadLine());
            }
            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
