using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WPFalibaba
{
    class Program
    {
        public static List<Data> DBInfo(String terrain, String type)
        {
            //SQLiteConnection sqlite_conn;
            using (SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = C:\\Users\\xry\\source\\repos\\WPFalibaba\\WPFalibaba\\SHealthDB.sqlite; Version = 3; New = True; Compress = True; "))
            {
                sqlite_conn.Open();
                //sqlite_conn = CreateConnection();
                //CreateTable(sqlite_conn);
                //InsertData(sqlite_conn);
                return ReadData(sqlite_conn, terrain, type); 
            }
        }

        /*static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source = C: \\Users\\xry\\source\\repos\\WPFalibaba\\WPFalibaba\\alibabadb.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
         try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }*/

        /*
        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE SampleTable
               (Col1 VARCHAR(20), Col2 INT)";
           string Createsql1 = "CREATE TABLE SampleTable1
            (Col1 VARCHAR(20), Col2 INT)";
           sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();

        }

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable
               (Col1, Col2) VALUES('Test Text ', 1); ";
           sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable
               (Col1, Col2) VALUES('Test1 Text1 ', 2); ";
           sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable
               (Col1, Col2) VALUES('Test2 Text2 ', 3); ";
           sqlite_cmd.ExecuteNonQuery();


            sqlite_cmd.CommandText = "INSERT INTO SampleTable1
               (Col1, Col2) VALUES('Test3 Text3 ', 3); ";
           sqlite_cmd.ExecuteNonQuery();

        } */

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
                //return myreader;
            }
            conn.Close();
            return list;
            //return "Hejsan";
        }
    }
}