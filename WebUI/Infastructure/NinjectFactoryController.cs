using System;
using Ninject;
using System.Web.Routing;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Concrete;
using Domain.Entity;

namespace WebUI.Infastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            // создание контейнера
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            // получение объекта контроллера из контейнера 
            // используя его тип
            return controllerType == null
              ? null
              : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            /* Mock<IUserRepository> mock = new Mock<IUserRepository>();
             mock.Setup(m => m.Users).Returns(new List<User> {
           new User { Name = "Football" },
           new User { Name = "Surf board"},
           new User { Name = "Running shoes" }
         }.AsQueryable());
             ninjectKernel.Bind<IUserRepository>().ToConstant(mock.Object);*/
            //ninjectKernel.Bind<IUserRepository>().To<EFProductRepository>();
            ninjectKernel.Bind<IRepository<Car>>().To<EFRepository<Car>>();
            ninjectKernel.Bind<IRepository<BuyingCar>>().To<EFRepository <BuyingCar>> ();
            ninjectKernel.Bind<IRepository<OwnerCar>>().To<EFRepository<OwnerCar>>();
            ninjectKernel.Bind<IRepository<SearchQuery>>().To<EFRepository<SearchQuery>>();
        }
    }
}