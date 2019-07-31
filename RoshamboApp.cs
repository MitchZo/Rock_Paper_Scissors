using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class RoshamboApp
    {
        public static void RunApplication()
        {
            bool playAgain = true;
            bool win = false;
            int winCount = 0;
            int lossCount = 0;
            Challenger user = new Challenger();
            //get the user's name
            user.Name = IntroductionToTheArena();
            //have the user choose their opponent
            string champion = ChooseYourChampion(user);
            while (playAgain)
            {
                win = Combat(user, champion);
                if (win == true)
                { winCount++; }
                else { lossCount++; }
                string response = GetUserInput("DO YOU DARE REENTER THE ARENA, FOOL?", "YES OR NO! ARE YOU BRASH ENOUGH TO FACE THE MONSTERS AGAIN??","yes/no");
                if (response.ToLower() == "yes")
                {
                    playAgain = true;
                }
                else
                { playAgain = false;
                    Console.WriteLine($"{user.Name.ToUpper()}'S RECORD IN THE ARENA IS AS FOLLOWS! {winCount} - {lossCount}");
                }
            }
        }

        public static string GetUserInput(string prompt, string reprompt, string viableOptions)
        {
            string response = "";
            //prompt the user with the first prompt
            Console.WriteLine(prompt);

            //as long as this isn't the first time the user has run through
            //this loop, and they are continuing to give us bad info,
            //use the reprompt instead of prompt.
            bool isValid = false;
            while (!isValid)
            {
                //take the user's response
                response = Console.ReadLine();
                //validate the response isn't blank and works for the list of options available
                if (!Validator.ValidateStringNotNull(response) || !Validator.ValidateIsOption(response, viableOptions))
                {
                    isValid = false;
                    //if the response is blank or invalid, reprompt them.
                    Console.WriteLine(reprompt);
                }
                //break out of the loop if the response is valid
                else
                { isValid = true; }
            }
            //return the valid response
            return response;
        }
        public static string IntroductionToTheArena()
        {
            //get a valid username
            string userName = GetUserInput("WHO DARES CHALLENGE IN THE ARENA OF ROSHAMBO?!",
                "SPEAK UP MORTAL! I CAN'T HEAR YOU! I SAID 'WHO DARES CHALLENGE IN THE ARENA OF ROSHAMBO?!'",
                "any");
            return userName;
        }
        public static string ChooseYourChampion(Challenger user)
        {
            Console.Clear();
            //display the options of champions
            DisplayChampionList();
            //have the user decide which combatant they want to square off against and be sure it's a valid option.
            return GetUserInput($"WELCOME {user.Name.ToUpper()}! CHOOSE THE SLAYER WHO WILL FACILITATE YOUR DEMISE!",
                "C'MON. I KNOW IT'S HARD TO FACE YOUR OWN MORTALITY BUT I'M ON A SCHEDULE HERE...",
                "melvin/melvin the conquerer/harry/harry the unstoppable/1/2");
        }
        public static void DisplayChampionList()
        {
            //list out the champions available to the user
            Console.WriteLine("1. Melvin The Conquerer");
            Console.WriteLine("2. Harry The Unstoppable");
            Console.WriteLine("");
        }
        public static Melvin CreateMelvin()
        {
            //create a new melvin
            Melvin melvin = new Melvin();
            melvin.Name = "Melvin";
            return melvin;
        }
        public static Harry CreateHarry()
        {
            //create a new harry
            Harry harry = new Harry();
            harry.Name = "Harry";
            return harry;
        }
        public static bool Combat(Challenger user,string champion)
        {
            //have the user choose their weapon
            user.WeaponOfChoice = user.GenerateRoshambo();

            bool win = false;
            //create the opponent
            if (champion.ToLower() == "melvin" || champion.ToLower() == "melvin the conquerer" || champion == "1")
            {
                Melvin opponent = CreateMelvin();
                opponent.WeaponOfChoice = opponent.GenerateRoshambo();
                win = Clash(user, opponent);
            }
            else
            {
                Harry opponent = CreateHarry();
                opponent.WeaponOfChoice = opponent.GenerateRoshambo();
                win = Clash(user, opponent);
            }
            return win;
        }
        public static bool Clash(Challenger user, Player opponent)
        {
            if (user.WeaponOfChoice.ToLower() == "paper")
            {
                if (opponent.WeaponOfChoice.ToLower() == "rock")
                {
                    Console.WriteLine($"{user.Name.ToUpper()}'S MIGHTY SHEET OF PRINTER PAPER ENTIRELY ENCOMPASSES {opponent.Name.ToUpper()}'S PUNY PEBBLE!");
                    return true; }
                else if (opponent.WeaponOfChoice.ToLower() == "scissors")
                {
                    Console.WriteLine($"THE FINELY SHARPENED EDGES OF {opponent.Name.ToUpper()}'S BLADES TEAR {user.Name.ToUpper()}'S WEAK PAPER TO SHREDS!");
                    return false; }
                else
                {
                    Console.WriteLine("THE PAPERS STACK ATOP EACH OTHER NEATLY! NO BLOOD IS SPILT! DO IT AGAIN!");
                    return Combat(user, opponent.Name);
                }
            }
            else if (user.WeaponOfChoice.ToLower() == "rock")
            {
                if (opponent.WeaponOfChoice.ToLower() == "scissors")
                {
                    Console.WriteLine($"{user.Name.ToUpper()}'S BOULDER DEMOLOISHES {opponent.Name.ToUpper()}'S SHEARS AS IF THEY WERE MADE OF TIN FOIL!");
                    return true;
                }
                else if (opponent.WeaponOfChoice.ToLower() == "paper")
                {
                    Console.WriteLine($"{user.Name.ToUpper()}'S BOULDER IS IMMOVEABLE! {opponent.Name.ToUpper()}'S PAPER IS PLACED NEATLY ATOP IT!");
                    return false;
                }
                else
                {
                    Console.WriteLine("THE TWO ROCKS SMASH AMONGST EACH OTHER! BOTH ARE DESTROYED! THE CROWD FOUND THAT ENJOYABLE! DO IT AGAIN!");
                    return Combat(user, opponent.Name);
                }
            }
            else
            {
                if (opponent.WeaponOfChoice.ToLower() == "paper")
                {
                    Console.WriteLine($"{user.Name.ToUpper()}'S SCISSORS CUT THROUGH {opponent.Name.ToUpper()}'S PAPER LIKE IT WAS PAPER!");
                    return true;
                }
                else if (opponent.WeaponOfChoice.ToLower() == "rock")
                {
                    Console.WriteLine($"{user.Name.ToUpper()} IS CRUSHED UNDER THE MASSIVE WEIGHT OF {opponent.Name.ToUpper()}'S ROCK SLIDE!");
                    return false;
                }
                else
                {
                    Console.WriteLine("THE TWO SCISSORS SIMPLY SHARPEN EACH OTHER! DO IT AGAIN! WITH MORE DANGER!");
                    return Combat(user, opponent.Name);
                }
            }
        }
    }
}

