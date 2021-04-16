using AnagraficaClienti.EntitiesLayer.Entities;
using AnagraficaClienti.EntitiesLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnagraficaClienti.EntitiesLayer.BusinessLayer
{
    public class AnagraficaBL : IAnagraficaBL
    {
        private readonly IClientRepository _clientRepo;
        private readonly IOrderRepository _orderRepo;

        public AnagraficaBL(IClientRepository client, IOrderRepository order)
        {
            _clientRepo = client;
            _orderRepo = order;
        }

        public bool CreateClient(Client item)
        {
            return _clientRepo.Create(item);
        }

        public bool CreateOrder(Order item)
        {
            return _orderRepo.Create(item);
        }

        public bool DeleteClientById(int id)
        {
            return _clientRepo.DeleteById(id);
        }

        public bool DeleteOrderById(int id)
        {
            return _orderRepo.DeleteById(id);
        }

        public bool UpdateClient(int id, Client item)
        {
            return _clientRepo.Update(id, item);
        }

        public bool UpdateOrder(int id, Order item)
        {
            return _orderRepo.Update(id, item);
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _clientRepo.GetAll();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepo.GetAll();
        }

        public Client GetClientById(int id)
        {
            return _clientRepo.GetById(id);
        }

        public Order GetOrderById(int id)
        {
            return _orderRepo.GetById(id);
        }
    }
}
