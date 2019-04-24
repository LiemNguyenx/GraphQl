using GraphAPI.GraphQL;
using GraphAPI.GraphQL.GraphOwner;
using GraphAPI.Models;
using GraphAPI.Repository.Interfaces;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Mutations
{
    public class OwnerMutation : ObjectGraphType
    {
        public OwnerMutation(IDataRepository<Owner> _ownerRepo)
        {
            Field<OwnerType>(
                "addOwner",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<OwnerInputType>> { Name = "owner" }),
                resolve: context =>
                {
                    var owner = context.GetArgument<Owner>("owner");
                    return _ownerRepo.Add(owner);
                }
                );
        }
    }
}
