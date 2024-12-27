using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ForestFireSimulation
{
    public partial class MainForm : Form
    {
        private ForestGrid _forest;
        private GridRenderer _gridRenderer;
        private Timer _timer;
        private double _spreadProbability = 0.6;

        public MainForm()
        {
            InitializeComponent();
            InitializeSimulation();
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;


        }

        private void InitializeSimulation()
        {
            _forest = new ForestGrid(20, 40);
            _forest.IgniteRandomTree();
            gridRenderer.Forest = _forest;

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += (sender, e) => UpdateSimulation();
        }

        private void UpdateSimulation()
        {
            _forest.Update(_spreadProbability);
            gridRenderer.Invalidate();
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
                gridRenderer.Forest = _forest;
                _timer.Stop();
                gridRenderer.Invalidate();
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
            _timer.Stop();
            InitializeSimulation();
            gridRenderer.Invalidate();
        }
    }
}

