using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35EmployeeProductReview
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        //UC 2
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " Order Id : " + list.OrederId + " Rating : " + list.Rating
                    + " Review : " + list.Review + " ISLike : " + list.IsLike);
            }
        }

        //UC 3
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProductID == 1 && productReviews.Rating > 3) ||
                               (productReviews.ProductID == 4 && productReviews.Rating > 3) ||
                               (productReviews.ProductID == 9 && productReviews.Rating > 3)
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " Order Id : " + list.OrederId + " Rating : " + list.Rating
                    + " Review : " + list.Review + " ISLike : " + list.IsLike);
            }
        }

        // UC 4
        public void RetriveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "--------" + list.Count);
            }
        }

        // UC 5
        public void RetriveProductIDAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " Review : " + list.Review);
            }
        }

        //UC 6
        public void SkipTopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                select productReviews).Skip(5);

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " Order Id : " + list.OrederId + " Rating : " + list.Rating
                    + " Review : " + list.Review + " ISLike : " + list.IsLike);
            }
        }

        // UC 7
        public void RetriveOnlyProductIDAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " Review : " + list.Review);
            }
        }

        //UC 9
        public void RetriveRecordsIsLikeValueTrue(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where productReviews.IsLike == true
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " Order Id : " + list.OrederId + " Rating : " + list.Rating
                    + " Review : " + list.Review + " ISLike : " + list.IsLike);
            }
        }

        // UC 10
        public void AverageRating(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Avg = x.Average(g => g.Rating) });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "--------" + list.Avg);
            }
        }

        // UC 11
        public void RetriveRecordsNice(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where productReviews.Review == "nice"
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " Order Id : " + list.OrederId + " Rating : " + list.Rating
                    + " Review : " + list.Review + " ISLike : " + list.IsLike);
            }
        }

        //UC 12
        public void RetriveSomeRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.OrederId == 10)
                               orderby productReviews.Rating
                               select productReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " Order Id : " + list.OrederId + " Rating : " + list.Rating
                    + " Review : " + list.Review + " ISLike : " + list.IsLike);
            }
        }
    }
}
