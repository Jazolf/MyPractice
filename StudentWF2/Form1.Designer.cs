namespace StudentWF2
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
            this.btnStudentCoursesCount = new System.Windows.Forms.Button();
            this.btnNameAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentCoursesCount
            // 
            this.btnStudentCoursesCount.Location = new System.Drawing.Point(32, 12);
            this.btnStudentCoursesCount.Name = "btnStudentCoursesCount";
            this.btnStudentCoursesCount.Size = new System.Drawing.Size(293, 62);
            this.btnStudentCoursesCount.TabIndex = 0;
            this.btnStudentCoursesCount.Text = "تعداد دانشجویان و دروس";
            this.btnStudentCoursesCount.UseVisualStyleBackColor = true;
            this.btnStudentCoursesCount.Click += new System.EventHandler(this.btnStudentCoursesCount_Click);
            // 
            // btnNameAverage
            // 
            this.btnNameAverage.Location = new System.Drawing.Point(32, 96);
            this.btnNameAverage.Name = "btnNameAverage";
            this.btnNameAverage.Size = new System.Drawing.Size(293, 62);
            this.btnNameAverage.TabIndex = 0;
            this.btnNameAverage.Text = "نام دانشجویان به همراه معدل";
            this.btnNameAverage.UseVisualStyleBackColor = true;
            this.btnNameAverage.Click += new System.EventHandler(this.btnNameAverage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 181);
            this.Controls.Add(this.btnNameAverage);
            this.Controls.Add(this.btnStudentCoursesCount);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دانشجو بهمراه معدل دروس";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentCoursesCount;
        private System.Windows.Forms.Button btnNameAverage;
    }
}

