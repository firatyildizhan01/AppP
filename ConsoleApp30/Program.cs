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
            Ogrenci mbd = new Ogrenci();
            //mbd.AD = "fırat";
            mbd.SOYAD = "yıldızhan";
            mbd.MEMLEKET = "diyarbakır";
            mbd.YAS = -34;
            mbd.CİNSİYET = 'e';
            Console.WriteLine();
            Console.WriteLine(mbd.AD);
            Console.WriteLine(mbd.SOYAD);
            Console.WriteLine(mbd.MEMLEKET);
            Console.WriteLine(mbd.YAS);
            Console.WriteLine(mbd.CİNSİYET);
            Console.ReadLine();
        }
    }
}
