using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.GraphQL.GraphOwner
{
    public class OwnerInputType : InputObjectGraphType
    {
        public OwnerInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("phonenumber");
            Field<StringGraphType>("address");
            Field<StringGraphType>("email");
        }
    }
}
