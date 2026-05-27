#region Variables
// int: whole numbers
// double: decimal numbers
// char: single characters
// string: text
// bool: true or false

// Declaration and initialization of variables
// type variableName = value;
int age = 25;
Console.WriteLine(age);

bool isStudent = true;
Console.WriteLine(isStudent);

// You can also declare a variable without assigning the value, and assign the value later:
string name;
name = "Alice";
Console.WriteLine(name);

// if you assign a new value to an existing variable, it will overwrite the previous value
age = 30;
Console.WriteLine(age);

// You can also declare multiple variables of the same type in one line
int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);

// You can also assign the same value to multiple variables in one line
int a, b, c;
a = b = c = 3;
Console.WriteLine(a+b+c);
#endregion


#region Constants
// Constants are variables that cannot be changed after they are assigned a value
const int myNum = 15;
#endregion