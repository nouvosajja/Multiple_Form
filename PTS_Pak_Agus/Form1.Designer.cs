namespace PTS_Pak_Agus
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lbljudul = new System.Windows.Forms.Label();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.lblnama = new System.Windows.Forms.Label();
            this.cmbumur = new System.Windows.Forms.ComboBox();
            this.lblumur = new System.Windows.Forms.Label();
            this.rblaki = new System.Windows.Forms.RadioButton();
            this.rbperempuan = new System.Windows.Forms.RadioButton();
            this.lbljenis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(129, 351);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(107, 59);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(293, 351);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(107, 59);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lbljudul
            // 
            this.lbljudul.AutoSize = true;
            this.lbljudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljudul.Location = new System.Drawing.Point(194, 19);
            this.lbljudul.Name = "lbljudul";
            this.lbljudul.Size = new System.Drawing.Size(185, 29);
            this.lbljudul.TabIndex = 3;
            this.lbljudul.Text = "Data Pendaftar";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(230, 95);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(226, 22);
            this.tbnama.TabIndex = 4;
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnama.Location = new System.Drawing.Point(126, 93);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(61, 22);
            this.lblnama.TabIndex = 5;
            this.lblnama.Text = "Nama";
            // 
            // cmbumur
            // 
            this.cmbumur.FormattingEnabled = true;
            this.cmbumur.Location = new System.Drawing.Point(230, 141);
            this.cmbumur.Name = "cmbumur";
            this.cmbumur.Size = new System.Drawing.Size(135, 24);
            this.cmbumur.TabIndex = 6;
            // 
            // lblumur
            // 
            this.lblumur.AutoSize = true;
            this.lblumur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblumur.Location = new System.Drawing.Point(130, 139);
            this.lblumur.Name = "lblumur";
            this.lblumur.Size = new System.Drawing.Size(57, 22);
            this.lblumur.TabIndex = 7;
            this.lblumur.Text = "Umur";
            // 
            // rblaki
            // 
            this.rblaki.AutoSize = true;
            this.rblaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblaki.Location = new System.Drawing.Point(230, 207);
            this.rblaki.Name = "rblaki";
            this.rblaki.Size = new System.Drawing.Size(101, 24);
            this.rblaki.TabIndex = 8;
            this.rblaki.TabStop = true;
            this.rblaki.Text = "Laki-laki";
            this.rblaki.UseVisualStyleBackColor = true;
            this.rblaki.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbperempuan
            // 
            this.rbperempuan.AutoSize = true;
            this.rbperempuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbperempuan.Location = new System.Drawing.Point(345, 207);
            this.rbperempuan.Name = "rbperempuan";
            this.rbperempuan.Size = new System.Drawing.Size(124, 24);
            this.rbperempuan.TabIndex = 9;
            this.rbperempuan.TabStop = true;
            this.rbperempuan.Text = "Perempuan";
            this.rbperempuan.UseVisualStyleBackColor = true;
            // 
            // lbljenis
            // 
            this.lbljenis.AutoSize = true;
            this.lbljenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljenis.Location = new System.Drawing.Point(53, 209);
            this.lbljenis.Name = "lbljenis";
            this.lbljenis.Size = new System.Drawing.Size(134, 22);
            this.lbljenis.TabIndex = 10;
            this.lbljenis.Text = "Jenis Kelamin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.lbljenis);
            this.Controls.Add(this.rbperempuan);
            this.Controls.Add(this.rblaki);
            this.Controls.Add(this.lblumur);
            this.Controls.Add(this.cmbumur);
            this.Controls.Add(this.lblnama);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.lbljudul);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnlogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lbljudul;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.ComboBox cmbumur;
        private System.Windows.Forms.Label lblumur;
        private System.Windows.Forms.RadioButton rblaki;
        private System.Windows.Forms.RadioButton rbperempuan;
        private System.Windows.Forms.Label lbljenis;
    }
}

