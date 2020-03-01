using IncidentDemo.Models;
using IncidentDemo.Repository;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IncidentDemo.DependencyInjection
{
    public class IncidentModule
        : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Incident>>().To<IncidentRepository>();
            Bind<IIncidentDataContext>()
                .ToConstant(new IncidentDataContext
                    {
                        Incidents = new []
                        {
                            new Incident
                            {
                                Id = 1,
                                Description = "Sample Incident Description",
                                HappenedAt = DateTime.Now,
                                IncidentTypes = new [] {
                                    new IncidentType { Description = "Incident Type 1" },
                                    new IncidentType { Description = "Incident Type 2" }
                                },
                                PersonInvolved = "Someone Unfortunate"
                            }
                        }
                    })
                .InSingletonScope();
        }
    }
}