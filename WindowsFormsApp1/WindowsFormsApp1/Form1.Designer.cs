namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPanel1 = new System.Windows.Forms.ComboBox();
            this.buttonOKTeamData = new System.Windows.Forms.Button();
            this.labelPlayerIdentity = new System.Windows.Forms.Label();
            this.labelManagerIdentity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxPanel2 = new System.Windows.Forms.ComboBox();
            this.buttonOkFindMatch = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamDataToolStripMenuItem,
            this.findMatchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // teamDataToolStripMenuItem
            // 
            this.teamDataToolStripMenuItem.Name = "teamDataToolStripMenuItem";
            this.teamDataToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.teamDataToolStripMenuItem.Text = "Team Data";
            this.teamDataToolStripMenuItem.Click += new System.EventHandler(this.teamDataToolStripMenuItem_Click);
            // 
            // findMatchToolStripMenuItem
            // 
            this.findMatchToolStripMenuItem.Name = "findMatchToolStripMenuItem";
            this.findMatchToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.findMatchToolStripMenuItem.Text = "Find Match";
            this.findMatchToolStripMenuItem.Click += new System.EventHandler(this.findMatchToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelManagerIdentity);
            this.panel1.Controls.Add(this.labelPlayerIdentity);
            this.panel1.Controls.Add(this.buttonOKTeamData);
            this.panel1.Controls.Add(this.comboBoxPanel1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 306);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxPanel1
            // 
            this.comboBoxPanel1.FormattingEnabled = true;
            this.comboBoxPanel1.Location = new System.Drawing.Point(14, 12);
            this.comboBoxPanel1.Name = "comboBoxPanel1";
            this.comboBoxPanel1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPanel1.TabIndex = 0;
            this.comboBoxPanel1.SelectedIndexChanged += new System.EventHandler(this.comboBoxPanel1_SelectedIndexChanged);
            // 
            // buttonOKTeamData
            // 
            this.buttonOKTeamData.Location = new System.Drawing.Point(159, 12);
            this.buttonOKTeamData.Name = "buttonOKTeamData";
            this.buttonOKTeamData.Size = new System.Drawing.Size(75, 23);
            this.buttonOKTeamData.TabIndex = 1;
            this.buttonOKTeamData.Text = "OK";
            this.buttonOKTeamData.UseVisualStyleBackColor = true;
            this.buttonOKTeamData.Click += new System.EventHandler(this.buttonOKTeamData_Click);
            // 
            // labelPlayerIdentity
            // 
            this.labelPlayerIdentity.AutoSize = true;
            this.labelPlayerIdentity.Location = new System.Drawing.Point(11, 58);
            this.labelPlayerIdentity.Name = "labelPlayerIdentity";
            this.labelPlayerIdentity.Size = new System.Drawing.Size(73, 13);
            this.labelPlayerIdentity.TabIndex = 2;
            this.labelPlayerIdentity.Text = "Player Identity";
            // 
            // labelManagerIdentity
            // 
            this.labelManagerIdentity.AutoSize = true;
            this.labelManagerIdentity.Location = new System.Drawing.Point(327, 58);
            this.labelManagerIdentity.Name = "labelManagerIdentity";
            this.labelManagerIdentity.Size = new System.Drawing.Size(86, 13);
            this.labelManagerIdentity.TabIndex = 3;
            this.labelManagerIdentity.Text = "Manager Identity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(276, 202);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(330, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(276, 202);
            this.dataGridView2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.buttonOkFindMatch);
            this.panel2.Controls.Add(this.comboBoxPanel2);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 307);
            this.panel2.TabIndex = 2;
            // 
            // comboBoxPanel2
            // 
            this.comboBoxPanel2.FormattingEnabled = true;
            this.comboBoxPanel2.Location = new System.Drawing.Point(14, 15);
            this.comboBoxPanel2.Name = "comboBoxPanel2";
            this.comboBoxPanel2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPanel2.TabIndex = 0;
            this.comboBoxPanel2.SelectedIndexChanged += new System.EventHandler(this.comboBoxPanel2_SelectedIndexChanged);
            // 
            // buttonOkFindMatch
            // 
            this.buttonOkFindMatch.Location = new System.Drawing.Point(141, 15);
            this.buttonOkFindMatch.Name = "buttonOkFindMatch";
            this.buttonOkFindMatch.Size = new System.Drawing.Size(75, 23);
            this.buttonOkFindMatch.TabIndex = 1;
            this.buttonOkFindMatch.Text = "OK";
            this.buttonOkFindMatch.UseVisualStyleBackColor = true;
            this.buttonOkFindMatch.Click += new System.EventHandler(this.buttonOkFindMatch_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(14, 58);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(494, 230);
            this.dataGridView3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMatchToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPlayerIdentity;
        private System.Windows.Forms.Button buttonOKTeamData;
        private System.Windows.Forms.ComboBox comboBoxPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxPanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelManagerIdentity;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonOkFindMatch;
    }
}

