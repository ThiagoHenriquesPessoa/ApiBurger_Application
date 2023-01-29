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
            services.AddScoped<IBreadBusiness, BreadBusiness>();
            services.AddScoped<IBaseRepository<Object>, BaseRepository<Object>>();

            return services;
        }
    }
}
