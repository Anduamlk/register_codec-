using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Exam__System
{
    public partial class Register : Form
    {
       //SqlConnection con;
      // SqlCommand com;
        public Register()
        {
            InitializeComponent();
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8EPR46S\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;TrustServerCertificate=True");
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (textBoxid.Text == "" || textBoxfristname.Text == "" || textBoxlastnmae.Text == "" || textBoxusername.Text == "" || textBoxDept.Text == "" || textBoxDept.Text == "" || textBoxEmail.Text == "" || comboBox1.Text == "" || textBoxpassword.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                   
                    con.Open();
                    string query = "insert into register values('" + (textBoxid.Text + "','" + textBoxfristname.Text + "','" + textBoxlastnmae.Text + "','" + textBoxusername.Text + "','" + textBoxDept.Text + "','" + textBoxEmail.Text + "','" + comboBox1.SelectedItem.ToString() + "' ,'" + textBoxpassword.Text + "')");
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration  Successfully!!!");
                    con.Close();

                    textBoxid.Text = "";
                    textBoxfristname.Text = "";
                    textBoxlastnmae.Text = "";
                    textBoxusername.Text = "";
                    textBoxDept.Text = "";
                    textBoxEmail.Text = "";
                    comboBox1.Text = "";
                    textBoxpassword.Text = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }










        }
        
           

      
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

