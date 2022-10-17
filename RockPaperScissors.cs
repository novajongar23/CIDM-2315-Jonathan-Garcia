namespace RockPaperScissors;
class Program
{
    static void Main(string[] args)
    {
        HumanPlayer Jonathan = new HumanPlayer(1);
        ComputerPlayer Comp = new ComputerPlayer();

        string ans = "";
        int count = Jonathan.GetPoints();

        while (ans != "n" && count > 0)
        {
            Console.WriteLine("****Rock Paper Scissors, Start!!****");
           
            Console.WriteLine("You have " + count + " points");

            string user = Jonathan.HumanDecision();
             string choices = Comp.ComputerDecision();
            Console.WriteLine("--> Your Decision: " + user);
            Console.WriteLine("--> Computer Decision: " + choices);

            if (user == "rock" && choices == "scissors")
            {
                Console.WriteLine("You win!");
                Jonathan.WinRound();
            }
            else if (user == "rock" && choices == "paper")
            {
                Console.WriteLine("You Lose!");
                Jonathan.LoseRound();
            }
            else if (user == "paper" && choices == "rock")
            {
                Console.WriteLine("You win!");
                Jonathan.WinRound();
            }
            else if (user == "paper" && choices == "scissors")
            {
                Console.WriteLine("You Lose!");
                Jonathan.LoseRound();
            }
            else if (user == "scissors" && choices == "rock")
            {
                Console.WriteLine("You Lose!");
                Jonathan.LoseRound();
            }
            else if (user == "scissors" && choices == "paper")
            {
                Console.WriteLine("You win!");
                Jonathan.WinRound();
            }
            else
            {
                Console.WriteLine("Same choices");
            }
            count = Jonathan.GetPoints();
            if (count > 0)
            {
                Console.WriteLine("--> Play again? Input y to continue, or n to exit");
                ans = Console.ReadLine();
            }
            else Console.WriteLine("Sorry, you don't have enough points, thanks for playing.");
        }

        Console.WriteLine("Thank you for playing!");

    }
}
