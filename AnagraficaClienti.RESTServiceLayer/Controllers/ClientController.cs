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
    public class ClientController : ControllerBase
    {
        private readonly IAnagraficaBL _anagrafica;
        public ClientController(IAnagraficaBL bl)
        {
            this._anagrafica = bl;
        }


        // GET: api/Client/
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAll()
        {
            IEnumerable<Client> clientList = _anagrafica.GetAllClients();
            if (clientList == null)
                return StatusCode(500);
            return Ok(clientList);
        }

        // GET: api/client/{id}
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var client = _anagrafica.GetClientById(id);
            if (client == null)
                return BadRequest("Something gone wrong, or your client doesn't exist");
            return Ok(client);
        }

        // POST: api/client/{client}
        [HttpPost]
        public ActionResult CreateNewCLient([FromBody]Client newClient)
        {
            var request = _anagrafica.CreateClient(newClient);
            if (!request)
                return BadRequest("Something went wrong");
            return Ok("The new client has been succesfully created");
        }

        // DELETE: api/client/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteClient(int id)
        {
            var request = _anagrafica.DeleteClientById(id);
            if (!request)
                return StatusCode(500);
            return Ok("The client has been succesfully deleted");
        }

        // PUT: api/client/{id}&{client}
        [HttpPut("{id}")]
        public ActionResult UpdateClient(int id, [FromBody]Client clientToEdit)
        {
            var request = _anagrafica.UpdateClient(id, clientToEdit);
            if (!request)
                return BadRequest("Something gone wrong or the client doesn't exist");
            return Ok("The client has been succesfully edited");
        }
    }
}
