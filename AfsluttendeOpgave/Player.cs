using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfsluttendeOpgave
{
    internal class Player : Character
    {
        

        public Player(string name, int hP, int xP, List<Equipment> equipment) : base(name, hP, xP)
        {
            Equipment = equipment;
        }

        public Player(string name, int hP, int xP) : base(name, hP, xP)
        {
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }


        public List<Equipment> Equipment = new List<Equipment>();

        public override void Attack(Character opponentCharacter)
        {
            int damage = Damage();
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

        int Damage()
        {
            int damage = 0;

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
