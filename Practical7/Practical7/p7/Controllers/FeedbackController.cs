using Microsoft.AspNetCore.Mvc;
using p7.Models;

namespace p7.Controllers
{
    public class FeedbackController : Controller
    {
        // In-memory list used instead of a database
        private static readonly List<Feedback> feedbacks = new List<Feedback>
        {
            new Feedback
            {
                Id = 1, Name = "Riya Mehta", Email = "riya.mehta@example.com",
                Phone = "9876543210", Subject = "Course Content", Rating = 5,
                Comments = "The MVC practicals were easy to follow and very useful.",
                SubmittedOn = new DateTime(2026, 10, 12)
            },
            new Feedback
            {
                Id = 2, Name = "Kunal Joshi", Email = "kunal.joshi@example.com",
                Phone = "9123456780", Subject = "Faculty", Rating = 4,
                Comments = "Concepts are explained well, a few more demos would help.",
                SubmittedOn = new DateTime(2026, 10, 14)
            },
            new Feedback
            {
                Id = 3, Name = "Sneha Rathod", Email = "sneha.rathod@example.com",
                Phone = "9988776655", Subject = "Laboratory", Rating = 3,
                Comments = "Lab systems were slow while running Visual Studio.",
                SubmittedOn = new DateTime(2026, 10, 16)
            }
        };

        // GET: /Feedback
        public IActionResult Index()
        {
            List<Feedback> list = feedbacks.OrderByDescending(f => f.SubmittedOn).ToList();

            ViewBag.Total = list.Count;
            ViewBag.Average = list.Count > 0 ? list.Average(f => f.Rating) : 0;

            return View(list);
        }

        // GET: /Feedback/Create
        public IActionResult Create()
        {
            return View(new Feedback());
        }

        // POST: /Feedback/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Feedback feedback)
        {
            // Server-side validation (Data Annotations)
            if (!ModelState.IsValid)
            {
                return View(feedback);
            }

            feedback.Id = feedbacks.Max(f => f.Id) + 1;
            feedback.SubmittedOn = DateTime.Now;
            feedbacks.Add(feedback);

            TempData["Success"] = "Thank you, " + feedback.Name + "! Your feedback has been submitted.";
            return RedirectToAction("Index");
        }
    }
}
