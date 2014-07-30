using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BusinessObject;

namespace DataAccess
{
    public class UserDA
    {
        public ArrayList GetAllUSer()
        {
            ArrayList users = new ArrayList();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {
                
                SqlCommand cmd = new SqlCommand("spGetAllUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                conn.Open();

                da.Fill(ds);
                foreach (DataRow  row in ds.Tables[0].Rows)
                {
                    UserBO user = new UserBO((int)row[0],
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        row[4].ToString());
                    users.Add(user);
                }
            }

            return users;
        }

        public UserBO GetUserByUserPass(string user, string pass)
        {
           UserBO userbo = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {

                SqlCommand cmd = new SqlCommand("spGetUserByUserPass", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", user);
                cmd.Parameters.AddWithValue("@password", pass);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                conn.Open();

                da.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    userbo = new UserBO((int)row[0],
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        row[4].ToString());
    
                }
            }

            return userbo;
        }

        public bool CheckUser(string user)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("spCheckUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", user);
                conn.Open();
                int cnt = (int)cmd.ExecuteScalar();
                if (cnt > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void InsertUser(UserBO user)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("spAddNewUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", user.name);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue(@"user_type", user.user_type);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
