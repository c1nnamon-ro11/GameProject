using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebInterfaceGame.Models
{
    public class ViewModel
    {
        static public List<ViewModel> GameUnits { get; set; } = new List<ViewModel>()
        {
            new ViewModel {Id=1, Name = "Asteroid", Power = "50", Damage = "15",
                Features = "In a collision, reduces your level (and at the same time weapons) by 1. Destruction leads to the release of four more charges.",
                LoreDescribe ="This stone is capable of destroying your weapons, has interesting consequences."},
            new ViewModel {Id=2, Name = "Charge", Power = "5", Damage = "5", 
                Features ="Spawned by destroyed Asteroid.",
                LoreDescribe ="Finally destroyed?"},
            new ViewModel {Id=3, Name = "Rocket", Power = "5", Damage = "10",
                Features ="Very fast object that increases its speed over time. Compensated by predictable trajectory.",
                LoreDescribe ="Fast. Accurate. Painful."},
            new ViewModel {Id=4, Name = "Star", Power = "10", Damage = "10",
                Features ="Small size and high speed make the star a dangerous obstacle.",
                LoreDescribe ="A strange trajectory will often confuse."},
            new ViewModel {Id=5, Name = "Boss", Power = "?", Damage = "?",
                Features ="?",
                LoreDescribe ="The most dangerous enemy. Stay away from him as much as possible."},
        }.ToList();

        static public List<string> Scoreboard { get; set; } = new List<string>();
        static public int Count { get { return count; } set { value = count; } }
        static private int count = GameUnits.Count();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        public string Damage { get; set; }
        public string Features { get; set; }
        public string LoreDescribe { get; set; }
    }
}