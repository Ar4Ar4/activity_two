namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WishList = new System.Windows.Forms.ListBox();
            this.FillBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CountBtn = new System.Windows.Forms.Button();
            this.Tit = new System.Windows.Forms.Label();
            this.SelLab = new System.Windows.Forms.Label();
            this.CuntLab = new System.Windows.Forms.Label();
            this.SelBox = new System.Windows.Forms.TextBox();
            this.CuntBox = new System.Windows.Forms.TextBox();
            this.SortBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WishList
            // 
            this.WishList.FormattingEnabled = true;
            this.WishList.Location = new System.Drawing.Point(12, 48);
            this.WishList.Name = "WishList";
            this.WishList.Size = new System.Drawing.Size(151, 134);
            this.WishList.TabIndex = 0;
            this.WishList.SelectedIndexChanged += new System.EventHandler(this.WishList_SelectedIndexChanged);
            // 
            // FillBtn
            // 
            this.FillBtn.Location = new System.Drawing.Point(198, 48);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(75, 23);
            this.FillBtn.TabIndex = 1;
            this.FillBtn.Text = "Fill";
            this.FillBtn.UseVisualStyleBackColor = true;
            this.FillBtn.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(198, 106);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CountBtn
            // 
            this.CountBtn.Location = new System.Drawing.Point(198, 135);
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Size = new System.Drawing.Size(75, 23);
            this.CountBtn.TabIndex = 3;
            this.CountBtn.Text = "Count";
            this.CountBtn.UseVisualStyleBackColor = true;
            this.CountBtn.Click += new System.EventHandler(this.CountBtn_Click);
            // 
            // Tit
            // 
            this.Tit.AutoSize = true;
            this.Tit.Location = new System.Drawing.Point(84, 13);
            this.Tit.Name = "Tit";
            this.Tit.Size = new System.Drawing.Size(50, 13);
            this.Tit.TabIndex = 4;
            this.Tit.Text = "Wish List";
            this.Tit.Click += new System.EventHandler(this.Tit_Click);
            // 
            // SelLab
            // 
            this.SelLab.AutoSize = true;
            this.SelLab.Location = new System.Drawing.Point(12, 234);
            this.SelLab.Name = "SelLab";
            this.SelLab.Size = new System.Drawing.Size(54, 13);
            this.SelLab.TabIndex = 5;
            this.SelLab.Text = "Selection:";
            this.SelLab.Click += new System.EventHandler(this.SelLab_Click);
            // 
            // CuntLab
            // 
            this.CuntLab.AutoSize = true;
            this.CuntLab.Location = new System.Drawing.Point(28, 267);
            this.CuntLab.Name = "CuntLab";
            this.CuntLab.Size = new System.Drawing.Size(38, 13);
            this.CuntLab.TabIndex = 6;
            this.CuntLab.Text = "Count:";
            this.CuntLab.Click += new System.EventHandler(this.CuntLab_Click);
            // 
            // SelBox
            // 
            this.SelBox.Location = new System.Drawing.Point(72, 231);
            this.SelBox.Name = "SelBox";
            this.SelBox.Size = new System.Drawing.Size(100, 20);
            this.SelBox.TabIndex = 7;
            this.SelBox.TextChanged += new System.EventHandler(this.SelBox_TextChanged);
            // 
            // CuntBox
            // 
            this.CuntBox.Location = new System.Drawing.Point(72, 264);
            this.CuntBox.Name = "CuntBox";
            this.CuntBox.Size = new System.Drawing.Size(100, 20);
            this.CuntBox.TabIndex = 8;
            this.CuntBox.TextChanged += new System.EventHandler(this.CuntBox_TextChanged);
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(198, 77);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(75, 23);
            this.SortBtn.TabIndex = 9;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(198, 164);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 333);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 327);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.CuntBox);
            this.Controls.Add(this.SelBox);
            this.Controls.Add(this.CuntLab);
            this.Controls.Add(this.SelLab);
            this.Controls.Add(this.Tit);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.FillBtn);
            this.Controls.Add(this.WishList);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Wish List Gen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WishList;
        private System.Windows.Forms.Button FillBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CountBtn;
        private System.Windows.Forms.Label Tit;
        private System.Windows.Forms.Label SelLab;
        private System.Windows.Forms.Label CuntLab;
        private System.Windows.Forms.TextBox SelBox;
        private System.Windows.Forms.TextBox CuntBox;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

