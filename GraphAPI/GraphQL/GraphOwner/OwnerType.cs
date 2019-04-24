using System;
using GraphAPI.GraphQL.GraphFace;
using GraphAPI.GraphQL.GraphPlate;
using GraphAPI.Models;
using GraphAPI.Repository.Interfaces;
using GraphQL.Types;

namespace GraphAPI.GraphQL
{
    public class OwnerType : ObjectGraphType<Owner>
    {
        public OwnerType(IPlateRepository plateRepository)
        {
            Name = "Owner";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Owner's Id");
            Field(x => x.Name).Description("Owner's Name");
            Field(x => x.Email).Description("Owner's Email");
            Field(x => x.PhoneNumber).Description("Owner's Number");
            Field(x => x.Address).Description("Owner's Address");
            Field(x => x.LastFound).Description("Owner's LastFound");
            Field(x => x.CreateAt).Description("Create At");
            Field(x => x.ModifyDate).Description("Modify Date");

            Field<ListGraphType<PlateType>>("plates",
                arguments: new QueryArguments(new QueryArgument<DateTimeGraphType> { Name = "timefound" }),
                resolve: context => {
                    var timefound = context.GetArgument<DateTime>("timefound");
                    return timefound == null
                        ? plateRepository.GetAllForOwner(context.Source.Id)
                        : plateRepository.GetAllForOwner(context.Source.Id,timefound);
            },description: "Owner's Plates");

            Field(x => x.Faces, type: typeof(ListGraphType<FaceType>)).Description("Modify Date");
        }
    }
}
