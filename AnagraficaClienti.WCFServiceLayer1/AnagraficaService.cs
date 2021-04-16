using AnagraficaClienti.ContextLayer.Repositories;
using AnagraficaClienti.EntitiesLayer.BusinessLayer;
using AnagraficaClienti.EntitiesLayer.Entities;
using AnagraficaClienti.EntitiesLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AnagraficaClienti.WCFServiceLayer1
{
    public class AnagraficaService : IAnagraficaService
    {
        private IClientRepository _clientRepo = new ClientRepository();
        private IOrderRepository _orderRepo = new OrderRepository();

        public bool CreateClient(Client item)
        {
            return _clientRepo.Create(item);
        }

        public bool DeleteClient(int id)
        {
            return _clientRepo.DeleteById(id);
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _clientRepo.GetAll();
        }

        public Client GetClientById(int id)
        {
            return _clientRepo.GetById(id);
        }

        public bool UpdateClient(int id, Client item)
        {
            return _clientRepo.Update(id, item);
        }

        public bool CreateOrder(Order item)
        {
            return _orderRepo.Create(item);
        }

        public bool DeleteOrder(int id)
        {
            return _orderRepo.DeleteById(id);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepo.GetAll();
        }

        public Order GetOrderById(int id)
        {
            return _orderRepo.GetById(id);
        }

        public bool UpdateOrder(int id, Order item)
        {
            return _orderRepo.Update(id, item);
        }
    }
}
