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
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            //tạo nút gốc
            TreeNode root = new TreeNode("Danh sách liên hệ", 0, 0);
            root.Tag = 0;
            //tạo các nút con
            TreeNode gd = new TreeNode("Gia đình", 1, 1);
            gd.Tag = 1;
            TreeNode bb = new TreeNode("Bạn bè", 1, 1);
            bb.Tag = 2;
            TreeNode cq = new TreeNode("Cơ quan", 1, 1);
            cq.Tag = 3;
            //thêm nút con vào nút gốc
            root.Nodes.Add(gd);
            root.Nodes.Add(bb);
            root.Nodes.Add(cq);
            //thêm nút gốc vào cây
            trvGroup.Nodes.Add(root);
            trvGroup.ExpandAll();
        }

        private void trvGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //xóa dữ liệu cũ
            lstContact.Items.Clear();
            //lấy nút được chọn
            TreeNode Node = e.Node;
            if (Node.Tag.ToString().Equals("1"))
            {
                //Tạo một listview item
                ListViewItem contact1 = new ListViewItem(new string[] { "Nguyễn Văn A", "09/10/1982", "abc@gmail.com", "0987657886" }, 2);
                ListViewItem contact2 = new ListViewItem(new string[] { "Nguyễn Văn B", "20/06/1987", "teo@gmail.com", "098556454" }, 2);
                ListViewItem contact3 = new ListViewItem(new string[] { "Nguyễn Văn C", "23/06/1989", "ty@gmail.com", "098896547" }, 2);
                //thêm item vào listview
                lstContact.Items.Add(contact1);
                lstContact.Items.Add(contact2);
                lstContact.Items.Add(contact3);
            }
            if (Node.Tag.ToString().Equals("2"))
            {
                //Tạo một listview item
                ListViewItem contact1 = new ListViewItem(new string[] { "Nguyễn Văn D", "09/10/1982", "abc@gmail.com", "0987657886" }, 2);
                ListViewItem contact2 = new ListViewItem(new string[] { "Nguyễn Văn E", "20/06/1987", "teo@gmail.com", "098556454" }, 2);
                ListViewItem contact3 = new ListViewItem(new string[] { "Nguyễn Văn F", "23/06/1989", "ty@gmail.com", "098896547" }, 2);
                //thêm item vào listview
                lstContact.Items.Add(contact1);
                lstContact.Items.Add(contact2);
                lstContact.Items.Add(contact3);
            }
        }

        private void lstContact_Click(object sender, EventArgs e)
        {
            //khai báo biến chuỗi chứa thông tin khi chọn 1 liên hệ
            SelectedListViewItemCollection collection = lstContact.SelectedItems;

            //nếu có liên hệ được chọn thì lấy thông tin chi tiết
            if (collection.Count > 0)
            {
                //hiển thị thông tin chi tiết
                frmEdit form2 = new frmEdit();
                form2.collection = collection;
                form2.ShowDialog();

                lstContact.SelectedItems[0].Text = form2.collection[0].Text;
                lstContact.SelectedItems[0].SubItems[1].Text = form2.collection[0].SubItems[1].Text;
                lstContact.SelectedItems[0].SubItems[2].Text = form2.collection[0].SubItems[2].Text;
                lstContact.SelectedItems[0].SubItems[3].Text = form2.collection[0].SubItems[3].Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
