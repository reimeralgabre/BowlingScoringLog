using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BowlingScoringLog
{
    class Database
    {
        public static SqlConnection DefSQLConnection()
        {
            SqlConnection conn = null;

            try
            {
                //string eConn = ConfigurationManager.ConnectionStrings["Database"].ToString();
                //string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Folder1\\Folder2\\dbRecordLog.mdf;" + "Integrated Security = True; ";
                string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbRecordLog.mdf;Integrated Security=True";

                conn = new SqlConnection(strConn);
                conn.Open();
            }
            catch (Exception) { conn = null; }
            return conn;
        }

        public static DataTable GetRecords(SqlCommand sqlCommand)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = GetRecords(sqlCommand.Connection, sqlCommand);
            }
            catch (Exception ex)
            {
                dt = null;
                //Msg.Show(ex, Msg.Message_Type.Error);
            }
            return dt;
        }

        public static DataTable GetRecords(SqlConnection sqlConnection, SqlCommand sqlCommand)
        {
            DataTable dt = null;
            try
            {
                using (sqlConnection)
                {
                    SqlDataReader rdr;
                    sqlCommand.Connection = sqlConnection;

                    //if (sqlConnection.State != ConnectionState.Open) { sqlConnection.Open(); }
                    rdr = sqlCommand.ExecuteReader();

                    using (dt = new DataTable())
                    {
                        dt.Load(rdr);
                    }
                }
            }
            catch (Exception ex)
            {
                dt = null;
                //Msg.Show(ex, Msg.Message_Type.Error);
            }

            return dt;
        }
    }
}
