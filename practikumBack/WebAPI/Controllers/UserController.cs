using Microsoft.AspNetCore.Mvc;
using Repository.entities;
using Services.interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IDataServices<User> service;

        public UserController(IDataServices<User> service)
        {
            this.service = service;
        }

        [HttpGet]
        public Task<List<User>> Get()
        {
            return service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public Task<User> Get(int id)
        {
            return service.GetByIdAsync(id);
        }

        [HttpPost]
        public Task Post([FromBody] User value)
        {
            return service.AddAsync(value);
        }

        [HttpPut("{id}")]
        public Task<User> Put([FromBody] User value)
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
