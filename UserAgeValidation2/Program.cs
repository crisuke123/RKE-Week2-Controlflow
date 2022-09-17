
// Rakendus küsib kasutajal sisestada tema vanus 
//kui kasutaja vanus on noorem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//Muul juhul 
//konsoolis kuvatakse "welcome to Instagram"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();
int userAgeNum = 0;
bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine($"Parse result {isAgeNumber}. User Is {userAgeNum} years old.");
if (isAgeNumber)
{ 
 if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcom to Instagram!");
    }

    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("could not read your age.");
}


