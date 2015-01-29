namespace ProftaakGame
{
    partial class CalibreerForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Positioneer de handschoen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "De game begint in ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lCount
            // 
            this.lCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount.Location = new System.Drawing.Point(0, 46);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(260, 42);
            this.lCount.TabIndex = 2;
            this.lCount.Text = "3";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "seconden";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDown
            // 
            this.countDown.Enabled = true;
            this.countDown.Interval = 1000;
            this.countDown.Tick += new System.EventHandler(this.countDown_Tick);
            // 
            // CalibreerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 111);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalibreerForm";
            this.Text = "CalibreerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer countDown;
    }
}