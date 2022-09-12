using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTS_Pak_Agus
{
    public partial class Form1 : Form
    {
        string nama;
        string umur;
        string jeniskelamin;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            nama = this.tbnama.Text.ToString();
            umur = cmbumur.SelectedItem.ToString();

            if (rblaki.Checked)
                jeniskelamin = "Laki - laki";
            else if (rbperempuan.Checked)
                jeniskelamin = "Perempuan";

            Form2 f2 = new Form2();

            f2.lblhasilnama.Text = nama;
            f2.lblhasilumur.Text = umur;
            f2.lblhasiljenis.Text = jeniskelamin;

            f2.Show();
            this.Visible = false;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                Application.Exit();           }
            else
            {
                // Do something  
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 18; i < 36; i++)
            {
                cmbumur.Items.Add(i.ToString());
            }
        }
    }
}
