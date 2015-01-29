using System.Windows.Forms;

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
            System.Windows.Forms.ColumnHeader chName;
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddbLevels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddbSerialPorts = new System.Windows.Forms.ComboBox();
            this.gbHighscores = new System.Windows.Forms.GroupBox();
            this.lvHighscores = new System.Windows.Forms.ListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bStartGame = new System.Windows.Forms.Button();
            chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSettings.SuspendLayout();
            this.gbHighscores.SuspendLayout();
            this.SuspendLayout();
            // 
            // chName
            // 
            chName.Text = "Name";
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.tbName);
            this.gbSettings.Controls.Add(this.label3);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.ddbLevels);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.ddbSerialPorts);
            this.gbSettings.Location = new System.Drawing.Point(12, 12);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(374, 104);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(133, 73);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(235, 20);
            this.tbName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
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
            // ddbLevels
            // 
            this.ddbLevels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddbLevels.DisplayMember = "MapName";
            this.ddbLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddbLevels.FormattingEnabled = true;
            this.ddbLevels.Location = new System.Drawing.Point(133, 46);
            this.ddbLevels.Name = "ddbLevels";
            this.ddbLevels.Size = new System.Drawing.Size(235, 21);
            this.ddbLevels.TabIndex = 2;
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
            this.ddbSerialPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddbSerialPorts.FormattingEnabled = true;
            this.ddbSerialPorts.Location = new System.Drawing.Point(133, 19);
            this.ddbSerialPorts.Name = "ddbSerialPorts";
            this.ddbSerialPorts.Size = new System.Drawing.Size(235, 21);
            this.ddbSerialPorts.TabIndex = 0;
            // 
            // gbHighscores
            // 
            this.gbHighscores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHighscores.Controls.Add(this.lvHighscores);
            this.gbHighscores.Location = new System.Drawing.Point(12, 122);
            this.gbHighscores.Name = "gbHighscores";
            this.gbHighscores.Padding = new System.Windows.Forms.Padding(6);
            this.gbHighscores.Size = new System.Drawing.Size(374, 245);
            this.gbHighscores.TabIndex = 0;
            this.gbHighscores.TabStop = false;
            this.gbHighscores.Text = "Highscores";
            // 
            // lvHighscores
            // 
            this.lvHighscores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            chName,
            this.chDate,
            this.chScore});
            this.lvHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHighscores.GridLines = true;
            this.lvHighscores.Location = new System.Drawing.Point(6, 19);
            this.lvHighscores.Name = "lvHighscores";
            this.lvHighscores.Size = new System.Drawing.Size(362, 220);
            this.lvHighscores.TabIndex = 2;
            this.lvHighscores.UseCompatibleStateImageBehavior = false;
            this.lvHighscores.View = System.Windows.Forms.View.Details;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            // 
            // chScore
            // 
            this.chScore.Text = "Score";
            // 
            // bStartGame
            // 
            this.bStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bStartGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bStartGame.Location = new System.Drawing.Point(12, 373);
            this.bStartGame.Name = "bStartGame";
            this.bStartGame.Size = new System.Drawing.Size(374, 43);
            this.bStartGame.TabIndex = 1;
            this.bStartGame.Text = "Start Game";
            this.bStartGame.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 428);
            this.Controls.Add(this.bStartGame);
            this.Controls.Add(this.gbHighscores);
            this.Controls.Add(this.gbSettings);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
        private System.Windows.Forms.ComboBox ddbLevels;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chScore;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
    }
}