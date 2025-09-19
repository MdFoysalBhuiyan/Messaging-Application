using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Messaging_Application
{
    public class DataAcess
    {
        public static string Connection_String = ConfigurationManager.ConnectionStrings["Text"].ConnectionString;

        private static string _connectionString = string.Empty;

        public static string ConnectionString
        {
            get
            {
                if (_connectionString == string.Empty)
                {
                    _connectionString = Connection_String;
                }
                return _connectionString;
            }
        }

        public DataAcess(string  connectionString)
        {
            _connectionString= connectionString;
        }
        
        public DataAcess()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Text"].ConnectionString;
            Connection_String = connStr;
        }
        public SqlCommand GetCommand(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
            return sqlCmd;
        }


        public DataTable Execute(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = GetCommand(sql);

            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            return dt;
        }


        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {

                command.Connection.Open();
                dt.Load(command.ExecuteReader());
            }
            catch (Exception ex) { }
            finally
            {
                command.Connection.Close();
            }

            return dt;
        }


        public int ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            int result = 0;
            try
            {
                cmd.Connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                cmd.Connection.Close();
            }

            return result;
        }



        public int ExecuteNonQuery(SqlCommand command)
        {
            int result = 0;
            try
            {
                command.Connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                command.Connection.Close();
            }

            return result;
        }

    }
}
