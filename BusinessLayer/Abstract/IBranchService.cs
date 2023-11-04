using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBranchService
    {
        void Add(Branch Branch);
        void Update(Branch Branch);
        void Delete(Branch Branch);
        List<Branch> GetAll();
        Branch GetById(int id);
        Branch GetByName(string name);
        List<Branch> GetAllWithDescriptionAndImage();
        Branch GetWithDescriptionAndImageById(int id);
        List<Branch> GetAllByMember(int memberId);

    }
}
