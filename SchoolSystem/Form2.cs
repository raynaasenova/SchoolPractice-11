using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class Form2 : Form
    {
        private string connString;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            string id = idStudentBox.Text;
            if (id == "")
            {
                MessageBox.Show("Задайте идентификатор");
            }
            else
            {
                //string connString = @"Server=localhost;Database=School;" + "Trusted_Connection=True;";
                //string queryString = "SELECT * FROM Student" + "WHERE idStudent = " + id + ";";
                //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Database=School;" + "Integrated Security=True;";
                string queryString = "SELECT * FROM Student" + "WHERE idStudent = " + id + ";";
                using (SqlConnection connection = new SqlConnection(connString))
                {SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        studNameBox.Text = reader[1].ToString();
                        studSurnameBox.Text = reader[2].ToString();
                        studFamilyBox.Text = reader[3].ToString();
                        studEmailBox.Text = reader[8].ToString();
                    }
                    button2.Enabled = true;
                }
            }
        }
    }
}
