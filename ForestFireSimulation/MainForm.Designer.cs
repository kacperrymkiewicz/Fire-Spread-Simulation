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
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(10, 10);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 30);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(100, 10);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 30);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(190, 10);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 30);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(280, 10);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(166, 30);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Ustawienia symulacji";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 800);
            Controls.Add(btnStart);
            Controls.Add(btnStop);
            Controls.Add(btnReset);
            Controls.Add(btnSettings);
            Name = "MainForm";
            Text = "Forest Fire Simulation";
            ResumeLayout(false);
        }

        #endregion
    }
}