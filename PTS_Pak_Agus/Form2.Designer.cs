namespace PTS_Pak_Agus
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
            this.btnback = new System.Windows.Forms.Button();
            this.lblnamalengkap = new System.Windows.Forms.Label();
            this.lblumur = new System.Windows.Forms.Label();
            this.lbljeniskelamin = new System.Windows.Forms.Label();
            this.lblhasilnama = new System.Windows.Forms.Label();
            this.lblhasilumur = new System.Windows.Forms.Label();
            this.lblhasiljenis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(215, 292);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 59);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // lblnamalengkap
            // 
            this.lblnamalengkap.AutoSize = true;
            this.lblnamalengkap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamalengkap.Location = new System.Drawing.Point(56, 103);
            this.lblnamalengkap.Name = "lblnamalengkap";
            this.lblnamalengkap.Size = new System.Drawing.Size(143, 22);
            this.lblnamalengkap.TabIndex = 3;
            this.lblnamalengkap.Text = "Nama Lengkap";
            // 
            // lblumur
            // 
            this.lblumur.AutoSize = true;
            this.lblumur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblumur.Location = new System.Drawing.Point(56, 149);
            this.lblumur.Name = "lblumur";
            this.lblumur.Size = new System.Drawing.Size(57, 22);
            this.lblumur.TabIndex = 5;
            this.lblumur.Text = "Umur";
            // 
            // lbljeniskelamin
            // 
            this.lbljeniskelamin.AutoSize = true;
            this.lbljeniskelamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljeniskelamin.Location = new System.Drawing.Point(56, 191);
            this.lbljeniskelamin.Name = "lbljeniskelamin";
            this.lbljeniskelamin.Size = new System.Drawing.Size(134, 22);
            this.lbljeniskelamin.TabIndex = 6;
            this.lbljeniskelamin.Text = "Jenis Kelamin";
            // 
            // lblhasilnama
            // 
            this.lblhasilnama.AutoSize = true;
            this.lblhasilnama.Location = new System.Drawing.Point(249, 108);
            this.lblhasilnama.Name = "lblhasilnama";
            this.lblhasilnama.Size = new System.Drawing.Size(104, 16);
            this.lblhasilnama.TabIndex = 7;
            this.lblhasilnama.Text = "<namalengkap>";
            // 
            // lblhasilumur
            // 
            this.lblhasilumur.AutoSize = true;
            this.lblhasilumur.Location = new System.Drawing.Point(249, 153);
            this.lblhasilumur.Name = "lblhasilumur";
            this.lblhasilumur.Size = new System.Drawing.Size(50, 16);
            this.lblhasilumur.TabIndex = 8;
            this.lblhasilumur.Text = "<umur>";
            this.lblhasilumur.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblhasiljenis
            // 
            this.lblhasiljenis.AutoSize = true;
            this.lblhasiljenis.Location = new System.Drawing.Point(249, 195);
            this.lblhasiljenis.Name = "lblhasiljenis";
            this.lblhasiljenis.Size = new System.Drawing.Size(96, 16);
            this.lblhasiljenis.TabIndex = 9;
            this.lblhasiljenis.Text = "<jeniskelamin>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pendaftar";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblhasiljenis);
            this.Controls.Add(this.lblhasilumur);
            this.Controls.Add(this.lblhasilnama);
            this.Controls.Add(this.lbljeniskelamin);
            this.Controls.Add(this.lblumur);
            this.Controls.Add(this.lblnamalengkap);
            this.Controls.Add(this.btnback);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblnamalengkap;
        private System.Windows.Forms.Label lblumur;
        private System.Windows.Forms.Label lbljeniskelamin;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblhasilnama;
        public System.Windows.Forms.Label lblhasilumur;
        public System.Windows.Forms.Label lblhasiljenis;
    }
}