using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ThoughtsMania_1._0.Forms
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            CenterPanel();
        }

        private void CenterPanel()
        {

        }

        private void MyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Calculate the center of the form
            int panelX = (this.ClientSize.Width - MyPanel.Width) / 2;
            int panelY = (this.ClientSize.Height - MyPanel.Height) / 2;

            // Set the panel's location
            MyPanel.Location = new System.Drawing.Point(panelX, panelY);
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void Link_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyPanel.Visible = false;
            // Calculate the center of the form
            int panelX = (this.ClientSize.Width - PanelSign.Width) / 2;
            int panelY = (this.ClientSize.Height - PanelSign.Height) / 2;

            // Set the panel's location
            PanelSign.Location = new System.Drawing.Point(panelX, panelY);

        }
    }
}
