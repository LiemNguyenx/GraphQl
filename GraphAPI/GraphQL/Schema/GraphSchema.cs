//using GraphAPI.GraphQL.GraphOwner;
//using GraphAPI.Mutations;
using GraphAPI.GraphQL.Schema.Query;
using GraphQL;
using GraphQL.Types;

namespace GraphAPI.Graph
{
    public class GraphSchema : Schema
    {
        public GraphSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<MastQuery>();
            //Query = resolver.Resolve<OwnerQuery>();
            //Mutation = resolver.Resolve<OwnerMutation>();
        }
    }
}
