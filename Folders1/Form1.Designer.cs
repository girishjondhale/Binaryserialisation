namespace Folders1
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
            this.btncreatefolder = new System.Windows.Forms.Button();
            this.btncreatefile = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncreatefolder
            // 
            this.btncreatefolder.Location = new System.Drawing.Point(73, 37);
            this.btncreatefolder.Name = "btncreatefolder";
            this.btncreatefolder.Size = new System.Drawing.Size(147, 29);
            this.btncreatefolder.TabIndex = 0;
            this.btncreatefolder.Text = "create folder";
            this.btncreatefolder.UseVisualStyleBackColor = true;
            this.btncreatefolder.Click += new System.EventHandler(this.btncreatefolder_Click);
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(292, 37);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(161, 29);
            this.btncreatefile.TabIndex = 1;
            this.btncreatefile.Text = "create file";
            this.btncreatefile.UseVisualStyleBackColor = true;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(117, 136);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(75, 20);
            this.t.TabIndex = 2;
            this.t.Text = "productid";
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Location = new System.Drawing.Point(108, 202);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(107, 20);
            this.t2.TabIndex = 3;
            this.t2.Text = "product name";
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.Location = new System.Drawing.Point(108, 277);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(101, 20);
            this.t3.TabIndex = 4;
            this.t3.Text = "product price";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(292, 136);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(161, 26);
            this.txtid.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(292, 202);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(161, 26);
            this.txtname.TabIndex = 6;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(292, 277);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(161, 26);
            this.txtprice.TabIndex = 7;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(144, 368);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(116, 33);
            this.btnwrite.TabIndex = 8;
            this.btnwrite.Text = "write to file";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(324, 368);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(113, 33);
            this.btnread.TabIndex = 9;
            this.btnread.Text = "read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.btncreatefolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreatefolder;
        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label t2;
        private System.Windows.Forms.Label t3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
    }
}

