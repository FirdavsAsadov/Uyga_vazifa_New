using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_HT_Task2
{
    internal class ReviewList<TReview> : IReviewList<TReview> where TReview : IReview
    {
        private List<TReview> _reviewList;
        public ReviewList()
        {
            _reviewList = new List<TReview>();
        }



        public void Add(TReview review)
        {
            _reviewList.Add(review);
        }
        public void Remove(Guid id)
        {
            TReview review = _reviewList.FirstOrDefault(x => x.Id == id);
            if(review != null)
            {
                _reviewList.Remove(review);
            }
        }
        public void Remove(TReview review)
        {
            _reviewList?.Remove(review);
        }
        public void Update(Guid id, int star, string message)
        {
            _reviewList.Where(rew => rew.Id == id).ToList().ForEach(item =>
            {
                item.Star = star;
                item.Message = message;
            });
        }


        public TReview GetReview(Guid id)
        {
            return _reviewList.Find(rew => rew.Id == id);
        } 


        public TReview GetReview(string message) 
        {
            return _reviewList.Find(rew => rew.Message == message);
        }


        public void GetOveralReview()
        {
            if(_reviewList.Count <= 0)
            {
                Console.WriteLine("Be the first to leave a review for this product");
            }  
            bool AllFiveStars = _reviewList.All(rew =>  rew.Star == 5);
            if(AllFiveStars)
            {
                Console.WriteLine("Great news! All reviews for this product are 5-star ratings");
            }
            TReview reviewlewost = _reviewList.OrderBy(rew =>rew.Star).FirstOrDefault();
            var allfirstStar = _reviewList.FirstOrDefault(review => review.Star == 1);
            if(allfirstStar != null)
            {
                Console.WriteLine(allfirstStar.Message);
            }
        }



    }
}
