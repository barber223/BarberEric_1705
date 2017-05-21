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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Xwins = new System.Windows.Forms.NumericUpDown();
            this.Owins = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xwins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Owins)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(51, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1108, 760);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn9
            // 
            this.btn9.AllowDrop = true;
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn9.Location = new System.Drawing.Point(844, 521);
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
            this.btn8.Location = new System.Drawing.Point(612, 521);
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
            this.btn7.Location = new System.Drawing.Point(381, 521);
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
            this.btn6.Location = new System.Drawing.Point(844, 291);
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
            this.btn5.Location = new System.Drawing.Point(612, 291);
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
            this.btn4.Location = new System.Drawing.Point(381, 291);
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
            this.btn3.Location = new System.Drawing.Point(844, 64);
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
            this.btn2.Location = new System.Drawing.Point(612, 64);
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
            this.btn1.Location = new System.Drawing.Point(381, 62);
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
            this.pictureBox1.Location = new System.Drawing.Point(343, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 750);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "TicTacToeBoard-02.jpg");
            this.imageList1.Images.SetKeyName(1, "TicTacToeBoard-03.jpg");
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
            // Xwins
            // 
            this.Xwins.Enabled = false;
            this.Xwins.Location = new System.Drawing.Point(158, 560);
            this.Xwins.Name = "Xwins";
            this.Xwins.ReadOnly = true;
            this.Xwins.Size = new System.Drawing.Size(120, 31);
            this.Xwins.TabIndex = 12;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1198, 811);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xwins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Owins)).EndInit();
            this.ResumeLayout(false);

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
    }
}

