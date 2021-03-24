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
    class Data
    {
        OracleConnection con = null;
        string connectString = "Data source = product-management.chkwjetizrxz.ap-northeast-2.rds.amazonaws.com:1521/PRODUCT;User Id=root;Password=bestrong";
        OracleCommand cmd = null;



        OracleDataReader rs;
        OracleDataReader rs2;




        // 테이블 정보를 매개변수로 받는다.
        // 테이블 의 칼럼 값들을 읽는다. (값들을 읽어서 리스트 배열에 넣는다.) --> 배열에 담은 값들은 해당 테이블의 칼럼값들이다. ,전역변수로 선언
        // 그러면 여기 클래스 에서는 테이블 정보, 칼럼들의 정보를 받을수 있다.
        // crud 할때는 값들을 따로 매개변수로 만들어서 => 전역변수로 리스트 변수와 선언된것과 비교해서 값들 확인.
        // 
        public Data()
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



    }
}
