using GraphAPI.GraphQL.GraphPlate;
using GraphAPI.Models;
using GraphAPI.Repository.Interfaces;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Graph.GraphPlate
{
    public class PlateQuery : ObjectGraphType
    {
        public PlateQuery(IDataRepository<Plate> db)
        {
            Field<ListGraphType<PlateType>>(
                "plates",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "first" },
                    new QueryArgument<IdGraphType> { Name = "offset" }
                    ),
                resolve: context =>
                {
                    var first = context.GetArgument<int>("first");
                    var offset = context.GetArgument<int>("offset");
                    return db.GetAll(first, offset);
                });
            Field<PlateType>(
                "plate",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType>
                    {
                        Name = "id",
                        Description = "Plate's id"
                    }),
                resolve: context =>
                {
                    var id = context.GetArgument<long>("id");
                    return db.Get(id);
                });
        }
    }
}
