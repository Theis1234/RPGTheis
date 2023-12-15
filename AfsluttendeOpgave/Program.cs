using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfsluttendeOpgave
{
    internal class Program
    {
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
                NPC nPC = new NPC("Skeletor", 4000, 5000, NPCtype.Skeleton);

                while (!player.IsDead() && !nPC.IsDead())
                {
                    player.Attack(nPC);
                    if (!nPC.IsDead())
                    {
                        nPC.Attack(player);
                    }
                }
                if (player.HP <= 0)
                {
                    Console.WriteLine("Player has died");
                }
                else
                {
                    Console.WriteLine("NPC has died");
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong in the battle sim");
            }



        }

    }
}
