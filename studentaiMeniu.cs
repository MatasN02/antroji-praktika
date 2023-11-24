using MySql.Data.MySqlClient;

namespace FormUI
{
    public partial class studentaiMeniu : Form
    {
        List<studentas> studentai = new List<studentas>();

        public void updateBinding()
        {
            StudentaiListBox.DataSource = studentai;
            StudentaiListBox.DisplayMember = "FullInfo";
        }

        public studentaiMeniu()
        {
            InitializeComponent();
            updateBinding();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            studentai = db.GetPeople();
            updateBinding();
        }

        private void IterptiStudent�_Click(object sender, EventArgs e)
        {
            StudentoPridejimoMeniu SpridejimoMeniu = new StudentoPridejimoMeniu();
            SpridejimoMeniu.Show();
        }

        private void removeStudentFromTheList_Click(object sender, EventArgs e)
        { 
            string naikinamoStudentoId = SalinamasStudentasTextBox.Text;

            
            ExecuteMySqlCommand executeMyCommand = new ExecuteMySqlCommand();
          
            string query1 = "DELETE FROM pazymys WHERE studentoID=" + naikinamoStudentoId + " ";
            string query2 = "DELETE FROM studentas WHERE studentoID=" + naikinamoStudentoId + " ";

            executeMyCommand.executeNoReturnQuery(query1);
            executeMyCommand.executeNoReturnQuery(query2);

            SalinamasStudentasTextBox.Clear();
        }
    }
}
    





