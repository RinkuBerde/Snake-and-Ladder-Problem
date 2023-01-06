namespace SnakeLadder
{
    internal class SnakeLadder
    {
      static void Main(string[] args)
        { 
            //variable
            int position = 0, rollDice;
            //create random number of rolling dice
            Random random = new Random();

            //list to check option 
            var list = new List<string> { "No Play", "Ladder", "Snake" };

            //user condition
            rollDice = random.Next(1, 7);
            Console.WriteLine("Rolled Dice number is:" + rollDice);
            //print user option 
            Console.WriteLine("player option 1.No Play 2.Ladder 3.Snake");

            //random to check user option
            int index = random.Next(list.Count);
            Console.WriteLine("Player option is: " + list[index]);

            if (position + rollDice< 100)
            {
                if (list[index] == "Ladder") position += rollDice;
                if (list[index] == "Snake") position -= rollDice;
            }

            if (position < 0)
            {
                position = 0;
            }
            //print to console
            Console.WriteLine("\n");
            

            //print result of playerPosition and dice rolled
            Console.WriteLine("Player current position:" + position);
            Console.WriteLine("Player final postion:" + position );

        }      
        
    }
}