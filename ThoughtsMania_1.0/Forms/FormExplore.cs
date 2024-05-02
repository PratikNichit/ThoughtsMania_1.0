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
    public partial class FormExplore : Form
    {
        private Panel panelDesktop;
        public CardData cardData;

        public FormExplore()
        {
            InitializeComponent();
        }

        public FormExplore(Panel panelDesktop)
        {
            InitializeComponent();
            this.panelDesktop = panelDesktop;
            flowLayoutForButton.AutoScroll = true;
        }


        private void FormExplore_Load(object sender, EventArgs e)
        {

            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var cardData = connection.Query<CardData>("thoughts_mania.get_cards", commandType: CommandType.StoredProcedure);
                cardData = cardData.ToList();
                foreach(var data in cardData)
                {
                    this.cardData= data;
                    CardPost cardPost = new CardPost(panelDesktop,data);
                    cardPost.WritersName = data.name;
                    cardPost.dateOfPost = data.date_of_post.ToString();
                    cardPost.title = data.title;
                    cardPost.subtitle = data.sub_title;
                    cardPost.post_image = data.image_path;
                    cardPost.profileImage = data.profile_image_path;
                    cardPost.topic = data.topic;
                    flowPanel.Controls.Add(cardPost);
                }
            }
                flowLayoutForButton.FlowDirection = FlowDirection.LeftToRight;
            loadButtonTopics();
        }

        private void loadButtonTopics()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var topics = connection.Query<Topics>("thoughts_mania.get_topics_name", commandType: CommandType.StoredProcedure);
                topics = topics.ToList();
                foreach (var data in topics)
                {
                    ExploreButton button = new ExploreButton(flowLayoutForButton,cardData);
                    button.name = data.topic_name;
                    flowLayoutForButton.Controls.Add(button);
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // Define the amount to scroll (in pixels)
            int scrollAmount = 500; // Adjust as needed

            // Get the current scroll position
            int currentScrollPosition = flowLayoutForButton.HorizontalScroll.Value;

            // Calculate the new scroll position
            int newScrollPosition = currentScrollPosition + scrollAmount;

            // Ensure the new scroll position is within bounds
            newScrollPosition = Math.Min(newScrollPosition, flowLayoutForButton.HorizontalScroll.Maximum);

            // Scroll the FlowLayoutPanel to the new position
            flowLayoutForButton.HorizontalScroll.Value = newScrollPosition;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            // Define the amount to scroll backward (in pixels)
            int scrollAmount = 500; // Adjust as needed

            // Get the current scroll position
            int currentScrollPosition = flowLayoutForButton.HorizontalScroll.Value;

            // Calculate the new scroll position (scrolling backward)
            int newScrollPosition = currentScrollPosition - scrollAmount;

            // Ensure the new scroll position is within bounds
            newScrollPosition = Math.Max(newScrollPosition, flowLayoutForButton.HorizontalScroll.Minimum);

            // Scroll the FlowLayoutPanel to the new position
            flowLayoutForButton.HorizontalScroll.Value = newScrollPosition;

        }
    }
}
