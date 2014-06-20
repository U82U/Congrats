using Congrats.Data.Repository;
using Congrats.Domain.Members;

namespace Congrats.Daab.Linq
{
    using System.Collections.Generic;

    /// <summary>
    /// The member repository.
    /// </summary>
    public class MemberRepository : IMemberRepository
    {
        public Member GetMember(int memberId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return new List<Member>
                       {
                           new Member{LastName = "Sidorovichev" },
                           new Member{LastName = "Novik" },
                       };
        }

        public void SaveMember(Member member)
        {
            throw new System.NotImplementedException();
        }
    }
}
