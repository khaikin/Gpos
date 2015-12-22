using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PosDal
{
    public class BaseAdoDal
    {
        private readonly string _connectionString;
        public BaseAdoDal(string connectionString)
        {
            _connectionString = connectionString;
        }


        protected DataTable ExecuteStoredProcedure(string name, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (var connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = name;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    using (var da = new SqlDataAdapter(command))
                        da.Fill(dt);
                }
            }
            return dt.Copy();
        }


        protected int RowCount(string query)
        {
            int count = 0;
            using (SqlCommand command = new SqlCommand(query, new SqlConnection(_connectionString)))
            {
                command.Connection.Open();
                using (var dr = command.ExecuteReader(CommandBehavior.CloseConnection))
                    while (dr.Read()) count++;
            }
            return count;
        }


        protected DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (var connection = new SqlConnection(_connectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    connection.Open();
                    da.Fill(dt);
                }
            }
            return dt.Copy();
        }



        protected object ExecuteScalar(string query)
        {
            DataTable dt = new DataTable();
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var da = new SqlCommand(query, connection))
                {
                    connection.Open();
                    return da.ExecuteScalar();
                }
            }
        }


        protected int ExecuteNonQuery(string query)
        {
            DataTable dt = new DataTable();
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var da = new SqlCommand(query, connection))
                {
                    connection.Open();
                    return da.ExecuteNonQuery();
                }
            }
        }

    }
}
