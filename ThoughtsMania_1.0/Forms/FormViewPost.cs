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
using ThoughtsMania_1._0.Models;

namespace ThoughtsMania_1._0.Forms
{
    public partial class FormViewPost : Form
    {
        private CardData cardData;
        public FormViewPost(CardData cardData)
        {
            InitializeComponent();
            this.cardData = cardData;
        }

        private void FormViewPost_Load(object sender, EventArgs e)
        {
            TextTitle.Text = cardData.title;
            Profile_image.ImageLocation = cardData.profile_image_path;
            name.Text = cardData.name;
            date_of_post.Text = cardData.date_of_post.ToString();
            TextSubTitle.Text = cardData.sub_title;
            ImagePost.ImageLocation = cardData.image_path;
            body.Text = cardData.body;
        }
    }
}
