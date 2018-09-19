using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NetCoreSaas.Api.Queries.Sample;

namespace NetCoreSaas.Api.Controllers.Sample
{
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        private readonly IMediator _mediator;

        public SampleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<string> Get()
        {

            return await _mediator.Send(new Ping());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "sample";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string sample)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string sample)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
