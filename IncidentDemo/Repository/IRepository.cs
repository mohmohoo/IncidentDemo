using System.Collections.Generic;

namespace IncidentDemo.Repository
{
    public interface IRepository<TRepoObject>
    {
        IResult<TRepoObject> Get(int id);

        IResult<TRepoObject> Create(TRepoObject incident);

        IResult<TRepoObject> Update(TRepoObject incident);

        IResult<TRepoObject> Delete(TRepoObject incident);

        IResult<IEnumerable<TRepoObject>> List();
    }
}