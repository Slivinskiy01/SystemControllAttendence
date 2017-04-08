namespace SystemControllAttendence
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.DocNumber = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.Names = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LastName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.Heder = new System.Windows.Forms.Panel();
            this.IconLogo = new System.Windows.Forms.PictureBox();
            this.bunifuElipse3 = new ns1.BunifuElipse(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuElipse4 = new ns1.BunifuElipse(this.components);
            this.Photo = new System.Windows.Forms.PictureBox();
            this.SaveChange = new ns1.BunifuThinButton2();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DocName = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Heder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // DocNumber
            // 
            this.DocNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DocNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocNumber.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DocNumber.Location = new System.Drawing.Point(12, 9);
            this.DocNumber.Name = "DocNumber";
            this.DocNumber.Size = new System.Drawing.Size(196, 20);
            this.DocNumber.TabIndex = 0;
            this.DocNumber.Text = "Номер";
            this.DocNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DocNumber_KeyPress);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(55, 189);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(88, 20);
            this.bunifuCustomLabel4.TabIndex = 27;
            this.bunifuCustomLabel4.Text = "Документ:";
            // 
            // Names
            // 
            this.Names.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Names.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Names.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Names.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Names.Location = new System.Drawing.Point(12, 9);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(196, 20);
            this.Names.TabIndex = 0;
            this.Names.Text = "Имя";
            this.Names.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LockInputNumber);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Names);
            this.panel3.Location = new System.Drawing.Point(149, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 40);
            this.panel3.TabIndex = 23;
            // 
            // MiddleName
            // 
            this.MiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MiddleName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MiddleName.Location = new System.Drawing.Point(12, 9);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(196, 20);
            this.MiddleName.TabIndex = 0;
            this.MiddleName.Text = "Отчество";
            this.MiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LockInputNumber);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.MiddleName);
            this.panel2.Location = new System.Drawing.Point(149, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 40);
            this.panel2.TabIndex = 24;
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LastName.Location = new System.Drawing.Point(12, 9);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(196, 20);
            this.LastName.TabIndex = 0;
            this.LastName.Text = "Фамилия";
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LockInputNumber);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.DocNumber);
            this.panel4.Location = new System.Drawing.Point(149, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 40);
            this.panel4.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Location = new System.Drawing.Point(149, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 40);
            this.panel1.TabIndex = 22;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel3;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(34, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(196, 20);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Добавление сотрудника";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(485, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(18, 21);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "_";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(510, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(19, 21);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "X";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.Close);
            // 
            // Heder
            // 
            this.Heder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.Heder.Controls.Add(this.IconLogo);
            this.Heder.Controls.Add(this.bunifuCustomLabel2);
            this.Heder.Controls.Add(this.bunifuCustomLabel3);
            this.Heder.Controls.Add(this.bunifuCustomLabel1);
            this.Heder.Dock = System.Windows.Forms.DockStyle.Top;
            this.Heder.Location = new System.Drawing.Point(0, 0);
            this.Heder.Name = "Heder";
            this.Heder.Size = new System.Drawing.Size(539, 35);
            this.Heder.TabIndex = 20;
            // 
            // IconLogo
            // 
            this.IconLogo.Image = global::SystemControllAttendence.Properties.Resources.Client_Company;
            this.IconLogo.Location = new System.Drawing.Point(6, 7);
            this.IconLogo.Name = "IconLogo";
            this.IconLogo.Size = new System.Drawing.Size(31, 24);
            this.IconLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconLogo.TabIndex = 5;
            this.IconLogo.TabStop = false;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Heder;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this;
            // 
            // Photo
            // 
            this.Photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Photo.Image = global::SystemControllAttendence.Properties.Resources.user_512_1_;
            this.Photo.Location = new System.Drawing.Point(3, 36);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(140, 140);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 21;
            this.Photo.TabStop = false;
            this.Photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SaveChange
            // 
            this.SaveChange.ActiveBorderThickness = 1;
            this.SaveChange.ActiveCornerRadius = 20;
            this.SaveChange.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.SaveChange.ActiveForecolor = System.Drawing.SystemColors.ControlLight;
            this.SaveChange.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.SaveChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SaveChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveChange.BackgroundImage")));
            this.SaveChange.ButtonText = "Зафиксировать изменения";
            this.SaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.SaveChange.IdleBorderThickness = 1;
            this.SaveChange.IdleCornerRadius = 20;
            this.SaveChange.IdleFillColor = System.Drawing.Color.Transparent;
            this.SaveChange.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.SaveChange.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.SaveChange.Location = new System.Drawing.Point(274, 398);
            this.SaveChange.Margin = new System.Windows.Forms.Padding(5);
            this.SaveChange.Name = "SaveChange";
            this.SaveChange.Size = new System.Drawing.Size(247, 41);
            this.SaveChange.TabIndex = 29;
            this.SaveChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveChange.Click += new System.EventHandler(this.SaveChange_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "Студенчиский",
            "Паспорт"});
            this.listBox1.Location = new System.Drawing.Point(383, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 42);
            this.listBox1.TabIndex = 30;
            // 
            // DocName
            // 
            this.DocName.BackColor = System.Drawing.Color.White;
            this.DocName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocName.FormattingEnabled = true;
            this.DocName.Items.AddRange(new object[] {
            "Студенчиский",
            "Паспорт"});
            this.DocName.Location = new System.Drawing.Point(377, 183);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(144, 29);
            this.DocName.TabIndex = 31;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(539, 453);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SaveChange);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Heder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEmployee";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Heder.ResumeLayout(false);
            this.Heder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuElipse bunifuElipse2;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox DocNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Panel Heder;
        private System.Windows.Forms.PictureBox IconLogo;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuDragControl bunifuDragControl2;
        private ns1.BunifuElipse bunifuElipse3;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuElipse bunifuElipse4;
        private ns1.BunifuThinButton2 SaveChange;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox DocName;
    }
}