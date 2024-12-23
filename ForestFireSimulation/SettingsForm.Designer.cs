namespace ForestFireSimulation
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnApply = new Button();
            txtGridWidth = new TextBox();
            txtGridHeight = new TextBox();
            trackBarSpreadProbability = new TrackBar();
            trackBarTreeProbability = new TrackBar();
            groupBoxMapSize = new GroupBox();
            btnCancel = new Button();
            labelMapWidth = new Label();
            labelMapHeight = new Label();
            groupBox1 = new GroupBox();
            labelSpreadProbability = new Label();
            labelTreeProbability = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarSpreadProbability).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTreeProbability).BeginInit();
            groupBoxMapSize.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnApply
            // 
            btnApply.Location = new Point(292, 400);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(94, 29);
            btnApply.TabIndex = 0;
            btnApply.Text = "Zapisz";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // txtGridWidth
            // 
            txtGridWidth.Font = new Font("Segoe UI", 9F);
            txtGridWidth.Location = new Point(130, 47);
            txtGridWidth.Name = "txtGridWidth";
            txtGridWidth.Size = new Size(125, 27);
            txtGridWidth.TabIndex = 1;
            txtGridWidth.Text = "20";
            // 
            // txtGridHeight
            // 
            txtGridHeight.Font = new Font("Segoe UI", 9F);
            txtGridHeight.Location = new Point(130, 97);
            txtGridHeight.Name = "txtGridHeight";
            txtGridHeight.Size = new Size(125, 27);
            txtGridHeight.TabIndex = 2;
            txtGridHeight.Text = "40";
            // 
            // trackBarSpreadProbability
            // 
            trackBarSpreadProbability.Location = new Point(236, 54);
            trackBarSpreadProbability.Name = "trackBarSpreadProbability";
            trackBarSpreadProbability.Size = new Size(295, 56);
            trackBarSpreadProbability.TabIndex = 3;
            trackBarSpreadProbability.Value = 1;
            trackBarSpreadProbability.Scroll += trackBar1_Scroll;
            // 
            // trackBarTreeProbability
            // 
            trackBarTreeProbability.Location = new Point(236, 116);
            trackBarTreeProbability.Name = "trackBarTreeProbability";
            trackBarTreeProbability.Size = new Size(296, 56);
            trackBarTreeProbability.TabIndex = 4;
            trackBarTreeProbability.Scroll += trackBar1_Scroll_1;
            // 
            // groupBoxMapSize
            // 
            groupBoxMapSize.Controls.Add(labelMapHeight);
            groupBoxMapSize.Controls.Add(labelMapWidth);
            groupBoxMapSize.Controls.Add(txtGridWidth);
            groupBoxMapSize.Controls.Add(txtGridHeight);
            groupBoxMapSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxMapSize.Location = new Point(28, 27);
            groupBoxMapSize.Name = "groupBoxMapSize";
            groupBoxMapSize.Size = new Size(736, 151);
            groupBoxMapSize.TabIndex = 12;
            groupBoxMapSize.TabStop = false;
            groupBoxMapSize.Text = "Rozmiar mapy";
            groupBoxMapSize.Enter += groupBox1_Enter;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(408, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelMapWidth
            // 
            labelMapWidth.AutoSize = true;
            labelMapWidth.Font = new Font("Segoe UI", 9F);
            labelMapWidth.Location = new Point(37, 50);
            labelMapWidth.Name = "labelMapWidth";
            labelMapWidth.Size = new Size(75, 20);
            labelMapWidth.TabIndex = 3;
            labelMapWidth.Text = "Szerokość";
            // 
            // labelMapHeight
            // 
            labelMapHeight.AutoSize = true;
            labelMapHeight.Font = new Font("Segoe UI", 9F);
            labelMapHeight.Location = new Point(38, 100);
            labelMapHeight.Name = "labelMapHeight";
            labelMapHeight.Size = new Size(74, 20);
            labelMapHeight.TabIndex = 4;
            labelMapHeight.Text = "Wysokość";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTreeProbability);
            groupBox1.Controls.Add(labelSpreadProbability);
            groupBox1.Controls.Add(trackBarSpreadProbability);
            groupBox1.Controls.Add(trackBarTreeProbability);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(28, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(736, 178);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ustawienia prawdopodobieństwa";
            // 
            // labelSpreadProbability
            // 
            labelSpreadProbability.AutoSize = true;
            labelSpreadProbability.Font = new Font("Segoe UI", 9F);
            labelSpreadProbability.Location = new Point(27, 54);
            labelSpreadProbability.Name = "labelSpreadProbability";
            labelSpreadProbability.Size = new Size(176, 20);
            labelSpreadProbability.TabIndex = 5;
            labelSpreadProbability.Text = "Rozprzestrzenianie ognia";
            // 
            // labelTreeProbability
            // 
            labelTreeProbability.AutoSize = true;
            labelTreeProbability.Font = new Font("Segoe UI", 9F);
            labelTreeProbability.Location = new Point(27, 116);
            labelTreeProbability.Name = "labelTreeProbability";
            labelTreeProbability.Size = new Size(140, 20);
            labelTreeProbability.TabIndex = 6;
            labelTreeProbability.Text = "Generowanie drzew";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(groupBoxMapSize);
            Controls.Add(btnApply);
            Name = "SettingsForm";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)trackBarSpreadProbability).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTreeProbability).EndInit();
            groupBoxMapSize.ResumeLayout(false);
            groupBoxMapSize.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnApply;
        private TextBox txtGridWidth;
        private TextBox txtGridHeight;
        private TrackBar trackBarSpreadProbability;
        private TrackBar trackBarTreeProbability;
        private GroupBox groupBoxMapSize;
        private Button btnCancel;
        private Label labelMapWidth;
        private Label labelMapHeight;
        private GroupBox groupBox1;
        private Label labelTreeProbability;
        private Label labelSpreadProbability;
    }
}