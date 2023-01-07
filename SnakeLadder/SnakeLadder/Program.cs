namespace SnakeLadder
{
    internal class SnakeLadder
    {
        static void Main(string[] args)
        {

            //local variable
            int rollDice, position = 0;
            int count = 0;

            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };

            //Conditions for user options
            rollDice = random.Next(1, 7);
            Console.WriteLine("Dice number is : " + rollDice);

            //Print user options
            Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");

            //Use random to check user option
            int pos = random.Next(list.Count);
            Console.WriteLine("Player option is : " + list[pos]);
            if (position + rollDice < 100)
            {
                if (list[pos] == "Ladder")
                {
                    position += rollDice;
                }
                if (list[pos] == "Snake")
                {
                    position -= rollDice;
                }
            }
            else if (position + rollDice == 100 && list[pos] == "Ladder")
            {
                position += rollDice;

            }

            if (position < 0)
            {
                position = 0;
            }
            //Print to Console
            Console.WriteLine("\n");
            Console.WriteLine("Player current position : " + position);
            count++;
            Console.WriteLine("Final position is :" + position);
            Console.WriteLine("Total MOves:" + count);
        } 

    }      
        
    }
