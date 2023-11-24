using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
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
    public partial class StudentoPridejimoMeniu : Form
    {
        public void updateBinding()
        {
            groupsList.DataSource = grupes;
            groupsList.DisplayMember = "FullInfo";
        }

        public StudentoPridejimoMeniu()
        {
            InitializeComponent();
            updateBinding();
        }


        private void prideti_Click(object sender, EventArgs e)
        {

            string vardas1 = valVardas.Text;
            string pavarde1 = valPavarde.Text;
            string grupesPavadinimas = grupesPav.Text;

            string GroupIdQuery = "SELECT grupesID FROM grupe WHERE pavadinimas = \"" + grupesPavadinimas + "\"  ";

            ExecuteMySqlCommand runMyCommand = new ExecuteMySqlCommand();
            int groupIdNumber = runMyCommand.executeReturnQuery(GroupIdQuery);

         
            string query = "INSERT INTO studentas (grupesID, vardas, pavarde) VALUES (\""+groupIdNumber+"\", \"" + vardas1 + "\", \"" + pavarde1 + "\" )";

            runMyCommand.executeNoReturnQuery(query);

            valPavarde.Clear();
            valVardas.Clear();
            grupesPav.Clear();
        }

       
        List<grupe> grupes = new List<grupe>();

        private void refreshGroups_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            grupes = db.GetGrupes();
            updateBinding();
        }
    }
}
