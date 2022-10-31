namespace ToDo.DataAccess.Models
{
    public class ToDoItem
    {
        public string task { get; set;}
        public string description { get; set; }
        public string status { get; set; }
        public string category { get; set; }
        public string priority { get; set; }
        public DateTime deadline { get; set; }
        public DateTime createDate { get; set; }
        public DateTime lastUpdateDate { get; set; }


    }
}
