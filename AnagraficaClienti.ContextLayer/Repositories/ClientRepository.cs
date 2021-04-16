using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnagraficaClienti.EntitiesLayer.Entities;
using AnagraficaClienti.EntitiesLayer.IRepositories;

namespace AnagraficaClienti.ContextLayer.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AnagraficaContext _db;
        public ClientRepository() : this(new AnagraficaContext()) { }
        public ClientRepository(AnagraficaContext db)
        {
            this._db = db;
        }

        public bool Create(Client item)
        {
            try
            {
                if (item == null)
                    return false;

                _db.Clients.Add(item);
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

                var clientToDelete = _db.Clients.Find(id);
                if (clientToDelete == null)
                    return false;

                _db.Clients.Remove(clientToDelete);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Client> GetAll()
        {
            try
            {
                return _db.Clients.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Client GetById(int id)
        {
            try
            {
                if (id <= 0)
                    return null;

                return _db.Clients.Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(int id, Client item)
        {
            try
            {
                if (id <= 0)
                    return false;

                _db.Clients.Update(item);
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
