using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNumber = new Random();
            int newRandom = randNumber.Next(1, 100);
       //     Console.WriteLine("Does this random number make me look fat, be honest? {0}", newRandom);


            var num = 0;
            var lastnum = 0;
            var tries = 0;
            var maxtries = 5;


            while (tries < maxtries && newRandom != num)
                {
                lastnum = num;
    //            Console.WriteLine("your lastnum was: {0}", lastnum);
    //            Console.WriteLine("tries: {0}, newRandom: {1}", tries, newRandom);
                    Console.Write("What you waiting for, enter a number homey: ");
                    var homeyNumber = int.TryParse(Console.ReadLine(), out num);
                if (lastnum==num) { Console.WriteLine("Umm, may I suggest trying a different number?"); }
                    tries = tries +1;

                if (tries >= maxtries)
                {
                    Console.WriteLine("You can't guess forever man, you lose.");
                    Console.ReadLine();
                }
                else if (num == newRandom) {
                    Console.WriteLine("You Win Homey!  Your number was: {0}", num);
                    Console.ReadLine();
                }
                else if (num > newRandom) {

                    Console.WriteLine("Whoa homey, settle down, that guess was too high: {0}", num);
                    if (lastnum > newRandom && num > lastnum) { Console.WriteLine("You aren't helping yourself.  Guess Lower"); }
                  
                }

                else
                {

                    Console.WriteLine("Fell a little short there homey, your guess was too low: {0}", num);
                    if (lastnum < newRandom && num < lastnum && lastnum !=0) { Console.WriteLine("You aren't helping yourself.  Guess Higher"); }
                    }
                

            }

            
        }
    }
}
