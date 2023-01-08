using System;

namespace ApexRestaurant.Repository.Domain
{
    public class Customer
    {
        public int Menu_Id { get; set; }

        public int Menu_Name { get; set; }

        public int Available_Date_From { get; set; }

        public int Available_Date_To { get; set; }

        public int Other_Details { get; set; }


    }
}