using Autofac;
using Autofac.Core;
using  Core.Utilities.Interceptors;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Entity.Concrete;
using static Core.Utilities.Interceptors.MethodInterception;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace Business.DependencyResolver.AutoFac
{
    public class AutoFacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            // manager to service
            builder.RegisterType<AddressManager>().As<IAddressService>().SingleInstance();
            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<CustomerGroupManager>().As<ICustomerGroupService>().SingleInstance();
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<DistrictManager>().As<IDistrictService>().SingleInstance();
            builder.RegisterType<ModelManager>().As<IModelService>().SingleInstance();
            builder.RegisterType<ProductStatusManager>().As<IProductStatusService>().SingleInstance();
            builder.RegisterType<ServiceProductManager>().As<IServiceProductService>().SingleInstance();
            builder.RegisterType<ServiceTypeManager>().As<IServiceTypeService>().SingleInstance();

            //DALclass to DALInterface

            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();
            builder.RegisterType<EfCustomerGroupDal>().As<ICustomerGroupDal>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();
            builder.RegisterType<EfModelDal>().As<IModelDal>().SingleInstance();
            builder.RegisterType<EfProductStatusDal>().As<IProductStatusDal>().SingleInstance();
            builder.RegisterType<EfSerivceProductDal>().As<IServiceProductDal>().SingleInstance();
            builder.RegisterType<EfServiceTypeDal>().As<IServiceTypeDal>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                   Selector = new AspectInterceptorSelector() 

                }).SingleInstance();

        }
    }
}