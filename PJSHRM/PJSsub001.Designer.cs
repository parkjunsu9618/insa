namespace PJSHRM
{
    partial class PJSsub001
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grid_cdg_grpcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_cdg_grpnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_cdg_digit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_cdg_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_cdg_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_cdg_kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info1 = new System.Windows.Forms.Panel();
            this.cdg_length = new System.Windows.Forms.NumericUpDown();
            this.cdg_digit = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ifam_rel = new System.Windows.Forms.ComboBox();
            this.ifam_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cdg_use = new System.Windows.Forms.ComboBox();
            this.cdg_kind = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.info1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_digit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.info1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.881579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.11842F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(988, 673);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 53);
            this.panel1.TabIndex = 0;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(502, 12);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 21);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "사용여부";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "그룹코드명";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 608);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 27;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_cdg_grpcd,
            this.grid_cdg_grpnm,
            this.grid_cdg_digit,
            this.grid_cdg_length,
            this.grid_cdg_use,
            this.grid_cdg_kind});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(666, 580);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Tag = "basGrid";
            // 
            // grid_cdg_grpcd
            // 
            this.grid_cdg_grpcd.HeaderText = "그룹코드";
            this.grid_cdg_grpcd.Name = "grid_cdg_grpcd";
            this.grid_cdg_grpcd.ReadOnly = true;
            // 
            // grid_cdg_grpnm
            // 
            this.grid_cdg_grpnm.HeaderText = "그룹코드명";
            this.grid_cdg_grpnm.Name = "grid_cdg_grpnm";
            this.grid_cdg_grpnm.ReadOnly = true;
            // 
            // grid_cdg_digit
            // 
            this.grid_cdg_digit.HeaderText = "코드 자릿수";
            this.grid_cdg_digit.Name = "grid_cdg_digit";
            this.grid_cdg_digit.ReadOnly = true;
            // 
            // grid_cdg_length
            // 
            this.grid_cdg_length.HeaderText = "코드명 자릿수";
            this.grid_cdg_length.Name = "grid_cdg_length";
            this.grid_cdg_length.ReadOnly = true;
            // 
            // grid_cdg_use
            // 
            this.grid_cdg_use.HeaderText = "사용여부";
            this.grid_cdg_use.Name = "grid_cdg_use";
            this.grid_cdg_use.ReadOnly = true;
            // 
            // grid_cdg_kind
            // 
            this.grid_cdg_kind.HeaderText = "분류";
            this.grid_cdg_kind.Name = "grid_cdg_kind";
            this.grid_cdg_kind.ReadOnly = true;
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.White;
            this.info1.Controls.Add(this.cdg_length);
            this.info1.Controls.Add(this.cdg_digit);
            this.info1.Controls.Add(this.label11);
            this.info1.Controls.Add(this.label10);
            this.info1.Controls.Add(this.label18);
            this.info1.Controls.Add(this.label17);
            this.info1.Controls.Add(this.cdg_kind);
            this.info1.Controls.Add(this.cdg_use);
            this.info1.Controls.Add(this.ifam_rel);
            this.info1.Controls.Add(this.ifam_name);
            this.info1.Controls.Add(this.label16);
            this.info1.Controls.Add(this.label15);
            this.info1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info1.Location = new System.Drawing.Point(675, 62);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(310, 608);
            this.info1.TabIndex = 3;
            // 
            // cdg_length
            // 
            this.cdg_length.Location = new System.Drawing.Point(112, 93);
            this.cdg_length.Name = "cdg_length";
            this.cdg_length.Size = new System.Drawing.Size(171, 21);
            this.cdg_length.TabIndex = 264;
            this.cdg_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cdg_digit
            // 
            this.cdg_digit.Location = new System.Drawing.Point(112, 68);
            this.cdg_digit.Name = "cdg_digit";
            this.cdg_digit.Size = new System.Drawing.Size(171, 21);
            this.cdg_digit.TabIndex = 264;
            this.cdg_digit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 256;
            this.label11.Text = "분류";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 255;
            this.label10.Text = "사용여부";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 12);
            this.label18.TabIndex = 251;
            this.label18.Text = "코드명 자릿수";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 12);
            this.label17.TabIndex = 252;
            this.label17.Text = "단위코드자릿수";
            // 
            // ifam_rel
            // 
            this.ifam_rel.FormattingEnabled = true;
            this.ifam_rel.Location = new System.Drawing.Point(112, 17);
            this.ifam_rel.Name = "ifam_rel";
            this.ifam_rel.Size = new System.Drawing.Size(171, 20);
            this.ifam_rel.TabIndex = 250;
            // 
            // ifam_name
            // 
            this.ifam_name.Location = new System.Drawing.Point(112, 43);
            this.ifam_name.Name = "ifam_name";
            this.ifam_name.Size = new System.Drawing.Size(171, 21);
            this.ifam_name.TabIndex = 246;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 244;
            this.label16.Text = "그룹코드명";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 245;
            this.label15.Text = "그룹코드";
            // 
            // cdg_use
            // 
            this.cdg_use.FormattingEnabled = true;
            this.cdg_use.Location = new System.Drawing.Point(112, 118);
            this.cdg_use.Name = "cdg_use";
            this.cdg_use.Size = new System.Drawing.Size(171, 20);
            this.cdg_use.TabIndex = 250;
            // 
            // cdg_kind
            // 
            this.cdg_kind.FormattingEnabled = true;
            this.cdg_kind.Location = new System.Drawing.Point(112, 142);
            this.cdg_kind.Name = "cdg_kind";
            this.cdg_kind.Size = new System.Drawing.Size(171, 20);
            this.cdg_kind.TabIndex = 250;
            // 
            // PJSsub001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PJSsub001";
            this.Text = "그룹사항";
            this.Load += new System.EventHandler(this.PJSsub001_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.info1.ResumeLayout(false);
            this.info1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_digit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel info1;
        private System.Windows.Forms.NumericUpDown cdg_length;
        private System.Windows.Forms.NumericUpDown cdg_digit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox ifam_rel;
        private System.Windows.Forms.TextBox ifam_name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_cdg_grpcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_cdg_grpnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_cdg_digit;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_cdg_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_cdg_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_cdg_kind;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cdg_kind;
        private System.Windows.Forms.ComboBox cdg_use;
    }
}