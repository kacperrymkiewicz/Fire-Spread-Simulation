namespace ForestFireSimulation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private Button btnSettings;

        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            btnSettings = new Button();
            gridRenderer = new GridRenderer();
            menuPanel = new Panel();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(40, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 30);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(142, 12);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 30);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(246, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 30);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(350, 12);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(166, 30);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Ustawienia symulacji";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // gridRenderer
            // 
            gridRenderer.Dock = DockStyle.Fill;
            gridRenderer.Forest = null;
            gridRenderer.Location = new Point(0, 50);
            gridRenderer.Name = "gridRenderer";
            gridRenderer.Size = new Size(1600, 750);
            gridRenderer.TabIndex = 4;
            gridRenderer.Text = "gridRenderer";
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(btnSettings);
            menuPanel.Controls.Add(btnReset);
            menuPanel.Controls.Add(btnStart);
            menuPanel.Controls.Add(btnStop);
            menuPanel.Dock = DockStyle.Top;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1600, 50);
            menuPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            AcceptButton = btnStart;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnStop;
            ClientSize = new Size(1600, 800);
            Controls.Add(gridRenderer);
            Controls.Add(menuPanel);
            DoubleBuffered = true;
            Name = "MainForm";
            Text = "Forest Fire Simulation";
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GridRenderer gridRenderer;
        private Panel menuPanel;
    }
}