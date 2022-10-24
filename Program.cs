

//int is used to store the number
int result;
bool playAgain = true;
string decision;
while(playAgain == true)
{
Console.WriteLine("Please enter a number.");
//number will be converted here
result = Convert.ToInt32(Console.ReadLine());
//the entered number will be shown here as an even number
if(result % 2 == 0)
{
    Console.WriteLine($"{result} is an even number.");
}
else
{
    //if number isn't even it will be odd
    Console.WriteLine($"{result} is an odd number.");
}
 Console.WriteLine("Would you like to try again?Type Y to try again or N to end.");
    decision = Console.ReadLine().ToUpper();
    //if the user wanted to try again, pressing "Y" will send them to the beginning
 if(decision == "Y")
    {
      playAgain = true;
    }
    else if(decision == "N")
    {
      //if the user wanted to stop pressing "N" will end the program
      playAgain = false;
    }
    else
    {
        Console.WriteLine("Please pick a valid option.");
    }
}
