int totalPlayer = 0;
int totalDealer = 0;
int num = 0;
string message = "";
string SwitchControl = "menu";

while (true)
{
    switch (SwitchControl)
    {
        case "menu":
            Console.WriteLine("Welcome to E L  C A S I N O");
            Console.WriteLine("Write '21' to start the game Blackjack");
            SwitchControl = Console.ReadLine();
            break;

        case "21":
            do
            {
                System.Random random = new System.Random();
                num = random.Next(1, 12);
                totalPlayer = totalPlayer + num;
                Console.WriteLine("Take a card player");
                Console.WriteLine($"Your card is: {num}");
                Console.WriteLine("Do you want another card?");

            } while (Console.ReadLine() == "si" || Console.ReadLine() == "Si" || Console.ReadLine() == "Yes" || Console.ReadLine() == "yes");

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
            SwitchControl = "menu";
            break;

        default:
            Console.WriteLine("The value is not valid");
            break;
    }
}