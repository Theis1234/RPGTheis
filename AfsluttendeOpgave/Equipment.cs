using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfsluttendeOpgave
{
    internal class Equipment
    {
        public Equipment(string name, bool isEquipped, int damageBonus, int defenceBonus, int durability, int weight)
        {
            Name = name;
            IsEquipped = isEquipped;
            DamageBonus = damageBonus;
            DefenceBonus = defenceBonus;
            Durability = durability;
            Weight = weight;
        }

        public string Name { get; set; }
        public bool IsEquipped { get; set; }
        public int DamageBonus { get; set; }
        public int DefenceBonus { get; set; }
        public int Durability {  get; set; }
        public int Weight { get; set; }



    }
}
