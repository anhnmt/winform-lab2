
namespace WF_Lab2
{
    partial class frmContact
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvGroup = new System.Windows.Forms.TreeView();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.lstContact = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Panel2.Controls.Add(this.lstContact);
            this.splitContainer1.Size = new System.Drawing.Size(777, 302);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
            // 
            // trvGroup
            // 
            this.trvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvGroup.ImageIndex = 0;
            this.trvGroup.ImageList = this.imgIcon;
            this.trvGroup.Location = new System.Drawing.Point(0, 0);
            this.trvGroup.Name = "trvGroup";
            this.trvGroup.SelectedImageIndex = 0;
            this.trvGroup.Size = new System.Drawing.Size(260, 261);
            this.trvGroup.TabIndex = 0;
            this.trvGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvGroup_AfterSelect);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "icons8-contact-details-24.png");
            this.imgIcon.Images.SetKeyName(1, "icons8-user-group-24.png");
            this.imgIcon.Images.SetKeyName(2, "icons8-account-24.png");
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(427, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstContact
            // 
            this.lstContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstContact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.birthday,
            this.mail,
            this.phone});
            this.lstContact.HideSelection = false;
            this.lstContact.Location = new System.Drawing.Point(3, 0);
            this.lstContact.Name = "lstContact";
            this.lstContact.Size = new System.Drawing.Size(511, 261);
            this.lstContact.SmallImageList = this.imgIcon;
            this.lstContact.TabIndex = 0;
            this.lstContact.UseCompatibleStateImageBehavior = false;
            this.lstContact.View = System.Windows.Forms.View.Details;
            this.lstContact.SelectedIndexChanged += new System.EventHandler(this.lstContact_SelectedIndexChanged);
            this.lstContact.Click += new System.EventHandler(this.lstContact_Click);
            // 
            // name
            // 
            this.name.Text = "Họ và tên";
            this.name.Width = 176;
            // 
            // birthday
            // 
            this.birthday.Text = "Ngày sinh";
            this.birthday.Width = 99;
            // 
            // mail
            // 
            this.mail.Text = "Hòm thư";
            this.mail.Width = 75;
            // 
            // phone
            // 
            this.phone.Text = "Điện thoại";
            this.phone.Width = 130;
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 302);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmContact";
            this.Text = "Thông tin liên hệ";
            this.Load += new System.EventHandler(this.frmContact_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvGroup;
        private System.Windows.Forms.ListView lstContact;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader birthday;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.Button btnExit;
    }
}

