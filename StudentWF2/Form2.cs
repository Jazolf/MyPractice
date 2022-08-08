using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWF2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInsertStudentCount_Click(object sender, EventArgs e)
        {
            if (nmrStudentCount.Value != 0)
            {
                lboxStudentCount.Items.Add(nmrStudentCount.Value);
            }
            else
            {
                MessageBox.Show("تعداد دانشجویان را وارد نمایید");
            }

        }

        private void btnInsertCoursesCount_Click(object sender, EventArgs e)
        {
            if (nmrCoursesCount.Value != 0)
            {
                lboxCoursesCount.Items.Add(nmrCoursesCount.Value);
            }
            else
            {
                MessageBox.Show("تعداد دروس را وارد نمایید");
            }


        }
        public int StudentCount { get; set; }
        public int CoursesCount { get; set; }
        public Form2(int studentCount, int coursesCount)
        {
            InitializeComponent();
            StudentCount = studentCount;
            CoursesCount = coursesCount;
        }

    }
}
