//using System;
//using System.Collections.Generic;
//using System.Data.OleDb;
//using ProftaakGame.Objects;

//// nodig voor connectie met database

//namespace ProftaakGame
//{
//    public class DataBase
//    {
//        private readonly OleDbConnection connection;

//        public DataBase(string bestand)
//        {
//            // Deze is voor de ACCES datadase
//            const string provider = "Provider=Microsoft.ACE.OLEDB.12.0";

//            string connectionString = provider + ";Data Source=" + bestand;
//            connection = new OleDbConnection(connectionString);
//        }

//        public List<Highscore> GetHighscores()
//        {
//            const string sql = "SELECT * FROM StudentTabel";
//            var command = new OleDbCommand(sql, connection);

//            var studenten = new List<Highscore>();
//            try
//            {
//                connection.Open();
//                OleDbDataReader reader = command.ExecuteReader();

//                while (reader.Read())
//                {
//                    string naam = Convert.ToString(reader["Naam"]);
//                    int nr = Convert.ToInt32(reader["Studentnummer"]);
//                    int stpunten = Convert.ToInt32(reader["Studiepunten"]);
//                    studenten.Add(new Highscore());
//                }
//            }
//            catch
//            {
//                return null;
//            }
//            finally
//            {
//                connection.Close();
//            }
//            return studenten;
//        }

//        public bool VoegToe(int nummer, string naam, int studpunten)
//        {
//            string sql = string.Format("INSERT INTO StudentTabel VALUES ({0},'{1}'" + ",{2})", nummer, naam, studpunten);
//            var command = new OleDbCommand(sql, connection);

//            try
//            {
//                connection.Open();
//                command.ExecuteNonQuery();
//            }
//            catch
//            {
//                return false;
//            }
//            finally
//            {
//                connection.Close();
//            }
//            return true;
//        }

//        public int AantalStudenten()
//        {
//            string sql = "SELECT COUNT(*) FROM StudentTabel";
//            var command = new OleDbCommand(sql, connection);

//            int aantal = 0;
//            try
//            {
//                connection.Open();
//                aantal = Convert.ToInt32(command.ExecuteScalar());
//            }
//            catch
//            {
//                return -1;
//            }
//            finally
//            {
//                connection.Close();
//            }
//            return aantal;
//        }
//    }
//}