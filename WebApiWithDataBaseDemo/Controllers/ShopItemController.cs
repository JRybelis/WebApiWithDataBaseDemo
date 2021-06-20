using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiWithDataBaseDemo.Data;
using WebApiWithDataBaseDemo.Models;

namespace WebApiWithDataBaseDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : ControllerBase
    {
        private readonly DataContext _context;

        public ShopItemController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        [HttpGet]
        public List<ShopItem> GetAll()
        {
            return _context.ShopItems.ToList();
        }

        [HttpGet("{id}")]
        public ShopItem GetById(int id)
        {
            return _context.ShopItems.FirstOrDefault(s => s.PrimaryKey == id);
        }

        [HttpPost]
        public void Post(ShopItem item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        [HttpPut]
        public void Update(ShopItem shopItem)
        {
            _context.ShopItems.Update(shopItem);
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var shopItem = _context.ShopItems.FirstOrDefault((s => s.PrimaryKey == id));

            if (shopItem != null)
            {
                _context.ShopItems.Remove(shopItem);
                _context.SaveChanges();
            }
        }
    }
}
