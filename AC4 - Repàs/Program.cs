using System.Collections;
using System.Diagnostics;

namespace AC4R
{
    public class Program
    {
        public static void Main()
        {
            // EXERCICI 1
            Parella<string, int> one = new Parella<string, int>("Sera", 1);
            Parella<double, bool> two = new Parella<double, bool>(23.5, false);

            one.MostraInfo();
            two.MostraInfo();
        }
    }
}