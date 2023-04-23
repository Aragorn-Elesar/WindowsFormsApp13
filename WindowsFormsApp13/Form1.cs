using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        MenuStrip m;
        ToolStripMenuItem file;
        public Form1()
        {
            InitializeComponent();
            m = new MenuStrip();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            file = (ToolStripMenuItem)m.Items.Add(textBox1.Text);
            this.MainMenuStrip = m;
            this.Controls.Add(m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           ToolStripMenuItem f = (ToolStripMenuItem)file.DropDownItems.Add(textBox2.Text);
        }
    }
}
