// There is a thing about double.

// Setup
double doubleValue = 0.3;
double myDouble = 0;
const int iterator = 10000000;


// Addition
for (int i = 0; i < iterator; i++)
{
    myDouble += doubleValue;
}

Console.WriteLine("Added: " + myDouble);

// Reset
doubleValue = 0.3;
myDouble = 0;

// Multiplication
myDouble = doubleValue * iterator;

Console.WriteLine("Multiplied: " + myDouble);
Console.WriteLine("See the following on StackOverflow: https://stackoverflow.com/questions/3730019/why-not-use-double-or-float-to-represent-currency");