using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphAPI.Models;
namespace GraphAPI.GraphQL.Schema.Type
{
    public class ConfigType : ObjectGraphType<ConfigurationType>
    {
        public ConfigType()
        {
            Field(x => x.Name);
        }
    }
}
