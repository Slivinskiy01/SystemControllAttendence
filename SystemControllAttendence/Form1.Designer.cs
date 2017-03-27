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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.MenuStrrep = new System.Windows.Forms.PictureBox();
            this.SetingBtn = new ns1.BunifuFlatButton();
            this.OtchetBtn = new ns1.BunifuFlatButton();
            this.ManagerBtn = new ns1.BunifuFlatButton();
            this.MenuLogo = new System.Windows.Forms.Panel();
            this.HomeBtn = new ns1.BunifuFlatButton();
            this.Heder = new System.Windows.Forms.Panel();
            this.SerchInput = new ns1.BunifuTextbox();
            this.IconLogo = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.HederDragControl1 = new ns1.BunifuDragControl(this.components);
            this.LeftPanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Content = new System.Windows.Forms.Panel();
            this.mannagerControl1 = new SystemControllAttendence.MannagerControl();
            this.homeUserControl1 = new SystemControllAttendence.HomeUserControl();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuStrrep)).BeginInit();
            this.Heder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).BeginInit();
            this.Content.SuspendLayout();
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
            this.LeftPanel.Controls.Add(this.SetingBtn);
            this.LeftPanel.Controls.Add(this.OtchetBtn);
            this.LeftPanel.Controls.Add(this.ManagerBtn);
            this.LeftPanel.Controls.Add(this.MenuLogo);
            this.LeftPanel.Controls.Add(this.HomeBtn);
            this.LeftPanelTransition.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 35);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(220, 459);
            this.LeftPanel.TabIndex = 0;
            // 
            // MenuStrrep
            // 
            this.MenuStrrep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuStrrep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.MenuStrrep, BunifuAnimatorNS.DecorationType.None);
            this.MenuStrrep.Image = global::SystemControllAttendence.Properties.Resources.Menu_32px;
            this.MenuStrrep.Location = new System.Drawing.Point(179, 8);
            this.MenuStrrep.Name = "MenuStrrep";
            this.MenuStrrep.Size = new System.Drawing.Size(30, 30);
            this.MenuStrrep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuStrrep.TabIndex = 0;
            this.MenuStrrep.TabStop = false;
            this.MenuStrrep.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SetingBtn
            // 
            this.SetingBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SetingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SetingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetingBtn.BorderRadius = 0;
            this.SetingBtn.ButtonText = "Настройки";
            this.SetingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.SetingBtn, BunifuAnimatorNS.DecorationType.None);
            this.SetingBtn.DisabledColor = System.Drawing.Color.Gray;
            this.SetingBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.SetingBtn.Iconimage = global::SystemControllAttendence.Properties.Resources.Settings_32px;
            this.SetingBtn.Iconimage_right = null;
            this.SetingBtn.Iconimage_right_Selected = null;
            this.SetingBtn.Iconimage_Selected = null;
            this.SetingBtn.IconMarginLeft = 0;
            this.SetingBtn.IconMarginRight = 0;
            this.SetingBtn.IconRightVisible = true;
            this.SetingBtn.IconRightZoom = 0D;
            this.SetingBtn.IconVisible = true;
            this.SetingBtn.IconZoom = 90D;
            this.SetingBtn.IsTab = true;
            this.SetingBtn.Location = new System.Drawing.Point(0, 253);
            this.SetingBtn.Name = "SetingBtn";
            this.SetingBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SetingBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SetingBtn.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.SetingBtn.selected = false;
            this.SetingBtn.Size = new System.Drawing.Size(220, 48);
            this.SetingBtn.TabIndex = 7;
            this.SetingBtn.Text = "Настройки";
            this.SetingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetingBtn.Textcolor = System.Drawing.SystemColors.ControlLightLight;
            this.SetingBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // OtchetBtn
            // 
            this.OtchetBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.OtchetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.OtchetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OtchetBtn.BorderRadius = 0;
            this.OtchetBtn.ButtonText = "Отчет";
            this.OtchetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.OtchetBtn, BunifuAnimatorNS.DecorationType.None);
            this.OtchetBtn.DisabledColor = System.Drawing.Color.Gray;
            this.OtchetBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.OtchetBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("OtchetBtn.Iconimage")));
            this.OtchetBtn.Iconimage_right = null;
            this.OtchetBtn.Iconimage_right_Selected = null;
            this.OtchetBtn.Iconimage_Selected = null;
            this.OtchetBtn.IconMarginLeft = 0;
            this.OtchetBtn.IconMarginRight = 0;
            this.OtchetBtn.IconRightVisible = true;
            this.OtchetBtn.IconRightZoom = 0D;
            this.OtchetBtn.IconVisible = true;
            this.OtchetBtn.IconZoom = 90D;
            this.OtchetBtn.IsTab = true;
            this.OtchetBtn.Location = new System.Drawing.Point(0, 199);
            this.OtchetBtn.Name = "OtchetBtn";
            this.OtchetBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.OtchetBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.OtchetBtn.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.OtchetBtn.selected = false;
            this.OtchetBtn.Size = new System.Drawing.Size(220, 48);
            this.OtchetBtn.TabIndex = 6;
            this.OtchetBtn.Text = "Отчет";
            this.OtchetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OtchetBtn.Textcolor = System.Drawing.SystemColors.ControlLightLight;
            this.OtchetBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // ManagerBtn
            // 
            this.ManagerBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ManagerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ManagerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManagerBtn.BorderRadius = 0;
            this.ManagerBtn.ButtonText = "Управление";
            this.ManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.ManagerBtn, BunifuAnimatorNS.DecorationType.None);
            this.ManagerBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ManagerBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ManagerBtn.Iconimage = global::SystemControllAttendence.Properties.Resources.Start_Menu_32px;
            this.ManagerBtn.Iconimage_right = null;
            this.ManagerBtn.Iconimage_right_Selected = null;
            this.ManagerBtn.Iconimage_Selected = null;
            this.ManagerBtn.IconMarginLeft = 0;
            this.ManagerBtn.IconMarginRight = 0;
            this.ManagerBtn.IconRightVisible = true;
            this.ManagerBtn.IconRightZoom = 0D;
            this.ManagerBtn.IconVisible = true;
            this.ManagerBtn.IconZoom = 90D;
            this.ManagerBtn.IsTab = true;
            this.ManagerBtn.Location = new System.Drawing.Point(0, 145);
            this.ManagerBtn.Name = "ManagerBtn";
            this.ManagerBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ManagerBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ManagerBtn.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.ManagerBtn.selected = false;
            this.ManagerBtn.Size = new System.Drawing.Size(220, 48);
            this.ManagerBtn.TabIndex = 5;
            this.ManagerBtn.Text = "Управление";
            this.ManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManagerBtn.Textcolor = System.Drawing.SystemColors.ControlLightLight;
            this.ManagerBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagerBtn.Click += new System.EventHandler(this.ManagerBtn_Click);
            // 
            // MenuLogo
            // 
            this.LeftPanelTransition.SetDecoration(this.MenuLogo, BunifuAnimatorNS.DecorationType.None);
            this.MenuLogo.Location = new System.Drawing.Point(0, 6);
            this.MenuLogo.Name = "MenuLogo";
            this.MenuLogo.Size = new System.Drawing.Size(171, 79);
            this.MenuLogo.TabIndex = 4;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBtn.BorderRadius = 0;
            this.HomeBtn.ButtonText = "Домой";
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.HomeBtn, BunifuAnimatorNS.DecorationType.None);
            this.HomeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.HomeBtn.Iconimage = global::SystemControllAttendence.Properties.Resources.Home_32px;
            this.HomeBtn.Iconimage_right = null;
            this.HomeBtn.Iconimage_right_Selected = null;
            this.HomeBtn.Iconimage_Selected = null;
            this.HomeBtn.IconMarginLeft = 0;
            this.HomeBtn.IconMarginRight = 0;
            this.HomeBtn.IconRightVisible = true;
            this.HomeBtn.IconRightZoom = 0D;
            this.HomeBtn.IconVisible = true;
            this.HomeBtn.IconZoom = 90D;
            this.HomeBtn.IsTab = true;
            this.HomeBtn.Location = new System.Drawing.Point(0, 91);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HomeBtn.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.HomeBtn.selected = false;
            this.HomeBtn.Size = new System.Drawing.Size(220, 48);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "Домой";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeBtn.Textcolor = System.Drawing.SystemColors.ControlLightLight;
            this.HomeBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Heder
            // 
            this.Heder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Heder.Controls.Add(this.SerchInput);
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
            // SerchInput
            // 
            this.SerchInput.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.SerchInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SerchInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SerchInput.BackgroundImage")));
            this.SerchInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftPanelTransition.SetDecoration(this.SerchInput, BunifuAnimatorNS.DecorationType.None);
            this.SerchInput.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SerchInput.Icon = ((System.Drawing.Image)(resources.GetObject("SerchInput.Icon")));
            this.SerchInput.Location = new System.Drawing.Point(645, 5);
            this.SerchInput.Name = "SerchInput";
            this.SerchInput.Size = new System.Drawing.Size(199, 24);
            this.SerchInput.TabIndex = 0;
            this.SerchInput.text = "Serch...";
            this.SerchInput.Enter += new System.EventHandler(this.SerchInput_Enter);
            this.SerchInput.Validated += new System.EventHandler(this.SerchInput_Validated);
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
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.LeftPanelTransition.DefaultAnimation = animation2;
            // 
            // Content
            // 
            this.Content.Controls.Add(this.mannagerControl1);
            this.Content.Controls.Add(this.homeUserControl1);
            this.LeftPanelTransition.SetDecoration(this.Content, BunifuAnimatorNS.DecorationType.None);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(220, 35);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(739, 459);
            this.Content.TabIndex = 2;
            // 
            // mannagerControl1
            // 
            this.mannagerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LeftPanelTransition.SetDecoration(this.mannagerControl1, BunifuAnimatorNS.DecorationType.None);
            this.mannagerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mannagerControl1.Location = new System.Drawing.Point(0, 0);
            this.mannagerControl1.Name = "mannagerControl1";
            this.mannagerControl1.Size = new System.Drawing.Size(739, 459);
            this.mannagerControl1.TabIndex = 1;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LeftPanelTransition.SetDecoration(this.homeUserControl1, BunifuAnimatorNS.DecorationType.None);
            this.homeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(739, 459);
            this.homeUserControl1.TabIndex = 0;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuStrrep)).EndInit();
            this.Heder.ResumeLayout(false);
            this.Heder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).EndInit();
            this.Content.ResumeLayout(false);
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
        private ns1.BunifuFlatButton HomeBtn;
        private ns1.BunifuFlatButton SetingBtn;
        private ns1.BunifuFlatButton OtchetBtn;
        private ns1.BunifuFlatButton ManagerBtn;
        private System.Windows.Forms.Panel MenuLogo;
        private System.Windows.Forms.PictureBox IconLogo;
        private ns1.BunifuTextbox SerchInput;
        private System.Windows.Forms.PictureBox MenuStrrep;
        private BunifuAnimatorNS.BunifuTransition LeftPanelTransition;
        private System.Windows.Forms.Panel Content;
        private HomeUserControl homeUserControl1;
        private MannagerControl mannagerControl1;
    }
}

