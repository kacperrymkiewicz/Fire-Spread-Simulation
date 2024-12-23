using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestFireSimulation
{
    public enum CellState
    {
        Tree,
        Burning,
        Burned
    }

    public class Cell
    {
        public CellState State { get; set; }

        public Cell(CellState initialState)
        {
            State = initialState;
        }
    }
}
