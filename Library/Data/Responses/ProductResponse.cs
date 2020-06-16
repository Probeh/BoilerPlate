using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Responses
{
    public class ProductResponse : ResponseDTO<ProductResponse>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? ActiveSince { get; set; }
        public bool IsActive { get; set; }
    }
}
