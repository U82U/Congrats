using System.Collections.Generic;
using Congrats.Data.Repository;
using Congrats.Domain.Members;

namespace Congrats.Daab.Linq
{
    /// <summary>
    /// The member repository.
    /// </summary>
    public class MemberRepository : IMemberRepository
    {
        private EFDbContext Context  = new EFDbContext();
        
        public Member GetMember(int memberId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return Context.Members;
        }

        public void SaveMember(Member member)
        {
            throw new System.NotImplementedException();
        }
    }
}
