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

        public IResult<Incident> Get(int id)
        {
            var incident = _context.Incidents.Where(i => i.Id == id).SingleOrDefault();
            return Result.Success(incident, "Get success");
        }

        public IResult<Incident> Create(Incident incident)
        {
            _context.Incidents = _context.Incidents.Concat(new[] { incident }).ToArray();
            return Result.Success(incident, "Create success");
        }

        public IResult<Incident> Delete(Incident incident)
        {
            _context.Incidents = _context.Incidents.Where(x => x.Id != incident.Id).ToArray();
            return Result.Success(incident, "Delete success");
        }

        public IResult<IEnumerable<Incident>> List()
        {
            return Result.Success(_context.Incidents.AsEnumerable(), "List success");
        }

        public IResult<Incident> Update(Incident incident)
        {
            _context
                .Incidents
                .Where(i => i.Id == incident.Id)
                .ToList()
                .ForEach(i => {
                    i.IncidentTypes = incident.IncidentTypes;
                    i.Description = incident.Description;
                    i.HappenedAt = incident.HappenedAt;
                    i.PersonInvolved = incident.PersonInvolved;
                });
            return Result.Success(incident, "Update Success");
        }
    }
}