// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string[] friends = new string[5];
friends[0] = "Mahmoud";
friends[1] = "Mohamed";
friends[2] = "Ahmed";
friends[3] = "Taiseer";
friends[4] = "Hager";

friends.Print();

string[] childern = new string[5]
{
    "Mahmoud", "Mohamed", "Ahmed", "Taiseer", "Hager"
};

childern.Print();

string[] arr = 
{
    "Mahmoud", "Mohamed", "Ahmed", "Taiseer", "Hager"
};

arr.Print();

var folks = new string[5]
{
    "Mahmoud", "Mohamed", "Ahmed", "Taiseer", "Hager"
};

folks.Print();

var sliceRange = 1..3;

folks[1..^2].Print();


//Multi Dim:
int[,] suduko =
{
    {1, 2, 3, 4 },
    {2, 3, 4, 5 }
};


// Jagged array
var jagged = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 2, 3 },
    new int[] { 3, 4, 5 }
};

// Bounds check

public static class Extensions
{
    public static void Print<T>(this T[] source)
    {
        if(!source.Any())
        {
            Console.WriteLine("{}");
            return;
        }

        Console.Write("{ ");
        for(var i = 0; i <= source.Length - 1; i++)
        {
            Console.Write(source[i]);
            Console.Write(i < source.Length - 1 ? ", " : "");
        }
        Console.WriteLine(" }");
    }
}