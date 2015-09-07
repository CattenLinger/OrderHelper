namespace DinnerHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c_Decorative = new System.Windows.Forms.CheckBox();
            this.t_cakeWords = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label_budget = new System.Windows.Forms.Label();
            this.c_Wine = new System.Windows.Forms.CheckBox();
            this.c_VIP = new System.Windows.Forms.CheckBox();
            this.num_people = new System.Windows.Forms.NumericUpDown();
            this.dtp_orderDate = new System.Windows.Forms.DateTimePicker();
            this.t_phoneNumber = new System.Windows.Forms.TextBox();
            this.t_ordertitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_people)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 392);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "自助用餐";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "宴会用餐";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(334, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 99);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(426, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "生日用餐";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c_Decorative);
            this.panel1.Controls.Add(this.t_cakeWords);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_budget);
            this.panel1.Controls.Add(this.c_Wine);
            this.panel1.Controls.Add(this.c_VIP);
            this.panel1.Controls.Add(this.num_people);
            this.panel1.Controls.Add(this.dtp_orderDate);
            this.panel1.Controls.Add(this.t_phoneNumber);
            this.panel1.Controls.Add(this.t_ordertitle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 354);
            this.panel1.TabIndex = 0;
            // 
            // c_Decorative
            // 
            this.c_Decorative.AutoSize = true;
            this.c_Decorative.Location = new System.Drawing.Point(52, 167);
            this.c_Decorative.Name = "c_Decorative";
            this.c_Decorative.Size = new System.Drawing.Size(106, 22);
            this.c_Decorative.TabIndex = 34;
            this.c_Decorative.Text = "华丽装饰";
            this.c_Decorative.UseVisualStyleBackColor = true;
            this.c_Decorative.Visible = false;
            this.c_Decorative.Click += new System.EventHandler(this.controlsLeave);
            this.c_Decorative.Leave += new System.EventHandler(this.controlsLeave);
            // 
            // t_cakeWords
            // 
            this.t_cakeWords.Location = new System.Drawing.Point(134, 196);
            this.t_cakeWords.Name = "t_cakeWords";
            this.t_cakeWords.Size = new System.Drawing.Size(234, 28);
            this.t_cakeWords.TabIndex = 33;
            this.t_cakeWords.Visible = false;
            this.t_cakeWords.KeyUp += new System.Windows.Forms.KeyEventHandler(this.t_cakeWords_KeyUp);
            this.t_cakeWords.Leave += new System.EventHandler(this.controlsLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "蛋糕刻字";
            this.label9.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(255, 294);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 38);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Enabled = false;
            this.btn_submit.ForeColor = System.Drawing.Color.Black;
            this.btn_submit.Location = new System.Drawing.Point(92, 294);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(113, 38);
            this.btn_submit.TabIndex = 30;
            this.btn_submit.Text = "预定";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(49, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "费用预算";
            // 
            // label_budget
            // 
            this.label_budget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_budget.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_budget.ForeColor = System.Drawing.Color.Black;
            this.label_budget.Location = new System.Drawing.Point(135, 234);
            this.label_budget.Name = "label_budget";
            this.label_budget.Size = new System.Drawing.Size(233, 44);
            this.label_budget.TabIndex = 28;
            this.label_budget.Text = "￥";
            this.label_budget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_budget.Leave += new System.EventHandler(this.controlsLeave);
            // 
            // c_Wine
            // 
            this.c_Wine.AutoSize = true;
            this.c_Wine.ForeColor = System.Drawing.Color.Black;
            this.c_Wine.Location = new System.Drawing.Point(298, 167);
            this.c_Wine.Name = "c_Wine";
            this.c_Wine.Size = new System.Drawing.Size(70, 22);
            this.c_Wine.TabIndex = 27;
            this.c_Wine.Text = "酒水";
            this.c_Wine.UseVisualStyleBackColor = true;
            this.c_Wine.Click += new System.EventHandler(this.controlsLeave);
            this.c_Wine.Leave += new System.EventHandler(this.controlsLeave);
            // 
            // c_VIP
            // 
            this.c_VIP.AutoSize = true;
            this.c_VIP.ForeColor = System.Drawing.Color.Black;
            this.c_VIP.Location = new System.Drawing.Point(190, 167);
            this.c_VIP.Name = "c_VIP";
            this.c_VIP.Size = new System.Drawing.Size(70, 22);
            this.c_VIP.TabIndex = 26;
            this.c_VIP.Text = "会员";
            this.c_VIP.UseVisualStyleBackColor = true;
            this.c_VIP.Click += new System.EventHandler(this.controlsLeave);
            this.c_VIP.Leave += new System.EventHandler(this.controlsLeave);
            // 
            // num_people
            // 
            this.num_people.Location = new System.Drawing.Point(134, 88);
            this.num_people.Name = "num_people";
            this.num_people.Size = new System.Drawing.Size(234, 28);
            this.num_people.TabIndex = 25;
            this.num_people.ValueChanged += new System.EventHandler(this.controlsLeave);
            this.num_people.Leave += new System.EventHandler(this.controlsLeave);
            // 
            // dtp_orderDate
            // 
            this.dtp_orderDate.Location = new System.Drawing.Point(134, 122);
            this.dtp_orderDate.Name = "dtp_orderDate";
            this.dtp_orderDate.Size = new System.Drawing.Size(234, 28);
            this.dtp_orderDate.TabIndex = 24;
            this.dtp_orderDate.Leave += new System.EventHandler(this.controlsLeave);
            // 
            // t_phoneNumber
            // 
            this.t_phoneNumber.Location = new System.Drawing.Point(134, 54);
            this.t_phoneNumber.Name = "t_phoneNumber";
            this.t_phoneNumber.Size = new System.Drawing.Size(234, 28);
            this.t_phoneNumber.TabIndex = 23;
            this.t_phoneNumber.Leave += new System.EventHandler(this.controlsLeave);
            // 
            // t_ordertitle
            // 
            this.t_ordertitle.Location = new System.Drawing.Point(134, 20);
            this.t_ordertitle.Name = "t_ordertitle";
            this.t_ordertitle.Size = new System.Drawing.Size(234, 28);
            this.t_ordertitle.TabIndex = 22;
            this.t_ordertitle.Leave += new System.EventHandler(this.controlsLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(49, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "用餐日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(49, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "用餐人数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "联系电话";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "客户姓名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(434, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "点餐小精灵";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_people)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox c_Decorative;
        private System.Windows.Forms.TextBox t_cakeWords;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_budget;
        private System.Windows.Forms.CheckBox c_Wine;
        private System.Windows.Forms.CheckBox c_VIP;
        private System.Windows.Forms.NumericUpDown num_people;
        private System.Windows.Forms.DateTimePicker dtp_orderDate;
        private System.Windows.Forms.TextBox t_phoneNumber;
        private System.Windows.Forms.TextBox t_ordertitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

