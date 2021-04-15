using Angular.Controllers;
using Angular.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Angular.Data
{
    public class ComputerRepository : IComputerRepository
    {
        private readonly Context _db;

        public ComputerRepository(Context db)
        {
            _db = db;
        }

        public IEnumerable<Computer> GetAll()
        {
            return from c in _db.computer select c;
        }
    }
}
