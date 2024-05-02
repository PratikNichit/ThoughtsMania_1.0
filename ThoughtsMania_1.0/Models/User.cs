using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoughtsMania_1._0.Models
{
    public class User
    {
        public int user_id {  get; set; }
        public string email_id { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string profile_image_path { get; set; }
    }
}
