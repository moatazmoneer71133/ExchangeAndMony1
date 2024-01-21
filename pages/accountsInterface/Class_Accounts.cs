using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExchangeAndMony.pages.accountsInterface
{
   
    class Class_Accounts
    {
       // DataTable dt;

        //public DataTable Get_All_Accounts()
        //{
        //    data.ADB con = new data.ADB();
            
        //    con.openConnection();
        //    dt = new DataTable();
        //    dt = con.selectData("Get_All_Accounts", null);
        //    return dt; 
        //}

        //public DataTable Get_Accounts_Alone(int Acc_No)
        //{
        //    data.ADB con = new data.ADB();
        //    con.openConnection();
        //    dt = new DataTable();
        //    SqlParameter[] para = new SqlParameter[1];
        //    para[0] = new SqlParameter("@Acc_Num",SqlDbType.Int);
        //    para[0].Value = Acc_No; 
        //    dt = con.selectData("Get_Accounts_Alone", para);
        //    con.closeConnection();
        //    return dt;
        //}

        //public DataTable Get_Parent_Na(int Acc_Pa_No)
        //{
        //    data.ADB con = new data.ADB();
        //   // con.openConnection();
        //    dt = new DataTable();
        //    SqlParameter[] para1 = new SqlParameter[1];
        //    para1[0] = new SqlParameter("@Acc_Parent_Num", SqlDbType.Int);
        //    para1[0].Value = Acc_Pa_No;
        //    dt = con.selectData("Get_Parent_Na", para1);
        //   // con.closeConnection();
        //    return dt;
        //}
        //public void addAccount(int accno, int accparent, String accname,int acctype, int acclvl, double debit=0.0, double credit=0.0, double balance = 0.0)
        //{
        //    data.ADB con = new data.ADB();
        //    con.openConnection();
        //    SqlParameter[] para = new SqlParameter[8];
        //    para[0] = new SqlParameter("@Acc_Num", SqlDbType.Int);
        //    para[0].Value = accno;
        //    para[1] = new SqlParameter("@Acc_Parent_Num", SqlDbType.Int);
        //    para[1].Value = accparent;
        //    para[2] = new SqlParameter("@Acc_Aname", SqlDbType.NVarChar, 60);
        //    para[2].Value = accname;
        //    para[3] = new SqlParameter("@Acc_Type", SqlDbType.Int);
        //    para[3].Value = acctype;
        //    para[4] = new SqlParameter("@Acc_Level", SqlDbType.Int);
        //    para[4].Value = acclvl;
        //    para[5] = new SqlParameter("@Acc_Depet", SqlDbType.Decimal);
        //    para[5].Value = debit;
        //    para[6] = new SqlParameter("@Acc_Credit", SqlDbType.Decimal);
        //    para[6].Value = credit;
        //    para[7] = new SqlParameter("@Acc_Balance", SqlDbType.Decimal);
        //    para[7].Value = balance;
        //    con.ExcuteCmd("account_add", para);
        //    con.closeConnection();

        //}

        //// Account_Update
        //public void editAccount(int accno, int accparent, String accname, int acctype, int acclvl, double debit = 0.0, double credit = 0.0, double balance = 0.0)
        //{
        //    data.ADB con = new data.ADB();
        //    con.openConnection();
        //    SqlParameter[] para = new SqlParameter[8];
        //    para[0] = new SqlParameter("@Acc_Num", SqlDbType.Int);
        //    para[0].Value = accno;
        //    para[1] = new SqlParameter("@Acc_Parent_Num", SqlDbType.Int);
        //    para[1].Value = accparent;
        //    para[2] = new SqlParameter("@Acc_Aname", SqlDbType.NVarChar, 60);
        //    para[2].Value = accname;
        //    para[3] = new SqlParameter("@Acc_Type", SqlDbType.Int);
        //    para[3].Value = acctype;
        //    para[4] = new SqlParameter("@Acc_Level", SqlDbType.Int);
        //    para[4].Value = acclvl;
        //    para[5] = new SqlParameter("@Acc_Depet", SqlDbType.Decimal);
        //    para[5].Value = debit;
        //    para[6] = new SqlParameter("@Acc_Credit", SqlDbType.Decimal);
        //    para[6].Value = credit;
        //    para[7] = new SqlParameter("@Acc_Balance", SqlDbType.Decimal);
        //    para[7].Value = balance;

        //    con.ExcuteCmd("account_update", para);
        //    con.closeConnection();

        //}
    }
}
