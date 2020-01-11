using AddressBookService.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AddressBookService.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IAddressBookRepository, AddressBookRepository>();
            return services;
        }
    }
}
