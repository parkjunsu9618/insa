using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PJSHRM.DB_CONNECT;


namespace PJSHRM
{
    class PJS_INSA_CDG
    {


        DB_CONNECT DB = new DB_CONNECT();

        public PJS_INSA_CDG()
        {

        }



        public void serch(string cdg)
        {

            String sql_find = "select * " +
                "from PJS_INSA_CDG " +
                "where cdg_grpcd = :cdg_grpcd ";

            cmd.CommandText = sql_find;
            cmd.Parameters.Add("cdg_grpcd", OracleDbType.Varchar2).Value = cdg;

            rs = cmd.ExecuteReader();

            if (rs.Read())
            {
                Console.WriteLine(rs);

                MessageBox.Show("오늘 등록된 출고처리가 있습니다");
                return;
            }

        }










        public void insert(Dictionary<String, String> culgo_value, string item_samt)
        {


            try
            {
                
                String sql_find = "select * " +
                                "from PJS_INSA_CDG " +
                                "where cdg_grpcd = :cdg_grpcd ";

                cmd.CommandText = sql_find;
                cmd.Parameters.Add("culgo_code", OracleDbType.Varchar2).Value = culgo_value["culgo_code"];
                cmd.Parameters.Add("culgo_date", OracleDbType.Varchar2).Value = culgo_value["culgo_date"];

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    MessageBox.Show("오늘 등록된 출고처리가 있습니다");
                    return;
                }

                //else
                //{

                //    String sql_insert = "insert into pjs_culgo" +
                //        "(culgo_code, culgo_date, culgo_cnt, culgo_sau,culgo_amt, user_sysid) " +
                //        "values(:culgo_code, :culgo_date, :culgo_cnt, :culgo_sau, :culgo_amt, :user_sysid)";


                //    cmd2.CommandText = sql_insert;

                //    cmd2.Parameters.Add("culgo_code", OracleDbType.Varchar2).Value = culgo_value["culgo_code"];
                //    cmd2.Parameters.Add("culgo_date", OracleDbType.Varchar2).Value = culgo_value["culgo_date"];
                //    cmd2.Parameters.Add("culgo_cnt", OracleDbType.Varchar2).Value = culgo_value["culgo_cnt"];
                //    cmd2.Parameters.Add("culgo_sau", OracleDbType.Varchar2).Value = culgo_value["culgo_sau"];
                //    cmd2.Parameters.Add("culgo_amt", OracleDbType.Varchar2).Value = culgo_value["culgo_amt"];
                //    cmd2.Parameters.Add("user_sysid", OracleDbType.Varchar2).Value = culgo_value["user_sysid"];
                //    cmd2.ExecuteNonQuery();


                //    //재고량값 가져오기 -- 재고량 가져오기


                //    //int형 바꾸기
                //    item_samt = (Int32.Parse(item_samt) - Int32.Parse(culgo_value["culgo_cnt"])).ToString();




                //    //출고처리후 재고량 + 해주기. (업데이트처리)
                //    String item_insert = "update pjs_item " +
                //        "set item_samt = :item_samt " +
                //        "where item_code = :item_code";
                //    cmd4.CommandText = item_insert;
                //    cmd4.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_samt;
                //    cmd4.Parameters.Add("item_code", OracleDbType.Varchar2).Value = culgo_value["culgo_code"];
                //    cmd4.ExecuteNonQuery();


                //    MessageBox.Show("등록완료");



                //}

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            //db connection 해제 해주는 작업을 해줘야함.
            finally
            {
                con.Close();
            }



        }

        























    }
}
