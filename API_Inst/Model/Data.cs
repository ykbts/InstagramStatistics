namespace API_Inst.Model
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
