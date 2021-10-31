namespace _003_calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsin = new System.Windows.Forms.Button();
            this.btncos = new System.Windows.Forms.Button();
            this.btnspace = new System.Windows.Forms.Button();
            this.btnpow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnpow2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn_PI = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btncoining = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnonoff = new System.Windows.Forms.Button();
            this.txtoperators = new System.Windows.Forms.TextBox();
            this.btntan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btnplus);
            this.panel1.Controls.Add(this.btnminus);
            this.panel1.Controls.Add(this.btncoining);
            this.panel1.Controls.Add(this.btndivision);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btnequal);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnpoint);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 246);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Operators);
            // 
            // btnsin
            // 
            this.btnsin.BackColor = System.Drawing.Color.LightGray;
            this.btnsin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsin.Location = new System.Drawing.Point(40, 93);
            this.btnsin.Margin = new System.Windows.Forms.Padding(4);
            this.btnsin.Name = "btnsin";
            this.btnsin.Size = new System.Drawing.Size(62, 53);
            this.btnsin.TabIndex = 23;
            this.btnsin.Text = "sin";
            this.btnsin.UseVisualStyleBackColor = false;
            this.btnsin.Click += new System.EventHandler(this.btnsin_Click);
            // 
            // btncos
            // 
            this.btncos.BackColor = System.Drawing.Color.LightGray;
            this.btncos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncos.Location = new System.Drawing.Point(106, 93);
            this.btncos.Margin = new System.Windows.Forms.Padding(4);
            this.btncos.Name = "btncos";
            this.btncos.Size = new System.Drawing.Size(62, 53);
            this.btncos.TabIndex = 22;
            this.btncos.Text = "cos";
            this.btncos.UseVisualStyleBackColor = false;
            this.btncos.Click += new System.EventHandler(this.btncos_Click);
            // 
            // btnspace
            // 
            this.btnspace.BackColor = System.Drawing.Color.LightGray;
            this.btnspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspace.Location = new System.Drawing.Point(250, 93);
            this.btnspace.Margin = new System.Windows.Forms.Padding(4);
            this.btnspace.Name = "btnspace";
            this.btnspace.Size = new System.Drawing.Size(142, 53);
            this.btnspace.TabIndex = 17;
            this.btnspace.Text = "Delete";
            this.btnspace.UseVisualStyleBackColor = false;
            this.btnspace.Click += new System.EventHandler(this.btnspace_Click);
            // 
            // btnpow
            // 
            this.btnpow.BackColor = System.Drawing.Color.LightGray;
            this.btnpow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpow.Location = new System.Drawing.Point(330, 335);
            this.btnpow.Margin = new System.Windows.Forms.Padding(4);
            this.btnpow.Name = "btnpow";
            this.btnpow.Size = new System.Drawing.Size(62, 53);
            this.btnpow.TabIndex = 20;
            this.btnpow.Text = "x^y";
            this.btnpow.UseVisualStyleBackColor = false;
            this.btnpow.Click += new System.EventHandler(this.btnpow_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.LightGray;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(330, 154);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(62, 53);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnpow2
            // 
            this.btnpow2.BackColor = System.Drawing.Color.LightGray;
            this.btnpow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpow2.Location = new System.Drawing.Point(330, 274);
            this.btnpow2.Margin = new System.Windows.Forms.Padding(4);
            this.btnpow2.Name = "btnpow2";
            this.btnpow2.Size = new System.Drawing.Size(62, 53);
            this.btnpow2.TabIndex = 19;
            this.btnpow2.Text = "𝑥²";
            this.btnpow2.UseVisualStyleBackColor = false;
            this.btnpow2.Click += new System.EventHandler(this.btnpow2_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(150, 4);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(62, 53);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Numbers);
            // 
            // btn_PI
            // 
            this.btn_PI.BackColor = System.Drawing.Color.LightGray;
            this.btn_PI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PI.Location = new System.Drawing.Point(330, 214);
            this.btn_PI.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PI.Name = "btn_PI";
            this.btn_PI.Size = new System.Drawing.Size(62, 53);
            this.btn_PI.TabIndex = 18;
            this.btn_PI.Text = "𝞹";
            this.btn_PI.UseVisualStyleBackColor = false;
            this.btn_PI.Click += new System.EventHandler(this.btn_PI_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(83, 4);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(62, 53);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Numbers);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(17, 4);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(62, 53);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Numbers);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.LightGray;
            this.btnplus.Location = new System.Drawing.Point(227, 4);
            this.btnplus.Margin = new System.Windows.Forms.Padding(4);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(62, 53);
            this.btnplus.TabIndex = 12;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.Operators);
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.LightGray;
            this.btnminus.Location = new System.Drawing.Point(227, 64);
            this.btnminus.Margin = new System.Windows.Forms.Padding(4);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(62, 53);
            this.btnminus.TabIndex = 11;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.Operators);
            // 
            // btncoining
            // 
            this.btncoining.BackColor = System.Drawing.Color.LightGray;
            this.btncoining.Location = new System.Drawing.Point(227, 124);
            this.btncoining.Margin = new System.Windows.Forms.Padding(4);
            this.btncoining.Name = "btncoining";
            this.btncoining.Size = new System.Drawing.Size(62, 53);
            this.btncoining.TabIndex = 10;
            this.btncoining.Text = "*";
            this.btncoining.UseVisualStyleBackColor = false;
            this.btncoining.Click += new System.EventHandler(this.Operators);
            // 
            // btndivision
            // 
            this.btndivision.BackColor = System.Drawing.Color.LightGray;
            this.btndivision.Location = new System.Drawing.Point(227, 185);
            this.btndivision.Margin = new System.Windows.Forms.Padding(4);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(62, 53);
            this.btndivision.TabIndex = 9;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = false;
            this.btndivision.Click += new System.EventHandler(this.Operators);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(150, 64);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(62, 53);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Numbers);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(83, 64);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(62, 53);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Numbers);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(17, 64);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(62, 53);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Numbers);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(150, 124);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(62, 53);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Numbers);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(83, 124);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(62, 53);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Numbers);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(17, 124);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(62, 53);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Numbers);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.LightGray;
            this.btnequal.Location = new System.Drawing.Point(150, 184);
            this.btnequal.Margin = new System.Windows.Forms.Padding(4);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(62, 53);
            this.btnequal.TabIndex = 2;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = false;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(83, 184);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(62, 53);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Numbers);
            // 
            // btnpoint
            // 
            this.btnpoint.BackColor = System.Drawing.Color.LightGray;
            this.btnpoint.Location = new System.Drawing.Point(17, 184);
            this.btnpoint.Margin = new System.Windows.Forms.Padding(4);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(62, 53);
            this.btnpoint.TabIndex = 0;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.Numbers);
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.ForeColor = System.Drawing.Color.White;
            this.txtresult.Location = new System.Drawing.Point(40, 54);
            this.txtresult.Margin = new System.Windows.Forms.Padding(4);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(352, 34);
            this.txtresult.TabIndex = 1;
            this.txtresult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnonoff
            // 
            this.btnonoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnonoff.Location = new System.Drawing.Point(40, 415);
            this.btnonoff.Name = "btnonoff";
            this.btnonoff.Size = new System.Drawing.Size(128, 47);
            this.btnonoff.TabIndex = 3;
            this.btnonoff.Text = "OFF";
            this.btnonoff.UseVisualStyleBackColor = true;
            this.btnonoff.Click += new System.EventHandler(this.btnonoff_Click);
            // 
            // txtoperators
            // 
            this.txtoperators.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoperators.ForeColor = System.Drawing.Color.White;
            this.txtoperators.Location = new System.Drawing.Point(40, 22);
            this.txtoperators.Margin = new System.Windows.Forms.Padding(4);
            this.txtoperators.Name = "txtoperators";
            this.txtoperators.ReadOnly = true;
            this.txtoperators.Size = new System.Drawing.Size(352, 24);
            this.txtoperators.TabIndex = 4;
            // 
            // btntan
            // 
            this.btntan.BackColor = System.Drawing.Color.LightGray;
            this.btntan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntan.Location = new System.Drawing.Point(173, 93);
            this.btntan.Margin = new System.Windows.Forms.Padding(4);
            this.btntan.Name = "btntan";
            this.btntan.Size = new System.Drawing.Size(62, 53);
            this.btntan.TabIndex = 24;
            this.btntan.Text = "tan";
            this.btntan.UseVisualStyleBackColor = false;
            this.btntan.Click += new System.EventHandler(this.btntan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 476);
            this.Controls.Add(this.btntan);
            this.Controls.Add(this.btnspace);
            this.Controls.Add(this.btnsin);
            this.Controls.Add(this.txtoperators);
            this.Controls.Add(this.btncos);
            this.Controls.Add(this.btnonoff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnpow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnpow2);
            this.Controls.Add(this.btn_PI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "My Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnspace;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btncoining;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnonoff;
        private System.Windows.Forms.TextBox txtoperators;
        private System.Windows.Forms.Button btn_PI;
        private System.Windows.Forms.Button btnpow2;
        private System.Windows.Forms.Button btnpow;
        private System.Windows.Forms.Button btnsin;
        private System.Windows.Forms.Button btncos;
        private System.Windows.Forms.Button btntan;
    }
}

