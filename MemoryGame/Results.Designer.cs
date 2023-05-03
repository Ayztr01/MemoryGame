
namespace MemoryGame
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMismatch = new System.Windows.Forms.Label();
            this.txtMismatch = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(47, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 33);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtName.Location = new System.Drawing.Point(53, 179);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(204, 27);
            this.txtName.TabIndex = 10;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(97, 83);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(121, 31);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "RESULT";
            // 
            // lblMismatch
            // 
            this.lblMismatch.AutoSize = true;
            this.lblMismatch.BackColor = System.Drawing.Color.Transparent;
            this.lblMismatch.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMismatch.ForeColor = System.Drawing.Color.White;
            this.lblMismatch.Location = new System.Drawing.Point(48, 227);
            this.lblMismatch.Name = "lblMismatch";
            this.lblMismatch.Size = new System.Drawing.Size(128, 33);
            this.lblMismatch.TabIndex = 17;
            this.lblMismatch.Text = "Mismatch";
            // 
            // txtMismatch
            // 
            this.txtMismatch.BackColor = System.Drawing.Color.White;
            this.txtMismatch.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtMismatch.Location = new System.Drawing.Point(53, 263);
            this.txtMismatch.MaxLength = 20;
            this.txtMismatch.Name = "txtMismatch";
            this.txtMismatch.ReadOnly = true;
            this.txtMismatch.Size = new System.Drawing.Size(204, 27);
            this.txtMismatch.TabIndex = 16;
            this.txtMismatch.TabStop = false;
            this.txtMismatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(47, 309);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 33);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "Time:";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.White;
            this.txtTime.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtTime.Location = new System.Drawing.Point(53, 345);
            this.txtTime.MaxLength = 20;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(204, 27);
            this.txtTime.TabIndex = 18;
            this.txtTime.TabStop = false;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(311, 439);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblMismatch);
            this.Controls.Add(this.txtMismatch);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(327, 478);
            this.MinimumSize = new System.Drawing.Size(327, 478);
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMismatch;
        private System.Windows.Forms.TextBox txtMismatch;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
    }
}