using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2._3
{
	class Program
	{
		static void Main(string[] args)
		{
			int Numero1, numero2, numero3;
			Console.WriteLine("Introducir primer numero:");
			Numero1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Introducir segundo numero:");
			numero2 = int.Parse(Console.ReadLine());

			Console.WriteLine("Introducir tercer numero:");
			numero3 = int.Parse(Console.ReadLine());

			if (Numero1 * numero2 == numero3)
			{
				Console.WriteLine("El valor de el tercer numero es la multiplicacion de los dos primeros");
			}
			else
			{
				Console.WriteLine("El tercer número NO es la multiplicación de los dos primeros");
			}
			Console.ReadKey();

		}
	}
}
