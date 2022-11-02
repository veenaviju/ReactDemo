using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using domain;

namespace api.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        List<Activity> lstActivities;
        public ActivitiesController()
        {
            lstActivities = new List<Activity>
            {
                new Activity
                {
                    Id=new Guid("d5b050bb-5378-4d7e-9694-ec660b1dfaab"),
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Activity
                {
                    Id=new Guid("47a35718-f85c-4693-b380-b6a3e3cd2108"),
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                },
                new Activity
                {
                    Id=new Guid("461a57f2-dc2f-4f37-a39d-efd53e9acbef"),
                    Title = "Future Activity 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                },
                new Activity
                {
                    Id=new Guid("39fbb65b-e480-4a6b-a7d4-fdb0cb910107"),
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                },
                new Activity
                {
                    Id=new Guid("21971251-7c21-471a-a3ae-d1a25cde4d14"),
                    Title = "Future Activity 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub",
                },
                new Activity
                {
                    Id=new Guid("89243123-9c29-4832-b18b-2b1622b7ad35"),
                    Title = "Future Activity 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub",
                },
                new Activity
                {
                    Id=new Guid("d0a29263-c0f2-48c6-a5ba-fb2302e9cac9"),
                    Title = "Future Activity 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub",
                },
                new Activity
                {
                    Id=new Guid("dab600cf-e5b5-4609-bb17-c211e1be239b"),
                    Title = "Future Activity 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                },
                new Activity
                {
                    Id=new Guid("1b4aaf5b-b467-4a64-a6f1-37efd8ff5241"),
                    Title = "Future Activity 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Activity 2 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },
                new Activity
                {
                    Id=new Guid("8c20093e-97b1-4192-adf4-b17954eb680f"),
                    Title = "Future Activity 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                }
            };


        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return lstActivities;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid Id)
        {
            return lstActivities.Find(l=>l.Id==Id);
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity(Activity act)
        {
            lstActivities.Add(act);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditActivity(Guid id,Activity act)
        {
            lstActivities.Add(act);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            return Ok();
        }
    }   
}