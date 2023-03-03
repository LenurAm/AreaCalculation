using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Contracts
{
    public interface ITriangle: IFigure
    {
        bool IsTriangle(int[]Sides);
        bool IsTriangleRight(int[] Sides);
        int[] GetSides(int x, int y, int z);


	}
}
