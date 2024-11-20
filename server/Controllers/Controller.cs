using Microsoft.AspNetCore.Mvc;

namespace server.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller: ControllerBase
{
    private readonly ILogger<Controller> _logger;

    public Controller(ILogger<Controller> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWorkItems")]
    public IEnumerable<WorkItem> Get()
    {
        return new List<WorkItem>
        {
            new WorkItem {
                Id = "PBI-1001",
               Title = "Implement user authentication flow"
            },
            new WorkItem {
                Id = "PBI-1002", 
                Title = "Add dark mode theme support"
            },
            new WorkItem {
                Id = "PBI-1003",
                Title = "Optimize database queries for product listing"
            },
            new WorkItem {
                Id = "PBI-1004",
                Title = "Create mobile responsive navigation menu"
            },
            new WorkItem {
                Id = "PBI-1005",
                Title = "Add export to PDF functionality"
            },
            new WorkItem {
                Id = "PBI-1006",
                Title = "Implement real-time notifications"
            },
            new WorkItem {
                Id = "PBI-1007",
                Title = "Create automated email digest system"
            }
        };
    }
}
