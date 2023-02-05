using ApiBurger_Business.Business;
using ApiBurger_Business.InterfaceBusiness;
using ApiBurger_Repository.InterfaceRepositories;
using ApiBurger_Repository.Repositories;

namespace ApiBurger_Application.CrossCutting
{
    public static class MyConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            #region business

            services.AddScoped<IBreadBusiness, BreadBusiness>();
            services.AddScoped<IMeatBusiness, MeatBusiness>();
            services.AddScoped<IBurgerBusiness, BurgerBusiness>();
            services.AddScoped<IOptionalBusiness, OptionalBusiness>();

            #endregion business

            #region repository

            services.AddScoped<IBreadRepository, BreadRepository>();
            services.AddScoped<IMeatRepository, MeatRepository>();
            services.AddScoped<IBurgerRepository, BurgerRepository>();
            services.AddScoped<IOptionalRepository, OptionalRepository>();
            services.AddScoped<IOptionaisRepository, OptionaisRepository>();

            #endregion repository

            return services;
        }
    }
}