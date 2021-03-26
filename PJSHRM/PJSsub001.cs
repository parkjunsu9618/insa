using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJSHRM
{
    public partial class PJSsub001 : Form
    {
        /// <summary>
        /// 목차
        /// 1. 로드
        /// - 콤보박스default
        ///
        /// </summary>





        public PJSsub001()
        {
            InitializeComponent();
        }

        //로드
        private void PJSsub001_Load(object sender, EventArgs e)
        {
            //콤보박스default
            cdg_use.SelectedIndex = 0;
            cdg_kind.SelectedIndex = 0;



        }

        //값을 담아서 한번에 보내는 방법? 


        //컨트롤내에 있는 string 으로 받을 수 있는 값 가져오기


        public List<Dictionary<String, String>> makeDataVarchar()
        {

            //데이터 가공 전에 validation 체크하기.
            //1. 값이 제대로 들어 갔는지 확인하기.
            //2.









            //string 으로 받은다음 데이터 넣기전에 number로 가공하기?
            List<Dictionary<String, String>> datas = new List<Dictionary<String, String>>();









            foreach (Control target in info.Controls)
            {
                if (target is TextBox || target is ComboBox)
                {
                    Dictionary<String, String> data = new Dictionary<string, string>();
                    //데이터 만들기


                    Console.WriteLine(target.Name.GetType());


                    data.Add(target.Name, target.Text);




                    datas.Add(data);

                    Console.WriteLine("textbox:" + target.Name + ":" + target.Text);
                }


                //else if (target is NumericUpDown)
                //{
                //    Console.WriteLine("number:" + target.Name);
                //}
                //else if (target is DateTimePicker)
                //{
                //    Console.WriteLine("asdfasdfsda");
                //}



            }


            //ipgo_value.Add("ipgo_code", ipgo_code.Text);
            //ipgo_value.Add("ipgo_date", ipgo_date.Text);
            //ipgo_value.Add("ipgo_cnt", ipgo_cnt.Text);
            //ipgo_value.Add("ipgo_comp", ipgo_comp.Text);
            //ipgo_value.Add("ipgo_amt", ipgo_amt.Text);
            //ipgo_value.Add("user_sysid", user_sysid);
            return datas;
        }






        private void button1_Click(object sender, EventArgs e)
        {
            PJS_INSA_CDG cdg = new PJS_INSA_CDG();

            //cdg.serch(ifam_rel.Text);
            List<Dictionary<string, string>> aa = makeDataVarchar();
            









        }
    }
}
