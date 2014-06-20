using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;

namespace Congrats.WebUI.Infrastructure
{
    using Congrats.Daab.Linq;
    using Congrats.Data.Repository;

    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType != null)
            {
                return (IController)ninjectKernel.Get(controllerType);
            }

            return null;
        }

        protected void AddBindings()
        {
            ninjectKernel.Bind<IMemberRepository>().To<MemberRepository>();
        }
    }
}
