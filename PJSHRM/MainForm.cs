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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Point _imageLocation = new Point(22, 5);
        private Point _imgHitArea = new Point(22, 2);
        Image CloseImage;


        Type t;
        Form frm;

        Form mainPageForm = new PJSsub000();


        /// <summary>
        /// 목차
        /// 
        /// 1.코드관리
        /// 
        /// 2.폼생성
        /// - 폼만들기
        /// - 폼이동
        /// - 폼체크
        /// - 인스턴스생성
        /// 
        /// 3.탭이벤트
        /// - 탭이동
        /// - 탭그리기
        /// - 탭삭제
        /// 
        /// 4.이벤트
        /// - 로드
        /// 
        /// 5.
        /// - 즐겨찾기
        /// </summary>









        #region 코드관리
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //버튼관리
        /**
         * crud 컨트롤 key
         */
        public void btnValue()
        {
            serchBtn.Enabled = true;

            changeBtn.Enabled = false;
            deleteBtn.Enabled = false;
            confirmBtn.Enabled = true;
            canselBtn.Enabled = true;

        }
        public void btnValue2()
        {
            serchBtn.Enabled = true;

            changeBtn.Enabled = true;
            deleteBtn.Enabled = true;
            confirmBtn.Enabled = false;
            canselBtn.Enabled = false;

        }
        public void btnValue3()
        {
            serchBtn.Enabled = false;
            changeBtn.Enabled = false;
            deleteBtn.Enabled = false;
            confirmBtn.Enabled = false;
            canselBtn.Enabled = false;

        }
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        #endregion
















        #region 폼생성
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------




        //트리뷰선택
        private void MainTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            string tree = e.Node.Name;
            string tag_value = MainTree.SelectedNode.Tag.ToString();

            //현재폼검사
            //Console.Clear();





            //태그값 없을때 불러오기. tag값 비우기
            if (tag_value != "")
            {

                //폼이 열렸는지 안열렸는지 검사하는로직
                int form_check = formExit(tree);
                //폼없음
                if (form_check == 1)
                {



                    Form target_frm = GetInstance("PJSHRM." + tag_value);
                    make_tap(target_frm, tree, tag_value);





                    //폼확인
                    //foreach (Form OpenForm in Application.OpenForms)
                    //{
                    //    Console.WriteLine(OpenForm);
                    //}


                }
                else if (form_check == -1)
                {
                    move_tap(tree, "tap");
                }
                else
                {
                    move_tap(tree, "form");
                }

            }
            else
            {

            }

        }



        //폼만들기
        public void make_tap(Form target_form, string title, string tag_value)
        {
                      
            if (checkingNew.Checked)
            {

                NewFormFrame FrameForm = new NewFormFrame();
                FrameForm.Text = title;




                target_form.TopLevel = false;

                target_form.Size = FrameForm.target_panel.Size;
                


                FrameForm.target_panel.Controls.Add(target_form);

                //태그밸류
                FrameForm.target_panel.Tag = tag_value;

                target_form.Show();

                

                FrameForm.Show();
                FrameForm.BringToFront();



            }
            else
            {
                //컨텐츠 넣을 페이지 추가
                TabPage mypage = new TabPage(title);

                //패널안에 폼을 넣기  
                target_form.TopLevel = false;


                target_form.Size = mainTap.Size;


                mypage.Controls.Add(target_form);

                //태그밸류
                mypage.Tag = tag_value;

                //만들어진 탭 페이지를 탭컨트롤에 넣기.
                mainTap.TabPages.Add(mypage);



                mainTap.SelectedTab = mypage;


                target_form.Show();

            }




        }

        //폼이동
        public void move_tap(string title,string sort)
        {
            if(sort == "tap")
            {
                foreach (TabPage target in mainTap.TabPages)
                {
                    if (target.Text == title)
                    {
                        mainTap.SelectedTab = target;
                    }
                }
            }
            else if(sort == "form")
            {

                foreach (Form OpenForm in Application.OpenForms)
                {



                    if (OpenForm.Text == title)
                    {
                        OpenForm.BringToFront();
                    }



                }

            }


        }


        //폼체크
        public int formExit(string title)
        {

            //탭페이지 폼 체킹
            foreach (TabPage target in mainTap.TabPages)
            {

                if (target.Text == title)
                {
                    return -1;
                }
            }

            //폼분할 화면 체킹
            foreach (Form OpenForm in Application.OpenForms)
            {

                if (OpenForm.Text == title)
                {
                    return -2;
                }



            }




            return 1;




        }


        //인스턴스생성
        public Form GetInstance(string strFullyQualifiedName)
        {
            t = Type.GetType(strFullyQualifiedName);
            frm = Activator.CreateInstance(t, null) as Form;
            return frm;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        #endregion















        #region 탭이벤트
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------






        //탭사이즈
        private void mainTap_Resize(object sender, EventArgs e)
        {

            //폼크기 맞추기


            //열려있는 폼만 사이즈 맞추기.
            foreach (TabPage pages in mainTap.TabPages)
            {

                //탭컨트롤 페이지안 컨트롤은 폼 하나뿐.
                foreach (Form target in pages.Controls)
                {

                    target.Size = mainTap.Size;
                }

            }
        }

        //탭이동
        private void mainTap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mainTap.SelectedIndex >= 0)
            {
                if (mainTap.SelectedTab.Tag == null)
                {
                    return;
                }

                string tag_value = mainTap.SelectedTab.Tag.ToString();

                t = Type.GetType("PJSHRM." + tag_value);

                frm = (Form)mainTap.SelectedTab.Controls.Find(tag_value, true).FirstOrDefault();
            }


        }
        
        //탭그리기
        private void mainTap_DrawItem(object sender, DrawItemEventArgs e)
        {


            

            //TabP.Controls.Find(tc.TabPages[tc.SelectedIndex].Tag.ToString(), true).FirstOrDefault().Dispose();

            try
            {
                Image img = new Bitmap(CloseImage);
                Rectangle r = e.Bounds;
                r = this.mainTap.GetTabRect(e.Index);
                r.Offset(2, 2);
                Brush TitleBrush = new SolidBrush(Color.Black);
                Font f = this.Font;
                string title = this.mainTap.TabPages[e.Index].Text;

                e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));

                


                if (mainTap.SelectedIndex >= 0)
                {
                    e.Graphics.DrawImage(img, new Point(r.X + (this.mainTap.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
                }
            }
            catch (Exception) { }
        }

        //탭삭제
        private void mainTap_MouseDown(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.mainTap.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.mainTap.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (mainTap.SelectedIndex >= 0)
            {
                if (r.Contains(p))
                {
                    TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];


                    //TabP.Controls.Find(tc.TabPages[tc.SelectedIndex].Tag.ToString(), true).FirstOrDefault().Dispose();
                    tc.TabPages.Remove(TabP);
                    
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------        
        #endregion























        #region 이벤트
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------

        //로드
        private void MainForm_Load(object sender, EventArgs e)
        {

            #region 메인메뉴불러오기

            MainMemu menu = new MainMemu();


            
















            #endregion








            //mainPage form 호출



            //mainPageForm.TopLevel = false;
            //mainPageForm.Size = mainPage.Size;

            ////mainPageForm.Tag = 

            //mainPage.Controls.Add(mainPageForm);

            //mainPageForm.Show();






            //// 아이콘 리스트 만들기
            //ImageList myimageList = new ImageList();
            //// 아이콘
            //myimageList.Images.Add(Properties.Resources.docs);
            //myimageList.Images.Add(Properties.Resources.google_docs);
            //myimageList.Images.Add(Properties.Resources.door_key);
            //myimageList.Images.Add(Properties.Resources.key2);

            //MainTree.ImageList = myimageList;


            //MainTree.Nodes[0].ImageIndex = 2;
            //MainTree.Nodes[1].ImageIndex = 1;







            //MainTree.Nodes[0].Nodes[0].ImageIndex = 3;


            // 아이콘 추가
            //TreeNode AllCreator = new TreeNode("이름");
            //AllCreator.ImageIndex = 0;
            //AllCreator.SelectedImageIndex = 0;
            //MainTree.Nodes.Add(AllCreator);




            //tap draw
            mainTap.DrawMode = TabDrawMode.OwnerDrawFixed;
            mainTap.DrawItem += mainTap_DrawItem;
            CloseImage = PJSHRM.Properties.Resources.remove22;
            mainTap.Padding = new Point(23, 4);


            //






        }








            



        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------
        #endregion




        //즐겨찾기
        private void MainTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {


            if(e.Button == MouseButtons.Right)
            {



                contextMenuStrip1.Show(MainTree, e.Location);

                MainTree.SelectedNode = e.Node;

            }

        }
    }
}
