using System;

namespace IncidentDemo.Models
{
    public class Incident
    {
        public IncidentType[] IncidentTypes { get; set; }

        public DateTime HappenedAt { get; set; }

        public string Description { get; set; }

        public string PersonInvolved { get; set; }
    }
}