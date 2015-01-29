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
                    game.Connection = new SerialConnection(mf.PortName);
                    game.Connection.WriteData(SerialConnection.MessageType.pre_Game);
                    game.Level = mf.Level;
                    game.Map.Player.Name = mf.UserName;

                    game.Run();

                    mf.AddHighscore(game.Highscore);
                }
            }
        }
    }
#endif
}