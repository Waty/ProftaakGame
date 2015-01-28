#region Using Statements

using System;
using System.Windows.Forms;

#endregion

namespace ProftaakGame
{
#if WINDOWS || LINUX
    /// <summary>
    ///     The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            var mf = new MainForm();
            while (mf.ShowDialog() == DialogResult.OK)
            {
                using (var game = new ProftaakGame())
                {
                    game.Connection = new SerialConnection(mf.SerialPort);
                    game.Run();
                }
            }
        }
    }
#endif
}