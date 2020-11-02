/// Homework No. 8		Exercise Part 1
/// File Name: TheDuelists
/// @author: Evan Sinclair
/// Date:  Nov 2, 2020
///
/// Problem Statement: Write a program to simulate the duel. Your program should use random numbers 
/// and the probabilities given in the problem to determine whether a shooter hits the target.  Create a class named 
/// Duelist that contains the dueler’s name and shooting accuracy, a Boolean indicating whether the dueler is still 
/// alive, and a method ShootAtTarget(Duelist target) that sets the target to dead if the dueler hits his target 
/// (using a random number and the shooting accuracy) and does nothing otherwise.  Use properties for your Duelist class.
/// 
/// Once you can simulate a single duel, add a loop to your program that simulates 10,000 duels.  Count the number of 
/// times that each contestant wins and print the probability of winning for each contestant (ie for Aaron your program 
/// might output “Aaron won 3595/10000 duels or 35.95%).
/// 
/// Also run test for a strategy where Aaron misses his first shot/ shoots last.
/// 
/// Overall Plan:
/// 1)Build a Duelist class that has double accuracy bool isAlive and string name
/// 2)Add a method for one duelist to shoot another
/// 3)Create a Duel class that takes in 3 duelists and has methods to execute the diffrent strategies
/// 4)Create a driver program to iterate the duesl 10000 times each and output the results
///


using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duelist a = new Duelist(33.3333333333333333, "Aaron");
            Duelist b = new Duelist(50, "Bob");
            Duelist c = new Duelist(99.5, "Charlie");

            Duel strat1 = new Duel(a, b, c);
            int aWin = 0, bWin = 0, cWin = 0;
            string winner;


            for (int n = 0; n < 10000; n++)
            {
                winner = strat1.RunDuelStrat1();
                if (winner == "Aaron") aWin++;
                else if (winner == "Bob") bWin++;
                else cWin++;
                strat1.ResetLife();

            }

            Console.WriteLine("For the strategy where everyone shoots at the most accurate duelist: ");
            Console.WriteLine("Aaron won  " + aWin + " times out of 10000. That is " + Math.Round((Convert.ToDouble(aWin) / 100), 2) + " percent");
            Console.WriteLine("Bob won  " + bWin + " times out of 10000. That is " + Math.Round((Convert.ToDouble(bWin) / 100), 2) + " percent");
            Console.WriteLine("Charlie won  " + cWin + " times out of 10000. That is " + Math.Round((Convert.ToDouble(cWin) / 100), 2) + " percent");
            Console.WriteLine();

            aWin = bWin = cWin = 0;

            for (int n = 0; n < 10000; n++)
            {
                winner = strat1.RunDuelStrat2();
                if (winner == "Aaron") aWin++;
                else if (winner == "Bob") bWin++;
                else cWin++;
                strat1.ResetLife();

            }
            Console.WriteLine("For the strategy where everyone shoots at the most accurate duelist but Aaron misses on purpose the first shot: ");
            Console.WriteLine("Aaron won  " + aWin + " times out of 10000. That is " + Math.Round((Convert.ToDouble(aWin) / 100), 2) + " percent");
            Console.WriteLine("Bob won  " + bWin + " times out of 10000. That is " + Math.Round((Convert.ToDouble(bWin) / 100), 2) + " percent");
            Console.WriteLine("Charlie won  " + cWin + " times out of 10000. That is " + Math.Round((Convert.ToDouble(cWin) / 100), 2) + " percent");
        }
    }
}
