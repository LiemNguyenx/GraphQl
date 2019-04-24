using GraphAPI.Models;
using GraphAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Repository.Implements
{
    public class FaceManager : IDataRepository<Face>
    {
        readonly GraphDbContext _graphDbContext;

        public FaceManager(GraphDbContext graphDbContext)
        {
            _graphDbContext = graphDbContext;
        }
        public Face Add(Face entity)
        {
            _graphDbContext.Faces.Add(entity);
            _graphDbContext.SaveChanges();
            return entity;
        }

        public void Delete(Face entity)
        {
            _graphDbContext.Faces.Remove(entity);
            _graphDbContext.SaveChanges();
        }

        public Face Get(long id)
        {
            return _graphDbContext.Faces.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Face> GetAll(int first = 3, int offset = 0)
        {
            return _graphDbContext.Faces.Skip(offset).Take(2);
        }

        public void Update(Face dbEntity, Face entity)
        {
            dbEntity.OwnerId = entity.OwnerId;
            dbEntity.LastFound = entity.LastFound;
            dbEntity.ModifyDate = entity.ModifyDate;
            dbEntity.Img = entity.Img;

            _graphDbContext.SaveChanges();
        }
    }
}
