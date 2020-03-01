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

        public IResult<Incident> Create(Incident incident)
        {
            _context.Incidents = _context.Incidents.Concat(new[] { incident });
            return Result.Success(incident, "Create success");
        }

        public IResult<Incident> Delete(Incident incident)
        {
            _context.Incidents = _context.Incidents.Where(x => x.Id != incident.Id);
            return Result.Success(incident, "Delete success");
        }

        public IResult<IEnumerable<Incident>> List()
        {
            return Result.Success(_context.Incidents.AsEnumerable(), "List success");
        }

        public IResult<Incident> Update(Incident incident)
        {
            throw new System.NotImplementedException();
        }
    }
}