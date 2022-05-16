using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Services.Communication
{
    public class CategoryResponse : BaseResponse
    {
        public Category Category { get; private set; }

        private CategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }

        //Creates a success response
        public CategoryResponse(Category category) : this(true, string.Empty, category)
        {

        }

        //Creates an Error response
        public CategoryResponse(string message) : this(false, message, null)
        {

        }

    }
}
