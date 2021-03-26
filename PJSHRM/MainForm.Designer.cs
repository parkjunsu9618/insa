namespace PJSHRM
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("그룹코드관리");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("일반코드관리");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("부서코드관리");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("코드관리", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("인사기본사항");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("인사변동사항");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("가족사항");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("학력사항");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("수상경력");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("경력사항");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("자격면허");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("외국어");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("인사기록조회(통합)");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("인사기록관리", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.adminName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.label_hint = new System.Windows.Forms.Label();
            this.serchBtn = new FontAwesome.Sharp.IconButton();
            this.canselBtn = new FontAwesome.Sharp.IconButton();
            this.changeBtn = new FontAwesome.Sharp.IconButton();
            this.confirmBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTap = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkingNew = new System.Windows.Forms.CheckBox();
            this.MainTree = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ㅇㅇㅇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.즐겨찾기메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.FunctionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainTap.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.13176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.86824F));
            this.tableLayoutPanel1.Controls.Add(this.InfoPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FunctionPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.70014F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.29986F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.adminName);
            this.InfoPanel.Controls.Add(this.materialLabel3);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(3, 726);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(185, 32);
            this.InfoPanel.TabIndex = 35;
            // 
            // adminName
            // 
            this.adminName.AutoSize = true;
            this.adminName.Depth = 0;
            this.adminName.Font = new System.Drawing.Font("Roboto", 11F);
            this.adminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminName.Location = new System.Drawing.Point(78, 6);
            this.adminName.MouseState = MaterialSkin.MouseState.HOVER;
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(42, 19);
            this.adminName.TabIndex = 22;
            this.adminName.Text = "박준수";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(19, 5);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "관리자 : ";
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionPanel.Controls.Add(this.iconButton2);
            this.FunctionPanel.Controls.Add(this.label_hint);
            this.FunctionPanel.Controls.Add(this.serchBtn);
            this.FunctionPanel.Controls.Add(this.canselBtn);
            this.FunctionPanel.Controls.Add(this.changeBtn);
            this.FunctionPanel.Controls.Add(this.confirmBtn);
            this.FunctionPanel.Location = new System.Drawing.Point(194, 3);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(987, 38);
            this.FunctionPanel.TabIndex = 32;
            // 
            // label_hint
            // 
            this.label_hint.AutoSize = true;
            this.label_hint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label_hint.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label_hint.ForeColor = System.Drawing.Color.White;
            this.label_hint.Location = new System.Drawing.Point(451, 62);
            this.label_hint.Name = "label_hint";
            this.label_hint.Size = new System.Drawing.Size(51, 14);
            this.label_hint.TabIndex = 1;
            this.label_hint.Text = "label1";
            // 
            // serchBtn
            // 
            this.serchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serchBtn.FlatAppearance.BorderSize = 0;
            this.serchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.serchBtn.IconColor = System.Drawing.Color.Black;
            this.serchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serchBtn.IconSize = 25;
            this.serchBtn.Location = new System.Drawing.Point(732, 7);
            this.serchBtn.Name = "serchBtn";
            this.serchBtn.Size = new System.Drawing.Size(25, 25);
            this.serchBtn.TabIndex = 55;
            this.serchBtn.UseVisualStyleBackColor = true;
            // 
            // canselBtn
            // 
            this.canselBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canselBtn.FlatAppearance.BorderSize = 0;
            this.canselBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canselBtn.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.canselBtn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.canselBtn.IconColor = System.Drawing.Color.Red;
            this.canselBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.canselBtn.IconSize = 25;
            this.canselBtn.Location = new System.Drawing.Point(880, 7);
            this.canselBtn.Name = "canselBtn";
            this.canselBtn.Size = new System.Drawing.Size(25, 25);
            this.canselBtn.TabIndex = 17;
            this.canselBtn.UseVisualStyleBackColor = true;
            // 
            // changeBtn
            // 
            this.changeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeBtn.FlatAppearance.BorderSize = 0;
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBtn.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.changeBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.changeBtn.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.changeBtn.IconColor = System.Drawing.Color.Black;
            this.changeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changeBtn.IconSize = 25;
            this.changeBtn.Location = new System.Drawing.Point(782, 7);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(25, 25);
            this.changeBtn.TabIndex = 20;
            this.changeBtn.Tag = "수정";
            this.changeBtn.UseVisualStyleBackColor = true;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.confirmBtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.confirmBtn.IconColor = System.Drawing.Color.Green;
            this.confirmBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confirmBtn.IconSize = 25;
            this.confirmBtn.Location = new System.Drawing.Point(830, 7);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(25, 25);
            this.confirmBtn.TabIndex = 18;
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.mainTap);
            this.panel1.Location = new System.Drawing.Point(194, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 673);
            this.panel1.TabIndex = 38;
            // 
            // mainTap
            // 
            this.mainTap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTap.Controls.Add(this.mainPage);
            this.mainTap.Location = new System.Drawing.Point(0, 0);
            this.mainTap.Name = "mainTap";
            this.mainTap.Padding = new System.Drawing.Point(35, 5);
            this.mainTap.SelectedIndex = 0;
            this.mainTap.Size = new System.Drawing.Size(988, 673);
            this.mainTap.TabIndex = 35;
            this.mainTap.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTap_DrawItem);
            this.mainTap.SelectedIndexChanged += new System.EventHandler(this.mainTap_SelectedIndexChanged);
            this.mainTap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainTap_MouseDown);
            this.mainTap.Resize += new System.EventHandler(this.mainTap_Resize);
            // 
            // mainPage
            // 
            this.mainPage.Location = new System.Drawing.Point(4, 26);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(980, 643);
            this.mainPage.TabIndex = 0;
            this.mainPage.Tag = "PJSsub001";
            this.mainPage.Text = "  ";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 673);
            this.panel2.TabIndex = 39;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(185, 673);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MainTree);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(177, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "메뉴";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkingNew
            // 
            this.checkingNew.AutoSize = true;
            this.checkingNew.Location = new System.Drawing.Point(13, 16);
            this.checkingNew.Name = "checkingNew";
            this.checkingNew.Size = new System.Drawing.Size(96, 16);
            this.checkingNew.TabIndex = 56;
            this.checkingNew.Text = "새창으로열기";
            this.checkingNew.UseVisualStyleBackColor = true;
            // 
            // MainTree
            // 
            this.MainTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTree.ForeColor = System.Drawing.Color.Black;
            this.MainTree.FullRowSelect = true;
            this.MainTree.LineColor = System.Drawing.Color.Gray;
            this.MainTree.Location = new System.Drawing.Point(3, 3);
            this.MainTree.Name = "MainTree";
            treeNode43.Name = "그룹코드관리";
            treeNode43.Tag = "PJSsub001";
            treeNode43.Text = "그룹코드관리";
            treeNode44.Name = "일반코드관리";
            treeNode44.Tag = "PJSsub002";
            treeNode44.Text = "일반코드관리";
            treeNode45.Name = "부서코드관리";
            treeNode45.Tag = "PJSsub003";
            treeNode45.Text = "부서코드관리";
            treeNode46.Name = "codeNode";
            treeNode46.Tag = "";
            treeNode46.Text = "코드관리";
            treeNode47.Name = "인사기본사항";
            treeNode47.Tag = "PJSsub004";
            treeNode47.Text = "인사기본사항";
            treeNode48.Name = "인사변동사항";
            treeNode48.Tag = "PJSsub005";
            treeNode48.Text = "인사변동사항";
            treeNode49.Name = "가족사항";
            treeNode49.Tag = "PJSsub006";
            treeNode49.Text = "가족사항";
            treeNode50.Name = "학력사항";
            treeNode50.Tag = "PJSsub007";
            treeNode50.Text = "학력사항";
            treeNode51.Name = "수상경력";
            treeNode51.Tag = "PJSsub008";
            treeNode51.Text = "수상경력";
            treeNode52.Name = "경력사항";
            treeNode52.Tag = "PJSsub009";
            treeNode52.Text = "경력사항";
            treeNode53.Name = "자격면허";
            treeNode53.Tag = "PJSsub010";
            treeNode53.Text = "자격면허";
            treeNode54.Name = "외국어";
            treeNode54.Tag = "PJSsub011";
            treeNode54.Text = "외국어";
            treeNode55.Name = "인사기록조회(통합)";
            treeNode55.Tag = "PJSsub012";
            treeNode55.Text = "인사기록조회(통합)";
            treeNode56.Name = "basicInsaNode";
            treeNode56.Tag = "";
            treeNode56.Text = "인사기록관리";
            this.MainTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode56});
            this.MainTree.Size = new System.Drawing.Size(171, 641);
            this.MainTree.TabIndex = 27;
            this.MainTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTree_NodeMouseClick);
            this.MainTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTree_NodeMouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(177, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "즐겨찾기";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(177, 647);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "검색";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkingNew);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 38);
            this.panel3.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.message);
            this.panel4.Controls.Add(this.materialLabel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(194, 726);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(987, 32);
            this.panel4.TabIndex = 41;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Black;
            this.message.Location = new System.Drawing.Point(123, 9);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(189, 17);
            this.message.TabIndex = 25;
            this.message.Text = "안녕하세요 로그인 되었습니다.";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Message : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ㅇㅇㅇToolStripMenuItem,
            this.즐겨찾기메뉴ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // ㅇㅇㅇToolStripMenuItem
            // 
            this.ㅇㅇㅇToolStripMenuItem.Name = "ㅇㅇㅇToolStripMenuItem";
            this.ㅇㅇㅇToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ㅇㅇㅇToolStripMenuItem.Text = "ㅇㅇㅇ";
            // 
            // 즐겨찾기메뉴ToolStripMenuItem
            // 
            this.즐겨찾기메뉴ToolStripMenuItem.Name = "즐겨찾기메뉴ToolStripMenuItem";
            this.즐겨찾기메뉴ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.즐겨찾기메뉴ToolStripMenuItem.Text = "즐겨찾기메뉴";
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton2.IconColor = System.Drawing.Color.Red;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(942, 8);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(25, 25);
            this.iconButton2.TabIndex = 57;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.FunctionPanel.ResumeLayout(false);
            this.FunctionPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.mainTap.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel FunctionPanel;
        private System.Windows.Forms.Label label_hint;
        private FontAwesome.Sharp.IconButton serchBtn;
        private FontAwesome.Sharp.IconButton canselBtn;
        private FontAwesome.Sharp.IconButton changeBtn;
        private FontAwesome.Sharp.IconButton confirmBtn;
        private System.Windows.Forms.Panel InfoPanel;
        private MaterialSkin.Controls.MaterialLabel adminName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl mainTap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView MainTree;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label message;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.CheckBox checkingNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ㅇㅇㅇToolStripMenuItem;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}