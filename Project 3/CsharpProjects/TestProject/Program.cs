/*
    This Code gona make a messages became for the first str mensage to arrey
    and identify this messages to separete the word contain o's and convert
    to string again, after this we have the elements printed in our console.
*/

string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage) { if (i == 'o') { x++; } }
string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");