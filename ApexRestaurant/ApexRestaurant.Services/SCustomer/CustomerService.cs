using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RCustomer;


namespace ApexRestaurant.Services.SCustomer
{
    public class CustomerService : GenericService<Customer> , ICustomerService
    {
        public CustomerService(ICustomerRepository customerRepository ) : base (customerRepository)
        {

        }
    }
}
