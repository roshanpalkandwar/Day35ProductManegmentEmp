using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35EmployeeProductReview
{
    public class ProductReview
    {
        public int ProductID { get; set; }
        public int OrederId { get; set; }

        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }
    }
}
