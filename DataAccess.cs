using System;
using System.Data;
using System.Data.SqlClient;

namespace VehicleRentalSystem
{
    public sealed class DataAccess : IDisposable
    {
        public const string ConnectionString =
            @"Data Source=Dark;Initial Catalog=VehicleRentDB;Integrated Security=True;Encrypt=False";

        public SqlConnection Sqlcon { get; private set; }

        public DataAccess()
        {
            Sqlcon = new SqlConnection(ConnectionString);
            Sqlcon.Open();
        }

        private SqlCommand CreateCommand(string query, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(query, Sqlcon);

            if (parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
            }

            return command;
        }

        public DataSet ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand command = CreateCommand(query, parameters))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
        }

        public DataTable ExecuteQueryTable(string query, params SqlParameter[] parameters)
        {
            return ExecuteQuery(query, parameters).Tables[0];
        }

        public int ExecuteDMLQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand command = CreateCommand(query, parameters))
            {
                return command.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand command = CreateCommand(query, parameters))
            {
                return command.ExecuteScalar();
            }
        }

        public void Dispose()
        {
            if (Sqlcon != null)
            {
                Sqlcon.Dispose();
            }
        }
    }
}
