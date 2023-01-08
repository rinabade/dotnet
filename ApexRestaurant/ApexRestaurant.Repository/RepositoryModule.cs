using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Repository.RCustomer;

namespace ApexRestaurant.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection, string migrationsAssembly)
        {
            services.AddDbContext<RestaurantContext>(options => options.UseMySqlServer(connection, builder => builder.MigrationsAssembly(migrationsAssembly)));
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IMenu_ItemsRepository, Menu_ItemsRepository>();
            services.AddTransient<IMealsRepository, MealsRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();
            services.AddTransient<IMeal_DishesRepository, Meal_DishesRepository>();
            services.AddTransient<IRef_Staff_RolesRepository, Ref_Staff_RolesRepository>();
        }
    }
}