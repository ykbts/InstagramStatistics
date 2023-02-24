using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace  UI.Model
{
    public class Data
    {
        public string end_cursor { get; set; }
        public Collector[] collector { get; set; }

    }
    public class Collector
    {
        public string username { get; set; }
        public string id { get; set; }


    }
   
}