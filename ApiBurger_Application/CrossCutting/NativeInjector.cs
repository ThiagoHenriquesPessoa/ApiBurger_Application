using ApiBurger_Business.Business;
using ApiBurger_Business.InterfaceBusiness;
using ApiBurger_Repository.InterfaceRepositories;
using ApiBurger_Repository.Repositories;

namespace ApiBurger_Application.CrossCutting
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Business
            services.AddTransient<IBreadBusiness, BreadBusiness>();
            #endregion

            #region Repository
            services.AddTransient<IBreadRepository, BreadRepository>();
            #endregion
        }
    }
}