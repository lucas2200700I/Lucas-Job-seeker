namespace BlazorApp1 {
  public class JobListingService
{
    private static List<JobListing> jobListings = new List<JobListing>();

    public List<JobListing> GetJobListings()
    {
        return jobListings;
    }

    public void AddJobListing(JobListing jobListing)
    {
        jobListings.Add(jobListing);
    }

    public JobListing GetJobListingById(int jobId)
        {
            return jobListings.FirstOrDefault(job => job.Id == jobId);
        }
}

}