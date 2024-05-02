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
using ThoughtsMania_1._0.Models;

namespace ThoughtsMania_1._0.user_contols
{
    public partial class CardPost : UserControl
    {
        // Field
        private Panel panelDesktop;
        private Form currentChildForm;
        private bool isPressed = false;
        private CardData carddata;
        public CardPost()
        {
            InitializeComponent();
        }

        public CardPost(Panel panelDesktop, CardData carddata)
        {
            InitializeComponent();
            this.panelDesktop = panelDesktop;
            this.carddata = carddata;
        }

        [Category("Extra Properties")]
        public string WritersName
        {
            get
            {
                return name.Text;
            }
            set
            {
                name.Text = value;
            }
        }

        [Category("Extra Properties")]
        public string dateOfPost
        {
            get
            {
                return date_of_post.Text.ToString();
            }
            set
            {
                date_of_post.Text = value;
            }
        }

        [Category("Extra Properties")]
        public string profileImage
        {
            get
            {
                return pictureBox2.ImageLocation.ToString();
            }
            set
            {
                pictureBox2.ImageLocation = value;
            }
        }

        [Category("Extra Properties")]
        public string title
        {
            get 
            {
                return TextTitle.Text;
            }
            set
            {
                TextTitle.Text = value;
            }
        }

        [Category("Extra Properties")]
        public string subtitle
        {
            get
            {
                return TextSubTitle.Text;
            }
            set
            {
                TextSubTitle.Text = value;
            }
        }

        [Category("Extra Properties")]
        public string topic
        {
            get
            {
                return topicName.Text;
            }
            set
            {
                topicName.Text = value;
            }
        }


        [Category("Extra Properties")]
        public string post_image
        {
            get
            {
                return pictureBox1.ImageLocation.ToString();
            }
            set
            {
                pictureBox1.ImageLocation = value;
            }
        }


        private void CardPost_Load(object sender, EventArgs e)
        { 
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
            openChidForm(new Forms.FormViewPost(carddata));
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
