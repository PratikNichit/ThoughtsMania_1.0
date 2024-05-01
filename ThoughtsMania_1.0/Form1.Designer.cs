using System.Windows.Shapes;

namespace ThoughtsMania_1._0
{
    partial class Form1
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
            this.NavBar = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.BtnProfile = new FontAwesome.Sharp.IconButton();
            this.BtnTrending = new FontAwesome.Sharp.IconButton();
            this.BtnExplore = new FontAwesome.Sharp.IconButton();
            this.BtnPost = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(23)))));
            this.NavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavBar.Controls.Add(this.BtnProfile);
            this.NavBar.Controls.Add(this.BtnTrending);
            this.NavBar.Controls.Add(this.BtnExplore);
            this.NavBar.Controls.Add(this.BtnPost);
            this.NavBar.Controls.Add(this.LogoLabel);
            this.NavBar.Controls.Add(this.Logo);
            this.NavBar.Controls.Add(this.panel2);
            this.NavBar.Controls.Add(this.panel1);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1564, 90);
            this.NavBar.TabIndex = 0;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.Location = new System.Drawing.Point(179, 26);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(223, 37);
            this.LogoLabel.TabIndex = 4;
            this.LogoLabel.Text = "ThoughtsMania";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1489, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 88);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 88);
            this.panel1.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1564, 781);
            this.panelDesktop.TabIndex = 3;
            // 
            // BtnProfile
            // 
            this.BtnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProfile.BackColor = System.Drawing.Color.Transparent;
            this.BtnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProfile.FlatAppearance.BorderSize = 0;
            this.BtnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfile.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfile.ForeColor = System.Drawing.Color.Black;
            this.BtnProfile.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnProfile.IconColor = System.Drawing.Color.Black;
            this.BtnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProfile.Location = new System.Drawing.Point(1059, 22);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(97, 40);
            this.BtnProfile.TabIndex = 7;
            this.BtnProfile.Text = "Profile";
            this.BtnProfile.UseVisualStyleBackColor = false;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // BtnTrending
            // 
            this.BtnTrending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTrending.BackColor = System.Drawing.Color.Transparent;
            this.BtnTrending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTrending.FlatAppearance.BorderSize = 0;
            this.BtnTrending.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnTrending.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnTrending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrending.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrending.ForeColor = System.Drawing.Color.Black;
            this.BtnTrending.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnTrending.IconColor = System.Drawing.Color.Black;
            this.BtnTrending.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTrending.Location = new System.Drawing.Point(1153, 22);
            this.BtnTrending.Name = "BtnTrending";
            this.BtnTrending.Size = new System.Drawing.Size(106, 40);
            this.BtnTrending.TabIndex = 6;
            this.BtnTrending.Text = "Trending";
            this.BtnTrending.UseVisualStyleBackColor = false;
            this.BtnTrending.Click += new System.EventHandler(this.BtnTrending_Click);
            // 
            // BtnExplore
            // 
            this.BtnExplore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExplore.BackColor = System.Drawing.Color.Transparent;
            this.BtnExplore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExplore.FlatAppearance.BorderSize = 0;
            this.BtnExplore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnExplore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExplore.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExplore.ForeColor = System.Drawing.Color.Black;
            this.BtnExplore.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnExplore.IconColor = System.Drawing.Color.Black;
            this.BtnExplore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExplore.Location = new System.Drawing.Point(1265, 22);
            this.BtnExplore.Name = "BtnExplore";
            this.BtnExplore.Size = new System.Drawing.Size(97, 40);
            this.BtnExplore.TabIndex = 5;
            this.BtnExplore.Text = "Explore";
            this.BtnExplore.UseVisualStyleBackColor = false;
            this.BtnExplore.Click += new System.EventHandler(this.BtnExplore_Click);
            // 
            // BtnPost
            // 
            this.BtnPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPost.BackColor = System.Drawing.Color.Black;
            this.BtnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPost.FlatAppearance.BorderSize = 0;
            this.BtnPost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnPost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPost.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPost.ForeColor = System.Drawing.Color.White;
            this.BtnPost.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnPost.IconColor = System.Drawing.Color.Black;
            this.BtnPost.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPost.Location = new System.Drawing.Point(1386, 22);
            this.BtnPost.Name = "BtnPost";
            this.BtnPost.Size = new System.Drawing.Size(97, 40);
            this.BtnPost.TabIndex = 3;
            this.BtnPost.Text = "Post";
            this.BtnPost.UseVisualStyleBackColor = false;
            this.BtnPost.Click += new System.EventHandler(this.BtnPost_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::ThoughtsMania_1._0.Properties.Resources.image_final1;
            this.Logo.Location = new System.Drawing.Point(80, 10);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(98, 75);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1564, 871);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thoughts Mania";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label LogoLabel;
        private FontAwesome.Sharp.IconButton BtnPost;
        private FontAwesome.Sharp.IconButton BtnExplore;
        private FontAwesome.Sharp.IconButton BtnProfile;
        private FontAwesome.Sharp.IconButton BtnTrending;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

