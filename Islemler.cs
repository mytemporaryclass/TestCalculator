using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD

namespace TestCalculator
{
	class Islemler
	{
		public void Toplama(int sayi1,int sayi2)
		{
			return sayi1+sayi2;
		}
		public void Bolme(int sayi1,int sayi2)
		{
			if(sayi2!=0)
			{
				return sayi1/sayi2;

			}
			else
			{
				return 0;


			}

		}

	}
=======
using System.Threading.Tasks;
using BilgiKontrolLib;

namespace TestCalculater
{
    class Islemler
    {
        public int  Cikarma(int sayi1,int sayi2)
        {
        	return sayi1-sayi2;
        }

        public int carpma(int sayi1,int sayi2)
        {
        	return sayi1*sayi2;
        } 
    }
>>>>>>> 65b4ff500d9139d85fb53fbaa3fffbb210edc82f
}