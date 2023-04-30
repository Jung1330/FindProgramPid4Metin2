
namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            this.WithButtonButton = new System.Windows.Forms.Button();
            this.WithButtonServerPidTextBox = new System.Windows.Forms.TextBox();
            this.WithButtonSvNameTextBox = new System.Windows.Forms.TextBox();
            this.WithButtonSvnameLabel = new System.Windows.Forms.Label();
            this.PidLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SafeButtonCheckBox = new System.Windows.Forms.CheckBox();
            this.ServerCombo = new System.Windows.Forms.ComboBox();
            this.ServerBin = new System.Windows.Forms.Label();
            this.Modernize = new System.Windows.Forms.GroupBox();
            this.ServerPid = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.Label();
            this.SafeTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ServerListBox = new System.Windows.Forms.ListBox();
            this.Randomname = new System.Windows.Forms.Timer(this.components);
            this.ServerListLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Modernize.SuspendLayout();
            this.SuspendLayout();
            // 
            // WithButtonButton
            // 
            this.WithButtonButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.WithButtonButton.Location = new System.Drawing.Point(6, 105);
            this.WithButtonButton.Name = "WithButtonButton";
            this.WithButtonButton.Size = new System.Drawing.Size(100, 23);
            this.WithButtonButton.TabIndex = 0;
            this.WithButtonButton.Text = "GetPid";
            this.WithButtonButton.UseVisualStyleBackColor = true;
            this.WithButtonButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WithButtonServerPidTextBox
            // 
            this.WithButtonServerPidTextBox.Location = new System.Drawing.Point(6, 79);
            this.WithButtonServerPidTextBox.Name = "WithButtonServerPidTextBox";
            this.WithButtonServerPidTextBox.Size = new System.Drawing.Size(100, 20);
            this.WithButtonServerPidTextBox.TabIndex = 2;
            // 
            // WithButtonSvNameTextBox
            // 
            this.WithButtonSvNameTextBox.Location = new System.Drawing.Point(6, 40);
            this.WithButtonSvNameTextBox.Name = "WithButtonSvNameTextBox";
            this.WithButtonSvNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.WithButtonSvNameTextBox.TabIndex = 3;
            // 
            // WithButtonSvnameLabel
            // 
            this.WithButtonSvnameLabel.AutoSize = true;
            this.WithButtonSvnameLabel.Location = new System.Drawing.Point(24, 24);
            this.WithButtonSvnameLabel.Name = "WithButtonSvnameLabel";
            this.WithButtonSvnameLabel.Size = new System.Drawing.Size(46, 13);
            this.WithButtonSvnameLabel.TabIndex = 4;
            this.WithButtonSvnameLabel.Text = "Svname";
            // 
            // PidLabel
            // 
            this.PidLabel.AutoSize = true;
            this.PidLabel.Location = new System.Drawing.Point(6, 63);
            this.PidLabel.Name = "PidLabel";
            this.PidLabel.Size = new System.Drawing.Size(25, 13);
            this.PidLabel.TabIndex = 5;
            this.PidLabel.Text = "???";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WithButtonButton);
            this.groupBox1.Controls.Add(this.PidLabel);
            this.groupBox1.Controls.Add(this.WithButtonServerPidTextBox);
            this.groupBox1.Controls.Add(this.WithButtonSvnameLabel);
            this.groupBox1.Controls.Add(this.WithButtonSvNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "w\\button";
            // 
            // SafeButtonCheckBox
            // 
            this.SafeButtonCheckBox.AutoSize = true;
            this.SafeButtonCheckBox.Location = new System.Drawing.Point(6, 22);
            this.SafeButtonCheckBox.Name = "SafeButtonCheckBox";
            this.SafeButtonCheckBox.Size = new System.Drawing.Size(85, 17);
            this.SafeButtonCheckBox.TabIndex = 8;
            this.SafeButtonCheckBox.Text = "Find Pid (F2)";
            this.SafeButtonCheckBox.UseVisualStyleBackColor = true;
            this.SafeButtonCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ServerCombo
            // 
            this.ServerCombo.FormattingEnabled = true;
            this.ServerCombo.Items.AddRange(new object[] {
            "Aeldra",
            "Wom2",
            "Mercure2"});
            this.ServerCombo.Location = new System.Drawing.Point(6, 45);
            this.ServerCombo.Name = "ServerCombo";
            this.ServerCombo.Size = new System.Drawing.Size(100, 21);
            this.ServerCombo.TabIndex = 9;
            // 
            // ServerBin
            // 
            this.ServerBin.AutoSize = true;
            this.ServerBin.Location = new System.Drawing.Point(6, 82);
            this.ServerBin.Name = "ServerBin";
            this.ServerBin.Size = new System.Drawing.Size(13, 13);
            this.ServerBin.TabIndex = 11;
            this.ServerBin.Text = "0";
            // 
            // Modernize
            // 
            this.Modernize.Controls.Add(this.ServerPid);
            this.Modernize.Controls.Add(this.ServerName);
            this.Modernize.Controls.Add(this.ServerCombo);
            this.Modernize.Controls.Add(this.ServerBin);
            this.Modernize.Controls.Add(this.SafeButtonCheckBox);
            this.Modernize.Location = new System.Drawing.Point(12, 161);
            this.Modernize.Name = "Modernize";
            this.Modernize.Size = new System.Drawing.Size(115, 117);
            this.Modernize.TabIndex = 12;
            this.Modernize.TabStop = false;
            this.Modernize.Text = "F2";
            // 
            // ServerPid
            // 
            this.ServerPid.AutoSize = true;
            this.ServerPid.Location = new System.Drawing.Point(6, 95);
            this.ServerPid.Name = "ServerPid";
            this.ServerPid.Size = new System.Drawing.Size(28, 13);
            this.ServerPid.TabIndex = 13;
            this.ServerPid.Text = "Pid :";
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Location = new System.Drawing.Point(6, 69);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(66, 13);
            this.ServerName.TabIndex = 12;
            this.ServerName.Text = "ServerName";
            // 
            // SafeTimer
            // 
            this.SafeTimer.Tick += new System.EventHandler(this.SafeTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ServerListBox
            // 
            this.ServerListBox.FormattingEnabled = true;
            this.ServerListBox.Items.AddRange(new object[] {
            "Aeldra = 1",
            "Wom2 = 2",
            "Mercure = 3"});
            this.ServerListBox.Location = new System.Drawing.Point(133, 40);
            this.ServerListBox.Name = "ServerListBox";
            this.ServerListBox.Size = new System.Drawing.Size(107, 212);
            this.ServerListBox.TabIndex = 13;
            // 
            // Randomname
            // 
            this.Randomname.Enabled = true;
            this.Randomname.Tick += new System.EventHandler(this.Randomname_Tick);
            // 
            // ServerListLabel
            // 
            this.ServerListLabel.AutoSize = true;
            this.ServerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ServerListLabel.ForeColor = System.Drawing.Color.Green;
            this.ServerListLabel.Location = new System.Drawing.Point(141, 16);
            this.ServerListLabel.Name = "ServerListLabel";
            this.ServerListLabel.Size = new System.Drawing.Size(91, 20);
            this.ServerListLabel.TabIndex = 14;
            this.ServerListLabel.Text = "Server List";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Resume ->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ServerListLabel);
            this.Controls.Add(this.ServerListBox);
            this.Controls.Add(this.Modernize);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Modernize.ResumeLayout(false);
            this.Modernize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WithButtonButton;
        private System.Windows.Forms.TextBox WithButtonServerPidTextBox;
        private System.Windows.Forms.TextBox WithButtonSvNameTextBox;
        private System.Windows.Forms.Label WithButtonSvnameLabel;
        private System.Windows.Forms.Label PidLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SafeButtonCheckBox;
        private System.Windows.Forms.ComboBox ServerCombo;
        private System.Windows.Forms.Label ServerBin;
        private System.Windows.Forms.GroupBox Modernize;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Timer SafeTimer;
        private System.Windows.Forms.Label ServerPid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox ServerListBox;
        private System.Windows.Forms.Timer Randomname;
        private System.Windows.Forms.Label ServerListLabel;
        private System.Windows.Forms.Button button1;
    }
}

