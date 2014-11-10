using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CombatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            HippieMassacre();
            Console.ReadKey();
        }

        static void HippieMassacre()
        {
            int numberOfHippieAttacks = 0;
            int playerHP = 100;
            int hippieHP = 200;
            bool attaking = true;
            string weaponChosen;
            //create random number generator and weapons\\
            Random rng = new Random();
            int slayerCD;
            int republican;
            int heal;
            int hippieAttack = 0;
            //==========================================================\\
            //The enthralling story! 
            while (attaking && playerHP > 0 && hippieHP > 0)
            {
                Console.WriteLine("Thank you for coming to fight the greatest evil this world has ever faced.");
                PressAnyKey();
                DotMaker(200, 200, 2);
                Console.WriteLine("You have been chosen because we believe you may be the last hope.");
                PressAnyKey();
                Console.WriteLine("Our foe has spent the last 40 years perfecting his most deadly attacks. \nBut we've been busy too.");
                PressAnyKey();
                Console.WriteLine("Please wait here while I bring in the file.");
                PressAnyKey();
                DotMaker(200, 200, 0);
                Console.WriteLine("Thank you. \nOk heres what we know:\nHe sleeps in a foggy cavern and spends \nhis time finding new ways to increase his power. \nHe makes powerfull orbs made from glass and has a container\nof magical water that when thrown on you will make you \ncompletley lose your mind!");
                PressAnyKey();
                Console.WriteLine("Ok, get into the helecopter and lets get going. We will arm you on the way.");
                PressAnyKey();
                DotMaker(100, 50, 1);
                Console.WriteLine("Take this gym bag, it will have everything you need. \nAlso it has a cool headband incase you get sweaty.\nNow go! The fate of all humanity rests on your shoulders.\nGod speed.");
                PressAnyKey();
                Console.WriteLine("You get out of the helecopter \nand start walking towards a cave infront of you. \nClouds of smoke are billowing from it. \nYou dont know whats inside but pray the gym bag will be enough.");
                PressAnyKey();
                Console.WriteLine("As you get closer you can start to see through the smoke into the cave \nand start to make out a figure.\nYou inch closer and closer to find out what it is... \nYou put your hand on a rocky ledge to steady yourself.");
                PressAnyKey();
                Console.WriteLine("Your hand touchs something smooth thats obviously not a rock, \nit startles you and you quickly pull your hand back!\nYou see that its some kind of \nglass object and now its falling to the ground!");
                PressAnyKey();
                DotMaker(100, 10, 1);
                Console.WriteLine("CCRRAASSSHHHH!!!!!!!\nThe noise awakens the beast!\nHe turns his head to look at where it came from!\nAnd thats when you notice");
                PressAnyKey();
                Console.WriteLine();
                Console.WriteLine("ITS A HIPPIE!!!!");
                PressAnyKey();
                Console.WriteLine("(This is an automated sequence. Please dont hit key tell it is over. \nBut you need to press a key right now)");
                PressAnyKey();
                DotMaker(100, 100, 2);
                bool hasntSelectedChoice = true;
                while (playerHP > 0 && hippieHP > 0)
                {
                    //only runs this code if the enemy has attacked
                    if (numberOfHippieAttacks > 0)
                    {
                        Console.WriteLine("Choose a weapon! \n#1:Play a slayer CD\n#2:Throw a Republican\n#3:Use your job");
                        Console.WriteLine("\nEnter the number then press 'Enter'.");
                        //=================================ATTACK=====================================\\
                        hasntSelectedChoice = true;
                        while (hasntSelectedChoice)
                        {
                            weaponChosen = Console.ReadLine();
                            Console.Clear();
                            if (weaponChosen == "1")
                            {
                                if (rng.Next(0, 101) <= 70)
                                {
                                    slayerCD = rng.Next(20, 35);
                                    Console.WriteLine("Its super effective! \nYou did " + slayerCD + " damage!");
                                    hippieHP -= slayerCD;
                                }
                                else
                                {
                                    Console.WriteLine("Hippie's jam band is to loud for him to hear the Slayer CD!");
                                }
                                hasntSelectedChoice = false;
                            }
                            else if (weaponChosen == "2")
                            {
                                republican = rng.Next(10, 15);
                                Console.WriteLine("The Republican did " + republican + " damage");
                                hippieHP -= republican;
                                hasntSelectedChoice = false;
                            }
                            else if (weaponChosen == "3")
                            {
                                heal = rng.Next(10, 20);
                                Console.WriteLine("Wow! A job is actually good for something! You heal " + heal + " HP!");
                                playerHP += heal;
                                hasntSelectedChoice = false;
                            }
                            else
                            {
                                Console.WriteLine("Choose a weapon you hooser.");
                                Console.WriteLine("\n#1:Play a slayer CD\n#2:Throw a Republican\n#3:Use your job");
                                //Debugger to make game finish sooner
                                //hippieHP -= 99;
                            }
                        }
                        Console.WriteLine();
                        HpDisplay(playerHP, hippieHP);
                        Console.WriteLine();

                    }
                        //===========Hipi attacks!!==========\\
                        if (hippieHP > 0 && playerHP > 0 )
                        {
                            if (numberOfHippieAttacks > 0)
                            {
                                Console.WriteLine("Now for Hippie attack");
                            }

                            if (numberOfHippieAttacks == 0)
                            {
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("\nThe Hipi is awaking from his deep, deep slumber.\n");
                                Thread.Sleep(3000);
                                DotMaker(100, 300, 0);
                                Console.Clear();
                                Console.WriteLine("\nOH GOD THE HIPPIE IS AWAKE! \n\nHe lets out an awful war cry!\n");
                                Thread.Sleep(3500);
                                Console.Clear();
                                Console.WriteLine("\nHippie: BLLLAAAAAUUUUUUURRRRRRRGGGGGGGGGG!!!!!!\n\nHes in a RAGE!!");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }

                            Console.WriteLine();
                            Console.WriteLine("The Hippie tries to hit you!");
                            PressAnyKey();
                            if (rng.Next(0, 101) > 19 && hippieHP > 0)
                            {
                                Console.WriteLine("\nHe somehow sees only one of you and actually hits!\n");
                                hippieAttack = rng.Next(5, 16);
                                Console.WriteLine("He did a whoping " + hippieAttack + " damage!");
                                playerHP -= hippieAttack;
                            }
                            else if (hippieHP > 0)
                            {
                                Console.WriteLine("\nHippie is Hippie's worst enemy! He can't bring himself to hit you. ");
                            }

                            Console.WriteLine();
                            HpDisplay(playerHP, hippieHP);
                            Console.WriteLine();
                            PressAnyKey();
                        }
                        

                        if (numberOfHippieAttacks == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You are a bit dazed, your foe is obviously very powerful \nperhaps the strongest you've ever faced.\nYou look into the gym bag: \nOf course the first thing you do is put the headband on.");
                            PressAnyKey();
                            Console.WriteLine("The hippy is busy crying over that colorful piece of glass, I think he \nshould just clean the water up and fight.\nWhile your foe is distracted you see what else is in your gym bag:");
                            PressAnyKey();
                            Console.WriteLine("#1: A slayer CD. Does 20-35DMG");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nSlayer CD has a 70% chance of doing damage. \nBut its super effective against Hippie.");
                            PressAnyKey();
                            Console.WriteLine("#2: A Republican. Does 10-15DMG");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nYour gym bag is full of Republicans! (Obviously you're super swole \nif you've been lugging this bag around!)\nThrowing a Republican hits everytime and Hippie hates Republicans.");
                            PressAnyKey();
                            Console.WriteLine("The last item: A Job.");
                            Thread.Sleep(1000);
                            Console.WriteLine("\nHaving a job keeps you sustainable while Hippie becomes weaker and weaker.\nUsing your job heals 10-20HP!");
                            PressAnyKey();
                        }
                        numberOfHippieAttacks++;
                    
                }
            }
            if (playerHP >= 0)
            {
                Console.WriteLine("You win and save humanity!");
            }
            else
            {
                Console.WriteLine("The Hippie is trully powerful. Nice try though.");
            }
            PressAnyKey();


        }
        /// <summary>
        /// Where the magic is made. This function loops through lists of new lines and dots and can print out cool display effects using these two thing
        /// Certain Sequences you can change the speed of the graphic, and others u can change how many times it runs.
        /// </summary>
        /// <param name="timeBetweenLogs"></param>
        /// <param name="incrementor"></param>
        /// <param name="sequence"></param>
        static void DotMaker(int timeBetweenLogs, int incrementor, int sequence)
        {

            Console.Clear();
            int z = 0;
            Random rng = new Random();
            List<string> listOfNewLines = new List<string>() { "\n", "\n", "\n", "\n", "\n", "\n", "\n", "\n", "\n", "\n", "\n", "\n" };
            List<string> listOfDots = new List<string>();
            
            //populates dot list
            for (int i = 0; i < 14; i++)
            {
                listOfDots.Add("................................................................................");
            }
            //======================================================================================================\\
            int maxIndex = 0;
            if (sequence == 0)
            {
                maxIndex = listOfNewLines.Count();
                for (int i = 0; i < maxIndex; i++)
                {

                    for (int x = 0; x < i; x++)
                    {
                        Console.WriteLine(listOfNewLines[x]);
                    }
                    Console.WriteLine("................................................................................");
                    Thread.Sleep(incrementor);
                    Console.Clear();
                } 
            }
            if (sequence == 1)
            {
                while (z <= incrementor)
                {
                    int x = rng.Next(0, listOfNewLines.Count());
                    for (int i = 0; i <= x; i++)
                    {
                        Console.WriteLine(listOfNewLines[x]);
                    }
                    Console.WriteLine("................................................................................");
                    Thread.Sleep(timeBetweenLogs);
                    Console.Clear();
                    z++;
                }
            }
            //The most complex sequence. Fill screen with dots one after another, then adds new spaces while at the same time printing less and less lines of dots so it seems like they are being taken away. 
            if (sequence == 2)
            {
                
                
                //prints dots
                    for (int x = 0; x < listOfDots.Count(); x++)
                    {
                        Console.WriteLine(listOfDots[x]);
                        Thread.Sleep(incrementor);
                    }
                    //loop that dictates how many new lines to print out. 
                //Some integers are set difrently due to console size.
                    int newLineAdder = 0;
                    int dotCounter = listOfDots.Count() - 3;
                    while (dotCounter >= 0 && newLineAdder <= listOfNewLines.Count() - 1)
                    {
                        for (int i = 0; i <= newLineAdder; i++)
                        {
                            
                            Console.WriteLine(listOfNewLines[i]);
                            
                        }
                        //loop through dots to subtract
                        for (int x = dotCounter; x >= 0; x--)
                        {
                            Console.WriteLine(listOfDots[x]);
                        }
                        dotCounter--;
                        newLineAdder++;
                        Thread.Sleep(incrementor);
                        Console.Clear();
                    }
                    
                    Console.Clear();
                
            }

            
            
        }
        /// <summary>
        /// Enemy and Player HP display
        /// </summary>
        /// <param name="playerHP"></param>
        /// <param name="hippieHP"></param>
        static void HpDisplay(int playerHP, int hippieHP)
        {
            Console.WriteLine("Your HP: " + playerHP + "\nHippie HP: " + hippieHP);
        }
        /// <summary>
        /// Waits for user to enter key before continuing the game.
        /// </summary>
        static void PressAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }


    }
}
