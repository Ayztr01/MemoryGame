
namespace MemoryGame
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblMemoryGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(99, 227);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 44);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayerName.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(94, 128);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(148, 29);
            this.lblPlayerName.TabIndex = 8;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.Color.White;
            this.txtPlayerName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtPlayerName.Location = new System.Drawing.Point(66, 160);
            this.txtPlayerName.MaxLength = 15;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(199, 31);
            this.txtPlayerName.TabIndex = 6;
            this.txtPlayerName.TabStop = false;
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPlayerName.DoubleClick += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPlayerName.Enter += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPlayerName.MouseEnter += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMemoryGame
            // 
            this.lblMemoryGame.AutoSize = true;
            this.lblMemoryGame.BackColor = System.Drawing.Color.Transparent;
            this.lblMemoryGame.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoryGame.ForeColor = System.Drawing.Color.White;
            this.lblMemoryGame.Location = new System.Drawing.Point(60, 60);
            this.lblMemoryGame.Name = "lblMemoryGame";
            this.lblMemoryGame.Size = new System.Drawing.Size(231, 31);
            this.lblMemoryGame.TabIndex = 12;
            this.lblMemoryGame.Text = "MEMORY GAME";
            // 
            // Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(348, 333);
            this.Controls.Add(this.lblMemoryGame);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(364, 372);
            this.MinimumSize = new System.Drawing.Size(364, 372);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblMemoryGame;
    }
}

