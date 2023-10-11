namespace PictureBoxKontrola
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
            this.gumb = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.slika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.SuspendLayout();
            // 
            // gumb
            // 
            this.gumb.Location = new System.Drawing.Point(219, 304);
            this.gumb.Name = "gumb";
            this.gumb.Size = new System.Drawing.Size(326, 108);
            this.gumb.TabIndex = 0;
            this.gumb.Text = "slika";
            this.gumb.UseVisualStyleBackColor = true;
            this.gumb.Click += new System.EventHandler(this.gumb_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(65, 32);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(40, 13);
            this.txt.TabIndex = 1;
            this.txt.Text = "SLIKA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // slika
            // 
            this.slika.Image = global::PictureBoxKontrola.Properties.Resources.da;
            this.slika.Location = new System.Drawing.Point(219, 12);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(326, 274);
            this.slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slika.TabIndex = 3;
            this.slika.TabStop = false;
            this.slika.Visible = false;
            this.slika.Click += new System.EventHandler(this.slika_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.gumb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumb;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox slika;
    }
}

