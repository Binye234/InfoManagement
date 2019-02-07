using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace BLL
{
    public class MonthOpr
    {
        public void Create(MonthModel month)
        {
            using (OleDbConnection connection = new OleDbConnection(Tool.ConPath))
            {
                connection.Open();
                string sql = "INSERT INTO	MonthReport(Title,MonthDay) values(@Title,@MonthDay)";
                OleDbCommand command = new OleDbCommand(sql, connection);
                command.Parameters.AddWithValue("@Title", month.Title);
                command.Parameters.AddWithValue("@MonthDay", month.MonthDay);
                command.ExecuteNonQuery();
                Tool.SaveOpr(new LogModel() { Title = month.Title + "  添加", dateTime = DateTime.Now });
            }
        }

        public List<MonthModel> GetMonth()
        {
            using (OleDbConnection connection = new OleDbConnection(Tool.ConPath))
            {
                connection.Open();
                string sql = "Select ID,Title,MonthDay From MonthReport;";
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader reader = command.ExecuteReader();
                List<MonthModel> months = new List<MonthModel>();
                while (reader.Read())
                {
                    MonthModel month = new MonthModel();
                    month.ID = reader[0].ToString();
                    month.Title = reader[1].ToString();
                    month.MonthDay = reader[2].ToString();
                    months.Add(month);
                }
                return months;
            }
        }

        public void UpDate(MonthModel month)
        {
            using (OleDbConnection connection = new OleDbConnection(Tool.ConPath))
            {
                connection.Open();
                string sql = "UPDATE MonthReport Set Title=@Title,MonthDay=@MonthDay where ID=@ID";
                OleDbCommand command = new OleDbCommand(sql, connection);
                command.Parameters.AddWithValue("@ID", month.ID);
                command.Parameters.AddWithValue("@Title", month.Title);
                command.Parameters.AddWithValue("@MonthDay", month.MonthDay);
                command.ExecuteNonQuery();
                Tool.SaveOpr(new LogModel() { Title = month.Title + "  修改", dateTime = DateTime.Now });
            }
        }

        public void Delete(MonthModel month)
        {
            using (OleDbConnection connection = new OleDbConnection(Tool.ConPath))
            {
                connection.Open();
                string sql = "Delete MonthReport where ID=@ID";
                OleDbCommand command = new OleDbCommand(sql, connection);
                command.Parameters.AddWithValue("@ID", month.ID);             
                command.ExecuteNonQuery();
                Tool.SaveOpr(new LogModel() { Title = month.Title + "  删除", dateTime = DateTime.Now });
            }
        }
    }
}
