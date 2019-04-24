using GraphAPI.Models;
using GraphQL.Types;

namespace GraphAPI.GraphQL.GraphPlate
{
    public class PlateType : ObjectGraphType<Plate>
    {
        public PlateType()
        {
            Name = "Plate";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Plate's Id");
            Field(x => x.Number).Description("Plate's Number");
            Field(x => x.Location).Description("Plate's Location");
            Field(x => x.LastFound).Description("Plate's LastFound");
            Field(x => x.CreateAt).Description("Create At");
            Field(x => x.ModifyDate).Description("Modify Date");
        }
    }
}
