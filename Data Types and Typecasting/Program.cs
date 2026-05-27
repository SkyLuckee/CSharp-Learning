#region Data types
/*  Data Type           Size	        Description
    int         4 bytes	                Whole numbers from -2^31 to 2^31-1
    long L	    8 bytes	                Whole numbers from -2^63 to 2^63-1
    float F	    4 bytes	                Fractional numbers. storing 6 to 7 decimal digits
    double	    8 bytes	                Fractional numbers. storing 15 decimal digits
    bool	    1 byte	                true or false values
    char	    2 bytes	                Stores a single character/letter, surrounded by single quotes
    string	    2 bytes / character	    Stores a sequence of characters, surrounded by double quotes
 */

//When declaring a long or a float, use the suffixes L and F respectively
float num =1.5555F;
long num2 = 9223372036854775807L;
Console.WriteLine(num);
Console.WriteLine(num2);
/* otherwise the compiler will treat it as a int and a double respectively,
 and you will get a compilation error
*/
#endregion

#region Typecasting
// Casting
// Implicit casting (automatically) - converting a smaller type to a larger type size
int small = 0;
double small2 = small; // int to long
Console.WriteLine(small);
Console.WriteLine(small2);

// Explicit casting (manually) - converting a larger type to a smaller size type
float big = 1.5555F;
int big2 = (int)big; // double to int
Console.WriteLine(big);
Console.WriteLine(big2);

// Parsing - converting a string to a numeric type (int, double, etc.)
int num3 = int.Parse("2");
Console.WriteLine(num3.GetType());

// Conversion - converting anything to anything else, including custom types (classes, structs, etc.)
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
#endregion