namespace MemoryGame
{
    partial class HomePage
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
            this.btnGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMemoryGame = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Transparent;
            this.btnGame.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.Location = new System.Drawing.Point(108, 168);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(223, 59);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "PLAY";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(108, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 59);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMemoryGame
            // 
            this.lblMemoryGame.AutoSize = true;
            this.lblMemoryGame.BackColor = System.Drawing.Color.Transparent;
            this.lblMemoryGame.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoryGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMemoryGame.Location = new System.Drawing.Point(115, 76);
            this.lblMemoryGame.Name = "lblMemoryGame";
            this.lblMemoryGame.Size = new System.Drawing.Size(204, 39);
            this.lblMemoryGame.TabIndex = 3;
            this.lblMemoryGame.Text = "Memory Game";
            this.lblMemoryGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(108, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "ABOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(12, 12);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(21, 33);
            this.txtPlayerName.TabIndex = 5;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 471);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMemoryGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGame);
            this.Name = "HomePage";
            this.Text = "Memory Gmae";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMemoryGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPlayerName;
    }
}