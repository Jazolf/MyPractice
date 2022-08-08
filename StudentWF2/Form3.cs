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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnInsertFullName_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text != "")
            {
                lboxFullName.Items.Add(txtFullName.Text);
            }
            else
            {
                MessageBox.Show("نام دانشجو را وارد نمایید");
            }
        }
    }
}
