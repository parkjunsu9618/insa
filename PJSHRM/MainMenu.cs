using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.ComponentModel;
using System.Data;
using System.Drawing;



namespace PJSHRM
{
    class MainMemu
    {


        /// 목차
        ///- 변수지정
        ///- 생성자
        ///- 메뉴불러오기



        //변수지정
        OracleConnection con = null;
        string connectString = "Data source = 222.237.134.74:1522/ora7;User id=edu;Password=edu1234;";
        OracleCommand cmd = null;
        OracleDataReader rs;
        OracleDataReader rs2;


        /// <summary>
        /// 생성자
        /// </summary>        
        public MainMemu()
        {
            try
            {
                con = new OracleConnection(connectString);
                con.Open();
                cmd = con.CreateCommand();
                cmd.BindByName = true;


                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");

                }
                if (cmd == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }


        }


        /// <summary>
        /// 메뉴불러오기
        /// </summary>
        /// <param name="item_code"></param>
        /// <param name="item_name"></param>
        /// <param name="item_date"></param>
        /// <param name="item_date2"></param>
        /// <returns></returns>
        public List<Dictionary<string, string>> getMenu(string item_code, string item_name, string item_date, string item_date2)
        {

            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

                //가공하기
                List<Dictionary<String, String>> item_values = new List<Dictionary<String, String>>();



                string sql_item_find = "select * from pjs_item where " +
                    "item_name like :item_code and " +
                    "item_name like :item_name and " +
                    "item_date >= :item_date and " +
                    "item_date <= :item_date2 and " +
                    "item_yn = 'n'";

                cmd.CommandText = sql_item_find;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = "%" + item_code + "%";
                cmd.Parameters.Add("item_name", OracleDbType.Varchar2).Value = "%" + item_name + "%";
                cmd.Parameters.Add("item_date", OracleDbType.Varchar2).Value = item_date;
                cmd.Parameters.Add("item_date2", OracleDbType.Varchar2).Value = item_date2;
                rs = cmd.ExecuteReader();


                while (rs.Read())
                {
                    Dictionary<String, String> item_value = new Dictionary<string, string>();

                    item_value.Add("item_code", rs["item_code"].ToString());
                    item_value.Add("item_name", rs["item_name"].ToString());
                    item_value.Add("item_stand", rs["item_stand"].ToString());
                    item_value.Add("item_date", rs["item_date"].ToString());
                    item_value.Add("item_amt", rs["item_amt"].ToString());
                    item_value.Add("item_comp", rs["item_comp"].ToString());
                    item_value.Add("item_samt", rs["item_samt"].ToString());
                    item_value.Add("item_posi", rs["item_posi"].ToString());
                    item_value.Add("item_etc", rs["item_etc"].ToString());
                    item_value.Add("user_sys", rs["user_sys"].ToString());
                    item_value.Add("user_sysid", rs["user_sysid"].ToString());


                    item_values.Add(item_value);
                }
                return item_values;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            finally
            {
                con.Close();
            }


            return null;
        }











    }
}
