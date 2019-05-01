using GraphAPI.Base;
using GraphAPI.Models;
using GraphAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Repository.Implements
{
    public class MastService : IMastRepository
    {
        private readonly GraphDbContext dbContext;
        public MastService(GraphDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public FilterContext<Mast, FilterMastParam> GetMast(int pageSize = 2, int pageNumber = 1, int? lon = null, int? lat = null)
        {
            IEnumerable<Mast> filterd;
            filterd = dbContext.Masts;
            if (lon != null)
            {
                filterd = filterd.Where(x => x.Lon == lon);
            }
            if (lat != null)
            {
                filterd = filterd.Where(x => x.Lat == lat);
            }
            FilterContext<Mast, FilterMastParam> masts = new FilterContext<Mast, FilterMastParam>(filterd, pageSize, pageNumber);
            masts.FilterParams = new FilterMastParam
            {
                Lat = lat,
                Lon = lon
            };
            return masts;
        }

        public Mast GetMastById(int id)
        {
            return dbContext.Masts.FirstOrDefault();
        }
    }
}
