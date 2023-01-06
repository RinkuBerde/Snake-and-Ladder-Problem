namespace SnakeLadder
{
    internal class SnakeLadder
    {
      static void Main(string[] args)
        {
            int position = 0, rollDice;
            //create random number of rolling dice
            Random random = new Random();
            rollDice = random.Next(1, 7);
            Console.WriteLine("Rolled Dice number is:" + rollDice);
            //print user option 
            Console.WriteLine("player option 1.No Play 2.Ladder 3.Snake");
            var list = new List<string> { "No Play", "Ladder", "Snake" };
            //check user option
            int pos = random.Next(list.Count);
            //condition based on user option
            if (list[pos] == "Ladder")
            {
                position += rollDice;
            }
            else if (list[pos] == "Snake")
            {
                position -= rollDice;
            }

            //print result of playerPosition and dice rolled
            Console.WriteLine("Player option:" + list[pos]);
            Console.WriteLine("Player updated postion:" + position );

        }      
        
    }
}