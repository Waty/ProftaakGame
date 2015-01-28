namespace ProftaakGame
{
    partial class MainForm
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
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddbLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddbSerialPorts = new System.Windows.Forms.ComboBox();
            this.gbHighscores = new System.Windows.Forms.GroupBox();
            this.lvHighscores = new System.Windows.Forms.ListView();
            this.bStartGame = new System.Windows.Forms.Button();
            this.gbSettings.SuspendLayout();
            this.gbHighscores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.ddbLevel);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.ddbSerialPorts);
            this.gbSettings.Location = new System.Drawing.Point(12, 12);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(260, 74);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Level:";
            // 
            // ddbLevel
            // 
            this.ddbLevel.FormattingEnabled = true;
            this.ddbLevel.Location = new System.Drawing.Point(133, 46);
            this.ddbLevel.Name = "ddbLevel";
            this.ddbLevel.Size = new System.Drawing.Size(121, 21);
            this.ddbLevel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SerialPort:";
            // 
            // ddbSerialPorts
            // 
            this.ddbSerialPorts.FormattingEnabled = true;
            this.ddbSerialPorts.Location = new System.Drawing.Point(133, 19);
            this.ddbSerialPorts.Name = "ddbSerialPorts";
            this.ddbSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.ddbSerialPorts.TabIndex = 0;
            // 
            // gbHighscores
            // 
            this.gbHighscores.Controls.Add(this.lvHighscores);
            this.gbHighscores.Location = new System.Drawing.Point(12, 99);
            this.gbHighscores.Name = "gbHighscores";
            this.gbHighscores.Padding = new System.Windows.Forms.Padding(6);
            this.gbHighscores.Size = new System.Drawing.Size(260, 101);
            this.gbHighscores.TabIndex = 0;
            this.gbHighscores.TabStop = false;
            this.gbHighscores.Text = "Highscores";
            // 
            // lvHighscores
            // 
            this.lvHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHighscores.Location = new System.Drawing.Point(6, 19);
            this.lvHighscores.Name = "lvHighscores";
            this.lvHighscores.Size = new System.Drawing.Size(248, 76);
            this.lvHighscores.TabIndex = 2;
            this.lvHighscores.UseCompatibleStateImageBehavior = false;
            // 
            // bStartGame
            // 
            this.bStartGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bStartGame.Location = new System.Drawing.Point(12, 206);
            this.bStartGame.Name = "bStartGame";
            this.bStartGame.Size = new System.Drawing.Size(260, 43);
            this.bStartGame.TabIndex = 1;
            this.bStartGame.Text = "Start Game";
            this.bStartGame.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bStartGame);
            this.Controls.Add(this.gbHighscores);
            this.Controls.Add(this.gbSettings);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbHighscores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddbSerialPorts;
        private System.Windows.Forms.GroupBox gbHighscores;
        private System.Windows.Forms.ListView lvHighscores;
        private System.Windows.Forms.Button bStartGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddbLevel;
    }
}