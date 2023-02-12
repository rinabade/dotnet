using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;


namespace ApexRestaurant.Services
{
    public class ServiceModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICustomerService,CustomerService>();
        }
    }
    
}