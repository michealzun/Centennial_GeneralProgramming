namespace WindowsFormsApplication1
{
    partial class calculator
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.XValues = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.btnRemainder = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnOneOverX = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnAddAndMinus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(53, 36);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(42, 20);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.Visible = false;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(133, 36);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(42, 20);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.Visible = false;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(213, 36);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(42, 20);
            this.textBoxC.TabIndex = 2;
            this.textBoxC.Visible = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(22, 36);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(26, 13);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "A = ";
            this.labelA.Visible = false;
            this.labelA.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(101, 36);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(26, 13);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "B = ";
            this.labelB.Visible = false;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(181, 36);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(26, 13);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "C = ";
            this.labelC.Visible = false;
            // 
            // XValues
            // 
            this.XValues.AutoSize = true;
            this.XValues.Location = new System.Drawing.Point(27, 83);
            this.XValues.Name = "XValues";
            this.XValues.Size = new System.Drawing.Size(135, 13);
            this.XValues.TabIndex = 6;
            this.XValues.Text = "X₁=____    and    X₂=_____";
            this.XValues.Visible = false;
            this.XValues.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(28, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 31);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(204, 72);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(51, 34);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Visible = false;
            this.btnCalc.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.Location = new System.Drawing.Point(204, 52);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(51, 31);
            this.BtnC.TabIndex = 9;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // btnRemainder
            // 
            this.btnRemainder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemainder.Location = new System.Drawing.Point(204, 164);
            this.btnRemainder.Name = "btnRemainder";
            this.btnRemainder.Size = new System.Drawing.Size(51, 31);
            this.btnRemainder.TabIndex = 10;
            this.btnRemainder.Text = "\\";
            this.btnRemainder.UseVisualStyleBackColor = false;
            this.btnRemainder.Visible = false;
            this.btnRemainder.Click += new System.EventHandler(this.btnRemainder_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(204, 118);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(51, 31);
            this.btnDivide.TabIndex = 11;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(204, 164);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(51, 31);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(204, 210);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(51, 31);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(204, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 31);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(204, 303);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(51, 31);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.LightGray;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOne.Location = new System.Drawing.Point(30, 238);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(34, 31);
            this.btnOne.TabIndex = 16;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(28, 52);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(150, 35);
            this.textBoxInput.TabIndex = 17;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(85, 164);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(93, 31);
            this.btnX.TabIndex = 18;
            this.btnX.Text = "Ax²+Bx+C=0";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Visible = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.Location = new System.Drawing.Point(28, 164);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(34, 31);
            this.btnFactorial.TabIndex = 19;
            this.btnFactorial.Text = "x!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Visible = false;
            this.btnFactorial.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoot.Location = new System.Drawing.Point(28, 211);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(34, 31);
            this.btnRoot.TabIndex = 20;
            this.btnRoot.Text = " √";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Visible = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(85, 211);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(34, 31);
            this.btnSquare.TabIndex = 21;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Visible = false;
            this.btnSquare.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnOneOverX
            // 
            this.btnOneOverX.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOneOverX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneOverX.Location = new System.Drawing.Point(144, 211);
            this.btnOneOverX.Name = "btnOneOverX";
            this.btnOneOverX.Size = new System.Drawing.Size(34, 31);
            this.btnOneOverX.TabIndex = 22;
            this.btnOneOverX.Text = "1/x";
            this.btnOneOverX.UseVisualStyleBackColor = false;
            this.btnOneOverX.Visible = false;
            this.btnOneOverX.Click += new System.EventHandler(this.btnOneOverX_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.LightGray;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTwo.Location = new System.Drawing.Point(85, 238);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(34, 31);
            this.btnTwo.TabIndex = 23;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.LightGray;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThree.Location = new System.Drawing.Point(144, 238);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(34, 31);
            this.btnThree.TabIndex = 24;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.LightGray;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSix.Location = new System.Drawing.Point(144, 188);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(34, 31);
            this.btnSix.TabIndex = 28;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.LightGray;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFive.Location = new System.Drawing.Point(85, 188);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(34, 31);
            this.btnFive.TabIndex = 27;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.LightGray;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFour.Location = new System.Drawing.Point(28, 188);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(34, 31);
            this.btnFour.TabIndex = 26;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.LightGray;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNine.Location = new System.Drawing.Point(144, 138);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(34, 31);
            this.btnNine.TabIndex = 31;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.LightGray;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEight.Location = new System.Drawing.Point(85, 138);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(34, 31);
            this.btnEight.TabIndex = 30;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.LightGray;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeven.Location = new System.Drawing.Point(28, 138);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(34, 31);
            this.btnSeven.TabIndex = 29;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.LightGray;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDot.Location = new System.Drawing.Point(144, 285);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(34, 31);
            this.btnDot.TabIndex = 32;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.LightGray;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZero.Location = new System.Drawing.Point(85, 285);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(34, 31);
            this.btnZero.TabIndex = 33;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnAddAndMinus
            // 
            this.btnAddAndMinus.BackColor = System.Drawing.Color.LightGray;
            this.btnAddAndMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAndMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAndMinus.Location = new System.Drawing.Point(30, 285);
            this.btnAddAndMinus.Name = "btnAddAndMinus";
            this.btnAddAndMinus.Size = new System.Drawing.Size(34, 31);
            this.btnAddAndMinus.TabIndex = 34;
            this.btnAddAndMinus.Text = "±";
            this.btnAddAndMinus.UseVisualStyleBackColor = false;
            this.btnAddAndMinus.Click += new System.EventHandler(this.btnAddAndMinus_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 351);
            this.Controls.Add(this.btnAddAndMinus);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOneOverX);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnRemainder);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.XValues);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label XValues;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button btnRemainder;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnOneOverX;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnAddAndMinus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

