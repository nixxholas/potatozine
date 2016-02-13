using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace potatozine
{
    class dbengine
    {
        public static String uniConnectionStr;
        private DataTable Magazines = new DataTable();
        private DataTable Book = new DataTable();
        private DataTable Products = new DataTable();

        public void loadSQL() {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        //Connection String
                        conn.ConnectionString = "Data Source = DIT - NB1530078\\SQLEXPRESS; " + "database = Potatozine; " + "integrated security = true";

                        cmd.Connection = conn;

                        cmd.CommandText = "Select * from Magazine";

                        try
                        {
                            conn.Open();
                            da.SelectCommand = cmd;
                            Magazines.Rows.Clear();
                            da.Fill(Magazines);
                        }
                        catch (Exception ex)
                        {
                        }
                        finally
                        {
                            conn.Close();
                        }

                        cmd.CommandText = "Select * from Book";

                        try
                        {
                            conn.Open();
                            da.SelectCommand = cmd;
                            Book.Rows.Clear();
                            da.Fill(Book);
                        }
                        catch (Exception ex)
                        {
                        }
                        finally
                        {
                            conn.Close();
                        }

                    }
                }
            }
        }

        public void test2() {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        //Connection String
                        conn.ConnectionString = "Data Source = DIT - NB1530078\\SQLEXPRESS; " + "database = Potatozine; " + "integrated security = true";

                        cmd.Connection = conn;

                        cmd.CommandText = "Select * from Magazine";

                        Products.Rows.Clear();

                        try
                        {
                            conn.Open();
                            da.SelectCommand = cmd;
                            da.Fill(Products);
                        }
                        catch (Exception ex)
                        {
                        }
                        finally
                        {
                            conn.Close();
                        }

                        cmd.CommandText = "Select * from Book";

                        try
                        {
                            conn.Open();
                            da.SelectCommand = cmd;
                            da.Fill(Products);
                        }
                        catch (Exception ex)
                        {
                        }
                        finally
                        {
                            conn.Close();
                        }

                    }
                }
            }
        }
    }
}
