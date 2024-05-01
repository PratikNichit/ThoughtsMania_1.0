using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace ThoughtsMania_1._0.user_contols
{
    public partial class CardPost : UserControl
    {
        // Field
        private Panel panelDesktop;
        private Form currentChildForm;
        private bool isPressed = false;
        public CardPost()
        {
            InitializeComponent();
        }

        public CardPost(Panel panelDesktop)
        {
            InitializeComponent();
            this.panelDesktop = panelDesktop;
        }

        [Category("Extra Properties")]
        private string WritersName { get; set;}

        [Category("Extra Properties")]
        private DateTime dateOfPost {  get; set;}

        [Category("Extra Properties")]
        private string profileImage {  get; set;}

        [Category("Extra Properties")]
        private string title {  get; set;}

        [Category("Extra Properties")]
        private string subtitle { get; set;}

        [Category("Extra Properties")]
        private string topic { get; set;}


        private void CardPost_Load(object sender, EventArgs e)
        {
            string text = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. \r\nExcepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.gg";

            TextSubTitle.Text = text;
            TextSubTitle.ScrollBars = ScrollBars.None; 
        }

        private void BtnBookmark_Click(object sender, EventArgs e)
        {
            if(isPressed == false)
            {
                BtnBookmark.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
                isPressed = true;
            }
            else
            {
                BtnBookmark.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
                isPressed = false;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            openChidForm(new Forms.FormViewPost());
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
    }
}
