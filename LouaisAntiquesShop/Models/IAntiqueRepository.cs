using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LouaisAntiquesShop.Models
{
    public interface IAntiqueRepository
    {
        IEnumerable<AntiqueItem> GetAllAntiques();
        AntiqueItem GetAntiqueItemById(int itemId);

    }
}
