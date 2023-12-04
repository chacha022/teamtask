namespace StudyTable
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.game2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Themalabel = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.Colorlabel = new System.Windows.Forms.Label();
            this.Fontlabel = new System.Windows.Forms.Label();
            this.FontChange = new System.Windows.Forms.Button();
            this.BackgroundChange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.naver = new System.Windows.Forms.Button();
            this.google = new System.Windows.Forms.Button();
            this.waffle = new System.Windows.Forms.Button();
            this.wku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.Button();
            this.imageListCalendar = new System.Windows.Forms.ImageList(this.components);
            this.calcul = new System.Windows.Forms.Button();
            this.imageListCalculator = new System.Windows.Forms.ImageList(this.components);
            this.game1 = new System.Windows.Forms.Button();
            this.memo = new System.Windows.Forms.Button();
            this.imageListMemo = new System.Windows.Forms.ImageList(this.components);
            this.watch = new System.Windows.Forms.Button();
            this.imageListWatch = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.BackColorlabel = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // game2
            // 
            this.game2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.game2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game2.Location = new System.Drawing.Point(824, 132);
            this.game2.Name = "game2";
            this.game2.Size = new System.Drawing.Size(131, 234);
            this.game2.TabIndex = 53;
            this.game2.Text = "게임";
            this.game2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Themalabel);
            this.groupBox2.Controls.Add(this.apply);
            this.groupBox2.Controls.Add(this.domainUpDown1);
            this.groupBox2.Controls.Add(this.Colorlabel);
            this.groupBox2.Controls.Add(this.Fontlabel);
            this.groupBox2.Controls.Add(this.FontChange);
            this.groupBox2.Controls.Add(this.BackgroundChange);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(655, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 160);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "폼 변경";
            // 
            // Themalabel
            // 
            this.Themalabel.AutoSize = true;
            this.Themalabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Themalabel.Location = new System.Drawing.Point(24, 119);
            this.Themalabel.Name = "Themalabel";
            this.Themalabel.Size = new System.Drawing.Size(66, 16);
            this.Themalabel.TabIndex = 15;
            this.Themalabel.Text = "Thema :";
            // 
            // apply
            // 
            this.apply.FlatAppearance.BorderSize = 0;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Location = new System.Drawing.Point(214, 112);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(30, 30);
            this.apply.TabIndex = 14;
            this.apply.Text = "▣";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("RED");
            this.domainUpDown1.Items.Add("BLUE");
            this.domainUpDown1.Items.Add("YELLOW");
            this.domainUpDown1.Items.Add("ORIGINAL");
            this.domainUpDown1.Location = new System.Drawing.Point(114, 114);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(94, 26);
            this.domainUpDown1.TabIndex = 13;
            this.domainUpDown1.Text = "테마 변경";
            this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Colorlabel
            // 
            this.Colorlabel.AutoSize = true;
            this.Colorlabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Colorlabel.Location = new System.Drawing.Point(34, 80);
            this.Colorlabel.Name = "Colorlabel";
            this.Colorlabel.Size = new System.Drawing.Size(56, 16);
            this.Colorlabel.TabIndex = 9;
            this.Colorlabel.Text = "Color :";
            // 
            // Fontlabel
            // 
            this.Fontlabel.AutoSize = true;
            this.Fontlabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Fontlabel.Location = new System.Drawing.Point(40, 40);
            this.Fontlabel.Name = "Fontlabel";
            this.Fontlabel.Size = new System.Drawing.Size(50, 16);
            this.Fontlabel.TabIndex = 5;
            this.Fontlabel.Text = "Font :";
            // 
            // FontChange
            // 
            this.FontChange.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.FontChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontChange.Location = new System.Drawing.Point(114, 33);
            this.FontChange.Name = "FontChange";
            this.FontChange.Size = new System.Drawing.Size(130, 30);
            this.FontChange.TabIndex = 7;
            this.FontChange.Text = "폰트변경";
            this.FontChange.UseVisualStyleBackColor = true;
            this.FontChange.Click += new System.EventHandler(this.FontChange_Click);
            // 
            // BackgroundChange
            // 
            this.BackgroundChange.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BackgroundChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundChange.Location = new System.Drawing.Point(114, 73);
            this.BackgroundChange.Name = "BackgroundChange";
            this.BackgroundChange.Size = new System.Drawing.Size(130, 30);
            this.BackgroundChange.TabIndex = 8;
            this.BackgroundChange.Text = "배경색 변경";
            this.BackgroundChange.UseVisualStyleBackColor = true;
            this.BackgroundChange.Click += new System.EventHandler(this.BackgroundChange_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.naver);
            this.groupBox1.Controls.Add(this.google);
            this.groupBox1.Controls.Add(this.waffle);
            this.groupBox1.Controls.Add(this.wku);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(30, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 160);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사이트";
            // 
            // naver
            // 
            this.naver.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.naver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naver.Image = ((System.Drawing.Image)(resources.GetObject("naver.Image")));
            this.naver.Location = new System.Drawing.Point(30, 30);
            this.naver.Name = "naver";
            this.naver.Size = new System.Drawing.Size(100, 100);
            this.naver.TabIndex = 9;
            this.naver.UseVisualStyleBackColor = true;
            this.naver.Click += new System.EventHandler(this.naver_Click);
            // 
            // google
            // 
            this.google.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.google.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.google.Image = ((System.Drawing.Image)(resources.GetObject("google.Image")));
            this.google.Location = new System.Drawing.Point(170, 30);
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(100, 100);
            this.google.TabIndex = 10;
            this.google.UseVisualStyleBackColor = true;
            this.google.Click += new System.EventHandler(this.google_Click);
            // 
            // waffle
            // 
            this.waffle.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.waffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waffle.Image = ((System.Drawing.Image)(resources.GetObject("waffle.Image")));
            this.waffle.Location = new System.Drawing.Point(310, 30);
            this.waffle.Name = "waffle";
            this.waffle.Size = new System.Drawing.Size(100, 100);
            this.waffle.TabIndex = 11;
            this.waffle.UseVisualStyleBackColor = true;
            this.waffle.Click += new System.EventHandler(this.waffle_Click);
            // 
            // wku
            // 
            this.wku.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.wku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wku.Image = ((System.Drawing.Image)(resources.GetObject("wku.Image")));
            this.wku.Location = new System.Drawing.Point(450, 30);
            this.wku.Name = "wku";
            this.wku.Size = new System.Drawing.Size(100, 100);
            this.wku.TabIndex = 12;
            this.wku.UseVisualStyleBackColor = true;
            this.wku.Click += new System.EventHandler(this.wku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 52);
            this.label1.TabIndex = 49;
            this.label1.Text = "Study Desk";
            // 
            // calendar
            // 
            this.calendar.FlatAppearance.BorderSize = 0;
            this.calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendar.ImageList = this.imageListCalendar;
            this.calendar.Location = new System.Drawing.Point(103, 253);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(120, 120);
            this.calendar.TabIndex = 48;
            this.calendar.UseVisualStyleBackColor = true;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // imageListCalendar
            // 
            this.imageListCalendar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCalendar.ImageStream")));
            this.imageListCalendar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCalendar.Images.SetKeyName(0, "O_calend.png");
            this.imageListCalendar.Images.SetKeyName(1, "R_calend.png");
            this.imageListCalendar.Images.SetKeyName(2, "B_calend.png");
            this.imageListCalendar.Images.SetKeyName(3, "Y_calend.png");
            // 
            // calcul
            // 
            this.calcul.FlatAppearance.BorderSize = 0;
            this.calcul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcul.ImageList = this.imageListCalculator;
            this.calcul.Location = new System.Drawing.Point(263, 253);
            this.calcul.Name = "calcul";
            this.calcul.Size = new System.Drawing.Size(120, 120);
            this.calcul.TabIndex = 47;
            this.calcul.UseVisualStyleBackColor = true;
            this.calcul.Click += new System.EventHandler(this.calcul_Click);
            // 
            // imageListCalculator
            // 
            this.imageListCalculator.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCalculator.ImageStream")));
            this.imageListCalculator.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCalculator.Images.SetKeyName(0, "O_calcul.png");
            this.imageListCalculator.Images.SetKeyName(1, "R_calcul.png");
            this.imageListCalculator.Images.SetKeyName(2, "B_calcul.png");
            this.imageListCalculator.Images.SetKeyName(3, "Y_calcul.png");
            // 
            // game1
            // 
            this.game1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.game1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game1.Location = new System.Drawing.Point(655, 132);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(131, 234);
            this.game1.TabIndex = 46;
            this.game1.Text = "게임";
            this.game1.UseVisualStyleBackColor = true;
            // 
            // memo
            // 
            this.memo.FlatAppearance.BorderSize = 0;
            this.memo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memo.ImageList = this.imageListMemo;
            this.memo.Location = new System.Drawing.Point(193, 108);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(120, 120);
            this.memo.TabIndex = 44;
            this.memo.UseVisualStyleBackColor = true;
            // 
            // imageListMemo
            // 
            this.imageListMemo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMemo.ImageStream")));
            this.imageListMemo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMemo.Images.SetKeyName(0, "O_memo.png");
            this.imageListMemo.Images.SetKeyName(1, "R_memo.png");
            this.imageListMemo.Images.SetKeyName(2, "B_memo.png");
            this.imageListMemo.Images.SetKeyName(3, "Y_memo.png");
            // 
            // watch
            // 
            this.watch.FlatAppearance.BorderSize = 0;
            this.watch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watch.ImageList = this.imageListWatch;
            this.watch.Location = new System.Drawing.Point(33, 108);
            this.watch.Name = "watch";
            this.watch.Size = new System.Drawing.Size(120, 120);
            this.watch.TabIndex = 43;
            this.watch.UseVisualStyleBackColor = true;
            this.watch.Click += new System.EventHandler(this.watch_Click);
            // 
            // imageListWatch
            // 
            this.imageListWatch.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListWatch.ImageStream")));
            this.imageListWatch.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListWatch.Images.SetKeyName(0, "O_watch.png");
            this.imageListWatch.Images.SetKeyName(1, "R_watch.png");
            this.imageListWatch.Images.SetKeyName(2, "B_watch.png");
            this.imageListWatch.Images.SetKeyName(3, "Y_watch.png");
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(405, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(100);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(200, 200);
            this.label3.TabIndex = 52;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BackColorlabel
            // 
            this.BackColorlabel.Location = new System.Drawing.Point(-8, -20);
            this.BackColorlabel.Name = "BackColorlabel";
            this.BackColorlabel.Size = new System.Drawing.Size(1000, 600);
            this.BackColorlabel.TabIndex = 55;
            this.BackColorlabel.Text = "\r\n\r\n\r\n\r\n\r\n";
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logout.Location = new System.Drawing.Point(785, 37);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(99, 29);
            this.logout.TabIndex = 45;
            this.logout.Text = "로그아웃";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(905, 26);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(50, 50);
            this.close.TabIndex = 56;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.close);
            this.Controls.Add(this.game2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.calcul);
            this.Controls.Add(this.game1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.watch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackColorlabel);
            this.Name = "main";
            this.Text = "메인화면";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button game2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Colorlabel;
        private System.Windows.Forms.Label Fontlabel;
        private System.Windows.Forms.Button FontChange;
        private System.Windows.Forms.Button BackgroundChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button naver;
        private System.Windows.Forms.Button google;
        private System.Windows.Forms.Button waffle;
        private System.Windows.Forms.Button wku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calendar;
        private System.Windows.Forms.Button calcul;
        private System.Windows.Forms.Button game1;
        private System.Windows.Forms.Button memo;
        private System.Windows.Forms.Button watch;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BackColorlabel;
        private System.Windows.Forms.Label Themalabel;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ImageList imageListWatch;
        private System.Windows.Forms.ImageList imageListCalendar;
        private System.Windows.Forms.ImageList imageListMemo;
        private System.Windows.Forms.ImageList imageListCalculator;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}

