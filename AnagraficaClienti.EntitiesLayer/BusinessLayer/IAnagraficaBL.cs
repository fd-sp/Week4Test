using AnagraficaClienti.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnagraficaClienti.EntitiesLayer.BusinessLayer
{
    public interface IAnagraficaBL
    {
        IEnumerable<Client> GetAllClients();
        Client GetClientById(int id);
        bool DeleteClientById(int id);
        bool CreateClient(Client item);
        bool UpdateClient(int id, Client item);
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        bool DeleteOrderById(int id);
        bool CreateOrder(Order item);
        bool UpdateOrder(int id, Order item);
    }
}
