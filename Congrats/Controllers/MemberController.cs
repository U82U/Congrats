using System.Web.Mvc;
using Congrats.Data.Repository;

namespace Congrats.WebUI.Controllers
{
    public class MemberController : Controller
    {
        protected IMemberRepository repository;

        public MemberController(IMemberRepository memberRepository)
        {
            repository = memberRepository;
        }

        public ViewResult List()
        {
            return View(repository.GetAllMembers());
        }

    }
}
