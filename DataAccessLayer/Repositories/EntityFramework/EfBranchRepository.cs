using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EntityFramework
{
    public class EfBranchRepository : EfEntityRepositoryBase<Branch, Context>, IBranchDal
    {
        public void AddByMember(int memberId, int BranchId)
        {
            using (Context context = new Context())
            {
                MemberBranch memberBranch = new MemberBranch();
                memberBranch.MemberId = memberId;
                memberBranch.BranchId = BranchId;
                context.MemberBranches.Add(memberBranch);
                context.SaveChanges();
            }
        }

        public List<Branch> GetAllByMember(int memberId)
        {
            //First Way

            //using (Context context = new Context())
            //{
            //    return context.MemberBranches.Where(x => x.MemberId == memberId).Select(i => i.Branch).ToList();

            //}

            //Second Way
            using (Context context = new Context())
            {
                return (from branch in context.Branches
                        from member in branch.Members!
                        where member.MemberId == memberId
                        select branch).ToList();

            }
        }

        public List<Branch> GetAllWithDescriptionAndImage()
        {
            using (Context context = new Context())
            {
                return context.Branches.Include(x => x.Descriptions).Include(i => i.Images).ToList();

            }
        }


        public Branch GetWithDescriptionAndImageById(int id)
        {
            using (Context context = new Context())
            {
                return context.Branches.Where(i => i.BranchId == id)
                    .Include(x => x.Descriptions).Include(i => i.Images).FirstOrDefault()!;

            }
        }
    }
}
