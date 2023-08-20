namespace Folders1
{
    partial class Form2
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnjsonread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(261, 291);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(161, 26);
            this.txtPrice.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(261, 170);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 26);
            this.txtName.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(261, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 26);
            this.txtId.TabIndex = 11;
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.Location = new System.Drawing.Point(77, 294);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(101, 20);
            this.t3.TabIndex = 10;
            this.t3.Text = "product price";
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Location = new System.Drawing.Point(77, 173);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(107, 20);
            this.t2.TabIndex = 9;
            this.t2.Text = "product name";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(86, 48);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(75, 20);
            this.t.TabIndex = 8;
            this.t.Text = "productid";
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Location = new System.Drawing.Point(538, 117);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(99, 33);
            this.btnbinarywrite.TabIndex = 14;
            this.btnbinarywrite.Text = "binary write";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(674, 117);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(114, 33);
            this.btnbinaryread.TabIndex = 15;
            this.btnbinaryread.Text = "binary read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Location = new System.Drawing.Point(538, 192);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(99, 33);
            this.btnxmlwrite.TabIndex = 16;
            this.btnxmlwrite.Text = "xml write";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            // 
            // btnxmlread
            // 
            this.btnxmlread.Location = new System.Drawing.Point(674, 192);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(114, 33);
            this.btnxmlread.TabIndex = 17;
            this.btnxmlread.Text = "xml read";
            this.btnxmlread.UseVisualStyleBackColor = true;
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Location = new System.Drawing.Point(538, 282);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(99, 35);
            this.btnsoapwrite.TabIndex = 18;
            this.btnsoapwrite.Text = "soap write";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            // 
            // btnsoapread
            // 
            this.btnsoapread.Location = new System.Drawing.Point(674, 282);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(114, 35);
            this.btnsoapread.TabIndex = 19;
            this.btnsoapread.Text = "soap read";
            this.btnsoapread.UseVisualStyleBackColor = true;
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(538, 353);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(99, 33);
            this.btnjsonwrite.TabIndex = 20;
            this.btnjsonwrite.Text = "json write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            // 
            // btnjsonread
            // 
            this.btnjsonread.Location = new System.Drawing.Point(674, 353);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(114, 33);
            this.btnjsonread.TabIndex = 21;
            this.btnjsonread.Text = "json read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjsonread);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnsoapread);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnxmlread);
            this.Controls.Add(this.btnxmlwrite);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label t3;
        private System.Windows.Forms.Label t2;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnjsonread;
    }
}