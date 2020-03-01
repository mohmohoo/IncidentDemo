using System;

namespace IncidentDemo.Models
{
    public interface IIncident
    {
        IIncidentType[] IncidentTypes { get; }

        DateTime HappenedAt { get; }

        string Description { get; }

        string PersonInvolved { get; }
    }
}