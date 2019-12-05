using System;
using System.Windows.Forms;

namespace SAD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String username = this.dataSet1.get("joao@joao.pt", "joao");
            //this.userTableAdapter.NewUser("joao@joao.pt", "Joao", "Morada", "joao");
            String username = "";
            username = this.userTableAdapter.GetName("joao@joao.pt", "joao");
            MessageBox.Show(username);

        }

        private void WeSAVE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.databaseDataSet.User);

        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
    }
}
