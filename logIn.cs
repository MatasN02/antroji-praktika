using MySql.Data.MySqlClient;
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

namespace FormUI
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void Prisijungti_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(VartotojoVardas.Text == string.Empty))
                {
                    if (!(Slaptazodis.Text == string.Empty))
                    {
                        MySqlConnection connection = new MySqlConnection(helper.CnnVal("iverciusistema"));
                       
                        String query = "select * from admin where name = '" + VartotojoVardas.Text + "'and password = '" + this.Slaptazodis.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        connection.Open();


                        MySqlDataReader dbr;
                        dbr = cmd.ExecuteReader();
                        int count = 0;
                        while (dbr.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            this.Hide();
                            adminPanel f2 = new adminPanel(); //this is the change, code for redirect  
                            f2.ShowDialog();
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show(" username and password incorrect", "login page");
                        }

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show(" password empty", "login page");
                    }
                }
                else
                {
                    MessageBox.Show(" username empty", "login page");
                }
                // con.Close();  
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}

//MySqlConnection connection = new MySqlConnection(helper.CnnVal("iverciusistema")); connection string;

