namespace  BlazorApp1 {
    
    public class JobListing
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Salary { get; set; }

        public List<Application> Applications { get; set; } = new List<Application>();
    }
}
