using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using cloudyapi;
using TheArtOfDevHtmlRenderer.Adapters;
namespace Kramp.gg
{
    public partial class Form3 : Form
    {
        public Point mouseLocation;
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            cloudyapi.ExploitApi.Execute(Editor.Text);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            switch (cloudyapi.ExploitApi.Inject(Application.StartupPath + "\\bin\\api\\CeleryInject.exe", true, false))
            { 

case cloudyapi.InjectionStatus.SUCCESS:
                    //MessageBox.Show("Attached");
                    label3.ForeColor = Color.Green;
                    label3.Text = "Injected";
                break;
            case cloudyapi.InjectionStatus.ALREADY_INJECTED:
                MessageBox.Show("Attached");
                break;
            case cloudyapi.InjectionStatus.ALREADY_INJECTING:
                MessageBox.Show("Attaching");
                break;
            case cloudyapi.InjectionStatus.FAILED:
                    // MessageBox.Show("Not Attached");
                    label3.ForeColor = Color.Red;
                break;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                Editor.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form2 Options = new Form2();
            Options.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
          Form4 Options = new Form4();
            Options.Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            cloudyapi.ExploitApi.QuitRoblox();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
