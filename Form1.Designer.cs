namespace Prog_124_Static_Example_Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenWindow = new Button();
            lbPlayers = new ListBox();
            label1 = new Label();
            txtUpdatedHp = new TextBox();
            btnUpdateHp = new Button();
            btnRefreshList = new Button();
            SuspendLayout();
            // 
            // btnOpenWindow
            // 
            btnOpenWindow.Location = new Point(1017, 593);
            btnOpenWindow.Name = "btnOpenWindow";
            btnOpenWindow.Size = new Size(178, 40);
            btnOpenWindow.TabIndex = 0;
            btnOpenWindow.Text = "Open New Window";
            btnOpenWindow.UseVisualStyleBackColor = true;
            btnOpenWindow.Click += btnOpenWindow_Click;
            // 
            // lbPlayers
            // 
            lbPlayers.FormattingEnabled = true;
            lbPlayers.ItemHeight = 30;
            lbPlayers.Location = new Point(696, 34);
            lbPlayers.Name = "lbPlayers";
            lbPlayers.Size = new Size(499, 484);
            lbPlayers.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 282);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 2;
            label1.Text = "New Hp";
            // 
            // txtUpdatedHp
            // 
            txtUpdatedHp.Location = new Point(221, 279);
            txtUpdatedHp.Name = "txtUpdatedHp";
            txtUpdatedHp.Size = new Size(175, 35);
            txtUpdatedHp.TabIndex = 3;
            // 
            // btnUpdateHp
            // 
            btnUpdateHp.Location = new Point(433, 277);
            btnUpdateHp.Name = "btnUpdateHp";
            btnUpdateHp.Size = new Size(131, 40);
            btnUpdateHp.TabIndex = 4;
            btnUpdateHp.Text = "Update";
            btnUpdateHp.UseVisualStyleBackColor = true;
            btnUpdateHp.Click += btnUpdateHp_Click;
            // 
            // btnRefreshList
            // 
            btnRefreshList.Location = new Point(878, 536);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new Size(131, 40);
            btnRefreshList.TabIndex = 5;
            btnRefreshList.Text = "Refresh List";
            btnRefreshList.UseVisualStyleBackColor = true;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 676);
            Controls.Add(btnRefreshList);
            Controls.Add(btnUpdateHp);
            Controls.Add(txtUpdatedHp);
            Controls.Add(label1);
            Controls.Add(lbPlayers);
            Controls.Add(btnOpenWindow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenWindow;
        private ListBox lbPlayers;
        private Label label1;
        private TextBox txtUpdatedHp;
        private Button btnUpdateHp;
        private Button btnRefreshList;
    }
}