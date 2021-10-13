using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace services.Enitities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeletedDate { get; set; }

    }
}
