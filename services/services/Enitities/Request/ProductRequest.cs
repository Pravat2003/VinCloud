using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.Enitities.Request
{
    public class ProductRequest
    {
        public int? Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        //public string ImageUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
