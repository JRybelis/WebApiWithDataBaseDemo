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
        [MaxLength(50)]
        public string Name { get; set; }

        public bool Deleted { get; set; } = false;
        public Shop shop { get; set; }
        public int ShopId { get; set; }


    }
}
