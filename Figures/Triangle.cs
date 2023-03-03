using Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
	public class Triangle : ITriangle
	{
		public int x;
		public int y; 
		public int z;
		public int[] sides;

		

        public int[] GetSides(int x, int y, int z)
		{
			
			sides[0] = x;
			sides[1] = y;
			sides[2] = z;
			return sides;
		}
		
        public int Area(int[]sides)
		{
			int semi = ((sides[0] + sides[1] + sides[2]) / 2);

			return (int)(Math.Sqrt(semi * (semi - sides[0]) * (semi - sides[1]) * (semi - sides[2])));
		}
				
		public bool IsTriangle(int[] Sides)
		{
			if (((Sides[0] + Sides[1]) < Sides[2]) ||
							((Sides[1] + Sides[2]) < Sides[0]) ||
							((Sides[0] + Sides[2]) < Sides[1]))
			{
				return false;
			}
			return true;
		}
						

		public bool IsTriangleRight(int[] Sides)
		{
			if ((Sides[2] == Math.Sqrt((Sides[0] * Sides[0]) + (Sides[1] * Sides[1]))) ||
								(Sides[1] == Math.Sqrt((Sides[0] * Sides[0]) + (Sides[2] * Sides[2]))) ||
								(Sides[0] == Math.Sqrt((Sides[1] * Sides[1]) + (Sides[2] * Sides[2]))))
							{
								return true;
							}
			return false;
		}

		public int NumberOfSides(int[] Sides)
		{
			return Sides.Length;
		}

	}
}
	