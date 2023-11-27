using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using CoreLayer.Aspects.Autofac.Validation;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BranchManager : IBranchService
    {
        private  IBranchDal _BranchDal;
        public BranchManager(IBranchDal Branch) 
        {
            _BranchDal= Branch;
        }


        [ValidationAspect(typeof(BranchValidator), Priority = 1)]
        public void Add(Branch Branch)
        {
            _BranchDal.Add(Branch);
        }

        public void Delete(Branch Branch)
        {
            _BranchDal.Delete(Branch);
        }

        public List<Branch> GetAll()
        {
            return _BranchDal.GetAll();
        }

        public List<Branch> GetAllByMember(int memberId)
        {
            return _BranchDal.GetAllByMember(memberId);
        }

        public List<Branch> GetAllWithDescriptionAndImage()
        {
            return _BranchDal.GetAllWithDescriptionAndImage();
        }

        public Branch GetById(int id)
        {
            return _BranchDal.Get(i => i.BranchId == id);
        }

        public Branch GetByName(string name)
        {
            return _BranchDal.Get(i => i.BranchName == name);
        }

        public Branch GetWithDescriptionAndImageById(int id)
        {
            return _BranchDal.GetWithDescriptionAndImageById(id);
        }

        public void Update(Branch Branch)
        {
            _BranchDal.Update(Branch);
        }
    }
}
