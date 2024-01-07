using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Exam__System
{
    public partial class studtake : Form
    {
        public studtake()
        {
            InitializeComponent();
            RadioButton1.Visible = false;
            Q2.Visible = false;
            Q3.Visible = false;
            Q4.Visible = false;
            Q5.Visible = false;
            Q6.Visible = false;
            Q7.Visible = false;
            Q8.Visible = false;
            Q9.Visible = false;
            Q10.Visible = false;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8EPR46S\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;TrustServerCertificate=True");
        private void guna2RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (RadioButton1.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD FROM answer WHERE id =1", con);
                    SqlDataReader red = cmd.ExecuteReader();
                    while (red.Read())
                    {
                        label3.Text = red.GetValue(0).ToString();
                        redbtn1.Text = red.GetValue(1).ToString();
                        redbtn2.Text = red.GetValue(2).ToString();
                        redbtn3.Text = red.GetValue(3).ToString();
                        redbtn4.Text = red.GetValue(4).ToString();
                    }
                    red.Close();
                    cmd.ExecuteNonQuery();
           
                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
            {

                RadioButton1.Visible = true;
                Q2.Visible = false;
                Q3.Visible = false;
                Q4.Visible = false;
                Q5.Visible = false;
                Q6.Visible = false;
                Q7.Visible = false;
                Q8.Visible = false;
                Q9.Visible = false;
                Q10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 1))
            {
                RadioButton1.Visible = false;
               Q2.Visible = true;
                Q3.Visible = false;
                Q4.Visible = false;
                Q5.Visible = false;
                Q6.Visible = false;
                Q7.Visible = false;
                Q8.Visible = false;
                Q9.Visible = false;
                Q10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 2))
            {
                RadioButton1.Visible = false;
                Q2.Visible = false;
                Q3.Visible = true;
                Q4.Visible = false;
                Q5.Visible = false;
                Q6.Visible = false;
                Q7.Visible = false;
                Q8.Visible = false;
                Q9.Visible = false;
                Q10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 3))
            {
                RadioButton1.Visible = false;
                Q2.Visible = false;
                Q3.Visible = false;
                Q4.Visible = true;
                Q5.Visible = false;
                Q6.Visible = false;
                Q7.Visible = false;
                Q8.Visible = false;
                Q9.Visible = false;
                Q10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 4))
            {
                RadioButton1.Visible = false;
                Q2.Visible = false;
                Q3.Visible = false;
                Q4.Visible = false;
                Q5.Visible = true;
                Q6.Visible = false;
                Q7.Visible = false;
                Q8.Visible = false;
                Q9.Visible = false;
                Q10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 5))
            {
                RadioButton1.Visible = false;
                Q2.Visible = false;
                Q3.Visible = false;
                Q4.Visible = false;
                Q5.Visible = false;
                Q6.Visible = true;
                Q7.Visible = false;
                Q8.Visible = false;
                Q9.Visible = false;
                Q10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 6))
            {
                RadioButton1.Visible = false;
                Q2.Visible = false;
                Q3.Visible = false;
                Q4.Visible = false;
                Q5.Visible = false;
                Q6.Visible = false;
                Q7.Visible = true;
                Q8.Visible = false;
                Q9.Visible = false;
                Q10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 7))
            {
                RadioButton1.Visible = false;
                Q2.Visible = false;
                Q3.Visible = false;
                Q4.Visible = false;
                Q5.Visible = false;
                Q6.Visible = false;
                Q7.Visible = false;
                Q8.Visible = true;
                Q9.Visible = false;
                Q10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 8))
            {
                RadioButton1.Visible = false;
                Q2.Visible = false;
                Q3.Visible = false;
                Q4.Visible = false;
                Q5.Visible = false;
                Q6.Visible = false;
                Q7.Visible = false;
                Q8.Visible = false;
                Q9.Visible = true;
                Q10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 9))
            {
                RadioButton1.Visible = false;
                Q2.Visible = false;
                Q3.Visible = false;
                Q4.Visible = false;
                Q5.Visible = false;
                Q6.Visible = false;
                Q7.Visible = false;
                Q8.Visible = false;
                Q9.Visible = false;
                Q10.Visible = true;
            }
        }

        private void Q2_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                if (Q2.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD FROM answer WHERE id =2", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label3.Text = red.GetValue(0).ToString();
                        redbtn1.Text = red.GetValue(1).ToString();
                        redbtn2.Text = red.GetValue(2).ToString();
                        redbtn3.Text = red.GetValue(3).ToString();
                        redbtn4.Text = red.GetValue(4).ToString();
                  
                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Q3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (Q3.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD FROM answer WHERE id =3", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label3.Text = red.GetValue(0).ToString();
                        redbtn1.Text = red.GetValue(1).ToString();
                        redbtn2.Text = red.GetValue(2).ToString();
                        redbtn3.Text = red.GetValue(3).ToString();
                        redbtn4.Text = red.GetValue(4).ToString();
                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Q4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (Q4.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD FROM answer WHERE id =4", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label3.Text = red.GetValue(0).ToString();
                        redbtn1.Text = red.GetValue(1).ToString();
                        redbtn2.Text = red.GetValue(2).ToString();
                        redbtn3.Text = red.GetValue(3).ToString();
                        redbtn4.Text = red.GetValue(4).ToString();
                        
                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
          
            


        }

        private void guna2RadioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (Q5.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD FROM answer WHERE id =5", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label3.Text = red.GetValue(0).ToString();
                        redbtn1.Text = red.GetValue(1).ToString();
                        redbtn2.Text = red.GetValue(2).ToString();
                        redbtn3.Text = red.GetValue(3).ToString();
                        redbtn4.Text = red.GetValue(4).ToString();
                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Q6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (Q6.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD FROM answer WHERE id =6", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label3.Text = red.GetValue(0).ToString();
                        redbtn1.Text = red.GetValue(1).ToString();
                        redbtn2.Text = red.GetValue(2).ToString();
                        redbtn3.Text = red.GetValue(3).ToString();
                        redbtn4.Text = red.GetValue(4).ToString();
                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Q7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (Q7.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD FROM answer WHERE id =7", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label3.Text = red.GetValue(0).ToString();
                        redbtn1.Text = red.GetValue(1).ToString();
                        redbtn2.Text = red.GetValue(2).ToString();
                        redbtn3.Text = red.GetValue(3).ToString();
                        redbtn4.Text = red.GetValue(4).ToString();
                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Q8_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (Q8.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD FROM answer WHERE id =8", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label3.Text = red.GetValue(0).ToString();
                        redbtn1.Text = red.GetValue(1).ToString();
                        redbtn2.Text = red.GetValue(2).ToString();
                        redbtn3.Text = red.GetValue(3).ToString();
                        redbtn4.Text = red.GetValue(4).ToString();
                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Q9_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (Q9.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD FROM answer WHERE id =9", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label3.Text = red.GetValue(0).ToString();
                        redbtn1.Text = red.GetValue(1).ToString();
                        redbtn2.Text = red.GetValue(2).ToString();
                        redbtn3.Text = red.GetValue(3).ToString();
                        redbtn4.Text = red.GetValue(4).ToString();
                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Q10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (Q10.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD FROM answer WHERE id =10", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label3.Text = red.GetValue(0).ToString();
                        redbtn1.Text = red.GetValue(1).ToString();
                        redbtn2.Text = red.GetValue(2).ToString();
                        redbtn3.Text = red.GetValue(3).ToString();
                        redbtn4.Text = red.GetValue(4).ToString();
                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
