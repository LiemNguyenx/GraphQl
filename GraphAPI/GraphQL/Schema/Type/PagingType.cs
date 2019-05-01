using GraphAPI.Base;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.GraphQL.Schema.Type
{
    public class PagingType : ObjectGraphType<Paging>
    {
        public PagingType()
        {
            Name = "Paging";
            Field(x => x.PageNumber);
            Field(x => x.PageSize);
            Field(x => x.TotalPage);
            Field(x => x.TotalItems);
        }
    }
}
