using EricTangAspNet.Entities;
using EricTangAspNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace EricTangAspNet.Controllers
{
    public class ReviewController: Controller
    {
        private IInMemoryReview _reviews;

        public ReviewController(IInMemoryReview inMemoryReviews)
        {
            _reviews = inMemoryReviews;
        }

        public ViewResult Index()
        {
            var model = _reviews.GetAllReviews();
            return View(model);
        }
    }
}
