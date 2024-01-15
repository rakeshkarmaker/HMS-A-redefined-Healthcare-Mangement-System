using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using PatientDashboard;
using AdminDashboard;

namespace Healthcare_Management_System.Forms
{
    public partial class LoginForm : Form
    {

        //CS => Connection String
        string cs_Str = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "") { MessageBox.Show("Please select account type first!"); }
            else
            {

                if (comboBox1.Text == "Patient")
                {
                    SqlConnection con = new SqlConnection(cs_Str); //SQL CONNECTION CLASS
                    String query = "SELECT * FROM PATIENT_LOGIN WHERE patient_ID =@user AND patient_pass = @pass"; //Writing Query in the string
                                                                                                                   // Here the query command has been send via Passing the SQL connection class and passing the quary as parameters.
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", textBox1.Text); // Saying what is what
                    cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                    //Opening a connection for use
                    con.Open(); //must close after use, otherwise potential errors are inevitable


                    //Reading data or, executing the task!
                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr.HasRows == true)
                    {
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        FormMainMenu formPDashboard = new FormMainMenu(textBox1.Text);
                        this.Hide();
                        formPDashboard.Show();



                    }
                    else
                    {
                        MessageBox.Show("Wrong  Username or password. Try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                if (comboBox1.Text == "Doctor")
                {

                }
                if (comboBox1.Text == "Hospital")
                {

                }
                if (comboBox1.Text == "Administrator")
                {
                    {
                        SqlConnection con = new SqlConnection(cs_Str); //SQL CONNECTION CLASS
                        String query = "SELECT * FROM ADMIN_LOGIN WHERE ADMIN_ID =@user AND ADMIN_PASS = @pass"; //Writing Query in the string
                                                                                                                       // Here the query command has been send via Passing the SQL connection class and passing the quary as parameters.
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@user", textBox1.Text); // Saying what is what
                        cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                        //Opening a connection for use
                        con.Open(); //must close after use, otherwise potential errors are inevitable


                        //Reading data or, executing the task!
                        SqlDataReader dr = cmd.ExecuteReader();


                        if (dr.HasRows == true)
                        {
                            MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FormAdminDashboard formDash = new FormAdminDashboard(textBox1.Text);
                            this.Hide();
                            formDash.Show();



                        }
                        else
                        {
                            MessageBox.Show("Wrong  Username or password. Try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                      
                    }
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

             bool isChecked = checkBox1.Checked;

                switch (isChecked)
                {
                    case true:
                        textBox2.UseSystemPasswordChar = false;
                        break;
                    default:
                        textBox2.UseSystemPasswordChar = true;
                        break;

                }
            }
    }
    }

