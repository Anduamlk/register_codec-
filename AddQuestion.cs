
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Exam__System
{
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
           
         
        }
  

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
         
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8EPR46S\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;TrustServerCertificate=True");
        private void adQuestion_Click(object sender, EventArgs e)
        {
            if (Questions.Text == "" || ChoseA.Text == "" || ChoseB.Text == "" || ChoseC.Text == "" || ChoseD.Text == "" || Answr.Text == "")
            {
                MessageBox.Show("Please Fill all options correctly!!!");
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "insert into answer values('" + (Questions.Text + "','" + ChoseA.Text + "','" + ChoseB.Text + "','" + ChoseC.Text + "','" + ChoseD.Text + "','" + Answr.Text + "')");
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Added Successfully!!!");
                    con.Close();
               
                    Questions.Text = "";
                    ChoseA.Text = "";
                    ChoseB.Text = "";
                    ChoseC.Text = "";
                    ChoseD.Text = "";
                    Answr.Text = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (Questions.Text == "" || ChoseA.Text == "" || ChoseB.Text == "" || ChoseC.Text == "" || ChoseD.Text == "" || Answr.Text == "")
            {
                MessageBox.Show("Please Fill all options correctly!!!");
            }
            else
            {
                try
                {

                    con.Open();
                    string query = "update answer set question='"+Questions.Text + "',choseA='" + ChoseA.Text + "',choseB='" + ChoseB.Text + "',choseC='" + ChoseC.Text + "',choseD='" + ChoseD.Text + "',answr='" + Answr.Text + "'where id ="+2+"";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question update Successfully!!!");
                    con.Close();

                    Questions.Text = "";
                    ChoseA.Text = "";
                    ChoseB.Text = "";
                    ChoseC.Text = "";
                    ChoseD.Text = "";
                    Answr.Text = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
    }
}
