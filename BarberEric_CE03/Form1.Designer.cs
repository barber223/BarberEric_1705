namespace BarberEric_CE03
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
            this.btnO = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Owins = new System.Windows.Forms.NumericUpDown();
            this.Xwins = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Owins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xwins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnO
            // 
            this.btnO.BackgroundImage = global::BarberEric_CE03.Properties.Resources.TicTacToeBoard_03;
            this.btnO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnO.Location = new System.Drawing.Point(102, 336);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(203, 199);
            this.btnO.TabIndex = 2;
            this.btnO.Text = "o";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnO_MouseDown);
            // 
            // btnX
            // 
            this.btnX.BackgroundImage = global::BarberEric_CE03.Properties.Resources.TicTacToeBoard_02;
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnX.Location = new System.Drawing.Point(102, 92);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(203, 199);
            this.btnX.TabIndex = 1;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnX_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.Owins);
            this.groupBox1.Controls.Add(this.Xwins);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(51, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1108, 744);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Owins
            // 
            this.Owins.Enabled = false;
            this.Owins.Location = new System.Drawing.Point(158, 608);
            this.Owins.Name = "Owins";
            this.Owins.ReadOnly = true;
            this.Owins.Size = new System.Drawing.Size(120, 31);
            this.Owins.TabIndex = 13;
            // 
            // Xwins
            // 
            this.Xwins.Enabled = false;
            this.Xwins.Location = new System.Drawing.Point(158, 560);
            this.Xwins.Name = "Xwins";
            this.Xwins.ReadOnly = true;
            this.Xwins.Size = new System.Drawing.Size(120, 31);
            this.Xwins.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "O wins: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "X wins: ";
            // 
            // btn9
            // 
            this.btn9.AllowDrop = true;
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn9.Location = new System.Drawing.Point(844, 505);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(213, 203);
            this.btn9.TabIndex = 9;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn9_DragDrop);
            this.btn9.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn1_DragEnter);
            // 
            // btn8
            // 
            this.btn8.AllowDrop = true;
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn8.Location = new System.Drawing.Point(612, 505);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(213, 203);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn8_DragDrop);
            this.btn8.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn1_DragEnter);
            // 
            // btn7
            // 
            this.btn7.AllowDrop = true;
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7.Location = new System.Drawing.Point(381, 505);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(213, 203);
            this.btn7.TabIndex = 7;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn7_DragDrop);
            this.btn7.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn1_DragEnter);
            // 
            // btn6
            // 
            this.btn6.AllowDrop = true;
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.Location = new System.Drawing.Point(844, 273);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(213, 203);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn6_DragDrop);
            this.btn6.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn1_DragEnter);
            // 
            // btn5
            // 
            this.btn5.AllowDrop = true;
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.Location = new System.Drawing.Point(612, 273);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(213, 203);
            this.btn5.TabIndex = 5;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn5_DragDrop);
            this.btn5.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn1_DragEnter);
            // 
            // btn4
            // 
            this.btn4.AllowDrop = true;
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.Location = new System.Drawing.Point(381, 273);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(213, 203);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn4_DragDrop);
            this.btn4.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn1_DragEnter);
            // 
            // btn3
            // 
            this.btn3.AllowDrop = true;
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.Location = new System.Drawing.Point(844, 48);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(213, 203);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn3_DragDrop);
            this.btn3.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn1_DragEnter);
            // 
            // btn2
            // 
            this.btn2.AllowDrop = true;
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.Location = new System.Drawing.Point(612, 48);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(213, 203);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn2_DragDrop);
            this.btn2.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn1_DragEnter);
            // 
            // btn1
            // 
            this.btn1.AllowDrop = true;
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Location = new System.Drawing.Point(381, 46);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(213, 203);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.DragDrop += new System.Windows.Forms.DragEventHandler(this.btn1_DragDrop);
            this.btn1.DragEnter += new System.Windows.Forms.DragEventHandler(this.btn1_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BarberEric_CE03.Properties.Resources.TicTacToeBoard_01;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(343, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 750);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(3, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1102, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "TicTacToeBoard-02.jpg");
            this.imageList1.Images.SetKeyName(1, "TicTacToeBoard-03.jpg");
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Location = new System.Drawing.Point(0, 42);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1198, 42);
            this.menuStrip3.TabIndex = 4;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.playerVsComputerToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(89, 38);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Checked = true;
            this.playerVsPlayerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.playerVsPlayerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(327, 38);
            this.playerVsPlayerToolStripMenuItem.Text = "Player vs. Player";
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.playerVsPlayerToolStripMenuItem_Click);
            // 
            // playerVsComputerToolStripMenuItem
            // 
            this.playerVsComputerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.playerVsComputerToolStripMenuItem.Name = "playerVsComputerToolStripMenuItem";
            this.playerVsComputerToolStripMenuItem.Size = new System.Drawing.Size(327, 38);
            this.playerVsComputerToolStripMenuItem.Text = "Player vs. Computer";
            this.playerVsComputerToolStripMenuItem.Click += new System.EventHandler(this.playerVsComputerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1198, 811);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Owins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xwins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Owins;
        private System.Windows.Forms.NumericUpDown Xwins;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

