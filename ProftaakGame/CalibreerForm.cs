using System;
using System.Windows.Forms;

namespace ProftaakGame
{
    public partial class CalibreerForm : Form
    {
        private int delay = 3;

        public CalibreerForm()
        {
            InitializeComponent();
            lCount.Text = delay.ToString("G");
        }

        private void countDown_Tick(object sender, EventArgs e)
        {
            delay--;
            if (delay <= 0)
            {
                DialogResult = DialogResult.OK;
            }
            lCount.Text = delay.ToString("G");
        }
    }
}