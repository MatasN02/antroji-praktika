using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class grupes : Form
    {
        public grupes()
        {
            InitializeComponent();
        }

        private void grupes_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM grupe";

            ExecuteMySqlCommand executeMyCommand = new ExecuteMySqlCommand();
            dataGridView1.DataSource = executeMyCommand.getDataInListFormTable(query);

        }

        private void PridetiGrupe_Click(object sender, EventArgs e)
        {
            string grupesPavadinimas = GrupesPavTextBox.Text;
            
            string query = "INSERT INTO grupe (pavadinimas) VALUES (\""+grupesPavadinimas+"\");";

            ExecuteMySqlCommand runMyCommand = new ExecuteMySqlCommand();

            runMyCommand.executeNoReturnQuery(query);

            GrupesPavTextBox.Clear();

            grupes_Load(null, null);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string groupID;
            groupID = dataGridView1.Rows[e.RowIndex].Cells["grupesID"].Value.ToString();

            //MessageBox.Show(groupID);

             string getStudentsThatBelongToTheGroup = "SELECT * FROM studentas WHERE studentas.grupesID = \"" + groupID + "\" ";
            
            
             ExecuteMySqlCommand executeMyCommand = new ExecuteMySqlCommand();
             dataGridView2.DataSource = executeMyCommand.getDataInListFormTable(getStudentsThatBelongToTheGroup);
        }
    }
}
