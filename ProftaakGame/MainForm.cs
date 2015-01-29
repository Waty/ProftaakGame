using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;
using ProftaakGame.Properties;

namespace ProftaakGame
{
    public partial class MainForm : Form
    {
        private const string Database = "highscore";
        private const string Localhost = "localhost";
        private const string Password = "test";
        private const string Username = "root";
        private readonly DatabaseConnection database;

        public MainForm()
        {
            InitializeComponent();
            ddbSerialPorts.Items.AddRange(SerialPort.GetPortNames());

            database = new DatabaseConnection(Localhost, Database, Username, Password);

            LoadHighscores();
            LoadLevels();

            LoadSettings();
        }

        public String PortName
        {
            get { return ddbSerialPorts.Text; }
            set { ddbSerialPorts.Text = value; }
        }

        public String UserName
        {
            get { return tbName.Text; }
        }

        public Level Level
        {
            get { return (Level) ddbLevels.SelectedItem; }
        }

        private void LoadSettings()
        {
            Settings settings = Settings.Default;
            ddbSerialPorts.Text = settings.SerialPort;

            int lvl = settings.SelectedLevel;
            if (lvl >= 0 && lvl < ddbLevels.Items.Count)
            {
                ddbLevels.SelectedIndex = lvl;
            }

            tbName.Text = settings.UserName;
        }

        private void LoadLevels()
        {
            foreach (Level level in database.GetLevels())
            {
                ddbLevels.Items.Add(level);
            }
        }

        private void LoadHighscores()
        {
            List<Highscore> highscores = database.GetHighscores();
            if (highscores != null)
            {
                foreach (Highscore highscore in highscores)
                {
                    lvHighscores.Items.Add(GetListViewItem(highscore));
                }
            }
            else
            {
                Debug.WriteLine("Failed to retrieve settings");
            }
        }

        private static ListViewItem GetListViewItem(Highscore highscore)
        {
            return new ListViewItem(new[]
            {
                highscore.Name,
                highscore.Date.ToString("yyyy-MM-dd"),
                highscore.Points.ToString("G")
            });
        }

        public void AddHighscore(Highscore highscore)
        {
            database.AddScore(highscore);
            lvHighscores.Items.Add(GetListViewItem(highscore));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings settings = Settings.Default;
            settings.SerialPort = ddbSerialPorts.Text;
            settings.SelectedLevel = ddbLevels.SelectedIndex;
            settings.UserName = tbName.Text;
            settings.Save();
        }
    }
}