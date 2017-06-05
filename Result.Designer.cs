namespace SendyApp
{
    partial class Result
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.oNum = new System.Windows.Forms.TextBox();
            this.amt = new System.Windows.Forms.TextBox();
            this.curr = new System.Windows.Forms.TextBox();
            this.dst = new System.Windows.Forms.TextBox();
            this.eta = new System.Windows.Forms.TextBox();
            this.etd = new System.Windows.Forms.TextBox();
            this.extBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ETA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ETD";
            // 
            // oNum
            // 
            this.oNum.BackColor = System.Drawing.SystemColors.HighlightText;
            this.oNum.Location = new System.Drawing.Point(130, 30);
            this.oNum.Name = "oNum";
            this.oNum.ReadOnly = true;
            this.oNum.Size = new System.Drawing.Size(100, 20);
            this.oNum.TabIndex = 7;
            // 
            // amt
            // 
            this.amt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.amt.Location = new System.Drawing.Point(130, 63);
            this.amt.Name = "amt";
            this.amt.ReadOnly = true;
            this.amt.Size = new System.Drawing.Size(100, 20);
            this.amt.TabIndex = 8;
            // 
            // curr
            // 
            this.curr.BackColor = System.Drawing.SystemColors.HighlightText;
            this.curr.Location = new System.Drawing.Point(130, 102);
            this.curr.Name = "curr";
            this.curr.ReadOnly = true;
            this.curr.Size = new System.Drawing.Size(100, 20);
            this.curr.TabIndex = 9;
            // 
            // dst
            // 
            this.dst.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dst.Location = new System.Drawing.Point(130, 142);
            this.dst.Name = "dst";
            this.dst.ReadOnly = true;
            this.dst.Size = new System.Drawing.Size(100, 20);
            this.dst.TabIndex = 10;
            // 
            // eta
            // 
            this.eta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.eta.Location = new System.Drawing.Point(130, 182);
            this.eta.Name = "eta";
            this.eta.ReadOnly = true;
            this.eta.Size = new System.Drawing.Size(100, 20);
            this.eta.TabIndex = 11;
            // 
            // etd
            // 
            this.etd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.etd.Location = new System.Drawing.Point(130, 222);
            this.etd.Name = "etd";
            this.etd.ReadOnly = true;
            this.etd.Size = new System.Drawing.Size(100, 20);
            this.etd.TabIndex = 12;
            // 
            // extBtn
            // 
            this.extBtn.Location = new System.Drawing.Point(54, 304);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(182, 23);
            this.extBtn.TabIndex = 13;
            this.extBtn.Text = "Exit";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(299, 339);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.etd);
            this.Controls.Add(this.eta);
            this.Controls.Add(this.dst);
            this.Controls.Add(this.curr);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.oNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oNum;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.TextBox curr;
        private System.Windows.Forms.TextBox dst;
        private System.Windows.Forms.TextBox eta;
        private System.Windows.Forms.TextBox etd;
        private System.Windows.Forms.Button extBtn;
    }
}