// Strings methods
using System.Runtime.CompilerServices;

string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length); // Length of the string
Console.WriteLine(txt.ToUpper()); // Convert to uppercase
Console.WriteLine(txt.ToLower()); // Convert to lowercase

string firstName = "John ";
string lastName = "Doe";
string name = string.Concat(firstName, lastName); // concatenate strings
Console.WriteLine(name);

// format strings
string fullName = $"Full name: {firstName}{lastName}";
Console.WriteLine(fullName);

// Accessing characters in a string
Console.WriteLine(fullName[2]);
Console.WriteLine(fullName.IndexOf("n")); // Find the index of the first occurrence of "n"

//Substring - Extract a portion of the string based on the starting index and length
// Location of the letter D
int charPos = name.IndexOf("D");

// Get last name
string lastName1 = name.Substring(charPos);
Console.WriteLine(lastName1);

// Escaping characters
/* \n - New line
   \t - Tab
   \b - Backspace
   \\ - Backslash
   \' - Single quote
   \" - Double quote
*/