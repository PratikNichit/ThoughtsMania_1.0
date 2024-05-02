using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoughtsMania_1._0.Models
{
    public class CardData
    {
        public string name {  get; set; }
        public string profile_image_path { get; set; }
        public string title { get; set; }
        public string sub_title { get; set; }
        public string image_path { get; set; }
        public DateTime date_of_post { get; set; }
        public string topic;
        public string body;

    }
}
