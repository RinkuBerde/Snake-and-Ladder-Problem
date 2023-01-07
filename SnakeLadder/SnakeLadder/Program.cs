namespace SnakeLadder
{
    internal class SnakeLadder
    {
        static void Main(string[] args)
        {
            //local variable
            int rollDice, position1 = 0, position2= 0;
            int count = 0;
            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };
            // 1 ->player 1 is playing . 2 ->Player 2 is playing
            int playerChange = 1;
            while (position1 <= 100 || position2 <= 100)
            {
                //Print the current Player
                Console.WriteLine("Player: " + playerChange + " is playing \n");
                //Rolling dice
                rollDice = random.Next(1, 7);
                Console.WriteLine("Dice number is : " + rollDice + "\n");
                //Print user options
                Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake \n");

                //Use random to check user option
                int index = random.Next(list.Count);
                Console.WriteLine("Player option is : " + list[index] + "\n");

                //Goes to this loop if Player 1 is rolling dice
                if (playerChange == 1)
                {
                    //If option is "No Change" it will change player to 2
                    if (list[index] == "No Play" && playerChange == 1)
                    {
                        playerChange = 2;
                        continue;
                    }
                    //If player option is "Snake" , position will go down and will change player to 2
                    if (list[index] == "Snake")
                    {
                        position1 -= rollDice;
                        playerChange = 2;
                    }
                    //If after rolling dice player position <100 then it will increment the position of player to that of number of dice
                    if (position1 + rollDice < 100 && playerChange == 1)
                    {
                        if (list[index] == "Ladder") position1 += rollDice;
                    }
                    //If after rolling dice player reached "Exactly 100" then it will increment and come out of loop.Winner is Player 1
                    if (list[index] == "Ladder" && (position1 + rollDice == 100) && playerChange == 1)
                    {
                        position1 += rollDice;
                        break;
                    }
                    //If after getting "Snake" option , position is less than 0, then reset position to 0
                    if (position1 < 0 && list[index] == "Snake")
                    {
                        position1 = 0;
                    }
                    //Print to Console
                    Console.WriteLine("\n");
                    Console.WriteLine("Player 1 current position : " + position1);
                }
                 //Goes to this loop if Player 2 is rolling dice
                else if (playerChange == 2)
                {
                    //If option is "No Change" it will change player to 1
                    if (list[index] == "No Play" && playerChange == 2)
                    {
                        playerChange = 1;
                        continue;
                    }
                    //If after rolling dice player position <100 then it will increment the position of player to that of number of dice
                    if (position2 + rollDice < 100 && playerChange == 2)
                    {
                        if (list[index] == "Ladder") position2 += rollDice;
                    }
                    //If player option is "Snake" , position will go down and will change player to 1
                    if (list[index] == "Snake")
                    {
                        position2 -= rollDice;
                        playerChange = 1;
                    }
                    //If after rolling dice player reached "Exactly 100" then it will increment and come out of loop.Winner is Player 2
                    if (list[index] == "Ladder" && (position2 + rollDice == 100) && playerChange == 2)
                    {
                        position2 += rollDice;
                        break;
                    }
                    //If after getting "Snake" option , position is less than 0, then reset position to 0
                    if (position2 < 0 && list[index] == "Snake")
                    {
                        position2 = 0;
                    }
                    //Print to Console
                    Console.WriteLine("\n");
                    Console.WriteLine("Player 2 current position : " + position2);
                    count++;
                }
            }
            Console.WriteLine("\n");
            //Print winner of 2Player Game
            if (position1 == 100)
            {
                Console.WriteLine("Winner is player 1  :" + position1);
                Console.WriteLine("Final position of player 2  :" + position2);
            }
            else
            {
                Console.WriteLine("Winner is player 2  :" + position2);
                Console.WriteLine("Final position of player 1  :" + position1);
            }
            //Total Number of game played
            Console.WriteLine("Number of times game played :" + count);
        }
    }             
    }
