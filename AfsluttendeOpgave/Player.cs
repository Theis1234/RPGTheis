using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AfsluttendeOpgave
{

    /// <summary>
    /// The class player is the entire player object including player's methods of combat and properties. 
    /// </summary>
    internal class Player : Character
    {
        
        /// <summary>
        /// Player constructor with constructor information from parent class Character, also a List is given to the player to give the player damage and defence bonuses. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hP"></param>
        /// <param name="xP"></param>
        /// <param name="equipment"></param>
        public Player(string name, int hP, int xP, List<Equipment> equipment) : base(name, hP, xP)
        {
            Equipment = equipment;
        }
        /// <summary>
        /// Empty constructor yo
        /// </summary>
        /// <param name="name">Gets value through base class</param>
        /// <param name="hP">Gets hp value through base class</param>
        /// <param name="xP">Gets XP value through base class</param>
        public Player(string name, int hP, int xP) : base(name, hP, xP)
        {
        }

        
        /// <summary>
        /// This property was meant to be used to decrease opponent damage based on defence bonus. But I did not have enough time to implement it.
        /// </summary>
        public int TotalDefenceBonus
        {
            get { return Equipment.Sum(e => e.DefenceBonus); }
        }


        public List<Equipment> Equipment = new List<Equipment>();

        /// <summary>
        /// Will handle the attack logic, such as dealing damage, and making sure that equipment will we unequiped if no longer durable. 
        /// </summary>
        /// <param name="opponentCharacter"></param>
        public override void Attack(Character opponentCharacter)
        {
            int damage = Damage(20);
            foreach (var equipment in Equipment)
            {
                if (equipment.IsEquipped)
                {
                    equipment.Durability -= 1;
                    if (equipment.Durability <= 0)
                    {
                        equipment.IsEquipped = false;
                    }
                }
            }
            opponentCharacter.HP -= damage;
            

            return;

        }

        /// <summary>
        /// Method will calculate damage based on equipped weapons with damagebonus added to them. 
        /// </summary>
        /// <returns></returns>
        public int Damage(int amount)
        {
            int damage = amount;

            foreach (var item in Equipment)
            {
                if (item.IsEquipped)
                {
                    damage += item.DamageBonus;
                }
            }
            return damage;
        }
        


    }
}
