using GraphAPI.GraphQL.GraphOwner;
using GraphAPI.Mutations;
using GraphQL;
using GraphQL.Types;

namespace GraphAPI.Graph
{
    public class GraphSchema : Schema
    {
        public GraphSchema(IDependencyResolver resolver) : base(resolver)
        {
            //Query = resolver.Resolve<PlateQuery>();
            Query = resolver.Resolve<OwnerQuery>();
            Mutation = resolver.Resolve<OwnerMutation>();
        }
    }
}
