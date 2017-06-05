namespace SendyApp
{
    partial class Landing_Page
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.oLong = new System.Windows.Forms.TextBox();
            this.oLat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oType = new System.Windows.Forms.TextBox();
            this.oName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cnfrmBtn = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dlongBox = new System.Windows.Forms.TextBox();
            this.dlatBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtypeBox = new System.Windows.Forms.TextBox();
            this.dName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(747, 407);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.oLong);
            this.splitContainer2.Panel1.Controls.Add(this.oLat);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.oType);
            this.splitContainer2.Panel1.Controls.Add(this.oName);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer2.Panel2.Controls.Add(this.cnfrmBtn);
            this.splitContainer2.Panel2.Controls.Add(this.splitter1);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.dlongBox);
            this.splitContainer2.Panel2.Controls.Add(this.dlatBox);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.dtypeBox);
            this.splitContainer2.Panel2.Controls.Add(this.dName);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(249, 407);
            this.splitContainer2.SplitterDistance = 168;
            this.splitContainer2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Origin Longitude";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Origin Latitude";
            // 
            // oLong
            // 
            this.oLong.BackColor = System.Drawing.SystemColors.Window;
            this.oLong.Location = new System.Drawing.Point(135, 133);
            this.oLong.Name = "oLong";
            this.oLong.ReadOnly = true;
            this.oLong.Size = new System.Drawing.Size(100, 20);
            this.oLong.TabIndex = 6;
            // 
            // oLat
            // 
            this.oLat.BackColor = System.Drawing.SystemColors.Window;
            this.oLat.Location = new System.Drawing.Point(135, 103);
            this.oLat.Name = "oLat";
            this.oLat.ReadOnly = true;
            this.oLat.Size = new System.Drawing.Size(100, 20);
            this.oLat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Origin Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Origin Name";
            // 
            // oType
            // 
            this.oType.BackColor = System.Drawing.SystemColors.Window;
            this.oType.Location = new System.Drawing.Point(135, 72);
            this.oType.Name = "oType";
            this.oType.ReadOnly = true;
            this.oType.Size = new System.Drawing.Size(100, 20);
            this.oType.TabIndex = 2;
            // 
            // oName
            // 
            this.oName.BackColor = System.Drawing.SystemColors.Window;
            this.oName.Location = new System.Drawing.Point(135, 42);
            this.oName.Name = "oName";
            this.oName.ReadOnly = true;
            this.oName.Size = new System.Drawing.Size(100, 20);
            this.oName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // cnfrmBtn
            // 
            this.cnfrmBtn.Location = new System.Drawing.Point(15, 200);
            this.cnfrmBtn.Name = "cnfrmBtn";
            this.cnfrmBtn.Size = new System.Drawing.Size(220, 23);
            this.cnfrmBtn.TabIndex = 14;
            this.cnfrmBtn.Text = "Confirm Selection";
            this.cnfrmBtn.UseVisualStyleBackColor = true;
            this.cnfrmBtn.Click += new System.EventHandler(this.cnfrmBtn_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 174);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(249, 61);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Destination Longitude";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Destination Latitude";
            // 
            // dlongBox
            // 
            this.dlongBox.BackColor = System.Drawing.SystemColors.Window;
            this.dlongBox.Location = new System.Drawing.Point(135, 136);
            this.dlongBox.Name = "dlongBox";
            this.dlongBox.ReadOnly = true;
            this.dlongBox.Size = new System.Drawing.Size(100, 20);
            this.dlongBox.TabIndex = 10;
            // 
            // dlatBox
            // 
            this.dlatBox.BackColor = System.Drawing.SystemColors.Window;
            this.dlatBox.Location = new System.Drawing.Point(135, 106);
            this.dlatBox.Name = "dlatBox";
            this.dlatBox.ReadOnly = true;
            this.dlatBox.Size = new System.Drawing.Size(100, 20);
            this.dlatBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Destination Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Destination Name";
            // 
            // dtypeBox
            // 
            this.dtypeBox.BackColor = System.Drawing.SystemColors.Window;
            this.dtypeBox.Location = new System.Drawing.Point(135, 76);
            this.dtypeBox.Name = "dtypeBox";
            this.dtypeBox.ReadOnly = true;
            this.dtypeBox.Size = new System.Drawing.Size(100, 20);
            this.dtypeBox.TabIndex = 6;
            // 
            // dName
            // 
            this.dName.BackColor = System.Drawing.SystemColors.Window;
            this.dName.Location = new System.Drawing.Point(135, 46);
            this.dName.Name = "dName";
            this.dName.ReadOnly = true;
            this.dName.Size = new System.Drawing.Size(100, 20);
            this.dName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destination";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(494, 407);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Landing_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(747, 407);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Landing_Page";
            this.Text = "Landing_Page";
            this.Load += new System.EventHandler(this.Landing_Page_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oType;
        private System.Windows.Forms.TextBox oName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dtypeBox;
        private System.Windows.Forms.TextBox dName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox oLong;
        private System.Windows.Forms.TextBox oLat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dlongBox;
        private System.Windows.Forms.TextBox dlatBox;
        private System.Windows.Forms.Button cnfrmBtn;
        private System.Windows.Forms.Splitter splitter1;
    }
}