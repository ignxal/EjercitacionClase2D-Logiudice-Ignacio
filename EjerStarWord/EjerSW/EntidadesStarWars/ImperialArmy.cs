using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesStarWars
{
    public class ImperialArmy
    {
        private int capability;
        private List<Trooper> troopers;

        public List<Trooper> Troopers { get => troopers; }

        private ImperialArmy()
        {
            List<Trooper> troopers = new();
        }

        public ImperialArmy(int capability)
        {
            this.capability = capability;
        }

        public bool AddTrooper(Trooper soldier)
        {
            if(this.Troopers.Count < this.Troopers.Capacity)
            {
                this.Troopers.Add(soldier);
                return true;
            }

            return false;
        }

        public bool DeleteTrooper(Trooper soldier)
        {
            Trooper trooperToRemove = this.Troopers.Find(x => x.Type == soldier.Type);
            return this.Troopers.Remove(trooperToRemove);
        }
    }
}
