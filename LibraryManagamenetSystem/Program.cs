using LibraryManagamenetSystem;

using System.Runtime.InteropServices;




///Add Menu

Console.WriteLine("Hello, here you can manage books. Here are the options you can do");
Console.WriteLine("\n 1 - add new book \n 2 - see all available books \n 3 - search book by title");

UserInterface userInteractive = new UserInterface();
int userInput = userInteractive.ParseUserInput();

if (userInput == 1)
{
    userInteractive.AskUserToCreateBooks();

}
else if (userInput == 2)
{
    Console.WriteLine(2);
}
else if (userInput == 3)
{
    Console.WriteLine(3);
}

