using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ForestFireSimulation
{
    public partial class MainForm : Form
    {
        private ForestGrid _forest;
        private Timer _timer;
        private double _spreadProbability = 0.6;

        public MainForm()
        {
            InitializeComponent();
            InitializeSimulation();
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen; // Środek ekranu
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;    // Rozmiar roboczy ekranu
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; // Początek okna

        }

        private void InitializeSimulation()
        {
            _forest = new ForestGrid(20, 40);
            _forest.IgniteRandomTree();

            _timer = new Timer();
            _timer.Interval = 1000; // 500 ms
            _timer.Tick += (sender, e) => UpdateSimulation();

            this.Paint += (sender, e) => DrawForest(e.Graphics);
        }

        private void UpdateSimulation()
        {
            _forest.Update(_spreadProbability);
            Invalidate();
        }

        private void DrawForest(Graphics graphics)
        {
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartSimulation();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopSimulation();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSimulation();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm(_forest.Width, _forest.Height, _spreadProbability);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                _spreadProbability = settingsForm.SpreadProbability;
                _forest = new ForestGrid(settingsForm.GridHeight, settingsForm.GridWidth);
                _forest.IgniteRandomTree();
                Invalidate(); // Odświeżenie widoku
            }
        }


        private void StartSimulation()
        {
            _timer.Start();
        }

        private void StopSimulation()
        {
            _timer.Stop();
        }

        private void ResetSimulation()
        {
            _timer.Stop(); // Zatrzymanie timera
            InitializeSimulation(); // Ponowne ustawienie początkowego stanu
            Invalidate(); // Odświeżenie wizualizacji
        }
    }
}

