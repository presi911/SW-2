using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UC_Parking_Domain_Contracts.Contracts;
using UC_Parking_Domain_Contracts.DomainEntities;
using UC_Parking_Domain_Implementation.implementations;

namespace UC_Parking_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IVehiculoDomain _vehiculoDomain = new VehiculoDomainImplementation(null);

       /* public ValuesController(IVehiculoDomain _vehiculoDomain)
        {
            this._vehiculoDomain = _vehiculoDomain;
        }*/

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<VehiculoDomain>> Get()
        {
            return new JsonResult(this._vehiculoDomain.getListaVehiculos());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
