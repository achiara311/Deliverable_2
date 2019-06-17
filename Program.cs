using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliv_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, fullName, selection;
            int actionOption, dangerOption, chillingOption, goodFoodOption;

            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter last name.");
            lastName = Console.ReadLine();

            fullName = String.Concat(firstName, " ", lastName);

            //Asking user about what activities they want to do
            Console.WriteLine("Hello " + fullName + "!  What type of activity are you in the mood for this weekend?");
            Console.WriteLine("Type a number for your option:");
            Console.WriteLine("1. Danger");
            Console.WriteLine("2. Action");
            Console.WriteLine("3. Chilling");
            Console.WriteLine("4. Good Food");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                Console.WriteLine("How many people do you have with you?");
                dangerOption = Convert.ToInt32(Console.ReadLine());
                switch (dangerOption)
                {
                    case 0:
                        Console.WriteLine("Get your sneakers on and go skydiving. Just walk over; it's 4 blocks away.");
                        break;
                    case 1:
                        Console.WriteLine("Get in the sedan with your buddy and go skydiving");
                        break;
                    case 2:
                        Console.WriteLine("Get in the sedan and go skydiving");
                        break;
                    case 3:
                        Console.WriteLine("Get in the sedan and go skydiving");
                        break;
                    case 4:
                        Console.WriteLine("Get in the sedan and go skydiving");
                        break;
                    case 5:
                        Console.WriteLine("Get on the volkswagon and go skydiving");
                        break;
                    case 6:
                        Console.WriteLine("Get on the volkswagon and go skydiving");
                        break;
                    case 7:
                        Console.WriteLine("Get on the volkswagon and go skydiving");
                        break;
                    case 8:
                        Console.WriteLine("Get on the volkswagon and go skydiving");
                        break;
                    case 9:
                        Console.WriteLine("Get on the volkswagon and go skydiving");
                        break;
                    case 10:
                        Console.WriteLine("Get on the volkswagon and go skydiving");
                        break;
                    default:
                        Console.WriteLine("Take a plane to Denver and jump out of it with your friends");
                        break;

                }
                Console.WriteLine("Goodbye!");
            }
            else if (selection == "2")
            {
                Console.WriteLine("How many people are with you for action");
                actionOption = Convert.ToInt32(Console.ReadLine());
                switch (actionOption)
                {
                    case 0:
                        Console.WriteLine("Throw your sneakers on and walk 5 blocks to Belle Isle to watch the race.");
                        break;
                    case 1:
                        Console.WriteLine("Go drive over in the sedan and watch the Indy 500 race");
                        break;
                    case 2:
                        Console.WriteLine("Go drive over in the sedan and watch the Indy 500 race");
                        break;
                    case 3:
                        Console.WriteLine("Go drive over in the sedan and watch the Indy 500 race");
                        break;
                    case 4:
                        Console.WriteLine("Go drive over in the sedan and watch the Indy 500 race");
                        break;
                    case 5:
                        Console.WriteLine("Take the Volkswagon bus and go watch the Indy 500 race");
                        break;
                    case 6:
                        Console.WriteLine("Take the Volkswagon bus and go watch the Indy 500 race");
                        break;
                    case 7:
                        Console.WriteLine("Take the Volkswagon bus and go watch the Indy 500 race");
                        break;
                    case 8:
                        Console.WriteLine("Take the Volkswagon bus and go watch the Indy 500 race");
                        break;
                    case 9:
                        Console.WriteLine("Take the Volkswagon bus and go watch the Indy 500 race");
                        break;
                    case 10:
                        Console.WriteLine("Take the Volkswagon bus and go watch the Indy 500 race");
                        break;
                    default:
                        Console.WriteLine("Take a plane this weekend to go see the Indy 500 with all your friends and family " + firstName + "!");
                        break;
                }
                Console.WriteLine("Goodbye!");
            }
            else if (selection == "3")
            {
                Console.WriteLine("How many people for chilling");
                chillingOption = Convert.ToInt32(Console.ReadLine());
                switch (chillingOption)
                {
                    case 0:
                        Console.WriteLine("Throw your sneakers on and go hiking at Mist Trail to clear your head.");
                        break;
                    case 1:
                        Console.WriteLine("Drive over in the sedan to mist trail and go hiking");
                        break;
                    case 2:
                        Console.WriteLine("Go drive over in the sedan to national park and hike");
                        break;
                    case 3:
                        Console.WriteLine("Go drive for a bit in the sedan until you hit Mist Trail and go hiking for a day");
                        break;
                    case 4:
                        Console.WriteLine("Go drive in the sedan to Mist Trail and go hiking.");
                        break;
                    case 5:
                        Console.WriteLine("Take the Volkswagon bus and go hiking at National Park.");
                        break;
                    case 6:
                        Console.WriteLine("Take the Volkswagon bus and go hiking at National Park.");
                        break;
                    case 7:
                        Console.WriteLine("Take the Volkswagon bus and go hiking at National Park.");
                        break;
                    case 8:
                        Console.WriteLine("Take the Volkswagon bus and go hiking at National Park.");
                        break;
                    case 9:
                        Console.WriteLine("Take the Volkswagon bus and go hiking at National Park.");
                        break;
                    case 10:
                        Console.WriteLine("Take the Volkswagon bus and go hiking at National Park.");
                        break;
                    default:
                        Console.WriteLine("Fly over to Colorado and go hiking and even snowboarding. Have a great time, " + firstName + "!");
                        break;
                }

                Console.WriteLine("Goodbye!");
            }
            else if (selection == "4")
            {
                Console.WriteLine("How many people want food");
                goodFoodOption = Convert.ToInt32(Console.ReadLine());
                switch (goodFoodOption)
                {
                    case 0:
                        Console.WriteLine("Put on your sneakers and walk over to Taco Bell.");
                        break;
                    case 1:
                        Console.WriteLine("Drive over to taco bell in the sedan.");
                        break;
                    case 2:
                        Console.WriteLine("Drive over to taco bell in the sedan.");
                        break;
                    case 3:
                        Console.WriteLine("Drive over to taco bell in the sedan.");
                        break;

                    case 4:
                        Console.WriteLine("Drive over to taco bell in the sedan.");
                        break;
                    case 5:
                        Console.WriteLine("Take Volkswagon bus to Taco Bell.");
                        break;
                    case 6:
                        Console.WriteLine("Take Volkswagon bus to Taco Bell.");
                        break;
                    case 7:
                        Console.WriteLine("Take Volkswagon bus to Taco Bell.");
                        break;
                    case 8:
                        Console.WriteLine("Take Volkswagon bus to Taco Bell.");
                        break;
                    case 9:
                        Console.WriteLine("Take Volkswagon bus to Taco Bell.");
                        break;
                    case 10:
                        Console.WriteLine("Take Volkswagon bus to Taco Bell.");
                        break;
                    default:
                        Console.WriteLine("Take a plane to In-Out-Burger in California.");
                        break;
                }
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Selection not understood");
            }



            Console.ReadKey();
        }
    }
}
