using IncidentDemo.Models;
using IncidentDemo.Repository;
using Ninject.Modules;

namespace IncidentDemo.DependencyInjection
{
    public class IncidentModule
        : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Incident>>().To<IncidentRepository>();
        }
    }
}