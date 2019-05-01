using GraphAPI.GraphQL.Schema.Type;
using GraphAPI.Repository.Interfaces;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.GraphQL.Schema.Query
{
    public class MastQuery : ObjectGraphType<object>
    {
        public MastQuery(IMastRepository mastService)
        {
            Field<FilteredMastType>(
                "filteredmast",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name="pageSize", Description="size of page"},
                    new QueryArgument<IntGraphType> { Name = "pageNumber", Description = "page of list data" },
                    new QueryArgument<IntGraphType> { Name = "lon", Description = "filter params" },
                    new QueryArgument<IntGraphType> { Name = "lat", Description = "filter params" }
                ),
                resolve: context => {
                    int pageSize = context.GetArgument<int>("pageSize");
                    int pageNumber = context.GetArgument<int>("pageNumber");
                    int? lon = context.GetArgument<int?>("lon", defaultValue : null);
                    int? lat = context.GetArgument<int?>("lat", defaultValue: null);
                    return mastService.GetMast(pageSize,pageNumber,lon,lat);
                }
            );
        }
    }
}
