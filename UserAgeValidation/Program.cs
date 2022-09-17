// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal vailida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime 
//lähtudes kastaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcom, (mr/ms). [kasuaja perekonnanimi] 

Console.WriteLine("please, slect your gender (m/f):");

char usergender = Char.Parse (Console.ReadLine()); // loeb konsoolist maha andmeid string formaadis
Console.WriteLine("please,select your lastname:");

string userlastName = Console.ReadLine ();
if (usergender == 'm')
{ Console.WriteLine($"Welcome, Mr.{userlastName}!"); }
else if (usergender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userlastName}!");
}
else
{
    Console.WriteLine($"welcome, {userlastName}!"); 
}
    

