using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfsluttendeOpgave
{
    /// <summary>
    /// This class is used to give players some gear to help their strength and defence capabilities. 
    /// </summary>
    internal class Equipment
    {

        /// <summary>
        /// This constructor takes 6 difference properties as information to help add complexity to the battle simulator in terms of weapon attrition, weight, damage and defence bonuses.
        /// </summary>
        /// <param name="name">Name of the equipment given to the player</param>
        /// <param name="isEquipped">Boolean check to see if weapon is currently equipped. If unequipped, the bonuses will not be given to the player</param>
        /// <param name="damageBonus">Damage boost for the player from the equipment piece</param>
        /// <param name="defenceBonus">Defence boost for the player from the equipment piece</param>
        /// <param name="durability">Attrition effect to the equipment piece. When durability reaches 0, equipment is unequiped.</param>
        /// <param name="weight">No real effect in this program.</param>
        public Equipment(string name, bool isEquipped, int damageBonus, int defenceBonus, int durability, int weight)
        {
            Name = name;
            IsEquipped = isEquipped;
            DamageBonus = damageBonus;
            DefenceBonus = defenceBonus;
            Durability = durability;
            Weight = weight;
        }

        /// <summary>
        /// Name of weapon
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Bool check for equipness
        /// </summary>
        public bool IsEquipped { get; set; }

        /// <summary>
        /// Damage bonus attribute for weapons and other cool stuff
        /// </summary>
        public int DamageBonus { get; set; }
        /// <summary>
        /// Defence bonus attribute for armour and other cool stuff
        /// </summary>
        public int DefenceBonus { get; set; }
        /// <summary>
        /// Attrition effect given to armour and weapons. 
        /// </summary>
        public int Durability {  get; set; }
        /// <summary>
        /// shits heavy yo
        /// </summary>
        public int Weight { get; set; }



    }
}
