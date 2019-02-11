namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_percent = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_multiple = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_pow = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_cube = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_onediv = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_plusminus = new System.Windows.Forms.Button();
            this.inputData = new System.Windows.Forms.RichTextBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.RichTextBox();
            this.resultText = new System.Windows.Forms.Label();
            this.resultValue = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "temp";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "temp";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(612, 220);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 70);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Del";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(718, 220);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(100, 70);
            this.btn_divide.TabIndex = 4;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_percent
            // 
            this.btn_percent.Location = new System.Drawing.Point(294, 220);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(100, 70);
            this.btn_percent.TabIndex = 5;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = true;
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Location = new System.Drawing.Point(294, 296);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(100, 70);
            this.btn_sqrt.TabIndex = 10;
            this.btn_sqrt.Text = "√";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            // 
            // btn_multiple
            // 
            this.btn_multiple.Location = new System.Drawing.Point(718, 296);
            this.btn_multiple.Name = "btn_multiple";
            this.btn_multiple.Size = new System.Drawing.Size(100, 70);
            this.btn_multiple.TabIndex = 9;
            this.btn_multiple.Text = "X";
            this.btn_multiple.UseVisualStyleBackColor = true;
            this.btn_multiple.Click += new System.EventHandler(this.btn_multiple_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(612, 296);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(100, 70);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(506, 296);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(100, 70);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(400, 296);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(100, 70);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_pow
            // 
            this.btn_pow.Location = new System.Drawing.Point(294, 372);
            this.btn_pow.Name = "btn_pow";
            this.btn_pow.Size = new System.Drawing.Size(100, 70);
            this.btn_pow.TabIndex = 15;
            this.btn_pow.Text = "제곱";
            this.btn_pow.UseVisualStyleBackColor = true;
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(718, 372);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(100, 70);
            this.btn_minus.TabIndex = 14;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(612, 372);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(100, 70);
            this.btn_6.TabIndex = 13;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(506, 372);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(100, 70);
            this.btn_5.TabIndex = 12;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(400, 372);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(100, 70);
            this.btn_4.TabIndex = 11;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_cube
            // 
            this.btn_cube.Location = new System.Drawing.Point(294, 448);
            this.btn_cube.Name = "btn_cube";
            this.btn_cube.Size = new System.Drawing.Size(100, 70);
            this.btn_cube.TabIndex = 20;
            this.btn_cube.Text = "세제곱";
            this.btn_cube.UseVisualStyleBackColor = true;
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(718, 448);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(100, 70);
            this.btn_plus.TabIndex = 19;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(612, 448);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(100, 70);
            this.btn_3.TabIndex = 18;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(506, 448);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(100, 70);
            this.btn_2.TabIndex = 17;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(400, 448);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(100, 70);
            this.btn_1.TabIndex = 16;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_onediv
            // 
            this.btn_onediv.Location = new System.Drawing.Point(294, 524);
            this.btn_onediv.Name = "btn_onediv";
            this.btn_onediv.Size = new System.Drawing.Size(100, 70);
            this.btn_onediv.TabIndex = 25;
            this.btn_onediv.Text = "1/x";
            this.btn_onediv.UseVisualStyleBackColor = true;
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(718, 524);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(100, 70);
            this.btn_equal.TabIndex = 24;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            // 
            // btn_dot
            // 
            this.btn_dot.Location = new System.Drawing.Point(612, 524);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(100, 70);
            this.btn_dot.TabIndex = 23;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(506, 524);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(100, 70);
            this.btn_0.TabIndex = 22;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_plusminus
            // 
            this.btn_plusminus.Location = new System.Drawing.Point(400, 524);
            this.btn_plusminus.Name = "btn_plusminus";
            this.btn_plusminus.Size = new System.Drawing.Size(100, 70);
            this.btn_plusminus.TabIndex = 21;
            this.btn_plusminus.Text = "±";
            this.btn_plusminus.UseVisualStyleBackColor = true;
            this.btn_plusminus.Click += new System.EventHandler(this.btn_plusminus_Click);
            // 
            // inputData
            // 
            this.inputData.Location = new System.Drawing.Point(294, 154);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(526, 54);
            this.inputData.TabIndex = 26;
            this.inputData.Text = "";
            this.inputData.TextChanged += new System.EventHandler(this.inputData_TextChanged);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(501, 81);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(113, 25);
            this.mainLabel.TabIndex = 27;
            this.mainLabel.Text = "Micro계산기";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(379, 113);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data.Size = new System.Drawing.Size(439, 32);
            this.data.TabIndex = 28;
            this.data.Text = "";
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(918, 171);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(60, 25);
            this.resultText.TabIndex = 29;
            this.resultText.Text = "결과값";
            // 
            // resultValue
            // 
            this.resultValue.Location = new System.Drawing.Point(893, 214);
            this.resultValue.Name = "resultValue";
            this.resultValue.ReadOnly = true;
            this.resultValue.Size = new System.Drawing.Size(120, 58);
            this.resultValue.TabIndex = 30;
            this.resultValue.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "저장된 수";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 762);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultValue);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.data);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.btn_onediv);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_plusminus);
            this.Controls.Add(this.btn_cube);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_pow);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_multiple);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_percent);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_percent;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.Button btn_multiple;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_pow;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_cube;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_onediv;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_plusminus;
        private System.Windows.Forms.RichTextBox inputData;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.RichTextBox data;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.RichTextBox resultValue;
        private System.Windows.Forms.Label label1;
    }
}

