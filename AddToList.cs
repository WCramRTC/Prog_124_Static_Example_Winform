using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_124_Static_Example_Winform
{
    public partial class AddToList : Form
    {
        public AddToList()
        {
            InitializeComponent();

        } // AddToList()

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int hp = int.Parse(txtHp.Text);

            Player player = new Player(name, hp);

            DataClass.AddPlayer(player);
        } // btnAddPlayer_Click()



        private void RefreshList()
        {
            lvPlayerList.Items.Clear();
            foreach (Player item in DataClass._players)
            {
                string[] info =
                {
                    item.Name,
                    item.Hp.ToString()
                };

                ListViewItem lvi = new ListViewItem(info);
                lvPlayerList.Items.Add(lvi);

            }
        } // RefreshList()

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        } // btnRefresh_Click
    }
}
