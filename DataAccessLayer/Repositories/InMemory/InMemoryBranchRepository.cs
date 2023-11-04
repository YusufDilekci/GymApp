using CoreLayer.DataAccess.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.InMemory
{
    public class InMemoryBranchRepository : IBranchDal
    {
        private IQueryable<Branch> _branches;
        public InMemoryBranchRepository()
        {
            _branches = new List<Branch>
                {
                    new Branch(){BranchId=1, BranchName="Fitness", BranchInfo="üiğiüğğşğşsğaüğ"},
                    new Branch(){BranchId=2, BranchName="Kickbox", BranchInfo="üiğiüğğşğşsğaüğ"},
                    new Branch(){BranchId=3, BranchName="Zumba",  BranchInfo="üiğiüğğşğşsğaüğ"},
                    new Branch(){BranchId=4, BranchName="Pilates",  BranchInfo="üiğiüğğşğşsğaüğ"},
                    new Branch(){BranchId=5, BranchName="Coaching",  BranchInfo="üiğiüğğşğşsğaüğ"},

                }.AsQueryable();
        }

        public void Add(Branch entity)
        {
            _branches.ToList().Add(entity);
        }

        public void AddByMember(int memberId, int BranchId)
        {
            throw new NotImplementedException();
        }

        public void Delete(Branch entity)
        {
            _branches.ToList().Remove(entity);
        }

        public Branch Get(Expression<Func<Branch, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Branch> GetAll(Expression<Func<Branch, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Branch> GetAllByMember(int memberId)
        {
            throw new NotImplementedException();
        }

        public List<Branch> GetAllWithDescriptionAndImage()
        {
            throw new NotImplementedException();
        }

        public Branch GetWithDescriptionAndImageById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Branch entity)
        {
            
            var Branch = _branches.ToList().Find(i=> i.BranchId == entity.BranchId);
            Branch.BranchInfo = entity.BranchInfo;
            Branch.BranchPrice = entity.BranchPrice;
            Branch.BranchName = entity.BranchName;


        }
    }
}
