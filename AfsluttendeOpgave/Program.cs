using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfsluttendeOpgave
{
    internal class Program
    {
        /// <summary>
        /// This method is responsible for running the battle simulation between player and NPC. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Equipment> playerEquipment = new List<Equipment>()
            {
                new Equipment("Sword",true,20,120,200,30),
                new Equipment("Shield",true,0,10,60,100),
                new Equipment("Platebody",true,0,50,30,60),
                new Equipment("Platelegs",false,0,40,20,100),
                new Equipment("Helmet",true,0,25,20,40)

            };
            try
            {
                Player player = new Player("TheLegend27", 100, 100000, playerEquipment);
                NPC npc = new NPC("Skeletor", 200, 500, NPCtype.Skeleton);

                int value = player.HP;
                while (!player.CheckIfDead() && !npc.CheckIfDead())
                {
                    player.Attack(npc);
                    if (!npc.CheckIfDead())
                    {
                        npc.Attack(player);
                    }
                }
                if (npc.HP <= 0)
                {
                    Console.WriteLine("NPC has died");
                    Console.WriteLine($"Gained {npc.XP}");
                    player.XP += npc.XP;
                }
                if (player.HP <= 0)
                {
                    Console.WriteLine("Player has died");
                    
                }
                

            }
            catch
            {
                Console.WriteLine("Something went wrong in the battle sim");
            }



        }

    }
}
