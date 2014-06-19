using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congrats.Core.Members
{
    public class Newlyweds
    {
        public int NewlywedsId { get; set; }

        public Member Bride { get; set; }

        public Member Groom { get; set; }
    }
}
