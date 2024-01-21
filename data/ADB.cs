using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ExchangeAndMony.data
{
    class ADB
    {

        SqlConnection conn=new SqlConnection(@"server=DESKTOP-6FOQ2KB\SQLEXPRESS; database=db_acount; integrated security=true");
        SqlCommand cmd = new SqlCommand();
        
       // public ADB(){
           //   string Mode = Properties.Settings.Default.Mode;
            //  if(Mode == "win")
             //  {
             //    conn = new SqlConnection(@"server="+Properties.Settings.Default.Server+"; database="+Properties.Settings.Default.DB+"; integrated security=true");
          //  }
           //  else
           // {
            //  conn = new SqlConnection(@"server="+Properties.Settings.Default.Server+"; database="+Properties.Settings.Default.DB+"; integrated security=false;user id = "+ Properties.Settings.Default.user+ ";password="+Properties.Settings.Default.password+";");

            //}



           // conn = new SqlConnection(@"server=DESKTOP-6FOQ2KB\SQLEXPRESS; database=db_acount; integrated security=true");
        //}
      public void openConnection()
        {
             
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void ExcuteCmd(string s,SqlParameter[] para)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = s;
            cmd.Connection = conn;
            if(para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            cmd.ExecuteNonQuery();
        }

        public DataTable selectData(string s, SqlParameter[] para)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = s;
            cmd.Connection = conn;


            if(para != null)
            {
                for(int j=0; j < para.Length; j++)
                {
                    cmd.Parameters.Add(para[j]);
                }
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            return dt;
        }

        public DataTable par(int Acc_Parent_Num)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter bus = new SqlDataAdapter();
            bus.SelectCommand = new SqlCommand("select * from tbl_Account where Acc_Num =" +Acc_Parent_Num,conn);
            bus.Fill(dt);
            return dt;

        }
       
    }
}
