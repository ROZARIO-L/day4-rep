using system;
Class4 obj = new Class4();
int exitkey=1;
while (exitkey>0)
{
Console.WriteLine("You want to exit ? Y/N");
string choice = Console.ReadLine();
if (choice.ToLower() == "n")
{
obj.InputX();
choice = Console.ReadLine();
}
else
{
break;
}
}
Console.ReadLine()