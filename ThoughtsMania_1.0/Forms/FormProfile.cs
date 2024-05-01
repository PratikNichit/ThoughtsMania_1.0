using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThoughtsMania_1._0.Forms
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
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
                string fileName = Path.GetFileName(sourceFilePath);
                string newFilePath = Path.Combine(destinationFolder, fileName);

                // Copy the image file to the destination folder
                File.Copy(sourceFilePath, newFilePath);

                // Show a message box with the new path of the saved image
                MessageBox.Show("Image saved successfully.\nNew path: " + newFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
