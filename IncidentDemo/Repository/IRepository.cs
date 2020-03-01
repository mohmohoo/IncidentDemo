using IncidentDemo.Models;
using System.Collections.Generic;

namespace IncidentDemo.Repository
{
    public interface IRepository
    {
        IResult<IIncident> Add(IIncident incident);

        IResult<IIncident> Update(IIncident incident);

        IResult<IIncident> Delete(IIncident incident);

        IResult<IEnumerable<IIncident>> List();
    }
}