using LouaisAntiquesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LouaisAntiquesShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<AntiqueItem> Antiques { get; set; }
    }
}
