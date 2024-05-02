using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ThoughtsMania_1._0.Models;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ThoughtsMania_1._0.Forms
{
    public partial class FormPost : Form
    {
        public User user;
        public string path;
        public FormPost(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPost_Load(object sender, EventArgs e)
        {

            loadData();
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            // Apply bold formatting to the selected text
            if (Body.SelectionFont != null)
            {
                Font currentFont = Body.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold;
                Body.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            // Apply italic formatting to the selected text
            if (Body.SelectionFont != null)
            {
                Font currentFont = Body.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic;
                Body.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            // Show color picker dialog and apply selected color to the selected text
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Body.SelectionColor = colorDialog.Color;
            }
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            // Open file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the selected image in a PictureBox (optional)
                pictureBox1.ImageLocation = openFileDialog.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image size mode as needed
            }
            if(pictureBox1.ImageLocation != null)
            {
                SelectImageButton.Visible = false;
            }


        }

        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                // Get the selected image file path
                string sourceFilePath = pictureBox1.ImageLocation;

                // Specify the destination folder where the image will be saved
                string destinationFolder = @"C:\Users\Pratik Nichit\source\repos\ThoughtsMania_1.0\ThoughtsMania_1.0\Images\post\";

                // Create the destination folder if it doesn't exist
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                // Generate a unique file name for the saved image (optional)
                string fileName = Path.GetFileName(sourceFilePath);
                string newFilePath = Path.Combine(destinationFolder, fileName);

                // Copy the image file to the destination folder
                File.Copy(sourceFilePath, newFilePath);

                // Show a message box with the new path of the saved image
                path = newFilePath;
                MessageBox.Show("Image saved successfully.\nNew path: " + newFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadData()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var name = connection.Query<Topics>("SELECT topic_name from Topics;");
                name = name.ToList();
                List<string> list = new List<string>();
                foreach (var value in name)
                {
                    list.Add(value.topic_name);
                }

                Topic.DataSource = list;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    title = Title.Text,
                    sub_title = SubTitle.Text,
                    body = Body.Text,
                    image_path = path,
                    topic = Topic.Text,
                    user_id = user.user_id
                };
                connection.Execute("thoughts_mania.insert_into_post", parameters, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Data Uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
