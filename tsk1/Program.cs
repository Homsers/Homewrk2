Console.WriteLine("Enter a number from 100 to 999");
int number0 = int.Parse(Console.ReadLine());
int number1 = number0 % 10;
int number2 = number0 / 100;
int number3 = number0 % 100;
int number4 = number3 / 10;
int result = number2 * 10 + number1;
Console.WriteLine($"Number {result} from {number0}, second digit was {number4}");