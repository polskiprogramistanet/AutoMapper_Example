using System;
using System.Collections.Generic;
using System.Text;

namespace libAutoMapper.Domain.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Availability { get; set; }
    }
}
