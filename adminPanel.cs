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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void EnterStudentai_Click(object sender, EventArgs e)
        {
            studentaiMeniu studentuSarasas = new studentaiMeniu();
            studentuSarasas.Show();

        }

        private void EnterStudGrupes_Click(object sender, EventArgs e)
        {
            grupes groupePanel1 = new grupes();
            groupePanel1.Show();
        }
    }
}
