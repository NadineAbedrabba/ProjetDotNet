using MagicVilla_VillaAPI.Models;
using MagicVillas.Data;
using MagicVillas.Repository.IRepository;
using System.Linq.Expressions;

namespace MagicVillas.Repository
{
    public class VillaRepository : IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    



    public Task Create(Villa entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Villa>> Get(Expression<Func<Villa>> filter = null, bool tracked = true)
        {
            throw new NotImplementedException();
        }

        public Task<List<Villa>> GetAll(Expression<Func<Villa>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Villa entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }

    internal class ApplcationDbContext
    {
    }
}
