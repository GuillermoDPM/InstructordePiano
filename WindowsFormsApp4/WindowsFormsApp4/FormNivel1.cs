using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormNivel1 : Form
    {
        public FormNivel1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics partitura1;
            partitura1 = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);

            partitura1.DrawLine(lapiz, 100, 160, 100, 280);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
