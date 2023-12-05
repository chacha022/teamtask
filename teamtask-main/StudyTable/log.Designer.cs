namespace StudyTable
{
    partial class log
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
            this.PWlabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.PWTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PWlabel
            // 
            this.PWlabel.AutoSize = true;
            this.PWlabel.Location = new System.Drawing.Point(19, 57);
            this.PWlabel.Name = "PWlabel";
            this.PWlabel.Size = new System.Drawing.Size(23, 12);
            this.PWlabel.TabIndex = 14;
            this.PWlabel.Text = "PW";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(19, 13);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(16, 12);
            this.IDlabel.TabIndex = 13;
            this.IDlabel.Text = "ID";
            // 
            // PWTextBox
            // 
            this.PWTextBox.Location = new System.Drawing.Point(21, 72);
            this.PWTextBox.Name = "PWTextBox";
            this.PWTextBox.Size = new System.Drawing.Size(244, 21);
            this.PWTextBox.TabIndex = 12;
            this.PWTextBox.Text = "비밀번호를 입력해주세요.";
            this.PWTextBox.Click += new System.EventHandler(this.PWTextBox_Click);
            this.PWTextBox.Leave += new System.EventHandler(this.PWTextBox_Leave);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(21, 29);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(244, 21);
            this.IDTextBox.TabIndex = 11;
            this.IDTextBox.Text = "아이디를 입력해주세요.";
            this.IDTextBox.Click += new System.EventHandler(this.IDTextBox_Click);
            this.IDTextBox.Leave += new System.EventHandler(this.IDTextBox_Leave);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(190, 105);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 10;
            this.login.Text = "로그인";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.PWlabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.PWTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.login);
            this.Name = "log";
            this.Text = "로그인화면";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PWlabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox PWTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button login;
    }
}