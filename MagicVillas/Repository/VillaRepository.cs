using MagicVilla_VillaAPI.Models;
using MagicVillas.Data;
using MagicVillas.Repository.IRepository;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace MagicVillas.Repository
{
    public class VillaRepository : Repository<Villa> , IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db): base (db)
        {
            _db = db;
        }
    



   
        
        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
            
        }


    }

   
}
