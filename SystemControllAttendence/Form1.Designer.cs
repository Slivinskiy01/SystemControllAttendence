namespace SystemControllAttendence
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.MenuLogo = new System.Windows.Forms.Panel();
            this.Heder = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.HederDragControl1 = new ns1.BunifuDragControl(this.components);
            this.LeftPanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MenuStrrep = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton4 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuTextbox1 = new ns1.BunifuTextbox();
            this.IconLogo = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.Heder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuStrrep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.LeftPanel.Controls.Add(this.MenuStrrep);
            this.LeftPanel.Controls.Add(this.bunifuFlatButton4);
            this.LeftPanel.Controls.Add(this.bunifuFlatButton3);
            this.LeftPanel.Controls.Add(this.bunifuFlatButton2);
            this.LeftPanel.Controls.Add(this.MenuLogo);
            this.LeftPanel.Controls.Add(this.bunifuFlatButton1);
            this.LeftPanelTransition.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 35);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(50, 459);
            this.LeftPanel.TabIndex = 0;
            // 
            // MenuLogo
            // 
            this.LeftPanelTransition.SetDecoration(this.MenuLogo, BunifuAnimatorNS.DecorationType.None);
            this.MenuLogo.Location = new System.Drawing.Point(0, 6);
            this.MenuLogo.Name = "MenuLogo";
            this.MenuLogo.Size = new System.Drawing.Size(171, 79);
            this.MenuLogo.TabIndex = 4;
            // 
            // Heder
            // 
            this.Heder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Heder.Controls.Add(this.bunifuTextbox1);
            this.Heder.Controls.Add(this.IconLogo);
            this.Heder.Controls.Add(this.bunifuCustomLabel3);
            this.Heder.Controls.Add(this.bunifuCustomLabel2);
            this.Heder.Controls.Add(this.bunifuCustomLabel1);
            this.LeftPanelTransition.SetDecoration(this.Heder, BunifuAnimatorNS.DecorationType.None);
            this.Heder.Dock = System.Windows.Forms.DockStyle.Top;
            this.Heder.Location = new System.Drawing.Point(0, 0);
            this.Heder.Name = "Heder";
            this.Heder.Size = new System.Drawing.Size(959, 35);
            this.Heder.TabIndex = 1;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(905, 7);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(18, 21);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "_";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(929, 7);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(19, 21);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Х";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.LeftPanelTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 7);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(334, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Система контроля и управления доступом";
            // 
            // HederDragControl1
            // 
            this.HederDragControl1.Fixed = true;
            this.HederDragControl1.Horizontal = true;
            this.HederDragControl1.TargetControl = this.Heder;
            this.HederDragControl1.Vertical = true;
            // 
            // LeftPanelTransition
            // 
            this.LeftPanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.LeftPanelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LeftPanelTransition.DefaultAnimation = animation1;
            // 
            // MenuStrrep
            // 
            this.MenuStrrep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuStrrep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.MenuStrrep, BunifuAnimatorNS.DecorationType.None);
            this.MenuStrrep.Image = global::SystemControllAttendence.Properties.Resources.Menu_32px;
            this.MenuStrrep.Location = new System.Drawing.Point(9, 8);
            this.MenuStrrep.Name = "MenuStrrep";
            this.MenuStrrep.Size = new System.Drawing.Size(30, 30);
            this.MenuStrrep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuStrrep.TabIndex = 0;
            this.MenuStrrep.TabStop = false;
            this.MenuStrrep.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Настройки";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::SystemControllAttendence.Properties.Resources.Settings_32px;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 253);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(220, 48);
            this.bunifuFlatButton4.TabIndex = 7;
            this.bunifuFlatButton4.Text = "Настройки";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Отчет";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 199);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(220, 48);
            this.bunifuFlatButton3.TabIndex = 6;
            this.bunifuFlatButton3.Text = "Отчет";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Управление";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::SystemControllAttendence.Properties.Resources.Start_Menu_32px;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 145);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(220, 48);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Text = "Управление";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Домой";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::SystemControllAttendence.Properties.Resources.Home_32px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 91);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(220, 48);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "Домой";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftPanelTransition.SetDecoration(this.bunifuTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTextbox1.Enabled = false;
            this.bunifuTextbox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(640, 7);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(199, 22);
            this.bunifuTextbox1.TabIndex = 0;
            this.bunifuTextbox1.text = "Serch...";
            // 
            // IconLogo
            // 
            this.LeftPanelTransition.SetDecoration(this.IconLogo, BunifuAnimatorNS.DecorationType.None);
            this.IconLogo.Image = global::SystemControllAttendence.Properties.Resources.Client_Company;
            this.IconLogo.Location = new System.Drawing.Point(5, 5);
            this.IconLogo.Name = "IconLogo";
            this.IconLogo.Size = new System.Drawing.Size(31, 24);
            this.IconLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconLogo.TabIndex = 3;
            this.IconLogo.TabStop = false;
            // 
            // Content
            // 
            this.LeftPanelTransition.SetDecoration(this.Content, BunifuAnimatorNS.DecorationType.None);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(50, 35);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(909, 459);
            this.Content.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(959, 494);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.Heder);
            this.LeftPanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LeftPanel.ResumeLayout(false);
            this.Heder.ResumeLayout(false);
            this.Heder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuStrrep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel Heder;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuDragControl HederDragControl1;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuFlatButton bunifuFlatButton4;
        private ns1.BunifuFlatButton bunifuFlatButton3;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Panel MenuLogo;
        private System.Windows.Forms.PictureBox IconLogo;
        private ns1.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.PictureBox MenuStrrep;
        private BunifuAnimatorNS.BunifuTransition LeftPanelTransition;
        private System.Windows.Forms.Panel Content;
    }
}

