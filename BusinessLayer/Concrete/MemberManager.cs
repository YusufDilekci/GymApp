using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        public MemberManager(IMemberDal memberDal) 
        {
            _memberDal= memberDal;
        }
        public void Add(Member member)
        {
            _memberDal.Add(member);
        }

        public void Delete(Member member)
        {
            _memberDal.Delete(member);
        }

        public List<Member> GetAll()
        {
            return _memberDal.GetAll();
        }

        public Member GetByEmail(string email)
        {
            return _memberDal.Get(i => i.MemberEmail == email);
        }

        public Member GetByEmailAndPassword(string email, string password)
        {
            return _memberDal.Get(i => i.MemberEmail== email && i.MemberPassword == password);
        }

        public Member GetById(int id)
        {
            return _memberDal.Get(i => i.MemberId == id);
        }

        public Member GetByUsername(string username)
        {
            return _memberDal.Get(i => i.MemberUserName == username);
        }

        public void Update(Member member)
        {
             _memberDal.Update(member);
        }
    }
}
