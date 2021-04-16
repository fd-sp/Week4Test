using AnagraficaClienti.EntitiesLayer.Entities;
using AnagraficaClienti.EntitiesLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnagraficaClienti.ContextLayer.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AnagraficaContext _db;
        public OrderRepository() : this(new AnagraficaContext()) { }
        public OrderRepository(AnagraficaContext db)
        {
            this._db = db;
        }
        public bool Create(Order item)
        {
            try
            {
                if (item == null)
                    return false;

                _db.Orders.Add(item);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteById(int id)
        {
            try
            {
                if (id <= 0)
                    return false;

                var orderToDelete = _db.Orders.Find(id);
                if (orderToDelete == null)
                    return false;

                _db.Orders.Remove(orderToDelete);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Order> GetAll()
        {
            try
            {
                return _db.Orders.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Order GetById(int id)
        {
            try
            {
                if (id <= 0)
                    return null;

                return _db.Orders.Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(int id, Order item)
        {
            try
            {
                if (id <= 0)
                    return false;

                _db.Orders.Update(item);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
