int totalPlayer = 0;
int totalDealer = 0;
int num = 0;
string controlACard = "";
string message = "";
string SwitchControl = "menu";
System.Random random = new System.Random();

while (true)
{
    totalPlayer = 0;
    totalDealer = 0;
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

                num = random.Next(1, 12);
                totalPlayer = totalPlayer + num;
                Console.WriteLine("Take a card player");
                Console.WriteLine($"Your card is: {num}");
                if (totalPlayer > 21)
                {
                    controlACard = "no";
                }
                else
                {
                    Console.WriteLine("Do you want another card?");
                    controlACard = Console.ReadLine();
                }
                
            } while (controlACard == "si" || controlACard == "Si" || controlACard == "Yes" || controlACard == "yes");

            totalDealer = random.Next(14, 23);
            Console.WriteLine("The dealer has: " + totalDealer);

            if (totalPlayer > totalDealer && totalPlayer < 22)
            {
                message = "You win, congratulations!";
            }
            else if (totalPlayer <= totalDealer)
            {
                message = "You lose, try again";
            }
            else if(totalPlayer > 21)
            {
                message = "You lose, you pass 21 with: " + totalPlayer;
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