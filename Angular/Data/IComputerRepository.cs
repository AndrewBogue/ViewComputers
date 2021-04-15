using Angular.Data.Entities;
using System.Collections.Generic;

namespace Angular.Controllers
{
    public interface IComputerRepository
    {
        IEnumerable<Computer> GetAll();
    }
}