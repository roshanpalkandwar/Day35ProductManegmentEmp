namespace Day35EmployeeProductReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management");

            //UC1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID = 1,OrederId = 1,Rating=2,Review="Good",IsLike=true},
                new ProductReview(){ProductID = 1,OrederId = 2,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID = 3,OrederId = 3,Rating=4,Review="Good",IsLike=false},
                new ProductReview(){ProductID = 4,OrederId = 4,Rating=4,Review="Good",IsLike=false},
                new ProductReview(){ProductID = 5,OrederId = 5,Rating=2,Review="Good",IsLike=true},
                new ProductReview(){ProductID = 5,OrederId = 6,Rating=2,Review="Good",IsLike=true},
                new ProductReview(){ProductID = 6,OrederId = 10,Rating=6,Review="nice",IsLike=false},
                new ProductReview(){ProductID = 7,OrederId = 10,Rating=7,Review="nice",IsLike=true},
                new ProductReview(){ProductID = 8,OrederId = 10,Rating=8,Review="nice",IsLike=false},
                new ProductReview(){ProductID = 9,OrederId = 10,Rating=9,Review="nice",IsLike=true},
                new ProductReview(){ProductID = 10,OrederId = 11,Rating=10,Review="nice",IsLike=false},
                new ProductReview(){ProductID = 11,OrederId = 12,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID = 11,OrederId = 10,Rating=6,Review="Good",IsLike=false},
                new ProductReview(){ProductID = 12,OrederId = 14,Rating=7,Review="nice",IsLike=false},
                new ProductReview(){ProductID = 11,OrederId = 10,Rating=3,Review="Good",IsLike=true},
                new ProductReview(){ProductID = 13,OrederId = 16,Rating=3,Review="Good",IsLike=true},
                new ProductReview(){ProductID = 14,OrederId = 17,Rating=2,Review="Good",IsLike=false},
                new ProductReview(){ProductID = 15,OrederId = 18,Rating=2,Review="Good",IsLike=true},
                new ProductReview(){ProductID = 16,OrederId = 19,Rating=2,Review="Good",IsLike=false},
                new ProductReview(){ProductID = 16,OrederId = 20,Rating=5,Review="nice",IsLike=false},
                new ProductReview(){ProductID = 17,OrederId = 21,Rating=5,Review="nice",IsLike=true},
                new ProductReview(){ProductID = 18,OrederId = 22,Rating=4,Review="Good",IsLike=true},
                new ProductReview(){ProductID = 17,OrederId = 23,Rating=5,Review="nice",IsLike=false},
                new ProductReview(){ProductID = 19,OrederId = 24,Rating=9,Review="nice",IsLike=true},
                new ProductReview(){ProductID = 20,OrederId = 25,Rating=4,Review="Good",IsLike=true}
            };

            foreach (ProductReview list in productReviewList)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " Order Id : " + list.OrederId + " Rating : " + list.Rating
                   + " Review : " + list.Review + " ISLike : " + list.IsLike);
            }


            Management management = new Management();

            //UC 2
            management.TopRecords(productReviewList);

            //UC 3
            management.SelectedRecords(productReviewList);


            //UC 4
            management.RetriveCountOfRecords(productReviewList);

            //UC 5
            management.RetriveProductIDAndReview(productReviewList);

            // UC 6
            management.SkipTopRecords(productReviewList);

            //UC 7
            management.RetriveOnlyProductIDAndReview(productReviewList);

            //UC 9
            management.RetriveRecordsIsLikeValueTrue(productReviewList);

            //UC 10
            management.AverageRating(productReviewList);

            //UC 11
            management.RetriveRecordsNice(productReviewList);

            //UC 12
            management.RetriveSomeRecords(productReviewList);
        }
    }



}
            
        
    }

}
    
