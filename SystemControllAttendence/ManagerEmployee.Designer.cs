namespace SystemControllAttendence
{
    partial class ManagerEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerEmployee));
            this.Heder = new System.Windows.Forms.Panel();
            this.IconLogo = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.Textbox1 = new ns1.BunifuMaterialTextbox();
            this.LastName = new ns1.BunifuCustomLabel();
            this.Names = new ns1.BunifuCustomLabel();
            this.MiddleName = new ns1.BunifuCustomLabel();
            this.DeletEmployeeBtn = new ns1.BunifuThinButton2();
            this.EditEmployeeBtn = new ns1.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SerchPersonel = new ns1.BunifuImageButton();
            this.Heder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerchPersonel)).BeginInit();
            this.SuspendLayout();
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
            this.Heder.Size = new System.Drawing.Size(499, 35);
            this.Heder.TabIndex = 0;
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(445, 9);
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
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(216, 20);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Управление сотрудниками";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(470, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(19, 21);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "X";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Heder;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel3;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Textbox1
            // 
            this.Textbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Textbox1.HintForeColor = System.Drawing.SystemColors.ControlLight;
            this.Textbox1.HintText = "";
            this.Textbox1.isPassword = false;
            this.Textbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.Textbox1.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.Textbox1.LineMouseHoverColor = System.Drawing.SystemColors.ControlLight;
            this.Textbox1.LineThickness = 4;
            this.Textbox1.Location = new System.Drawing.Point(14, 43);
            this.Textbox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(296, 54);
            this.Textbox1.TabIndex = 2;
            this.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox1_KeyPress);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LastName.Location = new System.Drawing.Point(160, 114);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(85, 21);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "Фамилия";
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Names.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Names.Location = new System.Drawing.Point(160, 145);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(43, 21);
            this.Names.TabIndex = 6;
            this.Names.Text = "Имя";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MiddleName.Location = new System.Drawing.Point(160, 175);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(80, 21);
            this.MiddleName.TabIndex = 7;
            this.MiddleName.Text = "Отчество";
            // 
            // DeletEmployeeBtn
            // 
            this.DeletEmployeeBtn.ActiveBorderThickness = 1;
            this.DeletEmployeeBtn.ActiveCornerRadius = 20;
            this.DeletEmployeeBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.DeletEmployeeBtn.ActiveForecolor = System.Drawing.SystemColors.ControlLight;
            this.DeletEmployeeBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.DeletEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DeletEmployeeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeletEmployeeBtn.BackgroundImage")));
            this.DeletEmployeeBtn.ButtonText = "Удалить";
            this.DeletEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletEmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletEmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.DeletEmployeeBtn.IdleBorderThickness = 1;
            this.DeletEmployeeBtn.IdleCornerRadius = 20;
            this.DeletEmployeeBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.DeletEmployeeBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.DeletEmployeeBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.DeletEmployeeBtn.Location = new System.Drawing.Point(278, 368);
            this.DeletEmployeeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeletEmployeeBtn.Name = "DeletEmployeeBtn";
            this.DeletEmployeeBtn.Size = new System.Drawing.Size(207, 41);
            this.DeletEmployeeBtn.TabIndex = 9;
            this.DeletEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeletEmployeeBtn.Click += new System.EventHandler(this.DeletEmployeeBtn_Click);
            // 
            // EditEmployeeBtn
            // 
            this.EditEmployeeBtn.ActiveBorderThickness = 1;
            this.EditEmployeeBtn.ActiveCornerRadius = 20;
            this.EditEmployeeBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.EditEmployeeBtn.ActiveForecolor = System.Drawing.SystemColors.ControlLight;
            this.EditEmployeeBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.EditEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EditEmployeeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditEmployeeBtn.BackgroundImage")));
            this.EditEmployeeBtn.ButtonText = "Изменить";
            this.EditEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditEmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.EditEmployeeBtn.IdleBorderThickness = 1;
            this.EditEmployeeBtn.IdleCornerRadius = 20;
            this.EditEmployeeBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.EditEmployeeBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.EditEmployeeBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.EditEmployeeBtn.Location = new System.Drawing.Point(22, 368);
            this.EditEmployeeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.EditEmployeeBtn.Name = "EditEmployeeBtn";
            this.EditEmployeeBtn.Size = new System.Drawing.Size(207, 41);
            this.EditEmployeeBtn.TabIndex = 8;
            this.EditEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditEmployeeBtn.Click += new System.EventHandler(this.EditEmployeeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemControllAttendence.Properties.Resources.user_512_1_;
            this.pictureBox1.Location = new System.Drawing.Point(14, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SerchPersonel
            // 
            this.SerchPersonel.BackColor = System.Drawing.Color.Transparent;
            this.SerchPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SerchPersonel.Image = global::SystemControllAttendence.Properties.Resources.Search_96px;
            this.SerchPersonel.ImageActive = null;
            this.SerchPersonel.Location = new System.Drawing.Point(318, 43);
            this.SerchPersonel.Name = "SerchPersonel";
            this.SerchPersonel.Size = new System.Drawing.Size(63, 54);
            this.SerchPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SerchPersonel.TabIndex = 3;
            this.SerchPersonel.TabStop = false;
            this.SerchPersonel.Zoom = 10;
            this.SerchPersonel.Click += new System.EventHandler(this.SerchPersonel_Click);
            // 
            // ManagerEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(499, 423);
            this.Controls.Add(this.DeletEmployeeBtn);
            this.Controls.Add(this.EditEmployeeBtn);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SerchPersonel);
            this.Controls.Add(this.Textbox1);
            this.Controls.Add(this.Heder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerEmployee";
            this.Heder.ResumeLayout(false);
            this.Heder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerchPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Heder;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox IconLogo;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuDragControl bunifuDragControl2;
        private ns1.BunifuMaterialTextbox Textbox1;
        private ns1.BunifuImageButton SerchPersonel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuCustomLabel LastName;
        private ns1.BunifuCustomLabel Names;
        private ns1.BunifuCustomLabel MiddleName;
        private ns1.BunifuThinButton2 EditEmployeeBtn;
        private ns1.BunifuThinButton2 DeletEmployeeBtn;
    }
}