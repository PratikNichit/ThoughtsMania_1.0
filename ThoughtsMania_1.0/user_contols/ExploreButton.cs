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

namespace ThoughtsMania_1._0.user_contols
{
    public partial class ExploreButton : UserControl
    {
        public FlowLayoutPanel flowLayoutPanel;
        public CardData data;
        public ExploreButton(FlowLayoutPanel flowLayoutPanel,CardData data)
        {
            InitializeComponent();
            this.flowLayoutPanel = flowLayoutPanel;
            this.data = data;
        }

        [Category("Extra Properties")]
        public string topicName
        {
            get
            {
                return topicName;
            }
            set
            {
                topicName = value;
            }
        }

        [Category("Extra Properties")]
        public string name
        {
            get
            {
                return button.Text; 
            }
            set
            {
                button.Text = value;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
        }
    }
}
