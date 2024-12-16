using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private readonly ECommerceDbContext _context;

        public ProductsController(ECommerceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.Include(p=>p.Supplier).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            _context.Products.Add(product);
    
    // Add reviews if they exist
    if (product.Reviews != null && product.Reviews.Any())
    {
        foreach (var review in product.Reviews)
        {
            review.ProductId = product.Id; // Link review to the new product
            _context.Reviews.Add(review);
        }
    }
    
    // Save changes to the database
    await _context.SaveChangesAsync();

    // Return created product with its associated reviews
    return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }
}