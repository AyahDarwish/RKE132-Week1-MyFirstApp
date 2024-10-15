//This is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//string - sõne
string UserName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + UserName + "!");

//string interpolation
Console.WriteLine($"Hello, {UserName} !");