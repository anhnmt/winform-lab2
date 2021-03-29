using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace WF_Lab2
{

    public partial class frmEdit : Form
    {
        //khai báo biến chuỗi chứa thông tin khi chọn 1 liên hệ
        public SelectedListViewItemCollection collection;

        public frmEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            collection[0].Text = txtName.Text;
            collection[0].SubItems[1].Text = txtBirthday.Text;
            collection[0].SubItems[2].Text = txtEmail.Text;
            collection[0].SubItems[3].Text = txtPhone.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            txtName.Text = collection[0].Text;
            txtBirthday.Text = collection[0].SubItems[1].Text;
            txtEmail.Text = collection[0].SubItems[2].Text;
            txtPhone.Text = collection[0].SubItems[3].Text;
        }
    }
}
