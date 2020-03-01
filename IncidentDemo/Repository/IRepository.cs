using IncidentDemo.Models;
using System.Collections.Generic;

namespace IncidentDemo.Repository
{
    public interface IRepository
    {
        IResult<Incident> Add(Incident incident);

        IResult<Incident> Update(Incident incident);

        IResult<Incident> Delete(Incident incident);

        IResult<IEnumerable<Incident>> List();
    }
}