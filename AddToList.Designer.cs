namespace Prog_124_Static_Example_Winform
{
    partial class AddToList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvPlayerList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label1 = new Label();
            txtName = new TextBox();
            txtHp = new TextBox();
            label2 = new Label();
            btnAddPlayer = new Button();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // lvPlayerList
            // 
            lvPlayerList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvPlayerList.Location = new Point(655, 28);
            lvPlayerList.Name = "lvPlayerList";
            lvPlayerList.Size = new Size(545, 578);
            lvPlayerList.TabIndex = 0;
            lvPlayerList.UseCompatibleStateImageBehavior = false;
            lvPlayerList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Hp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 142);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 142);
            txtName.Name = "txtName";
            txtName.Size = new Size(354, 35);
            txtName.TabIndex = 2;
            // 
            // txtHp
            // 
            txtHp.Location = new Point(177, 218);
            txtHp.Name = "txtHp";
            txtHp.Size = new Size(354, 35);
            txtHp.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 218);
            label2.Name = "label2";
            label2.Size = new Size(40, 30);
            label2.TabIndex = 3;
            label2.Text = "Hp";
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(199, 330);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(268, 40);
            btnAddPlayer.TabIndex = 5;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(873, 639);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 40);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh List";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // AddToList
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1265, 722);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddPlayer);
            Controls.Add(txtHp);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(lvPlayerList);
            Name = "AddToList";
            Text = "AddToList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvPlayerList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label1;
        private TextBox txtName;
        private TextBox txtHp;
        private Label label2;
        private Button btnAddPlayer;
        private Button btnRefresh;
    }
}