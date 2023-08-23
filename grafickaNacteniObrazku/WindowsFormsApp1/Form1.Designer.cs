namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayImage = new System.Windows.Forms.Button();
            this.displayImageInWindow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayImageInWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // displayImage
            // 
            this.displayImage.Location = new System.Drawing.Point(298, 353);
            this.displayImage.Name = "displayImage";
            this.displayImage.Size = new System.Drawing.Size(152, 52);
            this.displayImage.TabIndex = 1;
            this.displayImage.Text = "showImage";
            this.displayImage.UseVisualStyleBackColor = true;
            this.displayImage.Click += new System.EventHandler(this.displayImage_Click);
            // 
            // displayImageInWindow
            // 
            this.displayImageInWindow.Location = new System.Drawing.Point(160, 46);
            this.displayImageInWindow.Name = "displayImageInWindow";
            this.displayImageInWindow.Size = new System.Drawing.Size(445, 276);
            this.displayImageInWindow.TabIndex = 2;
            this.displayImageInWindow.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayImageInWindow);
            this.Controls.Add(this.displayImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.displayImageInWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayImage;
        private System.Windows.Forms.PictureBox displayImageInWindow;
    }
}

