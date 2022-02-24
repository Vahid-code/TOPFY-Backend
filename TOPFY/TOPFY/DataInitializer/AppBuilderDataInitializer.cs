using DomainModels.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Repository.Services.Abstarction;
using TOPFY.DataInitializer;

namespace Repository.DAL.DataInitializer
{
    public static class AppBuilderDataInitializer
    {
        public async static void Seed(this IApplicationBuilder builder)
        {
            using IServiceScope scope = builder.ApplicationServices.CreateScope();
            IUnitOfWork unitOfWork = scope.ServiceProvider
                .GetRequiredService<IUnitOfWork>();
            AppDbContext context = scope.ServiceProvider
               .GetRequiredService<AppDbContext>();
            UserManager<User> userManager = scope.ServiceProvider
             .GetRequiredService<UserManager<User>>();
            DbSeeder dbSeeder = new(unitOfWork, context, userManager);
            await dbSeeder.InitializeSeeder();
        }
    }
}
