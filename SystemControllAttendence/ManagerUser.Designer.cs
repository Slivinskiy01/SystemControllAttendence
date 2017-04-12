namespace SystemControllAttendence
{
    partial class ManagerUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerUser));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.Heder = new System.Windows.Forms.Panel();
            this.IconLogo = new System.Windows.Forms.PictureBox();
            this.MinimizaidBtnLabel = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.ClosedBtnLabe = new ns1.BunifuCustomLabel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.DeletUserBtn = new ns1.BunifuThinButton2();
            this.EditUserBtn = new ns1.BunifuThinButton2();
            this.Names = new ns1.BunifuCustomLabel();
            this.LastName = new ns1.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SerchUser = new ns1.BunifuImageButton();
            this.Textbox1 = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.Heder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerchUser)).BeginInit();
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
            this.Heder.Controls.Add(this.MinimizaidBtnLabel);
            this.Heder.Controls.Add(this.bunifuCustomLabel3);
            this.Heder.Controls.Add(this.ClosedBtnLabe);
            this.Heder.Dock = System.Windows.Forms.DockStyle.Top;
            this.Heder.Location = new System.Drawing.Point(0, 0);
            this.Heder.Name = "Heder";
            this.Heder.Size = new System.Drawing.Size(548, 35);
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
            // MinimizaidBtnLabel
            // 
            this.MinimizaidBtnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizaidBtnLabel.AutoSize = true;
            this.MinimizaidBtnLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizaidBtnLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizaidBtnLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MinimizaidBtnLabel.Location = new System.Drawing.Point(494, 9);
            this.MinimizaidBtnLabel.Name = "MinimizaidBtnLabel";
            this.MinimizaidBtnLabel.Size = new System.Drawing.Size(18, 21);
            this.MinimizaidBtnLabel.TabIndex = 2;
            this.MinimizaidBtnLabel.Text = "_";
            this.MinimizaidBtnLabel.Click += new System.EventHandler(this.MinimizaidBtnLabel_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(34, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(225, 20);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Управление пользователями";
            // 
            // ClosedBtnLabe
            // 
            this.ClosedBtnLabe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClosedBtnLabe.AutoSize = true;
            this.ClosedBtnLabe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosedBtnLabe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClosedBtnLabe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ClosedBtnLabe.Location = new System.Drawing.Point(519, 9);
            this.ClosedBtnLabe.Name = "ClosedBtnLabe";
            this.ClosedBtnLabe.Size = new System.Drawing.Size(19, 21);
            this.ClosedBtnLabe.TabIndex = 1;
            this.ClosedBtnLabe.Text = "X";
            this.ClosedBtnLabe.Click += new System.EventHandler(this.ClosedBtnLabe_Click);
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
            // DeletUserBtn
            // 
            this.DeletUserBtn.ActiveBorderThickness = 1;
            this.DeletUserBtn.ActiveCornerRadius = 20;
            this.DeletUserBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.DeletUserBtn.ActiveForecolor = System.Drawing.SystemColors.ControlLight;
            this.DeletUserBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.DeletUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DeletUserBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeletUserBtn.BackgroundImage")));
            this.DeletUserBtn.ButtonText = "Удалить";
            this.DeletUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletUserBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.DeletUserBtn.IdleBorderThickness = 1;
            this.DeletUserBtn.IdleCornerRadius = 20;
            this.DeletUserBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.DeletUserBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.DeletUserBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.DeletUserBtn.Location = new System.Drawing.Point(278, 392);
            this.DeletUserBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeletUserBtn.Name = "DeletUserBtn";
            this.DeletUserBtn.Size = new System.Drawing.Size(207, 41);
            this.DeletUserBtn.TabIndex = 18;
            this.DeletUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeletUserBtn.Click += new System.EventHandler(this.DeletUserBtn_Click);
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.ActiveBorderThickness = 1;
            this.EditUserBtn.ActiveCornerRadius = 20;
            this.EditUserBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.EditUserBtn.ActiveForecolor = System.Drawing.SystemColors.ControlLight;
            this.EditUserBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.EditUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EditUserBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditUserBtn.BackgroundImage")));
            this.EditUserBtn.ButtonText = "Изменить";
            this.EditUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditUserBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.EditUserBtn.IdleBorderThickness = 1;
            this.EditUserBtn.IdleCornerRadius = 20;
            this.EditUserBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.EditUserBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.EditUserBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(106)))), ((int)(((byte)(40)))));
            this.EditUserBtn.Location = new System.Drawing.Point(22, 392);
            this.EditUserBtn.Margin = new System.Windows.Forms.Padding(5);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(207, 41);
            this.EditUserBtn.TabIndex = 17;
            this.EditUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Names.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Names.Location = new System.Drawing.Point(160, 169);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(43, 21);
            this.Names.TabIndex = 15;
            this.Names.Text = "Имя";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LastName.Location = new System.Drawing.Point(160, 138);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(85, 21);
            this.LastName.TabIndex = 14;
            this.LastName.Text = "Фамилия";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemControllAttendence.Properties.Resources.user_512_1_;
            this.pictureBox1.Location = new System.Drawing.Point(14, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // SerchUser
            // 
            this.SerchUser.BackColor = System.Drawing.Color.Transparent;
            this.SerchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SerchUser.Image = global::SystemControllAttendence.Properties.Resources.Search_96px;
            this.SerchUser.ImageActive = null;
            this.SerchUser.Location = new System.Drawing.Point(318, 52);
            this.SerchUser.Name = "SerchUser";
            this.SerchUser.Size = new System.Drawing.Size(63, 54);
            this.SerchUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SerchUser.TabIndex = 12;
            this.SerchUser.TabStop = false;
            this.SerchUser.Zoom = 10;
            this.SerchUser.Click += new System.EventHandler(this.SerchUser_Click);
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
            this.Textbox1.Location = new System.Drawing.Point(14, 52);
            this.Textbox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(296, 54);
            this.Textbox1.TabIndex = 11;
            this.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(11, 52);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(36, 16);
            this.bunifuCustomLabel4.TabIndex = 19;
            this.bunifuCustomLabel4.Text = "Email";
            // 
            // ManagerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(548, 456);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.Heder);
            this.Controls.Add(this.DeletUserBtn);
            this.Controls.Add(this.EditUserBtn);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SerchUser);
            this.Controls.Add(this.Textbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerUser";
            this.Heder.ResumeLayout(false);
            this.Heder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerchUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuElipse bunifuElipse2;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel Heder;
        private System.Windows.Forms.PictureBox IconLogo;
        private ns1.BunifuCustomLabel MinimizaidBtnLabel;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel ClosedBtnLabe;
        private ns1.BunifuThinButton2 DeletUserBtn;
        private ns1.BunifuThinButton2 EditUserBtn;
        private ns1.BunifuCustomLabel Names;
        private ns1.BunifuCustomLabel LastName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuImageButton SerchUser;
        private ns1.BunifuMaterialTextbox Textbox1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuDragControl bunifuDragControl2;
    }
}