using IncidentDemo.Models;
using System.Linq;

namespace IncidentDemo.Repository
{
    public class IncidentDataContext
        : IIncidentDataContext
    {
        public IQueryable<Incident> Incidents { get; set; }

        public IQueryable<IncidentType> IncidentTypes { get; set; }
    }
}