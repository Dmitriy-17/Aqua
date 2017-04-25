using System;

using Infrastructure.Enums;

namespace Infrastructure.Order
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public string Price { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int RegionId { get; set; }
        public int CityId { get; set; }
        public OrderState OrderState { get; set; }
        public TypeOfService TypeOfService { get; set; }
    }
}
