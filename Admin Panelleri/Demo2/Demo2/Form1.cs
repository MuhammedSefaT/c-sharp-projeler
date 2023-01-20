using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        Eğitim amaçlı yapılmıştır.Kötüye kullanımda hiçbir sorumluluk kabul etmiyorum.
        Github : https://www.github.com/MuhammedSefaT Takip edin :D
        Başarılar dilerim.Kolay gelsin.
        */

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cvp = MessageBox.Show("Çıkış Yapılsın mı?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == cvp)
                {
                    Application.Exit();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                guna2PictureBox2.Image = Image.FromFile(@"..\..\Resources\1.jpg");
                guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                guna2PictureBox2.Image = Image.FromFile(@"..\..\Resources\2.jpg");
                guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {
                guna2PictureBox2.Image = Image.FromFile(@"..\..\Resources\3.jpg");
                guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            try
            {
                guna2PictureBox2.Image = Image.FromFile(@"..\..\Resources\4.jpg");
                guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //checkBox işaretli ise
                if (guna2CustomCheckBox1.Checked)
                {
                    //karakteri göster.
                    guna2TextBox2.PasswordChar = '\0';
                }
                //değilse karakterlerin yerine * koy.
                else
                {
                    guna2TextBox2.PasswordChar = '*';
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //checkBox işaretli ise
                if (guna2CustomCheckBox1.Checked)
                {
                    //karakteri göster.
                    guna2TextBox2.PasswordChar = '\0';
                }
                //değilse karakterlerin yerine * koy.
                else
                {
                    guna2TextBox2.PasswordChar = '*';
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
