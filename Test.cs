using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestCalculator
{
    class Test
    {
        static void Main(string[] args)
        {

        	Islemler islem = new Islemler();
        	int sayiA, sayiB;
        	sayiA = Console.ReadLine();
        	sayiB = Console.ReadLine();
        	Console.WriteLine("Toplalama="+ilem.Toplama(sayiA,sayiB));
        	Console.WriteLine("Çıkarma="+ilem.Cikarma(sayiA,sayiB));
        	Console.WriteLine("Bölme="+ilem.Bolme(sayiA,sayiB));
        	Console.WriteLine("çarpma="+ilem.carpma(sayiA,sayiB));
        }
    }
}
    