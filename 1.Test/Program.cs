Console.WriteLine("which type of match will be played? short, regular, double or custom? ");
string match = Console.ReadLine();

int games = 0;
int points = 0;

int Player1;
int Player2;

switch (match)
{
    case "short":
        games = 1;
        break;

    case "regular":
        games = 4;
        break;

    case "double":
        games = 3;
        break;

    case "custom":
        break;

        do
        {
            Console.WriteLine("How many games must be won?");

        }
        while (games < 0 || games > 9 || games % 2 != 1);
}

int service = Random.Shared.Next(1, 3);
string scorer;
int points1 = 0;
int points2 = 0;
int games1 = 0;
int games2 = 0;

do
{
    Console.WriteLine("Player has the service" + service);

    Console.Write("Who gets the point?: ");
    scorer = Console.ReadLine()!;

    switch (scorer)
    {
        case "1":
            points1++;

            if (points1 == 11)
            {
                Console.WriteLine("Player1 is the winner of this game.");
                games1++;
                points1 = points2 = 0;
                service = Random.Shared.Next(1, 3);
            }
            break;

        case "2":
            points2++;
            if (points2 == 11)

            {
                Console.WriteLine("Player2 is the winner of this game.");
                games2++;
                points1 = points2 = 0;
                service = Random.Shared.Next(1, 3);
            }
            break;
    }

    Console.WriteLine("Games: {games1}:{games2}, Points: {points1}:{points2}" + games);

    if ((points1 + points2) % 2 == 0)
    {
        if (service == 1) { service = 2; }
        else { service = 1; }
    }
}
while (scorer != "q" && games1 != games && games2 != games);

if (scorer != "q")
{
    int winner = 0;
    if (games1 == games) {winner = 1;}
    else {winner = 2;}
    Console.WriteLine("player {winner}, you are the winner!" + winner);
}

