namespace burakAydemirFinalProject
{
    partial class frmLurePhoto
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
            this.pbLure = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLure)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLure
            // 
            this.pbLure.Location = new System.Drawing.Point(12, 12);
            this.pbLure.Name = "pbLure";
            this.pbLure.Size = new System.Drawing.Size(598, 415);
            this.pbLure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLure.TabIndex = 1;
            this.pbLure.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(266, 437);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmLurePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(622, 473);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbLure);
            this.Name = "frmLurePhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image";
            this.Load += new System.EventHandler(this.frmLurePhoto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbLure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLure;
        private System.Windows.Forms.Button btnClose;
    }
}