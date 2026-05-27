/*if (condition1) 
{
    block of code to be executed if condition1 is True
}
else if (condition2) 
{
    block of code to be executed if condition1 is False and condition2 is True
}
else
{
    block of code to be executed if neither condition is True
}
*/

int n = Convert.ToInt32(Console.ReadLine());
if (n%2 == 0)
{
    Console.WriteLine($"{n} is a even number");
}
else if (n % 2 == 1)
{
    Console.WriteLine($"{n} is a odd number");
}
else
{
    Console.WriteLine($"{n} is not a valid number");
}

// Short Hand If...Else (Ternary Operator)
// variable = (condition) ? expressionTrue :  expressionFalse;
string result = (n % 2 == 0) ? $"{n} is a even number" : $"{n} is a odd number";
Console.WriteLine(result);