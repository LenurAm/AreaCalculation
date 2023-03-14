using Figures.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
	public class Circle : ICircle
	{
		
		
		public int[] radius;
		public double Area(int[] radius)
		{
			return Math.Round((Math.PI * radius[0] * radius[0]),2);
		}

		public int NumberOfSides(int[] Sides)
		{
			return radius.Length;
		}
	}
}
