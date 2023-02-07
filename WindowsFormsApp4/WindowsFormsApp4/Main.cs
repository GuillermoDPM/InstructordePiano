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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelHomeSubmenu.Visible = false;
            panelHerramientasSubmenu.Visible = false;
            frmAprender1.Visible = false;
            frmPiezas1.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelHomeSubmenu.Visible == true)
                panelHomeSubmenu.Visible = false;
            if (panelHerramientasSubmenu.Visible == true)
                panelHerramientasSubmenu.Visible = false;

        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHomeSubmenu);
            

        }

        private void btnAprender_Click(object sender, EventArgs e)
        {

            frmPiezas1.Hide();
            frmAprender1.Show();
            frmAprender1.BringToFront();

            //..
            // klk
            //..
            hideSubMenu();

        }

        private void btnPiezas_Click(object sender, EventArgs e)
        {
            frmAprender1.Hide();
            frmPiezas1.Show();
            frmPiezas1.BringToFront();
            //..
            // klk
            //..
            hideSubMenu();
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            //..
            // klk
            //..
            hideSubMenu();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelHomeSubmenu);

        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHerramientasSubmenu);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
