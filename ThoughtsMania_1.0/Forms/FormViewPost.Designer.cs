namespace ThoughtsMania_1._0.Forms
{
    partial class FormViewPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewPost));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ImagePost = new System.Windows.Forms.PictureBox();
            this.body = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.Label();
            this.date_of_post = new System.Windows.Forms.Label();
            this.Profile_image = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextSubTitle = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_image)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 1036);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1035, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 1036);
            this.panel2.TabIndex = 1;
            // 
            // TextTitle
            // 
            this.TextTitle.BackColor = System.Drawing.Color.White;
            this.TextTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextTitle.Font = new System.Drawing.Font("Segoe UI Variable Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTitle.Location = new System.Drawing.Point(0, 0);
            this.TextTitle.Multiline = true;
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.ReadOnly = true;
            this.TextTitle.Size = new System.Drawing.Size(527, 129);
            this.TextTitle.TabIndex = 2;
            this.TextTitle.Text = "Advice From a Software Engineer With 8 Years of Experience";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TextTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(508, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 129);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.TextSubTitle);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(508, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 189);
            this.panel4.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ImagePost);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(508, 318);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(527, 422);
            this.panel8.TabIndex = 5;
            // 
            // ImagePost
            // 
            this.ImagePost.BackColor = System.Drawing.Color.DimGray;
            this.ImagePost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePost.Location = new System.Drawing.Point(0, 0);
            this.ImagePost.Name = "ImagePost";
            this.ImagePost.Size = new System.Drawing.Size(527, 422);
            this.ImagePost.TabIndex = 0;
            this.ImagePost.TabStop = false;
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.White;
            this.body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.body.Dock = System.Windows.Forms.DockStyle.Top;
            this.body.Font = new System.Drawing.Font("Segoe UI Variable Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body.Location = new System.Drawing.Point(508, 740);
            this.body.Name = "body";
            this.body.ReadOnly = true;
            this.body.Size = new System.Drawing.Size(527, 296);
            this.body.TabIndex = 6;
            this.body.Text = resources.GetString("body.Text");
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(83, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 27);
            this.name.TabIndex = 8;
            this.name.Text = "Name of the Writer";
            // 
            // date_of_post
            // 
            this.date_of_post.AutoSize = true;
            this.date_of_post.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_of_post.Location = new System.Drawing.Point(83, 38);
            this.date_of_post.Name = "date_of_post";
            this.date_of_post.Size = new System.Drawing.Size(123, 27);
            this.date_of_post.TabIndex = 9;
            this.date_of_post.Text = "date of post";
            // 
            // Profile_image
            // 
            this.Profile_image.Image = global::ThoughtsMania_1._0.Properties.Resources.someone;
            this.Profile_image.Location = new System.Drawing.Point(0, 6);
            this.Profile_image.Name = "Profile_image";
            this.Profile_image.Size = new System.Drawing.Size(77, 72);
            this.Profile_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile_image.TabIndex = 10;
            this.Profile_image.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Profile_image);
            this.panel5.Controls.Add(this.date_of_post);
            this.panel5.Controls.Add(this.name);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(527, 84);
            this.panel5.TabIndex = 0;
            // 
            // TextSubTitle
            // 
            this.TextSubTitle.BackColor = System.Drawing.Color.White;
            this.TextSubTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextSubTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextSubTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSubTitle.Location = new System.Drawing.Point(0, 84);
            this.TextSubTitle.Multiline = true;
            this.TextSubTitle.Name = "TextSubTitle";
            this.TextSubTitle.ReadOnly = true;
            this.TextSubTitle.Size = new System.Drawing.Size(527, 105);
            this.TextSubTitle.TabIndex = 1;
            this.TextSubTitle.Text = "My name is Benoit. I have been a software engineer for the past eight and a half " +
    "years. I stayed at my previous (and first) company for seven and a half years, t" +
    "hen I joined a new one in early 2022.";
            // 
            // FormViewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1564, 871);
            this.Controls.Add(this.body);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormViewPost";
            this.Text = "FormViewPost";
            this.Load += new System.EventHandler(this.FormViewPost_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_image)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox ImagePost;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox Profile_image;
        private System.Windows.Forms.Label date_of_post;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox TextSubTitle;
    }
}