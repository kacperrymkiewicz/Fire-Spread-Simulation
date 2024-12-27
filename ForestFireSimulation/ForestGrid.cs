using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestFireSimulation
{
    public class ForestGrid
    {
        private readonly int _rows;
        private readonly int _cols;
        private readonly Cell[,] _grid;
        private readonly Random _random = new Random();

        public ForestGrid(int rows, int cols, double treeProbability = 0.5)
        {
            _rows = rows;
            _cols = cols;
            _grid = new Cell[rows, cols];
            InitializeGrid(treeProbability);
        }

        private void InitializeGrid(double treeSpawnProbability)
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    _grid[i, j] = new Cell(_random.NextDouble() < treeSpawnProbability ? CellState.Tree : CellState.Burned);
                }
            }
        }

        public void IgniteRandomTree()
        {
            while (true)
            {
                int row = _random.Next(_rows);
                int col = _random.Next(_cols);
                if (_grid[row, col].State == CellState.Tree)
                {
                    _grid[row, col].State = CellState.Burning;
                    break;
                }
            }
        }

        public void Update(double probability)
        {
            var newGrid = new Cell[_rows, _cols];

            // Skopiuj obecny stan do nowej siatki
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    newGrid[i, j] = new Cell(_grid[i, j].State);
                }
            }

            // Aktualizacja stanu w nowej siatce
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (_grid[i, j].State == CellState.Tree && HasBurningNeighbor(i, j) && _random.NextDouble() < probability)
                    {
                        newGrid[i, j].State = CellState.Burning;
                    }
                    else if (_grid[i, j].State == CellState.Burning)
                    {
                        newGrid[i, j].State = CellState.Burned;
                    }
                }
            }

            // Przepisanie nowego stanu do głównej siatki
            Array.Copy(newGrid, _grid, _grid.Length);
        }


        private bool HasBurningNeighbor(int row, int col)
        {
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i >= 0 && i < _rows && j >= 0 && j < _cols && _grid[i, j].State == CellState.Burning)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool HasBurningTrees()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (_grid[i, j].State == CellState.Burning)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Cell[,] GetGrid() => _grid;
        public int Width => _grid.GetLength(1);
        public int Height => _grid.GetLength(0);

    }
}
