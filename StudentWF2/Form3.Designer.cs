namespace StudentWF2
{
    partial class Form3
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnInsertFullName = new System.Windows.Forms.Button();
            this.lboxFullName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی دانشجو را وارد نمایید:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(124, 57);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(294, 23);
            this.txtFullName.TabIndex = 1;
            // 
            // btnInsertFullName
            // 
            this.btnInsertFullName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFullName.Location = new System.Drawing.Point(12, 57);
            this.btnInsertFullName.Name = "btnInsertFullName";
            this.btnInsertFullName.Size = new System.Drawing.Size(97, 23);
            this.btnInsertFullName.TabIndex = 2;
            this.btnInsertFullName.Text = " اضافه کن";
            this.btnInsertFullName.UseVisualStyleBackColor = true;
            this.btnInsertFullName.Click += new System.EventHandler(this.btnInsertFullName_Click);
            // 
            // lboxFullName
            // 
            this.lboxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxFullName.FormattingEnabled = true;
            this.lboxFullName.ItemHeight = 16;
            this.lboxFullName.Location = new System.Drawing.Point(12, 102);
            this.lboxFullName.Name = "lboxFullName";
            this.lboxFullName.Size = new System.Drawing.Size(406, 228);
            this.lboxFullName.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 357);
            this.Controls.Add(this.lboxFullName);
            this.Controls.Add(this.btnInsertFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نام دانشجویان";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnInsertFullName;
        private System.Windows.Forms.ListBox lboxFullName;
    }
}