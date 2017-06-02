namespace BarberEric_CE03
{
    partial class AboutForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Items.AddRange(new object[] {
            "About the game",
            "    The game of tic tack toe id an extremely complex game where it requires",
            "extreme thought processes in order to be able to win the game. The goal of the ga" +
                "me",
            "is to get 3 of your selected pieces in a row to win the round.",
            "",
            "How is it played?",
            "\t1. Select who is what peice.",
            "\t2. Determine who will go first each round/ Alternate (players choice)",
            "\t3. Click and hold the tile and drag into place once the tile is located over a ",
            "\t\tdesired location on the board release the mouse and your turn ",
            "\t\tis over and recorded.",
            "\t4. Other players turn repeat step 3 untill game is complete. ",
            "Conclusion",
            "\tAfter the game is completed the board will clear and the winner of the round ",
            "will be recorded in the bottom left of the games menu. If you would like to resta" +
                "rt the",
            "scoreboard click file new game. Then continue as before. Of course, the option of" +
                " player",
            "vs. computer is a paid option so it is not visible to users as at this time."});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1218, 811);
            this.listBox1.TabIndex = 0;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 811);
            this.Controls.Add(this.listBox1);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}