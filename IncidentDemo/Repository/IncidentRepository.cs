using System.Collections.Generic;
using IncidentDemo.Models;

namespace IncidentDemo.Repository
{
    public class IncidentRepository
        : IRepository<Incident>
    {
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
            throw new System.NotImplementedException();
        }

        public IResult<Incident> Update(Incident incident)
        {
            throw new System.NotImplementedException();
        }
    }
}