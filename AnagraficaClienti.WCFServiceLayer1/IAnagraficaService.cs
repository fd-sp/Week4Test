using AnagraficaClienti.EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AnagraficaClienti.WCFServiceLayer1
{
    [ServiceContract]
    public interface IAnagraficaService
    {
        [OperationContract]
        IEnumerable<Client> GetAllClients();

        [OperationContract]
        Client GetClientById(int id);

        [OperationContract]
        bool CreateClient(Client item);

        [OperationContract]
        bool DeleteClient(int id);

        [OperationContract]
        bool UpdateClient(int id, Client item);

        [OperationContract]
        IEnumerable<Order> GetAllOrders();

        [OperationContract]
        Order GetOrderById(int id);

        [OperationContract]
        bool CreateOrder(Order item);

        [OperationContract]
        bool DeleteOrder(int id);

        [OperationContract]
        bool UpdateOrder(int id, Order item);
    }
}
