namespace Better_Services
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startServiceBtn = new System.Windows.Forms.Button();
            this.stoppedSortedBy = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aktionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRefreshAktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funktionsübersichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überDieseAnwendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.runningSortedBy = new System.Windows.Forms.ComboBox();
            this.stopServiceBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.runningList = new System.Windows.Forms.ListBox();
            this.stoppedList = new System.Windows.Forms.ListBox();
            this.roundedPanel1 = new RoundedPanel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Running services";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stopped services";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startServiceBtn);
            this.panel1.Controls.Add(this.stoppedSortedBy);
            this.panel1.Location = new System.Drawing.Point(17, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 30);
            this.panel1.TabIndex = 6;
            // 
            // startServiceBtn
            // 
            this.startServiceBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startServiceBtn.Enabled = false;
            this.startServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startServiceBtn.Font = new System.Drawing.Font("Arial", 10F);
            this.startServiceBtn.ForeColor = System.Drawing.Color.Black;
            this.startServiceBtn.Location = new System.Drawing.Point(155, 1);
            this.startServiceBtn.Name = "startServiceBtn";
            this.startServiceBtn.Size = new System.Drawing.Size(84, 23);
            this.startServiceBtn.TabIndex = 3;
            this.startServiceBtn.Text = "Start";
            this.startServiceBtn.UseVisualStyleBackColor = false;
            this.startServiceBtn.Click += new System.EventHandler(this.startServiceBtn_Click);
            // 
            // stoppedSortedBy
            // 
            this.stoppedSortedBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stoppedSortedBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stoppedSortedBy.Font = new System.Drawing.Font("Arial", 9F);
            this.stoppedSortedBy.ForeColor = System.Drawing.Color.Black;
            this.stoppedSortedBy.FormattingEnabled = true;
            this.stoppedSortedBy.Items.AddRange(new object[] {
            "Sorted by (Default)",
            "Ascending (A-Z)",
            "Descending (Z-A)"});
            this.stoppedSortedBy.Location = new System.Drawing.Point(5, 3);
            this.stoppedSortedBy.Name = "stoppedSortedBy";
            this.stoppedSortedBy.Size = new System.Drawing.Size(144, 25);
            this.stoppedSortedBy.TabIndex = 0;
            this.stoppedSortedBy.Text = "Sorted by (Default)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktionenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 38);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aktionenToolStripMenuItem
            // 
            this.aktionenToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.aktionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktualisierenToolStripMenuItem,
            this.autoRefreshAktivierenToolStripMenuItem});
            this.aktionenToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F);
            this.aktionenToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aktionenToolStripMenuItem.Name = "aktionenToolStripMenuItem";
            this.aktionenToolStripMenuItem.Size = new System.Drawing.Size(60, 34);
            this.aktionenToolStripMenuItem.Text = "Action";
            // 
            // aktualisierenToolStripMenuItem
            // 
            this.aktualisierenToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.aktualisierenToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aktualisierenToolStripMenuItem.Name = "aktualisierenToolStripMenuItem";
            this.aktualisierenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.aktualisierenToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.aktualisierenToolStripMenuItem.Text = "Refresh (manually)";
            this.aktualisierenToolStripMenuItem.Click += new System.EventHandler(this.aktualisierenToolStripMenuItem_Click);
            // 
            // autoRefreshAktivierenToolStripMenuItem
            // 
            this.autoRefreshAktivierenToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.autoRefreshAktivierenToolStripMenuItem.CheckOnClick = true;
            this.autoRefreshAktivierenToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.autoRefreshAktivierenToolStripMenuItem.Name = "autoRefreshAktivierenToolStripMenuItem";
            this.autoRefreshAktivierenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.autoRefreshAktivierenToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.autoRefreshAktivierenToolStripMenuItem.Text = "Auto Refresh";
            this.autoRefreshAktivierenToolStripMenuItem.Click += new System.EventHandler(this.autoRefreshAktivierenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funktionsübersichtToolStripMenuItem,
            this.überDieseAnwendToolStripMenuItem});
            this.hilfeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F);
            this.hilfeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(29, 34);
            this.hilfeToolStripMenuItem.Text = "?";
            // 
            // funktionsübersichtToolStripMenuItem
            // 
            this.funktionsübersichtToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.funktionsübersichtToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.funktionsübersichtToolStripMenuItem.Name = "funktionsübersichtToolStripMenuItem";
            this.funktionsübersichtToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.funktionsübersichtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.funktionsübersichtToolStripMenuItem.Text = "Help";
            this.funktionsübersichtToolStripMenuItem.Click += new System.EventHandler(this.funktionsübersichtToolStripMenuItem_Click);
            // 
            // überDieseAnwendToolStripMenuItem
            // 
            this.überDieseAnwendToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.überDieseAnwendToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.überDieseAnwendToolStripMenuItem.Name = "überDieseAnwendToolStripMenuItem";
            this.überDieseAnwendToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.überDieseAnwendToolStripMenuItem.Text = "About this Application";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.restartBtn);
            this.panel2.Controls.Add(this.stopServiceBtn);
            this.panel2.Controls.Add(this.runningSortedBy);
            this.panel2.Location = new System.Drawing.Point(17, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 30);
            this.panel2.TabIndex = 5;
            // 
            // runningSortedBy
            // 
            this.runningSortedBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.runningSortedBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runningSortedBy.Font = new System.Drawing.Font("Arial", 9F);
            this.runningSortedBy.ForeColor = System.Drawing.Color.Black;
            this.runningSortedBy.FormattingEnabled = true;
            this.runningSortedBy.Items.AddRange(new object[] {
            "Sorted by (Default)",
            "Ascending (A-Z)",
            "Descending (Z-A)"});
            this.runningSortedBy.Location = new System.Drawing.Point(5, 3);
            this.runningSortedBy.Name = "runningSortedBy";
            this.runningSortedBy.Size = new System.Drawing.Size(144, 25);
            this.runningSortedBy.TabIndex = 0;
            this.runningSortedBy.Text = "Sorted by (Default)";
            // 
            // stopServiceBtn
            // 
            this.stopServiceBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stopServiceBtn.Enabled = false;
            this.stopServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stopServiceBtn.Font = new System.Drawing.Font("Arial", 10F);
            this.stopServiceBtn.ForeColor = System.Drawing.Color.Black;
            this.stopServiceBtn.Location = new System.Drawing.Point(155, 1);
            this.stopServiceBtn.Name = "stopServiceBtn";
            this.stopServiceBtn.Size = new System.Drawing.Size(84, 23);
            this.stopServiceBtn.TabIndex = 1;
            this.stopServiceBtn.Text = "Stop";
            this.stopServiceBtn.UseVisualStyleBackColor = false;
            this.stopServiceBtn.Click += new System.EventHandler(this.stopServiceBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.restartBtn.Enabled = false;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.restartBtn.Font = new System.Drawing.Font("Arial", 10F);
            this.restartBtn.ForeColor = System.Drawing.Color.Black;
            this.restartBtn.Location = new System.Drawing.Point(245, 1);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(84, 23);
            this.restartBtn.TabIndex = 2;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            // 
            // runningList
            // 
            this.runningList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.runningList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.runningList.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningList.ForeColor = System.Drawing.Color.Black;
            this.runningList.FormattingEnabled = true;
            this.runningList.HorizontalExtent = 20;
            this.runningList.ItemHeight = 19;
            this.runningList.Location = new System.Drawing.Point(17, 168);
            this.runningList.Margin = new System.Windows.Forms.Padding(10);
            this.runningList.Name = "runningList";
            this.runningList.Size = new System.Drawing.Size(765, 266);
            this.runningList.TabIndex = 0;
            // 
            // stoppedList
            // 
            this.stoppedList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stoppedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stoppedList.Font = new System.Drawing.Font("Arial", 8.25F);
            this.stoppedList.ForeColor = System.Drawing.Color.Black;
            this.stoppedList.FormattingEnabled = true;
            this.stoppedList.ItemHeight = 16;
            this.stoppedList.Location = new System.Drawing.Point(16, 525);
            this.stoppedList.Margin = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.stoppedList.Name = "stoppedList";
            this.stoppedList.Size = new System.Drawing.Size(765, 272);
            this.stoppedList.TabIndex = 3;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel1.Controls.Add(this.searchBar);
            this.roundedPanel1.Controls.Add(this.searchBtn);
            this.roundedPanel1.Location = new System.Drawing.Point(17, 44);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(765, 39);
            this.roundedPanel1.TabIndex = 11;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchBar.ForeColor = System.Drawing.Color.Black;
            this.searchBar.Location = new System.Drawing.Point(19, 11);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(633, 19);
            this.searchBar.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchBtn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(651, 0);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(3);
            this.searchBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBtn.Size = new System.Drawing.Size(114, 39);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 813);
            this.Controls.Add(this.runningList);
            this.Controls.Add(this.stoppedList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox stoppedList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox stoppedSortedBy;
        private System.Windows.Forms.Button startServiceBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aktionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRefreshAktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funktionsübersichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überDieseAnwendToolStripMenuItem;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button searchBtn;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button stopServiceBtn;
        private System.Windows.Forms.ComboBox runningSortedBy;
        private System.Windows.Forms.ListBox runningList;
    }
}

