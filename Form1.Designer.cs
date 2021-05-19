
namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //iuyfdg
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn0 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.dotbtn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cpybtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::SimpleCalculator.Properties.Resources.Screenshot__107_;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 338);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.txtDisplay.Location = new System.Drawing.Point(3, 3);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(256, 61);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::SimpleCalculator.Properties.Resources.Screenshot__107_;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn0, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button19, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnEqual, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.dotbtn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn1, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnSub, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn4, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnMul, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDiv, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.clrbtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReset, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cpybtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(256, 265);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(67, 215);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(58, 47);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Location = new System.Drawing.Point(3, 215);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(58, 47);
            this.button19.TabIndex = 18;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.Location = new System.Drawing.Point(195, 215);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(58, 47);
            this.btnEqual.TabIndex = 17;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // dotbtn
            // 
            this.dotbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotbtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dotbtn.Location = new System.Drawing.Point(131, 215);
            this.dotbtn.Name = "dotbtn";
            this.dotbtn.Size = new System.Drawing.Size(58, 47);
            this.dotbtn.TabIndex = 16;
            this.dotbtn.Text = ".";
            this.dotbtn.UseVisualStyleBackColor = true;
            this.dotbtn.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(195, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 47);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(131, 162);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 47);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(67, 162);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(58, 47);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(3, 162);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(58, 47);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnSub
            // 
            this.btnSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSub.Location = new System.Drawing.Point(195, 109);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(58, 47);
            this.btnSub.TabIndex = 11;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(131, 109);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(58, 47);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(67, 109);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(58, 47);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(3, 109);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(58, 47);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnMul
            // 
            this.btnMul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMul.Location = new System.Drawing.Point(195, 56);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(58, 47);
            this.btnMul.TabIndex = 7;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(131, 56);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(58, 47);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(67, 56);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(58, 47);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(3, 56);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(58, 47);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiv.Location = new System.Drawing.Point(195, 3);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(58, 47);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clrbtn.Location = new System.Drawing.Point(131, 3);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(58, 47);
            this.clrbtn.TabIndex = 2;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(67, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(58, 47);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cpybtn
            // 
            this.cpybtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpybtn.Location = new System.Drawing.Point(3, 3);
            this.cpybtn.Name = "cpybtn";
            this.cpybtn.Size = new System.Drawing.Size(58, 47);
            this.cpybtn.TabIndex = 0;
            this.cpybtn.Text = "Copy";
            this.cpybtn.UseVisualStyleBackColor = true;
            this.cpybtn.Click += new System.EventHandler(this.cpybtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button cpybtn;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button dotbtn;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
    }
}

