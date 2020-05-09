using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LouaisAntiquesShop.Models
{
    public class MockAntiqueRepository : IAntiqueRepository
    {
        private List<AntiqueItem> _antiques;

        public MockAntiqueRepository()
        {
            if (_antiques == null)
            {
                InitializeAntiques();
            }
        }

        private void InitializeAntiques()
        {
            _antiques = new List<AntiqueItem>
        {
            new AntiqueItem {Id = 1, Name = "Butchering Kit", Price = 543.61M, ShortDescription = "Vintage from the 1900s. coming out of a northern Vermont barn", LongDescription = "This is an absolutely amazing antique hand forged and professionally made knives, hooks, and chains hog butchering kit. The case is also beautifully done, handmade with its original leather strap, with fantastic original hardware.", ImageUrl = "https://i.etsystatic.com/6813572/r/il/dff3b8/1976026564/il_794xN.1976026564_ifs4.jpg", IsItemOfTheWeek = true, ImageThumbnailUrl = "https://i.etsystatic.com/6813572/r/il/dff3b8/1976026564/il_794xN.1976026564_ifs4.jpg"},
            new AntiqueItem {Id = 2, Name = "Antique Doll", Price = 123.22M, ShortDescription = "CONNIE Minie Pullip custom doll by Antique Shop Dolls", LongDescription = "Handmade Connie, Mini Pullip (fake) custom. All clothing included. SHOES NOT INCLUDED", ImageUrl = "https://i.etsystatic.com/6118176/r/il/650bd4/1778308311/il_fullxfull.1778308311_q1d2.jpg", IsItemOfTheWeek = false, ImageThumbnailUrl = "https://i.etsystatic.com/6118176/r/il/8a3985/1778308079/il_794xN.1778308079_i2bw.jpg"},
            new AntiqueItem {Id = 3, Name = "Leather Suitcases Collection", Price = 1144.34M, ShortDescription = "Leather Suitcases Vintage Luggage Collection from the 1930s", LongDescription = "A stunning collection of 5 x antique vintage suitcases in beautiful black and reddish brown leather, with an excellent aged patina. This charming set would do well as accent pieces to your interior decor or stacked for a real show stopper in the hallway, living room, bedroom or foyer. Would look super in both a designer style home or high-end retail setting. \\n They can also be used as photography props for backdrops, themed events or weddings, the choice is yours!", ImageUrl = "https://i.etsystatic.com/11418038/r/il/0fb3b6/1929603522/il_794xN.1929603522_nd0q.jpg", IsItemOfTheWeek = false, ImageThumbnailUrl = "https://i.etsystatic.com/11418038/r/il/d91172/1905567357/il_794xN.1905567357_n6xi.jpg"},
            new AntiqueItem {Id = 4, Name = "Vintage AMATI Trumpet", Price = 340.12M, ShortDescription = "Vintage AMATI Trumpet Instrument and Mouthpiece Brass Trumpet from the 1950s", LongDescription = "Vintage AMATI Trumpet Instrument and Mouthpiece Brass Trumpet with Case and Home decor Music shop decor Music love gift. \\n This Trumpet is AMATI-KRASLICE trade mark.Made in Socialist Czech Republic. \\n Schmidt's Mouthpiece \\n it's a rare collectible trumpet or perfect musical decor for your home, a music studio, a music store.", ImageUrl = "https://i.etsystatic.com/14975704/r/il/d16f9f/1968817928/il_794xN.1968817928_a37d.jpg", IsItemOfTheWeek = false, ImageThumbnailUrl = "https://i.etsystatic.com/14975704/r/il/9c9c7c/2016368567/il_794xN.2016368567_8kag.jpg"}
        };
        }

        public IEnumerable<AntiqueItem> GetAllAntiques()
        {
            return _antiques;
        }

        public AntiqueItem GetAntiqueItemById(int itemId)
        {
            return _antiques.FirstOrDefault(a => a.Id == itemId);
        }
    }
}
