﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bovelo
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            show_table();
        }

        private void show_table()
        {
            Database db1 = new Database();
            MySqlConnection conn = new MySqlConnection(db1.MyConnection);
       
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine("Connected");

                string sql = "SELECT * FROM client;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                label_db_clients.Items.Clear();

                while (rdr.Read())
                {
                    
                    label_db_clients.Items.Add(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();
            }

            catch (Exception ex)

            {
                label_first_name.Text = ex.ToString();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox_lastname.Text != null && this.textBox_firstname.Text != null && this.textBox_country.Text != null && this.textBox_city.Text != null && this.textBox_street.Text != null && Convert.ToInt32(this.numericUpDown1.Value) > 0 && Convert.ToInt32(this.numericUpDown_zipcode.Value) > 0 && this.textBox_phonenumber.Text != null && this.textBox_email.Text != null)
            {
                Client client = new Client(this.textBox_lastname.Text, this.textBox_firstname.Text, this.textBox_country.Text, this.textBox_city.Text, this.textBox_street.Text, Convert.ToInt32(this.numericUpDown1.Value), Convert.ToInt32(this.numericUpDown_zipcode.Value), this.textBox_phonenumber.Text, this.textBox_email.Text);
                client.Save();
                show_table(); //call function defined earlier to connect to database and show data on a label 
            }
            else
            {
                MessageBox.Show("Missing required personnal details");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
