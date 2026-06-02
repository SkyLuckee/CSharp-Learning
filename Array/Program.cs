using System;
using System.Linq;

// Array aka a list
// Declared using a type followed by square brackets
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
int[] myNum = { 10, 20, 30, 40 };

// Accessing the elements of an array using index
Console.WriteLine(cars[0]); // Outputs "Volvo"

// Modifying an element of an array
cars[0] = "Opel";

// Array length
Console.WriteLine(cars.Length);

// other way to declare an array
// Create an array of four elements, and add values later
string[] cars1 = new string[4];

// Create an array of four elements and add values right away 
string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

// Create an array of four elements without specifying the size 
string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };

//declaring array and then initializing it later
string[] cars5;
cars5 = new string[] { "Volvo", "BMW", "Ford", "Mazda" }; // have to use new keyword when initializing an array after declaration

// Array methods
// Sorts the elements of an array in alphabetical order or ascending order
Array.Sort(cars);
foreach (string i in cars)
{
    Console.WriteLine(i);
}

Array.Sort(myNum);
foreach (int i in myNum)
{
    Console.WriteLine(i);
}

// Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace
//using System;
//using System.Linq;
int[] myNumbers = { 5, 1, 8, 9 };
Console.WriteLine(myNumbers.Max());  // returns the largest value
Console.WriteLine(myNumbers.Min());  // returns the smallest value
Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

// Multidimensional arrays
int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } }; // [,] -> 2D array, [,,] -> 3D array, etc.

// accessing elements of a multidimensional array
Console.WriteLine(numbers[0,2]); // Output: 2

numbers[0, 0] = 5;  // Change value to 5
Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

// looping through a multidimensional array
foreach (int i in numbers)
{
    Console.WriteLine(i);
}