using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FeatureFlag.Infrastructure
{
    internal class DataBase
    {
        string ConnectionStringName = "ConnectionString";

        public DataBase()
        {

        }

        public DataBase(string connectionStringName)
        {
            ConnectionStringName = connectionStringName;
        }

        public DataTable ExecuteDataTable(string query)
        {
            string conexao = ConfigurationManager.ConnectionStrings[this.ConnectionStringName].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conexao);

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;

            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlCommand.ExecuteReader());
            sqlConnection.Close();
            sqlConnection.Dispose();

            return dataTable;
        }

    }    
}
