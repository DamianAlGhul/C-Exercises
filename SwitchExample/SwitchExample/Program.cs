int totalPlayer = 0;
int totalDealer = 0;
int coins = 0;
int bet = 0;
int botbet = 0;
int i = 0;
int s = 0;
int num = 0;
string controlACard = "";
string message = "";
string SwitchControl = "menu";
System.Random random = new System.Random();

while (true)
{
    Console.WriteLine("Welcome to E L  C A S I N O");
    Console.WriteLine("How many coins do you want? \n Remember, you need one to play");
    coins = Convert.ToInt32(Console.ReadLine());

    for (i = 0; i <= coins; i++)
    {

        totalPlayer = 0;
        totalDealer = 0;
        switch (SwitchControl)
        {
            case "menu":
                coins--;
                i--;
                Console.WriteLine($"You have {coins} coins");
                if (coins > 1)
                {
                    Console.WriteLine("How many coins do you want to bet?");
                    bet = Convert.ToInt32(Console.ReadLine());
                    botbet = bet;
                    Console.WriteLine($"The bet is {bet}");
                }
                Console.WriteLine("Write '21' to start the game Blackjack");
                SwitchControl = Console.ReadLine();
                coins++;
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

                } while (controlACard == "si" ||
                         controlACard == "Si" ||
                         controlACard == "Yes" ||
                         controlACard == "yes");

                totalDealer = random.Next(14, 23);
                Console.WriteLine("The dealer has: " + totalDealer);

                if (totalPlayer > totalDealer && totalPlayer < 22)
                {
                    message = "You win, congratulations!";
                    coins = coins + botbet;
                }
                else if (totalPlayer <= totalDealer)
                {
                    message = "You lose, try again";
                    coins = coins - bet;
                }
                else if (totalPlayer > 21)
                {
                    message = "You lose, you pass 21 with: " + totalPlayer;
                    coins = coins - bet;
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
    Console.WriteLine("Press a key to clean and start a new game");
    Console.ReadKey();
    for (s = 0; s < 50; s++)
    {
        Console.WriteLine();
    }
}