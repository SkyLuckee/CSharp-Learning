// While 
/*
     while (condition)
     {
          Code to execute as long as the condition is true
     }
*/

int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

// Do While - While loop but in reverse
/*
      do 
    {
        Code to execute
    }
    while (condition);
*/
int j = 0;
do
{
    Console.WriteLine(j);
    j++;
}
while (j < 5);
// The code block will be executed at least once even if the condition is false
// because the condition is evaluated after the code block is executed.


// For loop
/*
     for (statement 1; statement 2; statement 3) 
    {
      code block to be executed
    }
*/
//Statement 1 is executed (one time) before the execution of the code block.
//Statement 2 defines the condition for executing the code block.
//Statement 3 is executed (every time) after the code block has been executed.
for (int a = 0; a < 5; a++)
{
    Console.WriteLine(a);
}

// foreach loop - used to iterate through a collection of items
/*
     foreach (type variableName in arrayName) 
    {
      // code block to be executed
    }
*/
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string b in cars)
{
    Console.WriteLine(b);
}

// Break and continue statements
// Break statement can be used to jump out of a loop or switch statement

// continue statement can be used to skip the current iteration of a loop and continue with the next iteration