using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment : IEntity
    {
        public int CommentId { get; set; }
        public int ProductId { get; set; }
        public string CommentTitle { get; set; }
        public string? CommentDescription { get; set; }
        public DateTime CommentDate { get; set; }
        public int CommentStar { get; set; }
        public Product Product { get; set; }
    }
}
