//•	Reads an array of integer numbers from the console, separated by single space
//•	Array length will always be even number.
//•	Calculate the average value of the elements in the middle of the array
//•	Print the result formatted to the second digit

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int num1 = numbers[(numbers.Length /2)-1];
int num2 = numbers[(numbers.Length /2) ];
double averageValue = (num1 + num2) / 2.0;
Console.WriteLine($"{averageValue:f2}");

//Console.WriteLine(num1);
//Console.WriteLine(num2);

