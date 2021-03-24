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
    class Memu
    {
        OracleConnection con = null;
        string connectString = "Data source = 222.237.134.74:1522/ora7;User id=edu;Password=edu1234;";
        OracleCommand cmd = null;


        OracleDataReader rs;
        OracleDataReader rs2;


        public Memu()
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
