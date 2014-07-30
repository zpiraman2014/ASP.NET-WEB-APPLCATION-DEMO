using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using BusinessObject;
using System.Data;

namespace DataAccess
{
    public class CoffeeDA
    {
        public ArrayList GetCoffeeByType(string CoffeeType)
        {
            ArrayList CoffeeList = new ArrayList();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("spGetCoffeeByType", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();

                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", CoffeeType);


                con.Open();
                da.SelectCommand = cmd;
                da.Fill(ds);

                foreach (DataRow dt in ds.Tables[0].Rows)
                {

                    CoffeeBO coffee = 
                        new CoffeeBO((int)dt[0],dt[1].ToString(),
                            dt[2].ToString(),
                            double.Parse(dt[3].ToString()),
                            dt[4].ToString(),
                            dt[5].ToString(),
                            dt[6].ToString(),
                            dt[7].ToString());

                    CoffeeList.Add(coffee);
                }

            }

            return CoffeeList;
        }

        public ArrayList GetAllCoffee()
        {
            ArrayList CoffeeList = new ArrayList();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("spGetAllCoffee", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();

                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;


                con.Open();
                da.SelectCommand = cmd;
                da.Fill(ds);

                foreach (DataRow dt in ds.Tables[0].Rows)
                {

                    CoffeeBO coffee =
                        new CoffeeBO((int)dt[0], dt[1].ToString(),
                            dt[2].ToString(),
                            double.Parse(dt[3].ToString()),
                            dt[4].ToString(),
                            dt[5].ToString(),
                            dt[6].ToString(),
                            dt[7].ToString());

                    CoffeeList.Add(coffee);
                }

            }

            return CoffeeList;
        }


        public ArrayList GetCoffeeTypes()  
        {
            ArrayList CoffeeList = new ArrayList();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("spGetAllTypes", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();

                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;


                con.Open();
                da.SelectCommand = cmd;
                da.Fill(ds);

                foreach (DataRow dt in ds.Tables[0].Rows)
                {
                    CoffeeList.Add(dt[0].ToString());
                }

            }

            return CoffeeList;
        }

        public void InsertCoffee(CoffeeBO coffee)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("spInsertCoffee",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(@"name", coffee.name);
                cmd.Parameters.Add(@"type", coffee.type);
                cmd.Parameters.Add(@"price", coffee.price);
                cmd.Parameters.Add(@"roast", coffee.roast);
                cmd.Parameters.Add(@"country", coffee.country);
                cmd.Parameters.Add(@"image", coffee.image);
                cmd.Parameters.Add(@"review", coffee.review);
                
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public CoffeeBO GetCoffeeById(int id)  
        {
            CoffeeBO coffee = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("spGetCoffeeById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", id);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                conn.Open();

                da.SelectCommand = cmd;
                da.Fill(ds);

                foreach (DataRow row in  ds.Tables[0].Rows)
                {
                    coffee = new CoffeeBO(
                    (int)row[0], row[1].ToString(), row[2].ToString(), Convert.ToDouble(row[3]), row[4].ToString(),
                    row[5].ToString(), row[6].ToString(), row[7].ToString());
                }
            }

            return coffee;
        }

        public void UpdateCoffee(CoffeeBO coffee)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("spUpdateCoffee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 1500;
                cmd.Parameters.Add("@id", coffee.id);
                cmd.Parameters.Add(@"name", coffee.name);
                cmd.Parameters.Add(@"type", coffee.type);
                cmd.Parameters.Add(@"price", coffee.price);
                cmd.Parameters.Add(@"roast", coffee.roast);
                cmd.Parameters.Add(@"country", coffee.country);
                cmd.Parameters.Add(@"image", coffee.image);
                cmd.Parameters.Add(@"review", coffee.review);

                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public void DeleteCoffee(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeDB"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("spDeleteCoffee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 1500;
                cmd.Parameters.Add("@id", id);
                conn.Open();

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }
    }
}
