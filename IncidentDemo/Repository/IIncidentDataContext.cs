using IncidentDemo.Models;
using System.Linq;

namespace IncidentDemo.Repository
{
    public interface IIncidentDataContext
    {
        IQueryable<Incident> Incidents { get; }

        IQueryable<IncidentType> IncidentTypes { get; }
    }
}