using GraphAPI.Models;
using GraphAPI.Repository.Interfaces;
using GraphQL.Types;


namespace GraphAPI.GraphQL.GraphOwner
{
    public class OwnerQuery : ObjectGraphType
    {
        public OwnerQuery(IDataRepository<Owner> db)
        {
            Field<OwnerType>(
                "Owner",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id" }
                    ),
                resolve: context =>
                {
                    var id = context.GetArgument<long>("id");
                    return db.Get(id);
                });
            Field<ListGraphType<OwnerType>>(
                "Owners",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "first" },
                    new QueryArgument<IdGraphType> { Name = "offset" }
                    ),
                resolve: context =>
                {
                    var first = context.GetArgument<int?>("first") ?? 3;
                    var offset = context.GetArgument<int?>("offset") ?? 0;
                    return db.GetAll(first, offset);
                });
        }
    }
}
