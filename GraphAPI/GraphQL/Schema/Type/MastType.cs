using GraphAPI.Base;
using GraphAPI.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.GraphQL.Schema.Type
{
    public class MastType : ObjectGraphType<Mast>
    {
        public MastType()
        {
            Field(x => x.Lat);
            Field(x => x.Lon);
        }
    }
    public class FilteredMastType : ObjectGraphType<FilterContext<Mast, FilterMastParam>>
    {
        public FilteredMastType()
        {
            Field<ListGraphType<MastType>>(
                "masts",
                resolve: context => context.Source.Data
            );
            Field<PagingType>(
                "paging",
                resolve: context => context.Source.Paging
            );
            //Field<ComplexGraphType<FilterMastParam>>(
            //    "filterParams",
            //    resolve: context => context.Source.FilterParams
            //);
        }
    }
}
