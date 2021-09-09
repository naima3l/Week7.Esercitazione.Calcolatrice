
namespace Week7.Esercitazione.Calcolatrice.WinForms
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textValue = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelTextValue = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(13, 49);
            this.textValue.Name = "textValue";
            this.textValue.ReadOnly = true;
            this.textValue.Size = new System.Drawing.Size(240, 31);
            this.textValue.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 46);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelTextValue
            // 
            this.labelTextValue.AutoSize = true;
            this.labelTextValue.Location = new System.Drawing.Point(14, 9);
            this.labelTextValue.Name = "labelTextValue";
            this.labelTextValue.Size = new System.Drawing.Size(54, 25);
            this.labelTextValue.TabIndex = 2;
            this.labelTextValue.Text = "Value";
            this.labelTextValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 115);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 47);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(106, 115);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 47);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(198, 115);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 47);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(198, 197);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 47);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(106, 197);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 47);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(13, 197);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 47);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(198, 281);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 47);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(106, 281);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 47);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(13, 281);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 47);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(198, 363);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(55, 47);
            this.btnEqual.TabIndex = 14;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(106, 363);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 47);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(13, 363);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(55, 47);
            this.btnPunto.TabIndex = 12;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(286, 363);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(55, 47);
            this.btnMul.TabIndex = 18;
            this.btnMul.Tag = "moltiplica";
            this.btnMul.Text = "x";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(286, 281);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(55, 47);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.Tag = "dividi";
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(286, 197);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(55, 47);
            this.btnSub.TabIndex = 16;
            this.btnSub.Tag = "sottrai";
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(286, 115);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(55, 47);
            this.btnSum.TabIndex = 15;
            this.btnSum.Tag = "somma";
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.labelTextValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textValue);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelTextValue;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSum;
    }
}

