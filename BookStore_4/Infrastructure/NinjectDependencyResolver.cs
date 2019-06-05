using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
//using Moq;
using Ninject;
using BookStore_4.Concrete;
using BookStore_4.Abstract;

namespace BookStore_4.Infrastructure
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
            kernel.Bind<IBookRepository>().To<EFBookRepository>();
        }
    }
}