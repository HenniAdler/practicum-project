using Microsoft.AspNetCore.Mvc;
using Repository.entities;
using Services.interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IDataServices<Child> service;

        public ChildController(IDataServices<Child> service)
        {
            this.service = service;
        }

        [HttpGet]
        public Task<List<Child>> Get()
        {
            return service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public Task<Child> Get(int id)
        {
            return service.GetByIdAsync(id);
        }

        [HttpPost]
        public Task Post([FromBody] Child value)
        {
            return service.AddAsync(value);
        }

        [HttpPut("{id}")]
        public Task<Child> Put([FromBody] Child value)
        {
            return service.UpdateAsync(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.DeleteAsync(id);
        }
    }
}
