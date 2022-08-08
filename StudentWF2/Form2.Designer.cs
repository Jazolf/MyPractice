namespace StudentWF2
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
            this.label1 = new System.Windows.Forms.Label();
            this.nmrStudentCount = new System.Windows.Forms.NumericUpDown();
            this.btnInsertStudentCount = new System.Windows.Forms.Button();
            this.lboxStudentCount = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrCoursesCount = new System.Windows.Forms.NumericUpDown();
            this.btnInsertCoursesCount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lboxCoursesCount = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStudentCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCoursesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "تعداد دانشجویان را وارد نمایید:";
            // 
            // nmrStudentCount
            // 
            this.nmrStudentCount.Location = new System.Drawing.Point(97, 23);
            this.nmrStudentCount.Name = "nmrStudentCount";
            this.nmrStudentCount.Size = new System.Drawing.Size(76, 23);
            this.nmrStudentCount.TabIndex = 1;
            // 
            // btnInsertStudentCount
            // 
            this.btnInsertStudentCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertStudentCount.Location = new System.Drawing.Point(12, 23);
            this.btnInsertStudentCount.Name = "btnInsertStudentCount";
            this.btnInsertStudentCount.Size = new System.Drawing.Size(75, 25);
            this.btnInsertStudentCount.TabIndex = 2;
            this.btnInsertStudentCount.Text = "اضافه کن";
            this.btnInsertStudentCount.UseVisualStyleBackColor = true;
            this.btnInsertStudentCount.Click += new System.EventHandler(this.btnInsertStudentCount_Click);
            // 
            // lboxStudentCount
            // 
            this.lboxStudentCount.FormattingEnabled = true;
            this.lboxStudentCount.ItemHeight = 16;
            this.lboxStudentCount.Location = new System.Drawing.Point(12, 63);
            this.lboxStudentCount.Name = "lboxStudentCount";
            this.lboxStudentCount.Size = new System.Drawing.Size(161, 20);
            this.lboxStudentCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "تعداد دانشجویان:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "تعداد دروس را وارد نمایید:";
            // 
            // nmrCoursesCount
            // 
            this.nmrCoursesCount.Location = new System.Drawing.Point(97, 109);
            this.nmrCoursesCount.Name = "nmrCoursesCount";
            this.nmrCoursesCount.Size = new System.Drawing.Size(76, 23);
            this.nmrCoursesCount.TabIndex = 6;
            // 
            // btnInsertCoursesCount
            // 
            this.btnInsertCoursesCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCoursesCount.Location = new System.Drawing.Point(12, 108);
            this.btnInsertCoursesCount.Name = "btnInsertCoursesCount";
            this.btnInsertCoursesCount.Size = new System.Drawing.Size(73, 23);
            this.btnInsertCoursesCount.TabIndex = 7;
            this.btnInsertCoursesCount.Text = "اضافه کن";
            this.btnInsertCoursesCount.UseVisualStyleBackColor = true;
            this.btnInsertCoursesCount.Click += new System.EventHandler(this.btnInsertCoursesCount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "تعداد دروس:";
            // 
            // lboxCoursesCount
            // 
            this.lboxCoursesCount.FormattingEnabled = true;
            this.lboxCoursesCount.ItemHeight = 16;
            this.lboxCoursesCount.Location = new System.Drawing.Point(12, 151);
            this.lboxCoursesCount.Name = "lboxCoursesCount";
            this.lboxCoursesCount.Size = new System.Drawing.Size(161, 20);
            this.lboxCoursesCount.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 194);
            this.Controls.Add(this.lboxCoursesCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInsertCoursesCount);
            this.Controls.Add(this.nmrCoursesCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lboxStudentCount);
            this.Controls.Add(this.btnInsertStudentCount);
            this.Controls.Add(this.nmrStudentCount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعداد دانشجویان و دروس";
            ((System.ComponentModel.ISupportInitialize)(this.nmrStudentCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCoursesCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrStudentCount;
        private System.Windows.Forms.Button btnInsertStudentCount;
        private System.Windows.Forms.ListBox lboxStudentCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrCoursesCount;
        private System.Windows.Forms.Button btnInsertCoursesCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lboxCoursesCount;
    }
}