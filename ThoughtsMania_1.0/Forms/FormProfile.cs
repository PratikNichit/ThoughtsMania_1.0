using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using ThoughtsMania_1._0.Models;
using ThoughtsMania_1._0.user_contols;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ThoughtsMania_1._0.Forms
{
    public partial class FormProfile : Form
    {
        public User user;
        public string newPath;
        private Panel panelDesktop;
        public CardData cardData;
        public FormProfile(User user,Panel panelDesktop)
        {
            InitializeComponent();
            this.user = user;
            this.panelDesktop = panelDesktop;
            
        }

        private void LabelProfile_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the selected image in a PictureBox (optional)
                Profile_picture.ImageLocation = openFileDialog.FileName;
                Profile_picture.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image size mode as needed
            }
        }

        private void SaveIt_Click(object sender, EventArgs e)
        {
            if (Profile_picture.Image != null)
            {
                // Get the selected image file path
                string sourceFilePath = Profile_picture.ImageLocation;

                // Specify the destination folder where the image will be saved
                string destinationFolder = @"C:\Users\Pratik Nichit\source\repos\ThoughtsMania_1.0\ThoughtsMania_1.0\Images\Profile_picture\";

                // Create the destination folder if it doesn't exist
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                // Generate a unique file name for the saved image (optional)
                string fileName = System.IO.Path.GetFileName(sourceFilePath);
                string newFilePath = System.IO.Path.Combine(destinationFolder, fileName);

                // Copy the image file to the destination folder
                File.Copy(sourceFilePath, newFilePath);

                // Show a message box with the new path of the saved image
                newPath = newFilePath;
                MessageBox.Show("Image saved successfully.\nNew path: " + newFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { id = user.user_id };
                var Picture = connection.Query<ProfilePicture>("thoughts_mania.get_user_data", parameters, commandType: CommandType.StoredProcedure);
                Picture = Picture.ToList();

                foreach (var profile in Picture)
                {
                    Profile_picture.ImageLocation = profile.profile_image_path;
                    Profile_picture.SizeMode = PictureBoxSizeMode.Zoom;
                }

                TextEmail.Text = user.email_id;
                TextName.Text = user.name;
            }

        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    email = TextEmail.Text,
                    user_name = TextName.Text,
                    path = newPath,
                    id = user.user_id
                };
                connection.Execute("thoughts_mania.update_user_data", parameters, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Data Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loadMyPost()
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
                    flowLayoutPanel1.Controls.Add(cardPost);
                }

            }
        }

        private void BtnMyPost_Click(object sender, EventArgs e)
        {
            loadMyPost();
        }
    }
}
