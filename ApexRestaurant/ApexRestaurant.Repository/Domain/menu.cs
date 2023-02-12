using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexRestaurant.Repository.Domain
{
    public class Menu
    {
        public int Id {get ; set;}
        public string fname {get; set;}
        public double price {get; set;}
        public bool availability {get;set;}
    }
}