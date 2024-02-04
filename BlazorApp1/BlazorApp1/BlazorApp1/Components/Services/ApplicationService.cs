using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace BlazorApp1 {
  public interface IApplicationService
  {
      void ApplyForJob(Application application);
      List<Application> GetApplicationsForJob(int jobId);
  }

  public class ApplicationService : IApplicationService
  {
      private static List<Application> applications = new List<Application>();

      public void ApplyForJob(Application application)
      {
          // Implement logic to store the application
          applications.Add(application);
      }

      public List<Application> GetApplicationsForJob(int jobId)
      {
          // Implement logic to retrieve applications for a specific job
          return applications.Where(app => app.JobId == jobId).ToList();
      }
  }

}
