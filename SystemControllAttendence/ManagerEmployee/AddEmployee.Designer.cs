namespace SystemControllAttendence
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.Heder = new System.Windows.Forms.Panel();
            this.IconLogo = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LastName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Names = new System.Windows.Forms.TextBox();
            this.DocName = new ns1.BunifuDropdown();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DocNumber = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.Position = new ns1.BunifuDropdown();
            this.AddEmployees = new ns1.BunifuThinButton2();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.Heder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.Heder.TabIndex = 10;
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
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(34, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(278, 20);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Добавление студента (сотрудника)";
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
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel3;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Heder;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Location = new System.Drawing.Point(152, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 40);
            this.panel1.TabIndex = 14;
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
            this.LastName.Enter += new System.EventHandler(this.RemoveText);
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LockInputNumber);
            this.LastName.Leave += new System.EventHandler(this.AddText);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.MiddleName);
            this.panel2.Location = new System.Drawing.Point(152, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 40);
            this.panel2.TabIndex = 15;
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
            this.MiddleName.Enter += new System.EventHandler(this.RemoveText);
            this.MiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LockInputNumber);
            this.MiddleName.Leave += new System.EventHandler(this.AddText);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Names);
            this.panel3.Location = new System.Drawing.Point(152, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 40);
            this.panel3.TabIndex = 15;
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
            this.Names.Enter += new System.EventHandler(this.RemoveText);
            this.Names.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LockInputNumber);
            this.Names.Leave += new System.EventHandler(this.AddText);
            // 
            // DocName
            // 
            this.DocName.BackColor = System.Drawing.Color.Transparent;
            this.DocName.BorderRadius = 3;
            this.DocName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DocName.Items = new string[] {
        "Студенчиский",
        "Паспорт"};
            this.DocName.Location = new System.Drawing.Point(150, 191);
            this.DocName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DocName.Name = "DocName";
            this.DocName.NomalColor = System.Drawing.Color.Transparent;
            this.DocName.onHoverColor = System.Drawing.Color.Transparent;
            this.DocName.selectedIndex = 0;
            this.DocName.Size = new System.Drawing.Size(157, 40);
            this.DocName.TabIndex = 17;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(58, 201);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(88, 20);
            this.bunifuCustomLabel4.TabIndex = 18;
            this.bunifuCustomLabel4.Text = "Документ:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.DocNumber);
            this.panel4.Location = new System.Drawing.Point(315, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 40);
            this.panel4.TabIndex = 19;
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
            this.DocNumber.Enter += new System.EventHandler(this.RemoveText);
            this.DocNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DocNumber_KeyPress);
            this.DocNumber.Leave += new System.EventHandler(this.AddText);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(58, 251);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(95, 20);
            this.bunifuCustomLabel5.TabIndex = 21;
            this.bunifuCustomLabel5.Text = "Должность:";
            // 
            // Position
            // 
            this.Position.BackColor = System.Drawing.Color.Transparent;
            this.Position.BorderRadius = 3;
            this.Position.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Position.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Position.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Position.Items = new string[] {
        "Студент",
        "Преподователь"};
            this.Position.Location = new System.Drawing.Point(152, 241);
            this.Position.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Position.Name = "Position";
            this.Position.NomalColor = System.Drawing.Color.Transparent;
            this.Position.onHoverColor = System.Drawing.Color.Transparent;
            this.Position.selectedIndex = 0;
            this.Position.Size = new System.Drawing.Size(157, 40);
            this.Position.TabIndex = 20;
            // 
            // AddEmployees
            // 
            this.AddEmployees.ActiveBorderThickness = 1;
            this.AddEmployees.ActiveCornerRadius = 20;
            this.AddEmployees.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.AddEmployees.ActiveForecolor = System.Drawing.SystemColors.ControlLight;
            this.AddEmployees.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.AddEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AddEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddEmployees.BackgroundImage")));
            this.AddEmployees.ButtonText = "Отправить";
            this.AddEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployees.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployees.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddEmployees.IdleBorderThickness = 1;
            this.AddEmployees.IdleCornerRadius = 20;
            this.AddEmployees.IdleFillColor = System.Drawing.Color.Transparent;
            this.AddEmployees.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.AddEmployees.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AddEmployees.Location = new System.Drawing.Point(322, 398);
            this.AddEmployees.Margin = new System.Windows.Forms.Padding(5);
            this.AddEmployees.Name = "AddEmployees";
            this.AddEmployees.Size = new System.Drawing.Size(181, 41);
            this.AddEmployees.TabIndex = 16;
            this.AddEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddEmployees.Click += new System.EventHandler(this.AddEmployees_Click);
            // 
            // Photo
            // 
            this.Photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Photo.Image = global::SystemControllAttendence.Properties.Resources.user_512_1_;
            this.Photo.Location = new System.Drawing.Point(6, 48);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(140, 140);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 13;
            this.Photo.TabStop = false;
            this.Photo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(539, 453);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.AddEmployees);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Heder);
            this.Controls.Add(this.Photo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.Heder.ResumeLayout(false);
            this.Heder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel Heder;
        private System.Windows.Forms.PictureBox IconLogo;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox Photo;
        private ns1.BunifuDragControl bunifuDragControl2;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox MiddleName;
        private ns1.BunifuThinButton2 AddEmployees;
        private ns1.BunifuDropdown DocName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox DocNumber;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuDropdown Position;
    }
}