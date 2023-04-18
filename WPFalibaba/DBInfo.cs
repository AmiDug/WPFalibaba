using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace WPFalibaba
{
    class Program
    {
        public static List<Data> DBInfo(String terrain, String type)
        {
            using (SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = C:\\Users\\xry\\source\\repos\\WPFalibaba\\WPFalibaba\\SHealthDB.sqlite; Version = 3; New = True; Compress = True; "))
            {
                sqlite_conn.Open();
                return ReadData(sqlite_conn, terrain, type); 
            }
        }

        static List<Data> ReadData(SQLiteConnection conn, String terrain, String type)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            String query = "";
            if (terrain == "road") { query = "SELECT * FROM step_data_road"; }
            if (terrain == "forest") { query = "SELECT * FROM step_data_forest"; }
            sqlite_cmd.CommandText = query;
            List<Data> list = new List<Data>();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            int column = 0;
            switch(type)
            {
                case ("steps"): column = 9; break;
                case ("duration"): column = 0; break;
                case ("speed"): column = 10; break;
                case ("distance"): column = 11; break;
                case ("calories"): column = 12; break;
            }
            while (sqlite_datareader.Read())
            {
                double val = Convert.ToDouble(sqlite_datareader[column].ToString());
                DateTime time = DateTime.Parse(sqlite_datareader[4].ToString());
                list.Add(new Data { Date = time, Value = val });
            }
            conn.Close();
            return list;
        }
    }
}