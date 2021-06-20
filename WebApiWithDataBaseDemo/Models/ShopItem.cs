using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiWithDataBaseDemo.Models
{
    public class ShopItem
    {
        [Key]
        public int PrimaryKey { get; set; }
        public string Name { get; set; }
    }
}
