using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThoughtsMania_1._0.user_contols
{
    public partial class ExploreButton : UserControl
    {
        public ExploreButton()
        {
            InitializeComponent();
        }

        [Category("Extra Properties")]
        public string topicName
        {
            get
            {
                return topicName.ToString(); ;
            }
            set
            {
                topicName = value.ToString();
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
                button.Text = value.ToString();
            }
        }
    }
}
