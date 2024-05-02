namespace ThoughtsMania_1._0.user_contols
{
    partial class CardPost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextSubTitle = new System.Windows.Forms.TextBox();
            this.TextTitle = new System.Windows.Forms.Label();
            this.date_of_post = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.topicName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDot = new FontAwesome.Sharp.IconButton();
            this.BtnBookmark = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TextSubTitle);
            this.panel1.Controls.Add(this.TextTitle);
            this.panel1.Controls.Add(this.date_of_post);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(19, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 294);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ThoughtsMania_1._0.Properties.Resources.someone;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThoughtsMania_1._0.Properties.Resources.Screenshot_2024_04_29_231025;
            this.pictureBox1.Location = new System.Drawing.Point(692, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TextSubTitle
            // 
            this.TextSubTitle.BackColor = System.Drawing.Color.White;
            this.TextSubTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextSubTitle.Font = new System.Drawing.Font("Segoe UI Variable Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.TextSubTitle.Location = new System.Drawing.Point(15, 129);
            this.TextSubTitle.Multiline = true;
            this.TextSubTitle.Name = "TextSubTitle";
            this.TextSubTitle.ReadOnly = true;
            this.TextSubTitle.Size = new System.Drawing.Size(653, 151);
            this.TextSubTitle.TabIndex = 4;
            // 
            // TextTitle
            // 
            this.TextTitle.AutoSize = true;
            this.TextTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTitle.Location = new System.Drawing.Point(7, 82);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(394, 44);
            this.TextTitle.TabIndex = 3;
            this.TextTitle.Text = "Title For now its Just 👍";
            // 
            // date_of_post
            // 
            this.date_of_post.AutoSize = true;
            this.date_of_post.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_of_post.Location = new System.Drawing.Point(79, 32);
            this.date_of_post.Name = "date_of_post";
            this.date_of_post.Size = new System.Drawing.Size(123, 27);
            this.date_of_post.TabIndex = 2;
            this.date_of_post.Text = "date of post";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(79, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 27);
            this.name.TabIndex = 1;
            this.name.Text = "Name of the Writer";
            // 
            // topicName
            // 
            this.topicName.AutoSize = true;
            this.topicName.BackColor = System.Drawing.Color.LightGray;
            this.topicName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicName.Location = new System.Drawing.Point(29, 328);
            this.topicName.Name = "topicName";
            this.topicName.Size = new System.Drawing.Size(105, 27);
            this.topicName.TabIndex = 7;
            this.topicName.Text = "Technlogy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(26, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 1);
            this.panel2.TabIndex = 9;
            // 
            // BtnDot
            // 
            this.BtnDot.FlatAppearance.BorderSize = 0;
            this.BtnDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDot.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.BtnDot.IconColor = System.Drawing.Color.Black;
            this.BtnDot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDot.IconSize = 30;
            this.BtnDot.Location = new System.Drawing.Point(1050, 319);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(28, 36);
            this.BtnDot.TabIndex = 10;
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // BtnBookmark
            // 
            this.BtnBookmark.FlatAppearance.BorderSize = 0;
            this.BtnBookmark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnBookmark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBookmark.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.BtnBookmark.IconColor = System.Drawing.Color.Black;
            this.BtnBookmark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBookmark.IconSize = 30;
            this.BtnBookmark.Location = new System.Drawing.Point(1099, 319);
            this.BtnBookmark.Name = "BtnBookmark";
            this.BtnBookmark.Size = new System.Drawing.Size(28, 36);
            this.BtnBookmark.TabIndex = 8;
            this.BtnBookmark.UseVisualStyleBackColor = true;
            this.BtnBookmark.Click += new System.EventHandler(this.BtnBookmark_Click);
            // 
            // CardPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnBookmark);
            this.Controls.Add(this.topicName);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.Name = "CardPost";
            this.Size = new System.Drawing.Size(1158, 385);
            this.Load += new System.EventHandler(this.CardPost_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TextTitle;
        private System.Windows.Forms.Label date_of_post;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox TextSubTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label topicName;
        private FontAwesome.Sharp.IconButton BtnBookmark;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnDot;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
