using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThoughtsMania_1._0
{
    public partial class Form1 : Form
    {
        //fields
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
            openChidForm(new Forms.FormHomePage());
        }

        public void openChidForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnExplore_Click(object sender, EventArgs e)
        {
            openChidForm(new Forms.FormExplore(panelDesktop));
        }

        private void BtnTrending_Click(object sender, EventArgs e)
        {
            openChidForm(new Forms.FormTrending());
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            openChidForm(new Forms.FormProfile());
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            openChidForm(new Forms.FormHomePage());
        }

        private void BtnPost_Click(object sender, EventArgs e)
        {
            openChidForm(new Forms.FormPost());
        }
    }
}
