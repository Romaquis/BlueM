using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlueModasApi.Data;
using BlueModasApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlueModasApi.Controllers {
    public class AccountController: Controller {
        private readonly StoreDataContext _context;
    

        public AccountController(StoreDataContext context) {
            _context = context;
        }

        [Route("v1/account")]
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _context.Accounts.AsNoTracking().ToList();
        }

        [Route("v1/account/{id}")]
        [HttpGet]
        public Account Get(int id)
        {
            //Find() aind não suporta AsNoTracking
            //FirstOrDefault vai pegar o primeiro e caso não exista retorna vazio
            return _context.Accounts.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        [Route("v1/account")]
        [HttpPost]
        public Account Post ([FromBody]Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
            
            return account;
        }

        [Route("v1/account")]
        [HttpPut]
        public Account Put ([FromBody]Account account)
        {
            _context.Entry<Account>(account).State = EntityState.Modified;
            _context.SaveChanges();

            return account;
        }

        [Route("v1/account")]
        [HttpDelete]
        public Account Delete([FromBody] Account account)
        {
            _context.Accounts.Remove(account);
            _context.SaveChanges();

            return account;
        }
    }
}