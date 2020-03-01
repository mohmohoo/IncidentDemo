using System.Collections.Generic;
using System.Linq;
using IncidentDemo.Models;

namespace IncidentDemo.Repository
{
    

    public class IncidentRepository
        : IRepository<Incident>
    {
        private IIncidentDataContext _context;

        public IncidentRepository(IIncidentDataContext context)
        {
            _context = context;
        }

        public IResult<Incident> Add(Incident incident)
        {
            throw new System.NotImplementedException();
        }

        public IResult<Incident> Delete(Incident incident)
        {
            throw new System.NotImplementedException();
        }

        public IResult<IEnumerable<Incident>> List()
        {
            return Result.Success(_context.Incidents.AsEnumerable());
        }

        public IResult<Incident> Update(Incident incident)
        {
            throw new System.NotImplementedException();
        }
    }
}