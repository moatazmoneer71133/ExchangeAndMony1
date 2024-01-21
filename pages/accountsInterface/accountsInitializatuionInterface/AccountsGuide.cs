using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface
{
    public partial class AccountsGuide : DevExpress.XtraEditors.XtraForm
    {
        Class_Accounts class_Accounts = new Class_Accounts();
        //SqlDataAdapter bus = new SqlDataAdapter();
        Classes.Gen_Class xx = new Classes.Gen_Class();
        // nameDocument.Text="سند قيد بسيط";
        public AccountsGuide()
        {


            // nameDocument.Text = "سند قيد بسيط";
            InitializeComponent();

            // Create_node();
        }


        //    private void Create_node()
        //    {
        //        TreeNode tn;
        //        tv_Accounts.Nodes.Clear();
        //        DataView dv = new DataView(class_Accounts.Get_All_Accounts());
        //        dv.RowFilter = "Acc_Parent_Num=0";
        //        // عرض الحسابات في سجرة الحسابات
        //        foreach (DataRowView drv in dv)
        //        {
        //            tn = new TreeNode(drv["Acc_Num"].ToString()+"  "+ drv["Acc_Aname"].ToString());
        //            tn.Tag = drv["Acc_Num"].ToString();
        //            tv_Accounts.Nodes.Add(tn);


        //        }
        //        foreach (TreeNode tnode in tv_Accounts.Nodes)
        //        {
        //            Node_Caild(tnode);
        //        }

        //    }

        //    private void Node_Caild(TreeNode nd)
        //    {
        //        TreeNode ctn ;
        //        DataView dv = new DataView(class_Accounts.Get_All_Accounts());
        //        dv.RowFilter = "Acc_Parent_Num="+Convert.ToInt32(nd.Tag);
        //        // عرض الحسابات في سجرة الحسابات
        //        foreach (DataRowView drv in dv)
        //        {
        //            ctn = new TreeNode(drv["Acc_Num"].ToString() + "  " + drv["Acc_Aname"].ToString());
        //            ctn.Tag = drv["Acc_Num"].ToString();
        //            nd.Nodes.Add(ctn);
        //            Node_Caild(ctn);

        //        }
        //    }
        DataTable tbl_accounts = new DataTable();

        public void FillTreeView(string key, string NodeName, TreeNode N, int NodeColor)
        {
            TreeNode NN;

            if (N == null)
            {
                NN = this.tv_Accounts.Nodes.Add(key, NodeName, 2, 2);
                NN.Tag = "";
            }
            else
            {
                NN = N.Nodes.Add(key, NodeName, NodeColor, NodeColor);
                NN.Tag = key;
            }

            DataView dv = tbl_accounts.DefaultView;
            Int64 xkey = Convert.ToInt64(key);

            dv.RowFilter = "Acc_Parent_Num ='" + xkey + "'";

            foreach (DataRow dr in dv.ToTable().Rows)
            {
                FillTreeView(Convert.ToString(dr["Acc_Num"]), "(" + Convert.ToString(dr["Acc_Num"]) + ") " + Convert.ToString(dr["Acc_Aname"]), NN, Convert.ToInt32(dr["Acc_Type"]));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tv_Accounts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //txt_tag.Text = tv_Accounts.SelectedNode.Tag.ToString();
            xx.Show_Account_Details(this);
        }

        private void txt_tag_TextChanged(object sender, EventArgs e)
        {
        //        DataTable dt,dt2 = new DataTable();
        //        dt = class_Accounts.Get_Accounts_Alone(Convert.ToInt32(txt_tag.Text));

            //        if (dt.Rows.Count>0)
            //        {
            //            txt_Acc_num.Text = dt.Rows[0][0].ToString();
            //            txt_Acc_Aname.Text = dt.Rows[0][2].ToString();
            //            //com_Acc_Parent.Items.Add(dt.Rows[0][2].ToString());
            //            //String a = dt.Rows[0][4].ToString();
            //            if(Convert.ToInt32(dt.Rows[0][4].ToString()) == 1)
            //                {
            //                    com_Acc_Type.Text = "رئيسي";
            //            }
            //            else
            //            {
            //                com_Acc_Type.Text = "فرعي";
            //            }
            //            data.ADB con = new data.ADB();
            //            //int a = Convert.ToInt32(dt.Rows[0][1]);
            //            // dt2 = class_Accounts.Get_Parent_Na(a);


            //            if (Convert.ToInt32(dt.Rows[0][1]) != 0)
            //            {
            //                dt2 = con.par(Convert.ToInt32(dt.Rows[0][1]));
            //                com_Acc_Parent.Text = dt2.Rows[0][2].ToString();
            //               // txt_par_num.Text = dt2.Rows[0][1].ToString();
            //               // txt_parent_num.Text = dt2.Rows[0][1].ToString();
            //            }
            //            else
            //            {
            //               // dt2 = con.par(Convert.ToInt32(dt.Rows[0][1]));
            //                com_Acc_Parent.Text = dt.Rows[0][2].ToString();
            //                txt_par_num.Text = dt.Rows[0][1].ToString();

            //            }
            //               txt_Acc_level.Text = dt.Rows[0][4].ToString();
            //               txt_parent_num.Text = dt.Rows[0][1].ToString();
            //            // else
            //            //   txt_Acc_Parent.Text = "null";
            //            // com_Acc_Parent.Text= dt2.Rows[0][0].ToString();

            //        }
                }

        private void txt_Acc_Parent_TextChanged(object sender, EventArgs e)
        {

        }

        private void com_Acc_Parent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //        try
            //        {
            //            if (com_Acc_Type.SelectedIndex == 0 || com_Acc_Type.SelectedIndex == 1)

            //            {
            //                this.txt_Acc_num.Text = Convert.ToString(xx.GetAccCode(Convert.ToInt64(this.com_Acc_Parent.SelectedValue), this));
            //            }

            //        }
            //        catch
            //        {
            //            return;
            //        }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //        int com_acc_type;
            //        if (com_Acc_Type.Text == "فرعي")
            //            com_acc_type = 2;
            //        else
            //            com_acc_type = 1;
            //        try
            //        {
            //            class_Accounts.addAccount(
            //                Convert.ToInt32(txt_Acc_num.Text),
            //                 Convert.ToInt32(txt_tag.Text),
            //                 txt_Acc_Aname.Text,
            //                 com_acc_type,
            //                 (Convert.ToInt32(txt_Acc_level.Text)+1),
            //                 0.0,
            //                 0.0,
            //                 0.0
            //                );

            //            Create_node();
            //           // btn_add.Enabled = false;
            //            MessageBox.Show("تمت عملية الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        }
            //        catch
            //        {
            //            MessageBox.Show("هناك خطأ يجب تصحيح الخطأ قبل الإدخال", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }


            xx.Save_In_AccountsTbl(this);
            //com_Acc_Parent.TabIndex
            //Update();
            xx.Clear_Controls_Accounts(this);
        }

        private void txt_level_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //        int com_acc_type;
            //        if (com_Acc_Type.Text == "فرعي")
            //            com_acc_type = 2;
            //        else
            //            com_acc_type = 1;
            //        try
            //        {
            //            class_Accounts.editAccount(
            //                 Convert.ToInt32(txt_Acc_num.Text),
            //                 Convert.ToInt32(txt_parent_num.Text),
            //                 txt_Acc_Aname.Text,
            //                 com_acc_type,
            //                 Convert.ToInt32(txt_Acc_level.Text),
            //                 0.0,
            //                 0.0,
            //                 0.0
            //                );

            //         //   Create_node();
            //            // btn_add.Enabled = false;
            //            MessageBox.Show("تمت عملية التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        }
            //        catch
            //        {
            //            MessageBox.Show("هناك خطأ يجب تصحيح الخطأ قبل الإدخال", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }

            xx.Edit_In_AccountsTbl(this);
                }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           if(int.Parse(txt_Acc_num.Text) <= 6)
                MessageBox.Show("لا يمكن حذف هذا الحساب الرئيسي");
           else if (txt_Acc_Aname.Text == "")
                MessageBox.Show("لا يوجد حساب محدد لحذفه");
            else
            {
                int d = tv_Accounts.SelectedNode.GetNodeCount(false);
                if ((d == 0))
                {
                    
                    if ((MessageBox.Show(("هل تود حذف الحساب : " + (tv_Accounts.SelectedNode.Text + " من دليل الحسابات ")), "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))

                    {
                        xx.Delete_Accunt_InDirect(this.txt_Acc_num.Text, this);
                        btn_add.Enabled = true;
                    }

                }
                else
                {
                    MessageBox.Show("معذرة، لا يمكن حذف حساب  رئيسي له ابناء", "رسالة تنبيه ");
                }
            }
        }

        private void com_Acc_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                 if (com_Acc_Type.SelectedIndex == 0 && com_Acc_Parent.Text.Trim() == "")
                {
                  
                    this.txt_Acc_num.Text = xx.GetAccCode(0, this).ToString();
                }
                else if (com_Acc_Type.SelectedIndex == 0 && com_Acc_Parent.Text.Trim() != "")
                {
                   
                    this.txt_Acc_num.Text = Convert.ToString(xx.GetAccCode(Convert.ToInt64(this.com_Acc_Parent.SelectedValue), this));                
                    
                }
                else if (com_Acc_Type.SelectedIndex == 1 && com_Acc_Parent.Text.Trim() != "")
                {
                                      
                    this.txt_Acc_num.Text = Convert.ToString(xx.GetAccCode(Convert.ToInt64(this.com_Acc_Parent.SelectedValue), this));
                   
                }
            }

            catch
            {
                return;
            }
        }

        private void AccountsGuide_Load(object sender, EventArgs e)
        {
            this.AccID.Text = xx.GetNewID_From_AccountTbl().ToString();
            xx.FillCombFromTable(this.com_Acc_Parent);
            xx.FillTables(tbl_accounts);
            this.tv_Accounts.Nodes.Clear();
            FillTreeView("0", "شجرة الحسابات", null, 5);
            this.tv_Accounts.TopNode.Expand();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            xx.Clear_Controls_Accounts(this);
        }

        private void timer_message_seccess_Tick(object sender, EventArgs e)
        {
            this.lbl_Message.Text = null;
           // lbl_Message.Enabled = false;
            this.PictureBoxMessage.Image = null;
            timer_message_seccess.Stop();

        }

        private void PictureBoxMessage_Click(object sender, EventArgs e)
        {

        }

        private void Update()
        {
            xx.FillCombFromTable(this.com_Acc_Parent);
            xx.FillTables(tbl_accounts);
            this.tv_Accounts.Nodes.Clear();
            FillTreeView("0", "شجرة الحسابات", null, 5);
            this.tv_Accounts.TopNode.Expand();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form1 panel_mainhome = new Form1();
            this.Hide();
            panel_mainhome.Controls.Clear();
        }

        private void txt_Acc_Aname_Enter(object sender, EventArgs e)
        {
            var lang = InputLanguage.InstalledInputLanguages.OfType<InputLanguage>().Where(l => l.Culture.Name.StartsWith("ar")).FirstOrDefault();
            if(lang != null)
            {
                InputLanguage.CurrentInputLanguage = lang;
            }
        }

        private void txt_Acc_Aname_TextChanged(object sender, EventArgs e)
        {

        }

        private void com_Acc_Parent_Enter(object sender, EventArgs e)
        {
            var lang = InputLanguage.InstalledInputLanguages.OfType<InputLanguage>().Where(l => l.Culture.Name.StartsWith("ar")).FirstOrDefault();
            if (lang != null)
            {
                InputLanguage.CurrentInputLanguage = lang;
            }
        }

        private void AccID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Acc_num_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
