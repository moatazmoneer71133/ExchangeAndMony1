namespace ExchangeAndMony.pages.file
{
    partial class frm_conFormat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_conFormat));
            this.group_db = new System.Windows.Forms.GroupBox();
            this.txt_conn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.group_db.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_db
            // 
            this.group_db.Controls.Add(this.label5);
            this.group_db.Controls.Add(this.label4);
            this.group_db.Controls.Add(this.label3);
            this.group_db.Controls.Add(this.label2);
            this.group_db.Controls.Add(this.label1);
            this.group_db.Controls.Add(this.txt_pass);
            this.group_db.Controls.Add(this.txt_user);
            this.group_db.Controls.Add(this.txt_db);
            this.group_db.Controls.Add(this.txt_server);
            this.group_db.Controls.Add(this.txt_conn);
            this.group_db.Location = new System.Drawing.Point(12, 12);
            this.group_db.Name = "group_db";
            this.group_db.Size = new System.Drawing.Size(512, 248);
            this.group_db.TabIndex = 0;
            this.group_db.TabStop = false;
            this.group_db.Text = "قاعدة البيانات";
            // 
            // txt_conn
            // 
            this.txt_conn.Location = new System.Drawing.Point(41, 48);
            this.txt_conn.Name = "txt_conn";
            this.txt_conn.Size = new System.Drawing.Size(333, 24);
            this.txt_conn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(402, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "نمط الاتصال";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(402, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم السيرفر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(402, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(402, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "المستخدم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(402, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "قاعدة البيانات";
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(41, 81);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(333, 24);
            this.txt_server.TabIndex = 2;
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(41, 117);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(333, 24);
            this.txt_db.TabIndex = 3;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(41, 153);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(333, 24);
            this.txt_user.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(41, 189);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(333, 24);
            this.txt_pass.TabIndex = 5;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(436, 277);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(88, 32);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(115, 277);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 32);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 277);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(88, 32);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // frm_conFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 321);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.group_db);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frm_conFormat.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_conFormat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تهيئة الاتصال بقاعدة البيانات";
            this.group_db.ResumeLayout(false);
            this.group_db.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_db;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_conn;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
    }
}