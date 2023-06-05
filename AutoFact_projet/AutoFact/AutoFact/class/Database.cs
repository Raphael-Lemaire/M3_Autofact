using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;


namespace AutoFact
{
    class Database
    {
        private static Database _instance = null;


        //private static readonly object _syncObject = new object();
        private static string conString = (@"Data Source = ../../../Base_Donnee/autofact.db");

        private Database()
        {
            SQLiteConnection Conn = new SQLiteConnection(conString);
            SQLiteCommand command = new SQLiteCommand(Conn);
            Conn.Open();
            if (Conn.State == ConnectionState.Open)
            {
                Console.WriteLine("successfully connect");

            }
            else
            {
                Console.WriteLine("denied");
            }
        }
        public static Database getInstance()
        {
            if (_instance == null)
            {

                _instance = new Database();
            }
             SQLiteConnection Conn = new SQLiteConnection(conString);
             SQLiteCommand command = new SQLiteCommand();
            return _instance;
        }
        public SQLiteConnection getConnection()
        {
                
                SQLiteConnection Conn = new SQLiteConnection(conString);
                Conn.Open();
                Console.WriteLine("Connected");
                return Conn;
        }
        //public static SQLiteCommand getCommand()
        //{
           // SQL
        //}
    }
}



