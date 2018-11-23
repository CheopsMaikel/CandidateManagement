using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Business.Query
{
    public interface IQueryHandler<TQuery> where TQuery : IQuery
    {
        Result Handle(TQuery query);
    }
}
