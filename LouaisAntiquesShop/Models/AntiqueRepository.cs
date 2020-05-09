using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LouaisAntiquesShop.Models
{
    public class AntiqueRepository : IAntiqueRepository
    {
        private readonly AppDbContext _appDbContext;

        public AntiqueRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<AntiqueItem> GetAllAntiques()
        {
            return _appDbContext.Antiques;
        }

        public AntiqueItem GetAntiqueItemById(int itemId)
        {
            return _appDbContext.Antiques.FirstOrDefault(a => a.Id==itemId );
        }
    }
}
