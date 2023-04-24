namespace Prog_124_Static_Example_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenWindow_Click(object sender, EventArgs e)
        {
            new AddToList().Show();
        }

        private void btnUpdateHp_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbPlayers.SelectedIndex;
            int updatedHp = int.Parse(txtUpdatedHp.Text);
            DataClass._players[selectedIndex].Hp = updatedHp;
        }

        public void RefreshList()
        {
            lbPlayers.Items.Clear();
            foreach (Player item in DataClass._players)
            {
                lbPlayers.Items.Add(item);
            }
        } // RefreshList()



        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}