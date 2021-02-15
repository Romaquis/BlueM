using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlueModasApi.Data;
using BlueModasApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlueModasApi.Controllers {
    public class ProductController: Controller {
        private readonly StoreDataContext _context;
    

        public ProductController(StoreDataContext context) {
            _context = context;
        }

        [Route("v1/product")]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _context.Products.AsNoTracking().ToList();
        }

        [Route("v1/product/{id}")]
        [HttpGet]
        public Product Get(int id)
        {
            return _context.Products.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        [Route("v1/product/{title}/title")]
        [HttpGet]
        public IEnumerable<Product> Get(string title) {
            return _context.Products.AsNoTracking().Where(x => x.Title.Contains(title)).ToList();
        }

        [Route("v1/product")]
        [HttpPost]
        public Product Post ([FromBody]Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            
            return product;
        }

        [Route("v1/product")]
        [HttpPut]
        public Product Put ([FromBody]Product product)
        {
            _context.Entry<Product>(product).State = EntityState.Modified;
            _context.SaveChanges();

            return product;
        }

        [Route("v1/product")]
        [HttpDelete]
        public Product Delete([FromBody] Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();

            return product;
        }
    }
}