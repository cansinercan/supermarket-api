using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Services.Communication
{
    public class ProductResponse : BaseResponse
    {
        public Product Product { get; set; }
        public ProductResponse(bool success, string message, Product product) : base(success, message)
        {
            Product = product;
        }

        //Creates a success response
        public ProductResponse(Product product) : this(true, string.Empty, product)
        {

        }

        //Creates an Error response
        public ProductResponse(string message) : this(false, message, null)
        {

        }

    }
}
