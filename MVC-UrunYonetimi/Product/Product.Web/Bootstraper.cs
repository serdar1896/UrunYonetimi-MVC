﻿using Autofac;
using Autofac.Integration.Mvc;
using Product.Core.Infrastructure;
using Product.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product.Web
{
    public static class Bootstrapper
    {
        public static void RunConfig()
        {
            BuildAutoFac();
        }
        private static void BuildAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<ProductsRepocitory>().As<IProductRepository>();
            builder.RegisterType<ProducstImageRepository>().As<IProductImageRepository>();
            builder.RegisterType<ProductFeatureRepository>().As<IProductFeatureRepository>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}