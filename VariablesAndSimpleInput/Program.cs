
int age;
age = 10;

int anotherAge = 85;

int number1, 
    number3, 
    number4 = 10;

int x = 13;

float someOtherFloatingPointNotation = 85.59F;
double someFloatingPointNotation = 85.59;
decimal someFloatingPointForMoney = 125.98M;
bool someName = false;
char someSingleLetterNoticeTheQuotes = 'L';

const double TAX_RATE = 0.095;

decimal total = someFloatingPointForMoney;

int someTotal = 1 + 1 + 1;


System.Console.Write("What is your first name? ");
string firstName = Console.ReadLine();

System.Console.Write("What is your last name? ");
string lastName = Console.ReadLine();

System.Console.WriteLine("Your name is " + firstName + " " + lastName);

System.Console.WriteLine($"Your name is {firstName} {lastName}");




//This is a comment... Meaning the compiler ingornes this line of code.

//What if I want to store a number? How would I do this??


System.Console.Write("Provide me a whole number! ");
int userDefinedWholeNumber = Convert.ToInt32(Console.ReadLine()); 

/*
System.Console.Write("Provide me a decimal number! ");
double userDefinedDecimal = Convert.ToDouble(Console.ReadLine());
*/

//char letter = Console.ReadLine()[0];

//Lets add 5 to the number
userDefinedWholeNumber = userDefinedWholeNumber + 5;

userDefinedWholeNumber += 5;

//Whoops! Too many fives take away a 5
userDefinedWholeNumber -= 5;

//Lets add 1!
userDefinedWholeNumber += 1;

++userDefinedWholeNumber;

//--userDefinedWholeNumber;



//Lets add 5, then divide by 6 and show the answer.

System.Console.WriteLine((userDefinedWholeNumber + 5) / 6);




