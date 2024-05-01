using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtsMania_1._0.user_contols;

namespace ThoughtsMania_1._0.Forms
{
    public partial class FormExplore : Form
    {
        private Panel panelDesktop;

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
            flowLayoutForButton.FlowDirection = FlowDirection.LeftToRight;
            for (int i= 0; i <= 5; i++)
            {
                  CardPost cardPost = new CardPost(panelDesktop);
                   flowPanel.Controls.Add(cardPost);
            }
            loadButtonTopics();
        }

        private void loadButtonTopics()
        {
            for(int i = 0; i <= 60; i++)
            {
                ExploreButton button = new ExploreButton();
                flowLayoutForButton.Controls.Add(button);
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
