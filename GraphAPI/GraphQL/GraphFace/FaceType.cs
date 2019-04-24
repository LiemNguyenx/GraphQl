using GraphAPI.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.GraphQL.GraphFace
{
    public class FaceType : ObjectGraphType<Face>
    {
        public FaceType()
        {
            Name = "Face";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Face'ss Id");
            Field(x => x.Img).Description("Face'ss Img");
            Field(x => x.Location).Description("Face'ss Location");
            Field(x => x.LastFound).Description("Face'ss LastFound");
            Field(x => x.CreateAt).Description("Create At");
            Field(x => x.ModifyDate).Description("Modify Date");
        }
    }
}
