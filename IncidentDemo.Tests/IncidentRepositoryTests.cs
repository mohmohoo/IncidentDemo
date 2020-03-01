using IncidentDemo.Models;
using IncidentDemo.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace IncidentDemo.Tests
{
    [TestClass]
    public class IncidentRepositoryTests
    {
        [TestMethod]
        public void ListTest()
        {
            var mockIncident = new Incident { Description = "Mock Description" };
            var mockContext = new IncidentDataContext
            {
                Incidents = new[] { mockIncident }
            };
            var target = new IncidentRepository(mockContext);
            var actuals = target.List();

            Assert.IsNotNull(actuals);
            Assert.IsTrue(actuals.Success);
            Assert.IsNotNull(actuals.Output);
            Assert.AreEqual(1, actuals.Output.Count());
            Assert.AreEqual(mockIncident.Description, actuals.Output.ToList()[0].Description);
        }
    }
}
