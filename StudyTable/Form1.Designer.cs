namespace StudyTable
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.game2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.apply = new System.Windows.Forms.Button();
            this.Colorlabel = new System.Windows.Forms.Label();
            this.Fontlabel = new System.Windows.Forms.Label();
            this.Themalabel = new System.Windows.Forms.Label();
            this.FontChange = new System.Windows.Forms.Button();
            this.BackgroundChange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.naver = new System.Windows.Forms.Button();
            this.google = new System.Windows.Forms.Button();
            this.waffle = new System.Windows.Forms.Button();
            this.wku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.calender = new System.Windows.Forms.Button();
            this.calcul = new System.Windows.Forms.Button();
            this.game1 = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.memo = new System.Windows.Forms.Button();
            this.watch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BackColorlabel = new System.Windows.Forms.Label();
            this.ColorBt = new System.Windows.Forms.Button();
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
            this.groupBox2.Controls.Add(this.ColorBt);
            this.groupBox2.Controls.Add(this.apply);
            this.groupBox2.Controls.Add(this.Colorlabel);
            this.groupBox2.Controls.Add(this.Fontlabel);
            this.groupBox2.Controls.Add(this.Themalabel);
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
            // apply
            // 
            this.apply.FlatAppearance.BorderSize = 0;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Location = new System.Drawing.Point(214, 111);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(0, 0);
            this.apply.TabIndex = 12;
            this.apply.Text = "▣";
            this.apply.UseVisualStyleBackColor = true;
            // 
            // Colorlabel
            // 
            this.Colorlabel.AutoSize = true;
            this.Colorlabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Colorlabel.Location = new System.Drawing.Point(52, 80);
            this.Colorlabel.Name = "Colorlabel";
            this.Colorlabel.Size = new System.Drawing.Size(38, 16);
            this.Colorlabel.TabIndex = 9;
            this.Colorlabel.Text = "BC :";
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
            // Themalabel
            // 
            this.Themalabel.AutoSize = true;
            this.Themalabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Themalabel.Location = new System.Drawing.Point(34, 114);
            this.Themalabel.Name = "Themalabel";
            this.Themalabel.Size = new System.Drawing.Size(56, 16);
            this.Themalabel.TabIndex = 6;
            this.Themalabel.Text = "Color :";
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
            // calender
            // 
            this.calender.FlatAppearance.BorderSize = 0;
            this.calender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calender.Image = ((System.Drawing.Image)(resources.GetObject("calender.Image")));
            this.calender.Location = new System.Drawing.Point(103, 253);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(120, 120);
            this.calender.TabIndex = 48;
            this.calender.UseVisualStyleBackColor = true;
            // 
            // calcul
            // 
            this.calcul.FlatAppearance.BorderSize = 0;
            this.calcul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcul.Image = ((System.Drawing.Image)(resources.GetObject("calcul.Image")));
            this.calcul.Location = new System.Drawing.Point(263, 253);
            this.calcul.Name = "calcul";
            this.calcul.Size = new System.Drawing.Size(120, 120);
            this.calcul.TabIndex = 47;
            this.calcul.UseVisualStyleBackColor = true;
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
            // logout
            // 
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logout.Location = new System.Drawing.Point(841, 50);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(99, 29);
            this.logout.TabIndex = 45;
            this.logout.Text = "로그아웃";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // memo
            // 
            this.memo.FlatAppearance.BorderSize = 0;
            this.memo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memo.Image = ((System.Drawing.Image)(resources.GetObject("memo.Image")));
            this.memo.Location = new System.Drawing.Point(193, 108);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(120, 120);
            this.memo.TabIndex = 44;
            this.memo.UseVisualStyleBackColor = true;
            // 
            // watch
            // 
            this.watch.FlatAppearance.BorderSize = 0;
            this.watch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watch.Image = ((System.Drawing.Image)(resources.GetObject("watch.Image")));
            this.watch.Location = new System.Drawing.Point(33, 108);
            this.watch.Name = "watch";
            this.watch.Size = new System.Drawing.Size(120, 120);
            this.watch.TabIndex = 43;
            this.watch.UseVisualStyleBackColor = true;
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
            // ColorBt
            // 
            this.ColorBt.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.ColorBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorBt.Location = new System.Drawing.Point(114, 114);
            this.ColorBt.Name = "ColorBt";
            this.ColorBt.Size = new System.Drawing.Size(130, 30);
            this.ColorBt.TabIndex = 13;
            this.ColorBt.Text = "색 변경";
            this.ColorBt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.game2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.calcul);
            this.Controls.Add(this.game1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.watch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackColorlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button game2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label Colorlabel;
        private System.Windows.Forms.Label Fontlabel;
        private System.Windows.Forms.Label Themalabel;
        private System.Windows.Forms.Button FontChange;
        private System.Windows.Forms.Button BackgroundChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button naver;
        private System.Windows.Forms.Button google;
        private System.Windows.Forms.Button waffle;
        private System.Windows.Forms.Button wku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calender;
        private System.Windows.Forms.Button calcul;
        private System.Windows.Forms.Button game1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button memo;
        private System.Windows.Forms.Button watch;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BackColorlabel;
        private System.Windows.Forms.Button ColorBt;
    }
}

