namespace ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface
{
    partial class AccountsGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsGuide));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AccID = new System.Windows.Forms.TextBox();
            this.txt_par_num = new System.Windows.Forms.TextBox();
            this.txt_parent_num = new System.Windows.Forms.TextBox();
            this.txt_Acc_level = new System.Windows.Forms.TextBox();
            this.txt_tag = new System.Windows.Forms.TextBox();
            this.tv_Accounts = new System.Windows.Forms.TreeView();
            this.imageList_TreeView = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Acc_num = new System.Windows.Forms.TextBox();
            this.txt_Acc_Aname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.com_Acc_Parent = new System.Windows.Forms.ComboBox();
            this.com_Acc_Type = new System.Windows.Forms.ComboBox();
            this.AccFinal = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_Divert = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBoxMessage = new System.Windows.Forms.PictureBox();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_Acc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_message_seccess = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Divert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.gridControl_Divert);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 771);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AccID);
            this.groupBox1.Controls.Add(this.txt_par_num);
            this.groupBox1.Controls.Add(this.txt_parent_num);
            this.groupBox1.Controls.Add(this.txt_Acc_level);
            this.groupBox1.Controls.Add(this.txt_tag);
            this.groupBox1.Controls.Add(this.tv_Accounts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Acc_num);
            this.groupBox1.Controls.Add(this.txt_Acc_Aname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.com_Acc_Parent);
            this.groupBox1.Controls.Add(this.com_Acc_Type);
            this.groupBox1.Controls.Add(this.AccFinal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(178, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(966, 335);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // AccID
            // 
            this.AccID.Location = new System.Drawing.Point(328, 293);
            this.AccID.Name = "AccID";
            this.AccID.Size = new System.Drawing.Size(100, 24);
            this.AccID.TabIndex = 12;
            this.AccID.TextChanged += new System.EventHandler(this.AccID_TextChanged);
            // 
            // txt_par_num
            // 
            this.txt_par_num.Location = new System.Drawing.Point(172, 291);
            this.txt_par_num.Name = "txt_par_num";
            this.txt_par_num.Size = new System.Drawing.Size(100, 24);
            this.txt_par_num.TabIndex = 61;
            // 
            // txt_parent_num
            // 
            this.txt_parent_num.Location = new System.Drawing.Point(172, 261);
            this.txt_parent_num.Name = "txt_parent_num";
            this.txt_parent_num.Size = new System.Drawing.Size(100, 24);
            this.txt_parent_num.TabIndex = 12;
            this.txt_parent_num.TextChanged += new System.EventHandler(this.txt_level_TextChanged);
            // 
            // txt_Acc_level
            // 
            this.txt_Acc_level.Location = new System.Drawing.Point(328, 263);
            this.txt_Acc_level.Name = "txt_Acc_level";
            this.txt_Acc_level.Size = new System.Drawing.Size(100, 24);
            this.txt_Acc_level.TabIndex = 60;
            this.txt_Acc_level.TextChanged += new System.EventHandler(this.txt_Acc_Parent_TextChanged);
            // 
            // txt_tag
            // 
            this.txt_tag.Location = new System.Drawing.Point(172, 220);
            this.txt_tag.Name = "txt_tag";
            this.txt_tag.Size = new System.Drawing.Size(100, 24);
            this.txt_tag.TabIndex = 59;
            this.txt_tag.TextChanged += new System.EventHandler(this.txt_tag_TextChanged);
            // 
            // tv_Accounts
            // 
            this.tv_Accounts.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tv_Accounts.ImageIndex = 0;
            this.tv_Accounts.ImageList = this.imageList_TreeView;
            this.tv_Accounts.Location = new System.Drawing.Point(495, 19);
            this.tv_Accounts.Name = "tv_Accounts";
            this.tv_Accounts.RightToLeftLayout = true;
            this.tv_Accounts.SelectedImageIndex = 0;
            this.tv_Accounts.Size = new System.Drawing.Size(455, 296);
            this.tv_Accounts.TabIndex = 58;
            this.tv_Accounts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_Accounts_AfterSelect);
            // 
            // imageList_TreeView
            // 
            this.imageList_TreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_TreeView.ImageStream")));
            this.imageList_TreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_TreeView.Images.SetKeyName(0, "Open_16x16.png");
            this.imageList_TreeView.Images.SetKeyName(1, "NewCustomers_16x16.png");
            this.imageList_TreeView.Images.SetKeyName(2, "TreeView_16x16.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "الحساب الأب";
            // 
            // txt_Acc_num
            // 
            this.txt_Acc_num.Location = new System.Drawing.Point(14, 106);
            this.txt_Acc_num.Multiline = true;
            this.txt_Acc_num.Name = "txt_Acc_num";
            this.txt_Acc_num.Size = new System.Drawing.Size(310, 30);
            this.txt_Acc_num.TabIndex = 3;
            this.txt_Acc_num.TextChanged += new System.EventHandler(this.txt_Acc_num_TextChanged);
            // 
            // txt_Acc_Aname
            // 
            this.txt_Acc_Aname.Location = new System.Drawing.Point(14, 65);
            this.txt_Acc_Aname.Multiline = true;
            this.txt_Acc_Aname.Name = "txt_Acc_Aname";
            this.txt_Acc_Aname.Size = new System.Drawing.Size(310, 30);
            this.txt_Acc_Aname.TabIndex = 2;
            this.txt_Acc_Aname.TextChanged += new System.EventHandler(this.txt_Acc_Aname_TextChanged);
            this.txt_Acc_Aname.Enter += new System.EventHandler(this.txt_Acc_Aname_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "الحساب الختامي";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "نوع الحساب";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 52;
            this.label7.Text = "رقم الحساب";
            // 
            // com_Acc_Parent
            // 
            this.com_Acc_Parent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.com_Acc_Parent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Acc_Parent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.com_Acc_Parent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.com_Acc_Parent.FormattingEnabled = true;
            this.com_Acc_Parent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.com_Acc_Parent.IntegralHeight = false;
            this.com_Acc_Parent.Location = new System.Drawing.Point(14, 22);
            this.com_Acc_Parent.Name = "com_Acc_Parent";
            this.com_Acc_Parent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_Acc_Parent.Size = new System.Drawing.Size(310, 25);
            this.com_Acc_Parent.TabIndex = 1;
            this.com_Acc_Parent.SelectedIndexChanged += new System.EventHandler(this.com_Acc_Parent_SelectedIndexChanged);
            this.com_Acc_Parent.Enter += new System.EventHandler(this.com_Acc_Parent_Enter);
            // 
            // com_Acc_Type
            // 
            this.com_Acc_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Acc_Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.com_Acc_Type.FormattingEnabled = true;
            this.com_Acc_Type.ImeMode = System.Windows.Forms.ImeMode.On;
            this.com_Acc_Type.IntegralHeight = false;
            this.com_Acc_Type.Items.AddRange(new object[] {
            "رئيسي",
            "فرعي"});
            this.com_Acc_Type.Location = new System.Drawing.Point(14, 150);
            this.com_Acc_Type.Name = "com_Acc_Type";
            this.com_Acc_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.com_Acc_Type.Size = new System.Drawing.Size(310, 24);
            this.com_Acc_Type.TabIndex = 4;
            this.com_Acc_Type.SelectedIndexChanged += new System.EventHandler(this.com_Acc_Type_SelectedIndexChanged);
            // 
            // AccFinal
            // 
            this.AccFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccFinal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AccFinal.FormattingEnabled = true;
            this.AccFinal.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AccFinal.IntegralHeight = false;
            this.AccFinal.Items.AddRange(new object[] {
            "حساب",
            "نقد"});
            this.AccFinal.Location = new System.Drawing.Point(14, 190);
            this.AccFinal.Name = "AccFinal";
            this.AccFinal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccFinal.Size = new System.Drawing.Size(310, 24);
            this.AccFinal.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(344, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 26);
            this.label11.TabIndex = 54;
            this.label11.Text = "اسم الحساب";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_new);
            this.groupBox3.Controls.Add(this.btn_edit);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_print);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.btn_exit);
            this.groupBox3.Location = new System.Drawing.Point(178, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(966, 83);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // btn_new
            // 
            this.btn_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_new.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Appearance.Options.UseFont = true;
            this.btn_new.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_new.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_new.ImageOptions.SvgImage")));
            this.btn_new.Location = new System.Drawing.Point(849, 18);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(101, 47);
            this.btn_new.TabIndex = 25;
            this.btn_new.TabStop = false;
            this.btn_new.Text = "جديد";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_edit.Location = new System.Drawing.Point(639, 18);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 47);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(538, 18);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 47);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_print.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_print.Location = new System.Drawing.Point(227, 18);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(93, 47);
            this.btn_print.TabIndex = 22;
            this.btn_print.Text = "طباعة";
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_update.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(431, 18);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(101, 47);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_search.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Location = new System.Drawing.Point(327, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 47);
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "بحث";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(743, 18);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 47);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_exit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Appearance.Options.UseFont = true;
            this.btn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.Image")));
            this.btn_exit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(7, 18);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 47);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // gridControl_Divert
            // 
            this.gridControl_Divert.Location = new System.Drawing.Point(3, 524);
            this.gridControl_Divert.MainView = this.gridView1;
            this.gridControl_Divert.Name = "gridControl_Divert";
            this.gridControl_Divert.Size = new System.Drawing.Size(1302, 237);
            this.gridControl_Divert.TabIndex = 5;
            this.gridControl_Divert.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_Divert;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PictureBoxMessage);
            this.panel2.Controls.Add(this.lbl_Message);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.date_Acc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Tempus Sans ITC", 8F);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 63);
            this.panel2.TabIndex = 1;
            // 
            // PictureBoxMessage
            // 
            this.PictureBoxMessage.Location = new System.Drawing.Point(295, 13);
            this.PictureBoxMessage.Name = "PictureBoxMessage";
            this.PictureBoxMessage.Size = new System.Drawing.Size(30, 28);
            this.PictureBoxMessage.TabIndex = 62;
            this.PictureBoxMessage.TabStop = false;
            this.PictureBoxMessage.Click += new System.EventHandler(this.PictureBoxMessage_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.Font = new System.Drawing.Font("Tempus Sans ITC", 14F);
            this.lbl_Message.Location = new System.Drawing.Point(151, 9);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(158, 39);
            this.lbl_Message.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1226, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "التاريخ";
            // 
            // date_Acc
            // 
            this.date_Acc.Location = new System.Drawing.Point(1031, 20);
            this.date_Acc.Name = "date_Acc";
            this.date_Acc.RightToLeftLayout = true;
            this.date_Acc.Size = new System.Drawing.Size(180, 25);
            this.date_Acc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "دليل الحسابات";
            // 
            // timer_message_seccess
            // 
            this.timer_message_seccess.Interval = 1000;
            this.timer_message_seccess.Tick += new System.EventHandler(this.timer_message_seccess_Tick);
            // 
            // AccountsGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 777);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsGuide";
            this.Text = "/*";
            this.Load += new System.EventHandler(this.AccountsGuide_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Divert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_Acc;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraGrid.GridControl gridControl_Divert;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        public DevExpress.XtraEditors.SimpleButton btn_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tag;
        private System.Windows.Forms.TextBox txt_Acc_level;
        private System.Windows.Forms.TextBox txt_parent_num;
        private System.Windows.Forms.TextBox txt_par_num;
        public System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox txt_Acc_Aname;
        internal System.Windows.Forms.TextBox txt_Acc_num;
        internal System.Windows.Forms.ComboBox com_Acc_Parent;
        internal System.Windows.Forms.ComboBox AccFinal;
        internal System.Windows.Forms.ComboBox com_Acc_Type;
        internal System.Windows.Forms.TextBox AccID;
        internal System.Windows.Forms.Label lbl_Message;
        internal System.Windows.Forms.PictureBox PictureBoxMessage;
        public System.Windows.Forms.Timer timer_message_seccess;
        private System.Windows.Forms.ImageList imageList_TreeView;
        internal System.Windows.Forms.TreeView tv_Accounts;
        internal DevExpress.XtraEditors.SimpleButton btn_edit;
        internal DevExpress.XtraEditors.SimpleButton btn_delete;
        internal DevExpress.XtraEditors.SimpleButton btn_print;
        internal DevExpress.XtraEditors.SimpleButton btn_update;
        internal DevExpress.XtraEditors.SimpleButton btn_search;
        internal DevExpress.XtraEditors.SimpleButton btn_add;
        internal DevExpress.XtraEditors.SimpleButton btn_new;
    }
}