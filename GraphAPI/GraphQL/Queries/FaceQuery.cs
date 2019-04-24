using GraphAPI.Models;
using GraphAPI.Repository.Interfaces;
using GraphQL.Types;

namespace GraphAPI.GraphQL.GraphFace
{
    public class FaceQuery : ObjectGraphType
    {
        public FaceQuery(IDataRepository<Face> db)
        {
            Field<ListGraphType<FaceType>>(
                "faces",
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
            Field<FaceType>(
                "face",
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
