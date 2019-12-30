using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reklamcılık_Otomasyonu
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {
            adsScreen form = new adsScreen();
            BringForm(form);
        }

        private void BringForm(Form form)
        {
            panelForms.Controls.Clear();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            panelForms.Controls.Add(form);
            form.Show();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            clientsScreen form = new clientsScreen();
            BringForm(form);
        }

        private void adsButton_Click(object sender, EventArgs e)
        {
            adsScreen form = new adsScreen();
            BringForm(form);
        }

        private void pubButton_Click(object sender, EventArgs e)
        {
            publicationsScreen form = new publicationsScreen();
            BringForm(form);
        }
    }
}
