namespace 계산기
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Zero = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Two = new System.Windows.Forms.Button();
            this.bt_One = new System.Windows.Forms.Button();
            this.bt_Nine = new System.Windows.Forms.Button();
            this.bt_Eight = new System.Windows.Forms.Button();
            this.bt_Seven = new System.Windows.Forms.Button();
            this.bt_Backspace = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Remainder = new System.Windows.Forms.Button();
            this.bt_Four = new System.Windows.Forms.Button();
            this.bt_Five = new System.Windows.Forms.Button();
            this.bt_Six = new System.Windows.Forms.Button();
            this.bt_Three = new System.Windows.Forms.Button();
            this.bt_Divide = new System.Windows.Forms.Button();
            this.bt_Multiply = new System.Windows.Forms.Button();
            this.bt_Subtract = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_MM = new System.Windows.Forms.Button();
            this.bt_MP = new System.Windows.Forms.Button();
            this.bt_MS = new System.Windows.Forms.Button();
            this.bt_MR = new System.Windows.Forms.Button();
            this.bt_MC = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Trans16 = new System.Windows.Forms.Label();
            this.Trans10 = new System.Windows.Forms.Label();
            this.Trans8 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text16 = new System.Windows.Forms.Label();
            this.Text10 = new System.Windows.Forms.Label();
            this.Text8 = new System.Windows.Forms.Label();
            this.Trans2 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Label();
            this.bt_Result = new System.Windows.Forms.Button();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.bt_Zero, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.bt_Result, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 518);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(382, 86);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // bt_Zero
            // 
            this.bt_Zero.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Zero.Location = new System.Drawing.Point(3, 3);
            this.bt_Zero.Name = "bt_Zero";
            this.bt_Zero.Size = new System.Drawing.Size(185, 80);
            this.bt_Zero.TabIndex = 0;
            this.bt_Zero.Text = "0";
            this.bt_Zero.UseVisualStyleBackColor = true;
            this.bt_Zero.Click += new System.EventHandler(this.bt_Zero_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Add.Location = new System.Drawing.Point(288, 273);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(89, 80);
            this.bt_Add.TabIndex = 3;
            this.bt_Add.Text = "+";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.bt_Two, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.bt_One, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.bt_Nine, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.bt_Add, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.bt_Eight, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.bt_Seven, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.bt_Remainder, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_Four, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.bt_Five, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.bt_Six, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.bt_Three, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.bt_Clear, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_Backspace, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_Divide, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.bt_Multiply, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.bt_Subtract, 3, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 157);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 361);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // bt_Two
            // 
            this.bt_Two.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Two.Location = new System.Drawing.Point(98, 273);
            this.bt_Two.Name = "bt_Two";
            this.bt_Two.Size = new System.Drawing.Size(89, 84);
            this.bt_Two.TabIndex = 12;
            this.bt_Two.Text = "2";
            this.bt_Two.UseVisualStyleBackColor = true;
            this.bt_Two.Click += new System.EventHandler(this.bt_Two_Click);
            // 
            // bt_One
            // 
            this.bt_One.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_One.Location = new System.Drawing.Point(3, 273);
            this.bt_One.Name = "bt_One";
            this.bt_One.Size = new System.Drawing.Size(89, 84);
            this.bt_One.TabIndex = 10;
            this.bt_One.Text = "1";
            this.bt_One.UseVisualStyleBackColor = true;
            this.bt_One.Click += new System.EventHandler(this.bt_One_Click);
            // 
            // bt_Nine
            // 
            this.bt_Nine.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Nine.Location = new System.Drawing.Point(193, 93);
            this.bt_Nine.Name = "bt_Nine";
            this.bt_Nine.Size = new System.Drawing.Size(89, 84);
            this.bt_Nine.TabIndex = 6;
            this.bt_Nine.Text = "9";
            this.bt_Nine.UseVisualStyleBackColor = true;
            this.bt_Nine.Click += new System.EventHandler(this.bt_Nine_Click);
            // 
            // bt_Eight
            // 
            this.bt_Eight.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Eight.Location = new System.Drawing.Point(98, 93);
            this.bt_Eight.Name = "bt_Eight";
            this.bt_Eight.Size = new System.Drawing.Size(89, 84);
            this.bt_Eight.TabIndex = 5;
            this.bt_Eight.Text = "8";
            this.bt_Eight.UseVisualStyleBackColor = true;
            this.bt_Eight.Click += new System.EventHandler(this.bt_Eight_Click);
            // 
            // bt_Seven
            // 
            this.bt_Seven.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Seven.Location = new System.Drawing.Point(3, 93);
            this.bt_Seven.Name = "bt_Seven";
            this.bt_Seven.Size = new System.Drawing.Size(89, 84);
            this.bt_Seven.TabIndex = 4;
            this.bt_Seven.Text = "7";
            this.bt_Seven.UseVisualStyleBackColor = true;
            this.bt_Seven.Click += new System.EventHandler(this.bt_Seven_Click);
            // 
            // bt_Backspace
            // 
            this.bt_Backspace.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Backspace.Location = new System.Drawing.Point(193, 3);
            this.bt_Backspace.Name = "bt_Backspace";
            this.bt_Backspace.Size = new System.Drawing.Size(89, 84);
            this.bt_Backspace.TabIndex = 3;
            this.bt_Backspace.Text = "←";
            this.bt_Backspace.UseVisualStyleBackColor = true;
            this.bt_Backspace.Click += new System.EventHandler(this.bt_Backspace_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Clear.Location = new System.Drawing.Point(98, 3);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(89, 84);
            this.bt_Clear.TabIndex = 2;
            this.bt_Clear.Text = "C";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Remainder
            // 
            this.bt_Remainder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Remainder.Location = new System.Drawing.Point(3, 3);
            this.bt_Remainder.Name = "bt_Remainder";
            this.bt_Remainder.Size = new System.Drawing.Size(89, 84);
            this.bt_Remainder.TabIndex = 0;
            this.bt_Remainder.Text = "%";
            this.bt_Remainder.UseVisualStyleBackColor = true;
            this.bt_Remainder.Click += new System.EventHandler(this.bt_Remainder_Click);
            // 
            // bt_Four
            // 
            this.bt_Four.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Four.Location = new System.Drawing.Point(3, 183);
            this.bt_Four.Name = "bt_Four";
            this.bt_Four.Size = new System.Drawing.Size(89, 84);
            this.bt_Four.TabIndex = 7;
            this.bt_Four.Text = "4";
            this.bt_Four.UseVisualStyleBackColor = true;
            this.bt_Four.Click += new System.EventHandler(this.bt_Four_Click);
            // 
            // bt_Five
            // 
            this.bt_Five.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Five.Location = new System.Drawing.Point(98, 183);
            this.bt_Five.Name = "bt_Five";
            this.bt_Five.Size = new System.Drawing.Size(89, 84);
            this.bt_Five.TabIndex = 8;
            this.bt_Five.Text = "5";
            this.bt_Five.UseVisualStyleBackColor = true;
            this.bt_Five.Click += new System.EventHandler(this.bt_Five_Click);
            // 
            // bt_Six
            // 
            this.bt_Six.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Six.Location = new System.Drawing.Point(193, 183);
            this.bt_Six.Name = "bt_Six";
            this.bt_Six.Size = new System.Drawing.Size(89, 84);
            this.bt_Six.TabIndex = 9;
            this.bt_Six.Text = "6";
            this.bt_Six.UseVisualStyleBackColor = true;
            this.bt_Six.Click += new System.EventHandler(this.bt_Six_Click);
            // 
            // bt_Three
            // 
            this.bt_Three.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Three.Location = new System.Drawing.Point(193, 273);
            this.bt_Three.Name = "bt_Three";
            this.bt_Three.Size = new System.Drawing.Size(89, 84);
            this.bt_Three.TabIndex = 11;
            this.bt_Three.Text = "3";
            this.bt_Three.UseVisualStyleBackColor = true;
            this.bt_Three.Click += new System.EventHandler(this.bt_Three_Click);
            // 
            // bt_Divide
            // 
            this.bt_Divide.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Divide.Location = new System.Drawing.Point(288, 3);
            this.bt_Divide.Name = "bt_Divide";
            this.bt_Divide.Size = new System.Drawing.Size(89, 84);
            this.bt_Divide.TabIndex = 13;
            this.bt_Divide.Text = "÷";
            this.bt_Divide.UseVisualStyleBackColor = true;
            this.bt_Divide.Click += new System.EventHandler(this.bt_Divide_Click);
            // 
            // bt_Multiply
            // 
            this.bt_Multiply.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Multiply.Location = new System.Drawing.Point(288, 93);
            this.bt_Multiply.Name = "bt_Multiply";
            this.bt_Multiply.Size = new System.Drawing.Size(89, 84);
            this.bt_Multiply.TabIndex = 14;
            this.bt_Multiply.Text = "×";
            this.bt_Multiply.UseVisualStyleBackColor = true;
            this.bt_Multiply.Click += new System.EventHandler(this.bt_Multiply_Click);
            // 
            // bt_Subtract
            // 
            this.bt_Subtract.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Subtract.Location = new System.Drawing.Point(288, 183);
            this.bt_Subtract.Name = "bt_Subtract";
            this.bt_Subtract.Size = new System.Drawing.Size(89, 84);
            this.bt_Subtract.TabIndex = 14;
            this.bt_Subtract.Text = "－";
            this.bt_Subtract.UseVisualStyleBackColor = true;
            this.bt_Subtract.Click += new System.EventHandler(this.bt_Subtract_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.bt_MM, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_MP, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_MS, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_MR, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_MC, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 104);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 55);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // bt_MM
            // 
            this.bt_MM.Location = new System.Drawing.Point(307, 3);
            this.bt_MM.Name = "bt_MM";
            this.bt_MM.Size = new System.Drawing.Size(70, 49);
            this.bt_MM.TabIndex = 4;
            this.bt_MM.Text = "M-";
            this.bt_MM.UseVisualStyleBackColor = true;
            this.bt_MM.Click += new System.EventHandler(this.bt_MM_Click);
            // 
            // bt_MP
            // 
            this.bt_MP.Location = new System.Drawing.Point(231, 3);
            this.bt_MP.Name = "bt_MP";
            this.bt_MP.Size = new System.Drawing.Size(70, 49);
            this.bt_MP.TabIndex = 3;
            this.bt_MP.Text = "M+";
            this.bt_MP.UseVisualStyleBackColor = true;
            this.bt_MP.Click += new System.EventHandler(this.bt_MP_Click);
            // 
            // bt_MS
            // 
            this.bt_MS.Location = new System.Drawing.Point(155, 3);
            this.bt_MS.Name = "bt_MS";
            this.bt_MS.Size = new System.Drawing.Size(70, 49);
            this.bt_MS.TabIndex = 2;
            this.bt_MS.Text = "MS";
            this.bt_MS.UseVisualStyleBackColor = true;
            this.bt_MS.Click += new System.EventHandler(this.bt_MS_Click);
            // 
            // bt_MR
            // 
            this.bt_MR.Location = new System.Drawing.Point(79, 3);
            this.bt_MR.Name = "bt_MR";
            this.bt_MR.Size = new System.Drawing.Size(70, 49);
            this.bt_MR.TabIndex = 1;
            this.bt_MR.Text = "MR";
            this.bt_MR.UseVisualStyleBackColor = true;
            this.bt_MR.Click += new System.EventHandler(this.bt_MR_Click);
            // 
            // bt_MC
            // 
            this.bt_MC.Location = new System.Drawing.Point(3, 3);
            this.bt_MC.Name = "bt_MC";
            this.bt_MC.Size = new System.Drawing.Size(70, 49);
            this.bt_MC.TabIndex = 0;
            this.bt_MC.Text = "MC";
            this.bt_MC.UseVisualStyleBackColor = true;
            this.bt_MC.Click += new System.EventHandler(this.bt_MC_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Trans16, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Trans10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Trans8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Text2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Text16, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Text10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Text8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Trans2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 41);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Trans16
            // 
            this.Trans16.AutoSize = true;
            this.Trans16.Location = new System.Drawing.Point(288, 21);
            this.Trans16.Name = "Trans16";
            this.Trans16.Size = new System.Drawing.Size(15, 15);
            this.Trans16.TabIndex = 8;
            this.Trans16.Text = "0";
            // 
            // Trans10
            // 
            this.Trans10.AutoSize = true;
            this.Trans10.Location = new System.Drawing.Point(193, 21);
            this.Trans10.Name = "Trans10";
            this.Trans10.Size = new System.Drawing.Size(15, 15);
            this.Trans10.TabIndex = 7;
            this.Trans10.Text = "0";
            // 
            // Trans8
            // 
            this.Trans8.AutoSize = true;
            this.Trans8.Location = new System.Drawing.Point(98, 21);
            this.Trans8.Name = "Trans8";
            this.Trans8.Size = new System.Drawing.Size(15, 15);
            this.Trans8.TabIndex = 6;
            this.Trans8.Text = "0";
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Location = new System.Drawing.Point(3, 0);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(45, 15);
            this.Text2.TabIndex = 4;
            this.Text2.Text = "2진수";
            // 
            // Text16
            // 
            this.Text16.AutoSize = true;
            this.Text16.Location = new System.Drawing.Point(288, 0);
            this.Text16.Name = "Text16";
            this.Text16.Size = new System.Drawing.Size(53, 15);
            this.Text16.TabIndex = 3;
            this.Text16.Text = "16진수";
            // 
            // Text10
            // 
            this.Text10.AutoSize = true;
            this.Text10.Location = new System.Drawing.Point(193, 0);
            this.Text10.Name = "Text10";
            this.Text10.Size = new System.Drawing.Size(53, 15);
            this.Text10.TabIndex = 2;
            this.Text10.Text = "10진수";
            // 
            // Text8
            // 
            this.Text8.AutoSize = true;
            this.Text8.Location = new System.Drawing.Point(98, 0);
            this.Text8.Name = "Text8";
            this.Text8.Size = new System.Drawing.Size(45, 15);
            this.Text8.TabIndex = 1;
            this.Text8.Text = "8진수";
            // 
            // Trans2
            // 
            this.Trans2.AutoSize = true;
            this.Trans2.Location = new System.Drawing.Point(3, 21);
            this.Trans2.Name = "Trans2";
            this.Trans2.Size = new System.Drawing.Size(15, 15);
            this.Trans2.TabIndex = 5;
            this.Trans2.Text = "0";
            // 
            // Display
            // 
            this.Display.Dock = System.Windows.Forms.DockStyle.Top;
            this.Display.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(382, 59);
            this.Display.TabIndex = 5;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_Result
            // 
            this.bt_Result.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Result.Location = new System.Drawing.Point(194, 3);
            this.bt_Result.Name = "bt_Result";
            this.bt_Result.Size = new System.Drawing.Size(185, 80);
            this.bt_Result.TabIndex = 2;
            this.bt_Result.Text = "=";
            this.bt_Result.UseVisualStyleBackColor = true;
            this.bt_Result.Click += new System.EventHandler(this.bt_Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 607);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button bt_Zero;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bt_Two;
        private System.Windows.Forms.Button bt_One;
        private System.Windows.Forms.Button bt_Nine;
        private System.Windows.Forms.Button bt_Eight;
        private System.Windows.Forms.Button bt_Seven;
        private System.Windows.Forms.Button bt_Backspace;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Remainder;
        private System.Windows.Forms.Button bt_Four;
        private System.Windows.Forms.Button bt_Five;
        private System.Windows.Forms.Button bt_Six;
        private System.Windows.Forms.Button bt_Three;
        private System.Windows.Forms.Button bt_Divide;
        private System.Windows.Forms.Button bt_Multiply;
        private System.Windows.Forms.Button bt_Subtract;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt_MM;
        private System.Windows.Forms.Button bt_MP;
        private System.Windows.Forms.Button bt_MS;
        private System.Windows.Forms.Button bt_MR;
        private System.Windows.Forms.Button bt_MC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Trans16;
        private System.Windows.Forms.Label Trans10;
        private System.Windows.Forms.Label Trans8;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text16;
        private System.Windows.Forms.Label Text10;
        private System.Windows.Forms.Label Text8;
        private System.Windows.Forms.Label Trans2;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button bt_Result;
    }
}

