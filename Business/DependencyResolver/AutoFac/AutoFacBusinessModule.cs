using Autofac;
using Autofac.Core;
using  Core.Utilities.Interceptors;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Entity.Concrete;
using static Core.Utilities.Interceptors.MethodInterception;

namespace Business.DependencyResolver.AutoFac
{
    public class AutoFacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
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

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                   Selector = new AspectInterceptorSelector() 

                }).SingleInstance();

        }
    }
}