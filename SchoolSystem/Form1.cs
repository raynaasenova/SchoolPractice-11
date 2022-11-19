using System;
using System.Data.SqlClient;
using System.Drawing;
//using System.Drawing;
using System.Windows.Forms;


namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static SchoolData schData = new SchoolData();

        public class GetData
        {
            //static string connString = @"Server=localhost;Database=School; " + "Trusted_Connection = True;";
            static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Database=School;" + "Integrated Security=True;";
            static string queryString = "SELECT name, patron, city, " + " district, address, web_site, telephone FROM School_data";
            public static void ShowData()
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            schData.name = reader[0].ToString();
                            schData.patron = reader[1].ToString();
                            schData.city = reader[2].ToString();
                            schData.district = reader[3].ToString();
                            schData.address = reader[4].ToString();
                            schData.web_site = reader[5].ToString();
                            schData.telephone = reader[6].ToString();
                        }
                    }
                }
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           GetData.ShowData();
            //public string Trim (params char[]? trimChars);
            //string name = ((firstName.Trim() + " " + middleName.Trim()).Trim() + " " + lastName.Trim()).Trim();
            schoolNameLabel.Text = schData.name.Trim();
            schoolPatronLabel.Text = schData.patron;
            schoolDistrictLabel.Text = "гр. " + schData.city.Trim();
            schoolDistrictLabel.Text = "обл. " + schData.district;
            schoolAddressLabel.Text = schData.address.Trim();
            schoolWebpageLabel.Text = "сайт " + schData.web_site;
            schoolTelephoneLabel.Text = "тел. " + schData.telephone;
            Bitmap image = new Bitmap("C:\\SchoolSystem\\Resurses\\logo.png");
            pictureBox.Image = image;
        }
        private void button1_Click(object sender, EventArgs e)
            {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Database=School;" + "Integrated Security=True;";
            string queryString = "SELECT idStudent, name, surname, family " + "FROM Student ORDER BY idStudent";            
            string row;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    Console.WriteLine("State: {0}", connection.State);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            row = ((int)reader[0]).ToString();
                            row = row + reader[1].ToString();
                            row = row + reader[2].ToString();
                            row = row + reader[3].ToString();                        
                        listBox1.Items.Add(row);
                        }
                    }
                }
                listBox1.Visible = true;
            }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        public static Form2 studEdit;
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (studEdit != null)
            {
                studEdit.BringToFront();
            }
            else
            {
                studEdit = new Form2();
                studEdit.FormClosed += delegate { studEdit = null; };
                studEdit.Show(this);
            }
        }
    }
    }

