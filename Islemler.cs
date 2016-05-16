using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
}