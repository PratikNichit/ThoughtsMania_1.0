using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtsMania_1._0.Models;
using ThoughtsMania_1._0.user_contols;

namespace ThoughtsMania_1._0.Forms
{
    public partial class FormTrending : Form
    {
        private Panel panelDesktop;
        public CardData cardData;
        public FormTrending()
        {
            InitializeComponent();
        
        }

        public FormTrending(Panel panelDesktop)
        {
            InitializeComponent();
            this.panelDesktop = panelDesktop;
        }

        private void flowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormTrending_Load(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var cardData = connection.Query<CardData>("thoughts_mania.get_cards", commandType: CommandType.StoredProcedure);
                cardData = cardData.ToList();
                foreach (var data in cardData)
                {
                    this.cardData = data;
                    CardPost cardPost = new CardPost(panelDesktop, data);
                    cardPost.WritersName = data.name;
                    cardPost.dateOfPost = data.date_of_post.ToString();
                    cardPost.title = data.title;
                    cardPost.subtitle = data.sub_title;
                    cardPost.post_image = data.image_path;
                    cardPost.profileImage = data.profile_image_path;
                    cardPost.topic = data.topic;
                    flowLayout.Controls.Add(cardPost);
                }

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
