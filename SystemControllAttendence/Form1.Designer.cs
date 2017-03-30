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
            this.MenuStrrep = new System.Windows.Forms.PictureBox();
            this.SetingBtn = new ns1.BunifuFlatButton();
            this.ReptBtn = new ns1.BunifuFlatButton();
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
            this.Homes = new System.Windows.Forms.Panel();
            this.Managers = new System.Windows.Forms.Panel();
            this.Rept = new System.Windows.Forms.Panel();
            this.Setings = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuStrrep)).BeginInit();
            this.Heder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLogo)).BeginInit();
            this.Homes.SuspendLayout();
            this.Managers.SuspendLayout();
            this.Rept.SuspendLayout();
            this.Setings.SuspendLayout();
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
            this.LeftPanel.Controls.Add(this.ReptBtn);
            this.LeftPanel.Controls.Add(this.ManagerBtn);
            this.LeftPanel.Controls.Add(this.MenuLogo);
            this.LeftPanel.Controls.Add(this.HomeBtn);
            this.LeftPanelTransition.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 35);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(50, 459);
            this.LeftPanel.TabIndex = 0;
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
            this.SetingBtn.Click += new System.EventHandler(this.SetingBtn_Click);
            // 
            // ReptBtn
            // 
            this.ReptBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ReptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ReptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReptBtn.BorderRadius = 0;
            this.ReptBtn.ButtonText = "Отчет";
            this.ReptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelTransition.SetDecoration(this.ReptBtn, BunifuAnimatorNS.DecorationType.None);
            this.ReptBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ReptBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ReptBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ReptBtn.Iconimage")));
            this.ReptBtn.Iconimage_right = null;
            this.ReptBtn.Iconimage_right_Selected = null;
            this.ReptBtn.Iconimage_Selected = null;
            this.ReptBtn.IconMarginLeft = 0;
            this.ReptBtn.IconMarginRight = 0;
            this.ReptBtn.IconRightVisible = true;
            this.ReptBtn.IconRightZoom = 0D;
            this.ReptBtn.IconVisible = true;
            this.ReptBtn.IconZoom = 90D;
            this.ReptBtn.IsTab = true;
            this.ReptBtn.Location = new System.Drawing.Point(0, 199);
            this.ReptBtn.Name = "ReptBtn";
            this.ReptBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ReptBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ReptBtn.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.ReptBtn.selected = false;
            this.ReptBtn.Size = new System.Drawing.Size(220, 48);
            this.ReptBtn.TabIndex = 6;
            this.ReptBtn.Text = "Отчет";
            this.ReptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReptBtn.Textcolor = System.Drawing.SystemColors.ControlLightLight;
            this.ReptBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReptBtn.Click += new System.EventHandler(this.ReptBtn_Click);
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
            // Homes
            // 
            this.Homes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Homes.Controls.Add(this.bunifuCustomLabel4);
            this.LeftPanelTransition.SetDecoration(this.Homes, BunifuAnimatorNS.DecorationType.None);
            this.Homes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Homes.Location = new System.Drawing.Point(50, 35);
            this.Homes.Name = "Homes";
            this.Homes.Size = new System.Drawing.Size(909, 459);
            this.Homes.TabIndex = 2;
            // 
            // Managers
            // 
            this.Managers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Managers.Controls.Add(this.bunifuCustomLabel7);
            this.LeftPanelTransition.SetDecoration(this.Managers, BunifuAnimatorNS.DecorationType.None);
            this.Managers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Managers.Location = new System.Drawing.Point(50, 35);
            this.Managers.Name = "Managers";
            this.Managers.Size = new System.Drawing.Size(909, 459);
            this.Managers.TabIndex = 3;
            this.Managers.Visible = false;
            // 
            // Rept
            // 
            this.Rept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Rept.Controls.Add(this.bunifuCustomLabel5);
            this.LeftPanelTransition.SetDecoration(this.Rept, BunifuAnimatorNS.DecorationType.None);
            this.Rept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rept.Location = new System.Drawing.Point(50, 35);
            this.Rept.Name = "Rept";
            this.Rept.Size = new System.Drawing.Size(909, 459);
            this.Rept.TabIndex = 4;
            this.Rept.Visible = false;
            // 
            // Setings
            // 
            this.Setings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Setings.Controls.Add(this.bunifuCustomLabel6);
            this.LeftPanelTransition.SetDecoration(this.Setings, BunifuAnimatorNS.DecorationType.None);
            this.Setings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setings.Location = new System.Drawing.Point(50, 35);
            this.Setings.Name = "Setings";
            this.Setings.Size = new System.Drawing.Size(909, 459);
            this.Setings.TabIndex = 5;
            this.Setings.Visible = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.LeftPanelTransition.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(436, 18);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(62, 20);
            this.bunifuCustomLabel4.TabIndex = 1;
            this.bunifuCustomLabel4.Text = "Домой";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.LeftPanelTransition.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(447, 18);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(51, 20);
            this.bunifuCustomLabel5.TabIndex = 1;
            this.bunifuCustomLabel5.Text = "Отчет";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.LeftPanelTransition.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(407, 18);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(91, 20);
            this.bunifuCustomLabel6.TabIndex = 1;
            this.bunifuCustomLabel6.Text = "Настройки";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.LeftPanelTransition.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(320, 18);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(101, 20);
            this.bunifuCustomLabel7.TabIndex = 1;
            this.bunifuCustomLabel7.Text = "Управление";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(959, 494);
            this.Controls.Add(this.Managers);
            this.Controls.Add(this.Setings);
            this.Controls.Add(this.Rept);
            this.Controls.Add(this.Homes);
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
            this.Homes.ResumeLayout(false);
            this.Homes.PerformLayout();
            this.Managers.ResumeLayout(false);
            this.Managers.PerformLayout();
            this.Rept.ResumeLayout(false);
            this.Rept.PerformLayout();
            this.Setings.ResumeLayout(false);
            this.Setings.PerformLayout();
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
        private ns1.BunifuFlatButton ReptBtn;
        private ns1.BunifuFlatButton ManagerBtn;
        private System.Windows.Forms.Panel MenuLogo;
        private System.Windows.Forms.PictureBox IconLogo;
        private ns1.BunifuTextbox SerchInput;
        private System.Windows.Forms.PictureBox MenuStrrep;
        private BunifuAnimatorNS.BunifuTransition LeftPanelTransition;
        private System.Windows.Forms.Panel Managers;
        private System.Windows.Forms.Panel Homes;
        private System.Windows.Forms.Panel Rept;
        private System.Windows.Forms.Panel Setings;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
    }
}

