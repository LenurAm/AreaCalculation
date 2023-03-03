using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Contracts
{
    public interface IFigure
    {
        //int[] Sides { get; set; }
        int NumberOfSides(int[] Sides);

        int Area(int[] Sides);

    }
}
