using System.Collections.Generic;

namespace IncidentDemo.Repository
{
    public interface IRepository<TRepoObject>
    {
        IResult<TRepoObject> Add(TRepoObject incident);

        IResult<TRepoObject> Update(TRepoObject incident);

        IResult<TRepoObject> Delete(TRepoObject incident);

        IResult<IEnumerable<TRepoObject>> List();
    }
}