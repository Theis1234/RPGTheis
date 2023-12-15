using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfsluttendeOpgave
{
    internal abstract class Character
    {
        protected Character(string name, int hP, int xP)
        {
            Name = name;
            HP = hP;
            XP = xP;
        }


        /// <summary>
        /// Name of either the player or the monster
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Hitpoints of either the monster or the player that will be used in the battle simulator.
        /// </summary>
        public int HP { get; set; }
        /// <summary>
        /// If NPC, it is the experience gained from killing an NPC, if Player, is the player's current experience point value. 
        /// </summary>
        public int XP { get; set; }

        /// <summary>
        /// Method that forces the child classes NPC and Player to implement the Attack method. 
        /// </summary>
        /// <param name="character"></param>
        public abstract void Attack(Character character);
        
        /// <summary>
        /// You can write the damage as a parameter to this method. I have chosen to not implement this exact damage method in my child objects
        /// due to having a different idea on how to do the damage calculation.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int Damage(int number)
        {
            return number; 
        }
        /// <summary>
        /// This method will check to see if either side has succumbed to their fate
        /// </summary>
        /// <returns></returns>
        public bool CheckIfDead()
        {
            if (HP <= 0) return true;
            else return false;
        }
    }
}
