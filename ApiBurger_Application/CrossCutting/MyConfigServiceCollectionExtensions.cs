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
            #endregion
            #region repository
            services.AddScoped<IBreadRepository, BreadRepository>();
            services.AddScoped<IMeatRepository, MeatRepository>();
            #endregion
            return services;
        }
    }
}
