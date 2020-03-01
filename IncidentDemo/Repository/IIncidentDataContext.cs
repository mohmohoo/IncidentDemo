using IncidentDemo.Models;
using System.Collections.Generic;

namespace IncidentDemo.Repository
{
    public interface IIncidentDataContext
    {
        IList<Incident> Incidents { get; set; }

        IList<IncidentType> IncidentTypes { get; set; }
    }
}