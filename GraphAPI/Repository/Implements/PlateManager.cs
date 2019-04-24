using GraphAPI.Models;
using GraphAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Repository.Implements
{
    public class PlateManager : IPlateRepository
    {

        readonly GraphDbContext _graphDbContext;

        public PlateManager(GraphDbContext graphDbContext)
        {
            _graphDbContext = graphDbContext;
        }

        public void Add(Plate entity)
        {
            _graphDbContext.Plates.Add(entity);
            _graphDbContext.SaveChanges();
        }


        public void Delete(Plate entity)
        {
            _graphDbContext.Plates.Remove(entity);
            _graphDbContext.SaveChanges();
        }

        public Plate Get(long id)
        {
            return _graphDbContext.Plates.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Plate> GetAll(int first = 3, int offset = 0)
        {
            return _graphDbContext.Plates.Skip(offset).Take(2);
        }

        public IEnumerable<Plate> GetAllForOwner(long ownerId)
        {
            return _graphDbContext.Plates.Where(x => x.OwnerId == ownerId);
        }

        public IEnumerable<Plate> GetAllForOwner(long ownerId, DateTime lastFound)
        {
            return _graphDbContext.Plates.Where(x => x.OwnerId == ownerId && x.LastFound.Date == lastFound.Date);
        }

        public void Update(Plate dbEntity, Plate entity)
        {
            dbEntity.OwnerId = entity.OwnerId;
            dbEntity.LastFound = entity.LastFound;
            dbEntity.ModifyDate = entity.ModifyDate;
            dbEntity.Number = entity.Number;

            _graphDbContext.SaveChanges();
        }
    }
}
