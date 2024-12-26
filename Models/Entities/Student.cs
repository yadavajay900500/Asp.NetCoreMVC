namespace ASP_Net_Core_MVC.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EmailId { get; set; }
        public bool Subcrived { get; set; }

    }
}
