using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestFireSimulation
{
    public class GridRenderer : Control
    {
        private ForestGrid _forest;

        public ForestGrid Forest
        {
            get => _forest;
            set
            {
                _forest = value;
                Invalidate();
            }
        }

        public GridRenderer()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (_forest == null) return;

            var graphics = e.Graphics;
            var grid = _forest.GetGrid();
            int cellSize = 40;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Brush brush = grid[i, j].State switch
                    {
                        CellState.Tree => Brushes.Green,
                        CellState.Burning => Brushes.Red,
                        CellState.Burned => Brushes.Black,
                        _ => Brushes.Gray,
                    };

                    graphics.FillRectangle(brush, j * cellSize, i * cellSize, cellSize, cellSize);
                    graphics.DrawRectangle(Pens.White, j * cellSize, i * cellSize, cellSize, cellSize);
                }
            }
        }
    }

}
