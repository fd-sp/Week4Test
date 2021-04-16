using AnagraficaClienti.EntitiesLayer.BusinessLayer;
using AnagraficaClienti.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnagraficaClienti.RESTServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IAnagraficaBL _anagrafica;
        public OrderController(IAnagraficaBL bl)
        {
            this._anagrafica = bl;
        }

        // GET: api/Order/
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAll()
        {
            IEnumerable<Order> clientList = _anagrafica.GetAllOrders();
            if (clientList == null)
                return StatusCode(500);
            return Ok(clientList);
        }

        // GET: api/client/{id}
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var order = _anagrafica.GetOrderById(id);
            if (order == null)
                return BadRequest("Something gone wrong, or your order doesn't exist");
            return Ok(order);
        }

        // POST: api/order/{order}
        [HttpPost]
        public ActionResult CreateNewOrder([FromBody] Order newOrder)
        {
            var request = _anagrafica.CreateOrder(newOrder);
            if (!request)
                return BadRequest("Something went wrong");
            return Ok("The new order has been succesfully created");
        }

        // DELETE: api/order/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var request = _anagrafica.DeleteOrderById(id);
            if (!request)
                return StatusCode(500);
            return Ok("The order has been succesfully deleted");
        }

        // PUT: api/order/{id}&{order}
        [HttpPut("{id}")]
        public ActionResult UpdateOrder(int id, [FromBody] Order orderToEdit)
        {
            var request = _anagrafica.UpdateOrder(id, orderToEdit);
            if (!request)
                return BadRequest("Something gone wrong or the order doesn't exist");
            return Ok("The order has been succesfully edited");
        }
    }
}
