namespace Respond_bot
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChatlogGB = new System.Windows.Forms.GroupBox();
            this.ChatlogRTB = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UsernameLBLtext = new System.Windows.Forms.Label();
            this.BotUsernameLBL = new System.Windows.Forms.Label();
            this.BotNameLBL = new System.Windows.Forms.Label();
            this.NameLBL = new System.Windows.Forms.Label();
            this.BotIDlbl = new System.Windows.Forms.Label();
            this.idLBL = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ChatlogGB.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 260);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChatlogGB);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chatlog";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChatlogGB
            // 
            this.ChatlogGB.Controls.Add(this.ChatlogRTB);
            this.ChatlogGB.Location = new System.Drawing.Point(18, 15);
            this.ChatlogGB.Name = "ChatlogGB";
            this.ChatlogGB.Size = new System.Drawing.Size(526, 199);
            this.ChatlogGB.TabIndex = 0;
            this.ChatlogGB.TabStop = false;
            this.ChatlogGB.Text = "Chatlog";
            // 
            // ChatlogRTB
            // 
            this.ChatlogRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatlogRTB.EnableAutoDragDrop = true;
            this.ChatlogRTB.Location = new System.Drawing.Point(6, 13);
            this.ChatlogRTB.Name = "ChatlogRTB";
            this.ChatlogRTB.ReadOnly = true;
            this.ChatlogRTB.Size = new System.Drawing.Size(514, 180);
            this.ChatlogRTB.TabIndex = 0;
            this.ChatlogRTB.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Respond_bot.Properties.Resources.shittybanner;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 102);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BotIDlbl);
            this.groupBox1.Controls.Add(this.idLBL);
            this.groupBox1.Controls.Add(this.BotNameLBL);
            this.groupBox1.Controls.Add(this.NameLBL);
            this.groupBox1.Controls.Add(this.BotUsernameLBL);
            this.groupBox1.Controls.Add(this.UsernameLBLtext);
            this.groupBox1.Location = new System.Drawing.Point(19, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bot Information";
            // 
            // UsernameLBLtext
            // 
            this.UsernameLBLtext.AutoSize = true;
            this.UsernameLBLtext.Location = new System.Drawing.Point(6, 26);
            this.UsernameLBLtext.Name = "UsernameLBLtext";
            this.UsernameLBLtext.Size = new System.Drawing.Size(58, 13);
            this.UsernameLBLtext.TabIndex = 0;
            this.UsernameLBLtext.Text = "Username:";
            // 
            // BotUsernameLBL
            // 
            this.BotUsernameLBL.AutoSize = true;
            this.BotUsernameLBL.Location = new System.Drawing.Point(66, 26);
            this.BotUsernameLBL.Name = "BotUsernameLBL";
            this.BotUsernameLBL.Size = new System.Drawing.Size(0, 13);
            this.BotUsernameLBL.TabIndex = 1;
            // 
            // BotNameLBL
            // 
            this.BotNameLBL.AutoSize = true;
            this.BotNameLBL.Location = new System.Drawing.Point(66, 44);
            this.BotNameLBL.Name = "BotNameLBL";
            this.BotNameLBL.Size = new System.Drawing.Size(0, 13);
            this.BotNameLBL.TabIndex = 3;
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Location = new System.Drawing.Point(6, 44);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(38, 13);
            this.NameLBL.TabIndex = 2;
            this.NameLBL.Text = "Name:";
            // 
            // BotIDlbl
            // 
            this.BotIDlbl.AutoSize = true;
            this.BotIDlbl.Location = new System.Drawing.Point(66, 63);
            this.BotIDlbl.Name = "BotIDlbl";
            this.BotIDlbl.Size = new System.Drawing.Size(0, 13);
            this.BotIDlbl.TabIndex = 5;
            // 
            // idLBL
            // 
            this.idLBL.AutoSize = true;
            this.idLBL.Location = new System.Drawing.Point(6, 63);
            this.idLBL.Name = "idLBL";
            this.idLBL.Size = new System.Drawing.Size(40, 13);
            this.idLBL.TabIndex = 4;
            this.idLBL.Text = "Bot ID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 357);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Telgram bot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ChatlogGB.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox ChatlogGB;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RichTextBox ChatlogRTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label UsernameLBLtext;
        private System.Windows.Forms.Label BotUsernameLBL;
        private System.Windows.Forms.Label BotIDlbl;
        private System.Windows.Forms.Label idLBL;
        private System.Windows.Forms.Label BotNameLBL;
        private System.Windows.Forms.Label NameLBL;
    }
}

