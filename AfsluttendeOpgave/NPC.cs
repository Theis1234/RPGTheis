using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfsluttendeOpgave
{
    internal class NPC : Character
    {
        /// <summary>
        /// Empty constructor, inherits values from parent class Character. 
        /// </summary>
        /// <param name="name">Name of monster</param>
        /// <param name="hP">Life points of monster</param>
        /// <param name="xP">Experience points gained if killed</param>
        public NPC(string name, int hP, int xP) : base(name, hP, xP)
        {
        }

        /// <summary>
        /// Constructor will values that are inherited from the parent class Character, with an additional parameter NPCtype, to give the battlesimulator some variation of opponents.
        /// </summary>
        /// <param name="name">Name of monster</param>
        /// <param name="hP">Life points of monster</param>
        /// <param name="xP">Experience points gained if killed</param>
        /// <param name="npcType">Enum type of monster identity</param>
        public NPC(string name, int hP, int xP, NPCtype npcType) : base(name, hP, xP)
        {
            this.NpcType = npcType;
        }

        /// <summary>
        /// Helps globalize the npctype enum so it can be used in the damage calculation switch case.
        /// </summary>
        public NPCtype NpcType { get; set; }
        /// <summary>
        /// Method will substract the damage dealt to character, from their current hitpoints. 
        /// </summary>
        /// <param name="character">parsed in to calculate new hitpoints for opponent</param>
        public override void Attack(Character character)
        {
            int damage = Damage();

            character.HP -= damage;

            return;

        }

        /// <summary>
        /// Calculates the damage based on npctype enum. Different monsters have different difficulty, therefore different damage points.
        /// It is intentional that I am not using the parent method as I thought this one without an int parameter would be better
        /// </summary>
        /// <returns>Damage number given to opponent's hitpoints</returns>
        public int Damage()
        {
            switch (NpcType)
            {
                case NPCtype.Human:
                    return 5;

                case NPCtype.Skeleton:
                    return 8;

                case NPCtype.Demon:
                    return 10;

                case NPCtype.Giant:
                    return 6;

                case NPCtype.Dragon:
                    return 12;

                case NPCtype.Boomer:
                    return 2;

                case NPCtype.Herobrine:
                    return 1000000;

                case NPCtype.Rat:
                    return 1;

                case NPCtype.Dwarf:
                    return 8;

                case NPCtype.Bananaperson:
                    return 2;

                default: return 0;
            }
        }

    }
    /// <summary>
    /// Different types of NPCs that can be fought in the program. Only damage will be calculated based on these values, as some attributes were specified to be calculated elsewhere by assignment.
    /// </summary>
    enum NPCtype
    {
        Human,
        Skeleton,
        Demon,
        Giant,
        Dragon,
        Boomer,
        Herobrine,
        Rat,
        Dwarf,
        Bananaperson
    }
}
