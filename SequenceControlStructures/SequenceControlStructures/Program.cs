
// //define the variables we need
// double length;
// double width;
// double area;

// //Input of what we want to calculate
// Console.Write("Give me the length of the rectangle. ");
// length = Convert.ToDouble(Console.ReadLine());

// Console.Write("Give me the width of the rectangle. ");
// width = Convert.ToDouble(Console.ReadLine());

// // Processing
// area = length * width;

// System.Console.WriteLine($"The area of a rectangle with a length: {length} and a width: {width} is {area}.");



// // System.Console.WriteLine("Thanks for that! Next we will get some numbers and do some math around it!");

// int num1;
// int num2;
// int num3;
// int num4;

// System.Console.Write("Give me a num! ");
// num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Give me a num! ");
// num2 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Give me a num! ");
// num3 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Give me a num! ");
// num4 = Convert.ToInt32(Console.ReadLine());

 //How do you square a number?

// System.Console.WriteLine(num1 * num1);

// Console.WriteLine(Math.Sqrt(num1));

// System.Console.WriteLine(Math.Pow(num1, 3));

// System.Console.WriteLine(Math.Ceiling(4.1));
// System.Console.WriteLine(Math.Floor(4.8));
// System.Console.WriteLine(Math.Round(4.4));

// Random r = new Random();


// while(true)
//     System.Console.WriteLine(r.Next());

// double num1 = 6;

// int num2 = 25;


// int num3 = 2;

// double answer = (num1 + num2) * num3 / num1 + num2 * num3 + Math.Pow(num1, 3) - 4;

// System.Console.WriteLine(56467896 % 2);


//string name = "Mathew ";

// char[] letters = new char[6];

// letters[0] = 'M';
// letters[1] = 'a';
// letters[2] = 't';
// letters[3] = 'h';
// letters[4] = 'e';
// letters[5] = 'w';

// System.Console.WriteLine(name.ToUpper());

// System.Console.WriteLine(name[name.Length - 1]);

//name = name.Replace("Mathew", "Timmy").Trim().ToLower();

//System.Console.WriteLine($"Hello my name is {name}!");
// //System.Console.WriteLine("Hello my name is " + name.Trim() + "!");

// char middleIntial;

// System.Console.Write("Give me your middle inital! ");
// middleIntial = Console.ReadLine()[0];
// name = "Sally";

// name = "Sally";

//This is illegal as strings are immutable
//name[0] = 'A';

Random r = new Random();

string abc = "abcdefghijklmnopqrstuvwxyz";


string randomWord = "";

randomWord += abc[r.Next(0, 26)];
randomWord += abc[r.Next(0, 26)];
randomWord += abc[r.Next(0, 26)];
randomWord += abc[r.Next(0, 26)];
randomWord += abc[r.Next(0, 26)];
randomWord += abc[r.Next(0, 26)];
randomWord += abc[r.Next(0, 26)];
randomWord += abc[r.Next(0, 26)];
randomWord += abc[r.Next(0, 26)];

System.Console.WriteLine(randomWord);


System.Console.WriteLine("Hello! my name is Mathew!\n");
//escape characters
System.Console.WriteLine("The \trandom word generated is! \"" + randomWord +"\"\a");

// for(int i = 0; i < 500; i++)
// {
//     //randomWord = randomWord + abc[r.Next(0, 26)];
//     randomWord += abc[r.Next(0, 26)];
//     randomWord += abc[r.Next(0, 26)];
//     randomWord += abc[r.Next(0, 26)];
//     System.Console.WriteLine(randomWord);
//     randomWord = "";
// }
