using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookManagement.Models
{
    public class Functions
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string conStr;
        public Functions() 
        {
            conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Projects\C# Projects\1 DB\BookShopASPDB.mdf"";Integrated Security=True;Connect Timeout=30;";
            Con= new SqlConnection(conStr);
            cmd = new SqlCommand();
            cmd.Connection = Con;

        }

        public DataTable GetData(string Query)
        {
            dt= new DataTable();
            sda = new SqlDataAdapter(Query,conStr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(String Query)
        {
            int cnt = 0;
            if(Con.State== ConnectionState.Closed)
            {
                Con.Open();

            }
            cmd.CommandText=Query;
            cnt=cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }


    }
}