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

        public string Name { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }

        public abstract void Attack(Character character);
        

        public int Damage()
        {
            throw new NotImplementedException();
        }

        public bool IsDead()
        {
            if (HP <= 0) return true;
            else return false;
        }
    }
}
