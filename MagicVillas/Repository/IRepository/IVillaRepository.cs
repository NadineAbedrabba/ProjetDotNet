
using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVillas.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
      
        Task<Villa> UpdateAsync(Villa entity);

        
    }
}
