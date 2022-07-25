using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace project_group7_prn.DAO.DAOConnect
{
    public class DBcontext
    {
        public static SqlConnection GetConnection()
        {
            var conf = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true)
                 .Build();

            string strConn = conf.GetConnectionString("DbContext");
            Console.WriteLine(strConn);
            return new SqlConnection(strConn);
        }

        public static DataTable GetDataBySql(string sql)
        {
            //cmd text = sql la cau truy van minh muon lam, SqlConnection la connection minh muon lam tren n
            SqlCommand command = new SqlCommand(sql, GetConnection());
            //dataadapter lay ra toan bo du lieu co trong du lieu
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = command;
            DataTable tb = new DataTable();
            adap.Fill(tb);
            return tb;
        }

        public static DataTable GetTableByPara(string sql, SqlParameter[] par)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(par);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = command;
            DataTable tb = new DataTable();
            adap.Fill(tb);
            return tb;
        }

        //Insert, Update, delete depend cmd
        public static void Update(String sql, SqlParameter[] par)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(par);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
    }
}

