using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace BLL
{
    static public class Tool
    {
        static private string Path = System.IO.Directory.GetCurrentDirectory() + @"\MyDB.mdb";
        static public string ConPath = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source="+Path;

        static public void SaveOpr(LogModel log)
        {
            using (OleDbConnection connection = new OleDbConnection(Tool.ConPath))
            {
                connection.Open();
                string sql = "INSERT INTO	Log(Title,DateTime) values(@Title,@DateTime)";
                OleDbCommand command = new OleDbCommand(sql, connection);
                command.Parameters.AddWithValue("@Title", log.Title);
                command.Parameters.AddWithValue("@DateTime", log.dateTime);
                command.ExecuteNonQuery();
            }
        }
    }
}
