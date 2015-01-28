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
            using (var game = new ProftaakGame())
            {
                game.Run();
            }
        }
    }
#endif
}