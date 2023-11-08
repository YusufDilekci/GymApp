using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ShippingDetail : IEntity
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string AddressTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; } //İlçe
        public string PostalCode { get; set; }
        public Cart? Cart { get; set; }


    }
}
