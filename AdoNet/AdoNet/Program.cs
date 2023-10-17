using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace AdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Program().CreateTable();
            //new Program().InsertData();
            //new Program().RetrieveData();
            //new Program().DeleteData(); 
            //new Program().RetrieveData();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                //creating connection
                con = new SqlConnection("data source = .; database=student; integrated security = SSPI");

                //writing sql query
                SqlCommand cm = new SqlCommand("Create table StudentInfo(id int Primary Key not null, name varchar(100), email varchar(50), join_date date)", con);

                //opening connection
                con.Open();

                //executing query
                cm.ExecuteNonQuery();

                //Display Message
                Console.WriteLine("Table created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void InsertData(string sID, string sName, string sEmail)
        {
            SqlConnection con = null;
            try
            {
                //creating connection
                con = new SqlConnection("data source = .; database=student; integrated security = SSPI");

                string query = $"insert into studentInfo values('{sID}','{sName}','{sEmail}','12-02-2017')";

                //writing sql query
                SqlCommand cm = new SqlCommand(query, con);

                //opening connection
                con.Open();

                //executing the sql query
                int i = cm.ExecuteNonQuery();

                //display a message
                if (i == 1)
                {
                    Console.WriteLine(i + " row affected");
                }
                else
                {
                    Console.WriteLine(i + " rows affected");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void RetrieveData()
        {
            SqlConnection con = null;

            try
            {
                //create connection
                con = new SqlConnection("data source=.; database=student; integrated Security = SSPI ");

                //write query
                SqlCommand cm = new SqlCommand("Select * from StudentInfo", con);

                //open connection
                con.Open();

                //executing query
                SqlDataReader sdr = cm.ExecuteReader();

                //iterating data
                while (sdr.Read())
                {
                    Console.WriteLine($"{sdr["id"]} {sdr["name"]} {sdr["email"]} {sdr[3]}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: " + ex);
            }
            finally
            {
                con?.Close();
            }
        }

        public void DeleteData()
        {
            SqlConnection con = null;
            try
            {
                //create connection
                con = new SqlConnection("data source =. ; database = student; integrated security = SSPI");

                //write query
                SqlCommand cm = new SqlCommand("Delete from StudentInfo where id='102'", con);

                //open connection
                con.Open();

                //execute query
                int i = cm.ExecuteNonQuery();

                //write message
                Console.WriteLine("Record Deleted Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong" + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}