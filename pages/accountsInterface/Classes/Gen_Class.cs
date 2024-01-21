
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;
using System.Diagnostics;
using ExchangeAndMony.data;
using ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface;


namespace ExchangeAndMony.pages.accountsInterface.Classes
{

    class Gen_Class
    {
        // conection conn = new conection();
        //AccountsGuide accountsGuide = new AccountsGuide();
        //   SqlConnection conn = new SqlConnection(@"server=DESKTOP-6FOQ2KB\SQLEXPRESS; database=db_Account1; integrated security=true");
        // Get New ID
        public Double GetNewID_From_AccountTbl()
        {
            ADB con = new ADB();
            DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select isnull(MAX(ACCID),1) from tbl_accounts", conection.con);
            da.Fill(dt);
            Double ID;
            ID = Convert.ToInt64(dt.Rows[0][0]);
            if (ID == 1)
            {
                ID = 1;
            }

            else if (ID > 1)

            {
                ID = ID + 1;
            }

            return ID;
            da.Dispose();
            dt.Dispose();
        }

        public Int64 GetAccCode(Int64 Result, AccountsGuide xx)
        {
            // MessageBox.Show(Result.ToString() + ".1");
         


                DataTable dt = new DataTable();
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter();
            //if (Result != 0)
            //{
                da = new SqlDataAdapter("select isNull(MAX(Acc_Num),1) from tbl_accounts where Acc_Parent_Num = " + Result + " ", conection.con);
                da.Fill(dt);
           // }


                Int64 MyNewID;
                MyNewID = Convert.ToInt64(dt.Rows[0][0]);
            MessageBox.Show("-----" + MyNewID );
            //if (Result == 0)
            //    MyNewID = Result;


            if (xx.com_Acc_Type.SelectedIndex == 0)
            {
               
                if (MyNewID == 1)
                {
             
                    MyNewID = int.Parse(Result.ToString() + "0".ToString() + 1);
                  
                }

                else
                {
                    MyNewID = (Convert.ToInt64(dt.Rows[0][0]) + 1);
                   
                }

            }
            else if (xx.com_Acc_Type.SelectedIndex == 1)
            {

                if (MyNewID == 1)
                {
                    MessageBox.Show("com_Acc_Type.SelectedIndex == 0 ...1111....");
                    MyNewID = int.Parse(Result.ToString() + "0".ToString() + "0".ToString() + "0".ToString() + 1);
                }

                else
                {
                    MessageBox.Show(xx.com_Acc_Type.SelectedIndex.ToString() + "--" + MyNewID);
                    MyNewID = (Convert.ToInt64(dt.Rows[0][0]) + 1);

                }


            }
            else
            {
                MessageBox.Show(xx.com_Acc_Type.SelectedIndex.ToString());
            }

            return MyNewID;
            // لتخلص من ال"dataAdepter"  من الرام
            da.Dispose();
            dt.Dispose();

        }
        public void FillCombFromTable(ComboBox cmb)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select  Acc_Num,Acc_Aname from tbl_accounts where Acc_Type = " + 0 + " ", conection.con);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmb.DataSource = dt;
                cmb.DisplayMember = "Acc_Aname";
                cmb.ValueMember = "Acc_Num";
                cmb.Text = null;

            }
            else
            {
                cmb.DataSource = null;
            }
            da.Dispose();

        }

        public void Clear_Controls_Accounts(AccountsGuide xx)
        {

            // xx.Acc_ID.Text = Convert.ToString(this.GetNewID_From_AccountTbl());
            xx.txt_Acc_Aname.Text = null;
            xx.txt_Acc_num.Text = null;
            xx.com_Acc_Type.Text = null;
            xx.com_Acc_Parent.Text = null;
            xx.AccFinal.Text = null;
            // xx.btn_add.Enabled = true;

        }

        public void Save_In_AccountsTbl(AccountsGuide xx)
        {
            try
            {
                if (xx.com_Acc_Type.SelectedIndex == 0 && xx.com_Acc_Parent.Text.Trim() != "" && xx.txt_Acc_num.Text == "")
                {
                    MessageBox.Show("لا يوجد رقم للحساب حدد الحساب الأب,  ثم قم بتحديد نوع الحساب ليظهر لك رقم الحساب");

                }
                else
                if ((xx.AccID.Text.Trim() == ""))
                {
                    return;
                    
                }
                else if ((xx.txt_Acc_Aname.Text.Trim() == ""))
                {
                    xx.txt_Acc_Aname.Focus();
                      MessageBox.Show("2");
                }
                else if (((xx.com_Acc_Type.SelectedIndex == 1) && (xx.com_Acc_Parent.Text.Trim() == "")))

                {
                    MessageBox.Show("الحساب الفرعي يجب ان يكون له حساب اب ");

                }
                //else if ((xx.AccFinal.Text.Trim() == ""))
                //{
                //    MessageBox.Show("من فضلك اختر الحساب الختامي ");
                //}
                else if ((xx.txt_Acc_num.TextLength > 17))
                {
                    MessageBox.Show(" معذرة، لقد وصلت الى المستوى الاخير في دليل الحسابات لا يمكنك اضافة حساب في هذا المستوى");
                    return;
                }
                else
                {
                    
           
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    dt.Clear();
                    // (Convert.ToInt32(xx.AccID.Text.Trim())+1)
                    da = new SqlDataAdapter(("Select * FROM tbl_accounts where ACCID = " + xx.AccID.Text.Trim() + " "), conection.con);

                    da.Fill(dt);
                    if ((dt.Rows.Count == 0))
                    {
                       
                        dt.Rows.Add();
                        int last = (dt.Rows.Count - 1);

                        dt.Rows[last]["ACCID"] = xx.AccID.Text;
                        dt.Rows[last]["Acc_Num"] = xx.txt_Acc_num.Text;
                        dt.Rows[last]["Acc_Aname"] = xx.txt_Acc_Aname.Text.ToString();
                        dt.Rows[last]["Acc_Type"] = xx.com_Acc_Type.SelectedIndex;

                        if ((xx.com_Acc_Parent.Text.Trim() == ""))
                        {
                            dt.Rows[last]["Acc_Parent_Num"] = 0;
                        }
                        else if ((xx.com_Acc_Parent.Text.Trim() != ""))
                        {
                            dt.Rows[last]["Acc_Parent_Num"] = xx.com_Acc_Parent.SelectedValue;
                           
                        }

                        // بشكل تلقائيinsert  يقوم بتوليد جملة ال 
                        SqlCommandBuilder Save = new SqlCommandBuilder(da);
                        da.Update(dt);
                        dt.AcceptChanges();
                      
                 
                        //if (xx.tv_Accounts.SelectedNode.IsSelected == true)
                        //{

                        //    string NodeName = xx.txt_Acc_Aname.Text;
                        //    // ' load data to refresh Treeview
                        //    TreeNode TN = new TreeNode(("(" + (xx.txt_Acc_num.Text + (") " + NodeName))), xx.com_Acc_Type.SelectedIndex, (xx.com_Acc_Type.SelectedIndex + 3));

                        //    TN.Tag = xx.txt_Acc_num.Text;
                        //    xx.tv_Accounts.SelectedNode.Nodes.Add(TN);
                        //    xx.tv_Accounts.SelectedNode.Expand();
                        //}
                        //else { MessageBox.Show("11111تم الحفظ بنجاح"); }

                        // ==========================================================
                        // ' clear Control
                      //  xx.txt_Acc_Aname.Clear();
                        xx.AccID.Text = Convert.ToString(Convert.ToInt64(xx.AccID.Text) + 1);
                        xx.txt_Acc_num.Text = Convert.ToString(Convert.ToInt64(xx.txt_Acc_num.Text) + 1);
                        xx.lbl_Message.Text = "تم الحفظ بنجاح";
                        xx.PictureBoxMessage.Image = Properties.Resources.OK;
                        xx.timer_message_seccess.Start();
                        if ((xx.com_Acc_Type.SelectedIndex == 0))
                        {
                            Int64 ParentID = Convert.ToInt64(xx.com_Acc_Parent.SelectedValue);
                            // Fill Main Accounts"
                            FillCombFromTable(xx.com_Acc_Parent);
                            xx.com_Acc_Parent.SelectedValue = ParentID;
                        }

                        // Clear Controls
                        //xx.AccNote.Text = null;
                        //xx.AccStopped.Checked = false;
                        //xx.AccPhone.Text = null;
                        //xx.AccPhone2.Text = null;
                        //xx.AccMail.Text = null;
                        //xx.AccAddress.Text = null;
                        //xx.AccMaxDuration.Text = "0";
                        //xx.AccMaxLimt.Text = "0";
                        //xx.AccName.Focus();
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }


        // Show Account details
        public void Show_Account_Details(AccountsGuide xx)
        {
            try
            {
                DataTable DT = new DataTable();
                DT.Clear();
                TreeNode N;
                N = xx.tv_Accounts.SelectedNode;
                string sql;
                sql = ("Select * FROM tbl_accounts where Acc_Num = '" + N.Tag + "'");

                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter(sql, conection.con);
                da.Fill(DT);
                if ((DT.Rows.Count > 0))
                {
                    xx.AccID.Text = DT.Rows[0]["AccID"].ToString();
                    xx.txt_Acc_Aname.Text = DT.Rows[0]["Acc_Aname"].ToString();
                    xx.com_Acc_Type.SelectedIndex = Convert.ToInt16(DT.Rows[0]["Acc_Type"]);
                    xx.com_Acc_Parent.SelectedValue = DT.Rows[0]["Acc_Parent_Num"];
                    // xx.AccFinal.SelectedIndex = Convert.ToInt16(DT.Rows[0]["AccFinal"]);
                    xx.txt_Acc_num.Text = DT.Rows[0]["Acc_Num"].ToString();

                    xx.btn_add.Enabled = true;
                    xx.btn_edit.Enabled = true;
                    xx.btn_print.Enabled = true;
                    xx.btn_delete.Enabled = true;
                }
                else
                {
                    // clearTools
                    Clear_Controls_Accounts(xx);
                    xx.btn_add.Enabled = false;
                }



            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message)
                return;
            }

        }



        // Update Account data
        public void Edit_In_AccountsTbl(AccountsGuide xx)
        {
            try
            {
                if ((xx.AccID.Text.Trim() == ""))
                {
                    return;
                    // MessageBox.Show("1");
                }
                else if ((xx.txt_Acc_Aname.Text.Trim() == ""))
                {
                    xx.txt_Acc_Aname.Focus();
                    //  MessageBox.Show("2");
                }
                else if (((xx.com_Acc_Type.SelectedIndex == 1) && (xx.com_Acc_Parent.Text.Trim() == "")))

                {
                    MessageBox.Show("الحساب الفرعي يجب ان يكون له حساب اب ");

                }
                //else if ((xx.AccFinal.Text.Trim() == ""))
                //{
                //    MessageBox.Show("من فضلك اختر الحساب الختامي ");
                //}
                else if ((xx.txt_Acc_num.TextLength > 17))
                {
                    MessageBox.Show(" معذرة، لقد وصلت الى المستوى الاخير في دليل الحسابات لا يمكنك اضافة حساب في هذا المستوى");
                    return;
                }
                else
                {


                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    dt.Clear();

                    da = new SqlDataAdapter(("Select * FROM tbl_accounts where ACCID = " + xx.AccID.Text.Trim() + " "), conection.con);

                    da.Fill(dt);
                    if ((dt.Rows.Count > 0))
                    {

                        //dt.Rows.Add();
                        // int last = (dt.Rows.Count - 1);

                        dt.Rows[0]["ACCID"] = xx.AccID.Text;
                        dt.Rows[0]["Acc_Num"] = xx.txt_Acc_num.Text;
                        dt.Rows[0]["Acc_Aname"] = xx.txt_Acc_Aname.Text.ToString();
                        dt.Rows[0]["Acc_Type"] = xx.com_Acc_Type.SelectedIndex;
                        //dt.Rows[last]["Acc_Type"] =
                        //dt.Rows[last]["Acc_Type"] =
                        //dt.Rows[last]["Acc_Type"] =
                        //dt.Rows[last]["Acc_Type"] =
                        if (xx.com_Acc_Parent.Text.ToString() == "")
                        {
                            dt.Rows[0]["Acc_Parent_Num"] = Convert.ToInt32(0);
                        }
                        else if (xx.com_Acc_Parent.Text.Trim() != "")
                        {
                            dt.Rows[0]["Acc_Parent_Num"] = xx.com_Acc_Parent.SelectedValue;
                        }

                        //       dt.Rows[0]["AccFinal"] = xx.AccFinal.SelectedIndex;
                        //       dt.Rows[0]["AccNote"] = xx.AccNote.Text.ToString();
                        dt.Rows[0]["EditDate"] = DateTime.Now.Date.ToString("yyyy-MM-dd");
                        //  dt.Rows[0]["EditUser"] = 1;

                        // بشكل تلقائيinsert  يقوم بتوليد جملة ال 
                        SqlCommandBuilder Save = new SqlCommandBuilder(da);
                        da.Update(dt);
                        dt.AcceptChanges();

                        string NodeName = ("(" + (xx.txt_Acc_num.Text + (") " + xx.txt_Acc_Aname.Text)));

                        xx.tv_Accounts.SelectedNode.Text = NodeName;
                        xx.tv_Accounts.SelectedNode.Checked.ToString();
                        // ==========================================================
                        //  clear Control
                        Clear_Controls_Accounts(xx);
                        xx.lbl_Message.Text = "تم التعديل بنجاج";
                        xx.PictureBoxMessage.Image = Properties.Resources.OK;
                        xx.timer_message_seccess.Start();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        // Delete Accounts
        public void Delete_Accunt_InDirect(string index, AccountsGuide xx)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            dt.Clear();
            da = new SqlDataAdapter("Delete  FROM tbl_accounts where Acc_Num = " + index + "", conection.con);
            da.Fill(dt);
            xx.tv_Accounts.SelectedNode.Remove();
            // give msgbox to sure save
            xx.lbl_Message.Text = "تم الحذف بنجاح";
            xx.PictureBoxMessage.Image = Properties.Resources.OK;
            xx.timer_message_seccess.Start();
            da.Dispose();
            dt.Dispose();
        }
        //fill Tables
        public void FillTables(DataTable dt)
        {
            //DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select Acc_Num,Acc_Aname,Acc_Parent_Num,Acc_Type from tbl_accounts", conection.con);
            da.Fill(dt);
            da.Dispose();
        }

        public void tv_update()
        {
            //xx.FillCombFromTable(this.com_Acc_Parent);
            //xx.FillTables(tbl_accounts);
            //this.tv_Accounts.Nodes.Clear();
            //FillTreeView("0", "شجرة الحسابات", null, 5);
            //this.tv_Accounts.TopNode.Expand();
        }





        //public void add_currency(String CurrencyName,String ArabicSymbol, String EnglishSymbol, String Note)
        //{
        //    //dt.Clear();
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da = new SqlDataAdapter("insert into Currencise ('CurrencyName','ArabicSymbol','EnglishSymbol',Date','Note') values("+CurrencyName+","+ArabicSymbol+","+EnglishSymbol+","+"2024"+","+Note+")", conection.con);
        //    da.Fill(dt);
        //    da.Dispose();
        //}
    }
}
