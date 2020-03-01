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
                        Incidents = new List<Incident>
                        {
                            new Incident
                            {
                                Description = "Sample Incident Description",
                                HappenedAt = DateTime.Now,
                                IncidentTypes = new IncidentType[0],
                                PersonInvolved = "Someone Unfortunate"
                            }
                        }.AsQueryable()
                    })
                .InSingletonScope();
        }
    }
}