using N23_HT_Task2;

ReviewList<IReview> reviewList = new ReviewList<IReview>();
reviewList.GetOveralReview();

Review review1 = new Review(Guid.NewGuid(), 5,"hi barbe");
Review review2 = new Review(Guid.NewGuid(), 3, "karl");
Review review3 = new Review(Guid.NewGuid(), 4, "janob");
CrashReport crashReport = new CrashReport(Guid.NewGuid(),5, "salom", "");
CrashReport crashReport2 = new CrashReport(Guid.NewGuid(),5, "salom", "");
CrashReport crashReport3 = new CrashReport(Guid.NewGuid(), 5, "salom", "");
reviewList.Add(review1);
reviewList.Add(review2);
reviewList.Add(review3);


reviewList.Add(crashReport);
reviewList.Add(crashReport2);
reviewList.Add(crashReport3);
Console.WriteLine(reviewList.GetReview(review1.Id));
Console.WriteLine(reviewList.GetReview("Message 1 - uchun"));
reviewList.Update(review2.Id, 1, "bu yangi 2 inchi message");
reviewList.GetOveralReview();


