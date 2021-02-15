using System.Collections.Generic;
using BlueModasApi.Data;
using BlueModasApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlueModasApi.Controllers {
    public class SaleController: Controller {
        private readonly StoreDataContext _context;
        
        public SaleController(StoreDataContext context) {
            _context = context;
        }

        [Route("v1/sale")]
        [HttpPost]
        public int Post([FromBody]Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
            return sale.Id;
        }
    }
}

