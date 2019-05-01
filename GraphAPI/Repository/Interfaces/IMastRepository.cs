using GraphAPI.Base;
using GraphAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Repository.Interfaces
{
    public interface IMastRepository
    {
        Mast GetMastById(int id);
        FilterContext<Mast, FilterMastParam> GetMast(int pageSize, int pageNumber, int? lon, int? lat);
    }
}
