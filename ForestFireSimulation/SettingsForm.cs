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

        public SettingsForm(int currentWidth, int currentHeight, double currentSpreadProbability)
        {
            InitializeComponent();

            // Ustawienie domyślnych wartości
            txtGridWidth.Text = currentWidth.ToString();
            txtGridHeight.Text = currentHeight.ToString();
            trackBarSpreadProbability.Value = (int)currentSpreadProbability * 10;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                GridWidth = int.Parse(txtGridWidth.Text);
                GridHeight = int.Parse(txtGridHeight.Text);
                SpreadProbability = trackBarSpreadProbability.Value / 10;
                TreeProbability = trackBarTreeProbability.Value / 10;

                if (GridWidth <= 0 || GridHeight <= 0)
                {
                    MessageBox.Show("Grid size must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult = DialogResult.OK; // Zatwierdzenie zmian
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Anulowanie zmian
            Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
