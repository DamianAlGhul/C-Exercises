int totalPlayer = 15;
int totalDealer = 15;
string message = "";
string SwitchControl = "pene";

switch (SwitchControl)
{
    case "menu":
        Console.WriteLine("Welcome to E L  C A S I N O");
        Console.WriteLine("Write '21' to start the game Blackjack");
        SwitchControl = Console.ReadLine();
        break;

    case "21":
        if (totalPlayer > totalDealer && totalPlayer < 22)
        {
            message = "You win, congratulations!";
        }
        else if (totalPlayer <= totalDealer || totalPlayer > 21)
        {
            message = "You lose, try again";
        }
        else
        {
            message = "Invalid condition, try and play again";
        }

        Console.WriteLine(message);
        break;

    default:
        Console.WriteLine("The value is not valid");
        break;
}