using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
	class StartKlass
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tere tulemast");
			string eesnimi = Console.ReadLine();
			Console.WriteLine("Tere," + eesnimi);
			if (eesnimi.ToLower()=="juku")
			{
				Console.WriteLine("Tule minu juurde külla! Lähme kinno! Kui vana sa oled? {}",eesnimi);
				int vanus = int.Parse(Console.ReadLine());
				if (vanus < 0 || vanus > 120)
				{
					Console.WriteLine("Viga andmetega!");
				}
				else if(vanus<=6)
				{
					Console.WriteLine("Tasuta pilet!");
				}
				else if(vanus>6 && vanus<=14)
				{
					Console.WriteLine("Lastepilet!");
				}
				else if(vanus>15 && vanus<=65)
				{
					Console.WriteLine("Täispilet!");
				}
				else if(vanus> 65)
				{
					Console.WriteLine("Sooduspilet!");
				}
				
			}

			else
			{
				Console.WriteLine("Täna mind kodus pole!");
			}

			int arv1 = int.Parse(Console.ReadLine());
			int arv2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);

			Console.WriteLine("Tere," + eesnimi);
			if (eesnimi.ToLower() == "Alia")
			Console.WriteLine("Tere," + eesnimi);
			if (eesnimi.ToLower() == "Darja")
			Console.WriteLine("Tere," + eesnimi);
			if (eesnimi.ToLower() == "Sofija")

			Console.WriteLine("Kirjuta cm1 sein");
			decimal cm1=Math.Abs(int.Parse(Console.ReadLine()));
			Console.WriteLine("Kirjuta cm2 sein");
			decimal cm2=Math.Abs(int.Parse(Console.ReadLine()));

			Console.WriteLine("Põranda pindala");
			Console.WriteLine(cm1 * cm2 + "cm2");
			Console.WriteLine("Kas tahad remondi teha?");
			string otvet = Console.ReadLine();
			if(otvet=="jah")
			{
				Console.WriteLine("Kui suur ruud meetri hind?");
				decimal hind = decimal.Parse(Console.ReadLine());
				Console.WriteLine(Math.Round(hind * ((cm1/100) *(cm2/100)),2) + "- summa");

			}

			Console.WriteLine("Kirjuta temperatuur");
			decimal temp = decimal.Parse(Console.ReadLine());
			if (temp>18)
			{
				Console.WriteLine(temp + "See väike temperatuur");
			}
			else if (temp>18)
			{
				Console.WriteLine(temp + "See suur temperatuur");
			}
			else if (temp==18)
			{
				Console.WriteLine(temp + "See normaalne temperatuur");
			}



				Console.ReadLine();
		}
	}
}
