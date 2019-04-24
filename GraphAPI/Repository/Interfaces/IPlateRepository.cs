using GraphAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Repository.Interfaces
{
    public interface IPlateRepository
    {
        IEnumerable<Plate> GetAllForOwner(long ownerId);
        IEnumerable<Plate> GetAllForOwner(long ownerId, DateTime lastFound);
    }
}
