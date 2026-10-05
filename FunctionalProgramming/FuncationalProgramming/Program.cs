// int someWholeNumber = 5;

// double somePartOfAWholeNumber = 5.9;
// decimal iAmMoney = 78.99M;

using System.Linq.Expressions;

string name = "Matt,David,Steve";

// System.Console.WriteLine(name.Length);
string[] names = name.Split(',');

// char[] nameAsLetters = {'M', 'a', 't', 't'};

// int[] numbers = new int[5];

// numbers[0] = 15;
// numbers[1] = 78;
// numbers[2] = 25;
// numbers[3] = 36;
// numbers[4] = 75;
// numbers[5] = 6987;

// char[] letters = new char[5];
// string[] namesAgain = new string[5];


// System.Console.WriteLine(names[0]);
// System.Console.WriteLine(names[1]);
// System.Console.WriteLine(names[names.Length - 1][0]);


// System.Console.WriteLine(name.ToUpper());






// List<char> listOfCharacters = new List<char>();


// System.Console.WriteLine(nameAsLetters.Length);

// char aSingleLetter = 'A';

// bool somethingTrueOrFalse = true;

//Random r = new Random();

//Example Running Program
//
System.Console.Write("How many grades do you have to average? ");
int numberOfGradesToAverage = Convert.ToInt32(Console.ReadLine());
int[] grades = new int[numberOfGradesToAverage];

for(int i = 0; i < grades.Length; i++)
{
    System.Console.Write("Give me your grade. ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
   
}

int sum = SumAnArray(grades);

double average = Average(sum, grades.Length);

System.Console.WriteLine(average);


//Code
//DoSomethingButDontReturnAnything("This is a message", 8, names);
//DoSomethingButDontReturnAnything("This is a another message", 8, "Emily,Tina,Samantah, sally".Split(','));

//int sum = Sum(1, 5);
//System.Console.WriteLine(sum);

//Methods 
//header
static void DoSomethingButDontReturnAnything(string message, int num, string[] stuff)
//body
{
    System.Console.WriteLine(message);
    PrintOutArrayItems(stuff);
    System.Console.WriteLine("You gave a number " + num);
    System.Console.WriteLine("And an array of strings as follows:");
    
    
}

static void PrintOutArrayItems(string[] items)
{
    for(int i = 0; i < items.Length; i++)
    {
        System.Console.WriteLine(items[i]);
    }
    
}

static int Sum(int num1, int num2)
{
    return num1 + num2;
}

static int SumAnArray(int[] numbers)
{
    int sum = 0;

    for(int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[0];
    }

    return sum;
}

static double Average(int numberToAverage, int numberToAverageOn)
{
    return (double)numberToAverage / numberToAverageOn;
}

// static int TheNameOfTheMethod()
// {
    
// }


