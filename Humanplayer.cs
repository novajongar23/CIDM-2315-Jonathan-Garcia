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
