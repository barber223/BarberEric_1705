namespace BarberEric_CE02
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
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbextension = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail2 = new System.Windows.Forms.TextBox();
            this.txtemail1 = new System.Windows.Forms.TextBox();
            this.lblspacer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Spaces = new System.Windows.Forms.Label();
            this.txtphone2 = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblfirst = new System.Windows.Forms.Label();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.largeIcon = new System.Windows.Forms.ImageList(this.components);
            this.smallIcon = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Contacts = new System.Windows.Forms.ListBox();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cmbextension);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtemail2);
            this.groupBox1.Controls.Add(this.txtemail1);
            this.groupBox1.Controls.Add(this.lblspacer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Spaces);
            this.groupBox1.Controls.Add(this.txtphone2);
            this.groupBox1.Controls.Add(this.txtPhone1);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblphone);
            this.groupBox1.Controls.Add(this.lblLast);
            this.groupBox1.Controls.Add(this.lblfirst);
            this.groupBox1.Controls.Add(this.lvUsers);
            this.groupBox1.Location = new System.Drawing.Point(12, 1219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 1334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(369, 331);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 60);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(201, 331);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 60);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(34, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 60);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbextension
            // 
            this.cmbextension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbextension.FormattingEnabled = true;
            this.cmbextension.Items.AddRange(new object[] {
            ".net",
            ".com",
            ".edu"});
            this.cmbextension.Location = new System.Drawing.Point(465, 266);
            this.cmbextension.Name = "cmbextension";
            this.cmbextension.Size = new System.Drawing.Size(98, 33);
            this.cmbextension.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 18;
            // 
            // txtemail2
            // 
            this.txtemail2.Location = new System.Drawing.Point(338, 266);
            this.txtemail2.Name = "txtemail2";
            this.txtemail2.Size = new System.Drawing.Size(121, 31);
            this.txtemail2.TabIndex = 17;
            // 
            // txtemail1
            // 
            this.txtemail1.Location = new System.Drawing.Point(153, 266);
            this.txtemail1.Name = "txtemail1";
            this.txtemail1.Size = new System.Drawing.Size(158, 31);
            this.txtemail1.TabIndex = 16;
            // 
            // lblspacer
            // 
            this.lblspacer.AutoSize = true;
            this.lblspacer.Location = new System.Drawing.Point(309, 269);
            this.lblspacer.Name = "lblspacer";
            this.lblspacer.Size = new System.Drawing.Size(33, 25);
            this.lblspacer.TabIndex = 14;
            this.lblspacer.Text = "@";
            // 
            // label3
            // 
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(391, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(269, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 41);
            this.label2.TabIndex = 12;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(249, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = ")";
            // 
            // Spaces
            // 
            this.Spaces.Enabled = false;
            this.Spaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spaces.Location = new System.Drawing.Point(146, 196);
            this.Spaces.Name = "Spaces";
            this.Spaces.Size = new System.Drawing.Size(19, 48);
            this.Spaces.TabIndex = 10;
            this.Spaces.Text = "(";
            // 
            // txtphone2
            // 
            this.txtphone2.Location = new System.Drawing.Point(416, 202);
            this.txtphone2.MaxLength = 4;
            this.txtphone2.Name = "txtphone2";
            this.txtphone2.Size = new System.Drawing.Size(114, 31);
            this.txtphone2.TabIndex = 9;
            this.txtphone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(299, 203);
            this.txtPhone1.MaxLength = 3;
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(90, 31);
            this.txtPhone1.TabIndex = 8;
            this.txtPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(171, 202);
            this.txtArea.MaxLength = 3;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(72, 31);
            this.txtArea.TabIndex = 7;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(153, 149);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(312, 31);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(152, 95);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(313, 31);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(80, 269);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(21, 207);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(130, 25);
            this.lblphone.TabIndex = 3;
            this.lblphone.Text = "Phone Num:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(29, 155);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(127, 25);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Last Name: ";
            // 
            // lblfirst
            // 
            this.lblfirst.AutoSize = true;
            this.lblfirst.Location = new System.Drawing.Point(29, 101);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(122, 25);
            this.lblfirst.TabIndex = 1;
            this.lblfirst.Text = "First Name:";
            // 
            // lvUsers
            // 
            this.lvUsers.LargeImageList = this.largeIcon;
            this.lvUsers.Location = new System.Drawing.Point(569, 35);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(544, 392);
            this.lvUsers.SmallImageList = this.smallIcon;
            this.lvUsers.TabIndex = 0;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvUsers_MouseDoubleClick);
            // 
            // largeIcon
            // 
            this.largeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeIcon.ImageStream")));
            this.largeIcon.Tag = "https://upload.wikimedia.org/wikipedia/commons/e/e4/Elliot_Grieveson.png";
            this.largeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.largeIcon.Images.SetKeyName(0, "icn for users.png");
            // 
            // smallIcon
            // 
            this.smallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallIcon.ImageStream")));
            this.smallIcon.Tag = "https://upload.wikimedia.org/wikipedia/commons/e/e4/Elliot_Grieveson.png";
            this.smallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.smallIcon.Images.SetKeyName(0, "icn for users.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeToolStripMenuItem,
            this.smallToolStripMenuItem});
            this.viewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Checked = true;
            this.largeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.largeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // Contacts
            // 
            this.Contacts.FormattingEnabled = true;
            this.Contacts.ItemHeight = 25;
            this.Contacts.Location = new System.Drawing.Point(5, 48);
            this.Contacts.Name = "Contacts";
            this.Contacts.Size = new System.Drawing.Size(718, 1204);
            this.Contacts.TabIndex = 2;
            // 
            // btnAddPage
            // 
            this.btnAddPage.Location = new System.Drawing.Point(8, 1064);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(342, 187);
            this.btnAddPage.TabIndex = 3;
            this.btnAddPage.Text = "Add";
            this.btnAddPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 1263);
            this.Controls.Add(this.btnAddPage);
            this.Controls.Add(this.Contacts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbextension;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail2;
        private System.Windows.Forms.TextBox txtemail1;
        private System.Windows.Forms.Label lblspacer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Spaces;
        private System.Windows.Forms.TextBox txtphone2;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblfirst;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ImageList largeIcon;
        private System.Windows.Forms.ImageList smallIcon;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ListBox Contacts;
        private System.Windows.Forms.Button btnAddPage;
    }
}

