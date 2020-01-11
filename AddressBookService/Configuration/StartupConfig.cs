using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AddressBookService.Configuration
{
    public static class StartupConfig
    {
        public static void EnsureMigrationOfContext<T>(this IApplicationBuilder app) where T: DbContext
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetService<T>();
            context.Database.EnsureCreated();
            context.Database.Migrate();
        }
    }
}
