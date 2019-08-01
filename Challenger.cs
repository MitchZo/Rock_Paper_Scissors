using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class Challenger : Player
    {
        public override Enum GenerateRoshambo()
        {
            //get user's weapon
            string choice = RoshamboApp.GetUserInput("CHOOSE YOUR WEAPON!\n1. ROCK! (MOST DURABLE OF ALL WEAPONS! WEAK AGAINST TREE PULP!)\n2. PAPER! (BEST COVERAGE TO SUPPRESS YOUR ENEMIES! CAN BE SHEARED WITH BLADES!)\n" +
            "3. SCISSORS! (SHARP EDGES WITH WHICH TO SHREAD THE WEAK! DON'T LET ITS HINGE BE BASHED!)", "CHOOSE YOUR WEAPON! I WON'T ASK AGAIN! WELL... I WILL, BUT I WON'T BE HAPPY ABOUT IT.", "1/2/3/paper/rock/scissors");

            if (choice == "1" || choice.ToLower() == "rock" || choice.ToLower() == "rock!")
            { return Roshambo.rock; }
            else if (choice == "2" || choice.ToLower() == "paper" || choice.ToLower() == "paper!")
            { return Roshambo.paper; }
            else
            { return Roshambo.scissors; }
        }
    }
}
