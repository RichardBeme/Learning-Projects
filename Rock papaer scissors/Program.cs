Random random = new Random();
int x = random.Next(1, 4);
int playerschoice;
int rock = 1;
int paper = 2;
int scissors = 3;
bool playagain = true;

Console.Title = "Rock, Paper, Scissors!";
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

while (playagain == true)
{

    do
    {
        Console.WriteLine("Declare your weapon of choice. 1 for rock, 2 for paper, or 3 for scissors.");
        playerschoice = Convert.ToInt32(Console.ReadLine());
    }
    while (playerschoice < 1 || playerschoice > 3);



    {
        if (playerschoice == x) Console.WriteLine($"{playerschoice}! That is what I picked!");
        if (playerschoice == rock && x == scissors) Console.WriteLine("Rock beats scissors! You win");
        if (playerschoice == scissors && x == paper) Console.WriteLine("Scissors beats rock! You win!");
        if (playerschoice == paper && x == rock) Console.WriteLine("Paper beats rock! You win!");

        if (playerschoice == rock && x == paper) Console.WriteLine("Paper beats rock! You lose");
        if (playerschoice == scissors && x == rock) Console.WriteLine("Rock beats scissors!You lose!");
        if (playerschoice == paper && x == scissors) Console.WriteLine("scissors beats paper! You lose!");

        Console.WriteLine(" Would you like to play again? Press 1 for yes 2 for no.");
        int playerresponse = Convert.ToInt32(Console.ReadLine());
        if (playerresponse == 2) playagain = false;
    }

}

