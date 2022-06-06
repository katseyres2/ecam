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
    public partial class PartsStock : Form
    {
        string searchCriteria = "reference";
        string partInfo = "";
        List<string> clientParams = new List<string>();
        public PartsStock()
        {
            InitializeComponent();
            DataTable datas = GetData(String.Format("Select * from parts_stock"));
            dataGridView1.DataSource = datas;
            string[]  searchCriterions = new string[] { "reference", "name" };
            comboBox1.Items.AddRange(searchCriterions);
        }

        private static DataTable GetData(string sqlCommand)
        {
            Database db1 = new Database();
            MySqlConnection conn = new MySqlConnection(db1.MyConnection);
            

            MySqlCommand command = new MySqlCommand(sqlCommand, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instancier client
            if (clientParams.Count != 0)
            {
                
            }
            else
            {
            }
            
            clientParams.Clear();
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            partInfo = "";
            int column = 0;
            try
            {
                while (column < dataGridView1.ColumnCount)
                {
                    partInfo+=(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    clientParams.Add(dataGridView1.Rows[e.RowIndex].Cells[column].Value.ToString());
                    partInfo += " ";                  
                    column++;
                }
                label2.Text = partInfo;
            }
            catch{
                label2.Text = "";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable datas;
            datas = GetData(String.Format("Select * From client where {0} like '{1}%'", searchCriteria, textBox1.Text));
            datas.Columns.RemoveAt(0);
            dataGridView1.DataSource = datas;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCriteria = comboBox1.SelectedItem.ToString();
        }
    }
}
