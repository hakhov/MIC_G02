namespace MyCalc
{
    partial class Form1
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
            this.txResult = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btPluse = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btOne = new System.Windows.Forms.Button();
            this.btResult = new System.Windows.Forms.Button();
            this.btDoubleZero = new System.Windows.Forms.Button();
            this.btPoint = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.btPlusMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txResult
            // 
            this.txResult.Location = new System.Drawing.Point(14, 14);
            this.txResult.Name = "txResult";
            this.txResult.ReadOnly = true;
            this.txResult.Size = new System.Drawing.Size(304, 23);
            this.txResult.TabIndex = 0;
            this.txResult.Text = "0";
            this.txResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(14, 54);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(56, 48);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "CR";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(138, 54);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(56, 48);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "←";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btPluse_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(200, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btPluse_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(138, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "9";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btOne_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(76, 108);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 48);
            this.button6.TabIndex = 6;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btOne_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 108);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 48);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btOne_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(200, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 48);
            this.button8.TabIndex = 12;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btPluse_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(138, 162);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 48);
            this.button9.TabIndex = 11;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btOne_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(76, 162);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 48);
            this.button10.TabIndex = 10;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btOne_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(14, 162);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 48);
            this.button11.TabIndex = 9;
            this.button11.Text = "4";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btOne_Click);
            // 
            // btPluse
            // 
            this.btPluse.Location = new System.Drawing.Point(200, 216);
            this.btPluse.Name = "btPluse";
            this.btPluse.Size = new System.Drawing.Size(56, 48);
            this.btPluse.TabIndex = 16;
            this.btPluse.Text = "+";
            this.btPluse.UseVisualStyleBackColor = true;
            this.btPluse.Click += new System.EventHandler(this.btPluse_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(138, 216);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(56, 48);
            this.button13.TabIndex = 15;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btOne_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(76, 216);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 48);
            this.button14.TabIndex = 14;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btOne_Click);
            // 
            // btOne
            // 
            this.btOne.Location = new System.Drawing.Point(14, 216);
            this.btOne.Name = "btOne";
            this.btOne.Size = new System.Drawing.Size(56, 48);
            this.btOne.TabIndex = 13;
            this.btOne.Text = "1";
            this.btOne.UseVisualStyleBackColor = true;
            this.btOne.Click += new System.EventHandler(this.btOne_Click);
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(262, 270);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(56, 48);
            this.btResult.TabIndex = 20;
            this.btResult.Text = "=";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // btDoubleZero
            // 
            this.btDoubleZero.Location = new System.Drawing.Point(138, 270);
            this.btDoubleZero.Name = "btDoubleZero";
            this.btDoubleZero.Size = new System.Drawing.Size(56, 48);
            this.btDoubleZero.TabIndex = 19;
            this.btDoubleZero.Text = "00";
            this.btDoubleZero.UseVisualStyleBackColor = true;
            this.btDoubleZero.Click += new System.EventHandler(this.btDoubleZero_Click);
            // 
            // btPoint
            // 
            this.btPoint.Location = new System.Drawing.Point(76, 270);
            this.btPoint.Name = "btPoint";
            this.btPoint.Size = new System.Drawing.Size(56, 48);
            this.btPoint.TabIndex = 18;
            this.btPoint.Text = ".";
            this.btPoint.UseVisualStyleBackColor = true;
            this.btPoint.Click += new System.EventHandler(this.btPoint_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(14, 270);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(56, 48);
            this.button19.TabIndex = 17;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.btOne_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(262, 54);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(56, 48);
            this.button20.TabIndex = 4;
            this.button20.Text = "√";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.btPluse_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(262, 108);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 48);
            this.button21.TabIndex = 21;
            this.button21.Text = "%";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.btPluse_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(262, 162);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(56, 48);
            this.button22.TabIndex = 21;
            this.button22.Text = "1/x";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.btPluse_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(262, 216);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(56, 48);
            this.button23.TabIndex = 21;
            this.button23.Text = "x²";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.btPluse_Click);
            // 
            // btPlusMinus
            // 
            this.btPlusMinus.Location = new System.Drawing.Point(200, 270);
            this.btPlusMinus.Name = "btPlusMinus";
            this.btPlusMinus.Size = new System.Drawing.Size(56, 48);
            this.btPlusMinus.TabIndex = 19;
            this.btPlusMinus.Text = "±";
            this.btPlusMinus.UseVisualStyleBackColor = true;
            this.btPlusMinus.Click += new System.EventHandler(this.btPlusMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(324, 323);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.btPlusMinus);
            this.Controls.Add(this.btDoubleZero);
            this.Controls.Add(this.btPoint);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.btPluse);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btOne);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.txResult);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txResult;
        private Button btClear;
        private Button button1;
        private Button btRemove;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button btPluse;
        private Button button13;
        private Button button14;
        private Button btOne;
        private Button btResult;
        private Button btDoubleZero;
        private Button btPoint;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button btPlusMinus;
    }
}