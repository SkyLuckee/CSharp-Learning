// Methods / functions

static void MyMethod() // defined by name + ()
{
    // static means that the method belongs to the Program class and not an object of the Program class
    // normally, methods are tied to objects so the static keyword is used to create methods that are not tied to objects

    // void means that this method does not have a return value
    Console.WriteLine("Hello");
}
MyMethod(); // calling the method by its name + ()

// Information can be passed to methods as parameter.
static void Name(string fname, int age)
{
    Console.WriteLine(fname + " Refsnes" + age);
}
Name("Liam",21);

// Default parameter values
static void Nation(string country = "Norway") // if no argument is provided, the default value will be used
{
    Console.WriteLine(country);
}
Nation(); // will print "Norway")

// Return values from methods
static int Sum(int x) // replace the void keyword with the type of value you want to return (in this case int)
{
    return 5 + x;
}
var z = Sum(6); // will return 11
Console.WriteLine(z);

// Method overloading
// With method overloading, multiple methods can have the same name with different parameters
//static int PlusMethod(int x, int y)
//{
//    return x + y;
//}
//static double PlusMethod(double x, double y)
//{
//    return x + y;
//}

//int myNum1 = PlusMethod(8, 5);
//double myNum2 = PlusMethod(4.3, 6.26);

//Console.WriteLine("Int: " + myNum1);
//Console.WriteLine("Double: " + myNum2);