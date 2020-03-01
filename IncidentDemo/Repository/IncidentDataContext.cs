using IncidentDemo.Models;
using System.Collections.Generic;

namespace IncidentDemo.Repository
{
    public class IncidentDataContext
        : IIncidentDataContext
    {
        public IList<Incident> Incidents { get; set; }

        public IList<IncidentType> IncidentTypes { get; set; }
    }
}