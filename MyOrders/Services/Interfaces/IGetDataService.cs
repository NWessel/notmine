using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyOrders.Models;
using MyOrders.Data;

namespace MyOrders.Services.Interfaces
{
    public interface IGetDataService
    {
        List<Order> ImportData();
    }
}