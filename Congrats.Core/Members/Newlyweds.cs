namespace Congrats.Domain.Members
{
    public class Newlyweds
    {
        public int NewlywedsId { get; set; }

        public Member Bride { get; set; }

        public Member Groom { get; set; }
    }
}
