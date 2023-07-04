//string name = "Bob";
//if (name.StartsWith("B"))
//{
//    Console.WriteLine("The name starts with 'B'!");
//}
string [] SuspectIDs = {"B123" , "C234", "A345", "C15", "B177", "3003", "C235", "B179"};
string prefix = "B";
{
    foreach (string fraudulentsIDs in SuspectIDs)
    if (fraudulentsIDs.StartsWith(prefix))
    {
        Console.WriteLine($"This is the fraudulents Ids: {fraudulentsIDs}");
    }
}


//Dica do shaka
SuspectIDs.All(x => x.StartsWith(prefix));
