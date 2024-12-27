using System;
using System.Windows.Forms;

namespace ForestFireSimulation
{
    public partial class SettingsForm : Form
    {
        public int GridWidth { get; private set; }
        public int GridHeight { get; private set; }
        public double SpreadProbability { get; private set; }
        public double TreeProbability { get; private set; }

        public SettingsForm(int currentWidth, int currentHeight, double currentSpreadProbability, double currentTreeProbability)
        {
            InitializeComponent();

            txtGridWidth.Text = currentWidth.ToString();
            txtGridHeight.Text = currentHeight.ToString();
            trackBarSpreadProbability.Value = (int)(currentSpreadProbability * 10);
            trackBarTreeProbability.Value = (int)(currentTreeProbability * 10);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                GridWidth = int.Parse(txtGridWidth.Text);
                GridHeight = int.Parse(txtGridHeight.Text);
                SpreadProbability = ((double)trackBarSpreadProbability.Value / 10);
                TreeProbability = ((double)trackBarTreeProbability.Value / 10);

                if (GridWidth <= 0 || GridHeight <= 0)
                {
                    MessageBox.Show("Rozmiar siatki musi być większy od 0.", "Nieprawidłowa wartość", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Podane wartości muszą być liczbami całkowitymi.", "Nieprawidłowy typ danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

}
