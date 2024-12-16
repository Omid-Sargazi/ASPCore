using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product{ get; set; }
        public string ReviewerName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}