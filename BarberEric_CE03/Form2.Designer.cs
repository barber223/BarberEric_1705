namespace BarberEric_CE03
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
            this.Choose = new System.Windows.Forms.Label();
            this.PlayerSelction = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Choose
            // 
            this.Choose.AutoSize = true;
            this.Choose.Location = new System.Drawing.Point(58, 76);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(151, 25);
            this.Choose.TabIndex = 0;
            this.Choose.Text = "Select X or O: ";
            // 
            // PlayerSelction
            // 
            this.PlayerSelction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerSelction.FormattingEnabled = true;
            this.PlayerSelction.Items.AddRange(new object[] {
            "X",
            "O"});
            this.PlayerSelction.Location = new System.Drawing.Point(270, 73);
            this.PlayerSelction.Name = "PlayerSelction";
            this.PlayerSelction.Size = new System.Drawing.Size(121, 33);
            this.PlayerSelction.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(132, 140);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(187, 73);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 237);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.PlayerSelction);
            this.Controls.Add(this.Choose);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Choose;
        private System.Windows.Forms.ComboBox PlayerSelction;
        private System.Windows.Forms.Button btnOk;
    }
}