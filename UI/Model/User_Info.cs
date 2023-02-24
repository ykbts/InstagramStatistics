using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{

    public class User_Info
    {
        public User_Info2 response { get; set; }

    }
    public class User_Info2
    {
        public body body { get; set; }

    }
    public class body
    {
        public data data { get; set; }
        public users user { get; set; }
    }
    public class data
    {
        public users user { get; set; }
    }
    public class users
    {
        public edge_followed_by edge_followed_by { get; set; }
        public edge_follow edge_follow { get; set; }
        public string id { get; set; }
        public string profile_pic_url_hd { get; set; }
        public string username { get; set; }


    }
    public class edge_followed_by
    {
        public int count { get; set; }
    }
    public class edge_follow
    {
        public int count { get; set; }
    }

}











