
outTheLowestAndGreatestValuesInArray();


static void searchForElementInArray()
{
    // Search an element in an array.
    int[] arrNumbers = new int[55];
    int arrCount, numberForSearch, index = 0;
    bool isFound = false;

    Console.Write("Please, Enter count of number: ");
    arrCount = int.Parse(Console.ReadLine());

    Console.WriteLine($"Please, {arrCount} number: ");

    for (index = 0; index < arrCount; index++)
    {
        arrNumbers[index] = int.Parse(Console.ReadLine());
    }

    Console.Write("Please, Enter the number to search about it: ");
    numberForSearch = int.Parse(Console.ReadLine());

    for (index = 0; index < arrCount; index++)
    {
        if (arrNumbers[index] == numberForSearch)
        {
            isFound = true;
            Console.WriteLine($"{numberForSearch} is found at index {index}.");
        }
    }

    if (!isFound)
    {
        Console.WriteLine($"{numberForSearch} isn't in our array");
    }
}

static void countAllEventNumberInArray()
{
    int[] arrNumbers = new int[55];
    int arrCount, index, countOfEvenNumber = 0;

    Console.Write("Please, Enter number of array elements: ");
    arrCount = int.Parse(Console.ReadLine());

    Console.Write($"Please, Enter {arrCount} element: ");

    for (index = 0; index < arrCount; index++)
    {
        arrNumbers[index] = int.Parse(Console.ReadLine());

        if (arrNumbers[index] % 2 == 0 ) 
            countOfEvenNumber++;

    }

    Console.WriteLine($"Count of event element in the array is: {countOfEvenNumber} element");

}

static void outTheTwoMinimumValueInArray()
{
    int arrCount, index = 0;

    Console.Write("Please, Enter number of array elements: ");
    arrCount = int.Parse(Console.ReadLine());

    int[] arrNumbers = new int[arrCount];

    Console.WriteLine($"Please, Enter {arrCount} element: ");

    for (index = 0; index < arrCount; index++)
    {
        arrNumbers[index] = int.Parse(Console.ReadLine());
    }

    Array.Sort(arrNumbers);

    foreach(int i in arrNumbers )
    {
        Console.WriteLine(i);
    }

    Console.WriteLine($"First minimum value is {arrNumbers[0]} and the secand value is {arrNumbers[1]}.");

}

static void outTheLowestAndGreatestValuesInArray()
{
    int arrCount, index = 0;

    Console.Write("Please, Enter number of array elements: ");
    arrCount = int.Parse(Console.ReadLine());

    int[] arrNumbers = new int[arrCount];

    Console.WriteLine($"Please, Enter {arrCount} element: ");

    for (index = 0; index < arrCount; index++)
    {
        arrNumbers[index] = int.Parse(Console.ReadLine());
    }

    Array.Sort(arrNumbers);

    Console.WriteLine($"First minimum value is {arrNumbers[0]} and the greatest value is {arrNumbers[arrCount - 1]}.");

}