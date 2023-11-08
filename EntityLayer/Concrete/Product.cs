using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int SubCategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }

        //public double StarRate { get; set; } Producta yapılan her yorumdaki yıldız sayısının toplam kişiye oranını hesaplayacak bir trigger oluşturacağız
        public SubCategory? SubCategory { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public CartLine? CartLine { get; set; }
    }
}
