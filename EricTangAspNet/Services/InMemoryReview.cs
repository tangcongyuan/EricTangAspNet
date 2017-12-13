using System.Collections.Generic;
using System.Linq;
using EricTangAspNet.Entities;

namespace EricTangAspNet.Services
{
    public class InMemoryReview : IInMemoryReview
    {
        private static readonly List<Review> _reviews;

        static InMemoryReview()
        {
            _reviews = new List<Review>()
            {
                new Review { Id = 0, Text = "First review is always important." },
                new Review { Id = 1, Text = "Who cares about the second comment?"}
            };
        }
        public void Add(Review newReview)
        {
            newReview.Id = _reviews.Max(r => r.Id) + 1;
            _reviews.Add(newReview);
        }

        public int Commit() { return 0; }

        public Review Get(int id) => _reviews.FirstOrDefault(r => r.Id == id);

        public IEnumerable<Review> GetAllReviews() => _reviews;
    }
}
