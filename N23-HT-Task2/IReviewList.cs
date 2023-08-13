using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT_Task2
{
    internal interface IReviewList<TReview> where TReview : IReview
    {
        public void Add(TReview review);
        public void Update(Guid id, int star, string message);
        public void Remove(Guid id);
        public void Remove(TReview review);
        public TReview GetReview(Guid id);
        public TReview GetReview(string message);

        public void GetOveralReview();
    }
}
