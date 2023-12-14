int totalPlayer = 15;
int totalDealer = 15;
string message = "";

if (totalPlayer > totalDealer && totalPlayer < 22)
{
    message = "You win, congratulations!";
}
else if(totalPlayer <= totalDealer || totalPlayer > 21){
    message = "You lose, try again";
}
else
{
    message = "Invalid condition, try and play again";
}

Console.WriteLine(message);