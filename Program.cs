using problem2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            player alice = new player("Alice", 110, 50, 10);
            player bob = new player("bob", 100, 60, 20);

            stats fireball = new stats("fireball", 23, 12, 5, 15, "a fiery attack");
            alice.learnSkill(fireball);
            Console.WriteLine(alice.attack(bob));
            

            stats superburn = new stats("super", 200, 50, 50, 75, "an overpower attack");
            bob.learnSkill(superburn);
            Console.WriteLine(bob.attack(alice));
            Console.ReadKey();

            Console.WriteLine("Play magical duel");
            Console.WriteLine("option 1: Add player");
            Console.WriteLine("option 2: Add Skill Statistics");
            Console.WriteLine("option 3: Display player info");
            Console.WriteLine("option 4: Learn a skill");
            Console.WriteLine("option 5: Attack");
            Console.WriteLine("Exit");

            List<player> Players=new List<player>();
            List<stats> Skill = new List<stats>();





            int option=0;
            while (option != 6)
            {
                Console.WriteLine("Enter option to continue");
                option = int.Parse(Console.ReadLine());
                if (option==1)
                {
                    player a = addPlayer();
                    Players.Add(a);
                }
                else if(option==2) 
                {
                    stats b = addSkill();
                    Skill.Add(b);
                }
                else if(option==3) 
                {
                    display_Player_info(Players);
                }
                else if(option==4)
                {
                    Console.WriteLine("Enter player name");
                    string val=Console.ReadLine();
                    Console.WriteLine("Enter skill name");
                    string val2 = Console.ReadLine();
                    int playerpos=0, skillpos=0;
                    for (int i = 0;i<Players.Count;i++)
                    {
                        if (Players[i].name==val)
                        {
                            playerpos = i;
                        }
                    }
                    for (int i = 0; i < Skill.Count; i++)
                    {
                        if (Skill[i].name == val2)
                        {
                            skillpos = i;
                        }
                    }
                    Players[playerpos].learnSkill(Skill[skillpos]);
                }
                else if(option==5)
                {
                    Console.WriteLine("Enter player name which atacks");
                    string val = Console.ReadLine();
                    Console.WriteLine("Enter player on which attack in conducted");
                    string val2 = Console.ReadLine();
                    int playertoAttackpos = 0, attackedPlayer = 0;
                    for (int i = 0; i < Players.Count; i++)
                    {
                        if (Players[i].name == val)
                        {
                            playertoAttackpos = i;
                        }
                        else if (Players[i].name == val2)
                        {
                            attackedPlayer = i;
                        }
                    }
                    Console.WriteLine(Players[playertoAttackpos].attack(Players[attackedPlayer]));

                }
                else if(option==6)
                {
                    break;
                }
            }

           

        }
        public static player addPlayer()
        {
            Console.WriteLine("Enter player name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter health");
            double health= double.Parse(Console.ReadLine());

            Console.WriteLine("Enter player maxhealth");
            double maxhealth = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter energy");
            double energy = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter player maxenergy");
            double maxenergy = double.Parse(Console.ReadLine());

            

            Console.WriteLine("Enter player armour");
            double armour = double.Parse(Console.ReadLine());

            player a = new player(name, health, maxhealth, energy,maxenergy, armour);
            return a;



        }

        public static stats addSkill()
        {
            Console.WriteLine("Enter player name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter damage");
            double damage = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter player penetration");
            double penetration = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter heal");
            double heal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter player cost");
            double cost = double.Parse(Console.ReadLine());



            Console.WriteLine("Enter player description");
            string des= Console.ReadLine();

            stats c = new stats(name, damage,penetration, heal, cost,des);
            return c;



        }
        public static void display_Player_info(List<player> Players)
        {
            foreach (player ele in Players) 
            {
                string str = "Name: " + ele.name + " Health: " + ele.hp + " Energy: " + ele.energy + " Armour: " + ele.armour;
                Console.WriteLine(str);
            }

        }

    }
}
