using Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
	public class Rectangle : IRectangle
	{
		public int x;
		public int y;
		public int[] sides;



		public int[] GetSides(int x, int y)
		{

			sides[0] = x;
			sides[1] = y;
			return sides;
		}




		public double Area(int[] sides)
		{
			return sides[0] * sides[1];
		}

		

		public int NumberOfSides(int[] Sides)
		{
			return sides.Length;
		}
	}
}
