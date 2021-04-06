using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            kisiler kb = new kisiler();
            string abd;
            string abd1;
            string abd2;
            string abd3;
            Console.WriteLine("istenilen değerleri yapınız");
            abd = Console.ReadLine();
            abd1 = Console.ReadLine();
            abd2 = Console.ReadLine();
            abd3 = Console.ReadLine();
            kb.kisilerListe(abd, abd1, abd2, abd3);

            Console.ReadLine();


        }
    }
}
