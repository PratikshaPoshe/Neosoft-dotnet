using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Web
{
    public partial class CustomerRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string Constring = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
                LoadBindGridView(Constring);
                
                
            }
        }

        public void LoadBindGridView(string Constirng)
        {
            string query = "select c.Name,c.zipcode,c.email,l.username from Customer as c Join login as l on c.id=l.cust_id";
            using (SqlConnection cons = new SqlConnection(Constirng))
            {
                using (SqlDataAdapter ads = new SqlDataAdapter(query, Constirng))
                {
                    using (DataTable dt = new DataTable())
                    {
                        ads.Fill(dt);
                        gv_cats.DataSource = dt;
                        gv_cats.DataBind();
                    }
                }
            }
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;
            string email = tb_email.Text;
            string zipcode = tb_zipcode.Text;
            string username = tb_username.Text;
            string password = tb_password.Text;

            string conString = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("spAddCustomer", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@zipcode", zipcode);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                /*SqlParameter outpara = new SqlParameter();
                outpara.ParameterName = "@id";
                outpara.SqlDbType = System.Data.SqlDbType.Int;
                outpara.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outpara);*/

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            LoadBindGridView(conString);
        }
    }
}