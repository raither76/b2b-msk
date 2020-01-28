using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Moq;
using Ninject;
using b2b_msk.Domain.Abstract;
using b2b_msk.Domain.Entities;
using b2b_msk.Domain.Concrete;


namespace b2b_msk.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            // Здесь размещаются привязки
            // Mock<IGoodRepository> mock = new Mock<IGoodRepository>();
            // mock.Setup(m => m.Goods).Returns(new List<Good>
            //     {
            //         new Good { Name = "SimCity", curPrice = 1499 },
            //         new Good { Name = "TITANFALL", curPrice=2299 },
            //         new Good { Name = "Battlefield 4", curPrice=899.4M }
            //      });
            //  kernel.Bind<IGoodRepository>().ToConstant(mock.Object);
            kernel.Bind<IGoodRepository>().To<EFGoodRepository>();


        }
    }
}