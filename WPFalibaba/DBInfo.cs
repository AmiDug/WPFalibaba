using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFalibaba
{
    class Program
    {
        public static List<Data> DBInfo()
        {
            //SQLiteConnection sqlite_conn;
            using (SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = C:\\Users\\xry\\source\\repos\\WPFalibaba\\WPFalibaba\\test_db_csv.sqlite; Version = 3; New = True; Compress = True; "))
            {
                sqlite_conn.Open();
                //sqlite_conn = CreateConnection();
                //CreateTable(sqlite_conn);
                //InsertData(sqlite_conn);
                return ReadData(sqlite_conn); 
            }
        }

        static SQLiteConnection CreateConnection()
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
        }

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

        static List<Data> ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM com4";
            List<Data> list = new List<Data>();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            int skip = 2;
            while (sqlite_datareader.Read())
            {
                if (skip == 0)
                {
                    double val = Convert.ToDouble(sqlite_datareader[0].ToString());
                    DateTime time = DateTime.Parse(sqlite_datareader[5].ToString());
                    list.Add(new Data { Date = time, Value = val });
                }
                else { skip--; }
                //return myreader;
            }
            conn.Close();
            return list;
            //return "Hejsan";
        }
    }
}