// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Logical And &&
//Console.WriteLine(true || true);    // true
//Console.WriteLine(true && false);   // false
//Console.WriteLine(false && true);   // false
//Console.WriteLine(false && false);  // false


// Logical OR ||
//Console.WriteLine(true || true);    // true
//Console.WriteLine(true || false);   // true
//Console.WriteLine(false || true);   // true
//Console.WriteLine(false || false);  // false

// Logical XOR ^ 
//Console.WriteLine(true ^ true);     // false
//Console.WriteLine(true ^ false);    // true
//Console.WriteLine(false ^ true);    // true
//Console.WriteLine(false ^ false);   // false

// Example


// Input
var isFirstFive = true;
var GPA = 3.4;

// Operation
var isElegibleToScholarShip = GPA >= 3.5 && isFirstFive;

// Output
Console.WriteLine($"isElegibleToScholarShip: {isElegibleToScholarShip}");