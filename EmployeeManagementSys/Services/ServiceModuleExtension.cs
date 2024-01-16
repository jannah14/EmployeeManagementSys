using EmployeeManagementSys.Services;

namespace EmployeeManagementSys.Repos

{
    public static partial class ServiceModuleExtension
    {
        public static void RegisterServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEmployeeService, EmployeeService>();
        }
    }
}
