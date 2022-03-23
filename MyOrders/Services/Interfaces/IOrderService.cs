using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyOrders.Models;
using MyOrders.Data;

namespace MyOrders.Services.Interfaces
{
    public interface IOrderService
    {

        List<Order> GetAll();
        List<Order> GetByOrderNumber(int orderNumber);
        Order GetFullOrderDetails(int? id);
        
        
        /*
        public OrderViewModel Get(int id);
        public IEnumerable<OrderViewModel> GetAll();
        public void Add(OrderViewModel orderViewModel);
        public void Update(OrderViewModel orderViewModel);
        public void Delete(int id);
        */
    }
}