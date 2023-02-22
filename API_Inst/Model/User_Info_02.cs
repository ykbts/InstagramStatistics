namespace API_Inst.Model
{
    public class User_Info02
    {
        public User_Info002 response { get; set; }

    }
    public class User_Info002
    {
        public body1 body { get; set; }

    }
    public class body1
    {
        public users02 user { get; set; }
    }
    public class users02
    {

        public string pk { get; set; }
        public string username { get; set; }
    }

}