int player = 0;
int cpu = 0;
string switchControl = "menu";
string playerC = "";
string cpuC = "";
int playerCon = 0;
int cpuCon = 0;
System.Random random = new System.Random();

while (true)
{
    switch (switchControl)
    {
        case "menu":
            player = 0;
            cpu = 0;
            playerCon = 0;
            cpuCon = 0;
            Console.WriteLine("Welcome to rock paper scissors");
            Console.WriteLine("If you wanna play write 'x': ");
            switchControl = Console.ReadLine();
            break;

        case "x":
            do
            {
                Console.WriteLine("Write a number to have a try: " +
                    "\n1 = Rock" +
                    "\n2 = Paper" +
                    "\n3 = Scissor");
                player = Convert.ToInt32(Console.ReadLine());
                cpu = random.Next(1, 4);
                if (player == 1)
                {
                    playerC = "Rock";
                }
                else if (player == 2)
                {
                    playerC = "Paper";
                }
                else if (player == 3)
                {
                    playerC = "Scissors";
                }

                if (cpu == 1)
                {
                    cpuC = "Rock";
                }
                else if (cpu == 2)
                {
                    cpuC = "Paper";
                }
                else if (cpu == 3)
                {
                    cpuC = "Scissors";
                }
                Console.WriteLine("You choose: " + playerC);
                Console.WriteLine("Cpu choose: " + cpuC);

                if (player == cpu)
                {
                    Console.WriteLine("Is a tie!");
                }
                else if ((player == 1 && cpu == 3) || (player == 3 && cpu == 2) || (player == 2 && cpu == 1))
                {
                    Console.WriteLine("You win this round!");
                    playerCon = playerCon + 1;
                }
                else
                {
                    Console.WriteLine("You lose this round :C");
                    cpuCon = cpuCon + 1;
                }

                if (playerCon == 3 || cpuCon == 3)
                {
                    Console.WriteLine("Game Over");
                    switchControl = "y";
                }
            } while (switchControl == "x" || switchControl == "X");
            break;

        case "y":

            if(playerCon > cpuCon)
            {
                Console.WriteLine($"\nYou won the game!" +
                    $"\nWins Player: {playerCon}" +
                    $"\nWins CPU: {cpuCon}\n");
            }
            else
            {
                Console.WriteLine($"\nYou lost the game!" +
                    $"\nWins Player: {playerCon}" +
                    $"\nWins CPU: {cpuCon}\n");
            }
            switchControl = "menu";

            break;

        default:
            Console.WriteLine("Try to write right C:");
            break;
    }
}