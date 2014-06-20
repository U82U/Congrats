using System.Collections.Generic;
using Congrats.Domain.Members;

namespace Congrats.Data.Repository
{
    public interface IMemberRepository
    {
        Member GetMember(int memberId);

        IEnumerable<Member> GetAllMembers();

        void SaveMember(Member member);
    }
}
