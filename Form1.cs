using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace Kramp.gg
{
    
    public partial class Form1 : Form
    {
        public Point mouseLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://raw.githubusercontent.com/SixxyWare/Get-Kramp-Key-Free-/main/Get%20Kramp%20Key%20FREE");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
    }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (Key2342.Text == "Krampgetaseuws219")
            {
                Form3 f1 = new Form3();
                f1.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Invalid Key Code Please Get The Right Key .gg/kramp.gg");
                Key2342.Clear();
                Key2342.Focus();
            }

        }

        private void Key2342_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/XMtNR4Ng");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }
    }
}
