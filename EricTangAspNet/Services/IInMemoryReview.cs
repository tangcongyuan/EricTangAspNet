using EricTangAspNet.Entities;
using System.Collections.Generic;

namespace EricTangAspNet.Services
{
    public interface IInMemoryReview
    {
        IEnumerable<Review> GetAllReviews();

        Review Get(int id);

        void Add(Review newReview);

        int Commit();
    }
}