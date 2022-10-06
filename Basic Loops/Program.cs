
// Do-While "Hello World"

bool playAgain;
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    string userInput = Console.ReadLine();
    playAgain = userInput.ToLower() == "y";
} while (playAgain == true);

// for loop

bool playAgain;
do
{
    Console.WriteLine("Hello. Please enter a number.");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    for (int i = userNumber; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    for (int j = 0; j <= userNumber; j++)
    {
        Console.WriteLine(j);
    }

    Console.WriteLine("Would you like to continue? (y/n)");
    string userInput = Console.ReadLine();
    playAgain = userInput.ToLower() == "y";
} while (playAgain == true);

// Door Combination (While Loop)

int accessCode = 13579;
int userInput = 0;
int userAttempts = 0;

while (userAttempts++ < 5)
{
    Console.WriteLine("Access code needed to enter secure area. You will be locked out after 5 unsuccessful atttempts.");
    userInput = Convert.ToInt32(Console.ReadLine());

    if (userInput == accessCode)
    {
        Console.WriteLine("Access granted. Please enter and secure the door behind you.");
        break;
    }

    else if (userAttempts == 5)
    {
        Console.WriteLine("ACCESS DENIED. You have reached the max number of attempts to open this door.");
    }

    else
    {
        Console.WriteLine("CODE REJECTED. Please enter the correct code.");
    }
}
}

// Combo Code (Do-While Loop)

int accessCode = 13579;
int userInput = 0;
int userAttempts = 0;

do
{

    while (userAttempts++ < 5)
    {
        Console.WriteLine("To open this door, enter the correct access code. You have 5 tries.");
        userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput == accessCode)
        {
            Console.WriteLine("ACCESS GRANTED");
            break;
        }

        else if (userAttempts == 5)
        {
            Console.WriteLine("ACCESS DENIED. You have used up all your attempts.");
            break;
            
        } 
        else
        {
            Console.WriteLine("That code is incorrect. Please try again.");
        }
    } break;

} while (userInput != accessCode);

