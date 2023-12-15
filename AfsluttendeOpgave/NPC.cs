using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfsluttendeOpgave
{
    internal class NPC : Character
    {
        public NPC(string name, int hP, int xP) : base(name, hP, xP)
        {
        }

        public NPC(string name, int hP, int xP, NPCtype npcType) : base(name, hP, xP)
        {
            Name = name;
            HP = hP;
            XP = xP;
            this.NpcType = npcType;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }


        public NPCtype NpcType { get; set; }

        public override void Attack(Character playerCharacter)
        {
            int damage = Damage();
            
            playerCharacter.HP -= damage;

            return;

        }

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

       
        public int SetHP(Enum npcType)
        {
            switch (npcType)
            {
                case NPCtype.Human:
                    return HP = 100;

                case NPCtype.Skeleton:
                    return HP = 70;
                    
                case NPCtype.Demon:
                    return HP = 800;

                case NPCtype.Giant:
                    return HP = 150;

                case NPCtype.Dragon:
                    return HP = 300;

                case NPCtype.Boomer:
                    return HP = 50;

                case NPCtype.Herobrine:
                    return HP = 1000000;

                case NPCtype.Rat:
                    return HP = 20;

                case NPCtype.Dwarf:
                    return HP = 110;

                case NPCtype.Bananaperson:
                    return HP = 18;

                default: return 0;
            }
        }
        public int SetXP(Enum npcType)
        {
            switch (npcType)
            {
                case NPCtype.Human:
                    return XP = 200;

                case NPCtype.Skeleton:
                    return XP = 130;

                case NPCtype.Demon:
                    return XP = 2000;

                case NPCtype.Giant:
                    return XP = 340;

                case NPCtype.Dragon:
                    return XP = 1000;

                case NPCtype.Boomer:
                    return XP = 90;

                case NPCtype.Herobrine:
                    return XP = -1;

                case NPCtype.Rat:
                    return XP = 20;

                case NPCtype.Dwarf:
                    return XP = 205;

                case NPCtype.Bananaperson:
                    return XP = 18;

                default: return 0;
            }
        }

    }
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
