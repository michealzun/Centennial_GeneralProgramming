namespace Lab6
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnEvenOdd = new System.Windows.Forms.Button();
            this.btnGenerateValue = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFactor = new System.Windows.Forms.TextBox();
            this.labelFactor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbEvenOdd = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbRangedValue = new System.Windows.Forms.TextBox();
            this.tbHighIndex = new System.Windows.Forms.TextBox();
            this.tbLowIndex = new System.Windows.Forms.TextBox();
            this.tbSearceValue = new System.Windows.Forms.TextBox();
            this.lbValues = new System.Windows.Forms.ListBox();
            this.labelValueForSearch = new System.Windows.Forms.Label();
            this.radioChar = new System.Windows.Forms.RadioButton();
            this.radioDouble = new System.Windows.Forms.RadioButton();
            this.radioInteger = new System.Windows.Forms.RadioButton();
            this.labelBetweenHighLow = new System.Windows.Forms.Label();
            this.labelHighIndex = new System.Windows.Forms.Label();
            this.labelLowIndex = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(6, 70);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnEvenOdd
            // 
            this.btnEvenOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvenOdd.Location = new System.Drawing.Point(70, 70);
            this.btnEvenOdd.Name = "btnEvenOdd";
            this.btnEvenOdd.Size = new System.Drawing.Size(135, 23);
            this.btnEvenOdd.TabIndex = 1;
            this.btnEvenOdd.Text = "Check for Even or Odd";
            this.btnEvenOdd.UseVisualStyleBackColor = true;
            this.btnEvenOdd.Click += new System.EventHandler(this.btnEvenOdd_Click);
            // 
            // btnGenerateValue
            // 
            this.btnGenerateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateValue.Location = new System.Drawing.Point(235, 19);
            this.btnGenerateValue.Name = "btnGenerateValue";
            this.btnGenerateValue.Size = new System.Drawing.Size(140, 23);
            this.btnGenerateValue.TabIndex = 2;
            this.btnGenerateValue.Text = "Generate Value";
            this.btnGenerateValue.UseVisualStyleBackColor = true;
            this.btnGenerateValue.Click += new System.EventHandler(this.btnGenerateValue_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(300, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(300, 124);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFactor);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.labelFactor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate Asynchronously";
            // 
            // tbFactor
            // 
            this.tbFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFactor.Location = new System.Drawing.Point(70, 29);
            this.tbFactor.Name = "tbFactor";
            this.tbFactor.Size = new System.Drawing.Size(135, 20);
            this.tbFactor.TabIndex = 3;
            // 
            // labelFactor
            // 
            this.labelFactor.AutoSize = true;
            this.labelFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactor.Location = new System.Drawing.Point(6, 29);
            this.labelFactor.Name = "labelFactor";
            this.labelFactor.Size = new System.Drawing.Size(60, 13);
            this.labelFactor.TabIndex = 2;
            this.labelFactor.Text = "Get Factor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbEvenOdd);
            this.groupBox2.Controls.Add(this.labelNumber);
            this.groupBox2.Controls.Add(this.btnEvenOdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check for Even/Odd";
            // 
            // tbEvenOdd
            // 
            this.tbEvenOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEvenOdd.Location = new System.Drawing.Point(72, 36);
            this.tbEvenOdd.Name = "tbEvenOdd";
            this.tbEvenOdd.Size = new System.Drawing.Size(133, 20);
            this.tbEvenOdd.TabIndex = 2;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(19, 39);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(47, 13);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "Number:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbRangedValue);
            this.groupBox3.Controls.Add(this.tbHighIndex);
            this.groupBox3.Controls.Add(this.tbLowIndex);
            this.groupBox3.Controls.Add(this.tbSearceValue);
            this.groupBox3.Controls.Add(this.lbValues);
            this.groupBox3.Controls.Add(this.labelValueForSearch);
            this.groupBox3.Controls.Add(this.radioChar);
            this.groupBox3.Controls.Add(this.radioDouble);
            this.groupBox3.Controls.Add(this.radioInteger);
            this.groupBox3.Controls.Add(this.labelBetweenHighLow);
            this.groupBox3.Controls.Add(this.labelHighIndex);
            this.groupBox3.Controls.Add(this.labelLowIndex);
            this.groupBox3.Controls.Add(this.btnGenerateValue);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnDisplay);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(229, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 237);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display List of Values and Search";
            // 
            // tbRangedValue
            // 
            this.tbRangedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRangedValue.Location = new System.Drawing.Point(109, 208);
            this.tbRangedValue.Name = "tbRangedValue";
            this.tbRangedValue.Size = new System.Drawing.Size(266, 20);
            this.tbRangedValue.TabIndex = 16;
            // 
            // tbHighIndex
            // 
            this.tbHighIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHighIndex.Location = new System.Drawing.Point(182, 144);
            this.tbHighIndex.Name = "tbHighIndex";
            this.tbHighIndex.Size = new System.Drawing.Size(100, 20);
            this.tbHighIndex.TabIndex = 15;
            // 
            // tbLowIndex
            // 
            this.tbLowIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLowIndex.Location = new System.Drawing.Point(182, 102);
            this.tbLowIndex.Name = "tbLowIndex";
            this.tbLowIndex.Size = new System.Drawing.Size(100, 20);
            this.tbLowIndex.TabIndex = 14;
            // 
            // tbSearceValue
            // 
            this.tbSearceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearceValue.Location = new System.Drawing.Point(182, 61);
            this.tbSearceValue.Name = "tbSearceValue";
            this.tbSearceValue.Size = new System.Drawing.Size(100, 20);
            this.tbSearceValue.TabIndex = 13;
            // 
            // lbValues
            // 
            this.lbValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValues.FormattingEnabled = true;
            this.lbValues.Location = new System.Drawing.Point(21, 55);
            this.lbValues.Name = "lbValues";
            this.lbValues.Size = new System.Drawing.Size(58, 173);
            this.lbValues.TabIndex = 12;
            // 
            // labelValueForSearch
            // 
            this.labelValueForSearch.AutoSize = true;
            this.labelValueForSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueForSearch.Location = new System.Drawing.Point(85, 64);
            this.labelValueForSearch.Name = "labelValueForSearch";
            this.labelValueForSearch.Size = new System.Drawing.Size(89, 13);
            this.labelValueForSearch.TabIndex = 3;
            this.labelValueForSearch.Text = "Value for Search:";
            // 
            // radioChar
            // 
            this.radioChar.AutoSize = true;
            this.radioChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioChar.Location = new System.Drawing.Point(162, 22);
            this.radioChar.Name = "radioChar";
            this.radioChar.Size = new System.Drawing.Size(47, 17);
            this.radioChar.TabIndex = 11;
            this.radioChar.Text = "Char";
            this.radioChar.UseVisualStyleBackColor = true;
            // 
            // radioDouble
            // 
            this.radioDouble.AutoSize = true;
            this.radioDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDouble.Location = new System.Drawing.Point(88, 22);
            this.radioDouble.Name = "radioDouble";
            this.radioDouble.Size = new System.Drawing.Size(59, 17);
            this.radioDouble.TabIndex = 10;
            this.radioDouble.Text = "Double";
            this.radioDouble.UseVisualStyleBackColor = true;
            // 
            // radioInteger
            // 
            this.radioInteger.AutoSize = true;
            this.radioInteger.Checked = true;
            this.radioInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInteger.Location = new System.Drawing.Point(21, 22);
            this.radioInteger.Name = "radioInteger";
            this.radioInteger.Size = new System.Drawing.Size(58, 17);
            this.radioInteger.TabIndex = 9;
            this.radioInteger.TabStop = true;
            this.radioInteger.Text = "Integer";
            this.radioInteger.UseVisualStyleBackColor = true;
            // 
            // labelBetweenHighLow
            // 
            this.labelBetweenHighLow.AutoSize = true;
            this.labelBetweenHighLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetweenHighLow.Location = new System.Drawing.Point(123, 182);
            this.labelBetweenHighLow.Name = "labelBetweenHighLow";
            this.labelBetweenHighLow.Size = new System.Drawing.Size(184, 13);
            this.labelBetweenHighLow.TabIndex = 7;
            this.labelBetweenHighLow.Text = "Values Between High and Low:";
            // 
            // labelHighIndex
            // 
            this.labelHighIndex.AutoSize = true;
            this.labelHighIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighIndex.Location = new System.Drawing.Point(113, 147);
            this.labelHighIndex.Name = "labelHighIndex";
            this.labelHighIndex.Size = new System.Drawing.Size(61, 13);
            this.labelHighIndex.TabIndex = 6;
            this.labelHighIndex.Text = "High Index:";
            // 
            // labelLowIndex
            // 
            this.labelLowIndex.AutoSize = true;
            this.labelLowIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLowIndex.Location = new System.Drawing.Point(115, 105);
            this.labelLowIndex.Name = "labelLowIndex";
            this.labelLowIndex.Size = new System.Drawing.Size(59, 13);
            this.labelLowIndex.TabIndex = 5;
            this.labelLowIndex.Text = "Low Index:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 261);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "YueyangSun_Lab6_Ex1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnEvenOdd;
        private System.Windows.Forms.Button btnGenerateValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelValueForSearch;
        private System.Windows.Forms.Label labelFactor;
        private System.Windows.Forms.RadioButton radioChar;
        private System.Windows.Forms.RadioButton radioDouble;
        private System.Windows.Forms.RadioButton radioInteger;
        private System.Windows.Forms.Label labelBetweenHighLow;
        private System.Windows.Forms.Label labelHighIndex;
        private System.Windows.Forms.Label labelLowIndex;
        private System.Windows.Forms.TextBox tbFactor;
        private System.Windows.Forms.TextBox tbEvenOdd;
        private System.Windows.Forms.TextBox tbRangedValue;
        private System.Windows.Forms.TextBox tbHighIndex;
        private System.Windows.Forms.TextBox tbLowIndex;
        private System.Windows.Forms.TextBox tbSearceValue;
        private System.Windows.Forms.ListBox lbValues;
    }
}

