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

class HumanPlayer
{
    private int points;
    public HumanPlayer(int JG)
    {
        points = 5;
    }
    public int GetPoints()
    {
        return points;
    }
    public void WinRound()
    {
        points += 5;
    }
    public void LoseRound()
    {
        points -= 5;
    }
    public string HumanDecision()
    {
        Console.WriteLine("Please input your choice: rock, paper, or scissors.");
        string user = Console.ReadLine();
        if (user == "rock") return user;
        else if(user == "paper") return user;
        else if(user == "scissors") return user;
        else return "error. Try 'rock' 'paper' or 'scissors'";
    }

}

class ComputerPlayer
{
    public string ComputerDecision()
    {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0, 3) ;
        if (rnd_num == 0) return "rock";
        else if (rnd_num == 1) return "paper";
        else if (rnd_num == 2) return "scissors";
        else return "Error";
    }
}
