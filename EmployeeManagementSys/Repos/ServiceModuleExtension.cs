namespace EmployeeManagementSys.Repos
{
    public static partial class ServiceModuleExtension
    {
        public static void RegisterRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
