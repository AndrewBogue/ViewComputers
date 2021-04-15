using Angular.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Angular.Controllers
{
    [ApiController]
    [Route("api/computers")]
    public class ComputerController : Controller
    {
        private readonly IComputerRepository _repository;
        private readonly ILogger<ComputerController> _logger;

        public ComputerController(IComputerRepository repository, ILogger<ComputerController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Computer> Get()
        {
            var all = _repository.GetAll().ToList();
            return all;
        }
    }
}
