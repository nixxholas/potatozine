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
        public static String uniConnectionStr = "Data Source = DIT-NB1530078\\SQLEXPRESS; " + "database = Potatozine; " + "integrated security = true";
        //"Data Source=NIXH\\SQLEXPRESS;" + "database=potatozine;" + "integrated security=true";


        private DataTable Magazines = new DataTable();
        private DataTable Book = new DataTable();


        private List<magazine> magazineobj = new List<magazine>();
        private List<Book> bookobj = new List<Book>();
        public void createobjects()
        {
            foreach (DataRow Row in Magazines.Rows)
            {
                magazine m = new magazine();
                m.Pid = Row["prodID"].ToString();
                m.Name = Row["name"].ToString();
                m.Desc = Row["descpt"].ToString();
                m.Price = double.Parse(Row["price"].ToString());
                m.Catcd = int.Parse(Row["catcd"].ToString());
                m.ImgLink = Row["img"].ToString();
                m.Pages = int.Parse(Row["pages"].ToString());
                magazineobj.Add(m);
            }
            foreach (DataRow Row in Book.Rows)
            {
                Book b = new Book();
                b.Pid = Row["prodID"].ToString();
                b.Name = Row["name"].ToString();
                b.Desc = Row["descpt"].ToString();
                b.Price = double.Parse(Row["price"].ToString());
                b.Catcd = int.Parse(Row["catcd"].ToString());
                b.ImgLink = Row["img"].ToString();
                b.Publisher = Row["publisher"].ToString();
                b.Authors = Row["author"].ToString();
                b.Type = Row["type"].ToString();
                bookobj.Add(b);
            }
        }


        public void loadProducts(string table)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        //Connection String
                        conn.ConnectionString = uniConnectionStr;

                        cmd.Connection = conn;

                        cmd.CommandText = "Select * from " + table;

                        if (table == "magazine")
                        {

                            try
                            {
                                //Open Connection
                                conn.Open();
                                da.SelectCommand = cmd;
                                da.Fill(Magazines);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                        else
                        {
                            try
                            {
                                //Open Connection
                                conn.Open();
                                da.SelectCommand = cmd;
                                da.Fill(Book);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
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

        public List<magazine> Magazineobj {
            get { return this.magazineobj; }
        }

        public List<Book> Bookobj {
            get { return this.bookobj; }
        }
    }
}
