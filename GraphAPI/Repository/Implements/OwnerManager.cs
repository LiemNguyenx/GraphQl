using GraphAPI.Models;
using GraphAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Repository.Implements
{
    public class OwnerManager : IDataRepository<Owner>
    {
        readonly GraphDbContext _graphDbContext;

        public OwnerManager(GraphDbContext graphDbContext)
        {
            _graphDbContext = graphDbContext;
        }
        public Owner Add(Owner entity)
        {
            _graphDbContext.Add(entity);
            _graphDbContext.SaveChanges();
            return entity;
        }

        public void Delete(Owner entity)
        {
            throw new NotImplementedException();
        }

        public Owner Get(long id)
        {
            return _graphDbContext.Owners.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Owner> GetAll(int first, int offset)
        {
            return _graphDbContext.Owners.Skip(offset).Take(first);
        }

        public void Update(Owner dbEntity, Owner entity)
        {
            throw new NotImplementedException();
        }
    }
}
