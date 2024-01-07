using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam__System
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
           
        
    }

        private void tchBtn_Click(object sender, EventArgs e)
        {
            if (urname.Text == "")
            {
                MessageBox.Show("Enter your user name");

            }
            else if (pass.Text == "")
            {
                MessageBox.Show("Enter your password");

            }
           
           
                
                
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-8EPR46S\\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;TrustServerCertificate=True");
                    SqlCommand cmd = new SqlCommand("select * from form_login where username = @username and password = @password", con);
                    cmd.Parameters.AddWithValue("@username", urname.Text);
                    cmd.Parameters.AddWithValue("@password", pass.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfully");
                        studtake ad = new studtake();
                        ad.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login is Invalid");
                    }
                }

               
               
            
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
