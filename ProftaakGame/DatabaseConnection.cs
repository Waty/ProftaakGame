using System;
using System.Collections.Generic;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace ProftaakGame
{
    internal class DatabaseConnection
    {
        private readonly MySqlConnection connection;

        public DatabaseConnection(string server, string database, string username, string password)
        {
            string str =
                string.Format(
                    "server={0};user id={1};database={3};persist security info=False;Convert Zero Datetime=True",
                    server, username, password, database);

            connection = new MySqlConnection(str);
        }

        public List<Highscore> GetHighscores()
        {
            var command = new MySqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM scores"
            };

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();


                var highscores = new List<Highscore>();
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    String name = reader.GetString("name");
                    DateTime date = reader.GetDateTime("date");
                    int coins = reader.GetInt32("coins");
                    int lives = reader.GetInt32("lives");
                    highscores.Add(new Highscore(id, name, date, coins, lives));
                }
                return highscores;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public bool AddScore(Highscore highscore)
        {
            var command = new MySqlCommand
            {
                Connection = connection,
                CommandText =
                    string.Format("INSERT INTO scores (date, name, coins, lives) VALUES ('{0}','{1}', {2}, {3})",
                        highscore.Date.ToString("yyyy-MM-dd"), highscore.Name, highscore.Coins, highscore.Lives)
            };

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public List<Level> GetLevels()
        {
            var command = new MySqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * FROM maps"
            };

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();


                var levels = new List<Level>();
                while (reader.Read())
                {
                    levels.Add(new Level
                    {
                        MapId = reader.GetInt32(0),
                        MapName = reader.GetString(1),
                        MapData = reader.GetString(2).Split('\n')
                    });
                }
                return levels;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }
    }
}