using EntityLayer.Concrete;

namespace GymApp.Models
{
    public class ProductCommentViewModel
    {
        public Product? p { get; set; }
        public Comment? c { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
