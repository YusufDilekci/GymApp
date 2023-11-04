namespace GymApp.Models
{
    public class BranchDescriptionImageViewModel
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchInfo { get; set; }
        public double BranchPrice { get; set; }
        public List<string> BranchDescriptions { get; set; }
        public List<string> BranchImages { get; set; }
    }
}
