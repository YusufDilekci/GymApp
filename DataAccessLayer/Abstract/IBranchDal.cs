using CoreLayer.DataAccess;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBranchDal : IEntityRepositoryBase<Branch>
    {
        List<Branch> GetAllWithDescriptionAndImage();
        Branch GetWithDescriptionAndImageById(int id);
        List<Branch> GetAllByMember(int memberId);
        void AddByMember(int memberId, int branchId);
        
    }
}
